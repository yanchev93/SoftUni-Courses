namespace P04.Collector
{
    using System;
    using System.Text;
    using System.Reflection;
    using System.Linq;

    public class Spy
    {
        public string AnalyzeAcessModifiers(string className)
        {
            Type hackerClassInfo = Type.GetType(className);
            MethodInfo[] allMethods = hackerClassInfo.GetMethods
                (BindingFlags.Instance | BindingFlags.Public
                | BindingFlags.NonPublic | BindingFlags.Static);

            StringBuilder sbAnalyzeAcessModifiers = new StringBuilder();


            foreach (var method in allMethods.Where(x=>x.Name.StartsWith("get")))
            {
                sbAnalyzeAcessModifiers.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (var method in allMethods.Where(x => x.Name.StartsWith("set")))
            {
                sbAnalyzeAcessModifiers.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sbAnalyzeAcessModifiers.ToString().TrimEnd();
        }
    }
}
