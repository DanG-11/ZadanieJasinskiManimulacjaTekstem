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

//Zad 4

Console.WriteLine("Wypisz zdanie:");
string OGTekst4 = Console.ReadLine();
Console.WriteLine("Jaki znak chcesz zamienić?");
string UserReplacementInputFrom = Convert.ToString(Console.ReadLine());
Console.WriteLine("Na jaki?");
string UserReplacementInputTo = Convert.ToString(Console.ReadLine());
string ReplacedText = OGTekst4.Replace(UserReplacementInputFrom, UserReplacementInputTo);
Console.WriteLine(ReplacedText);

//Zad 5
Console.WriteLine("Wypisz zdanie:");
string OGTekst5 = Console.ReadLine();
char[] OGTekst5Array = OGTekst5.ToCharArray();
string Zad5TekstOdwrocony = string.Empty;
for (int i = 0; i < OGTekst5.Length; i++)
{

    Zad5TekstOdwrocony = Zad5TekstOdwrocony + OGTekst5Array[OGTekst5.Length - 1 - i];
}
Console.WriteLine(Zad5TekstOdwrocony);

//Zad 6
Console.WriteLine("Wypisz zdanie:");
string OGTekst6 = Console.ReadLine().Replace(" ", "").ToLower();
char[] OGTekst6Array = OGTekst6.ToCharArray();
string Zad6TekstOdwrocony = string.Empty;
for (int i = 0; i < OGTekst6.Length; i++)
{

    Zad6TekstOdwrocony = Zad6TekstOdwrocony + OGTekst6Array[OGTekst6.Length - 1 - i];
}

if (Zad6TekstOdwrocony == OGTekst6)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}

//Zad 7
Console.WriteLine("Wypisz tekst:");
string OGTekst7 = Console.ReadLine();
string[] OGTekst7Split = OGTekst7.Trim().Split(' ');
int IloscSlow = 0;

for (int x = 0; x <= OGTekst7Split.Length; x++)
{
    IloscSlow = x;
}
Console.WriteLine(IloscSlow);

//Zad 8
Console.WriteLine("Wypisz tekst:");
string OGTekst8 = Console.ReadLine().ToString().Trim();
string[] OGTekst8Split = OGTekst8.Split(' ');
string Zad8Akronim = String.Empty;
for (int i = 0; i < OGTekst8Split.Length; i++)
{
    Zad8Akronim = Zad8Akronim + OGTekst8Split[i][0];
}
Console.WriteLine(Zad8Akronim);

//Zad 9
Console.WriteLine("Wypisz tekst:");
string OGTekst9 = Console.ReadLine().Trim();

int NaKtorymZnakuMalpa = OGTekst9.IndexOf("@") + 1;

string OGTekst9Split = OGTekst9.Substring(NaKtorymZnakuMalpa, (OGTekst9.Length - (NaKtorymZnakuMalpa)));
Console.WriteLine(OGTekst9Split);