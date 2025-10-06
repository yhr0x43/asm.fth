\ Dynamic Array
\ yhr_C 2025-09-03

\ A simple implementation of dynamic array, it uses 'resize' to allocate and
\ expand the buffer as necessary

\ in code-comments, da-addr is a reference to dynamic array

0
    cell +Field da.size
    cell +Field da.cap
    cell +Field da.data
Constant da

: >pow2 ( n -- pow2 )
    -1
    BEGIN 2dup and WHILE
            1 lshift
    REPEAT
    1 rshift and 1 lshift
;

: da-@ ( da-addr -- addr u )
    dup  da.addr @
    swap da.size @
;

: da-reserve ( da-addr u -- )
    over da.size @ + tuck ( n da-addr n )
    over da.cap  @
    > IF ( n da-addr )
        tuck s.addr @   ( da-addr n a-addr )
        swap >pow2 tuck ( da-addr pow2 a-addr pow2 )
        resize throw
        2 pick s.addr !
        swap s.cap !
    ELSE
        2drop
    THEN
;

: da-! ( addr u da-addr -- )
    0 allocate throw over s.addr !
    0 over s.cap !
    0 over s.size !
    2dup swap da-reserve
    2dup s.size +!
    s.addr swap move
;

: da-? ( da-addr -- )
    dup da.addr ?
    dup da.size ?
        da.cap  ?
;

: da-append ( s-addr n -- a-addr )
    2dup da-reserve over da-@ + >r swap da.size +! r>
;
