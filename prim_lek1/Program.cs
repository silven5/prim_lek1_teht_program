// See https://aka.ms/new-console-template for more information
object xx = new Object();
Calculate(5,xx);

void Calculate (int t,object xx)
{
    int x = 6;
    xx = 6;
    int y = 7;
    int z = y + t + x;
    xx = 7.3;
   
    Console.WriteLine(z);
    
}