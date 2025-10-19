\ asm.fs - Assembler utils
\ concept of sect is defined here, a sect (section) is the unit of relocation
\ it is also directly tied to PE/ELF sections, where it has datastructure
\ for assembling such sections in practice

base @
hex

require dynarr.fs
require xref.fs

\ TODO: section name longer than 8 chars
0
    8      +Field sect.name
    cell   +Field sect.name-len
    dynarr +Field sect.buffer
    xrefs  +Field sect.xrefs
Constant sect

dynarr allocate throw Constant sect_list
sect_list dynarr-init

: sect-new ( name-addr name-u -- sect-addr )
    sect_list sect dynarr-append
    >r
    dup 8 > IF ABORT" section name must be shorter than 8 chars" THEN
    dup r@ sect.name-len !
    r@ sect.name swap move
    r@ sect.buffer dynarr-init
    r@ sect.xrefs  dynarr-init
    r>
;

Variable this_sect

: .sect ( name-addr name-u -- ) sect-new this_sect ! ;

: .cur ( -- offset-u ) this_sect @ sect.buffer dynarr.size @ ;
: .equ ( name-addr name-u val-u -- ) this_sect @ sect.xrefs xval ;
: .val ( name-addr name-u -- val-u ) this_sect @ sect.xrefs xgetval ;

: .db ( c -- )      this_sect @ sect.buffer 1 dynarr-append c! ;
: .dw ( w -- )      this_sect @ sect.buffer 2 dynarr-append w! ;
: .dd ( u -- )      this_sect @ sect.buffer 4 dynarr-append l! ;
: .ds ( addr u -- ) this_sect @ sect.buffer over dynarr-append swap move ;

: .rb ( c -- ) .cur ['] c! this_sect @ sect.xrefs xref 0 .db ;
: .rw ( c -- ) .cur ['] w! this_sect @ sect.xrefs xref 0 .dw ;
: .rd ( c -- ) .cur ['] l! this_sect @ sect.xrefs xref 0 .dd ;

base !
