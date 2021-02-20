using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase se encarga de controlar las acciones que se vinculan 
     * con el ObjetoRaza(Array o arreglo de objetos tipo ObjetoRaza)
     */
    class ControladorRaza
    {
        //atributos
        private int tamano;
        private ObjetoRaza[] miArrayRaza;

        //constructores
        public ControladorRaza()
        {
            this.tamano = 10;
            this.miArrayRaza = new ObjetoRaza[this.tamano];
        }//fin constructor

        //parametros-metodos
        /*
        * GetArrayObjetosRaza : este metodo se encarga de devolver el arreglo de objetos raza
        */
        public ObjetoRaza[] GetArrayObjetosRaza()
        {
            return this.miArrayRaza;
        }//fin GetArrayObjetosRaza
        /*
        * GetObjetoRaza: este metodo o parametro se encarga de obtener un arreglo o array de Objetos Raza
        */
        public ObjetoRaza GetObjetoRaza(int indice)
        {
            return this.miArrayRaza[indice];
        }//fin GetObjetoRaza
        /* RegistrarRaza: este metodo se encarga de registrar los objetos Finca en un array programado manualmente
        * que es de tipo ObjetoRaza, de un tamano predeterminado 10. 
        * 
        */
        public string RegistrarRaza(int indice, ObjetoRaza objetoRaza)
        {
            String salida = "";
            if (indice >= 0 && indice < this.tamano)
            {
                if (this.miArrayRaza[indice] == null)
                {
                    this.miArrayRaza[indice] = objetoRaza;
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
        }//fin RegistrarAnimal
        /* MostrarRaza: este metodo se encarga de mostrar la informacion que se encuentra dentro del array para poder
         * imprimirlo en la consola o pantalla.
         * 
         */
        public string MostrarRaza()
        {
            String salida = "";
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayRaza[i] != null)
                {
                    salida += "\nIndice: " + i + " = " + this.miArrayRaza[i].GetInformacionObjetoRaza();
                }//fin if
                else
                {
                    salida += "\nIndice " + i + " = vacía.";
                }//fin else
            }//fin for
            return "\n****Lista de Razas Actuales****\n" + salida;
        }//fin MostrarRaza
        /*
        *  VerificarCodigo: se encarga de verificar si ya existe o no una raza con un numero que lo identifica como unico 
        */
        public int VerificarCodigo(int codigo)
        {
            int salida = 0;
            int contador = 0;
            int fila = 0;
            //recorrer el arreglo 
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayRaza[i] != null && this.miArrayRaza[i].CodigoRaza == codigo)
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
        }//fin VerificarCodigo
    }//fin clase ControladorRaza
}
