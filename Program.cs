using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i1 = new("8333-1523", "10", "1526895", 128);
Nokia n1 = new("9444-1621", "7", "187360", 256);

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Facebook");

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");