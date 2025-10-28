require asm.fs
require coff.fs

: .view-sections this_sect @ rfb.xrefs xrefs-? cr ;

hex

refable allocate throw
dup rfb.buffer dynarr-init
dup rfb.xrefs dynarr-init
this_sect !

IMAGE_FILE_MACHINE_AMD64	.dw \ Machine
0001				.dw \ NumberOfSections
3A9DF370			.dd \ TimeDateStamp
s" SymbolTable"			.rd \ PointerToSymbolTable
00000001			.dd \ NumberOfSymbols
0000				.dw \ SizeOfOptionalHeader
0000				.dw \ Characteristics
\ Section 1
s" .text"			.ds 00 .db 00 .db 00 .db
00000000			.dd \ VirtualSize
00000000			.dd \ VirutalAddress
s" sect..text.size"		.rd \ SizeOfRawData
s" sect..text.start"		.rd \ PointerToRawData
00000000			.dd \ PointerToRelocations
00000000			.dd \ PointerToLinenumbers
0000				.dw \ NumberOfRelocations
0000				.dw \ NumberOfLinenumbers
60500020			.dd \ Characteristics

s" SymbolTable" .cur		.equ
00000000			.dd \ zeroes | union w/ ShortName
s" str_main"			.rd \ offset |
00000000			.dd \ Value (offset)
0001				.dw \ SectionNumber
0020				.dw \ Type
IMAGE_SYM_CLASS_EXTERNAL	.db \ StoageClass
00				.db \ NumberOfAuxSymbols

.cur Constant StringTableStart
s" StringTableSize"		.rd \ String table size
\ s" str_WinMainCRTStartup" .cur StringTableStart -	.equ
\ s" WinMainCRTStartup"		.ds 00 .db
s" str_main" .cur StringTableStart -	.equ
s" _start"			.ds 00 .db
s" StringTableSize" .cur StringTableStart -		.equ

s" sect..text.start" .cur	.equ
0EB .db
0FE .db
090 .db
090 .db
0FEEDBEEF .dd

s" sect..text.final" .cur	.equ
s" sect..text.size" .cur s" sect..text.start" .val -	.equ

this_sect @ rfb.buffer dynarr.data @
this_sect @ rfb.xrefs
xrefs-apply

s" pillar-raw.obj" r/w bin create-file throw

this_sect @ rfb.buffer dynarr-@
2 pick write-file throw
close-file throw

bye
