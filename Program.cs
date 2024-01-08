using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123324546");
nokia.Memoria = 64;
nokia.Modelo = "asdasdkjn";
nokia.Imei = "23334234";
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.Write("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123324546", Modelo: "sdkjhdsfd");
iphone.Memoria = 32;
iphone.Imei = "1873873213";
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
