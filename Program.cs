Console.WriteLine("Witajcie, kasztany!");
Console.Write("Ile masz lat? ");

if(int.TryParse(Console.ReadLine(), out int ageI))
    Console.WriteLine($"Za 10 lat będziesz miał {ageI+10} lat.");