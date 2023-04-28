Console.Write("Pozitif Bir Sayı Girin : ");
int n = 0;
bool kontrol=false;
string kelime = string.Empty;
kontrol=int.TryParse(Console.ReadLine(), out n);
int sayac = 1;
string[] liste=new string[0];

do
{
    Console.Write($"{sayac}. Kelimeyi Girin : ");
    kelime = Console.ReadLine();
    Array.Resize(ref liste, liste.Length + 1);
    liste[liste.Length - 1] = kelime;
    sayac++;

} while (sayac<=n);

Array.Reverse(liste);
foreach(string s in liste)
{
    Console.WriteLine(s);
}
Console.ReadKey();