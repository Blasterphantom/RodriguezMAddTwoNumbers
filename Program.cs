//Marcel Rodriguez
//10-17-22 4pm
//Add 2 Numbers
//We will ask the user to enter two numbers, add the values, and display
//the result
//Peer review -

Console.Clear();

string end = "yes";
while (end == "yes")
{
    bool isContainer = false;
    bool isNumber;
    int validNum = 0;
    
    while(isContainer == false)
    {

        Console.WriteLine("Please enter a number: ");
        string numberOne = Console.ReadLine();

        isNumber = Int32.TryParse(numberOne, out validNum);

        if(isNumber == true)
        {
            isContainer = true;
            Console.WriteLine($"\nThe number you entered was {numberOne}");
        }
        else
        {
            Console.WriteLine("\nPlease enter an actual number.\n");
        }

    }

    bool isContainer2 = false;
    bool isNumber2;
    int validNum2 = 0;

    while(isContainer2 == false)
    {
        Console.WriteLine("\nPlease enter another number: ");
        string numberTwo = Console.ReadLine();
        isNumber2 = Int32.TryParse(numberTwo, out validNum2);

        if(isNumber2 == true)
        {
            isContainer2 = true;
            Console.WriteLine($"\nThe number you entered was {numberTwo}\n");
        }
        else
        {
            Console.WriteLine("\nPlease enter an actual number.\n");
        }
    }

    int sum = validNum + validNum2;

    Console.WriteLine($"The sum of {validNum} and {validNum2} is {sum}!\n");



    Console.WriteLine("Do you want to try again? Yes/No");
    end = Console.ReadLine().ToLower();
    Console.WriteLine("\n\n");
}