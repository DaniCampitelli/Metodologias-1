using System;
using System.Collections.Generic;
using Metodologias_1.Practica_2;


namespace Metodologias_1.Practica_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empecemos!");


            void llenar(IColeccionable cole)
            {
                Random numeroRandom = new Random();
                Numero relleno = new Numero(numeroRandom.Next(99));
                while (cole.agregar(relleno) == true)
                {
                    Console.WriteLine("Agregando  elemento " + relleno.getValor());
                    relleno = new Numero(numeroRandom.Next(99));

                }
                Console.WriteLine("elemento lleno");
            }

            void informar(IColeccionable cole)
            {
                Console.WriteLine("La coleccion tiene " + cole.cuantos() + " elementos");



                Console.WriteLine("El minimo elemento es " + ((Numero)cole.minimo()).getValor());
                Console.WriteLine("El maximo elemento es " + ((Numero)cole.maximo()).getValor());

                Console.WriteLine("Ingrese un valor a buscar ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Numero valorBuscado = new Numero(n1);
                Console.WriteLine("valor ingresado " + valorBuscado.getValor());
                if (cole.contiene(valorBuscado) == true)
                {
                    Console.WriteLine("El elemento leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leído NO está en la colección");
                }
            }

            void llenarPersonas(IColeccionable cole)
            {
                List<String> listaDeNombres = new List<string>()
                {
                 "Juan Percha",
                 "Juanita Viale",
                 "Esteban Quito",
                 "Abel D Retido",
                 "Agustin Vertebrado",
                 "Alba Babosa",
                 "Aldo Lorido",
                 "Alberto Matazo",
                 "Alen Guado",
                 "Alex Plosivo",
                 "Alfonsin Sesos",
                 "Ines Tornudo",
                 "Irma Tematica",
                 "Isaac A Mocos",
                 "Ivan Pirito",
                 "Jacobo Quete",
                 "Jaime Talero",
                 "Jazmin Secto",
                 "Jaime Jillas",
                 "Joel Electrico",
                 "Jhonny Latrago",
                 "Joaquin Odoro",
                 "Jessi Nojos",
                 "Norma Cita",
                 "Olaf E. Itado",
                 "Nico Tinoso",
                 "Omar Tillado",
                 "Omar Ciano",
                 "Omar Garita",
                 "Oscar Mado",
                 "Tomas Todonte",
                 "Vicente Rorifico",
                 "Victor Ticolis"

                };

                Random puntero = new Random();
                Random dniRandom = new Random();
                int dniR = dniRandom.Next(111111, 99999999);

                Persona persona = new Persona(listaDeNombres[puntero.Next(listaDeNombres.Count - 1)], dniR);

                while (cole.agregar(persona) == true)

                {
                    Console.WriteLine("Agregando  elemento " + persona.getNombre() + " con DNI " + persona.getDni());
                    dniR = dniRandom.Next(111111, 99999999);
                    persona = new Persona(listaDeNombres[puntero.Next(listaDeNombres.Count - 1)], dniR);


                }

                Console.WriteLine("elemento lleno de personas");
            }

            void InformarPersona(IColeccionable cole)
            {
                Console.WriteLine("La coleccion tiene " + cole.cuantos() + " elementos");
                Console.WriteLine("El minimo es " + ((Persona)cole.minimo()).getNombre());
                Console.WriteLine("El maximo es " + ((Persona)cole.maximo()).getNombre());

                Console.WriteLine("Ingrese un valor a buscar ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Persona dniBuscado = new Persona("nombre X ", n1);
                Console.WriteLine("valor ingresado " + dniBuscado.getDni());
                if (cole.contiene(dniBuscado) == true)
                {
                    Console.WriteLine("El elemento leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leído NO está en la colección");
                }


            }

            void llenarAlumnos(IColeccionable cole)
            {
                List<String> listaDeNombres = new List<string>()
                {
                 "Juan Percha",
                 "Juanita Viale",
                 "Esteban Quito",
                 "Abel D Retido",
                 "Agustin Vertebrado",
                 "Alba Babosa",
                 "Aldo Lorido",
                 "Alberto Matazo",
                 "Alen Guado",
                 "Alex Plosivo",
                 "Alfonsin Sesos",
                 "Ines Tornudo",
                 "Irma Tematica",
                 "Isaac A Mocos",
                 "Jacobo Quete",
                 "Jaime Talero",
                 "Jazmin Secto",
                 "Jaime Jillas",
                 "Joel Electrico",
                 "Jhonny Latrago",
                 "Joaquin Odoro",
                 "Jessi Nojos",
                 "Norma Cita",
                 "Olaf E. Itado",
                 "Nico Tinoso",
                 "Omar Tillado",
                 "Omar Ciano",
                 "Omar Garita",
                 "Oscar Mado",
                 "Tomas Todonte",
                 "Vicente Rorifico",
                 "Victor Ticolis"

                };

                Random puntero = new Random();
                Random dniRandom = new Random();
                Random legajoRandom = new Random();
                Random promedioRandom = new Random();
                int dniR = dniRandom.Next(111111, 99999999);
                int legajoR = legajoRandom.Next(1111, 99999);
                int promedioR = promedioRandom.Next(11, 99);
                int punteroR = puntero.Next(listaDeNombres.Count - 1);
                IEstrategiaDeComparacion est = new PorDni();
            


                Alumno alumno = new Alumno(listaDeNombres[puntero.Next(listaDeNombres.Count - 1)], dniR, legajoR, promedioR);
                Console.WriteLine("Como desea comparar? 1-Por Legajo  2-Por Promedio 3-Por Dni ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        est = new PorLegajo();
                        alumno.cambiarEstrategia(est);
                        Console.WriteLine("Vamos a comparar por legajo ");
                        break;
                    case 2:
                        est = new PorPromedio();
                        alumno.cambiarEstrategia(est);
                        Console.WriteLine("Vamos a comparar por promedio ");
                        break;
                    case 3:
                        Console.WriteLine("Vamos a comparar por Dni ");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta,vamos a comparar por Dni ");
                        break;
                }

                while (cole.agregar(alumno) == true)

                {
                    Console.WriteLine("Agregando  elemento " + alumno.getNombre() + " con DNI " + alumno.getDni() + " ,legajo: " + alumno.getLegajo() + " y un promedio de: " + alumno.getPromedio());
                    dniR = dniRandom.Next(111111, 99999999);
                    legajoR = legajoRandom.Next(1111, 99999);
                    promedioR = promedioRandom.Next(11, 99);
                    punteroR = puntero.Next(listaDeNombres.Count - 1);
                    alumno = new Alumno(listaDeNombres[punteroR], dniR, legajoR, promedioR);
                    alumno.cambiarEstrategia(est);


                }

                Console.WriteLine("elemento lleno de Alumnos");
            }

            void InformarAlumnos(IColeccionable cole)
            {
                Console.WriteLine("La coleccion tiene " + cole.cuantos() + " elementos");
                Console.WriteLine("El valor minimo es " + ((Alumno)cole.minimo()).getNombre());
                Console.WriteLine("El valor maximo es " + ((Alumno)cole.maximo()).getNombre());

                Console.WriteLine("Ingrese el valor a buscar ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Alumno Buscado = new Alumno("x", n1, n1, n1);//
                Console.WriteLine("Que desea buscar? 1- Legajo  2- Promedio 3- Dni ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Buscado.cambiarEstrategia(new PorLegajo());
                        Console.WriteLine("Vamos a buscar el legajo  ");
                        break;
                    case 2:
          
                        Buscado.cambiarEstrategia(new PorPromedio());
                        Console.WriteLine("Vamos a buscar el promedio ");
                        break;
                    case 3:
                        Console.WriteLine("Vamos a buscar el Dni ");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta,vamos a buscar el Dni ");
                        break;
                }

                if (cole.contiene(Buscado) == true)
                {
                    Console.WriteLine("El valor buscado está en la colección");
                }
                else
                {
                    Console.WriteLine("El valor buscado NO está en la colección");
                }
            }


            void imprimirElementos(Iterable a) {
                Iterador b = a.CrearIterador();
                while (!b.Fin()) {
                    Console.WriteLine(b.Actual());// Como imprimir 
                    b.Siguiente();
                }


            }










            /*

           //#################### Ej 7 ################################


           pila = new Pila()
           cola = new Cola()
           llenar(pila)
           llenar(cola)
           informar(pila)
           informar(cola)

           ####################### EJ 9 ###############################

            // IColeccionable pila = new Pila(10);
           //IColeccionable cola = new Cola(10);
          // llenar(pila);
          // llenar(cola);
           //informar(pila);
          // informar(cola);




           ######################## EJ 13###############################

           pila = new Pila()
           cola = new Cola()
           multiple = new ColeccionMultiple(pila, cola)
           llenarPersonas(pila)
           llenarPersonas(cola)
           informar(multiple)

           */

            // ##################### EJ 17################################

            /* IColeccionable pilaPersonas = new Pila(20);
              IColeccionable colaPersonas = new Cola(20);
              llenarAlumnos(pilaPersonas);
              llenarAlumnos(colaPersonas);

              ColeccionMultiple c = new ColeccionMultiple(pilaPersonas, colaPersonas);
              InformarAlumnos(c);
          */
            //####################### EJ 8 P2 ############################
            
            
           Pila pila = new Pila(20);
            Cola cola = new Cola(20);
            Conjunto conjunto = new Conjunto(20);
            Diccionario diccionario = new Diccionario(20);
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            llenarAlumnos(conjunto);
            llenarAlumnos(diccionario);
            imprimirElementos(pila);
            imprimirElementos(cola);
            imprimirElementos(conjunto);
            imprimirElementos(diccionario);






                // test de contiene "positivo"
                //Console.WriteLine("test de ALE Contiene n1 ? " + test.contiene(n1));
                //test de cuantos
                //Console.WriteLine("test tiene " + test.cuantos() + " elementos");
                //test de contiene "negativo"
                //Console.WriteLine("test Contiene n3 ? " + test.contiene(n3));
                // test de mayor numero
                //Console.WriteLine("el mayor es numero es  " + ((Numero)test.maximo()).getValor());

            //test de sacar
            //  while (test.cuantos() > 0)
            //  {
            //      Console.WriteLine("Elemento  " + ((Numero)test.sacar()).getValor());
            //  }




            //informar(test);

            // llenar(colaP);

            //informar(test2);



            /*Console.WriteLine(c.contiene(n1));

            Console.WriteLine(c.cuantos());

            Console.WriteLine(((Numero)c.maximo()).getValor());
            */

            //informar(pilaP);
            //informar(colaP);




            //informar(test);
            //Console.WriteLine(test.cuantos());

            //test de sacar
            //while (test.cuantos() > 0)
            //{
            //Console.WriteLine("Elemento  " + ((Numero)test.sacar()).getValor());
            //}


            //llenar(test2);
            //Console.WriteLine(test2.cuantos());
            //test de sacar
            //while (test2.cuantos() > 0)
            //{
            //    Console.WriteLine("Sacando Elemento  " + ((Numero)test2.sacar()).getValor());
            //}




        } 
        
        
    }
}

