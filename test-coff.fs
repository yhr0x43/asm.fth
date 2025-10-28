require asm.fs
require coff.fs

hex

s" .text" .sect

$B8 .db 1 .dd   \ mov eax,1
$BB .db 1 .dd   \ mov ebx,1
$CD .db $80 .db \ int 80h
$EB .db $FE .db \ spin: jmp spin

s" pillar-coff.obj" r/w bin create-file throw
.endasm

bye
