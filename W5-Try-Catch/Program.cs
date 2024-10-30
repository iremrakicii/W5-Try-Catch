class Program
{
    static void Main()
    {
        bool Value = false;
        while (!Value)
        {
            try
            {
                Console.WriteLine("Lütfen bir sayı değeri giriniz.");
                int cevap = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Girilen sayının karesi:" + cevap * cevap);
                Value = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz formatta bir  giriş yaptınız! Lütfen bir sayı giriniz. ");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Girdiğiniz sayı , belirlenen sınırdan daha büyük ya da daha küçük!");
            }
            finally
            {

            }
        }
        Console.WriteLine("İşlem Tamamlandı");
        Console.ReadKey();

    }
}
