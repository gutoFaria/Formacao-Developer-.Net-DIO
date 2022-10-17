

// TODO: Realizar os testes com as classes Nokia e Iphone

using DesafioPOO.Models;

Nokia n1 = new Nokia("10","n10","imei10",64);
Nokia n2 = new Nokia("12","n12","imei12",120);

Iphone i1 = new Iphone("13","i13","imei13",120);
Iphone i2 = new Iphone("15","i15","imei15",220);

n1.ImprimirAplicativo();
n1.InstalarAplicativo("youtube");
Console.WriteLine("\n");
i2.ImprimirAplicativo();
i2.InstalarAplicativo("sound music");