﻿List<string> lista = new List<string>();
int i = 0;

while(i <= 1000)
{
    lista.Add(Cadena());
    i++;
}

List<string> listaFiltrada = (from n in lista.AsParallel()
                              where ContieneLetras(n)
                              select n).ToList();

foreach(string str in listaFiltrada)
    Console.WriteLine(str);

bool ContieneLetras(string cadena)
{
    bool resultado = false;
    if(cadena.Contains("X"))
        resultado = true;
    return resultado;
}

string Cadena()
{
    var caracteres = "ABCDEFGHIJQLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    var array = new char[10];
    var random = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = caracteres[random.Next(caracteres.Length)];

    var resultado = new string(array);
    return resultado;
}