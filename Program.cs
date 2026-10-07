int option;

do
{
    Console.WriteLine("===CHEVA CALCULATOR===");
    Console.WriteLine("1. SUMAR");
    Console.WriteLine("2. RESTAR");
    Console.WriteLine("3. MULTIPLICAR");
    Console.WriteLine("4. DIVIDIR");
    Console.WriteLine("5. VERIFICAR APROBACIÓN");
    Console.WriteLine("6. SALIR");

    Console.WriteLine("SELECCIONE UNA OPCION:");





    while (!int.TryParse(Console.ReadLine()!, out option) || option < 1 || option > 6)
    {
        Console.WriteLine("DATO INVALIDO, POR FAVOR SELECCIONE UNA OPCION VALIDA:");
    }


    switch (option)
    {
        case 1:
            int quantity;
            Console.WriteLine("INGRESE LA CANTIDAD DE NUMEROS QUE QUIERES SUMAR:");

            while (!int.TryParse(Console.ReadLine()!, out quantity) || quantity < 2)
            {
                Console.WriteLine("DATO INVALIDO, POR FAVOR LA CANTIDAD A SUMAR TIENE QUE SER MINIMO DE 2:");
            }

            int addition = 0;

            for (int i = 1; i<=quantity; i++)
            {

                int number = 0;
                Console.WriteLine($"INGRESA EL {i} NUMERO");
                while(!int.TryParse(Console.ReadLine()!, out number))
                {
                    Console.WriteLine("DATO INVALIDO, INGRESE UN NUMERO VALIDO: ");
                }
                

                addition += number;
                Console.WriteLine($"TOTAL: {addition}");
            }



            break;


        case 2:


            break;


        case 3:



            break;



        case 4:


            break;



        case 5:



            break;



        case 6:



            break;


    }


    } while (option != 6) ;











