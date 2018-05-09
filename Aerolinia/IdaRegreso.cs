using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aerolinia
{
    public class IdaRegreso :RegistroPasaje,IPasaje
    {
        #region variables
        private string _id;
        private int _valorT;
        private DateTime _fechaI, _fechaR;
        #endregion

        #region propiedades
        public string ID
        {
            get { return _id; }

            set { _id = value; }
        }
        public int ValorT
        {
            get { return _valorT; }

            set { _valorT = value; }
        }
        public DateTime FechaI
        {
            get { return _fechaI; }

            set { _fechaI = value; }
        }
        public DateTime FechaR
        {
            get { return _fechaR; }

            set { _fechaR = value; }
        }
        
        #endregion

        #region
        public Ciudad ciudadO { get; set; }
        public Ciudad ciudadD { get; set; }
        #endregion

        #region contructor
        public IdaRegreso()
        {
            this.Init();
        }

        public IdaRegreso(string nombre, string apellidos, TipoPasaje tipo, int valorB, int total)
            : base(nombre, apellidos, tipo, valorB, total)      
        {
            this.Init();
        }

        private void Init()
        {
            ID = "PSJ-IYR";
            FechaI=DateTime.Now;
            FechaR = DateTime.Now;
            ciudadO = Ciudad.Seleccione;
            ciudadD = Ciudad.Seleccione;
            ValorT = 0;
        }
        #endregion

        public int Costo(int valorbase)
        {
            int Total = 0;
            Total=valorbase+((2/100)*valorbase)+((2*valorbase)*4/100);
            return Total;
        }
    }
}
