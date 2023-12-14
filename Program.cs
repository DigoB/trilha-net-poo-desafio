using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("11111111111", "Nokia A", "22222", 64);

Console.WriteLine("================== Testes Nokia =====================");
Console.WriteLine();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("GitHub");

Console.WriteLine();
Console.WriteLine("=====================================================");
Console.WriteLine();

Console.WriteLine("================== Testes Iphone ====================");

Iphone iphone = new Iphone("22222222222", "Iphone B", "33333", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO");