using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema_SET_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MENU();

                int n;
                Console.WriteLine();
                Console.WriteLine("Daca vreti sa iesiti din aplicatie introduceti 0.");
                Console.Write("Introduceti numarul exercitiului dorit:");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: ex1(); break;
                    case 2: ex2(); break;
                    case 3: ex3(); break;
                    case 4: ex4(); break;
                    case 5: ex5(); break;
                    case 6: ex6(); break;
                    case 7: ex7(); break;
                    case 8: ex8(); break;
                    case 9: ex9(); break;
                    case 10: ex10(); break;
                    case 11: ex11(); break;
                    case 12: ex12(); break;
                    case 13: ex13(); break;
                    case 14: ex14(); break;
                    case 15: ex15(); break;
                    case 16: ex16(); break;
                    case 17: ex17(); break;
                    case 18: ex18(); break;
                    case 19: ex19(); break;
                    case 20: ex20(); break;
                    case 21: ex21(); break;
                    case 0:return;
                        default:Console.WriteLine("Numar introdus gresit");break;

                }
            }
        }
        private static void MENU()
        {
            Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. \r\n2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. \r\n3.Determinati daca n se divide cu k, unde n si k sunt date de intrare. \r\n4.Detreminati daca un an y este an bisect. \r\n5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. \r\n6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. \r\n7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. \r\n8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  \r\n9.Afisati toti divizorii numarului n. \r\n10.Test de primalitate: determinati daca un numar n este prim.\r\n11.Afisati in ordine inversa cifrele unui numar n. \r\n12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. \r\n13.Determianti cati ani bisecti sunt intre anii y1 si y2.\r\n14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. \r\n15.Se dau 3 numere. Sa se afiseze in ordine crescatoare. \r\n16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)\r\n17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. \r\n18.Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. \r\n19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. \r\n20.Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)\r\nO fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0\r\nO fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. \r\nO fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. \r\n21.Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\". ");
        }
      
        /// <summary>
        /// Rezolvam ecuatia de gradul 1 cu o necunoscuta.
        /// </summary>
        private static void ex1()
        {
            Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.");
            Console.WriteLine("Introduceti numerele:");
            float a, b;
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            b = float.Parse(Console.ReadLine());
            float x = -b / a;
            Console.WriteLine("x=" + x);
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Rezolvam ecuatia de gradul 2 cu o necunoscuta.
        /// </summary>
        private static void ex2()
        {
            Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
            Console.WriteLine("Introduceti numerele:");
            float a, b, c, d;
            Console.Write("a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("b=");
            b = float.Parse(Console.ReadLine());
            Console.Write("c=");
            c = float.Parse(Console.ReadLine());
            d = (b * b) - 4 * a * c;
            if (d >= 0)
            {
                float x1 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                float x2 = (-b + (float)Math.Sqrt(d)) / (2 * a);
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii reale");

            }
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinam daca n se divide cu k.
        /// </summary>
        private static void ex3()
        {
            Console.WriteLine("3.Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            Console.WriteLine("Introduceti numerele:");
            float n, k;
            Console.Write("n=");
            n = float.Parse(Console.ReadLine());
            Console.Write("k=");
            k = float.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("{0} se divide cu {1}", n, k);
            }
            else
            {
                Console.WriteLine(n + " nu se divide " + k);
            }
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Detreminam daca un an y este an bisect.
        /// </summary>
        private static void ex4()
        {
            Console.WriteLine("Detreminati daca un an y este an bisect.");
            Console.Write("Introduceti anul:");
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine(y + " este an bisect");
            }
            else
            {
                Console.WriteLine(y + " nu este an bisect");
            }
            Revenire();
            Console.ReadKey();
            Console.Clear();

        }
        /// <summary>
        /// Afisam a k-a cifra a unui numar . 
        /// </summary>
        private static void ex5()
        {
            Console.WriteLine("5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            int x, k;
            Console.Write("Introduceti numarul:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Introduceti a k-a cifra:");
            k=int.Parse(Console.ReadLine());
           
            for (int i=1; i<k; i++ ) 

            {
                x = x / 10;
            }
            x = x % 10;
            Console.WriteLine("A "+k+"-a cifra este "+x);
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Aflam daca 3 numere pot fi laturile unui triunghi.
        /// </summary>
        private static void ex6()
        {
            Console.WriteLine("6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            Console.WriteLine("Introduceti numerele:");
            int a, b, c;
            Console.Write("a=");
            a= int.Parse(Console.ReadLine());
            Console.Write("b=");
            b= int.Parse(Console.ReadLine());
            Console.Write("c=");
            c= int.Parse(Console.ReadLine());   
            if(a<b+c && b<a+c && c<a+b)
            {
                Console.WriteLine("{0}, {1} si {2} pot fi laturile unui triunghi",a,b,c);
            }
            else
            {
                Console.WriteLine("{0}, {1} si {2} nu pot fi laturile unui triunghi", a, b, c);
            }
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Inversam valorile variabilelor(cu ajutor).
        /// </summary>
        private static void ex7()
        {
            Console.WriteLine("7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
            Console.WriteLine("Introduceti numerele:");
            int a,b,aux;
            Console.Write("a=");
            a= int.Parse(Console.ReadLine());
            Console.Write("b=");
            b= int.Parse(Console.ReadLine());
            aux = b;
            b = a;
            a = aux;
            Console.WriteLine("a="+ a +" "+ "b="+ b);
            Revenire();
            Console.ReadKey();
            Console.Clear();

        }
        /// <summary>
        /// Inversam valorile variabilelor(fara ajutor).
        /// </summary>
        private static void ex8()
        {
            Console.WriteLine("8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            Console.WriteLine("Introduceti numerele:");
            int a, b;
            Console.Write("a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            b=int.Parse(Console.ReadLine());
            a =  a + b;
            b = a - b;
            a -=  b;
            Console.WriteLine("a="+a + " " +"b="+ b);
            Revenire();
            Console.ReadKey();       
            Console.Clear();
        }
        /// <summary>
        /// Afisam toti divizorii unui numar.
        /// </summary>
        private static void ex9()
        {
            Console.WriteLine("9.Afisati toti divizorii numarului n. ");
            int x;
            Console.Write("n=");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine($"Divizorii lui {x} sunt: ");
            for(int i=1;i<=x;i++)
                if(x%i==0)
                {
                    Console.Write(i+" "); 
                    
                }
            Console.WriteLine();
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Verificam daca un numar este prim.
        /// </summary>
        private static void ex10()
        {
           
            Console.WriteLine("10.Test de primalitate: determinati daca un numar n este prim.");
            int n;
            Console.Write("Introduceti numarul:");
            n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Nu e prim");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("E prim");
                return;
            }

            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine("Nu e prim");
                    return;
                }
            }
            Console.WriteLine("E prim");
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Afisam in ordine inversa cifrele unui numar n. 
        /// </summary>
        private static void ex11()
        {
            Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n. ");
            int n;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            int m = 0;
            Console.WriteLine("Inversul numarului este:");
            while (n % 10 == 0) // pentru a scrie 0-urile daca numarul se termina in unul sau mai multe 0-uri
            {
                n /= 10;
                Console.Write("0");
            }
            while (n!=0)
            {
                m = m * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine(m);
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinam cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        /// </summary>
        private static void ex12()
        {
            //!! nu ii gata
            Console.WriteLine("12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ");
            int a, b, n;
            Console.Write("a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            b=int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            int aux = 0;
            for(int i=a; i<=b; i++)
            {
                if (i%n ==0)
                {
                    aux++;
                    
                }
             
            }
            Console.WriteLine("In intervalul [" + a + "," + b + "]," + n + " se divide cu " + aux + " numere");
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinam cati ani bisecti sunt intre anii y1 si y2.
        /// </summary>
        private static void ex13()
        {
            Console.WriteLine("13.Determianti cati ani bisecti sunt intre anii y1 si y2.");
            int y1, y2;
            Console.Write("Introduceti primul an:");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea an:");
            y2= int.Parse(Console.ReadLine());
            int ani=0;
            for (int i = y1; i <= y2; i++)
            {
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    ani++;
                }
            
            }
            Console.WriteLine("Intre ani " + y1 + "," + y2 + " sunt " + ani + " ani bisecti.");
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinam daca un numar este palindrom.
        /// </summary>
        private static void ex14()
        {
         Console.WriteLine("14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ");
            int n,nr,aux;
            Console.Write("n=");
            n= int.Parse(Console.ReadLine());
            nr = n;
            aux = 0;
            while (nr != 0)
            {
                aux = aux * 10 + nr % 10;
                nr /= 10;
            }
            if (n == aux)
                Console.WriteLine($"Numarul {n} este palindrom");
            else Console.WriteLine($"Numarul {n} nu este palindrom");
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Afisam 3 numere in ordine crescatoare.
        /// </summary>
        private static void ex15()
        {
            int x, y, z,aux=0;
            Console.WriteLine("15.Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
            Console.WriteLine("Introduceti numerele:");
            Console.Write("x=");
            x=int.Parse(Console.ReadLine());
            Console.Write("y=");
            y=int.Parse(Console.ReadLine());
            Console.Write("z=");
            z=int.Parse(Console.ReadLine());
            if (x > y) { aux = x;x = y;y = aux;aux = 0; }
            if (x>z) { aux = x;x = z;z = aux;aux = 0; }
            if(y > z) { aux = y;y = z;z = aux; aux = 0; }
            Console.WriteLine("x={0},y={1},z={2}",x,y,z);
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Afisam 5 numere in ordine crescatoare.
        /// </summary>
        private static void ex16()
        {
            int a, b, c,d,e, aux = 0;
            Console.WriteLine("16.Se dau 5 numere. Sa se afiseze in ordine crescatoare.(nu folositi tablouri)");
            Console.WriteLine("Introduceti numerele:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            d = int.Parse(Console.ReadLine());
            Console.Write("e=");
            e = int.Parse(Console.ReadLine());
            if (a > b) { aux = a; a = b; b = aux; aux = 0; }
            if (a > c) { aux = a; a = c; c = aux; aux = 0; }
            if (a>d) { aux= a; a = d; d = aux; aux = 0; }
            if (a > e) { aux = a; a = e; e = aux;aux = 0; }
            if (b > c) { aux = b; b = c; c = aux; aux = 0; }
            if (b > d) { aux = b; b = d; d = aux; aux = 0; }
            if (b> e) { aux = b; b = e; e = aux; aux=0; }
            if (c > d) { aux = c; c = d;d = aux; aux = 0; }
            if (c > e) { aux = c; c = e;e = aux; aux = 0; }
            if(d > e) { aux = d;d = e; e = aux; aux = 0; }
            
            Console.WriteLine("a={0},b={1},c={2},d={3},e={4}", a, b, c,d,e);
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Algoritmul lui Euclid
        /// </summary>
        private static void ex17()
        {
            Console.WriteLine("17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ");
            Console.WriteLine("Introduceti numerele:"); 
            int x, y;
            Console.Write("x=");
            x=int.Parse(Console.ReadLine());
            Console.Write("y=");
            y=int.Parse(Console.ReadLine());
            int x1 = x;
            int y1 = y;
            while(y1 !=0)
            {
                int r = x1 % y1;
                x1 = y1;
                y1 = r;
            }
            int cmmdc = x1;
            Console.WriteLine("CMMDC="+cmmdc);
            int cmmmc = (x * y) / cmmdc;
            Console.WriteLine("CMMMC="+cmmmc);
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Descompunerea in factorii primi a unui numar.
        /// </summary>
        private static void ex18()
        {
            Console.WriteLine("18.Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. ");
            int n;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());

            Console.Write($"Descompunerea in factori primi a lui {n} este: ");
            int d = 2;
            while (n > 1)
            {
                int p = 0;
                while (n % d == 0)
                {
                    n /= d;
                    p++;
                }
                if (p != 0)
                {
                    Console.Write($"{d}^{p}*");
                }
                if (d == 2)
                    d++;
                else
                    d += 2;
            }
            Console.WriteLine();
            Revenire();
            Console.ReadKey();
            Console.Clear();    

        }
        /// <summary>
        /// Determinam daca un numar e format doar cu 2 cifre care se pot repeta.
        /// </summary>
        private static void ex19()
        {
            Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");
            

            Console.Write("Introduceti numarul:");

            int n = Convert.ToInt32(Console.ReadLine());

            //a set that stores digits from number n, if the size of the set is 2 the answer yes and no otherwise.
            SortedSet<int> cifre = new SortedSet<int>();
            int aux = n;
            while (aux > 0)
            {
                cifre.Add(aux % 10);
                aux /= 10;
            }

            if (cifre.Count() == 2)
                Console.WriteLine($"Numarul {n} este format doar din 2 tipuri de cifre");
            else
                Console.WriteLine($"Numarul {n} nu este format doar din 2 tipuri de cifre");
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Afisam fractia m/n in format zecimal.
        /// </summary>
        private static void ex20()
        {
            Console.WriteLine("20.Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)\r\nO fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0\r\nO fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. \r\nO fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. ");
            int m , n ;
            Console.Write("m=");
            m=int.Parse(Console.ReadLine());
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
          
            int parteInt, parteFract;
            parteInt = m / n; 
            parteFract = m % n; 
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
               
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
            Revenire();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Ghicim un numar intre 1 si 1024.
        /// </summary>
        private static void ex21()
        {
            Console.WriteLine("21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?");

            int n = new Random().Next(1, 1025);
            int x = 0;
            Console.WriteLine("Ghiciti un numar intre 1 si 1024..");
            Console.WriteLine();
            while (n != x)
            {
                Console.Write("Numarul este mai mare sau egal decat.. ");
                x = int.Parse(Console.ReadLine());
                if (n > x)
                    Console.WriteLine("DA");
                else
                if (n < x)
                    Console.WriteLine("NU");
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Felicitari! Numarul este {n}");
                    Console.WriteLine();
                }
            }
            Revenire();
            Console.ReadKey();  
            Console.Clear();
        }

        private static void Revenire()
        {
            Console.WriteLine("Apasa orice buton pentru a reveni la meniu.");
        }
    }

}
