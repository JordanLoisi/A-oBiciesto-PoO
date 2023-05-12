using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñoBiciesto_PoO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("si desea salir de la aplicacion presione Ctrl+c ");
            int anio = 0;
            do
            {
                
                Console.Write("ingrese el año ");
                anio = int.Parse(Console.ReadLine());

                if (EsBiciesto(anio))
                {
                    Console.WriteLine(ValidarTiempo(anio,EsBiciesto(anio)));
                }
                else
                {
                    Console.WriteLine(ValidarTiempo(anio, EsBiciesto(anio)));
                }
                Console.Write("ingrese un ENTER para continuar .....");
                Console.ReadLine();

            } while (true);
        }
         public static bool EsBiciesto(int anio)
            {
                if (anio % 4 == 0)
                {
                    if (anio % 100 == 0)
                    {
                        if (anio % 400 == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }

                }
                else
                {
                    return false;
                }
            }
        public  static string ValidarTiempo(int anio,bool valido) 
        {
            if (anio == DateTime.Now.Year && valido)
            {
                return $"El año {anio} es Bisiesto";
            }
            else
            {
                if (anio==DateTime.Now.Year && !valido)
                {
                    return $"El año {anio} No es Bisiesto";
                }
                else
                {
                    if (anio < DateTime.Now.Year && valido)
                    {
                        return $"El año {anio}  fue Bisiesto";
                    }
                    else
                    {
                        if (anio < DateTime.Now.Year && !valido)
                        {
                            return $"El año {anio} No fue Bisiesto";
                        }
                        else
                        {
                            if (anio>DateTime.Now.Year && valido)
                            {
                                return $"El año {anio} sera Bisiesto";
                            }
                            else
                            {
                                return $"El año {anio} no sera Bisiesto";
                            }
                        }
                    }
                }
            }
        } 

        }
    }


