using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_qt_aluno_curso_a = 0;
            int v_qt_aluno_curso_b = 0;
            int v_qt_aluno_curso_c = 0;
            int v_tot_qt_aluno = 0;


            //declaração dos Cursos como conjuntos
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            //--------------------------------------------
            //--------------------------------------------
            Console.Write("O curso A possui quantos alunos?");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < x; i++)
            {                
                A.Add(int.Parse(Console.ReadLine()));
            }
            //--------------------------------------------
            Console.Write("O curso B possui quantos alunos?");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < y; i++)
            {                
                B.Add(int.Parse(Console.ReadLine()));
            }
            //--------------------------------------------
            Console.Write("O curso C possui quantos alunos?");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < z; i++)
            {                
                C.Add(int.Parse(Console.ReadLine()));
            }
            //--------------------------------------------
            //--------------------------------------------
            A.ExceptWith(B);
            foreach(int k in A)
            {
                v_qt_aluno_curso_a = v_qt_aluno_curso_a + 1;
            }
            B.ExceptWith(C);
            foreach(int w in B)
            {
                v_qt_aluno_curso_b = v_qt_aluno_curso_b + 1;
            }
            C.ExceptWith(A);
            foreach (int f in C)
            {
                v_qt_aluno_curso_c = v_qt_aluno_curso_c + 1;
            }

            v_tot_qt_aluno = v_qt_aluno_curso_a + v_qt_aluno_curso_b + v_qt_aluno_curso_c;
            Console.WriteLine("Total de Alunos: " + v_tot_qt_aluno);            

        }
    }
}
