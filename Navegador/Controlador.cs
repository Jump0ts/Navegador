using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Controlador
    {
        private ArrayList favoritos = new ArrayList();
        private ArrayList historial = new ArrayList();
        private ArrayList buscadores = new ArrayList();
        private String buscador = "https://www.google.es/search?q=";
        private const String expresion = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
        
        public Controlador()
        {
            buscadores.Add("https://www.google.es/search?q=");
            buscadores.Add("https://es.search.yahoo.com/search?p=");
            buscadores.Add("https://www.bing.com/search?q=");
            buscadores.Add("https://www.ecosia.org/search?q=");
            buscadores.Add("https://duckduckgo.com/?q=");
        }

        public void navegar(String cadena)
        {
            anadirHistorial(cadena);
            Singleton.getNavegador().getWeb().ScriptErrorsSuppressed = true;
            if (validar(cadena) == false) cadena = buscador + cadena;
            Singleton.getNavegador().getWeb().Navigate(cadena);
            Singleton.getNavegador().getTxtDireccion().Text = cadena;
        }

        private Boolean validar(String cadena)
        {
            Regex reg = new Regex(expresion);
            return reg.IsMatch(cadena);
        }

        public void anadirFav(String cadena)
        {
            Boolean visto = false;
            for (int i = 0; i < favoritos.Count; i++)
            {
                if (favoritos[i].Equals(cadena)) visto = true;
            }
            if (visto == false) favoritos.Add(cadena);
        }

        public void eliminarFav(String cadena)
        {
            favoritos.Remove(cadena);
        }

        public void rellenarFav(ListBox listaFav)
        {
            listaFav.Items.Clear();

            for(int i = 0; i < favoritos.Count; i++)
            {
                listaFav.Items.Add(favoritos[i]);
            }
        }

        private void anadirHistorial(String cadena)
        {
            historial.Add(cadena);
        }

        public void eliminarHist(int indice)
        {
            historial.RemoveAt(indice);
        }

        public void eliminarTodoHist(ListBox listaHist)
        {
            listaHist.Items.Clear();
            historial.Clear();
        }

        public void rellenarHist(ListBox listaHist)
        {
            listaHist.Items.Clear();
            for(int i = 0; i < historial.Count; i++)
            {
                listaHist.Items.Add(historial[i]);
            }
        }

        public void rellenarBuscadores(ToolStripComboBox comboBuscadores)
        {
            comboBuscadores.Items.Clear();
            for(int i = 0; i < buscadores.Count; i++)
            {
                comboBuscadores.Items.Add(buscadores[i]);
            }
        }

        public void cambiaBuscador(int indice)
        {
            buscador = ""+buscadores[indice];
        }
    }
}
