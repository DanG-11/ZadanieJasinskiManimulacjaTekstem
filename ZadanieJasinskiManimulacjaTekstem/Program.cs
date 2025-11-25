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

if(WyborTekstu == 1)
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