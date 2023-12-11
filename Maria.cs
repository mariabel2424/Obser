using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public class Maria : IObserver
    {
        private TiendaDeHelados tiendaDeHelados;

        public Maria(TiendaDeHelados tiendaDe)
        {
            tiendaDeHelados = tiendaDe;
            tiendaDeHelados.AddObserver(this);
        }

        public void Notify(string mensaje)
        {
            Console.WriteLine($"Hola soy Maria: {mensaje}");
        }
    }
}
