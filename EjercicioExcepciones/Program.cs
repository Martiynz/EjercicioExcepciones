using System;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Menú de Operaciones:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 5)
                    {
                        continuar = false;
                        continue;
                    }

                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            Console.WriteLine($"Resultado de la suma: {resultado}");
                            break;
                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            Console.WriteLine($"Resultado de la resta: {resultado}");
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            Console.WriteLine($"Resultado de la multiplicación: {resultado}");
                            break;
                        case 4:
                            resultado = operaciones.Dividir(num1, num2);
                            Console.WriteLine($"Resultado de la división: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un número válido.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}

