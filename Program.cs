int n1,n2, Contador = 1;

Console.Write("Tabuada do número: ");
n1 =  Convert.ToInt32(Console.ReadLine());

n2 = 0;

while (n2 < 10 )
{
    n2 = n2 + 1;
    Contador =  n1 * n2;
    Console.WriteLine($"{n1} x {n2} = {Contador}");
}