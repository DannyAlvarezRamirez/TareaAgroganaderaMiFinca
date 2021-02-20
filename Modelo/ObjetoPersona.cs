using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase es un objeto Persona con sus parametros y metodos propios,
     * de este objeto Persona o clase van a heredar las clases u objetos Dueno y Empleado
     */
    class ObjetoPersona
    {
        //atributos
        private int intIdentificacionPersona;
        private string strNombrePersona, strPrimerApellidoPersona, strSegundoApellidoPersona;

        //constructores
        public ObjetoPersona(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido)
        {
            this.intIdentificacionPersona = identificacionPersona;
            this.strNombrePersona = nombrePersona;
            this.strPrimerApellidoPersona = primerApellido;
            this.strSegundoApellidoPersona = segundoApellido;
        }//fin constructor con parametros

        //parametros
        //IdentificacionPersona
        public int IdentificacionPersona
        {
            set
            {
                this.intIdentificacionPersona = value;
            }
            get
            {
                return this.intIdentificacionPersona;
            }
        }//IdentificacionPersona
        //NombrePersona
        public string NombrePersona
        {
            set
            {
                this.strNombrePersona = value;
            }
            get
            {
                return this.strNombrePersona;
            }
        }//NombrePersona
        //PrimerApellidoPersona
        public string PrimerApellidoPersona
        {
            set
            {
                this.strPrimerApellidoPersona = value;
            }
            get
            {
                return this.strPrimerApellidoPersona;
            }
        }//PrimerApellidoPersona
        //SegunoApellidoPersona
        public string SegunoApellidoPersona
        {
            set
            {
                this.strSegundoApellidoPersona = value;
            }
            get
            {
                return this.strSegundoApellidoPersona;
            }
        }//SegunoApellidoPersona
    }//fin clase ObjetoPersona
}
