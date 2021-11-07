
//Main Menu Section
int opt;
Console.WriteLine("Enter your desired input corresponding to the respective action:");
Console.WriteLine("1: Month, Day Tool");
Console.WriteLine("2: Pay Calculator Tool");
Console.WriteLine("3: Exit Application");
string str = Console.ReadLine();


//Establishing the desired option !!IMPORTANT!!
opt = int.Parse(str);


    if (opt == 1) ;

//Month Day Calculator Tool
if (opt == 1) ;

{
    Console.WriteLine("Please enter the month you would like to know the number of days for:");

    int month = int.Parse(Console.ReadLine());

    //Months with 31 days
    switch (month)
    {
        case 1:
            Console.WriteLine("There are 31 days in January");
            break;

        case 3:
            Console.WriteLine("There are 31 days in March");
            break;

        case 5:
            Console.WriteLine("There are 31 days in May");
            break;

        case 7:
            Console.WriteLine("There are 31 days in July");
            break;

        case 8:
            Console.WriteLine("There are 31 days in August");
            break;

        case 10:
            Console.WriteLine("There are 31 days in October");
            break;

        case 12:
            Console.WriteLine("There are 31 days in December");
            break;
    }

    //Month with 30 days
    switch (month)
    {
        case 4:
            Console.WriteLine("There are 30 days in April");
            break;

        case 5:
            Console.WriteLine("There are 30 days in June");
            break;

        case 9:
            Console.WriteLine("There are 30 days in September");
            break;

        case 11:
            Console.WriteLine("There are 30 days in November");
            break;
    }

    //February 

    switch (month)
    {
        case 2:
        Console.WriteLine("You have selected February")
        Console.WriteLine("As February has a varying number of days please input the year:")
        
        int febyear = int.Parse(Console.ReadLine());

        if (febyear % != 4)
        Console.WriteLine("There are 28 days in February in the year " +febyear)

        else if (febyear % != 100)
        Console.WriteLine("There are 29 days in February as it was a leap year in the year " +febyear)

        else if (febyear % !=400)
        Console.WriteLine("There are 28 days in February in the year " +febyear)

        else Console.WriteLine("There are 29 days in February as it was a leap year in the year " +febyear)


    }

}








