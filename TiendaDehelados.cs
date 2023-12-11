using System;
using System.Collections.Generic;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class TiendaDeHelados : IPublisher
    {
        public string NombreHelado { get; set; } = "cono";
        private List<IObserver> ListaDeObservadores { get; set; }

        public TiendaDeHelados()
        {
            ListaDeObservadores = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            ListaDeObservadores.Add(observer);
        }

        public void NotifyAll()
        {
            // Crear una copia de la lista para evitar la excepción "Collection was modified"
            var observadoresCopia = new List<IObserver>(ListaDeObservadores);
            
            foreach (var observador in observadoresCopia)
            {
                observador.Notify($"¡Nombre de helado! {NombreHelado}");
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            ListaDeObservadores.Remove(observer);
        }

        public void LlegoElHelado(int numero)
        {
            Console.WriteLine($"Mi helado llegó {numero}");
            NombreHelado = "manjar";
            NotifyAll();
        }
    }
}