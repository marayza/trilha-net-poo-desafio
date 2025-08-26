using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine(" Iniciando testes com Iphone :");
Iphone iphone = new Iphone("123456789", "iPhone 15 PRO", "15484566985231", 264);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok");

Console.WriteLine(" ------------------------------------------------------------------- ");

Console.WriteLine(" Iniciando testes com Nokia :");
Nokia nokia = new Nokia("987654321", "Nokia ASX4", "2124587875268532", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine(" ------------------------------------------------------------------- ");

Console.WriteLine(" Iniciando testes com Samsumg :");
Samsumg samsumg = new Samsumg("456789123", "Samsumg Galaxy S21", "987654321654987", 128);
samsumg.Ligar();
samsumg.ReceberLigacao();
samsumg.InstalarAplicativo("LinkedIn");