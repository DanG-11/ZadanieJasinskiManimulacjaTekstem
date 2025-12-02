//Zad 1
Console.WriteLine("Wpisz tekst:");
string OGTekst = Console.ReadLine();
int DlugoscTekstu = Convert.ToInt32(OGTekst.Length);
string TekstMalymi = OGTekst.ToLower();
string TekstDuzymi = OGTekst.ToUpper();

Console.WriteLine(DlugoscTekstu);
Console.WriteLine(TekstMalymi);
Console.WriteLine(TekstDuzymi);

//Zad 1.1, 1.2
Console.WriteLine("1 - Wypisz tekst z małych liter; 2 - Wypisz tekst z dużych liter; 3 - Pierwsza litera duża a reszta małe.");
int WyborTekstu = Convert.ToInt32(Console.ReadLine());

if (WyborTekstu == 1)
{
    Console.WriteLine(TekstMalymi);
}
else if (WyborTekstu == 2)
{
    Console.WriteLine(TekstDuzymi);
}
else if (WyborTekstu == 3)
{
    string[] OddzielneLiteryTekstu = TekstDuzymi.Split();
    Console.WriteLine(TekstDuzymi.Substring(0, 1) + TekstMalymi.Substring(1));
}
else
{
    Console.WriteLine("Niepoprawny wybór.");
}

//Zad 2
Console.WriteLine("Wpisz tekst:");
string OGTekst2 = Console.ReadLine();
string TekstBezSpacji = OGTekst2.Trim();
int DlugoscTekstuBezSpacji = Convert.ToInt32(TekstBezSpacji.Length);
string PierwszaLiteraTekstuBezSpacji = TekstBezSpacji.Substring(0, 1);
string OstatniaLiteraTekstuBezSpacji = TekstBezSpacji.Substring(DlugoscTekstuBezSpacji - 1, 1);

Console.WriteLine("Tekst bez spacji na początku i końcu: " + TekstBezSpacji);
Console.WriteLine("Długość tekstu: " + DlugoscTekstuBezSpacji);
Console.WriteLine("Pierwsza litera tekstu: " + PierwszaLiteraTekstuBezSpacji);
Console.WriteLine("Ostatnia litera tekstu: " + OstatniaLiteraTekstuBezSpacji);

//Zad 3
Console.WriteLine("Wpisz tekst:");
string OGTekst3 = Console.ReadLine();
Console.WriteLine("Jakie znaki wyliczyć:");
char JakiZnak = Console.ReadKey().KeyChar;

int zad3occurences = 0;

for (int x = 0; x < OGTekst3.Length; x++)
{
    if (JakiZnak == OGTekst3[x])
    {
        zad3occurences++;
    }
}
Console.WriteLine($"\nLitera: {JakiZnak}, wystepuje {zad3occurences} razy.");