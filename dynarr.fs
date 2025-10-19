\ Dynamic Array
\ yhr_C 2025-09-03

\ A simple implementation of dynamic array, it uses 'resize' to allocate and
\ expand the buffer as necessary

\ in code-comments, da-addr is a reference to dynamic array

0
    cell +Field dynarr.size
    cell +Field dynarr.cap
    cell +Field dynarr.data
Constant dynarr

[UNDEFINED] >pow2 [IF]
: >pow2 ( n -- pow2 )
    -1
    BEGIN 2dup and WHILE
            1 lshift
    REPEAT
    1 rshift and 1 lshift
;
[THEN]

: dynarr-@ ( da-addr -- addr u )
    dup  dynarr.data @
    swap dynarr.size @
;

: dynarr-range ( da-addr -- begin-addr end-addr )
    dup  dynarr-@ +
    swap dynarr.data @
;

: dynarr-init ( da-addr -- )
    dynarr 0 fill
;

: dynarr-recap ( da-addr u -- )
    2dup swap dynarr.cap !
    over dynarr.data @
    ?dup 0= IF allocate ELSE swap resize THEN throw
    swap dynarr.data !
;

: dynarr-reserve ( da-addr u -- )
    over dynarr.size @ + tuck
    over dynarr.cap  @
    > IF ( newcap-u da-addr )
        swap >pow2
        dynarr-recap
    ELSE
        2drop
    THEN
;

: dynarr-append ( da-addr n -- a-addr )
    2dup dynarr-reserve
    over dynarr-@ +
    >r
    swap dynarr.size +!
    r>
;

: dynarr-? ( da-addr -- )
    dup dynarr.data ?
    dup dynarr.size ?
        dynarr.cap  ?
;
