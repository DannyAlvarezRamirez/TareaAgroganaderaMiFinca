using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase es un objeto Empleado con todas los parametros y metodos propias, esta clase hereda de ObjetoPersona
     */
    class ObjetoEmpleado : ObjetoPersona
    {
        //atributos
        private double strSalarioEmpleado;

        //constructores
        public ObjetoEmpleado(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            double salarioEmpleado)
            : base(identificacionPersona, nombrePersona, primerApellido, segundoApellido)
        {
            this.strSalarioEmpleado = salarioEmpleado;
        }//fin constructor con parametros

        //parametros
        //SalarioEmpleado
        public double SalarioEmpleado
        {
            set
            {
                this.strSalarioEmpleado = value;
            }
            get
            {
                return this.strSalarioEmpleado;
            }
        }//fin SalarioEmpleado
        //GetInformacionObjetoEmpleado
        public string GetInformacionObjetoEmpleado()
        {
            return "Información del empleado*\nIdentificacion = " + this.IdentificacionPersona + ", Nombre = " + this.NombrePersona + ", " +
                "Primer Apellido = " + this.PrimerApellidoPersona + ", Segundo Apellido = " + this.SegunoApellidoPersona + ", Salario = " + this.SalarioEmpleado;
        }//fin GetInformacionObjetoEmpleado
    }//fin clase ObjetoEmpleado
}
