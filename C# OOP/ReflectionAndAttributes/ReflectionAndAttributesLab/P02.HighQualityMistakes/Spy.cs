namespace P02.HighQualityMistakes
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string AnalyzeAcessModifiers(string className)
        {
            Type hackerInfo = Type.GetType(className);

            FieldInfo[] fieldsInfo = hackerInfo.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] publicMethodsInfo = hackerInfo.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] privateMethodsInfo = hackerInfo.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sbInfo = new StringBuilder();

            foreach (FieldInfo field in fieldsInfo)
            {
                sbInfo.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in privateMethodsInfo.Where(m => m.Name.StartsWith("get")))
            {
                sbInfo.AppendLine($"{method.Name} have to be public!");
            }

            foreach (MethodInfo method in publicMethodsInfo.Where(m => m.Name.StartsWith("set")))
            {
                sbInfo.AppendLine($"{method.Name} have to be private!");
            }

            return sbInfo.ToString().TrimEnd();
        }
    }
}
