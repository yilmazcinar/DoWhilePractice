/*

int i = 0;

Console.WriteLine("Ekranda kaç kere ben patikalıyım yazdırmak istiyorsunuz");
int limit = Convert.ToInt32(Console.ReadLine());

// Burada girdi kadar ekrana yazdırmak istediğim için limit değişkeninin i değişkeni ile eşitliğini kontrol etmedim. Sayacı 0 dan başlattığımız için örn 7 girdiğimizde 8 kere patikalıyım yazdıracaktır. 

while (i < limit)  
{
    Console.WriteLine("Ben patikalıyım");
    i++;

}

*/


int j = 0;

Console.WriteLine("Ekranda kaç kere ben patikalıyım yazdırmak istiyorsunuz?");

int limit2 = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir patikalıyım");
    j++;

}while (j < limit2);

// While döngüsünde kullanıcıdan aldığımız girdi koşulu sağlamıyorsa program hiç çalışmıyor. Fakat do-while döngüsünü kullandığımızda koşul gerçekleşmese bile 1 kere kod çalışmış oluyor. Örn while döngüsünde -5 girdiğimizde program çıkışa giderken, do-while döngüsünde -5 yazdığımızda 1 kere ekrana Ben bir patikalıyım yazdırıyor ve çıkıyor. 