using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace P01.Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] investigateFields)
        {
            Type hackerClass = Type.GetType(className);
            var hackerFields = hackerClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            
            StringBuilder sbHacker = new StringBuilder();

            Object classInstance = Activator.CreateInstance(hackerClass, new object[] { });

            sbHacker.AppendLine($"Class under investigation: {className}");

            foreach (var fields in hackerFields.Where(f => investigateFields.Contains(f.Name)))
            {
                sbHacker.AppendLine($"{fields.Name} = {fields.GetValue(classInstance)}");
            }

            return sbHacker.ToString().TrimEnd();
        }
    }
}
