class main{
    static int Main(string[] args) {
	double d = 0;
	for(int i = 0; i < args.Length; i++) {
	    d = double.Parse(args[i]);
	    System.Console.Write("cos({0}) = {1:f2}\n",args[i], System.Math.Cos(d));
	}
	return 0;
    }
}
