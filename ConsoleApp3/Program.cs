using System.ComponentModel.Design;

Console.Write("dodawanie - wpisz 1 liczbe: ");
    int num = Convert.ToInt32(Console.ReadLine());

Console.Write("wpisz 2 liczbe: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num + num2);




    Console.Write("podobalo sie?(tak/nie): ");
    string odpowiedz = Console.ReadLine();

    if (odpowiedz != "nie");
    
        Console.WriteLine("to spierdalaj.");
    
    else if (odpowiedz != "tak")
    
        Console.WriteLine("dzieki!");
    
    else
    
        Console.WriteLine("tak albo nie debilu");
    

    Console.WriteLine("koniec");
    Console.ReadKey();



