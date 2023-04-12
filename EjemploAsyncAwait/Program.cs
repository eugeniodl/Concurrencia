

Console.Write("Indique el valor máximo para el cálculo ");
string maxi = Console.ReadLine();
//int resultado = CuentaPrimos(int.Parse(maxi));
//Console.WriteLine(resultado);
int mx = int.Parse(maxi);

await ProcesamientoAsync(mx);
Console.WriteLine("Presione una tecla cualquiera para detener la "+
    "aplicación antes de que realice el cálculo");
Console.ReadKey();

async Task ProcesamientoAsync(int maxi)
{
    int resultado = await CuentaPrimosAsync(maxi);
    Console.WriteLine(resultado);
    Console.WriteLine("**********************");
}

// Función asíncrona
async Task<int> CuentaPrimosAsync(int maxi)
{
    int resultado = await Task.Run(() =>
    {
        int nb = 0;
        for (int i = 0; i <= maxi; i++)
        {
            if (EsPrimo(i))
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
        if(EsPrimo(i))
            resultado++;
    }
    return resultado;
}

bool EsPrimo(int n)
{
    // Revisa si n es múltiplo de 2
    if(n % 2 == 0)
        return false;
    // Si no, solo revisa los impares
    for (int i = 3; i * i <= n; i += 2)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}