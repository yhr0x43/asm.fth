\ xref.fs
\ provide named reference to a offste in a dynarr

require dynarr.fs

base @
hex

0
    cell +Field xrefp.xt     \ ! xt ( addr x -- )
    cell +Field xrefp.offset \ addr = base + offset
Constant xrefp \ xref pair

80 Constant xrefl.VALID
1F Constant xrefl.LENGTH

0
    1 aligned +Field xrefl.flag  \ =(valid?VALID:0)|(name_len&LENGTH)
    32 chars  +Field xrefl.name  \ TODO: symbol name length limit at 32
    cell      +Field xrefl.value
    dynarr    +Field xrefl.array \ array of xrefp
Constant xrefl \ xref list

dynarr Constant xrefs \ array of xrefl (xref plural)

: xrefl-new ( name-addr name-u xrefs-addr --  xrefl-addr )
    xrefl dynarr-append
    >r
    dup xrefl.LENGTH and   r@ xrefl.flag   @
                           r@ xrefl.name   cmove
    r>
;

: xrefl-find {: name-addr name-u xrefs-addr -- xrefl-addr :}
    name-u 32 > IF
        0 EXIT
    THEN
    0 \ do loop results 0 when xrefl not found
    xref-addr dynarr.size @
    0
    DO
        drop
        xrefs-addr dynarr.data @ i xrefl * +
        dup  xrefl.name
        swap xrefl.flag xrefl.LENGTH and
        name-addr name-u
        compare 0= IF
            drop xrefs-addr UNLOOP EXIT
        THEN
    LOOP
;

: xrefp-new ( offset-n xt xrefl-addr -- xrefp-addr )
    xrefp dynarr-append
    tuck xrefp.xt     !
    tuck xrefp.offset !
;

: xref {: name-addr name-u offset-n xt xrefs-addr -- :}
    name-addr name-u xrefs-addr xrefl-find
    dup 0= IF drop xrefl-new THEN
    offset-n xt rot xrefp-new
;

: xrefl-apply ( base-addr xrefl-addr -- )
    dup  xrefl.value
    over xrefl.array dup da.size swap da.data +
    rot  xrefl.array da.data
    DO ( base-addr xrefl-value )
        2dup swap
        i xrefp.offset +
        i xrefp.xt !
    xrefp +LOOP
    2drop
;

: xrefs-apply ( base-addr xrefs-addr -- )
    dup  da.data over da.size xrefl * +
    swap da.data
    DO
        dup i xrefl-apply
    xrefl +LOOP
;

base !
