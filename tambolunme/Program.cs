// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for(int i = 1; i >= 0; i++)
{
    Console.WriteLine("birinci sayıyı giriniz");
    int sayi1=int.Parse(Console.ReadLine());
    Console.WriteLine("ikinci sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());
    if (sayi1 >= sayi2)
    {
        if(sayi1%sayi2 == 0)
        {
            Console.WriteLine(sayi1 + " sayısı" + sayi2 + " sayısına tam bölünür");
        }
        else
        {
            Console.WriteLine(sayi1 + " sayısı" + sayi2 + " sayısına tam bölünmez");
            Console.Readkey();
         
        }
    }
}
