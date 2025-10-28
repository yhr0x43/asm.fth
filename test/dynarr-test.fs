require dynarr.fs

dynarr allocate throw Constant t-str

t-str dynarr-init

t-str dynarr.size @ .
t-str dynarr.cap @ .
t-str dynarr.data @ .

\ test reserving spaces
\ the orginal capacity is 0, and data is 0, this should trigger allocate
cr
t-str dynarr.data @ .
t-str 15 dynarr-reserve
t-str dynarr.data @ .
\ try r/w this memory
25 t-str dynarr.data @ c!
t-str dynarr.data @ c@ .
