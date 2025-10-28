FTH ?= gforth

OBJS := pillar-raw.obj pillar-coff.obj
.PHONY: all clean

all: $(OBJS)

clean:
	$(RM) $(OBJS)

pillar-raw.obj: test-raw.fs
	$(FTH) $^ -e bye

pillar-coff.obj: test-coff.fs
	$(FTH) $^ -e bye
