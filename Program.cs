using System.ComponentModel.Design;
using System.Drawing;
bool b = true;
do
{ 
    Console.WriteLine("elige un color:");
    Console.WriteLine("-----------------");
    Console.WriteLine("1. rojo");
    Console.WriteLine("2. azul");
    Console.WriteLine("3. amarillo");
    Console.WriteLine("4. magenta");
    Console.WriteLine("5. gris");
    Console.WriteLine("6. negro");
    Console.WriteLine("7. verde");
    Console.WriteLine("8. blanco");
    Console.WriteLine("9. rosado");
    Console.WriteLine("10. naranja");

    var color = int.Parse(Console.ReadLine());
    Console.WriteLine("ingresa tu nombre:");
    var nombre = Console.ReadLine();
    Console.WriteLine("ingresa tu nùmero de documento");
    var documento = Console.ReadLine();

  


        if (color == 1)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es rojo");
        }

        else if (color == 2)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es azul");
        }

        else if (color == 3)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es amarillo");
        }

        else if (color == 4)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es magenta y recibiras un premio ");
        b = false;
    }
         
        else if (color == 5)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es gris");
        }

        else if (color == 6)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es negro");
        }

        else if (color == 7)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es verde");
        }

        else if (color == 8)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es blanco");
        }

        else if (color == 9)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es rosado");
        }

        else if (color == 10)
        {
            Console.WriteLine($"gracias {nombre} su color favorito es naranja");
        }

        else
        {
            Console.WriteLine($"opción inválida, por favor ingresa un número del 1 al 10");
        }
    Console.WriteLine();
} while (b);


Console.WriteLine("Programa finalizado. ¡Gracias por participar!");