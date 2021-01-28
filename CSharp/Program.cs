using System.Reflection;
using System;

namespace CSharp
{
    class Program
    {
        private static string[] exercises = {
            "One"
        };

        static void Main(string[] args)
        {
            start();
        }

        private static void start()
        {
            try
            {
                Console.Write("Execute o exercício desejado: ");
                int exerciseArrayIndex = int.Parse(Console.ReadLine());
                ExecuteExercise(exerciseArrayIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ExecuteExercise(int exerciseNumber)
        {
            try
            {
                Type type = typeof(Exercise);
                MethodInfo method = type.GetMethod(exercises[exerciseNumber]);
                method.Invoke(ExerciseContainer(), null);
            }
            catch (Exception e)
            {
                throw new Exception("Não existe um exercício com o índice digitado.");
            }
        }

        private static Exercise ExerciseContainer()
        {
            return new Exercise();
        }
    }
}
