using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
// Kahve isimlerini saklamak için bir List<string> oluşturuluyor.
List<string> kahveler = new List<string>();

// Kullanıcıdan 5 kahve ismi girmesini istiyoruz.
for (int i = 1; i < 6; i++)
{
    Console.Write($"Kahve {i}: ");
    
    string KahveAdi = Console.ReadLine();

    // Kullanıcının girdiği kahve ismini listeye ekliyoruz.
    kahveler.Add( KahveAdi );
}

Console.WriteLine("Girdiğiniz Kahveler");

int siralama = 1;
// Listeyi foreach döngüsüyle ekrana yazdırıyoruz.
foreach ( string kahve in kahveler)
{
    Console.WriteLine($"{siralama}. " + kahve);

    siralama++;
}
