require asm.fs
require coff.fs

: .view-sections this_sect @ sect.xrefs xrefs-? cr ;

hex

s" .text" .sect

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
s" str_WinMainCRTStartup"	.rd \ offset |
00000000			.dd \ Value (offset)
0001				.dw \ SectionNumber
0020				.dw \ Type
IMAGE_SYM_CLASS_EXTERNAL	.db \ StoageClass
00				.db \ NumberOfAuxSymbols

.cur Constant StringTableStart
s" StringTableSize"		.rd \ String table size
s" str_WinMainCRTStartup" .cur StringTableStart -	.equ
s" WinMainCRTStartup"		.ds 00 .db
s" StringTableSize" .cur StringTableStart -		.equ

s" sect..text.start" .cur	.equ
0EB .db
0FE .db
90 .db
90 .db
FEEDBEEF .dd
s" sect..text.final" .cur	.equ
s" sect..text.size" .cur s" sect..text.start" .val -	.equ
.view-sections

Variable fd-out
s" pillar.obj" r/w bin create-file throw fd-out !

this_sect @ sect.buffer dynarr-@
\ out-buf s-@
fd-out @ write-file throw
fd-out @ close-file throw

bye
