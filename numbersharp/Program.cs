int a = 18;
int b = 2100000000;
int c = a + b;
Console.WriteLine($"C = {c}");
//int 上限 2,147,483,647
long d = a + b * c;
Console.WriteLine($"D = {d}");

long e = a + (long)b * c;
Console.WriteLine($"E = {e}");

e = ((long)a + b) * c;
Console.WriteLine($"D = {e}");


double aa = 1.0;
double bb = 3.0;
Console.WriteLine(aa / bb);

decimal cc = 1.0M;
decimal dd = 3.0M;
Console.WriteLine(cc / dd);