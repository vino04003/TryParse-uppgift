    
    Console.WriteLine("Skriv ett nummer: ");

    int number;

        if(int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("nummret var " + number);
        }
        else
        {
            Console.WriteLine("Inget nummer");
        }
    Console.ReadLine();

