int n = 0;
int z = 0;
int zbroj = 0;

Console.WriteLine("Unesite broj n:");

n = int.Parse(Console.ReadLine());

do{
    if (z % 2 == 0)
    {
    zbroj += z;
    }
    z++;
} while (z <= n) ;
Console.WriteLine("Broj: {0} ", zbroj);