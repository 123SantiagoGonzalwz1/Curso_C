using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Eventos
{
    public delegate void AvisaLinea(int valor);
    public class clsRepositorioDelegado
    {
        public event AvisaLinea ReportarAvance;
        public void ObtenTodos()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(250);
                ReportarAvance(i + 1);
            }
        }
    }

}
