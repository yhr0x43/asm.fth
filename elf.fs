base @
hex

10 Constant EI_NIDENT

0	Constant EI_MAG0
7F	Constant ELFMAG0
1	Constant EI_MAG1
char E  Constant ELFMAG1
2	Constant EI_MAG2
char L  Constant ELFMAG2
3	Constant EI_MAG3
char F  Constant ELFMAG3

4	Constant EI_CLASS		\ File class byte index
0	Constant ELFCLASSNONE		\ Invalid class
1	Constant ELFCLASS32		\ 32-bit objects
2	Constant ELFCLASS64		\ 64-bit objects
3	Constant ELFCLASSNUM	

5	Constant EI_DATA		\ Data encoding byte index
0	Constant ELFDATANONE		\ Invalid data encoding
1	Constant ELFDATA2LSB		\ 2's complement, little endian
2	Constant ELFDATA2MSB		\ 2's complement, big endian
3	Constant ELFDATANUM	

6	Constant EI_VERSION		\ File version byte index
					\ Value must be EV_CURRENT

7		Constant EI_OSABI		\ OS ABI identification
0		Constant ELFOSABI_NONE		\ UNIX System V ABI
0		Constant ELFOSABI_SYSV		\ Alias.
1		Constant ELFOSABI_HPUX		\ HP-UX
2		Constant ELFOSABI_NETBSD	\ NetBSD.
3		Constant ELFOSABI_GNU		\ Object uses GNU ELF extensions.
ELFOSABI_GNU	Constant ELFOSABI_LINUX		\ Compatibility alias.
6		Constant ELFOSABI_SOLARIS	\ Sun Solaris. 
7		Constant ELFOSABI_AIX		\ IBM AIX.
8		Constant ELFOSABI_IRIX		\ SGI Irix.
9		Constant ELFOSABI_FREEBSD	\ FreeBSD.
10		Constant ELFOSABI_TRU64		\ Compaq TRU64 UNIX.
11		Constant ELFOSABI_MODESTO	\ Novell Modesto.
12		Constant ELFOSABI_OPENBSD	\ OpenBSD.
64		Constant ELFOSABI_ARM_AEABI	\ ARM EABI
97		Constant ELFOSABI_ARM		\ ARM
255		Constant ELFOSABI_STANDALONE	\ Standalone (embedded) application

8	Constant EI_ABIVERSION	8	\ ABI version

9	Constant EI_PAD	9	\ Byte index of padding bytes

0	Constant ET_NONE	\ No file type
1	Constant ET_REL		\ Relocatable file
2	Constant ET_EXEC	\ Executable file
3	Constant ET_DYN		\ Shared object file
4	Constant ET_CORE	\ Core file
5	Constant ET_NUM		\ Number of defined types
FE00	Constant ET_LOOS	\ OS-specific range start
FEFF	Constant ET_HIOS	\ OS-specific range end
FF00	Constant ET_LOPROC	\ Processor-specific range start
FFFF	Constant ET_HIPROC	\ Processor-specific range end

decimal

0	Constant EM_NONE		\ No machine
1	Constant EM_M32			\ AT&T WE 32100
2	Constant EM_SPARC		\ SUN SPARC
3	Constant EM_386			\ Intel 80386
4	Constant EM_68K			\ Motorola m68k family
5	Constant EM_88K			\ Motorola m88k family
6	Constant EM_IAMCU		\ Intel MCU
7	Constant EM_860			\ Intel 80860
8	Constant EM_MIPS		\ MIPS R3000 big-endian
9	Constant EM_S370		\ IBM System/370
10	Constant EM_MIPS_RS3_LE		\ MIPS R3000 little-endian
					\ reserved 11-14
15	Constant EM_PARISC		\ HPPA
					\ reserved 16
17	Constant EM_VPP500		\ Fujitsu VPP500
18	Constant EM_SPARC32PLUS		\ Sun's "v8plus"
19	Constant EM_960			\ Intel 80960
20	Constant EM_PPC			\ PowerPC
21	Constant EM_PPC64		\ PowerPC 64-bit
22	Constant EM_S390		\ IBM S390
23	Constant EM_SPU			\ IBM SPU/SPC
					\ reserved 24-35
36	Constant EM_V800		\ NEC V800 series
37	Constant EM_FR20		\ Fujitsu FR20
38	Constant EM_RH32		\ TRW RH-32
39	Constant EM_RCE			\ Motorola RCE
40	Constant EM_ARM			\ ARM
41	Constant EM_FAKE_ALPHA		\ Digital Alpha
42	Constant EM_SH			\ Hitachi SH
43	Constant EM_SPARCV9		\ SPARC v9 64-bit
44	Constant EM_TRICORE		\ Siemens Tricore
45	Constant EM_ARC			\ Argonaut RISC Core
46	Constant EM_H8_300		\ Hitachi H8/300
47	Constant EM_H8_300H		\ Hitachi H8/300H
48	Constant EM_H8S			\ Hitachi H8S
49	Constant EM_H8_500		\ Hitachi H8/500
50	Constant EM_IA_64		\ Intel Merced
51	Constant EM_MIPS_X		\ Stanford MIPS-X
52	Constant EM_COLDFIRE		\ Motorola Coldfire
53	Constant EM_68HC12		\ Motorola M68HC12
54	Constant EM_MMA			\ Fujitsu MMA Multimedia Accelerator
55	Constant EM_PCP			\ Siemens PCP
56	Constant EM_NCPU		\ Sony nCPU embedded RISC
57	Constant EM_NDR1		\ Denso NDR1 microprocessor
58	Constant EM_STARCORE		\ Motorola Start*Core processor
59	Constant EM_ME16		\ Toyota ME16 processor
60	Constant EM_ST100		\ STMicroelectronic ST100 processor
61	Constant EM_TINYJ		\ Advanced Logic Corp. Tinyj emb.fam
62	Constant EM_X86_64		\ AMD x86-64 architecture
63	Constant EM_PDSP		\ Sony DSP Processor
64	Constant EM_PDP10		\ Digital PDP-10
65	Constant EM_PDP11		\ Digital PDP-11
66	Constant EM_FX66		\ Siemens FX66 microcontroller
67	Constant EM_ST9PLUS		\ STMicroelectronics ST9+ 8/16 mc
68	Constant EM_ST7			\ STmicroelectronics ST7 8 bit mc
69	Constant EM_68HC16		\ Motorola MC68HC16 microcontroller
70	Constant EM_68HC11		\ Motorola MC68HC11 microcontroller
71	Constant EM_68HC08		\ Motorola MC68HC08 microcontroller
72	Constant EM_68HC05		\ Motorola MC68HC05 microcontroller
73	Constant EM_SVX			\ Silicon Graphics SVx
74	Constant EM_ST19		\ STMicroelectronics ST19 8 bit mc
75	Constant EM_VAX			\ Digital VAX
76	Constant EM_CRIS		\ Axis Communications 32-bit emb.proc
77	Constant EM_JAVELIN		\ Infineon Technologies 32-bit emb.proc
78	Constant EM_FIREPATH		\ Element 14 64-bit DSP Processor
79	Constant EM_ZSP			\ LSI Logic 16-bit DSP Processor
80	Constant EM_MMIX		\ Donald Knuth's educational 64-bit proc
81	Constant EM_HUANY		\ Harvard University machine-independent object files
82	Constant EM_PRISM		\ SiTera Prism
83	Constant EM_AVR			\ Atmel AVR 8-bit microcontroller
84	Constant EM_FR30		\ Fujitsu FR30
85	Constant EM_D10V		\ Mitsubishi D10V
86	Constant EM_D30V		\ Mitsubishi D30V
87	Constant EM_V850		\ NEC v850
88	Constant EM_M32R		\ Mitsubishi M32R
89	Constant EM_MN10300		\ Matsushita MN10300
90	Constant EM_MN10200		\ Matsushita MN10200
91	Constant EM_PJ			\ picoJava
92	Constant EM_OPENRISC		\ OpenRISC 32-bit embedded processor
93	Constant EM_ARC_COMPACT		\ ARC International ARCompact
94	Constant EM_XTENSA		\ Tensilica Xtensa Architecture
95	Constant EM_VIDEOCORE		\ Alphamosaic VideoCore
96	Constant EM_TMM_GPP		\ Thompson Multimedia General Purpose Proc
97	Constant EM_NS32K		\ National Semi. 32000
98	Constant EM_TPC			\ Tenor Network TPC
99	Constant EM_SNP1K		\ Trebia SNP 1000
100	Constant EM_ST200		\ STMicroelectronics ST200
101	Constant EM_IP2K		\ Ubicom IP2xxx
102	Constant EM_MAX			\ MAX processor
103	Constant EM_CR			\ National Semi. CompactRISC
104	Constant EM_F2MC16		\ Fujitsu F2MC16
105	Constant EM_MSP430		\ Texas Instruments msp430
106	Constant EM_BLACKFIN		\ Analog Devices Blackfin DSP
107	Constant EM_SE_C33		\ Seiko Epson S1C33 family
108	Constant EM_SEP			\ Sharp embedded microprocessor
109	Constant EM_ARCA		\ Arca RISC
110	Constant EM_UNICORE		\ PKU-Unity & MPRC Peking Uni. mc series
111	Constant EM_EXCESS		\ eXcess configurable cpu
112	Constant EM_DXP			\ Icera Semi. Deep Execution Processor
113	Constant EM_ALTERA_NIOS2 	\ Altera Nios II
114	Constant EM_CRX			\ National Semi. CompactRISC CRX
115	Constant EM_XGATE		\ Motorola XGATE
116	Constant EM_C166		\ Infineon C16x/XC16x
117	Constant EM_M16C		\ Renesas M16C
118	Constant EM_DSPIC30F		\ Microchip Technology dsPIC30F
119	Constant EM_CE			\ Freescale Communication Engine RISC
120	Constant EM_M32C		\ Renesas M32C
					\ reserved 121-130
131	Constant EM_TSK3000		\ Altium TSK3000
132	Constant EM_RS08		\ Freescale RS08
133	Constant EM_SHARC		\ Analog Devices SHARC family
134	Constant EM_ECOG2		\ Cyan Technology eCOG2
135	Constant EM_SCORE7		\ Sunplus S+core7 RISC
136	Constant EM_DSP24		\ New Japan Radio (NJR) 24-bit DSP
137	Constant EM_VIDEOCORE3		\ Broadcom VideoCore III
138	Constant EM_LATTICEMICO32 	\ RISC for Lattice FPGA
139	Constant EM_SE_C17		\ Seiko Epson C17
140	Constant EM_TI_C6000		\ Texas Instruments TMS320C6000 DSP
141	Constant EM_TI_C2000		\ Texas Instruments TMS320C2000 DSP
142	Constant EM_TI_C5500		\ Texas Instruments TMS320C55x DSP
143	Constant EM_TI_ARP32		\ Texas Instruments App. Specific RISC
144	Constant EM_TI_PRU		\ Texas Instruments Prog. Realtime Unit
					\ reserved 145-159
160	Constant EM_MMDSP_PLUS		\ STMicroelectronics 64bit VLIW DSP
161	Constant EM_CYPRESS_M8C		\ Cypress M8C
162	Constant EM_R32C		\ Renesas R32C
163	Constant EM_TRIMEDIA		\ NXP Semi. TriMedia
164	Constant EM_QDSP6		\ QUALCOMM DSP6
165	Constant EM_8051		\ Intel 8051 and variants
166	Constant EM_STXP7X		\ STMicroelectronics STxP7x
167	Constant EM_NDS32		\ Andes Tech. compact code emb. RISC
168	Constant EM_ECOG1X		\ Cyan Technology eCOG1X
169	Constant EM_MAXQ30		\ Dallas Semi. MAXQ30 mc
170	Constant EM_XIMO16		\ New Japan Radio (NJR) 16-bit DSP
171	Constant EM_MANIK		\ M2000 Reconfigurable RISC
172	Constant EM_CRAYNV2		\ Cray NV2 vector architecture
173	Constant EM_RX			\ Renesas RX
174	Constant EM_METAG		\ Imagination Tech. META
175	Constant EM_MCST_ELBRUS		\ MCST Elbrus
176	Constant EM_ECOG16		\ Cyan Technology eCOG16
177	Constant EM_CR16		\ National Semi. CompactRISC CR16
178	Constant EM_ETPU		\ Freescale Extended Time Processing Unit
179	Constant EM_SLE9X		\ Infineon Tech. SLE9X
180	Constant EM_L10M		\ Intel L10M
181	Constant EM_K10M		\ Intel K10M
					\ reserved 182
183	Constant EM_AARCH64		\ ARM AARCH64
					\ reserved 184
185	Constant EM_AVR32		\ Amtel 32-bit microprocessor
186	Constant EM_STM8		\ STMicroelectronics STM8
187	Constant EM_TILE64		\ Tilera TILE64
188	Constant EM_TILEPRO		\ Tilera TILEPro
189	Constant EM_MICROBLAZE		\ Xilinx MicroBlaze
190	Constant EM_CUDA		\ NVIDIA CUDA
191	Constant EM_TILEGX		\ Tilera TILE-Gx
192	Constant EM_CLOUDSHIELD		\ CloudShield
193	Constant EM_COREA_1ST		\ KIPO-KAIST Core-A 1st gen.
194	Constant EM_COREA_2ND		\ KIPO-KAIST Core-A 2nd gen.
195	Constant EM_ARCV2		\ Synopsys ARCv2 ISA. 
196	Constant EM_OPEN8		\ Open8 RISC
197	Constant EM_RL78		\ Renesas RL78
198	Constant EM_VIDEOCORE5		\ Broadcom VideoCore V
199	Constant EM_78KOR		\ Renesas 78KOR
200	Constant EM_56800EX		\ Freescale 56800EX DSC
201	Constant EM_BA1			\ Beyond BA1
202	Constant EM_BA2			\ Beyond BA2
203	Constant EM_XCORE		\ XMOS xCORE
204	Constant EM_MCHP_PIC		\ Microchip 8-bit PIC(r)
205	Constant EM_INTELGT		\ Intel Graphics Technology
					\ reserved 206-209
210	Constant EM_KM32		\ KM211 KM32
211	Constant EM_KMX32		\ KM211 KMX32
212	Constant EM_EMX16		\ KM211 KMX16
213	Constant EM_EMX8		\ KM211 KMX8
214	Constant EM_KVARC		\ KM211 KVARC
215	Constant EM_CDP			\ Paneve CDP
216	Constant EM_COGE		\ Cognitive Smart Memory Processor
217	Constant EM_COOL		\ Bluechip CoolEngine
218	Constant EM_NORC		\ Nanoradio Optimized RISC
219	Constant EM_CSR_KALIMBA		\ CSR Kalimba
220	Constant EM_Z80			\ Zilog Z80
221	Constant EM_VISIUM		\ Controls and Data Services VISIUMcore
222	Constant EM_FT32		\ FTDI Chip FT32
223	Constant EM_MOXIE		\ Moxie processor
224	Constant EM_AMDGPU		\ AMD GPU
					\ reserved 225-242
243	Constant EM_RISCV		\ RISC-V

247	Constant EM_BPF			\ Linux BPF -- in-kernel virtual machine
252	Constant EM_CSKY		\ C-SKY
258	Constant EM_LOONGARCH		\ LoongArch

259	Constant EM_NUM

\ Old spellings/synonyms.

EM_ARC_COMPACT	Constant EM_ARC_A5

hex

0	Constant EV_NONE		\ Invalid ELF version */
1	Constant EV_CURRENT		\ Current version */
2	Constant EV_NUM

require asm.fs

: .endasm ( fd -- )
    refable allocate throw
    dup rfb.buffer dynarr-init
    dup rfb.xrefs dynarr-init
    this_sect !

    ELFMAG0		.db	\ e_ident[EI_MAG0]
    ELFMAG1		.db	\ e_ident[EI_MAG1]
    ELFMAG2		.db	\ e_ident[EI_MAG2]
    ELFMAG3		.db	\ e_ident[EI_MAG3]
    ELFCLASS64		.db	\ e_ident[EI_CLASS]
    ELFDATA2LSB		.db	\ e_ident[EI_DATA]
    EV_CURRENT		.db	\ e_ident[EI_VERSION]
    ELFOSABI_NONE	.db	\ e_ident[EI_OSABI]
    0			.db	\ e_ident[EI_ABIVERSION]
    7 0 DO 0 .db LOOP		\ e_ident[EI_PAD]
    ET_DYN		.dw	\ e_type
    EM_X86_64		.dw	\ e_machine
    EV_CURRENT		.dd	\ e_version
    0000000000000001	.dq	\ e_entry
    0000000000000000	.dq	\ e_phoff
    0000000000000000	.dq	\ e_shoff
    00000000		.dd	\ e_flags
    0040		.dw	\ e_ehsize
    0038		.dw	\ e_phentsize
    000E		.dw	\ e_phnum
    0040		.dw	\ e_shentsize
    001C		.dw	\ e_shnum
    001B		.dw	\ e_shstrndx

    this_sect @ rfb.buffer dynarr-@
    2 pick write-file throw
    close-file throw
;

base !
