using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase es un objeto Finca con todas los parametros y metodos propios
     */
    class ObjetoFinca
    {
        //atributos
        private int intNumeroFinca;
        private string strNombreFinca, strDireccionFinca, strTelefonoFinca;
        private double dbTamanoFinca;

        ////constructores
        public ObjetoFinca(int numeroFinca, string nombreFinca, string direccionFinca, string telefonoFinca, double tamanoFinca)
        {
            this.intNumeroFinca = numeroFinca;
            this.strNombreFinca = nombreFinca;
            this.strDireccionFinca = direccionFinca;
            this.strTelefonoFinca = telefonoFinca;
            this.dbTamanoFinca = tamanoFinca;
        }//fin constructor con parametros

        //parametros
        //NumeroFinca
        public int NumeroFinca
        {
            set
            {
                this.intNumeroFinca = value;
            }
            get
            {
                return this.intNumeroFinca;
            }
        }//fin NumeroFinca
        //NombreFinca
        public string NombreFinca
        {
            set
            {
                this.strNombreFinca = value;
            }
            get
            {
                return this.strNombreFinca;
            }
        }//fin NombreFinca
        //DireccionFinca
        public string DireccionFinca
        {
            set
            {
                this.strDireccionFinca = value;
            }
            get
            {
                return this.strDireccionFinca;
            }
        }//fin DireccionFinca
        //TelefonoFinca
        public string TelefonoFinca
        {
            set
            {
                this.strTelefonoFinca = value;
            }
            get
            {
                return this.strTelefonoFinca;
            }
        }//fin TelefonoFinca
        //TamanoFinca
        public double TamanoFinca
        {
            set
            {
                this.dbTamanoFinca = value;
            }
            get
            {
                return this.dbTamanoFinca;
            }
        }//fin TamanoFinca
        //GetInformacionObjetoFinca
        public string GetInformacionObjetoFinca()
        {
            return "Información de la finca*\nNumero = " + this.NumeroFinca + ", Nombre = " + this.NombreFinca + ", " +
                "Direccion = " + this.DireccionFinca + ", Telefono = " + this.TelefonoFinca + ", Tamano = " +
                this.TamanoFinca;
        }//fin GetInformacionObjetoFinca
    }//fin clase ObjetoFinca
}
