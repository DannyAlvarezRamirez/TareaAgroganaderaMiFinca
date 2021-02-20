using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase se encarga de controlar las acciones que se vinculan 
     * con el ObjetoAnimal(Array o arreglo de objetos tipo ObjetoAnimal)
     */
    class ControladorAnimal
    {
        //atributos
        private int tamano;
        private ObjetoAnimal[] miArrayAnimal;

        //constructores
        public ControladorAnimal()
        {
            this.tamano = 10;
            this.miArrayAnimal = new ObjetoAnimal[this.tamano];
        }//fin constructor

        //parametros-metodos
        /*
        * GetSexoAnimal: este metodo o parametro se encarga de obtener un arreglo o array de Objetos Animales
        */
        public string GetSexoAnimal(int opcion)
        {
            //asignar valor a sexoAnimal = Macho o Hembra
            if (opcion == 1)
            {
                return "Macho";
            }//fin if sexo
            else
            {
                return "Hembra";
            }//fin else sexo
        }//fin GetSexoAnimal
        /* RegistrarAnimal: este metodo se encarga de registrar los objetos Animal en un array programado manualmente
        * que es de tipo ObjetoAnimal, de un tamano predeterminado 10. 
        * 
        */
        public string RegistrarAnimal(int indice, ObjetoAnimal objetoAnimal)
        {
            String salida = "";
            if (indice >= 0 && indice < this.tamano)
            {
                if (this.miArrayAnimal[indice] == null)
                {
                    this.miArrayAnimal[indice] = objetoAnimal;
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
        /* MostrarAnimal: este metodo se encarga de mostrar la informacion que se encuentra dentro del array para poder
         * imprimirlo en la consola o pantalla.
         * 
         */
        public string MostrarAnimal()
        {
            String salida = "";
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayAnimal[i] != null)
                {
                    salida += "\nIndice: " + i + " = " + this.miArrayAnimal[i].GetInformacionObjetoAnimal();
                }//fin if
                else
                {
                    salida += "\nIndice " + i + " = vacía.";
                }//fin else
            }//fin for
            return "\n****Lista de Animales Actuales****\n" + salida;
        }//fin MostrarAnimal
        /*
        *  VerificarIdentificacion: se encarga de verificar si ya existe o no un animal con un numero que lo identifica como unico 
        */
        public int VerificarIdentificacion(int identificacion)
        {
            int salida = 0;
            int contador = 0;
            int fila = 0;
            //recorrer el arreglo 
            for (int i = 0; i < this.tamano; i++)
            {
                if (this.miArrayAnimal[i] != null && this.miArrayAnimal[i].IdentificacionAnimal == identificacion)
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
    }//fin clase ControladorAnimal
}
