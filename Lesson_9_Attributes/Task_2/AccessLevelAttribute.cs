using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    class AccessLevelAttribute : System.Attribute
    {
        public  int level { get; set; }
        public AccessLevelAttribute()
        {
        }
        public AccessLevelAttribute(int level)
        {
            this.level = level;
        }
    }
}
