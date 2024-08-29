class Program
{
    static void Main()
    {
        bool jugarDeNuevo = true;

        while (jugarDeNuevo)
        {
            Console.WriteLine("¿Quieres empezar a jugar? (y/n)");
            char respuesta = Convert.ToChar(Console.ReadLine().ToLower());

            if (respuesta == 'y')
            {
                IniciarJuego();

                Console.WriteLine("¿Quieres volver a jugar? (y/n)");
                respuesta = Convert.ToChar(Console.ReadLine().ToLower());

                if (respuesta != 'y')
                {
                    jugarDeNuevo = false;
                }
            }
            else
            {
                jugarDeNuevo = false;
            }
        }
    }

    static void IniciarJuego()
    {
        string[] palabras =
        {
            "tangamandapio", "anticonstitucionalidad", "esternocleidomastoideo",
            "otorrinolaringologo", "electroencefalografista", "superextraordinarisimo"
        };

        Random generador = new Random();
        int NumeroAlAzar = generador.Next(0, palabras.Length);
        string PalabraAdivinar = palabras[NumeroAlAzar];

        string MostrarPalabra = "";
        for (int i = 0; i < PalabraAdivinar.Length; i++)
        {
            if (PalabraAdivinar[i] == ' ')
                MostrarPalabra += " "; 
            else
                MostrarPalabra += "-"; 
        }

        int OportunidadesRestantes = 10;
        char letraActual;
        bool fin = false;

        do
        {
            Console.WriteLine("Palabra a descubrir: " + MostrarPalabra);
            Console.WriteLine("Intentos Restantes: " + OportunidadesRestantes);

            Console.WriteLine("Ingresa una letra");
            letraActual = Convert.ToChar(Console.ReadLine());

            if (!PalabraAdivinar.Contains(letraActual))
            {
                OportunidadesRestantes--;
                Horca(OportunidadesRestantes);
            }

            string SiguienteMostrar = "";
            for (int i = 0; i < PalabraAdivinar.Length; i++)
            {
                if (letraActual == PalabraAdivinar[i])
                    SiguienteMostrar += letraActual;
                else
                    SiguienteMostrar += MostrarPalabra[i];
            }
            MostrarPalabra = SiguienteMostrar;

            if (!MostrarPalabra.Contains("-"))
            {
                Console.WriteLine("¡Felicidades, has ganado!");
                fin = true;
            }
            else if (OportunidadesRestantes == 0)
            {
                Console.WriteLine("Lo siento, has perdido.");
                Console.WriteLine("La palabra era: " + PalabraAdivinar);
                fin = true;
            }

        } while (!fin);
    }

    static void Horca(int OportunidadesRestantes)
    {
        switch (OportunidadesRestantes)
        {
            case 9:
                Console.WriteLine("-");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 8:
                Console.WriteLine("-----");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 7:
                Console.WriteLine("-------");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 6:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 5:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 4:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 3:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 2:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 1:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / ");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 0:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
        }
    }
}
