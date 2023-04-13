string path1 = @"C:\Users\JADPA-13\source\repos\Concurrencia\EjemploParallel02\fotos1\";
string path2 = @"C:\Users\JADPA-13\source\repos\Concurrencia\EjemploParallel02\fotos2\";

string[] lst = Directory.GetFiles(path1);

//int a = 1;
//foreach (var item in lst)
//{
//    File.Copy(item, path2 + "Foto" + a + ".jpg");
//    a++;
//}

Random r = new Random(10000);
Parallel.ForEach(lst, archivo =>
{
    int a = r.Next();
    File.Copy(archivo, path2 + "Foto" + a + ".jpg");
});