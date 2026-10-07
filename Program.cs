
try
{
    List<decimal> numbers = new List<decimal>();

    bool working = true;

    Console.WriteLine("===CHEVA CALCULATOR===");

    while (working)
    {

        Console.WriteLine("1. SUMA");
        Console.WriteLine("2. RESTA");
        Console.WriteLine("3. MULTIPLICACION");
        Console.WriteLine("4. DIVISION");
        Console.WriteLine("5. VERIFICAR CALIFICACION");
        Console.WriteLine("6. EXIT");

        Console.WriteLine("SELECCIONE UNA OPCION: ");
        int option;

        while (!int.TryParse(Console.ReadLine()!, out option) || option < 1 || option >=7)
        {
            Console.WriteLine("DATO INVALIDO, INGRESE UNA OPCION VALIDA: ");
        }
        

        if(option == 6)
        {
            working = false;
            Console.WriteLine("GRACIAS POR USAR CHEVA CALCULATOR");
            continue;
        }
       

       

        decimal result = 0;

        switch (option)
        {
            case 1:
                {

                    numbers.Clear();
                    result = 0;

                    Console.WriteLine("DIGITE EL PRIMER NUMERO:");
                    decimal number1ToSum;
                   

                    while (!decimal.TryParse(Console.ReadLine()!, out number1ToSum)){
                        Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                    }

                    numbers.Add(number1ToSum);





                    Console.WriteLine("DIGITE EL SEGUNDO NUMERO:");
                    decimal number2ToSum;


                    while (!decimal.TryParse(Console.ReadLine()!, out number2ToSum))
                    {
                        Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                    }

                    numbers.Add(number2ToSum);

                    bool wantToContinue = true;

                    while (wantToContinue)
                    {


                        Console.WriteLine("DESEA AGREGAR OTRO NUMERO? 1.SI|2.NO:");
                        int userDecision;
                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("INGRESE EL NUEVO NUMERO: ");
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber))
                            {
                                Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }

                       


                       
                    }

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        result = result + numbers[i];

                    }

                    Console.WriteLine($"EL RESULTADO ES: {result}");

                    break;

                }

            case 2:
                { 

                numbers.Clear();
                result = 0;


                Console.WriteLine("DIGITE EL PRIMER NUMERO:");
                decimal number1ToRest;


                while (!decimal.TryParse(Console.ReadLine()!, out number1ToRest))
                {
                    Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                }

                numbers.Add(number1ToRest);





                Console.WriteLine("DIGITE EL SEGUNDO NUMERO:");
                decimal number2ToRest;


                while (!decimal.TryParse(Console.ReadLine()!, out number2ToRest))
                {
                    Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                }

                numbers.Add(number2ToRest);

                bool wantToContinue = true;

                    while (wantToContinue)
                    {


                        Console.WriteLine("DESEA AGREGAR OTRO NUMERO? 1.SI|2.NO:");
                        int userDecision;
                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("INGRESE EL NUEVO NUMERO: ");
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber))
                            {
                                Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }

                    }




                        result = numbers[0];
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            result = result - numbers[i];

                        }
                        Console.WriteLine($"EL RESULTADO ES: {result}");



                        break;
                    }
                    


            case 3:
                { 
                

                numbers.Clear();
                result = 0;


                Console.WriteLine("DIGITE EL PRIMER NUMERO:");
                decimal number1ToMultiply;


                while (!decimal.TryParse(Console.ReadLine()!, out number1ToMultiply))
                {
                    Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                }

                numbers.Add(number1ToMultiply);





                Console.WriteLine("DIGITE EL SEGUNDO NUMERO:");
                decimal number2ToMultiply;


                while (!decimal.TryParse(Console.ReadLine()!, out number2ToMultiply))
                {
                    Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                }

                numbers.Add(number2ToMultiply);

                bool wantToContinue = true;

                    while (wantToContinue)
                    {


                        Console.WriteLine("DESEA AGREGAR OTRO NUMERO? 1.SI|2.NO:");
                        int userDecision;
                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("INGRESE EL NUEVO NUMERO: ");
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber))
                            {
                                Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }
                    }
                }

                result = numbers[0];



                for(int i = 1; i <numbers.Count; i++)
                {
                    result = result * numbers[i];
                }

                Console.WriteLine($"EL RESULTADO ES: {result}");
                break;

            case 4:
                {

                    numbers.Clear();
                    result = 0;

                    Console.WriteLine("DIGITE EL PRIMER NUMERO:");
                    decimal number1ToSplit;


                    while (!decimal.TryParse(Console.ReadLine()!, out number1ToSplit))
                    {
                        Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                    }

                    numbers.Add(number1ToSplit);







                    Console.WriteLine("DIGITE EL SEGUNDO NUMERO:");
                    decimal number2ToSplit;


                    while (!decimal.TryParse(Console.ReadLine()!, out number2ToSplit) || number2ToSplit == 0)
                    {
                        Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                    }

                    numbers.Add(number2ToSplit);

                    bool wantToContinue = true;

                    while (wantToContinue)
                    {


                        Console.WriteLine("DESEA AGREGAR OTRO NUMERO? 1.SI|2.NO:");
                        int userDecision;
                        while (!int.TryParse(Console.ReadLine()!, out userDecision) || userDecision < 1 || userDecision >= 3)
                        {
                            Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                        }

                        if (userDecision == 1)
                        {
                            wantToContinue = true;
                            decimal newNumber;
                            Console.WriteLine("INGRESE EL NUEVO NUMERO: ");
                            while (!decimal.TryParse(Console.ReadLine()!, out newNumber) || newNumber==0)
                            {
                                Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO");
                            }

                            numbers.Add(newNumber);
                        }
                        else
                        {
                            wantToContinue = false;
                        }

                    }

                }

                result = numbers[0];

                for (int i = 1; i < numbers.Count; i++)
                {
                    result = result / numbers[i];
                }

                Console.WriteLine($"EL RESULTADO ES: {result}");

                break;

            case 5:
                {
                    decimal note1;
                    Console.WriteLine("DIGITE LA PRIMERA NOTA: ");
                    while (!decimal.TryParse(Console.ReadLine()!, out note1) || note1 < 0 || note1 > 100)
                    {
                        Console.WriteLine("DATO INVALIDO, INGRESE UNA NOTA VALIDA: ");
                    }

                    decimal note2;
                    Console.WriteLine("DIGITE LA SEGUNDA NOTA: ");
                    while (!decimal.TryParse(Console.ReadLine()!, out note2) || note2 < 0 || note2 > 100)
                    {
                        Console.WriteLine("DATO INVALIDO, INGRESE UNA NOTA VALIDA: ");
                    }


                    decimal note3;
                    Console.WriteLine("DIGITE LA TERCERA NOTA: ");
                    while (!decimal.TryParse(Console.ReadLine()!, out note3) || note3 < 0 || note3 > 100)
                    {
                        Console.WriteLine("DATO INVALIDO, INGRESE UNA NOTA VALIDA: ");
                    }

                    decimal note4;
                    Console.WriteLine("DIGITE LA CUARTA NOTA: ");
                    while (!decimal.TryParse(Console.ReadLine()!, out note4) || note4 < 0 || note4 > 100)
                    {
                        Console.WriteLine("DATO INVALIDO, INGRESE UNA NOTA VALIDA: ");
                    }







                    decimal addition = note1 + note2 + note3 + note4;
                    decimal average = addition / 4;

                    Console.WriteLine($"EL PROMEDIO ES: {average}");

                    if (average >= 70)
                    {
                        Console.WriteLine("ESTUDIANTE APROBADO");
                    }
                    else
                    {
                        Console.WriteLine("ESTUDIANTE REPROBADO");
                    }
                }

                break;

       






        }

       

    }


   


    



    
}
catch(Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine("EL PROGRAMA NO PUDO COMPLETARSE DEBIDO AL ERROR");
}












