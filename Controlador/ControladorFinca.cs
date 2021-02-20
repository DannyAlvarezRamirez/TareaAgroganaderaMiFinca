using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase se encarga de controlar las acciones que se vinculan 
     * con el ObjetoFinca(Array o arreglo de objetos tipo ObjetoFinca)
     */
    class ControladorFinca
    {
        //atributos
        private int tamano;
        private ObjetoFinca[] miArrayFinca;

        //constructores
        public ControladorFinca()
        {
            this.tamano = 10;
            this.miArrayFinca = new ObjetoFinca[this.tamano];
        }//fin constructor

        //parametros-metodos
        /*
        * GetArrayObjetosFinca : este metodo se encarga de devolver el arreglo de objetos finca
        */
        public ObjetoFinca[] GetArrayObjetosFinca()
        {
            return this.miArrayFinca;
        }//fin GetArrayObjetosFinca

        /*
        * GetObjetoFinca: este metodo o parametro se encarga de obtener un Objeto Finca con un el indice especificado por parametros
        */
        public ObjetoFinca GetObjetoFinca(int indice)
        {
            return this.miArrayFinca[indice];
        }//fin GetObjetoFinca
        /* RegistrarFinca: este metodo se encarga de registrar los objetos Finca en un array programado manualmente
        * que es de tipo ObjetoFinca, de un tamano predeterminado 10. 
        * 
        */
        public string RegistrarFinca(int indice, ObjetoFinca objetoFinca)
        {
            String salida = "";
            if (indice >= 0 && indice < this.tamano)
            {
                if (this.miArrayFinca[indice] == null)
                {
                    this.miArrayFinca[indice] = objetoFinca;
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
        }//fin RegistrarFinca
        /* MostrarFinca: este metodo se encarga de mostrar la informacion que se encuentra dentro del array para poder
         * imprimirlo en la consola o pantalla.
         * 
         */
        public string MostrarFinca()
        {
            String salida = "";
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayFinca[i] != null)
                {
                    salida += "\nIndice: " + i + " = " + this.miArrayFinca[i].GetInformacionObjetoFinca();
                }//fin if
                else
                {
                    salida += "\nIndice " + i + " = vacía.";
                }//fin else
            }//fin for
            return "\n****Lista de Fincas Actuales****\n" + salida;
        }//fin MostrarFinca
        /*
        *  VerificarNumero: se encarga de verificar si ya existe o no una finca con un numero que lo identifica como unico 
        */
        public int VerificarNumero(int numero)
        {
            int salida = 0;
            int contador = 0;
            int fila = 0;
            //recorrer el arreglo 
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayFinca[i] != null && this.miArrayFinca[i].NumeroFinca == numero)
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
        }//fin VerificarNumero
    }//fin clase ControladorFinca
}
