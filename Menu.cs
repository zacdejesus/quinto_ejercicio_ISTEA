using System;
using System.Collections.Generic;
using System.Text;

namespace quinto_ejercicio
{
    class Menu
    {
        
        public static void MenuPrincipal()
        {   
            //se inizializan variables
            string[,] matrizEmpleados = new string[11,5];
            matrizEmpleados[0,0] = "nombre";
            matrizEmpleados[1,0] = "apellido";
            matrizEmpleados[2,0] = "dire";
            matrizEmpleados[3,0] = "edad";
            matrizEmpleados[4,0] = "sexp";
            matrizEmpleados[5,0] = "puesto";
            matrizEmpleados[6,0] = "antiguedad";
            matrizEmpleados[7,0] = "salario";
            matrizEmpleados[8,0] = "vacaciones";
            matrizEmpleados[9,0] = "dias off";
            matrizEmpleados[10,0] = "estado";

            for (int c = 1; c < 5; c++) 
            {
                 Console.WriteLine($"Datos del {c} empleado");

                Console.WriteLine("Ingrese Nombre");
                matrizEmpleados[0,c] = Validaciones.ValidarCadena("valor");

                Console.WriteLine($"Ingrese Apellido");
                matrizEmpleados[1,c] = Validaciones.ValidarCadena("nombre");

                Console.WriteLine($"Ingrese Direccion");
                matrizEmpleados[2,c] = Validaciones.ValidarCadena("nombre");

                Console.WriteLine($"Ingrese Edad");
                int edad = Validaciones.ValidadEntero(100,0);
                string edadStr = edad.ToString();
                matrizEmpleados[3,c] = edadStr;

                Console.WriteLine($"Ingrese sexo");
                matrizEmpleados[4,c] = Validaciones.ValidarCadena("nombre");

                Console.WriteLine($"Ingrese puesto");
                matrizEmpleados[5,c] = Validaciones.ValidarCadena("nombre");

                //se hace la logica de calcular las vacaciones

                Console.WriteLine($"Ingrese antiguedad");

                int aux = Validaciones.ValidadEntero(100,0);

                string antiguedad = aux.ToString();

                int vacaciones = Validaciones.ValidadVacaciones(aux);

                string vacacionStr = vacaciones.ToString();

                matrizEmpleados[6,c] = antiguedad;

                //termina logica de calcular las vacaciones

                Console.WriteLine($"Ingrese salario");
                int salario = Validaciones.ValidadEntero(10000000,0);
                string salarioStr = salario.ToString();
                matrizEmpleados[7,c] = salarioStr;

                matrizEmpleados[8,c] = vacacionStr;

                matrizEmpleados[9,c] = vacacionStr;

                matrizEmpleados[10,c] = "trabajando";
            }
            Console.WriteLine("");
            for (int f = 0; f < matrizEmpleados.GetLength(0); f++)
            {

               for (int c = 0; c < matrizEmpleados.GetLength(1); c++)
               {
                   if (!string.IsNullOrEmpty(matrizEmpleados[f, c]))
                   {
                       if (c == 0)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 1)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 2)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                         else if  (c == 3)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 4)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 5)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 6)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 7)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 8)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 9)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                                                      else if  (c == 10)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                       else
                       {
                           Console.Write($"{matrizEmpleados[f, c]  ,-3}\n");
                       }
                   }

               }
               Console.WriteLine("");  // salto de linea para mostrar la siguiente fila abajo 
            }

            Console.WriteLine("INGRESE EL NUMERO DE EMPLEADO QUE QUIERE QUE SALGA DE VACACIONES");
            Console.WriteLine($"1 {matrizEmpleados[0,1]}");
            Console.WriteLine($"2 {matrizEmpleados[0,2]}");
            Console.WriteLine($"3 {matrizEmpleados[0,3]}");
            Console.WriteLine($"4 {matrizEmpleados[0,4]}");
            
            int opcion = Validaciones.ValidadEntero(5,0);

            matrizEmpleados[10,opcion] = "de vaciones";
            matrizEmpleados[9,opcion] = "0";

                        for (int f = 0; f < matrizEmpleados.GetLength(0); f++)
            {

               for (int c = 0; c < matrizEmpleados.GetLength(1); c++)
               {
                   if (!string.IsNullOrEmpty(matrizEmpleados[f, c]))
                   {
                       if (c == 0)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 1)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 2)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                         else if  (c == 3)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 4)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                        else if  (c == 5)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 6)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 7)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 8)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                               else if  (c == 9)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                                                                      else if  (c == 10)
                       {
                           Console.Write("          {0,-10}", matrizEmpleados[f, c]);
                       }
                       else
                       {
                           Console.Write($"{matrizEmpleados[f, c]  ,-3}\n");
                       }
                   }

               }
               Console.WriteLine("");  // salto de linea para mostrar la siguiente fila abajo 
            }
        }
    }
}
