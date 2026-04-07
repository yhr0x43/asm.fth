require ../asm.fs
require ../elf.fs

hex

s" .text" .sect

s" test-elf.o" r/w bin create-file throw
.endasm

bye
