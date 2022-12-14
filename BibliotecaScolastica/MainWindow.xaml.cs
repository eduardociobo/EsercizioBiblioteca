using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BibliotecaScolastica
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }





        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            string autore = txtAutore.Text; 
            string titolo = txtTitolo.Text;
            string annoPublicazione = txtAnnoDiPubblicazione.Text;
            string nPagine = txtNumeroPagine.Text;
            string editore = txtEditore.Text;

            Libro l = new Libro();
            l.tostring(autore, titolo, annoPublicazione, nPagine, editore);
            l.readingTime(nPagine);
        }

        private void btnAggiungiBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNomeBiblioteca .Text;
            string indirizzo = txtIndirizzo .Text;
            string orarioApertura = txtOrarioApertura.Text;
            string orarioChiusura = txtOrarioChiusura.Text;

            Biblioteca b = new Biblioteca();
            b.getNome();
            b.setNome(nome);
            b.getIndirizzo();
            b.setIndirizzo(indirizzo);
            b.getOrarioApertura();
            b.setOrarioApertura(orarioApertura);
            b.getOrarioChiusura();
            b.setOrarioChiusura(orarioChiusura);
            b.Aggiungilibro(txtTitolo.Text);

        }
    }

    class Libro
    {
        
        public string toString(string autore, string titolo, string annoPubblicazione, string editore, int nPagine)
        {

            string numeroPagine = nPagine.ToString();
            string infoLibro = autore + "" + titolo + annoPubblicazione + editore + numeroPagine;

            return infoLibro;

           

        }

        public int readingTime(int nPagine)
        {
            int oreDiLettura = 1;
            if (nPagine < 100)
            {
                oreDiLettura = 1;
            }
            if  (nPagine > 100 && nPagine < 200){

                oreDiLettura = 2;
            }
            if (nPagine > 200)
            {
                oreDiLettura = 3;
            }

            return oreDiLettura;
            
        }

    }

    class Biblioteca
    {
        string nome;
        string indirizzo;
        string orarioApertura;
        string orarioChiusura;
        int i = 0;
        string[] elencoLibri = new string[1000];
        public string getNome()
        {
            
            return nome;
        }

        public void  setNome(string nm)
        {
            nome = nm;
        }

        public string getIndirizzo()
        {

            return indirizzo;
        }

        public void setIndirizzo(string ind)
        {
            indirizzo = ind;
        }

        public string getOrarioApertura()
        {

            return orarioApertura;
        }

        public void setOrarioApertura(string oAp)
        {
            orarioApertura = oAp;
        }

        public string getOrarioChiusura()
        {

            return orarioChiusura;
        }

        public void setOrarioChiusura(string oCh)
        {
            orarioChiusura = oCh;
        }

        public void aggiungiAdElencoLibri(string libro)
        {
            elencoLibri[i] = libro;
        }




    }




}
