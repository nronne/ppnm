CSFLAFS = -warn:4 -optimize-
out.txt : main.exe            
	mono $< > out.txt 

main.exe : main.cs approx.dll  
	mcs $(CSFLAGS) -reference:approx.dll  $<

approx.dll : approx.cs
	mcs -target:library approx.cs        

clean:                       
	rm -f out.txt hello.exe approx.dll
