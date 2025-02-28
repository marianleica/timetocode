using System;

// https://www.pbinfo.ro/probleme/categorii/12/elemente-de-baza-ale-limbajului-structura-de-decizie?start=0
// clasa a ix-a
// Elemente de baza ale limbajului
// Structura de decizie

// #109 Să se scrie un program care citeşte de la tastatură un număr natural şi verifică dacă numărul este par sau impar.

Console.WriteLine("Alege numar pentru a vedea daca e par sau impar: ");
int n1 = Convert.ToInt32(Console.ReadLine());
    if (n1 % 2 == 0)
    {
        Console.WriteLine("Numarul este par");
    }
    else
    {
        Console.WriteLine("Numarul este impar");
    }
Console.ReadLine("Urmatoarea solutie...");

// #105 Să se scrie un program care determină maximul a două numere întregi citite de la tastatură.

Console.WriteLine("Alege doua numere pentru a vedea care dintre ele e maximul: ");
Console.WriteLine("Primul numar: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al doilea numar: ");
int m2 = Convert.ToInt32(Console.ReadLine());
    if ( m2 > n2 )
    {
        Console.WriteLine(m2 + " este maximul");
    }
    else
    {
        Console.WriteLine(n2 + " este maximul");
    }

Console.ReadLine("Urmatoarea solutie...");

// #816 Determinați câte sticle de x litri cu apă trebuie deschise pentru a umple un vas de y litri.

Console.WriteLine("Alege doua numere pentru a vedea cate sticle de x litri cu apa trebuie deschise pentru a umple un vas de y litri: ");
Console.WriteLine("De cati litri este sticla: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cate litri are vasul: ");
int y = Convert.ToInt32(Console.ReadLine());
int rez = 0;

if (y > x)
{
    rez = y / x + 1;
}
else
{
    rez = 0;
}

Console.WriteLine("Pentru a umple vasul de " + y + " litri trebuie deschise " + rez + " sticle de " + x + " litri");
Console.ReadLine("Urmatoarea solutie...");

// #832 Fiind dată nota unui elev să se afișeze dacă acesta este corigent sau promovat.

Console.WriteLine("Alege nota elevului pentru a vedea daca este corigent sau promovat: ");
int nota = Convert.ToInt32(Console.ReadLine());
if (nota < 5)
{
    Console.WriteLine("Elevul este corigent");
}
else
{
    Console.WriteLine("Elevul este promovat");
}
Console.ReadLine("Urmatoarea solutie...");

// #469 Se dau trei numere naturale a b x. Să se verifice dacă numărul x aparține intervalului [a,b].

Console.WriteLine("Alege trei numere naturale a, b, si x pentru a verifica daca numarul x apartine intervalului [a,b]: ");
Console.WriteLine("Primul numar: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al doilea numar: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al treilea numar: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x >= a && x <= b)
{
    Console.WriteLine("Numarul " + x + " apartine intervalului [" + a + "," + b + "]");
}
else
{
    Console.WriteLine("Numarul " + x + " nu apartine intervalului [" + a + "," + b + "]");
}

Console.ReadLine("Urmatoarea solutie...");

// #3185 La un concurs pot participa copii cu vârste între a și b ani, inclusiv. Gigel are n ani. Stabiliți dacă poate participa la concurs.

Console.WriteLine("Alege trei numere naturale a, b, si n pentru a verifica daca copilul cu varsta n poate participa la concurs: ");
Console.WriteLine("Varsta minima: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Varsta maxima: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Varsta copilului: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= a && n <= b)
{
    Console.WriteLine("Copilul cu varsta " + n + " poate participa la concurs");
}
else
{
    Console.WriteLine("Copilul cu varsta " + n + " nu poate participa la concurs");
}

Console.ReadLine("Urmatoarea solutie...");

// #106 Se dau 3 numere întregi. Calculaţi minimul celor 3 numere date.

Console.WriteLine("Alege trei numere pentru a calcula minimul: ");
Console.WriteLine("Primul numar: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al doilea numar: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al treilea numar: ");
int c1 = Convert.ToInt32(Console.ReadLine());

if (a1 < b1 && a1 < c1)
{
    Console.WriteLine("Minimul este " + a1);
}
else if (b1 < a1 && b1 < c1)
{
    Console.WriteLine("Minimul este " + b1);
}
else
{
    Console.WriteLine("Minimul este " + c1);
}

Console.ReadLine("Urmatoarea solutie...");

// #4339 Se dau 3 numere natural a, b, si c. Stabiliți dacă dintre cele trei numere citite sunt mai multe numere pare sau mai multe impare.

Console.WriteLine("Alege trei numere pentru a verifica daca sunt mai multe numere pare sau impare: ");
Console.WriteLine("Primul numar: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al doilea numar: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al treilea numar: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a % 2 == 0 && b % 2 == 0 && c % 2 == 0) || (a % 2 == 0 && b % 2 == 0) || (a % 2 == 0 && c % 2 == 0) || (b % 2 == 0 && c % 2 == 0))
{
    Console.WriteLine("Sunt mai multe numere pare");
}
else
{
    Console.WriteLine("Sunt mai multe numere impare");
}

Console.ReadLine("Urmatoarea solutie...");

// #559 Se dau 5 numere distincte. Să se determine suma celor mai mari 3 dintre ele.

Console.WriteLine("Alege 5 numere distincte pentru a determina suma celor mai mari 3 dintre ele: ");
Console.WriteLine("Primul numar: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al doilea numar: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al treilea numar: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al patrulea numar: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Al cincilea numar: ");
int e = Convert.ToInt32(Console.ReadLine());

int[] arr = { a, b, c, d, e };
Array.Sort(arr);

int sum = arr[4] + arr[3] + arr[2];

Console.WriteLine("Suma celor mai mari 3 numere este: " + sum);

