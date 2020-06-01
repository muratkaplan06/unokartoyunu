using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unokartoyunu
{
    class Program
    {


        static string oyuncu2kartat(string[] o2kart, string bk, int r2)
        {
            
            bool cevap = true;
            string kartat2 = " ";
            bool bayrak1 = true;
            bool kont1 = true;
            for (int i = 0; i < o2kart.Length && bayrak1 == true; i++)
            {


                if (bk.Substring(0, 1) == o2kart[i].Substring(0, 1) || bk.Substring(1, 1) == o2kart[i].Substring(1, 1))
                {
                    kartat2 = o2kart[i];
                    o2kart[i] = "bos";
                    bayrak1 = false;
                    cevap = true;
                }
                else
                    cevap = false;
            }
            if (cevap == false)
            {
                Random gen1 = new Random();
                if (r2 > 0)
                {
                    
                    int uret = gen1.Next(1, 3);
                    r2--;
                    if (uret == 1)
                        kartat2 = "k" + bk.Substring(1, 1);
                    else if (uret == 2)
                        kartat2 = "m" + bk.Substring(1, 1);
                    else if (uret == 3)
                        kartat2 = "s" + bk.Substring(1, 1);
                    Console.WriteLine();
                    Console.WriteLine("oyuncu-2 renk değiştirme kartı kullanılarak rd,{0}'a dönüştürüldü", kartat2);

                    for (int j = 0; j < o2kart.Length && kont1 == true; j++)
                        if (o2kart[j] == "rd")
                        {
                            o2kart[j] = "bos";
                            kont1 = false;
                        }
                    
                }
                else if (r2 == 0)
                    kartat2 = "pas";
            }

             return kartat2;
        }
        static string Oyuncu2basla(string[] oyuncu2kart,int t2)
        {
            bool kontrol;
            string oyuncu2hamlesi=" ";
            Random generate1 = new Random();
            if (t2 == 1)
            {
                do
                {
                    int n2uret = generate1.Next(1, 6);
                    if (oyuncu2kart[n2uret] != "rd")
                    {

                        kontrol = false;
                        oyuncu2hamlesi = oyuncu2kart[n2uret];
                    }
                    else
                        kontrol = true;
                } while (kontrol == true);
                for (int j = 0; j < 6; j++)
                {
                    if (oyuncu2kart[j] == oyuncu2hamlesi)
                    {
                        oyuncu2kart[j] = "bos";
                    }
                }
            }
                return oyuncu2hamlesi;
        }
        static string Oyuncu3basla(string[] oyuncu3kart, int t3)
        {
            bool kontrol;
            string oyuncu3hamlesi = " ";
            Random generate2 = new Random();
            if (t3 == 1)
            {
                do
                {
                    int n3uret = generate2.Next(1, 6);
                    if (oyuncu3kart[n3uret] != "rd")
                    {

                        kontrol = false;
                        oyuncu3hamlesi = oyuncu3kart[n3uret];
                    }
                    else
                        kontrol = true;
                } while (kontrol == true);
                for (int j = 0; j < 6; j++)
                {
                    if (oyuncu3kart[j] == oyuncu3hamlesi)
                    {
                        oyuncu3kart[j] = "bos";
                    }
                }
            }
            return oyuncu3hamlesi;
        }

        static string oyuncu3kartat(string[] o3kart, string o2h,int r3)
        {
            string kartat3 = " ";
            bool bayrak2=true;
            bool kont2 = true;
            bool cvp = true;
           
            for (int i = 0; i < o3kart.Length && bayrak2 == true; i++)
            {
                if (o2h.Substring(0, 1) == o3kart[i].Substring(0, 1) || o2h.Substring(1, 1) == o3kart[i].Substring(1, 1))
                {
                    kartat3 = o3kart[i];
                    o3kart[i] = "bos";
                    bayrak2 = false;
                    cvp = true;
                }
                else
                    cvp = false;
            }
                if(cvp==false)    
                {
                    Random gen2 = new Random();
                  if (r3 > 0)
                  {
                    int uret = gen2.Next(1, 3);
                    if (uret == 1)
                        kartat3 = "k" + o2h.Substring(1, 1);
                    else if (uret == 2)
                        kartat3 = "m" + o2h.Substring(1, 1);
                    else if (uret == 3)
                        kartat3 = "s" + o2h.Substring(1, 1);
                    Console.WriteLine();
                    Console.WriteLine("oyunncu-3 renk değiştirme kartı kullanılarak rd,{0}'a dönüştürüldü", kartat3);
                    for (int j = 0; j < o3kart.Length && kont2 == true; j++)
                        if (o3kart[j] == "rd")
                        {
                            o3kart[j] = "bos";
                            kont2= false;
                        }
                    r3--;
                  }
                  else if(r3==0)
                    kartat3 = "pas";
                }
                return kartat3;
        }
        static bool bitiskontrolu(string[] BK,string[] O2K,string[] O3K,string[] biten)
        {
            bool bts = false;
            int j = 0;
            int sayac1=0, sayac2=0, sayac3=0;
            for(int i=0;i<6;i++)
            {
                if (BK[i] == "bos")
                    sayac1++;
                        if (O2K[i] == "bos")
                           sayac2++;
                           if (O3K[i] == "bos")
                              sayac3++;

            }
            if (sayac1 == 6 || sayac2 == 6 || sayac3 == 6)
            {
                bts = true;
                if (sayac1 == 6)
                    biten[j] = "oyuncu1 kazandı";
                else
                    biten[j] = "0";
                     j++;
                     if (sayac2 == 6)
                        biten[j] = "oyuncu2 kazandı";
                     else
                        biten[j] = "0";
                        j++;
                          if (sayac3 == 6)
                            biten[j] = "oyuncu3 kazandı";
                          else
                            biten[j] = "0";
            }

            return bts;
        }

        static void Main(string[] args)
        {
            string yerdekikart=" ";
            int n;
            string sonkart = " ";
            bool kont, bitis=false,rdkontrol,rdyokmu=false,flag=true; 
            int rd1 = 0;
            int rd2 = 0;
            int rd3= 0;
            string renk=" " ,yenirenk=" ";
            string kartsec1,kartseca,secim1,secim2;
            bool kartatıs = true,byrk=false;
            string oyuncu2hamlesi=" ";
            string oyuncu3hamlesi=" ";
            Random rastgele = new Random();
            string[] Kartlar = { "k1", "k2", "k3", "k4", "k5", "m1", "m2", "m3", "m4", "m5", "s1", "s2", "s3", "s4", "s5", "rd", "rd", "rd" };
            string[] benimkartlarim = new string[6];
            string[] oyuncu2Kartlari = new string[6];
            string[] oyuncu3Kartlari = new string[6];
            string[] bitiren=new string[3];
            int x = 0, y = 0, z = 0, tur = 1;
            int tur2,tur3;
            while (true)
            {
                if (x < 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int uretilen = rastgele.Next(0, 18);
                        if (Kartlar[uretilen] != "atandı")
                        {
                            benimkartlarim[x] = Kartlar[uretilen];
                            Kartlar[uretilen] = "atandı";
                            x++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                else if (y < 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int uretilen = rastgele.Next(0, 18);
                        if (Kartlar[uretilen] != "atandı")
                        {
                            oyuncu2Kartlari[y] = Kartlar[uretilen];
                            Kartlar[uretilen] = "atandı";
                            y++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                else if (z < 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int uretilen = rastgele.Next(0, 18);
                        if (Kartlar[uretilen] != "atandı")
                        {
                            oyuncu3Kartlari[z] = Kartlar[uretilen];
                            Kartlar[uretilen] = "atandı";
                            z++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                else
                {
                    break;
                }

            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("benim kartlarim:");
            for (int i = 0; i < 6; i++)
                Console.Write(benimkartlarim[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
                if (benimkartlarim[i] == "rd")
                    rd1++;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("oyuncu2 kartlarim:");
            for (int i = 0; i < 6; i++)
                Console.Write(oyuncu2Kartlari[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
                if (oyuncu2Kartlari[i] == "rd")
                    rd2++;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("oyumcu3 kartlarim:");
            for (int i = 0; i < 6; i++)
                Console.Write(oyuncu3Kartlari[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
                if (oyuncu3Kartlari[i] == "rd")
                    rd3++;
            Console.ForegroundColor = ConsoleColor.White;
            int baslangıc = rastgele.Next(1, 4);
            if (baslangıc == 1)
                Console.WriteLine("Oyuna sen başlıyorsun");
            else if (baslangıc == 2)
                Console.WriteLine("Oyuna 2.Oyuncu başlıyor");
            else if (baslangıc == 3)
                Console.WriteLine("Oyuna 3.Oyuncu başlıyor");
            Console.WriteLine("kirmizi icin:k,mavi icin:m,sari için:s,pas için:pas,renk degitirme için:rd yaziniz.");
            Console.WriteLine();
            bitis = false;
            while (kartatıs == true && bitis==false)
            {
                if (baslangıc == 1)
                {
                    if (tur == 1)
                    {
                        do
                        {
                            n = 0;
                            byrk = false;
                            Console.Write("kart tercihin= ");
                            kartsec1 = Convert.ToString(Console.ReadLine());
                            if ((kartsec1.ToLower() == "pas" || kartsec1.ToLower() == "rd") && tur == 1)
                            {
                                n++;
                                byrk = true;
                            }
                            if (n > 0)
                            {
                                Console.WriteLine("oyuna pas veya renk değiştirme kartı ile baslamazsın");
                                Console.WriteLine("tekrar kart atınız");
                            }

                        } while (byrk == true);


                        for (int j = 0; j < 6; j++)
                        {
                            if (benimkartlarim[j] == kartsec1.ToLower())
                            {
                                oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, benimkartlarim[j], rd2);
                                oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, oyuncu2hamlesi, rd3);
                                sonkart = oyuncu3hamlesi;
                                yerdekikart = benimkartlarim[j];
                                benimkartlarim[j] = "bos";
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("atılan kart:" + yerdekikart);
                                Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                                Console.WriteLine("ücüncü oyuncu:" + oyuncu3hamlesi);
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("kalan kartlarım");
                        for (int i = 0; i < benimkartlarim.Length; i++)
                            Console.Write(benimkartlarim[i].ToLower() + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine();
                        tur++;
                    }
                    while (tur > 1 && bitis == false)
                    {
                        kont = true;
                        Console.WriteLine();
                        Console.WriteLine("{0}. tur", tur);
                        Console.Write("kart tercihin= ");
                        kartseca = Convert.ToString(Console.ReadLine());

                        if (kartseca.ToLower() == "pas")
                        {

                            oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, sonkart, rd2);
                            if (oyuncu2hamlesi != "pas")
                            {
                                oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, oyuncu2hamlesi, rd3);
                                if (oyuncu3hamlesi != "pas")
                                    sonkart = oyuncu3hamlesi;
                                else
                                    sonkart = oyuncu2hamlesi;
                            }
                            else
                            {
                                oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, sonkart, rd3);
                                if (oyuncu3hamlesi != "pas")
                                    sonkart = oyuncu3hamlesi;
                            }

                            yerdekikart = "pas";
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("atılan kart:" + yerdekikart);
                            Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                            Console.WriteLine("ücüncü oyuncu:" + oyuncu3hamlesi);
                            Console.ForegroundColor = ConsoleColor.White;
                            tur++;

                        }
                        else if (kartseca.ToLower() == "rd")
                        {
                            if (rd1 == 0)
                            {
                                Console.WriteLine("rd yok");
                                break;
                            }
                            else if (rd1 > 0)
                            {
                                bool kontrol = false;
                                do
                                {
                                    Console.WriteLine("renk seçiniz");
                                    renk = Convert.ToString(Console.ReadLine());
                                    if (renk == "m")
                                        yenirenk = "m" + sonkart.Substring(1, 1);
                                    else if (renk == "k")
                                        yenirenk = "k" + sonkart.Substring(1, 1);
                                    else if (renk == "s")
                                        yenirenk = "s" + sonkart.Substring(1, 1);
                                    else
                                    {
                                        Console.WriteLine("Hatalı renk girişi");
                                        kontrol = true;
                                    }
                                } while (kontrol == true);
                                oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, yenirenk, rd2);
                                if (oyuncu2hamlesi != "pas")
                                {
                                    oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, oyuncu2hamlesi, rd3);
                                    if (oyuncu3hamlesi != "pas")
                                        sonkart = oyuncu3hamlesi;
                                    else
                                        sonkart = yenirenk;
                                }
                                else
                                {
                                    oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, yenirenk, rd3);
                                    if (oyuncu3hamlesi != "pas")
                                        sonkart = oyuncu3hamlesi;
                                    else
                                        sonkart = yenirenk;
                                }
                                yerdekikart = yenirenk;
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("atılan kart:" + yerdekikart);
                                Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                                Console.WriteLine("ücüncü oyuncu:" + oyuncu3hamlesi);
                                Console.ForegroundColor = ConsoleColor.White;
                                for (int j = 0; j < benimkartlarim.Length && kont == true; j++)
                                    if (benimkartlarim[j] == "rd")
                                    {
                                        benimkartlarim[j]= "bos";
                                        kont = false;
                                    }
                                tur++;
                                rd1--;
                            }
                        }
                        else if (kartseca.ToLower().Substring(0, 1) == sonkart.Substring(0, 1) || kartseca.ToLower().Substring(1, 1) == sonkart.Substring(1, 1))
                        {
                            for (int i = 0; i < benimkartlarim.Length; i++)
                            {
                                if (benimkartlarim[i] == kartseca.ToLower())
                                {

                                    oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, benimkartlarim[i], rd2);
                                    if (oyuncu2hamlesi != "pas")
                                    {
                                        oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, oyuncu2hamlesi, rd3);
                                        if (oyuncu3hamlesi != "pas")
                                            sonkart = oyuncu3hamlesi;
                                        else
                                            sonkart = oyuncu2hamlesi;
                                    }
                                    else
                                    {
                                        oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, benimkartlarim[i], rd3);
                                        if (oyuncu3hamlesi != "pas")
                                            sonkart = oyuncu3hamlesi;
                                        else
                                            sonkart = benimkartlarim[i];
                                    }
                                    yerdekikart = benimkartlarim[i];
                                    benimkartlarim[i] = "bos";
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("atılan kart:" + yerdekikart);
                                    Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                                    Console.WriteLine("ücüncü oyuncu:" + oyuncu3hamlesi);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    tur++;
                                    break;
                                }
                            }

                        }
                        else if (kartseca.ToLower().Substring(0, 1) != sonkart.Substring(0, 1) || kartseca.ToLower().Substring(1, 1) != sonkart.Substring(1, 1))
                        {
                            Console.WriteLine("hatalı hamle");
                            if (rd1 == 0 && kartseca == "rd")
                                Console.WriteLine("hatalı hamle");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("kalan kartlarım");
                        for (int i = 0; i < benimkartlarim.Length; i++)
                            Console.Write(benimkartlarim[i] + " ");

                        Console.ForegroundColor = ConsoleColor.White;
                        bitis = bitiskontrolu(benimkartlarim, oyuncu2Kartlari, oyuncu3Kartlari, bitiren);
                        if (bitis == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("oyun sona erdi.");
                            for (int i = 0; i < 3&&flag==true; i++)
                            {
                                if (bitiren[i] != "0")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("{0} kazandı", bitiren[i]);
                                    flag = false;
                                }
                               
                            }
                        }
                    }

                }
                else if (baslangıc == 2)
                {
                    bool kontrolbaslangıc2 = false;
                    tur2 = 1;
                    if (tur2 == 1)
                    {
                        Console.WriteLine("{0}. tur", tur2);
                        oyuncu2hamlesi = Oyuncu2basla(oyuncu2Kartlari, tur2);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                        if (oyuncu2hamlesi != "pas")
                            sonkart = oyuncu2hamlesi;
                        do
                        {
                            Console.Write("kart tercihin:");
                            secim1 = Convert.ToString(Console.ReadLine());
                            if (secim1.ToLower().Substring(0, 1) == sonkart.Substring(0, 1) || secim1.ToLower().Substring(1, 1) == sonkart.Substring(1, 1))
                            {
                                oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, secim1, rd3);
                                yerdekikart = secim1;
                                kontrolbaslangıc2 = false;
                            }
                            else if (secim1.ToLower() == "rd")
                            {
                                do
                                {
                                    kontrolbaslangıc2 = false;
                                    if (rd1 == 0)
                                    {
                                        Console.WriteLine("rd yok");
                                        rdyokmu = true;
                                    }
                                    else if (rd1 > 0)
                                    {
                                        rdyokmu = false;
                                        bool kontrol = false;
                                        do
                                        {
                                            Console.WriteLine("renk seçiniz");
                                            renk = Convert.ToString(Console.ReadLine());
                                            if (renk == "m")
                                                yenirenk = "m" + sonkart.Substring(1, 1);
                                            else if (renk == "k")
                                                yenirenk = "k" + sonkart.Substring(1, 1);
                                            else if (renk == "s")
                                                yenirenk = "s" + sonkart.Substring(1, 1);
                                            else
                                            {
                                                Console.WriteLine("Hatalı renk girişi");
                                                kontrol = true;
                                            }
                                        } while (kontrol == true);
                                        yerdekikart = yenirenk;
                                        oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, yenirenk, rd2);
                                        Console.WriteLine();
                                        Console.WriteLine("rd,{0}'a dönüştürüldü", yerdekikart);
                                    }
                                } while (rdyokmu == true);
                            }
                            else if (secim1.ToLower() == "pas")
                            {
                                kontrolbaslangıc2 = false; ;
                                yerdekikart = "pas";
                                oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, oyuncu2hamlesi, rd3);
                            }
                            else
                            {
                                Console.WriteLine("hatalı hamle");
                                kontrolbaslangıc2 = true;
                            }
                        } while (kontrolbaslangıc2 == true);

                        Console.WriteLine();
                        Console.WriteLine("ucuncu oyuncu:" + oyuncu3hamlesi);
                        for (int j = 0; j < 6; j++)
                        {
                            if (benimkartlarim[j] == secim1.ToLower())
                            {
                                benimkartlarim[j] = "bos";
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("kalan kartlarım:");
                        for (int j = 0; j < 6; j++)
                            Console.Write(benimkartlarim[j] + " ");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                     
                        for (int j = 0; j < 6; j++)
                            Console.Write(oyuncu3Kartlari[j] + " ");
                        if (oyuncu3hamlesi != "pas")
                            sonkart = oyuncu3hamlesi;
                        else
                            if (yerdekikart != "pas")
                            sonkart = yerdekikart;
                        else
                            sonkart = oyuncu2hamlesi;

                        tur2++;

                    }
                    if (tur2 > 1)
                    {
                        while (bitis == false)
                        {

                            Console.WriteLine();
                            Console.WriteLine("{0}. tur", tur2);
                            oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, sonkart, rd2);

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                            if (oyuncu2hamlesi != "pas")
                                sonkart = oyuncu2hamlesi;
                            do
                            {
                                Console.Write("kart tercihin:");
                                secim2 = Convert.ToString(Console.ReadLine());
                                if (secim2.ToLower().Substring(0, 1) == sonkart.Substring(0, 1) || secim2.ToLower().Substring(1, 1) == sonkart.Substring(1, 1) || secim2 == "pas" || secim2 == "rd")
                                {
                                    kontrolbaslangıc2 = false;
                                }
                                else
                                {
                                    Console.WriteLine("hatalı hamle");
                                    kontrolbaslangıc2 = true;
                                }
                            } while (kontrolbaslangıc2 == true);

                            if (secim2.ToLower().Substring(0, 1) == sonkart.Substring(0, 1) || secim2.ToLower().Substring(1, 1) == sonkart.Substring(1, 1))
                            {
                                for (int i = 0; i < 6; i++)
                                    if (benimkartlarim[i] == secim2)
                                    {
                                        benimkartlarim[i] = "bos";
                                    }
                                oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, secim2, rd3);
                                if (oyuncu3hamlesi != "pas")
                                    sonkart = oyuncu3hamlesi;
                                else
                                    sonkart = secim2;
                            }
                            else if (secim2.ToLower() == "pas")
                            {
                                if (oyuncu2hamlesi != "pas")
                                    oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, oyuncu2hamlesi, rd3);
                                else
                                    oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, sonkart, rd3);
                            }
                            else if (secim2.ToLower() == "rd")
                            {


                                if (rd1 == 0)
                                {
                                    Console.WriteLine("rd yok");
                                    break;
                                }
                                else if (rd1 > 0)
                                {

                                    bool kontrol = false;
                                    do
                                    {
                                        Console.WriteLine("renk seçiniz");
                                        renk = Convert.ToString(Console.ReadLine());
                                        if (renk == "m")
                                            yenirenk = "m" + sonkart.Substring(1, 1);
                                        else if (renk == "k")
                                            yenirenk = "k" + sonkart.Substring(1, 1);
                                        else if (renk == "s")
                                            yenirenk = "s" + sonkart.Substring(1, 1);
                                        else
                                        {
                                            Console.WriteLine("Hatalı renk girişi");
                                            kontrol = true;
                                        }
                                    } while (kontrol == true);
                                    rdkontrol = true;
                                    for (int i = 0; i < 6 && rdkontrol == true; i++)
                                        if (benimkartlarim[i] == "rd")
                                        {
                                            rdkontrol = false;
                                            benimkartlarim[i] = "bos";
                                            rd1--;
                                        }
                                    Console.WriteLine("kar tercihin:{0}", yenirenk);
                                    oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, yenirenk, rd3);
                                    if (oyuncu3hamlesi != "pas")
                                        sonkart = oyuncu3hamlesi;
                                    else
                                        sonkart = yenirenk;
                                }


                            }
                            rd1 = 0;
                            rd2 = 0;
                            rd3 = 0;
                            Console.WriteLine();
                            Console.WriteLine("ucuncu oyuncu:" + oyuncu3hamlesi);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("kalan kartlarım:");
                            for (int j = 0; j < 6; j++)
                                Console.Write(benimkartlarim[j] + " ");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            
                            for (int i = 0; i < 6; i++)
                                if (benimkartlarim[i] == "rd")
                                    rd1++;
                            for (int i = 0; i < 6; i++)
                                if (oyuncu2Kartlari[i] == "rd")
                                    rd2++;
                            for (int i = 0; i < 6; i++)
                                if (oyuncu3Kartlari[i] == "rd")
                                    rd3++;
                            tur2++;
                            bitis = bitiskontrolu(benimkartlarim, oyuncu2Kartlari, oyuncu3Kartlari, bitiren);
                            if (bitis == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine("oyun sona erdi.");

                                for (int i = 0; i < 3&&flag==true; i++)
                                {
                                    if (bitiren[i] != "0")
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("{0}", bitiren[i]);
                                        flag = false;
                                    }
                                }

                            }

                        }


                    }

                }
                else if (baslangıc == 3)
                {
                    bool kontrolbaslangıc3 = false;
                    tur3 = 1;
                    if (tur3 == 1)
                    {
                        Console.WriteLine("{0}. tur", tur3);
                        oyuncu3hamlesi = Oyuncu3basla(oyuncu3Kartlari, tur3);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ucuncu oyuncu:" + oyuncu3hamlesi);
                        if (oyuncu2hamlesi != "pas")
                            sonkart = oyuncu3hamlesi;
                        do
                        {
                            Console.Write("kart tercihin:");
                            secim1 = Convert.ToString(Console.ReadLine());
                            if (secim1.ToLower().Substring(0, 1) == sonkart.Substring(0, 1) || secim1.ToLower().Substring(1, 1) == sonkart.Substring(1, 1))
                            {
                                oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, secim1, rd2);
                                yerdekikart = secim1;
                                kontrolbaslangıc3 = false;
                            }
                            else if (secim1.ToLower() == "rd")
                            {
                                do
                                {
                                    kontrolbaslangıc3 = false;
                                    if (rd1 == 0)
                                    {
                                        Console.WriteLine("rd yok");
                                        rdyokmu = true;
                                    }
                                    else if (rd1 > 0)
                                    {
                                        rdyokmu = false;
                                        bool kontrol = false;
                                        do
                                        {
                                            Console.WriteLine("renk seçiniz");
                                            renk = Convert.ToString(Console.ReadLine());
                                            if (renk == "m")
                                                yenirenk = "m" + sonkart.Substring(1, 1);
                                            else if (renk == "k")
                                                yenirenk = "k" + sonkart.Substring(1, 1);
                                            else if (renk == "s")
                                                yenirenk = "s" + sonkart.Substring(1, 1);
                                            else
                                            {
                                                Console.WriteLine("Hatalı renk girişi");
                                                kontrol = true;
                                            }
                                        } while (kontrol == true);
                                        yerdekikart = yenirenk;
                                        oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, yenirenk, rd2);
                                        Console.WriteLine();
                                        Console.WriteLine("rd,{0}'a dönüştürüldü", yerdekikart);
                                    }
                                } while (rdyokmu == true);
                            }
                            else if (secim1.ToLower() == "pas")
                            {
                                kontrolbaslangıc3 = false; ;
                                yerdekikart = "pas";
                                oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, oyuncu2hamlesi, rd2);
                            }
                            else
                            {
                                Console.WriteLine("hatalı hamle");
                                kontrolbaslangıc3 = true;
                            }
                        } while (kontrolbaslangıc3 == true);

                        Console.WriteLine();
                        Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                        for (int j = 0; j < 6; j++)
                        {
                            if (benimkartlarim[j] == secim1)
                            {
                                benimkartlarim[j] = "bos";
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("kalan kartlarım:");
                        for (int j = 0; j < 6; j++)
                            Console.Write(benimkartlarim[j] + " ");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                      
                        if (oyuncu2hamlesi != "pas")
                            sonkart = oyuncu2hamlesi;
                        else
                            if (yerdekikart != "pas")
                            sonkart = yerdekikart;
                        else
                            sonkart = oyuncu3hamlesi;

                        tur3++;
                    }
                    if (tur3 > 1)
                    {
                        while (bitis == false)
                        {

                            Console.WriteLine();
                            Console.WriteLine("{0}. tur", tur3);
                            oyuncu3hamlesi = oyuncu3kartat(oyuncu3Kartlari, sonkart, rd3);

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ucuncu oyuncu:" + oyuncu3hamlesi);
                            if (oyuncu3hamlesi != "pas")
                                sonkart = oyuncu3hamlesi;
                            do
                            {
                                Console.Write("kart tercihin:");
                                secim2 = Convert.ToString(Console.ReadLine());
                                if (secim2.ToLower().Substring(0, 1) == sonkart.Substring(0, 1) || secim2.ToLower().Substring(1, 1) == sonkart.Substring(1, 1) || secim2 == "pas" || secim2 == "rd")
                                {
                                    kontrolbaslangıc3 = false;
                                }
                                else
                                {
                                    Console.WriteLine("hatalı hamle");
                                    kontrolbaslangıc3 = true;
                                }
                            } while (kontrolbaslangıc3 == true);

                            if (secim2.ToLower().Substring(0, 1) == sonkart.Substring(0, 1) || secim2.ToLower().Substring(1, 1) == sonkart.Substring(1, 1))
                            {
                                for (int i = 0; i < 6; i++)
                                    if (benimkartlarim[i] == secim2)
                                    {
                                        benimkartlarim[i] = "bos";
                                    }
                                oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, secim2, rd2);
                                if (oyuncu2hamlesi != "pas")
                                    sonkart = oyuncu2hamlesi;
                                else
                                    sonkart = secim2;
                            }
                           
                            else if (secim2.ToLower() == "rd")
                            {


                                if (rd1 == 0)
                                {
                                    Console.WriteLine("rd yok");
                                    break;
                                }
                                else if (rd1 > 0)
                                {

                                    bool kontrol = false;
                                    do
                                    {
                                        Console.WriteLine("renk seçiniz");
                                        renk = Convert.ToString(Console.ReadLine());
                                        if (renk == "m")
                                            yenirenk = "m" + sonkart.Substring(1, 1);
                                        else if (renk == "k")
                                            yenirenk = "k" + sonkart.Substring(1, 1);
                                        else if (renk == "s")
                                            yenirenk = "s" + sonkart.Substring(1, 1);
                                        else
                                        {
                                            Console.WriteLine("Hatalı renk girişi");
                                            kontrol = true;
                                        }
                                    } while (kontrol == true);
                                    rdkontrol = true;
                                    for (int i = 0; i < 6 && rdkontrol == true; i++)
                                        if (benimkartlarim[i] == "rd")
                                        {
                                            rdkontrol = false;
                                            benimkartlarim[i] = "bos";
                                            rd1--;
                                        }
                                    Console.WriteLine("kart tercihin:{0}", yenirenk);
                                    oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, yenirenk, rd2);
                                    if (oyuncu2hamlesi != "pas")
                                        sonkart = oyuncu2hamlesi;
                                    else
                                        sonkart = yenirenk;
                                }
                                

                            }
                            else if (secim2.ToLower() == "pas")
                            {
                                if (oyuncu3hamlesi != "pas")
                                    oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, oyuncu3hamlesi, rd2);
                                else
                                    oyuncu2hamlesi = oyuncu2kartat(oyuncu2Kartlari, sonkart, rd2);
                                     if (oyuncu2hamlesi != "pas")
                                       sonkart = oyuncu2hamlesi;
                                    else
                                    {
                                       if (oyuncu3hamlesi != "pas")
                                        sonkart = oyuncu3hamlesi;
                                    }
                            }
                            rd1 = 0;
                            rd2 = 0;
                            rd3 = 0;
                            Console.WriteLine();
                            Console.WriteLine("ikinci oyuncu:" + oyuncu2hamlesi);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("kalan kartlarım:");
                            for (int j = 0; j < 6; j++)
                                Console.Write(benimkartlarim[j] + " ");
                            for (int i = 0; i < 6; i++)
                                if (benimkartlarim[i] == "rd")
                                    rd1++;
                            for (int i = 0; i < 6; i++)
                                if (oyuncu2Kartlari[i] == "rd")
                                    rd2++;
                            for (int i = 0; i < 6; i++)
                                if (oyuncu3Kartlari[i] == "rd")
                                    rd3++;
                            tur3++;
                            bitis = bitiskontrolu(benimkartlarim, oyuncu2Kartlari, oyuncu3Kartlari, bitiren);
                            if (bitis == true)
                            {
                                Console.WriteLine();
                                Console.WriteLine("oyun sona erdi.");

                                for (int i = 0; i < 3&&flag==true; i++)
                                {
                                    if (bitiren[i] != "0")
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("{0}", bitiren[i]);
                                        flag = false;
                                        Console.WriteLine();
                                    }
                                }

                            }

                        }
                    }
                }
                    
            }
            Console.ReadKey();
        }
    }


} 


