
try
{
    List<decimal> numbers = new List<decimal>();
    bool working = true;

    Console.WriteLine("===CHEVA CALCULATOR===");

    // Main program loop
    while (working)
    {
        // Display calculator menu
        Console.WriteLine("1. ADDITION");
        Console.WriteLine("2. SUBTRACTION");
        Console.WriteLine("3. MULTIPLICATION");
        Console.WriteLine("4. DIVISION");
        Console.WriteLine("5. VERIFY STUDENT GRADE");
        Console.WriteLine("6. EXIT");

        Console.WriteLine("SELECT AN OPTION: ");
        int option;

        // Validate menu option
        while (!int.TryParse(Console.ReadLine()!, out option) || option < 1 || option >=7)
        {
            Console.WriteLine("INVALID DATA, ENTER A VALID OPTION: ");
        }

        // Exit the program
        if (option == 6)
        {
            Console.WriteLine("THANK YOU FOR USING CHEVA CALCULATOR");
            working = false;
           
            continue;
        }

        decimal result = 0;
        switch (option)
        {
            case 1:
                {
                    // Clear previous numbers
                    numbers.Clear();
                    result = 0;

                    Console.WriteLine("Enter the first number:");
                    decimal number1ToSum;

                    // Validate first number
                    while (!decimal.TryParse(Console.ReadLine()!, out number1ToSum)){
                        Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                    }

                    numbers.Add(number1ToSum);

                    Console.WriteLine("Enter the second number:");
                    decimal number2ToSum;

                    // Validate second number
                    while (!decimal.TryParse(Console.ReadLine()!, out number2ToSum))
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                    }

                    numbers.Add(number2ToSum);

                    bool wantToContinue = true;

                    // Allow additional numbers
                    while (wantToContinue)
                    {
                        Console.WriteLine("Do you want to add another number? 1. Yes | 2. No:");
                        int userDecision;

                        // Validate user decision
                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("Enter the new number: ");
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber))
                            {
                                Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }
    
                    }

                    // Calculate the sum
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        result = result + numbers[i];

                    }

                    Console.WriteLine($"THE RESULT IS: {result}");

                    break;

                }

            case 2:
                {
                // Clear previous numbers
                numbers.Clear();
                result = 0;


                Console.WriteLine("Enter the first number:");
                decimal number1ToRest;


                while (!decimal.TryParse(Console.ReadLine()!, out number1ToRest))
                {
                    Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                }

                numbers.Add(number1ToRest);

                Console.WriteLine("Enter the second number:");
                decimal number2ToRest;


                while (!decimal.TryParse(Console.ReadLine()!, out number2ToRest))
                {
                    Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                }

                numbers.Add(number2ToRest);

                bool wantToContinue = true;

                    // Allow additional numbers
                    while (wantToContinue)
                    {

                        Console.WriteLine("Do you want to add another number? 1. Yes | 2. No:");
                        int userDecision;

                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("Enter the new number: ");
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber))
                            {
                                Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }

                    }
                    // Start with the first number
                        result = numbers[0];

                    // Calculate the difference
                    for (int i = 1; i < numbers.Count; i++)
                        {
                            result = result - numbers[i];

                        }
                        Console.WriteLine($"THE RESULT IS: {result}");



                        break;
                    }
                    


            case 3:
                {


                // Clear previous numbers
                numbers.Clear();
                result = 0;


                Console.WriteLine("Enter the first number:");
                decimal number1ToMultiply;


                while (!decimal.TryParse(Console.ReadLine()!, out number1ToMultiply))
                {
                    Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                }

                numbers.Add(number1ToMultiply);

                Console.WriteLine("Enter the second number:");
                decimal number2ToMultiply;


                while (!decimal.TryParse(Console.ReadLine()!, out number2ToMultiply))
                {
                    Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                }

                numbers.Add(number2ToMultiply);

                bool wantToContinue = true;

                    // Allow additional numbers
                    while (wantToContinue)
                    {


                        Console.WriteLine("Do you want to add another number? 1. Yes | 2. No:");
                        int userDecision;
                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("Enter the new number: ");
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber))
                            {
                                Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }
                    }
                }

                // Start with the first number
                result = numbers[0];


                // Calculate the product
                for (int i = 1; i <numbers.Count; i++)
                {
                    result = result * numbers[i];
                }

                Console.WriteLine($"THE RESULT IS: {result}");
                break;

            case 4:
                {
                    // Clear previous numbers
                    numbers.Clear();
                    result = 0;

                    Console.WriteLine("Enter the first number:");
                    decimal number1ToSplit;


                    while (!decimal.TryParse(Console.ReadLine()!, out number1ToSplit))
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                    }

                    numbers.Add(number1ToSplit);

                    Console.WriteLine("Enter the second number:");
                    decimal number2ToSplit;

                    // Prevent division by zero
                    while (!decimal.TryParse(Console.ReadLine()!, out number2ToSplit) || number2ToSplit == 0)
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                    }

                    numbers.Add(number2ToSplit);

                    bool wantToContinue = true;

                    // Allow additional divisors
                    while (wantToContinue)
                    {
                        Console.WriteLine("Do you want to add another number? 1. Yes | 2. No:");
                        int userDecision;
                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("INVALID DATA, ENTER A VALID OPTION: ");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("Enter the new number: ");

                            // Prevent division by zero
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber) || newNumber==0)
                            {
                                Console.WriteLine("INVALID DATA, ENTER A VALID NUMBER: ");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }

                    }

                }

                // Start with the first number
                result = numbers[0];

                // Calculate the quotient
                for (int i = 1; i < numbers.Count; i++)
                {
                    result = result / numbers[i];
                }

                Console.WriteLine($"THE RESULT IS: {result}");

                break;

            case 5:
                {
                    decimal note1;
                    Console.WriteLine("Enter the first grade: ");

                    // Validate grade range
                    while (!decimal.TryParse(Console.ReadLine()!, out note1) || note1 < 0 || note1 > 100)
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID GRADE: ");
                    }

                    decimal note2;
                    Console.WriteLine("Enter the second grade: ");
                    while (!decimal.TryParse(Console.ReadLine()!, out note2) || note2 < 0 || note2 > 100)
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID GRADE: ");
                    }


                    decimal note3;
                    Console.WriteLine("Enter the third grade: ");
                    while (!decimal.TryParse(Console.ReadLine()!, out note3) || note3 < 0 || note3 > 100)
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID GRADE: ");
                    }

                    decimal note4;
                    Console.WriteLine("Enter the fourth grade: ");
                    while (!decimal.TryParse(Console.ReadLine()!, out note4) || note4 < 0 || note4 > 100)
                    {
                        Console.WriteLine("INVALID DATA, ENTER A VALID GRADE: ");
                    }

                    // Calculate the average grade
                    decimal addition = note1 + note2 + note3 + note4;
                    decimal average = addition / 4;

                    Console.WriteLine($"THE AVERAGE IS: {average}");

                    // Check if the student passed
                    if (average >= 70)
                    {
                        Console.WriteLine("STUDENT PASSED");
                    }
                    else
                    {
                        Console.WriteLine("STUDENT FAILED");
                    }
                }

                break;
        }
    }
    
}
catch(Exception ex)
{
    // Handle unexpected errors
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine("THE PROGRAM COULD NOT COMPLETE DUE TO THE ERROR");
}












