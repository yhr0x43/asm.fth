require ../asm.fs
require ../coff.fs

hex

s" .text" .sect

$BA .db s" msg-len" .rd	\ mov edx,$C
$B9 .db s" msg" .rd	\ mov ecx,msg
$BB .db 1 .dd		\ mov ebx,1
$B8 .db 4 .dd		\ mov eax,4
$CD .db $80 .db		\ int 80h   ; sys_write(1, "Hello", 5)
$BB .db 1 .dd		\ mov ebx,1
$B8 .db 1 .dd		\ mov eax,1
$CD .db $80 .db		\ int 80h   ; sys_exit(1)
$EB .db $FE .db		\ spin: jmp spin

s" msg" .cur $401000 + .equ
s\" Hello World!\n" .ds
s" msg-len" .cur s" msg" .val $401000 - - .equ

s" test-coff.obj" r/w bin create-file throw
.endasm

bye
