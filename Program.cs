
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

    switch (month)
//Month with 31 Days
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
        break
  case 12:
    Console.WriteLine("There are 31 days in December");
        break;
    }

//Month with 30 Days










