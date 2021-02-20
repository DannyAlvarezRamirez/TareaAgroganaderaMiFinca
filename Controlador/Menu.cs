using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAgroganaderaMiFinca
{
    /*
     * esta clase es el controlador de la aplicacion que se encarga de desplegar el menu principal
     */
    class Menu
    {
        //atributos e instancias/referencias de clasee u objetos
        private int intOpcion;
        private int intSalir;
        private int intIndiceFinca2;
        private int intIndiceRaza2;
        private int intIndiceAnimal;
        private int intContadorFinca;
        private int intContadorAnimal;
        private int intContadorRaza;
        private int intContadorDueno;
        private int intContadorEmpleado;
        private int intOpcionFinca;
        private int intOpcionAnimal;
        private int intOpcionRaza;
        private int intOpcionSexo;
        private int intOpcionDueno;
        private int intOpcionEmpleado;
        private int intIndiceFinca;
        private int intIndiceRaza;
        private int intIndiceDueno;
        private int intIndiceEmpleado;
        private int intNumeroFinca;
        private int intCodigoRaza;
        private int intIdentificacionAnimal;
        private int intIdentificacionDueno;
        private int intIdentificacionEmpleado;
        private VistaAplicacion miVistaAplicacion;
        private ControladorFinca miControladorFinca;
        private ControladorAnimal miControladorAnimal;
        private ControladorRaza miControladorRaza;
        private ControladorDueno miControladorDueno;
        private ControladorEmpleado miControladorEmpleado;
        private ObjetoFinca miObjetoFinca;
        private ObjetoAnimal miObjetoAnimal;
        private ObjetoRaza miObjetoRaza;
        private ObjetoDueno miObjetoDueno;
        private ObjetoEmpleado miObjetoEmpleado;

        //constructores
        public Menu()
        {
            this.intOpcion = 0;
            this.intSalir = 0;
            this.intIndiceAnimal = 0;
            this.intIndiceFinca2 = 0;
            this.intIndiceRaza2 = 0;
            this.intIndiceDueno = 0;
            this.intIndiceEmpleado = 0;
            this.intContadorFinca = 0;
            this.intContadorAnimal = 0;
            this.intContadorRaza = 0;
            this.intContadorDueno = 0;
            this.intContadorEmpleado = 0;
            this.intOpcionFinca = 0;
            this.intOpcionAnimal = 0;
            this.intOpcionRaza = 0;
            this.intOpcionSexo = 0;
            this.intOpcionDueno = 0;
            this.intOpcionEmpleado = 0;
            this.intNumeroFinca = 0;
            this.intCodigoRaza = 0;
            this.intIdentificacionAnimal = 0;
            this.intIdentificacionDueno = 0;
            this.intIdentificacionEmpleado = 0;
            this.miVistaAplicacion = new VistaAplicacion();
            this.miControladorFinca = new ControladorFinca();
            this.miControladorRaza = new ControladorRaza();
            this.miControladorAnimal = new ControladorAnimal();
            this.miControladorDueno = new ControladorDueno();
            this.miControladorEmpleado = new ControladorEmpleado();
            this.menu();
        }//fin constructor

        //parametros o metodos
        /*
         * menu: se encarga de desplegar el menu principal con el que interactua el usuario
         */
        public void menu()
        {
            //do while
            do
            {
                try
                {
                    this.intOpcion = miVistaAplicacion.MenuPrincipal();//mostrar el menu y obtener la opcion deseada
                    switch (this.intOpcion)
                    {
                        case 1://Registrar Finca.
                            try
                            {
                                //bucle para preguntar si desea registrar fincas o desea salir al menu principal
                                do
                                {
                                    this.intOpcionFinca = this.miVistaAplicacion.inputInt("1. Desea continuar registrando fincas." +
                                        "\n2. Salir al menu principal.");

                                    switch (this.intOpcionFinca)
                                    {
                                        case 1:
                                            //contador para tope de 10 objetos finca
                                            if (this.intContadorFinca < 10)
                                            {
                                                //verificar si existe o no el numero de codigo
                                                if (this.miControladorFinca.VerificarNumero(this.intNumeroFinca = this.miVistaAplicacion.inputInt("Digite el numero de finca:")) == -1)
                                                {
                                                    this.miVistaAplicacion.output(
                                                    this.miControladorFinca.RegistrarFinca(this.intIndiceFinca2, this.miObjetoFinca =
                                                    new ObjetoFinca(
                                                        this.intNumeroFinca,
                                                        this.miVistaAplicacion.input("Digite el nombre de finca:"),
                                                        this.miVistaAplicacion.input("Digite la direccion de finca:"),
                                                        this.miVistaAplicacion.input("Digite el telefono de finca:"),
                                                        this.miVistaAplicacion.inputDouble("Digite el tamano de finca:"))));
                                                    this.intIndiceFinca2++;
                                                    this.intContadorFinca++;
                                                }//fin if verificar si existe o no el numero identificador de la finca 
                                                else
                                                {
                                                    this.miVistaAplicacion.output("El numero de codigo de finca ya existe. Por favor digite otro.");
                                                }//fin else verificar si existe o no el numero identificador de la finca
                                            }//fin if
                                            else
                                            {
                                                this.miVistaAplicacion.output("Ya registro el limite de fincas equivalente a 10.");
                                                this.menu();
                                            }
                                            break;
                                        case 2:
                                            this.menu();
                                            break;
                                        default:
                                            //mensaje opcion incorrecta
                                            this.miVistaAplicacion.output("Opcion fuera del rango.");
                                            break;
                                    }//fin switch

                                } while (this.intOpcionFinca != 2);//fin while
                            }//fin try
                            catch (Exception ex)
                            {
                                this.miVistaAplicacion.output("Ha introducido un valor invalido.");
                            }//fin catch
                            break;

                        case 2://Registrar Dueño./////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            try
                            {
                                //bucle para preguntar si desea registrar duenos o salir al menu principal
                                do
                                {
                                    this.intOpcionDueno = this.miVistaAplicacion.inputInt("1. Desea continuar registrando duenos." +
                                        "\n2. Salir al menu principal.");

                                    switch (this.intOpcionDueno)
                                    {
                                        case 1:
                                            //contador para tope de 10 objetos duenos
                                            if (this.intContadorDueno < 10)
                                            {
                                                //verificar si existe o no un dueno registrado con una identificacion digitada por el usuario
                                                if (this.miControladorDueno.VerificarIdentificacion(this.intIdentificacionDueno = this.miVistaAplicacion.inputInt("Digite la identificacion del dueno:")) == -1)
                                                {
                                                    //verificar si existen fincas, si no hay no se puede registrar duenos
                                                    if (this.miControladorFinca.GetArrayObjetosFinca().GetValue(0) != null)
                                                    {
                                                        //verificar si usuario elije un indice correcto de 1 a 10 arreglo de fincas
                                                        if (
                                                        this.VerificarIndice(this.intIndiceFinca = this.miVistaAplicacion.inputInt(this.miControladorFinca.MostrarFinca() + "\nDigite el indice de la finca del dueno:")) == true)
                                                        {
                                                            //llenar el array y el objeto
                                                            this.miVistaAplicacion.output(
                                                                this.miControladorDueno.RegistrarDueno(this.intIndiceDueno, this.miObjetoDueno =
                                                                new ObjetoDueno(
                                                                    this.intIdentificacionDueno,
                                                                    this.miVistaAplicacion.input("Digite el nombre del dueno:"),
                                                                    this.miVistaAplicacion.input("Digite el primer apellido del dueno:"),
                                                                    this.miVistaAplicacion.input("Digite el segundo apellido del dueno:"),
                                                                    this.miVistaAplicacion.input("Digite el correo electronico del dueno:"),
                                                                    this.miVistaAplicacion.input("Digite el numero de celular del dueno:"),
                                                                    this.miControladorFinca.GetObjetoFinca(this.intIndiceFinca))));
                                                            this.intIndiceDueno++;
                                                            this.intContadorDueno++;
                                                        }//fin if verificar sexo y objetos dentro de rango
                                                        else
                                                        {
                                                            this.miVistaAplicacion.output("Ha digitado un indice fuera de rango o una opcion que no es ni 1 ni 2.");
                                                        }//fin else verificar sexo y objetos dentro de rango
                                                    }//fin if verificar que objetos no esten vacios
                                                    else
                                                    {
                                                        this.miVistaAplicacion.output("No hay fincas registradas aun. Por favor dirigase a registrarlas.");
                                                    }//fin else verificar objetos si estan vacios
                                                }//fin if verificar
                                                else
                                                {
                                                    this.miVistaAplicacion.output("Ya existe un dueno registrado con esa identificacion. Por favor digite otra.");
                                                }//fin else verificar
                                            }//fin if contador dueno
                                            else
                                            {
                                                this.miVistaAplicacion.output("Ya registro el limite de duenos equivalente a 10.");
                                                this.menu();
                                            }//fin else contador animal
                                            break;
                                        case 2:
                                            this.menu();
                                            break;
                                        default:
                                            //mensaje opcion incorrecta
                                            this.miVistaAplicacion.output("Opcion fuera del rango.");
                                            break;
                                    }//fin switch

                                } while (this.intOpcionDueno != 2);//fin while
                            }//fin try
                            catch (Exception ex)
                            {
                                this.miVistaAplicacion.output("Ha introducido un valor invalido.");
                            }//fin catch
                            break;

                        case 3://Registrar Empleado.//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            try
                            {
                                //bucle para preguntar si desea registrar empleados o desea salir al menu principal
                                do
                                {
                                    this.intOpcionEmpleado = this.miVistaAplicacion.inputInt("1. Desea continuar registrando empleados." +
                                        "\n2. Salir al menu principal.");

                                    switch (this.intOpcionEmpleado)
                                    {
                                        case 1:
                                            //contador para tope de 10 objetos empleado
                                            if (this.intContadorEmpleado < 10)
                                            {
                                                //verificar si existe o no la identificacion del empleado
                                                if (this.miControladorEmpleado.VerificarIdentificacion(this.intIdentificacionEmpleado = this.miVistaAplicacion.inputInt("Digite la identificacion del empleado:")) == -1)
                                                {
                                                    this.miVistaAplicacion.output(
                                                    this.miControladorEmpleado.RegistrarEmpleado(this.intIndiceEmpleado, this.miObjetoEmpleado =
                                                    new ObjetoEmpleado(
                                                        this.intIdentificacionEmpleado,
                                                        this.miVistaAplicacion.input("Digite el nombre del empleado:"),
                                                        this.miVistaAplicacion.input("Digite el primer apellido del empleado:"),
                                                        this.miVistaAplicacion.input("Digite el segundo apellido del empleado:"),
                                                        this.miVistaAplicacion.inputDouble("Digite el salario del empleado:"))));
                                                    this.intIndiceEmpleado++;
                                                    this.intContadorEmpleado++;
                                                }//fin if verificar 
                                                else
                                                {
                                                    this.miVistaAplicacion.output("El numero de identificacion del empleado ya existe. Por favor digite otro.");
                                                }//fin else verificar 
                                            }//fin if
                                            else
                                            {
                                                this.miVistaAplicacion.output("Ya registro el limite de empleados equivalente a 10.");
                                                this.menu();
                                            }
                                            break;
                                        case 2:
                                            this.menu();
                                            break;
                                        default:
                                            //mensaje opcion incorrecta
                                            this.miVistaAplicacion.output("Opcion fuera del rango.");
                                            break;
                                    }//fin switch

                                } while (this.intOpcionEmpleado != 2);//fin while
                            }//fin try
                            catch (Exception ex)
                            {
                                this.miVistaAplicacion.output("Ha introducido un valor invalido.");
                            }//fin catch
                            break;

                        case 4://Registrar Raza de Animales./////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            try
                            {
                                //bucle para preguntar si desea registrar razas o desea salir al menu principal
                                do
                                {
                                    this.intOpcionRaza = this.miVistaAplicacion.inputInt("1. Desea continuar registrando razas." +
                                        "\n2. Salir al menu principal.");

                                    switch (this.intOpcionRaza)
                                    {
                                        case 1:
                                            //contador para tope de 10 objetos finca
                                            if (this.intContadorRaza < 10)
                                            {
                                                //verificar si existe una raza registrada o no con el codigo
                                                if (this.miControladorRaza.VerificarCodigo(this.intCodigoRaza = this.miVistaAplicacion.inputInt("Digite el codigo de raza:")) == -1)
                                                {
                                                    this.miVistaAplicacion.output(
                                                    this.miControladorRaza.RegistrarRaza(this.intIndiceRaza2, this.miObjetoRaza =
                                                    new ObjetoRaza(
                                                        this.intCodigoRaza,
                                                        this.miVistaAplicacion.input("Digite la descripcion de la raza:"))));
                                                    this.intIndiceRaza2++;
                                                    this.intContadorRaza++;
                                                }//fin if verificar
                                                else
                                                {
                                                    this.miVistaAplicacion.output("Ya existe una raza registrada con ese codigo. Por favor digite otro.");
                                                }//fin else verificar
                                            }//fin if
                                            else
                                            {
                                                this.miVistaAplicacion.output("Ya registro el limite de razas equivalente a 10.");
                                                this.menu();
                                            }
                                            break;
                                        case 2:
                                            this.menu();
                                            break;
                                        default:
                                            //mensaje opcion incorrecta
                                            this.miVistaAplicacion.output("Opcion fuera del rango.");
                                            break;
                                    }//fin switch

                                } while (this.intOpcionRaza != 2);//fin while
                            }//fin try
                            catch (Exception ex)
                            {
                                this.miVistaAplicacion.output("Ha introducido un valor invalido.");
                            }//fin catch
                            break;

                        case 5://Registrar Animales./////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            try
                            {
                                //bucle para preguntar si desea registrar animales o salir al menu principal
                                do
                                {
                                    this.intOpcionAnimal = this.miVistaAplicacion.inputInt("1. Desea continuar registrando animales." +
                                        "\n2. Salir al menu principal.");

                                    switch (this.intOpcionAnimal)
                                    {
                                        case 1:
                                            //contador para tope de 10 objetos finca
                                            if (this.intContadorAnimal < 10)
                                            {
                                                //verificar si existe o no un animal registrado con una identificacion digitada por el usuario
                                                if (this.miControladorAnimal.VerificarIdentificacion(this.intIdentificacionAnimal = this.miVistaAplicacion.inputInt("Digite la identificacion del animal:")) == -1)
                                                {
                                                    //verificar si existen fincas y razas, si no hay alguno de los dos no se puede registrar animales
                                                    if (this.miControladorFinca.GetArrayObjetosFinca().GetValue(0) != null && this.miControladorRaza.GetArrayObjetosRaza().GetValue(0) != null)
                                                    {
                                                        //verificar si usuario elije un indice correcto de 1 a 10 arreglo de fincas//verificar si usuario elije un indice correcto de 1 a 10 arreglo de razas//verificar si usuario elije un numero u opcion correcto de 1 o 2
                                                        if (
                                                        this.VerificarIndice(this.intIndiceFinca = this.miVistaAplicacion.inputInt(this.miControladorFinca.MostrarFinca() + "\nDigite el indice de la finca del animal:")) == true
                                                        &&
                                                        this.VerificarIndice(this.intIndiceRaza = this.miVistaAplicacion.inputInt(this.miControladorRaza.MostrarRaza() + "\nDigite el indice de la raza del animal")) == true
                                                        &&
                                                        this.VerificarOpcion(this.intOpcionSexo = this.miVistaAplicacion.inputInt("Digite el sexo del animal:\n1. Macho.\n2. Hembra.")) == true)
                                                        {
                                                            //llenar el array y el objeto
                                                            this.miVistaAplicacion.output(
                                                                this.miControladorAnimal.RegistrarAnimal(this.intIndiceAnimal, this.miObjetoAnimal =
                                                                new ObjetoAnimal(
                                                                    this.intIdentificacionAnimal,
                                                                    this.miControladorAnimal.GetSexoAnimal(this.intOpcionSexo),
                                                                    this.miVistaAplicacion.input("Digite el nombre de la madre del animal:"),
                                                                    this.miVistaAplicacion.input("Digite el nombre del padre del animal:"),
                                                                    this.miVistaAplicacion.input("Digite el nombre del animal:"),
                                                                    this.miVistaAplicacion.input("Digite la fecha de nacimiento del animal(dia,mes,ano):"),
                                                                    this.miControladorFinca.GetObjetoFinca(this.intIndiceFinca),
                                                                    this.miControladorRaza.GetObjetoRaza(this.intIndiceRaza))));
                                                            this.intIndiceAnimal++;
                                                            this.intContadorAnimal++;
                                                        }//fin if verificar sexo y objetos dentro de rango
                                                        else
                                                        {
                                                            this.miVistaAplicacion.output("Ha digitado un indice fuera de rango o una opcion que no es ni 1 ni 2.");
                                                        }//fin else verificar sexo y objetos dentro de rango
                                                    }//fin if verificar que objetos no esten vacios
                                                    else
                                                    {
                                                        this.miVistaAplicacion.output("No hay fincas o razas registradas aun. Por favor dirigase a registrarlos");
                                                    }//fin else verificar objetos si estan vacios
                                                }//fin if verificar
                                                else
                                                {
                                                    this.miVistaAplicacion.output("Ya existe un animal registrado con esa identificacion. Por favor digite otra.");
                                                }//fin else verificar
                                            }//fin if contador animal
                                            else
                                            {
                                                this.miVistaAplicacion.output("Ya registro el limite de animales equivalente a 10.");
                                                this.menu();
                                            }//fin else contador animal
                                            break;
                                        case 2:
                                            this.menu();
                                            break;
                                        default:
                                            //mensaje opcion incorrecta
                                            this.miVistaAplicacion.output("Opcion fuera del rango.");
                                            break;
                                    }//fin switch

                                } while (this.intOpcionAnimal != 2);//fin while
                            }//fin try
                            catch (Exception ex)
                            {
                                this.miVistaAplicacion.output("Ha introducido un valor invalido.");
                            }//fin catch
                            break;

                        case 6://Mostrar los Registros.//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            //mostrar informacion de los registros
                            this.miVistaAplicacion.output("*Lista de Registros*\n" +
                                "*****FINCAS*****" + this.miControladorFinca.MostrarFinca() + "\n" +
                                "*****DUENOS*****" + this.miControladorDueno.MostrarDueno() + "\n" +
                                "*****EMPLEADOS*****" + this.miControladorEmpleado.MostrarEmpleado() + "\n" +
                                "*****RAZAS*****" + this.miControladorRaza.MostrarRaza() + "\n" +
                                "*****ANIMALES*****" + this.miControladorAnimal.MostrarAnimal() + "\n");
                            break;

                        case 7://Salir de sistema.///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            //preguntar si desea salir o no del sistema
                            this.intSalir = this.miVistaAplicacion.inputInt("¿Está realmente seguro de que desea salir?" +
                                "\nSi = Digite 1 \nNo = Digite 2");
                            if (this.intSalir == 1)
                            {
                                this.miVistaAplicacion.output("Gracias por utilizar nuestro programa");
                                System.Environment.Exit(0);
                            }
                            else
                            {
                                //volver al menu principal con datos cargados
                                this.menu();
                            }
                            break;

                        default:
                            //mensaje opcion incorrecta
                            this.miVistaAplicacion.output("Opcion fuera del rango.");
                            break;
                    }//fin switch
                }//fin try
                catch (Exception ex)
                {
                    this.miVistaAplicacion.output("Ha introducido un valor invalido.");
                }//fin catch

            } while (this.intOpcion != 7);//fin do while
        }//fin menu
        /*
        * VerificarIndice: este metodo o funcion se encarga de verificar si la opcion elegida por el usuario esta dentro 
        * del rango 1 a 10
        */
        public bool VerificarIndice(int indice)
        {
            if (indice >= 0 && indice < 10)
            {
                return true;
            }//fin if
            else
            {
                return false;
            }//fin else
        }// fin VerificarIndice
        /*
        * VerificarOpcion: este metodo o funcion se encarga de verificar si la opcion elegida por el usuario es 1 o 2
        */
        public bool VerificarOpcion(int opcion)
        {
            if (opcion >= 1 && opcion < 3)
            {
                return true;
            }//fin if
            else
            {
                return false;
            }//fin else
        }// fin VerificarOpcion
    }//fin clase Menu
}
