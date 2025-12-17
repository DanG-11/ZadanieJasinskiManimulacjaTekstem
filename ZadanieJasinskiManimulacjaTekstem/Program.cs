////Zad 1
//Console.WriteLine("Wpisz tekst:");
//string OGTekst = Console.ReadLine();
//int DlugoscTekstu = Convert.ToInt32(OGTekst.Length);
//string TekstMalymi = OGTekst.ToLower();
//string TekstDuzymi = OGTekst.ToUpper();

//Console.WriteLine(DlugoscTekstu);
//Console.WriteLine(TekstMalymi);
//Console.WriteLine(TekstDuzymi);

////Zad 1.1, 1.2
//Console.WriteLine("1 - Wypisz tekst z małych liter; 2 - Wypisz tekst z dużych liter; 3 - Pierwsza litera duża a reszta małe.");
//int WyborTekstu = Convert.ToInt32(Console.ReadLine());

//if (WyborTekstu == 1)
//{
//    Console.WriteLine(TekstMalymi);
//}
//else if (WyborTekstu == 2)
//{
//    Console.WriteLine(TekstDuzymi);
//}
//else if (WyborTekstu == 3)
//{
//    string[] OddzielneLiteryTekstu = TekstDuzymi.Split();
//    Console.WriteLine(TekstDuzymi.Substring(0, 1) + TekstMalymi.Substring(1));
//}
//else
//{
//    Console.WriteLine("Niepoprawny wybór.");
//}

////Zad 2
//Console.WriteLine("Wpisz tekst:");
//string OGTekst2 = Console.ReadLine();
//string TekstBezSpacji = OGTekst2.Trim();
//int DlugoscTekstuBezSpacji = Convert.ToInt32(TekstBezSpacji.Length);
//string PierwszaLiteraTekstuBezSpacji = TekstBezSpacji.Substring(0, 1);
//string OstatniaLiteraTekstuBezSpacji = TekstBezSpacji.Substring(DlugoscTekstuBezSpacji - 1, 1);

//Console.WriteLine("Tekst bez spacji na początku i końcu: " + TekstBezSpacji);
//Console.WriteLine("Długość tekstu: " + DlugoscTekstuBezSpacji);
//Console.WriteLine("Pierwsza litera tekstu: " + PierwszaLiteraTekstuBezSpacji);
//Console.WriteLine("Ostatnia litera tekstu: " + OstatniaLiteraTekstuBezSpacji);

////Zad 3
//Console.WriteLine("Wpisz tekst:");
//string OGTekst3 = Console.ReadLine();
//Console.WriteLine("Jakie znaki wyliczyć:");
//char JakiZnak = Console.ReadKey().KeyChar;

//int zad3occurences = 0;

//for (int x = 0; x < OGTekst3.Length; x++)
//{
//    if (JakiZnak == OGTekst3[x])
//    {
//        zad3occurences++;
//    }
//}
//Console.WriteLine($"\nLitera: {JakiZnak}, wystepuje {zad3occurences} razy.");

////Zad 4

//Console.WriteLine("Wypisz zdanie:");
//string OGTekst4 = Console.ReadLine();
//Console.WriteLine("Jaki znak chcesz zamienić?");
//string UserReplacementInputFrom = Convert.ToString(Console.ReadLine());
//Console.WriteLine("Na jaki?");
//string UserReplacementInputTo = Convert.ToString(Console.ReadLine());
//string ReplacedText = OGTekst4.Replace(UserReplacementInputFrom, UserReplacementInputTo);
//Console.WriteLine(ReplacedText);

////Zad 5
//Console.WriteLine("Wypisz zdanie:");
//string OGTekst5 = Console.ReadLine();
//char[] OGTekst5Array = OGTekst5.ToCharArray();
//string Zad5TekstOdwrocony = string.Empty;
//for (int i = 0; i < OGTekst5.Length; i++)
//{

//    Zad5TekstOdwrocony = Zad5TekstOdwrocony + OGTekst5Array[OGTekst5.Length - 1 - i];
//}
//Console.WriteLine(Zad5TekstOdwrocony);

////Zad 6
//Console.WriteLine("Wypisz zdanie:");
//string OGTekst6 = Console.ReadLine().Replace(" ", "").ToLower();
//char[] OGTekst6Array = OGTekst6.ToCharArray();
//string Zad6TekstOdwrocony = string.Empty;
//for (int i = 0; i < OGTekst6.Length; i++)
//{

//    Zad6TekstOdwrocony = Zad6TekstOdwrocony + OGTekst6Array[OGTekst6.Length - 1 - i];
//}

//if (Zad6TekstOdwrocony == OGTekst6)
//{
//    Console.WriteLine("TAK");
//}
//else
//{
//    Console.WriteLine("NIE");
//}

////Zad 7
//Console.WriteLine("Wypisz tekst:");
//string OGTekst7 = Console.ReadLine();
//string[] OGTekst7Split = OGTekst7.Trim().Split(' ');
//int IloscSlow = 0;

//for (int x = 0; x <= OGTekst7Split.Length; x++)
//{
//    IloscSlow = x;
//}
//Console.WriteLine(IloscSlow);

////Zad 8
//Console.WriteLine("Wypisz tekst:");
//string OGTekst8 = Console.ReadLine().ToString().Trim();
//string[] OGTekst8Split = OGTekst8.Split(' ');
//string Zad8Akronim = String.Empty;
//for (int i = 0; i < OGTekst8Split.Length; i++)
//{
//    Zad8Akronim = Zad8Akronim + OGTekst8Split[i][0];
//}
//Console.WriteLine(Zad8Akronim);

////Zad 9
//Console.WriteLine("Wypisz tekst:");
//string OGTekst9 = Console.ReadLine().Trim();

//int NaKtorymZnakuMalpa = OGTekst9.IndexOf("@") + 1;

//string OGTekst9Split = OGTekst9.Substring(NaKtorymZnakuMalpa, (OGTekst9.Length - (NaKtorymZnakuMalpa)));
//Console.WriteLine(OGTekst9Split);

////Zad 10
//Console.Write("Wypisz tekst:");
//string OGTekst10 = Console.ReadLine();
//Console.WriteLine("Wypisz zakazane słowa:");
//string[] zalazaneZlowa10 = Console.ReadLine().Split(" ");
//string[] listaOGTekstu10 = OGTekst10.Trim().Split(" ");
//string pelneSlowo = string.Empty;
//foreach(string slowo in listaOGTekstu10)
//{
//    for (int Z10 = 0; Z10 < listaOGTekstu10.Length; Z10++)
//    {
//        for (int ZakazaneZ10 = 0; ZakazaneZ10 < zalazaneZlowa10.Length; ZakazaneZ10++)
//        {
//            if (listaOGTekstu10[Z10].ToLower() == zalazaneZlowa10[ZakazaneZ10])
//            {
//                listaOGTekstu10[Z10] = new string('*', listaOGTekstu10[Z10].Length);
//            }
//        }
//    }
//}

//foreach(string word in listaOGTekstu10)
//{
//     pelneSlowo += word + " ";
//}
//pelneSlowo.Trim();
//Console.WriteLine(pelneSlowo);

////Zad 11
//Console.WriteLine("Wypisz tekst:");
//string OGTekst11 = Console.ReadLine();
//string[] listaOGTekstu11 = OGTekst11.Trim().Split(" ");
//string[] listaCyfr11 = "1 2 3 4 5 6 7 8 9 0".Trim().Split(" ");

//for (int i11 = 0; i11 < listaOGTekstu11.Length; i11++)
//{
//    for (int j11 = 0; j11 < listaCyfr11.Length; j11++)
//    {
//        if (listaOGTekstu11[i11] == listaCyfr11[j11])
//        {
//            string ReplaceWith = string.Empty;
//            switch (listaOGTekstu11[i11])
//            {
//                case "1":
//                    ReplaceWith = "jeden";
//                    break;
//                case "2":
//                    ReplaceWith = "dwa";
//                    break;
//                case "3":
//                    ReplaceWith = "trzy";
//                    break;
//                case "4":
//                    ReplaceWith = "cztery";
//                    break;
//                case "5":
//                    ReplaceWith = "pięć";
//                    break;
//                case "6":
//                    ReplaceWith = "sześć";
//                    break;
//                case "7":
//                    ReplaceWith = "siedem";
//                    break;
//                case "8":
//                    ReplaceWith = "osiem";
//                    break;
//                case "9":
//                    ReplaceWith = "dziewięć";
//                    break;
//                case "0":
//                    ReplaceWith = "zero";
//                    break;
//            }
//            listaOGTekstu11[i11] = listaOGTekstu11[i11].Replace(listaOGTekstu11[i11], ReplaceWith);
//        }
//    }
//}
//string EndString11 = string.Join(" ", listaOGTekstu11);
//Console.WriteLine(EndString11);

////Zad 12
//string dlugiTekst12 = "The city woke up slowly, stretching its streets under the pale morning light, while unseen stories quietly unfolded behind every closed door.";
//Console.WriteLine("Wypisz słowo:");
//string OGTekst12 = Console.ReadLine();
//    if (dlugiTekst12.Contains(OGTekst12))
//    {
//        int index12 = dlugiTekst12.IndexOf(OGTekst12);
//        Console.WriteLine($"Znaleziono na indeksie: {index12}");
//    }
//    else
//    {
//        Console.WriteLine("Nie znaleziono słowa.");
//    }

////Zad 13
//Console.WriteLine("Wypisz swoje imię i nazwisko:");
//string OGTekst13 = Console.ReadLine();
//string[] listOGTekst13 = OGTekst13.ToUpper().Trim().Split(" ");

//string imie = listOGTekst13[0];
//string nazwisko = listOGTekst13[1];
//listOGTekst13[0] = imie.Substring(0, 1) + listOGTekst13[0].Substring(1).ToLower();
//listOGTekst13[1] = nazwisko.Substring(0, 1) + listOGTekst13[1].Substring(1).ToLower();
//Console.WriteLine(listOGTekst13[0] + " " + listOGTekst13[1]);

////Zad 14
//Console.WriteLine("Wypisz tekst:");
//string OGTekst14 = Console.ReadLine().Trim();
//string tekstDoWypisania14 = string.Empty;
//for (int i14 = 0; i14 < OGTekst14.Length; i14++)
//{
//    if (i14 % 2 == 0)
//    {
//        tekstDoWypisania14 += Char.ToUpper(OGTekst14[i14]);
//    }
//    else if (i14 % 2 == 1)
//    {
//        tekstDoWypisania14 += Char.ToLower(OGTekst14[i14]);
//    }
//}
//Console.WriteLine(tekstDoWypisania14);

////Zad 15
//Console.WriteLine("Wypisz tekst:");
//string OGTekst15 = Console.ReadLine().Trim();
//string[] listaOGTekst15 = OGTekst15.Split(" ");
//string odwroconyTekst = string.Empty;

//for (int x15 = listaOGTekst15.Length -1; x15 >= 0; x15--)
//{
//    odwroconyTekst += listaOGTekst15[x15] + " ";
//}
//odwroconyTekst.Trim();
//Console.WriteLine(odwroconyTekst);

////Zad 16
//Console.WriteLine("Wypisz tekst:");
//string OGTekst16 = Console.ReadLine().Trim();
//string[] listOGTekst16 = OGTekst16.Split(",");

//if(listOGTekst16.Length != 3)
//{
//    Console.WriteLine("Nie tak wpisałeś tekst.");
//}
//else
//{
//    Console.WriteLine("Imię: " + listOGTekst16[0]);
//    Console.WriteLine("Nazwisko: " + listOGTekst16[1]);
//    Console.WriteLine("Wiek: " + listOGTekst16[2]);
//}

////Zad 17
//Console.WriteLine("Wypisz tekst:");
//string OGTekst17 = Console.ReadLine().ToString().Trim();
//char[] listOGTekst17 = OGTekst17.ToLower().ToCharArray();
//string samogloski = "aeiouy";
//char[] listSamogloski = samogloski.ToCharArray();
//int spolgloskiIlosc = 0;
//int samogloskiIlosc = 0;
//for (int i = 0; i < OGTekst17.Length; i++)
//{
//    if (char.IsLetter(listOGTekst17[i]))
//    {
//        if (listOGTekst17[i] == listSamogloski[0] || listOGTekst17[i] == listSamogloski[1] || listOGTekst17[i] == listSamogloski[2] || listOGTekst17[i] == listSamogloski[3] || listOGTekst17[i] == listSamogloski[4] || listOGTekst17[i] == listSamogloski[5])
//        {
//            samogloskiIlosc++;
//        }
//        else
//        {
//            spolgloskiIlosc++;
//        }
//    }
//}
//Console.WriteLine("Liczba samogłosek: " + samogloskiIlosc);
//Console.WriteLine("Liczba spółgłosek: " + spolgloskiIlosc);

//zad 18
Console.WriteLine("Wypisz tekst:");
string OGTekst18 = Console.ReadLine().Trim().ToString();
Console.WriteLine("Wypisz kod:");
string kod18 = Console.ReadLine().Trim().ToString();
int kod = int.Parse(kod18);
string zaszyfrowanyTekst = string.Empty;
foreach (char n in OGTekst18)
{
    if (char.IsLetter(n))
    {
        char offset = char.IsUpper(n) ? 'A' : 'a';
        char shifted = (char)(((n - offset + kod) % 26) + offset);
        zaszyfrowanyTekst += shifted;
    }
    else
    {
        zaszyfrowanyTekst += n;
    }
}
Console.WriteLine(zaszyfrowanyTekst);