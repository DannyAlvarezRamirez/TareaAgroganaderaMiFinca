using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase se encarga de controlar las acciones que se vinculan 
     * con el ObjetoEmpleado(Array o arreglo de objetos tipo ObjetoEmpleado)
     */
    class ControladorEmpleado
    {
        //atributos
        private int tamano;
        private ObjetoEmpleado[] miArrayEmpleado;

        //constructores
        public ControladorEmpleado()
        {
            this.tamano = 10;
            this.miArrayEmpleado = new ObjetoEmpleado[this.tamano];
        }//fin constructor

        //parametros-metodos
        /* RegistrarEmpleado: este metodo se encarga de registrar los objetos Empleado en un array programado manualmente
        * que es de tipo ObjetoEmpleado, de un tamano predeterminado 10. 
        * 
        */
        public string RegistrarEmpleado(int indice, ObjetoEmpleado objetoEmpleado)
        {
            String salida = "";
            if (indice >= 0 && indice < this.tamano)
            {
                if (this.miArrayEmpleado[indice] == null)
                {
                    this.miArrayEmpleado[indice] = objetoEmpleado;
                    salida = "Se agregó bien.";
                }//fin if array lleno
                else
                {
                    return "El indice está llena.";
                }//fin else array lleno
            }//fin if indice
            else
            {
                return "Indice fuera de rango.";
            }//fin else indice
            return salida;
        }//fin RegistrarEmpleado
        /* MostrarEmpleado: este metodo se encarga de mostrar la informacion que se encuentra dentro del array para poder
         * imprimirlo en la consola o pantalla.
         */
        public string MostrarEmpleado()
        {
            String salida = "";
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayEmpleado[i] != null)
                {
                    salida += "\nIndice: " + i + " = " + this.miArrayEmpleado[i].GetInformacionObjetoEmpleado();
                }//fin if
                else
                {
                    salida += "\nIndice " + i + " = vacía.";
                }//fin else
            }//fin for
            return "\n****Lista de Empleados Actuales****\n" + salida;
        }//fin MostrarEmpleado
        /*
        *  VerificarIdentificacion: se encarga de verificar si ya existe o no un empleado con un numero que lo identifica como unico 
        */
        public int VerificarIdentificacion(int identificacion)
        {
            int salida = 0;
            int contador = 0;
            int fila = 0;
            //recorrer el arreglo 
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayEmpleado[i] != null && this.miArrayEmpleado[i].IdentificacionPersona == identificacion)
                {
                    fila = i;
                    contador++;
                    break;
                }//fin if
            }//fin for
            //preguntar si contador es mayor que 0 entonces si existe
            if (contador > 0)
            {
                salida = fila;
            }//fin if
            else
            {
                salida = -1;
            }//fin else no existe, se puede proceder a registrar
            return salida;
        }//fin VerificarIdentificacion
    }//fin clase ControladorEmpleado
}
