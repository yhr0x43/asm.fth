FTH ?= gforth

.PHONY: all clean

all: test-coff

%.obj: %.fs
	$(FTH) $^ -e bye

%: %.obj
	$(LD) -o $@ $<
