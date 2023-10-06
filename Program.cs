using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "123456", modelo: "nokia1", imei: "1111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Gmail");

Smartphone iphone = new Iphone(numero: "654321", modelo: "Iphone 13", imei: "1313", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Gmail");
