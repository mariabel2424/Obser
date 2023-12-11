using System;
using System.Threading.Tasks;
using ObserverPattern;
using ObserverPattern.Interfaces;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Hello, World!");
        TiendaDeHelados tiendaDeHelados = new TiendaDeHelados();
        Belen belen = new Belen(tiendaDeHelados);
        Maria maria = new Maria(tiendaDeHelados);

        int i = 0;
        while (true)
        {
            tiendaDeHelados.LlegoElHelado(i);
            i++;

            // Esperar 2 segundos antes de la próxima iteración
            await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}



