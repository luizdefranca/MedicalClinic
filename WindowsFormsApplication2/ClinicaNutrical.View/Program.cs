using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaNutrical.View
{
    static class Program
    {
        /// <summary>
        ///Ponto inicial para a aplicacao
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClinicaNutrical.View.FormNewConsulta());
        }
    }
}
