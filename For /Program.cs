 // konsol ekranına 1o kere "kendine inanıyorum yazdırma

for (int i = 0; i <= 10; i++)
 {
     Console.WriteLine($"Kendime inanıyorum ben bu yazılım isini hallederim");
     
 }
 Console.WriteLine("-------------------->");// 1 den 20 ye kadar sayı yazdırma

 for (int i = 1; i <= 20; i++)
 {
     Console.WriteLine(i);
 }
     
 Console.WriteLine("-------------------->"); //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
 
 for (int i = 1; i <= 20; i++)
 {
     if (i % 2 == 0)
     {
         Console.WriteLine(i);
     }
 }
 Console.WriteLine("----------------------->"); //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
 int toplam = 0;
 for (int i = 50; i <= 150; i++)
 {
     toplam += i;
 }
 Console.WriteLine(toplam);
 Console.WriteLine("--------------------------------->"); //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

 
    int tekToplam = 0;
    int ciftToplam = 0;

 for (int i = 1; i <= 120; i++)
 {
     if (i % 2 == 0)
     {
         ciftToplam += i;
     }
     else
     {
         tekToplam += i;
     }
 }

 Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
 Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
 
 
 
 
 