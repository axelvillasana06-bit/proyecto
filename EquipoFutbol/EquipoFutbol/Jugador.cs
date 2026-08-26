using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoFutbol
{
    class Jugador : IComparable <Jugador>
    {
        private int _intDorsal;

        public int Dorsal
        {
            get { return _intDorsal; }
            set { _intDorsal = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private char _chrPosicion;

        public char Posicion
        {
            get { return _chrPosicion; }
            set { _chrPosicion = value; }
        }

        private bool _Titular;

        public bool Titular
        {
            get { return _Titular; }
            set { _Titular = value; }
        }

        private DateTime _dtmFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }


        public override string ToString()
        {
            return "Datos del jugador:\n\nNombre: " + Nombre + "\nDorsal: " + Dorsal + "\nPosicion:" + Posicion + "\nTitular: " + (Titular? "Si":"No") + "\nFecha de Nacimiento: " + FechaNacimiento.ToShortDateString();

        }


        private static readonly Dictionary<char, int> ordenPosiciones = new Dictionary<char, int>
    {
        { 'P', 1 },  // Portero
        { 'D', 2 },  // Defensa
        { 'M', 3 },  // Mediocampista
        { 'A', 4 }   // Atacante
    };

        public int CompareTo(Jugador otro)
        {
            return ordenPosiciones[Posicion].CompareTo(ordenPosiciones[otro.Posicion]);
        }
        

    }
}
