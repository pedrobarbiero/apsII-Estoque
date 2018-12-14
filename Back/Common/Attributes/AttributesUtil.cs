using Common.Attributes;
using System;
using System.Linq;
using System.Reflection;

namespace Common
{
    public class AttributesUtil
    {
        public static PropertyInfo GetTextField(Type classe){            
            foreach (var property in classe.GetProperties())
            {
                bool isTextField = property.GetCustomAttributes().FirstOrDefault(t => t is TextField) != null;
                if (isTextField)
                    return property;
            }
            throw new Exception($"Classe {classe} não possui TextField attribute!");
        }
    }
}
