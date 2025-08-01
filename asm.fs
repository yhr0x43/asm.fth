0
    1 cells +Field s.addr
    1 cells +Field s.size
    1 cells +Field s.cap
Constant sbuffer

: >pow2 ( n -- pow2 )
    -1
    BEGIN 2dup and WHILE
            1 lshift
    REPEAT
    1 rshift and 1 lshift ;

: s-@ ( s-addr -- addr u )
    dup  s.addr @
    swap s.size @ ;

: s-reserve ( s-addr u -- )
    over s.size @ + tuck ( n s-addr n )
    over s.cap  @
    > IF ( n s-addr )
        tuck s.addr @   ( s-addr n a-addr )
        swap >pow2 tuck ( s-addr pow2 a-addr pow2 )
        resize throw
        2 pick s.addr !
        swap s.cap !
    ELSE
        2drop
    THEN ;

: s-! ( addr u s-addr -- )
    0 allocate throw over s.addr !
    0 over s.cap !
    0 over s.size !
    2dup swap s-reserve
    2dup s.size +!
    s.addr swap move ;

: s-? ( s-addr -- )
    dup s.addr ?
    dup s.size ?
    s.cap ? ;

: s-append ( s-addr n -- a-addr )
    2dup s-reserve over s-@ + >r swap s.size +! r> ;

: s-db ( x s-addr -- )
    1 s-append c! ;

: s-dw ( x s-addr -- )
    2 s-append w! ;

: s-dd ( x s-addr -- )
    4 s-append l! ;

: s-d! ( x s-addr -- )
    1 cells s-append ! ;

: s-ds ( addr u s-addr -- )
    over s-append swap move ;

wordlist Constant xrefs-wl
wordlist Constant xvals-wl

0
    1 cells +Field xrefcell.last
    1 cells +Field xrefcell.xt
    1 cells +Field xrefcell.offset
Constant xrefcell

: xref ( name-addr name-u x xt! -- )
    2>r
    2dup xvals-wl search-wordlist
    0<> IF				\ when value exists, just deposit the value
        2drop
        2r> >body @ swap rot execute
    ELSE				\ otherwise, append a cell to the linked list in xrefs-wl
        2dup nextname
        xrefs-wl search-wordlist
        0= IF 0 ELSE >body THEN
        2r> rot
        get-current >r
        xrefs-wl set-current
        Create , , ,
        r> set-current
    THEN ;

: x@val ( addr u -- n )
    xvals-wl search-wordlist
    0= throw
    >body @ ;

: xval ( name-addr name-u n b-addr -- )
    2swap 2dup 2>r
    xrefs-wl search-wordlist
    0<> IF
        >body
        BEGIN ( n b-addr a-addr )
            dup WHILE
                dup dup >r >r >r
                2dup ( n b-addr n b-addr )
                r> xrefcell.offset @ +
                r> xrefcell.xt @
                execute
                r> @
        REPEAT
        2drop
    THEN
    2r> nextname
    get-current >r
    xvals-wl set-current
    Create ,
    r> set-current ;
