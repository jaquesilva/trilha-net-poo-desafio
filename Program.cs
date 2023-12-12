using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Iphone e Nokia
Console.WriteLine("Smartphone iPhone: ");
Smartphone novoIphone = new Iphone(numero: "456789", modelo: "Modelo A", imei: "111111111", memoria: 64);
novoIphone.InstalarAplicativo("DIO");
novoIphone.Ligar();
novoIphone.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone novoNokia = new Nokia(numero: "654321", modelo: "Modelo B", imei: "999999999", memoria: 64);
novoNokia.InstalarAplicativo("DIO");
novoNokia.Ligar();
novoNokia.ReceberLigacao();

