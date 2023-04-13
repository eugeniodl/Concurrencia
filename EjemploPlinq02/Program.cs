List<string> lista = new List<string>();
int i = 0;

while (i <= 1000)
{
    lista.Add(Cadena());
    i++;
}

List<string> filtro = (from n in lista.AsParallel()
                       where Contieneletras(n)
                       select n).ToList();

foreach (var item in filtro)
{
    Console.WriteLine(item);
}

bool Contieneletras(string cadena)
{
    bool resultado = false;
    if(cadena.Contains("E"))
        resultado = true;
    return resultado;
}

string Cadena()
{
    var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    var array = new char[10];
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = caracteres[random.Next(caracteres.Length)];

    var resultado = new string(array);
    return resultado;
}