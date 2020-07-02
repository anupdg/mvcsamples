using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSamples.Controllers
{
    public class GetRandomData
    {
        public static T GetRandomDataObject<T>()
        {
            T data = Activator.CreateInstance<T>();
            var r = new Random();
            foreach(var property in  data.GetType().GetProperties())
            {
                if (property.Name.ToLower().Contains("id"))
                {
                    property.SetValue(data, r.Next().ToString());
                }
                else if (property.Name.ToLower().Contains("email"))
                {
                    property.SetValue(data, $"mail-{r.Next()}@dummy.in");
                }
                else if (property.Name.ToLower().Contains("phone"))
                {
                    property.SetValue(data, $"+91-{r.Next()}");
                }
                else
                {
                    property.SetValue(data, $"{property.Name}{r.Next()}");
                }

            }
            return data;
        }
    }
}
