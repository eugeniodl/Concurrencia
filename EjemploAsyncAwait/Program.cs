Console.Write("Indique el valor máximo para el cálculo ");
string maxi;
maxi = Console.ReadLine();
//int resultado;
//resultado = CuentaPrimos(int.Parse(maxi));
//Console.WriteLine(resultado);
int mx;
mx = int.Parse(maxi);
await ProcesamientoAsync(mx);
Console.WriteLine("Presione una tecla cualquiera para detener la " +
    "aplicación antes de que se realice el cálculo");
Console.ReadKey();

async Task ProcesamientoAsync(int maxi)
{
    int resultado;
    resultado = await CuentaPrimosAsync(maxi);
    Console.WriteLine(resultado);
    Console.WriteLine("*********************");
}
// Método asíncrono
async Task<int> CuentaPrimosAsync(int maxi)
{
    int resultado;
    resultado = await Task.Run(() =>
    {
        int nb = 0;
        for (int i = 0; i <= maxi; i++)
        {
            if(esPrimo(i))
                nb++;
        }
        return nb;
    });
    return resultado;
}

int CuentaPrimos(int maxi)
{
    int resultado = 0;
    for (int i = 0; i <= maxi; i++)
    {
        if(esPrimo(i))
        {
            resultado++;
        }
    }
    return resultado;
}

bool esPrimo(int nb)
{
    if(nb < 0)
    {
        return false;
    }
    if(nb == 2)
    {
        return true;
    }
    if(nb % 2 == 0)
    {
        return false;
    }
    int i = 3;
    while((i * i <= nb))
    {
        if (nb % i == 0)
            return false;
        else
            i++;
    }
    return true;
}