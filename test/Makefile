FTH ?= gforth

.PHONY: all clean

all: test-coff

clean:
	$(RM) $(OBJS)

%.obj: %.fs
	$(FTH) $^ -e bye

%: %.obj
	$(LD) -o $@ $<
