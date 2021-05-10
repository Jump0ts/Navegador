using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Singleton
    {
        private static VNavegador navegador = null;
        private static Controlador control = null;

        public static VNavegador getNavegador()
        {
            if (navegador == null) navegador = new VNavegador();
            return navegador;
        }

        public static Controlador getControl()
        {
            if (control == null) control = new Controlador();
            return control;
        }
    }
}
