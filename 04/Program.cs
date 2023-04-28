//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.Write("Bir Cümle Yazınız : ");
string cumle=Console.ReadLine();
int kelimeSayisi, harfSayisi=0, boslukSayisi=0;
foreach (char itemm in cumle)
{
    harfSayisi++;
}

foreach (char item in cumle)
{
    if (item ==' ')
    {
        boslukSayisi++;
    }

}


Console.WriteLine($"Yazdığın cümlede kelime sayısı : {boslukSayisi+1} ve harf sayısı ise : {harfSayisi} ");
Console.ReadKey();