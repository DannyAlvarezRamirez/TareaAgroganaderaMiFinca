using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase es un objeto Raza con todas los parametros y metodos propios
     */
    class ObjetoRaza
    {
        //atributos
        private int intCodigoRaza;
        private string strDescripcionRaza;

        //constructores
        public ObjetoRaza(int codigoRaza, string descripcionRaza)
        {
            this.intCodigoRaza = codigoRaza;
            this.strDescripcionRaza = descripcionRaza;
        }//fin constructor con parametros

        //parametros
        //CodigoRaza
        public int CodigoRaza
        {
            set
            {
                this.intCodigoRaza = value;
            }
            get
            {
                return this.intCodigoRaza;
            }
        }//fin CodigoRaza
         //DescripcionRaza
        public string DescripcionRaza
        {
            set
            {
                this.strDescripcionRaza = value;
            }
            get
            {
                return this.strDescripcionRaza;
            }
        }//fin DescripcionRaza
        //GetInformacionObjetoRaza
        public string GetInformacionObjetoRaza()
        {
            return "Información de la raza*\nCodigo Raza = " + this.intCodigoRaza + ", " +
                "Descripcion de la raza = " + this.strDescripcionRaza;
        }//fin GetInformacionObjetoRaza
    }//fin clase ObjetoRaza
}
