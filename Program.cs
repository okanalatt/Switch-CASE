namespace Switch_CASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch Case :Bir değerin birden fazla değere göre kontrol edilmesi için kullanılır.
            //Switch Case, if-else yapısına göre daha okunabilir ve yönetilebilir kodlar yazmamızı sağlar.
            //Switch Case, birden fazla koşulun kontrol edilmesi gereken durumlarda tercih edilir.
            //Switch Case, bir değerin belirli durumlara göre farklı işlemler yapmasını sağlar.

            #region Switch Case Ornek
            ////Switch Case ÖRNEK
            //Console.WriteLine("Lütfen bir gün giriniz (1-7): ");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(
            //    gun switch
            //    {
            //        1 => "Pazartesi",
            //        2 => "Salı",
            //        3 => "Çarşamba",
            //        4 => "Perşembe",
            //        5 => "Cuma",
            //        6 => "Cumartesi",
            //        7 => "Pazar",
            //        _ => "Geçersiz gün numarası!"
            //    });
            //Console.ReadLine();
            ////Ornek Açıklama:
            ////Kullanıcıdan bir gün numarası alınıyor (1-7 arası).
            ////Switch ifadesi, bu numaraya göre gün adını döndürüyor.
            ////Eğer numara 1 ise "Pazartesi", 2 ise "Salı" vb. olarak devam ediyor.
            ////Eğer numara 1-7 dışında bir değer girilirse "Geçersiz gün numarası!" mesajı veriliyor.
            ////ORNEK 2
            //Console.WriteLine("Lütfen bir ay giriniz (1-12): ");
            //int ay = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(
            //    ay switch
            //    {
            //        1 => "Ocak",
            //        2 => "Şubat",
            //        3 => "Mart",
            //        4 => "Nisan",
            //        5 => "Mayıs",
            //        6 => "Haziran",
            //        7 => "Temmuz",
            //        8 => "Ağustos",
            //        9 => "Eylül",
            //        10 => "Ekim",
            //        11 => "Kasım",
            //        12 => "Aralık",
            //        _ => "Geçersiz ay numarası!"
            //    });
            //Console.ReadLine();
            //Console.WriteLine("Lütfen bir sayı giriniz: (1-3)");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            ////Switch Case ÖRNEK 3
            //switch (sayi)
            //{
            //    case 1:
            //        Console.WriteLine("sayı 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("sayı 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("sayı 3");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz sayı!");
            //        break;
            //} 
            #endregion

            //Ornek 2
            Console.WriteLine("Donem bilgisi giriniz: (1/2)");
            int donem = Convert.ToInt32(Console.ReadLine());
            switch (donem)
            {
                case 1:
                    Console.WriteLine("Not bilgisi giriniz: (0-100)");
                    int notDegeri = Convert.ToInt32(Console.ReadLine());
                    if (notDegeri > 60)
                    {
                        Console.WriteLine("Gectiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Kaldınız.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Not ortalaması giriniz:(0-100)");
                    int notOrt = Convert.ToInt32(Console.ReadLine());
                    if (notOrt > 50)
                    {
                        Console.WriteLine("Gectiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Kaldınız.");
                    }

                    break;
                default:
                    Console.WriteLine("Geçersiz dönem bilgisi!");
                    break;
            }

        }
    }
}

