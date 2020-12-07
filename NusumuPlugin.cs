using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusumuPlugintest
{
    public class NusumuPlugin
    {
        //DO NOT ADD PARAMETERS!
        //Plugin will not work with parameters ex: Execute(object obj1, object obj2)
        public static void Execute()
        {
            MessageBox.Show("test");
        }
    }
}
