using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i11 = new Iphone("44 99134 - 8788", "5641651651651", "IPHONE 11", 64);
Nokia n154 = new Nokia("44 9554 - 6464", "65146FD6DDSC6465", "Nokia Tijolão", 2);

Console.WriteLine($"Modelo: {i11.Modelo} IMEI: {i11.IMEI} Numero: {i11.Numero} Memoria: {i11.Memoria}");
i11.InstalarAplicativo("ZAP ZAP 2");
i11.Ligar();
i11.ReceberLigacao();

Console.WriteLine("\n\n");

Console.WriteLine($"Modelo: {n154.Modelo} IMEI: {n154.IMEI} Numero: {n154.Numero} Memoria: {n154.Memoria}");
n154.InstalarAplicativo("Raio x da natta.com");
n154.Ligar();
n154.ReceberLigacao();



