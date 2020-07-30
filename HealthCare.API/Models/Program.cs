using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //bool validado = false;
            //List<Ejemplo> _ejemplos = new List<Ejemplo>();

            //Ejemplo ejemploUno = new Ejemplo()
            //{
            //    Numero = 1,
            //    Letra = "c",
            //    Validacion= "Si"
            //};

            //Ejemplo ejemploDos = new Ejemplo()
            //{
            //    Numero = 2,
            //    Letra = "b",
            //    Validacion = "No"
            //};

            //Ejemplo ejemploTres = new Ejemplo()
            //{
            //    Numero = 1,
            //    Letra = "a",
            //    Validacion = ""
            //};

            //void insertaEjemplos(Ejemplo ejemplo)
            //{
            //    _ejemplos.Add(ejemplo);
            //}

            //insertaEjemplos(ejemploUno);
            //insertaEjemplos(ejemploDos);
            //insertaEjemplos(ejemploTres);


            //foreach (Ejemplo ejemplo in _ejemplos)
            //{
            //    Console.WriteLine(ejemplo.Letra.ToString(), ejemplo.Numero);
            //}

            ////Console.WriteLine("Comparando los objetos diferentes");
            //comparaEjemplos(ejemploUno, ejemploDos);

            ////Console.WriteLine("Comparando los objetos iguales");
            ////comparaEjemplos(ejemploUno,ejemploTres);

            //void comparaEjemplos(Ejemplo ejemploA, Ejemplo ejemploB)
            //{
            //    string diferencia="";

            //    if (ejemploA.Numero == ejemploB.Numero && ejemploA.Letra == ejemploB.Letra)
            //    {
            //        diferencia="todo_igual";
            //    }
            //    if (ejemploA.Numero != ejemploB.Numero && ejemploA.Letra == ejemploB.Letra)
            //    {
            //        diferencia = "num_dif";
            //    }
            //    if (ejemploA.Numero == ejemploB.Numero && ejemploA.Letra != ejemploB.Letra)
            //    {
            //        diferencia = "letra_dif";
            //    }
            //    if (ejemploA.Numero != ejemploB.Numero && ejemploA.Letra != ejemploB.Letra)
            //    {
            //        diferencia = "todo_dif";
            //    }

            //    switchUpdateType(diferencia);


            //}

            //void switchUpdateType(string _upDateType)
            //{

            //    switch (_upDateType)
            //    {
            //        case "todo_igual":
            //            Console.WriteLine("todo_igual");
            //            break;
            //        case "num_dif":
            //            Console.WriteLine("num_dif");
            //            break;
            //        case "letra_dif":
            //            Console.WriteLine("letra_dif");
            //            break;
            //        case "todo_dif":
            //            Console.WriteLine("todo_dif");
            //            break;
            //    }
            //}


            //foreach (Ejemplo ejemplo in _ejemplos)
            //{
            //    if (ejemplo.Validacion == "Si")
            //    {

            //        // Ejemplo ejemploForEach = new Ejemplo()
            //        //{
            //        ejemplo.Numero = ejemplo.Numero + 1;
            //        ejemplo.Letra = ejemplo.Letra + "for";
            //        //};

            //    }
            //    else
            //    {
            //        //Console.WriteLine("no está validado");
            //    }
            //}
            //foreach (Ejemplo ejemplo in _ejemplos)
            //{
            //    //Console.WriteLine(ejemplo);
            //}  

            var matrix = new string[3, 5]
          {
          { "a1","a2","a3","a4","a5"},
          { "b1","b2","b3","b4","b5"},
          { "c1","c2","c3","c4","c5"}
          };

            string letra = "c";
            Console.WriteLine("letra: ",letra); 
            int numero = 5;
            Console.WriteLine("numero: ", numero.ToString());
            string select = letra + numero.ToString();
            Console.WriteLine(select);
            selectedCell(select);

            void selectedCell(string _select)
            {        
                string l="";
                string n="";

                foreach (var row in matrix)
                {
                    if (row[0] == _select[0])
                    {
                        l = _select[0].ToString();
                        foreach (var column in row)
                        {
                            if (row[1] == _select[1])
                            {
                                n = _select[1].ToString();
                            }
                        }
                    }           
                 }; string selected = l + n; Console.WriteLine(selected);
            }

           

        }
        public IList<Ejemplo> ejemplosVarios() {
        
        return IList<Ejemplo> ejepz
        };
         
    }
}
