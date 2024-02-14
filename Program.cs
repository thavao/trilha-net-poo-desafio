using DesafioPOO.Models;


System.Console.WriteLine("Teste Celular 1 Nokia");
Nokia celular1 = new Nokia("9933-7154", "Nokia V35", "ABCDE#@!", 8);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("WhatsApp");

System.Console.WriteLine();

System.Console.WriteLine("Teste Celular 2 Iphone");
Iphone celular2 = new Iphone("9783-4114", "Iphone XS", "ZYXV321", 12);

celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Instagram");