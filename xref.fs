\ xref.fs - provide named reference to a offste in a dynarr
\ Typical Usage:
\

require dynarr.fs

base @
hex

0
    cell +Field xrefp.xt     \ ! xt ( addr x -- )
    cell +Field xrefp.offset \ addr = base + offset
Constant xrefp \ xref pair

0
    20 chars  +Field xrefl.name  \ TODO: symbol name length limit at 20hex
    1  chars  +Field xrefl.name-len
    1 aligned +Field xrefl.assigned
    cell      +Field xrefl.value
    dynarr    +Field xrefl.data  \ array of xrefp
Constant xrefl \ xref list

0
    dynarr +Field xrefs.data
Constant xrefs \ array of xrefl (xref plural)

: xrefl-? ( xrefl-addr -- )
    dup . ." : "
    dup  xrefl.name
    over xrefl.name-len c@
    [char] " emit
    type
    [char] " emit
     ."  = "
    dup xrefl.value ?
    xrefl.data  dynarr-range
    ?DO
        cr ."     "
        i xrefp.xt ?
        i xrefp.offset ?
    xrefp +LOOP
;

: xrefs-? ( xrefs-addr -- )
    ." xrefs:" cr
    dynarr-range
    ?DO
        i xrefl-? cr
    xrefl +LOOP
;

: xrefl-new ( name-addr name-u xrefs-addr -- xrefl-addr )
    xrefs.data xrefl dynarr-append
    >r
    dup r@ xrefl.name-len c!
    r@ xrefl.name swap move
    0 r@ xrefl.value !
    r@ xrefl.data dynarr-init
    r>
;

: xrefl-find ( name-addr name-u xrefs-addr -- xrefl-addr | 0 )
    over 32 > IF
        ABORT" symbol name longer than 32 not supported"
    THEN
    dynarr-range
    \ for each xrefl in the xrefs
    ?DO
        2dup
        i xrefl.name
        i xrefl.name-len c@
        compare 0= IF 2drop i UNLOOP EXIT THEN
    xrefl +LOOP
    2drop
    0 \ results 0 when xrefl not found
;

: xrefp-new ( offset-n xt xrefl-addr -- xrefp-addr )
    xrefl.data xrefp dynarr-append
    tuck xrefp.xt     !
    tuck xrefp.offset !
;

\ ensures a name exists in the xrefs table
: xrefl-ensure ( name-addr name-u xrefs-addr -- xrefl-addr )
    2 pick 2 pick 2 pick
    xrefl-find
    ?dup 0= IF
        xrefl-new
    ELSE
        >r drop drop drop r>
    THEN
;

: xref ( name-addr name-u offset-n xt xrefs-addr -- )
    rot rot 2>r
    xrefl-ensure
    2r> rot
    xrefp-new
    drop
;

: xrefl-apply ( base-addr xrefl-addr -- )
    dup xrefl.assigned c@
    0= IF
        dup xrefl.name over xrefl.name-len c@ type
        ."  is never assigned" cr
    THEN
    dup xrefl.value @
    swap xrefl.data dynarr-range
    ?DO ( base-addr xrefl-value )
        2dup swap
        i xrefp.offset @ +
        i xrefp.xt @ execute
    xrefp +LOOP
    2drop
;

: xrefs-apply ( base-addr xrefs-addr -- )
    dynarr-range
    ?DO
        dup i xrefl-apply
    xrefl +LOOP
    drop
;

: xval ( name-addr name-u val-n xrefs-addr -- )
    swap >r
    xrefl-ensure dup
    r> swap xrefl.value !
    xrefl.assigned 1 swap c!
;

: xgetval ( name-addr name-u xrefs-addr -- val-u )
    xrefl-find ?dup 0= IF ABORT" undefined symbol" THEN
    xrefl.value @
;

base !
