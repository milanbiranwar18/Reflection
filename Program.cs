using System.Reflection;

namespace ReflectionAssignment
{
    public class Program
    {
        public static void Main(string [] args)
        {


            //Type type = typeof(MoodAnalyser);

            //Console.WriteLine("Class :" + type.Name);

            //MethodInfo[] methods = type.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine("Method : " + method.Name);
            //    ParameterInfo[] parameters = method.GetParameters();
            //    foreach (var p in parameters)
            //    {
            //        Console.WriteLine("Parameter : " + p.Name + " : " + p.ParameterType);
            //    }
            //}


            //Type type1 = typeof(MoodAnalyser1);

            //Console.WriteLine("Class :" + type1.Name);

            //MethodInfo[] method = type1.GetMethods();
            //foreach (var m in method)
            //{
            //    Console.WriteLine("Method : " + m.Name);
            //    ParameterInfo[] parameters = m.GetParameters();
            //    foreach (var p in parameters)
            //    {
            //        Console.WriteLine("Parameter : " + p.Name + " : " + p.ParameterType);
            //    }
            //}


            Type type1 = typeof(MoodAnalyser1);
            ConstructorInfo[] ci = type1.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (ConstructorInfo ci2 in ci)
            {
                Console.WriteLine(ci2);
            }

            Console.WriteLine("--------------------------");

            Type type2 = typeof(MoodAnalyser1);
            MethodInfo[] mi = type2.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (MethodInfo c in mi)
            {
                Console.WriteLine(c);
            }


        }
    }
}



