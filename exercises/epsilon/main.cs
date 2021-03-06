using static System.Console;

class main{
    static int Main(){
	main.exercise();
	double a = 1.0;
	double b = 1.4;
	double tau = 0.5;
	double epsilon = 0.1;
	bool isSame = Comparison.Approx(a, b, epsilon, tau);
	Write("isSame is {0}\n", isSame);
	return 0;
    }
    static void exercise(){
	int i = 0;
	while(i<i+1) {i++;}
	Write("My largest int is: {0}\n", i);

	i = 0;
	while(i-1<i) {i--;}
	Write("My smallest in is: {0}\n", i);
	Write("From int.minvalue we get: {0}\n", int.MinValue);
	
	double x = 1;
	while(x+1!=1){x/=2;}
	Write("machine epsilon for double: {0}\n", x);

	float y = 1;
	while((y+1)!=1) {y/=2;}
	Write("machine epsilon for float: {0}\n", y);
	

	int max = int.MaxValue/2;
	float floatSumUp = 0f;
	for(int j = 1; j<max; j++) {floatSumUp += 1f/j;}
	Write("Harmonic sum (sum up) is : {0}\n", floatSumUp);
	
	float floatSumDown = 0f;
	for(int j = max-1; j>0; j--) {floatSumDown += 1f/j;}
	Write("Harmonic sum (sum down) is: {0}\n", floatSumDown);
	
	double doubleSumUp = 0;
	for(int j = 1; j<max; j++) {doubleSumUp += 1d/j;}
        Write("double Harmonic sum (sum up) is : {0}\n", doubleSumUp);

	double doubleSumDown = 0;
        for(int j = max-1; j>0; j--) {doubleSumDown += 1d/j;}
        Write("double Harmonic sum (sum down) is: {0}\n", doubleSumDown);

	Write("round off of integers: {0}\n", 3/5);
	
    }
}
