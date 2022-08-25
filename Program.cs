using System.Reflection;

namespace ReflectionAssignment
{
    public class Program
    {
        public static void Main(string [] args)
        {
           

            Type type = typeof(MoodAnalyser);

            Console.WriteLine("Class :" + type.Name);

            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine("Method : " + method.Name);
                ParameterInfo[] parameters = method.GetParameters();
                foreach (var p in parameters)
                {
                    Console.WriteLine("Parameter : " + p.Name + " : " + p.ParameterType);
                }
            }


            
        }
    }
}



