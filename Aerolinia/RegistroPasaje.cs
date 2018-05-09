using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aerolinia;

namespace Aerolinia
{
    public class RegistroPasaje
    {
        #region varibales
        protected string _nombre, _apellidos;
        protected TipoPasaje _tipo;
        protected int _valorB, _total;
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return _nombre; }

            set { _nombre = value; }
        }
        public string Apellidos
        {
            get { return _apellidos; }

            set { _apellidos = value; }
        }
        
        public int ValorB
        {
            get { return _valorB; }

            set { _valorB = value; }
        }
        public int Total
        {
            get { return _total; }

            set { _total = value; }
        }
        #endregion

        #region propiedades enum
        public TipoPasaje Tipo { get; set; }
        #endregion

        #region constructor
        public RegistroPasaje()
        {
            Init();
        }

        public RegistroPasaje(string nombre, string apellidos, TipoPasaje tipo, int valorB, int total)
        {
            _nombre = nombre;
            _apellidos = apellidos;
            Tipo = TipoPasaje.Seleccione;
            _valorB = valorB;
            _total = total;
        }

        public void Init()
        {
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Tipo= TipoPasaje.Seleccione;
            ValorB = 0;
            Total = 0;
        }
        #endregion

    }
}
