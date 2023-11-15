using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciospracticos2.clases
{
    public class Ejercicios
    {
        //Solicitar valores numéricos en dos arreglos distintos y almacenar el resultado de la suma de los valores en cada posición (posición 0 del arreglo 1 + posición 0 del arreglo 2) en un tercer arreglo. 
        public void SumadeValores()
        {
            int[] arreglo1 = new int[5];
            int[] arreglo2 = new int[5];
            int[] total = new int[5];

            Console.WriteLine("Pon numeros para el primer arreglo");
            for (int x = 0; x < 5; x++)
            {

                Console.WriteLine($"Pon valor de la posicion {x} del arreglo1 ");
                arreglo1[x] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Pon valor de la posición {x} del arreglo2");
                arreglo2[x] = Convert.ToInt32(Console.ReadLine());

                total[x] = arreglo1[x] + arreglo2[x];

            }

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"Valor en la posición {x} del arreglo1 + valor en la posicion{x} del arreglo 2 = {total[x]} en la posición {x} del arreglo3");
            }
        }
        // Queremos mostrar a todos los alumnos que están inscritos en ambas asignaturas. Estos alumnos se guardarán en un tercer arreglo, el cual se mostrará
        public void AlumnosInscritos(int cantidad, int cantidad2)
        {
            int[] Algebra = new int[cantidad];
            int[] Analisis = new int[cantidad2];
            int[] TotalAlumnos = new int[cantidad + cantidad2];

            Console.WriteLine("Pon Id de los alumnos de Algebra");
            for (int x = 0; x < Algebra.Length; x++)
            {
                Console.WriteLine($"Ahora, escriba el Id del alumno {x + 1} en su lista de alumnos de Algebra");
                Algebra[x] = Convert.ToInt32(Console.ReadLine());
                TotalAlumnos[x] = Algebra[x];

            }
            Console.WriteLine("Pon Id de los alumnos de Analisis");
            for (int x = 0; x < Analisis.Length; x++)
            {
                Console.WriteLine($"Ahora, escriba el Id del alumno {x + 1} en su lista de alumnos de Analisis");
                Analisis[x] = Convert.ToInt32(Console.ReadLine());
                TotalAlumnos[Algebra.Length + x] = Analisis[x];

            }
            Console.WriteLine($"El total de Id de alumnos registrados es: {TotalAlumnos.Length}");
            Console.WriteLine("Id de alumnos");
            for (int x = 0; x < TotalAlumnos.Length; x++)
            {
                Console.WriteLine(TotalAlumnos[x]);
            }
            int contador = 0;
            for (int x = 0; x < TotalAlumnos.Length; x++)
            {
                for (int y = x + 1; y < TotalAlumnos.Length; y++)
                {
                    if (TotalAlumnos[x] == TotalAlumnos[y])
                    {
                        contador++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Total de alumnos repetidos {contador} ");
        }

        //calcule el promedio de las notas aprobadas y el promedio de las notas desaprobadas.Iindique la cantidad de notas aprobadas y desaprobadas en el arreglo.
        public void Promedio()
        {
            int[] Notas = new int[8];
            float Aprobados = 0;
            float PromedioAprobados = 0;
            float PromedioReprobados = 0;
            float Reprobados = 0;
            Console.WriteLine("Pon la nota de cada alumno");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Del alumno numero {i + 1}");
                Notas[i] = Convert.ToInt32(Console.ReadLine());

                if (Notas[i] > 6)
                {
                    Aprobados++;
                    PromedioAprobados += Notas[i];

                }
                else
                {
                    Reprobados++;
                    PromedioReprobados += Notas[i];
                }
            }

            PromedioAprobados = PromedioAprobados / Aprobados;
            PromedioReprobados = PromedioReprobados / Reprobados;

            if (PromedioAprobados < 6)
            {
                Console.WriteLine($"Cantidad de aprobados: {Aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {Reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {PromedioAprobados}");
                Console.WriteLine($"Promedio de reprobados: {PromedioReprobados}\n");
                Console.WriteLine("Rango: Deficiente");
            }
            if (PromedioAprobados > 6 && PromedioAprobados < 11)
            {
                Console.WriteLine($"Cantidad de aprobados: {Aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {Reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {PromedioAprobados}");
                Console.WriteLine($"Promedio de reprobados: {PromedioReprobados} \n");
                Console.WriteLine("Rango: Regulares");
            }
            if (PromedioAprobados > 11 && PromedioAprobados < 16)
            {
                Console.WriteLine($"Cantidad de aprobados: {Aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {Reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {PromedioAprobados}");
                Console.WriteLine($"Promedio de reprobados: {PromedioReprobados}");
                Console.WriteLine("Rango: Buenos");
            }
            if (PromedioAprobados > 16)
            {
                Console.WriteLine($"Cantidad de aprobados: {Aprobados}");
                Console.WriteLine($"Cantidad de reprobados: {Reprobados}\n");
                Console.WriteLine($"Promedio de aprobados: {PromedioAprobados}");
                Console.WriteLine($"Promedio de reprobados: {PromedioReprobados}\n");
                Console.WriteLine("Rango: Excelente");
            }
        }
    }
}
