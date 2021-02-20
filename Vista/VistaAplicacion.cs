using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * Esta clase es la vista de la aplicaion: se despliegan la interfaz con que interactua el usuario
     */
    class VistaAplicacion
    {
        //parametros
        //MenuPrincipal
        public int MenuPrincipal()
        {
            string strOpcion;
            Console.WriteLine("*Menu Principal*\nDigite una opción:\n1. Registrar Finca.\n2. Registrar Dueño." +
                "\n3. Registrar Empleado.\n4. Registrar Raza de Animales.\n5. Registrar Animales." +
                "\n6. Mostrar los Registros.\n7. Salir de sistema.");
            return Convert.ToInt32(strOpcion = Console.ReadLine());
        }// fin MenuPrincipal
        //Entrada informacion sistema input
        public string input(string strEntrada)
        {
            string strSalida;
            Console.WriteLine(strEntrada);
            return strSalida = Console.ReadLine();
        }//fin Entrada informacion sistema input
        //Entrada informacion sistema inputInt
        public int inputInt(string strEntrada)
        {
            string strSalida;
            Console.WriteLine(strEntrada);
            return Convert.ToInt32(strSalida = Console.ReadLine());
        }//fin Entrada informacion sistema inputInt
        //Entrada informacion sistema inputDouble
        public double inputDouble(string strEntrada)
        {
            string strSalida;
            Console.WriteLine(strEntrada);
            return Convert.ToDouble(strSalida = Console.ReadLine());
        }//fin Entrada informacion sistema inputDouble
        //Salida informacion sistema output
        public void output(string strSalida)
        {
            Console.WriteLine(strSalida);
        }//fin Salida informacion sistema output
    }//fin VistaAplicacion
}
