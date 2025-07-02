using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("11944155", "Modelo ultra", "dfd4656s64f", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("------------------------");

Smartphone iphone = new Iphone("83945454", "Modelo 16", "fd4h444d4hfh", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");