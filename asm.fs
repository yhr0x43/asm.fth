\ asm.fs - Assembler utils
\ concept of sect is defined here, a sect (section) is the unit of relocation
\ it is also directly tied to PE/ELF sections, where it has datastructure
\ for assembling such sections in practice

base @
hex

require dynarr.fs
require xref.fs

0
    dynarr +Field rfb.buffer
    xrefs  +Field rfb.xrefs
Constant refable


0
    cell +Field sym.name-addr
    cell +Field sym.name-u
    cell +Field sym.type
Constant symbol

\ TODO: section name longer than 8 chars
0
    refable   +Field sect.rfb
    8 aligned +Field sect.name
    cell      +Field sect.name-len
    dynarr    +Field sect.symbols
Constant sect

dynarr allocate throw Constant sect_list
sect_list dynarr-init

Variable this_sect

: sect-init ( name-addr name-u sect-addr -- )
    over 8 > IF ABORT" section name must be shorter than 8 chars" THEN
    dup rfb.buffer dynarr-init
    dup rfb.xrefs  dynarr-init
    dup sect.name 8 erase
    2dup sect.name-len !
    sect.name swap move
;

: sect-new ( name-addr name-u -- sect-addr )
    sect_list sect dynarr-append
    >r r@ sect-init r>
;

: sect-find ( name-addr name-u -- sect-addr | 0 )
;

: sect-ensure ( name-addr name-u -- sect-addr )
;

: sect-count ( -- n )
    sect_list dynarr.size @ sect /
;

: resolve-all-xrefs ( -- )
    sect_list dynarr-range
    ?DO
        i rfb.buffer dynarr.data @ i rfb.xrefs xrefs-apply
    sect +LOOP
;

: .sect ( name-addr name-u -- ) sect-new this_sect ! ;

: .cur ( -- offset-u ) this_sect @ rfb.buffer dynarr.size @ ;
: .equ ( name-addr name-u val-u -- ) this_sect @ rfb.xrefs xval ;
: .val ( name-addr name-u -- val-u ) this_sect @ rfb.xrefs xgetval ;

\ : .labl ( name-addr name-u -- )
\     ABORT" unimplemented"
\     2dup .cur .equ
\     this_sect sect.symbols symbol dynarr-append
\     r>
\     dup r@ sym.name-len !
\     dup allocate throw r@ sym.name-addr !
\     r@ sym.name-addr @ swap move
\ ;

: .db ( c -- )      this_sect @ rfb.buffer 1 dynarr-append c! ;
: .dw ( w -- )      this_sect @ rfb.buffer 2 dynarr-append w! ;
: .dd ( u -- )      this_sect @ rfb.buffer 4 dynarr-append l! ;
: .ds ( addr u -- ) this_sect @ rfb.buffer over dynarr-append swap move ;

: .rb ( c -- ) .cur ['] c! this_sect @ rfb.xrefs xref 0 .db ;
: .rw ( c -- ) .cur ['] w! this_sect @ rfb.xrefs xref 0 .dw ;
: .rd ( c -- ) .cur ['] l! this_sect @ rfb.xrefs xref 0 .dd ;

base !
