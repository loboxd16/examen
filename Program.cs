// See https://aka.ms/new-console-template for more information




using System.Diagnostics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

string opcion;



    do
    {



        Console.WriteLine("Ingresa una de las siguientes opciones");
        Console.WriteLine("A) Opcion para saber si su numero es positivo, negativo o cero");
        Console.WriteLine("B) Opcion para saber el dia de la semana");
        Console.WriteLine("C) Opcion para saber la suma de los 100 numeros naturales");
        Console.WriteLine("D) Opcion para saber los numeros ingresados");
        Console.WriteLine("E) Opcion para saber el area de un circulo");
        Console.WriteLine("F) Opcion para mostrar los elementos de un arreglo unidimensional");
        Console.WriteLine("G) Opcion para saber el area de un circulo");
        Console.WriteLine("B) Opcion para mostrar nombres de personas");

        Console.WriteLine("S) Salir");


        opcion = Console.ReadLine().ToUpper();


        switch (opcion)
        {
            case "A":

                int ingresanumero()
                {

                    Console.WriteLine("Ingrese numero");
                    int numero = int.Parse(Console.ReadLine());

                    return numero;
                }


                int numeroPosi(int numero)


                {
                    numero = ingresanumero();


                    if (numero == 0)
                    {
                        Console.WriteLine("El numero es cero");
                    }
                    if (numero > 2)
                    {
                        Console.WriteLine("El numero es positivo");
                    }
                    if (numero < 0)
                    {
                        Console.WriteLine("El numero es negativo");
                    }

                    return numero;
                }





                break;

            case "B":

                void diasemana()
                {

                    int numeros = ingresanumero();


                    switch (numeros)
                    {
                        case 1:
                            Console.WriteLine("¡Es lunes! Comienza la semana con energía.");
                            break;

                        case 2:
                            Console.WriteLine("¡Es martes! Sigue avanzando.");
                            break;



                        case 3:
                            Console.WriteLine("¡Es miércoles! Ya estás en el ecuador de la semana.");
                            break;
                        case 4:
                            Console.WriteLine("¡Es jueves! Casi es el fin de semana.");
                            break;
                        case 5:
                            Console.WriteLine("¡Es viernes! El fin de semana está cerca.");
                            break;
                        case 6:
                            Console.WriteLine("¡Es sábado! Disfruta tu tiempo libre.");

                            break;

                        case 7:
                            Console.WriteLine("¡Es domingo! Prepárate para la nueva semana.");
                            break;
                        default:
                            Console.WriteLine("Día no válido. Por favor, ingrese un día de la semana válido.");
                            break;



                    }
                }


                break;


            case "C":

                int sumanumeros(int numeros)


                {
                    int suma = 0;
                    for (int i = 0; i <= 100; i++)
                    {




                        suma += i;
                    }
                    return suma;


                }
                Console.WriteLine("la suma de los numeros naturales es  " + sumanumeros(20));

                break;

            case "D":

                void numeroscadenas()
                {

                    int numeros = ingresanumero();

                    for (int i = 1; i <= numeros; i++)
                    {
                        Console.WriteLine(i);
                    }
                }






                break;
            case "E":





                double CalcularArea()
                {

                    Console.WriteLine("ingresa numero de la radio");
                    int x2 = int.Parse(Console.ReadLine());



                    double valor1 = 3.14;

                    double area = Math.Sqrt(valor1 * (x2 * x2));

                    return area;

                }


                Console.WriteLine("La area del circulo es " + CalcularArea());

                break;

            case "F":


                void MostrarEleme()
                {

                    int[] arreglo = { 1, 2, 3, 4, 5 };
                    Console.WriteLine("Los Elementos del arreglo son:");
                    foreach (int num in arreglo)
                    {
                        Console.WriteLine(num);
                    }


                }
                Console.WriteLine("los elementos son:");
                MostrarEleme();






                break;

            case "G":
                static void mostrarnames()
                {
                    List<string> lista = new List<string> { "jhony", "juan", "pedro", "hans" };

                    Console.WriteLine("los nombres son");

                    foreach (string num in lista)
                    {
                        Console.WriteLine(num);
                    }
                }

                mostrarnames();


                break;
            default:

                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }


    } while (opcion != "S");



