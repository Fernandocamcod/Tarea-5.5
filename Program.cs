using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] opciones = { "piedra", "papel", "tijera" };
        string jugarDeNuevo = "si"; // Inicializar jugarDeNuevo antes del bucle

        do
        {
            Console.WriteLine("Elige: piedra, papel o tijera:");
            string eleccionUsuario = Console.ReadLine().ToLower();

            // Validar la elección del usuario
            if (Array.IndexOf(opciones, eleccionUsuario) == -1)
            {
                Console.WriteLine("Opción inválida. Por favor elige piedra, papel o tijera.");
                continue; // Volver a pedir la elección
            }

            // Elección de la computadora
            int eleccionComputadoraIndex = random.Next(0, 3);
            string eleccionComputadora = opciones[eleccionComputadoraIndex];

            Console.WriteLine($"La computadora eligió: {eleccionComputadora}");

            // Determinar el resultado
            if (eleccionUsuario == eleccionComputadora)
            {
                Console.WriteLine("¡Es un empate!");
            }
            else if ((eleccionUsuario == "piedra" && eleccionComputadora == "tijera") ||
                     (eleccionUsuario == "papel" && eleccionComputadora == "piedra") ||
                     (eleccionUsuario == "tijera" && eleccionComputadora == "papel"))
            {
                Console.WriteLine("¡Ganaste!");
            }
            else
            {
                Console.WriteLine("¡Perdiste!");
            }

            // Preguntar si el usuario quiere jugar de nuevo
            Console.WriteLine("¿Quieres jugar de nuevo? (si/no):");
            jugarDeNuevo = Console.ReadLine().ToLower();

        } while (jugarDeNuevo == "si");

        Console.WriteLine("Gracias por jugar. ¡Hasta luego!");

        // Esperar a que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}