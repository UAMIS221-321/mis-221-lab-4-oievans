// Start Main

System.Console.WriteLine("Pease enter 1 for a full triangle, 2 for a partial triangle and 3 to exit.");
string input = Console.ReadLine();


    if(input == "1") GetFull();
    else if( input == "2") GetPartial();
    else if(input == "3")
        {
             System.Console.WriteLine("No Triangles Requested, Exiting Now");
        }
        else 
        {
            System.Console.WriteLine("Pease enter 1 for a full triangle, 2 for a partial triangle and 3 to exit.");
            input = Console.ReadLine();
        }





// End Main

static void GetFull()
{
    Random rnd = new Random();
    int rows = rnd.Next(3, 9);
    string output = "o";
    
    for(int i = 0; i <= rows; i++)
    {
        for(int j = 0; j < i; j++)
        {
            System.Console.Write(output + " ");
        }
        System.Console.WriteLine(Environment.NewLine);
    }

}

static void GetPartial()
{

    Random rnd = new Random();
    int rows = rnd.Next(3, 9);
    string output = "o";
    
    for(int i = 0; i <= rows; i++)
    {
        int missing = rnd.Next(i);
        for(int j = 0; j < i; j++)
        {
            if(j == missing) System.Console.Write("  ");
            else System.Console.Write(output + " ");
        }
        System.Console.WriteLine(Environment.NewLine);
    }

}