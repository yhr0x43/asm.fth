require asm.fs

sbuffer allocate throw Constant out-buf
0 0 out-buf s-!

: .db ( c -- )      out-buf s-db ;
: .dw ( w -- )      out-buf s-dw ;
: .dd ( u -- )      out-buf s-dd ;
: .ds ( addr u -- ) out-buf s-ds ;

: .cur ( -- u )    out-buf s.size @ ;
: .buf ( -- addr ) out-buf s.addr @ ;

: .equ ( addr u n -- ) .buf xval ;
: .val ( addr u -- n ) x@val ;
: .rb ( addr u -- ) .cur ['] c! xref 0 .db ;
: .rw ( addr u -- ) .cur ['] w! xref 0 .dw ;
: .rd ( addr u -- ) .cur ['] l! xref 0 .dd ;
: $ [char] $ parse ;

require coff.fs

hex
IMAGE_FILE_MACHINE_AMD64	.dw \ Machine
0001				.dw \ NumberOfSections
3A9DF370			.dd \ TimeDateStamp
$ SymbolTable$			.rd \ PointerToSymbolTable
00000001			.dd \ NumberOfSymbols
0000				.dw \ SizeOfOptionalHeader
0000				.dw \ Characteristics
\ Section 1
s" .text"			.ds 00 .db 00 .db 00 .db
00000000			.dd \ VirtualSize
00000000			.dd \ VirutalAddress
$ sect..text.size$		.rd \ SizeOfRawData
$ sect..text.start$		.rd \ PointerToRawData
00000000			.dd \ PointerToRelocations
00000000			.dd \ PointerToLinenumbers
0000				.dw \ NumberOfRelocations
0000				.dw \ NumberOfLinenumbers
60500020			.dd \ Characteristics

$ SymbolTable$ .cur		.equ
00000000			.dd \ zeroes | union w/ ShortName
$ str_WinMainCRTStartup$	.rd \ offset |
00000000			.dd \ Value (offset)
0001				.dw \ SectionNumber
0020				.dw \ Type
IMAGE_SYM_CLASS_EXTERNAL	.db \ StoageClass
00				.db \ NumberOfAuxSymbols

.cur Constant StringTableStart
$ StringTableSize$		.rd \ String table size
$ str_WinMainCRTStartup$ .cur StringTableStart -	.equ
s" WinMainCRTStartup"		.ds 00 .db
$ StringTableSize$ .cur StringTableStart -		.equ

$ sect..text.start$ .cur	.equ
0EB .db
0FE .db
90 .db
90 .db
FEEDBEEF .dd
$ sect..text.final$ .cur	.equ
$ sect..text.size$ .cur $ sect..text.start$ .val -	.equ

Variable fd-out
s" pillar.obj" r/w bin create-file throw fd-out !

out-buf s-@
fd-out @ write-file throw
fd-out @ close-file throw

out-buf s.addr
free

bye