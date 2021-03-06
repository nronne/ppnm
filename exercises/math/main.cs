using System;
using static System.Console;
using static System.Math;
using static cmath;

class main{
	static int Main(){
	    double t = 2;
	    Write("sqrt({0}) = {1:f2}\n",t, Sqrt(t));
	    complex z = new complex(0,1);
	    Write("exp(i) = {0:f2}\n", exp(z));
	    Write("exp(i*pi) = {0:f2}\n", exp(PI*z));
	    Write("i^i = {0:f2}\n", z.pow(z));
	    Write("sin(i pi) = {0:f2}\n", sin(z*PI));


	    Write("___________________________________________\n");
	    double x=1;
	    Write("sin({0})={1:f2}\n",x,Sin(x));
	    Write($"sin({x})={Sin(x)}\n");
	    double y=x*Exp(x);
	    Write($"y={y} (E={E})\n");
	    complex I = new complex(0,1);
	    complex ii = I*I;
	    Write($"I*I={ii}\n");
	    complex sini = sin(I);
	    Write($"sin(I)={sini}\n");
	    complex si2ci2 = sin(I).pow(2)+cos(I).pow(2);
	    Write($"sin(I)^2+cos(I)^2={si2ci2}\n");
	    complex ipowi = I.pow(I);
	    Write($"I.pow(I)={ipowi}, exp(-PI/2)={Exp(-PI/2)}\n");
	    complex si = (-(complex)1.0).pow(0.5);
	    si.print("sqrt(-1)=");
	    si.printf("sqrt(-1)=({0:f2},{1:f2})");
	    var invi=1/I;
	    invi.print("1/I=");
	    log(I).print("log(I)=");
	    
	    
	    return 0;
	}
}


