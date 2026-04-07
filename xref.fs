\ xref.fs - provide named reference to a offset in a dynarr

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
    xrefs.data dynarr-range
    ?DO
        i xrefl-? cr
    xrefl +LOOP
;

: xrefl-init ( name-addr name-u xrefl-addr -- )
    dup  xrefl.value    0 swap !
    dup  xrefl.data     dynarr-init
    2dup xrefl.name-len c!
    xrefl.name swap cmove
;

: xrefl-new ( name-addr name-u xrefs-addr -- xrefl-addr )
    xrefs.data xrefl dynarr-append
    dup >r xrefl-init r>
;

: xrefl= ( xrefl1-addr xrefl2-addr -- f )
    dup  xrefl.name
    swap xrefl.name-len c@
    rot
    dup  xrefl.name
    swap xrefl.name-len c@
    compare 0=
;

: xrefl-find ( name-addr name-u xrefs-addr -- xrefl-addr | 0 )
    over 20 > IF
        ABORT" symbol name longer than 20h not supported"
    THEN
    >r \ xref-addr
    \ FIXME: assumed CS is DS, is this assumption true?
    AHEAD [ here >r xrefl allot ] THEN [ r> ] literal \ pad
    dup >r
    xrefl-init
    r> \ pad
    r> \ xrefs-addr
    ['] xrefl= xrefl dynarr-find
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
        nip nip nip
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
    3 roll 3 roll rot ( val-n name-addr name-u xrefs-addr )
    xrefl-ensure
    swap over xrefl.value !
    xrefl.assigned 1 swap c!
;

: xgetval ( name-addr name-u xrefs-addr -- val-u )
    xrefl-find ?dup 0= IF ABORT" undefined symbol" THEN
    xrefl.value @
;

base !
