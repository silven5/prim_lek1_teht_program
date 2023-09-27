// See https://aka.ms/new-console-template for more information
using prim3_lek1;

SomeRef r1 = new SomeRef();
SomeVal v1= new SomeVal();
r1.x = 5;
v1.x = 5;
Console.WriteLine(r1.x);
Console.WriteLine(v1.x);
//А зараз трошки магії
SomeRef r2 = r1;
SomeVal v2 = v1;

r1.x = 8;
v1.x = 9;
Console.WriteLine(r1.x);
Console.WriteLine(v1.x);
Console.WriteLine(r2.x);
Console.WriteLine(v2.x);
Console.ReadKey();  
struct SomeVal

{
    public int x;
}
