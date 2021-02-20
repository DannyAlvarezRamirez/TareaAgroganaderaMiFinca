using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    class ObjetoAnimal
    {
        //atributos
        private int intIdentificacionAnimal;
        private string strSexoAnimal, strMadreAnimal, strPadreAnimal, strNombreAnimal, strFechaNacimientoAnimal;
        private ObjetoFinca objFincaAnimal;
        private ObjetoRaza objRazaAnimal;

        //constructores
        public ObjetoAnimal(int identificacionAnimal, string sexoAnimal, string madreAnimal, string padreAnimal, string nombreAnimal,
            string fechaNacimientoAnimal, ObjetoFinca objFincaAnimal, ObjetoRaza objRazaAnimal)
        {
            this.intIdentificacionAnimal = identificacionAnimal;
            this.strSexoAnimal = sexoAnimal;
            this.strMadreAnimal = madreAnimal;
            this.strPadreAnimal = padreAnimal;
            this.strNombreAnimal = nombreAnimal;
            this.strFechaNacimientoAnimal = fechaNacimientoAnimal;
            this.objFincaAnimal = objFincaAnimal;
            this.objRazaAnimal = objRazaAnimal;
        }//fin construcor con parametros

        //parametros
        //IdentificacionAnimal
        public int IdentificacionAnimal
        {
            set
            {
                this.intIdentificacionAnimal = value;
            }
            get
            {
                return this.intIdentificacionAnimal;
            }
        }//fin IdentificacionAnimal
        //SexoAnimal
        public string SexoAnimal
        {
            set
            {
                this.strSexoAnimal = value;
            }
            get
            {
                return this.strSexoAnimal;
            }
        }//fin SexoAnimal
        //MadreAnimal
        public string MadreAnimal
        {
            set
            {
                this.strMadreAnimal = value;
            }
            get
            {
                return this.strMadreAnimal;
            }
        }//fin MadreAnimal
        //PadreAnimal
        public string PadreAnimal
        {
            set
            {
                this.strPadreAnimal = value;
            }
            get
            {
                return this.strPadreAnimal;
            }
        }//fin PadreAnimal
        //NombreAnimal
        public string NombreAnimal
        {
            set
            {
                this.strNombreAnimal = value;
            }
            get
            {
                return this.strNombreAnimal;
            }
        }//fin NombreAnimal
        //FechaNacimientoAnimal
        public string FechaNacimientoAnimal
        {
            set
            {
                this.strFechaNacimientoAnimal = value;
            }
            get
            {
                return this.strFechaNacimientoAnimal;
            }
        }//fin FechaNacimientoAnimal
        //ObjetoFincaAnimal
        public ObjetoFinca ObjetoFincaAnimal
        {
            set
            {
                this.objFincaAnimal = value;
            }
            get
            {
                return this.objFincaAnimal;
            }
        }//fin ObjetoFincaAnimal
        //ObjetoRazaAnimal
        public ObjetoRaza ObjetoRazaAnimal
        {
            set
            {
                this.objRazaAnimal = value;
            }
            get
            {
                return this.objRazaAnimal;
            }
        }//fin ObjetoRazaAnimal
        //GetInformacionObjetoAnimal
        public string GetInformacionObjetoAnimal()
        {
            return "Información del animal*\nIdentificacion = " + this.IdentificacionAnimal + ", Sexo = " + this.SexoAnimal + ", " +
                "Madre = " + this.MadreAnimal + ", Padre = " + this.PadreAnimal + ", Nombre = " + this.NombreAnimal +
                ", Fecha Nacimiento = " + this.FechaNacimientoAnimal + ", Nombre de la Finca = " + this.objFincaAnimal.NombreFinca +
                ", Raza = " + this.objRazaAnimal.DescripcionRaza;
        }//fin GetInformacionObjetoAnimal
    }//fin clase ObjetoAnimal
}
