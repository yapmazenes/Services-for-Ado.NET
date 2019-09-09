using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Extensions
{
    public static class Extension
    {
        public static T Changer<T>(this object source)
        {

            T hedef = Activator.CreateInstance<T>();
            Type kaynak = source.GetType();
            PropertyInfo[] kaynakProp = kaynak.GetProperties();
            PropertyInfo[] hedefProp = typeof(T).GetProperties();
            foreach (PropertyInfo pi in kaynakProp)
            {
                object value = pi.GetValue(source);
                PropertyInfo ph = hedefProp.FirstOrDefault(x => x.Name == pi.Name);
                if (ph!=null)
                {
                    ph.SetValue(hedef, value);  
                }
           
                
            }
            return hedef;
        }
    }
}
