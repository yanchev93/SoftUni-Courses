using System;
using System.Reflection;
using System.Text;

namespace P03.MissionPrivateImpossible
{
    public class Spy
    {
        public string RevealPrivateMethods(string className)
        {
            Type hackerClassInfo = Type.GetType(className);
            MethodInfo[] privateMethodsInfo = hackerClassInfo
                   .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sbMethods = new StringBuilder();

            sbMethods.AppendLine($"All Private Methods of Class: {className}")
                     .AppendLine($"Base Class: {hackerClassInfo.BaseType.Name}");

            foreach (var privateMethod in privateMethodsInfo)
            {
                sbMethods.AppendLine(privateMethod.Name);
            }

            return sbMethods.ToString().TrimEnd();
        }
    }
}
