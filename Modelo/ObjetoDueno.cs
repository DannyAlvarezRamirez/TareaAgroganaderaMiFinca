using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase es un objeto Dueno con todas los parametros y metodos propias, esta clase hereda de ObjetoPersona
     */
    class ObjetoDueno : ObjetoPersona
    {
        //atributos
        private string strCorreoElectronicoDueno, strNumeroCelularDueno;
        private ObjetoFinca objFincaDueno;

        //constructores
        public ObjetoDueno(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            string correoElectronicoDueno, string numeroCelularDueno, ObjetoFinca objFincaDueno)
            : base(identificacionPersona, nombrePersona, primerApellido, segundoApellido)
        {
            this.strCorreoElectronicoDueno = correoElectronicoDueno;
            this.strNumeroCelularDueno = numeroCelularDueno;
            this.objFincaDueno = objFincaDueno;
        }//fin constructor con parametros

        //parametros
        //CorreoElectronicoDueno
        public string CorreoElectronicoDueno
        {
            set
            {
                this.strCorreoElectronicoDueno = value;
            }
            get
            {
                return this.strCorreoElectronicoDueno;
            }
        }//fin CorreoElectronicoDueno
        //NumeroCelularDueno
        public string NumeroCelularDueno
        {
            set
            {
                this.strNumeroCelularDueno = value;
            }
            get
            {
                return this.strNumeroCelularDueno;
            }
        }//fin NumeroCelularDueno
        //FincaDueno
        public ObjetoFinca FincaDueno
        {
            set
            {
                this.objFincaDueno = value;
            }
            get
            {
                return this.objFincaDueno;
            }
        }//fin FincaDueno
        //GetInformacionObjetoDueno
        public string GetInformacionObjetoDueno()
        {
            return "Información del dueno*\nIdentificacion = " + this.IdentificacionPersona + ", Nombre = " + this.NombrePersona + ", " +
                "Primer Apellido = " + this.PrimerApellidoPersona + ", Segundo Apellido = " + this.SegunoApellidoPersona + ", Correo electronico = " + this.CorreoElectronicoDueno +
                ", Numero Celular = " + this.NumeroCelularDueno + ", Nombre de la Finca = " + this.objFincaDueno.NombreFinca;
        }//fin GetInformacionObjetoDueno
    }//fin clase ObjetoDueno
}
