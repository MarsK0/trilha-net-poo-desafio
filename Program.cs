using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("12345678", "tijolão", "1234321", 32);
Iphone iphone = new Iphone("87654321", "pomposo", "4321234", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("jogo da cobrinha");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ZapZap");