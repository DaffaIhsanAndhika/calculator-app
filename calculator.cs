class Calculator
{
    static void Main (string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil penambahan: (0) + (1) = (2)", a, b, Penambahan(a, b));
		Console.WriteLine("Hasil pengurangan: (0) - (1) = (2)", a, b, Pengurangan(a, b));
		
		
	}
	
	static int penambahan (int a, int b)
	{
		return a + b;
	}
	
	static int pengurangan (int a, int b)
	{
		return a - b;
	}
}