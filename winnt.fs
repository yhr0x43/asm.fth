base @
hex

    5A4D Constant IMAGE_DOS_SIGNATURE
    454E Constant IMAGE_OS2_SIGNATURE
    454C Constant IMAGE_OS2_SIGNATURE_LE
    454C Constant IMAGE_VXD_SIGNATURE
00004550 Constant IMAGE_NT_SIGNATURE

   0 Constant IMAGE_FILE_MACHINE_UNKNOWN
0001 Constant IMAGE_FILE_MACHINE_TARGET_HOST         \ Useful for indicating we want to interact with the host and not a WoW guest.
014c Constant IMAGE_FILE_MACHINE_I386                \ Intel 386.
0162 Constant IMAGE_FILE_MACHINE_R3000               \ MIPS little-endian, 0x160 big-endian
0166 Constant IMAGE_FILE_MACHINE_R4000               \ MIPS little-endian
0168 Constant IMAGE_FILE_MACHINE_R10000              \ MIPS little-endian
0169 Constant IMAGE_FILE_MACHINE_WCEMIPSV2           \ MIPS little-endian WCE v2
0184 Constant IMAGE_FILE_MACHINE_ALPHA               \ Alpha_AXP
01a2 Constant IMAGE_FILE_MACHINE_SH3                 \ SH3 little-endian
01a3 Constant IMAGE_FILE_MACHINE_SH3DSP
01a4 Constant IMAGE_FILE_MACHINE_SH3E                \ SH3E little-endian
01a6 Constant IMAGE_FILE_MACHINE_SH4                 \ SH4 little-endian
01a8 Constant IMAGE_FILE_MACHINE_SH5                 \ SH5
01c0 Constant IMAGE_FILE_MACHINE_ARM                 \ ARM Little-Endian
01c2 Constant IMAGE_FILE_MACHINE_THUMB               \ ARM Thumb/Thumb-2 Little-Endian
01c4 Constant IMAGE_FILE_MACHINE_ARMNT               \ ARM Thumb-2 Little-Endian
01d3 Constant IMAGE_FILE_MACHINE_AM33
01F0 Constant IMAGE_FILE_MACHINE_POWERPC             \ IBM PowerPC Little-Endian
01f1 Constant IMAGE_FILE_MACHINE_POWERPCFP
0200 Constant IMAGE_FILE_MACHINE_IA64                \ Intel 64
0266 Constant IMAGE_FILE_MACHINE_MIPS16              \ MIPS
0284 Constant IMAGE_FILE_MACHINE_ALPHA64             \ ALPHA64
0366 Constant IMAGE_FILE_MACHINE_MIPSFPU             \ MIPS
0466 Constant IMAGE_FILE_MACHINE_MIPSFPU16           \ MIPS
IMAGE_FILE_MACHINE_ALPHA64 Constant IMAGE_FILE_MACHINE_AXP64
0520 Constant IMAGE_FILE_MACHINE_TRICORE             \ Infineon
0CEF Constant IMAGE_FILE_MACHINE_CEF
0EBC Constant IMAGE_FILE_MACHINE_EBC                 \ EFI Byte Code
8664 Constant IMAGE_FILE_MACHINE_AMD64               \ AMD64 (K8)
9041 Constant IMAGE_FILE_MACHINE_M32R                \ M32R little-endian
AA64 Constant IMAGE_FILE_MACHINE_ARM64               \ ARM64 Little-Endian
C0EE Constant IMAGE_FILE_MACHINE_CEE

0001 Constant IMAGE_FILE_RELOCS_STRIPPED             \ Relocation info stripped from file.
0002 Constant IMAGE_FILE_EXECUTABLE_IMAGE            \ File is executable  (i.e. no unresolved external references).
0004 Constant IMAGE_FILE_LINE_NUMS_STRIPPED          \ Line nunbers stripped from file.
0008 Constant IMAGE_FILE_LOCAL_SYMS_STRIPPED         \ Local symbols stripped from file.
0010 Constant IMAGE_FILE_AGGRESIVE_WS_TRIM           \ Aggressively trim working set
0020 Constant IMAGE_FILE_LARGE_ADDRESS_AWARE         \ App can handle >2gb addresses
0080 Constant IMAGE_FILE_BYTES_REVERSED_LO           \ Bytes of machine word are reversed.
0100 Constant IMAGE_FILE_32BIT_MACHINE               \ 32 bit word machine.
0200 Constant IMAGE_FILE_DEBUG_STRIPPED              \ Debugging info stripped from file in .DBG file
0400 Constant IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP     \ If Image is on removable media, copy and run from the swap file.
0800 Constant IMAGE_FILE_NET_RUN_FROM_SWAP           \ If Image is on Net, copy and run from the swap file.
1000 Constant IMAGE_FILE_SYSTEM                      \ System File.
2000 Constant IMAGE_FILE_DLL                         \ File is a DLL.
4000 Constant IMAGE_FILE_UP_SYSTEM_ONLY              \ File should only be run on a UP machine
8000 Constant IMAGE_FILE_BYTES_REVERSED_HI           \ Bytes of machine word are reversed.

0
    2 +Field coff.Machine
    2 +Field coff.NumberOfSections
    4 +Field coff.TimeDateStamp
    4 +Field coff.PointerToSymbolTable
    4 +Field coff.NumberOfSymbols
    2 +Field coff.SizeOfOptionalHeader
    2 +FIeld coff.Characteristics
Constant IMAGE_FILE_HEADER

\ 00000000 Constant IMAGE_SCN_TYPE_REG                   \ Reserved.
\ 00000001 Constant IMAGE_SCN_TYPE_DSECT                 \ Reserved.
\ 00000002 Constant IMAGE_SCN_TYPE_NOLOAD                \ Reserved.
\ 00000004 Constant IMAGE_SCN_TYPE_GROUP                 \ Reserved.
00000008 Constant IMAGE_SCN_TYPE_NO_PAD                  \ Reserved.
\ 00000010 Constant IMAGE_SCN_TYPE_COPY                  \ Reserved.

00000020 Constant IMAGE_SCN_CNT_CODE                     \ Section contains code.
00000040 Constant IMAGE_SCN_CNT_INITIALIZED_DATA         \ Section contains initialized data.
00000080 Constant IMAGE_SCN_CNT_UNINITIALIZED_DATA       \ Section contains uninitialized data.

00000100 Constant IMAGE_SCN_LNK_OTHER                    \ Reserved.
00000200 Constant IMAGE_SCN_LNK_INFO                     \ Section contains comments or some other type of information.
00000400 Constant IMAGE_SCN_TYPE_OVER                    \ Reserved.
00000800 Constant IMAGE_SCN_LNK_REMOVE                   \ Section contents will not become part of image.
00001000 Constant IMAGE_SCN_LNK_COMDAT                   \ Section contents comdat.
\ 00002000 Reserved.
\ 00004000 Constant IMAGE_SCN_MEM_PROTECTED - Obsolete   
00004000 Constant IMAGE_SCN_NO_DEFER_SPEC_EXC            \ Reset speculative exceptions handling bits in the TLB entries for this section.
00008000 Constant IMAGE_SCN_GPREL                        \ Section content can be accessed relative to GP
00008000 Constant IMAGE_SCN_MEM_FARDATA                
\ 00010000 Constant IMAGE_SCN_MEM_SYSHEAP  - Obsolete    
00020000 Constant IMAGE_SCN_MEM_PURGEABLE              
00020000 Constant IMAGE_SCN_MEM_16BIT                  
00040000 Constant IMAGE_SCN_MEM_LOCKED                 
00080000 Constant IMAGE_SCN_MEM_PRELOAD                

00100000 Constant IMAGE_SCN_ALIGN_1BYTES                 \
00200000 Constant IMAGE_SCN_ALIGN_2BYTES                 \
00300000 Constant IMAGE_SCN_ALIGN_4BYTES                 \
00400000 Constant IMAGE_SCN_ALIGN_8BYTES                 \
00500000 Constant IMAGE_SCN_ALIGN_16BYTES                \ Default alignment if no others are specified.
00600000 Constant IMAGE_SCN_ALIGN_32BYTES                \
00700000 Constant IMAGE_SCN_ALIGN_64BYTES                \
00800000 Constant IMAGE_SCN_ALIGN_128BYTES               \
00900000 Constant IMAGE_SCN_ALIGN_256BYTES               \
00A00000 Constant IMAGE_SCN_ALIGN_512BYTES               \
00B00000 Constant IMAGE_SCN_ALIGN_1024BYTES              \
00C00000 Constant IMAGE_SCN_ALIGN_2048BYTES              \
00D00000 Constant IMAGE_SCN_ALIGN_4096BYTES              \
00E00000 Constant IMAGE_SCN_ALIGN_8192BYTES              \
00F00000 Constant IMAGE_SCN_ALIGN_MASK

01000000 Constant IMAGE_SCN_LNK_NRELOC_OVFL              \ Section contains extended relocations.
02000000 Constant IMAGE_SCN_MEM_DISCARDABLE              \ Section can be discarded.
04000000 Constant IMAGE_SCN_MEM_NOT_CACHED               \ Section is not cachable.
08000000 Constant IMAGE_SCN_MEM_NOT_PAGED                \ Section is not pageable.
10000000 Constant IMAGE_SCN_MEM_SHARED                   \ Section is shareable.
20000000 Constant IMAGE_SCN_MEM_EXECUTE                  \ Section is executable.
40000000 Constant IMAGE_SCN_MEM_READ                     \ Section is readable.
80000000 Constant IMAGE_SCN_MEM_WRITE                    \ Section is writeable.

8 Constant IMAGE_SIZEOF_SHORT_NAME
0
    IMAGE_SIZEOF_SHORT_NAME +Field scn.Name
    0 +Field scn.PhysicalAddress    4 +Field scn.VirtualSize
    4 +Field scn.VirtualAddress
    4 +Field scn.SizeOfRawData
    4 +Field scn.PointerToRawData
    4 +Field scn.PointerToRelocations
    4 +Field scn.PointerToLinenumbers
    2 +Field scn.NumberOfRelocations
    2 +Field scn.NumberOfLinenumbers
    4 +Field scn.Characteristics
Constant IMAGE_SECTION_HEADER

\ Section values
       0 Constant IMAGE_SYM_UNDEFINED            \ Symbol is undefined or is common.
    FFFF Constant IMAGE_SYM_ABSOLUTE             \ Symbol is an absolute value.
    FFFE Constant IMAGE_SYM_DEBUG                \ Symbol is a special debug item.
    FEFF Constant IMAGE_SYM_SECTION_MAX          \ Values 0xFF00-0xFFFF are special
FFFFFFFF Constant IMAGE_SYM_SECTION_MAX_EX

\ Type (fundamental) values
0000 Constant IMAGE_SYM_TYPE_NULL            \ no type.
0001 Constant IMAGE_SYM_TYPE_VOID            \
0002 Constant IMAGE_SYM_TYPE_CHAR            \ type character.
0003 Constant IMAGE_SYM_TYPE_SHORT           \ type short integer.
0004 Constant IMAGE_SYM_TYPE_INT             \
0005 Constant IMAGE_SYM_TYPE_LONG            \
0006 Constant IMAGE_SYM_TYPE_FLOAT           \
0007 Constant IMAGE_SYM_TYPE_DOUBLE          \
0008 Constant IMAGE_SYM_TYPE_STRUCT          \
0009 Constant IMAGE_SYM_TYPE_UNION           \
000A Constant IMAGE_SYM_TYPE_ENUM            \ enumeration.
000B Constant IMAGE_SYM_TYPE_MOE             \ member of enumeration.
000C Constant IMAGE_SYM_TYPE_BYTE            \
000D Constant IMAGE_SYM_TYPE_WORD            \
000E Constant IMAGE_SYM_TYPE_UINT            \
000F Constant IMAGE_SYM_TYPE_DWORD           \
8000 Constant IMAGE_SYM_TYPE_PCODE           \
\ Type (derived) values
0 Constant IMAGE_SYM_DTYPE_NULL              \ no derived type.
1 Constant IMAGE_SYM_DTYPE_POINTER           \ pointer.
2 Constant IMAGE_SYM_DTYPE_FUNCTION          \ function.
3 Constant IMAGE_SYM_DTYPE_ARRAY             \ array.

FF Constant IMAGE_SYM_CLASS_END_OF_FUNCTION
00 Constant IMAGE_SYM_CLASS_NULL
01 Constant IMAGE_SYM_CLASS_AUTOMATIC
02 Constant IMAGE_SYM_CLASS_EXTERNAL
03 Constant IMAGE_SYM_CLASS_STATIC
04 Constant IMAGE_SYM_CLASS_REGISTER
05 Constant IMAGE_SYM_CLASS_EXTERNAL_DEF
06 Constant IMAGE_SYM_CLASS_LABEL
07 Constant IMAGE_SYM_CLASS_UNDEFINED_LABEL
08 Constant IMAGE_SYM_CLASS_MEMBER_OF_STRUCT
09 Constant IMAGE_SYM_CLASS_ARGUMENT
0A Constant IMAGE_SYM_CLASS_STRUCT_TAG
0B Constant IMAGE_SYM_CLASS_MEMBER_OF_UNION
0C Constant IMAGE_SYM_CLASS_UNION_TAG
0D Constant IMAGE_SYM_CLASS_TYPE_DEFINITION
0E Constant IMAGE_SYM_CLASS_UNDEFINED_STATIC
0F Constant IMAGE_SYM_CLASS_ENUM_TAG
10 Constant IMAGE_SYM_CLASS_MEMBER_OF_ENUM
11 Constant IMAGE_SYM_CLASS_REGISTER_PARAM
12 Constant IMAGE_SYM_CLASS_BIT_FIELD

44 Constant IMAGE_SYM_CLASS_FAR_EXTERNAL

64 Constant IMAGE_SYM_CLASS_BLOCK
65 Constant IMAGE_SYM_CLASS_FUNCTION
66 Constant IMAGE_SYM_CLASS_END_OF_STRUCT
67 Constant IMAGE_SYM_CLASS_FILE
68 Constant IMAGE_SYM_CLASS_SECTION
69 Constant IMAGE_SYM_CLASS_WEAK_EXTERNAL

6B Constant IMAGE_SYM_CLASS_CLR_TOKEN

0
    0 +Field sym.ShortName
    4 +Field sym.Short \ if 0, use LongName
    4 +Field sym.Long  \ offset into string table
    4 +Field sym.Value
    2 +Field sym.SectionNumber
    2 +Field sym.Type
    1 +Field sym.StorageClass
    1 +Field sym.NumberOfAuxSymbols
Constant IMAGE_SYMBOL

base !