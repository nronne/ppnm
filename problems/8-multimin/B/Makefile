INPUT = higgs.data
out.txt: main.exe $(INPUT)
	mono $< <$(INPUT) > $@

main.exe: main.cs matlib.dll
	mcs -reference:matlib.dll $<

LIBDIR = ../../../matlib/matrix
MATLIB = $(LIBDIR)/vector.cs
MATLIB += $(LIBDIR)/matrix.cs
MATLIB += ../minimizer.cs
matlib.dll: $(MATLIB)
	mcs -target:library -out:$@ $^


clean:
	$(RM) *.txt *.dll *.log *.exe
