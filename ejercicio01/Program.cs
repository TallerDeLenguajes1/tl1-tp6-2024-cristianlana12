// See https://aka.ms/new-console-template for more information
int a = 12344;
int aux = a;
int dig=0;
int numfin=0;
while (aux % 10 != 0)
{
    dig = aux%10;
    a = a/10;
    aux = a;
    numfin = numfin*10 + dig;
}

Console.WriteLine(numfin);