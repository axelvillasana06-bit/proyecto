using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoFutbol
{
    class Equipo
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strCategoria;

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }

        private List<Jugador> _listaJugadores = new List<Jugador>();

        public void InsertarJugador(Jugador unJugador)
        {
            _listaJugadores.Add(unJugador);
        }

        ~Equipo()
        {
            _listaJugadores.Clear();
        }

        public IEnumerator<Jugador> GetEnumerator()
        {
            return _listaJugadores.GetEnumerator();
        }
        
        public override string ToString()
        {
            return "El Nombre del Equipo es: " + Nombre + "\nCategoria: " + Categoria;
        }

        public void OrdenarJugadores()
        {
            _listaJugadores.Sort();  // Usa el CompareTo() de Jugador
        }

        public Jugador ObtenerJugador(int index)
        {
            if (index >= 0 && index < _listaJugadores.Count)
                return _listaJugadores[index];
            return null;
        }
        public void EliminarJugador(int index)
        {
            if (index >= 0 && index < _listaJugadores.Count)
            {
                _listaJugadores.RemoveAt(index); // Elimina el jugador en la posición dada
            }
        }
    }
}
