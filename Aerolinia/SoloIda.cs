using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerolinia
{
    public class SoloIda :RegistroPasaje,IPasaje
    {
        #region variables
        private string _id;
        private int _valorT;
        private DateTime _fechaV;
        #endregion

        #region propiedades
        public int ValorT
        {
            get { return _valorT; }

            set { _valorT = value; }
        }
        public string ID
        {
            get { return _id; }

            set { _id = value; }
        }
        public DateTime FechaV
        {
            get { return _fechaV; }

            set { _fechaV = value; }
        }
        #endregion

        #region
        public Ciudad ciudadO { get; set; }
        public Ciudad ciudadD { get; set; }
        #endregion

        #region contructor
        public SoloIda()
        {
            this.Init();
        }

        public SoloIda(string nombre, string apellidos, TipoPasaje tipo, int valorB, int total)
            : base(nombre, apellidos, tipo, valorB, total)      
        {
            this.Init();
        }

        private void Init()
        {
            ID = "PSJ-IDA";
            FechaV=DateTime.Now;
            ciudadO = Ciudad.Seleccione;
            ciudadD = Ciudad.Seleccione;
            ValorT = 0;
        }
        #endregion

        public int Costo(int valorbase)
        {
            int Total = 0;
            Total = valorbase + ((5 / 100) * valorbase) + (valorbase * 3 / 100);
            return Total;
        }
    }
}
