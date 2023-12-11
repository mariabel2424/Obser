namespace ObserverPattern.Interfaces
{
    public class Belen : IObserver
    {
        private TiendaDeHelados tiendaDeHelados;

        public Belen(TiendaDeHelados tiendaDe)
        {
            tiendaDeHelados = tiendaDe;
            tiendaDeHelados.AddObserver(this);
        }

        public void Notify(string mensaje)
        {
            Console.WriteLine($"Hola soy Belen: {mensaje}");
            tiendaDeHelados.RemoveObserver(this);
        }
    }
}