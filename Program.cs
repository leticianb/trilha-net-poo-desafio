using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone");
Smartphone a1 = new Iphone("13", "15", "56", 128);
a1.InstalarAplicativo("Whatsapp");
a1.Ligar();
a1.ReceberLigacao();

Console.WriteLine("\nNokia");
Smartphone n1 = new Nokia(numero: "13", modelo: "15", imei: "56",memoria: 128);
a1.InstalarAplicativo("Tiktok");
a1.Ligar();
a1.ReceberLigacao();
