//1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
Console.WriteLine("--------------------------- Kendime inanıyorum Yazısı --------------------------------------");
for (int i = 1; i <= 10; i++) Console.WriteLine($"{i}.Kendime inanıyorum, ben bu yazılım işini hallederim!");

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
Console.WriteLine("--------------------------- 1 ile 20 arasındaki sayıları yazdırma -----------------------------");
for (int i = 1; i <= 20; i++) Console.WriteLine(i);

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
Console.WriteLine("--------------------------- 1 ile 20 arasındaki çift sayıları yazdırma ------------------------");
for (int i = 0; i<= 20; i+=2) Console.WriteLine(i);

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
Console.WriteLine("----------------- 50 ile 150 arasındaki sayıların toplamını yazdırma --------------------------");
int sum = 0;
for(int i = 50; i <= 150; i++) sum = sum + i;
Console.WriteLine($"50 ile 150 arasında ki sayıların toplamı:{sum}");

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
Console.WriteLine("----------------- 1 ile 120 arasındaki sayıların çift ve tek toplamlarını ayrı ayrı yazdırma --------------------------");
int sumOdd = 0;
int sumEven = 0;
for(int i = 1; i<=120; i++)
{
    if (i % 2 == 0)
        sumEven += i;
    else
        sumOdd += i;
}
Console.WriteLine($"Tek sayıların toplamı: {sumOdd} çift sayıların toplamı: {sumEven}");