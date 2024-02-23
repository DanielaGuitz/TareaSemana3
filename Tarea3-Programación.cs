using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        bool datosValidos = false;
        while(!datosValidos)
        {
            try
            {
                //Calcular El Mayor de Tres Numeros
                Console.WriteLine("------------------------------------------------EL MAYOR DE TRES NUMEROS-----------------------------------------");
                Console.WriteLine("Ingrese El Primer Número");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa El Segundo Numero:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese El Tercer Numero:");
                int number3 = Convert.ToInt32(Console.ReadLine());
                int mayor;

                //si los datos estan correctos podemos salir del bucle
                datosValidos = true;
                

                //Calculos del Dato mayor
                if (number1 >= number2 && number1 >= number3)
                {
                    mayor = number1;
                }
                else if (number2 >= number1 && number2 >= number3)
                {
                    mayor = number2;
                }
                else
                {
                    mayor = number3;
                }
                Console.WriteLine("El número mayor de los datos ingresador es:" + mayor);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dato ingresado No válido");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR:" + ex.Message);
            }
        }

        //Validar Edad Para Ingresar Al Club
        Console.WriteLine("-----------------------------------------------------------INGRESO AL CLUB------------------------------------------------------------------");
        try
        {
            Console.WriteLine("¿Qué Edad Tienes?:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("¡BIENVENIDO AL CLUB!.");
            }
            else
            {
                Console.WriteLine("Lo siento, eres menor de edad. No puedes ingresar.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un número válido para la edad.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        // Calcular El precio Final de un Producto
        Console.WriteLine("---------------------------------------------------PRECIO FINAL DEL PRODUCTO---------------------------------------------------------------");
        try
        {
            Console.WriteLine("Ingrese El Monto Del Producto Q:");
            double price = double.Parse(Console.ReadLine());
           
                if (price > 100)
            {
                double discount = 0.10;
                   double  total = price - (price * discount);
                Console.WriteLine("El Precio Total, Con el Descuento es de: Q" + total);
            }
            else
            {
                Console.WriteLine("El Precio Total Es De: Q" + price);
            }  
        }
        catch (FormatException)
        {
            Console.WriteLine("Paraece que ocurrió un Problema");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error:" + ex.Message);
        }

        // Validar Usuario y Contraseña
        Console.WriteLine("---------------------------------------------------------- VALIDACIÓN DE USUARIO Y CONTRASEÑA ------------------------------------------------");
        
        try
        {
            string uservalid = "usuario";
            string passwordvalid = "contraseña";

            // Solicitar al Usuario Datos
            Console.WriteLine("Ingrese Su Usuario:");
            string user = Console.ReadLine();

            Console.WriteLine("Ingrese Su Contraseña:");
            string password = Console.ReadLine();

            if (user == uservalid && password == passwordvalid)
            {
                Console.WriteLine("INGRESO DE DATOS VÁLIDOS");
            }
            else
            {
                throw new Exception("Usuario o Contraseña Incorrectas");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }

        // Numero Par o Impar 
        Console.WriteLine("----------------------------------------------------------------------¿NÚMERO PAR O IMPAR?------------------------------------------------------");
        try
        {
            Console.WriteLine("Porfavor, Ingrese un número");
            int number = Convert.ToInt32(Console.ReadLine());

            if ( number % 2 == 0)
            {
                Console.WriteLine("El Digito Ingresado Es Par");
            }
            else
            {
                Console.WriteLine("El Digito Ingresad es Impar");
            }

        } catch (FormatException)
        {
            Console.WriteLine("Ocurrió un Problema");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR:" + ex.Message);
        }

        //Mensaje de Aprobacipn o Rechazo al Prestamo
        Console.WriteLine("--------------------------------------------------------------------SOLICITUD DE PRÉSTAMO---------------------------------------------------------");

        try
        {
            Console.WriteLine("Monto Del Prestamo a Solicitar:");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Su Edad:");
            int age = int.Parse(Console.ReadLine());

            if (amount < 5000 && age > 60) ;
            {
                Console.WriteLine("Su Prestamo ah sido Aprobado");
            }
            

        }catch (FormatException)
        {
            Console.WriteLine("Lo sentimos, Su Préstamo ah Sido Rechazado");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR:" + ex.Message);
        }

        // Calclucar El Area de una Figura Geometrica 
        Console.WriteLine("--------------------------------------------------------------AREA DE UNA FIGURA GEOMETRICA---------------------------------------------------------");

        try
        {
            Console.WriteLine("Tipo De Figura Geometrica:");
            Console.WriteLine("1. Tiángulo");
            Console.WriteLine("2.Cuadrado");
            Console.WriteLine("3.Círculo");
            string typefigure = Console.ReadLine().ToLower();

            double area = 0.0;
            switch (typefigure)
            {
                case "1":
                    Console.WriteLine("Ingrese la base del Triángulo:");
                    double basetriangle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del Triángulo");
                    double height = Convert.ToDouble(Console.ReadLine());

                    //Calculos
                    area = 0.5 * basetriangle * height;
                    break;

                case "2":
                    Console.WriteLine("Ingrese el lado del Cuadrado:");
                    double squareside = Convert.ToDouble(Console.ReadLine());

                    //Calculos
                    area = Math.Pow(squareside, 2);
                    break;

                case "3":
                    Console.WriteLine("¿Cuál es el Radio del Círculo?");
                    double circleradius = Convert.ToDouble(Console.ReadLine());

                    //Calculos
                    area = Math.PI * Math.Pow(circleradius, 2);
                    break;

                default: throw new ArgumentException("Figura No Válida");
            }
            Console.WriteLine($"El area de la {typefigure} es: {area}");
        }catch (Exception ex)
        {
            Console.WriteLine("$ ERROR:\" + {ex.Menssage}");
        }
        // Convertir numero de letra a numero
        Console.WriteLine("-----------------------------------------------------------CONVERSIÓN DE UN NUMERO LETRA A UN NUMERO DIGITO----------------------------------------");
        try
        {
            Console.WriteLine("Ingresa EN LETRAS un número del 1 al 5:");
            string numberinletter = Console.ReadLine().ToLower();

            int numberindigit;

            switch (numberinletter)
            {
                case "uno":
                    numberindigit = 1;
                    break;
                case "dos":
                    numberindigit = 2;
                    break;
                case "tres":
                    numberindigit = 3;
                    break;
                case "cuatro":
                    numberindigit = 4;
                    break;
                case "cinco":
                    numberindigit = 5;
                    break;
                default:
                    throw new ArgumentException("UPS! número en letra no válido");
            }
            Console.WriteLine($"El número ingresado en dígito es: {numberindigit}");


        } catch (Exception ex)
        {
            Console.WriteLine("**ERROR**" + ex.Message);
        }
        //Mostrar Dia de la Semana a Partir de Un número
        Console.WriteLine("--------------------------------------------------------DIA DE LA SEMANA A PARTIR DE UN NÚMERO----------------------------------------------------");
        try
        {
            Console.WriteLine("Ingrese un número del 1 al 7:");
            int number = Convert.ToInt32(Console.ReadLine());

            string numberweek;
            switch (number)
            {
                case 1:
                    numberweek = "Lunes";
                    break;
                case 2:
                    numberweek = "Martes";
                    break;
                case 3:
                    numberweek = "Miércoles";
                    break;
                case 4:
                    numberweek = "Jueves";
                    break;
                case 5:
                    numberweek = "Viernes";
                    break;
                case 6:
                    numberweek = "Sábado";
                    break;
                case 7:
                    numberweek = "Domingo";
                    break;
                default: throw new ArgumentException("Número de día No válido");
            }
            {
                Console.WriteLine($"El día que corresponde al número {number} es: {numberweek}");
            }
        } catch (Exception ex)
        {
            Console.WriteLine($"**ERRO**:{ ex.Message}");
        }

        //Calcular El Importe a Pagar por Un Servicio
        Console.WriteLine("---------------------------------------------------------------IMPORTE A PAGAR---------------------------------------------------------------------");

        try
        {
            Console.WriteLine("¿Qué tipo de servicio desea realizar?");
            Console.WriteLine("1.Lavado de Auto");
            Console.WriteLine("2.Cambio de Aceite");
            Console.WriteLine("3.Revisión Mecánica");
            int service = Convert.ToInt32(Console.ReadLine());

            double pay = 0.0;
            switch (service)
            {
                case 1:
                    pay = 50.0;
                    break;
                case 2:
                    pay = 30.0;
                    break;
                case 3:
                    pay = 150.0;
                    break;
                default: throw new ArgumentException("Opción No Válida");   
            }
            Console.WriteLine($"El pago total por el servicio requerido es de: ${pay}");
        } catch (Exception ex)
        {
            Console.WriteLine ($"**ERROR** { ex.Message}");
        }

        // Mensaje de bienvenida en diferentes idiomas
        Console.WriteLine("-------------Seleccione el número del Idioma de su preferencia-----------");
        Console.WriteLine("1.Español");
        Console.WriteLine("2.Inglés");
        Console.WriteLine("3.Francés");
        int lenguage = Convert.ToInt32(Console.ReadLine());
        try
        {
            string option;
            switch (lenguage)
            {
                case 1:
                    option = "¡Bienvenido! Estoy aquí para ayudarte";
                    break;
                case 2:
                    option = "Welcome! I am here to help you.";
                    break;
                case 3:
                    option = "Accueillir! Je suis ici pour vous aider.";
                    break;
                default: throw new ArgumentException("Selección de idioma no válido");
            }
            {
                Console.WriteLine($"{option}");
            }
        
        } catch (Exception ex)
        {
            Console.WriteLine($"**ERROR**: {ex.Message}");
        }

        //Evaluar la calificacion de un examen
        Console.WriteLine("----------------------------------------------------------------CALIFICACIÓN DE EXAMEN---------------------------------------------------------------");
        Console.WriteLine("Ingrese la calificación de su examen:");

        if (int.TryParse(Console.ReadLine (), out int qualification))
        {
            switch (qualification)
            {
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("WOW! Tienes una calificación Sobresaliente");
                    break;
                case int n when (n >= 80 && n <= 89):
                    Console.WriteLine("Felicidades! Tu calificación es Notable");
                    break;
                case int n when (n >= 70 && n <= 79):
                    Console.WriteLine("Muy Bien! Hiciste un buen trabajo");
                    break;
                case int n when (n >= 61 && n <= 69):
                    Console.WriteLine("Bien! Aprobaste el examen");
                    break;
                case int n when (n >= 0 && n <= 60):
                    Console.WriteLine("No aprobaste el examen, Estudia más!");
                    break;

                default:
                    Console.WriteLine("Calificación No válida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("**Error**, Vuelve a Intentarlo");
        }

        }
}
 

