using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes
{
    class MainWindowVM : INotifyPropertyChanged
    {
        //Campos con getters y setters
        readonly private List<Superheroe> lista = Superheroe.GetSamples();
        
        private Superheroe superheroeActual;
        public Superheroe SuperheroeActual 
        { 
            get { return superheroeActual; }
            set 
            { 
                superheroeActual = value;
                NotifyPropertyChanged("SuperheroeActual");
            }
        }
        private int contadorActual;
        public int ContadorActual 
        {
            get 
            { 
                return contadorActual; 
            }
            set
            {
                contadorActual = value;
                NotifyPropertyChanged("ContadorActual");
            } 
        }
        private int totalHeroes;
        public int TotalHeroes 
        { 
            get
            {
                return totalHeroes;
            }
            set
            {
                totalHeroes = value;
                NotifyPropertyChanged("TotalHeroes");
            }
        }

        //Constructor
        public MainWindowVM()
        {
            SuperheroeActual = lista.FirstOrDefault<Superheroe>();
            ContadorActual = 1;
            TotalHeroes = lista.Count;
        }

        //Metodos
        public void Avanzar()
        {
            if (ContadorActual < TotalHeroes)
            {
                ContadorActual++;
                SuperheroeActual = lista[ContadorActual - 1];
            }
        }

        public void Retroceder()
        {
            if(ContadorActual > 1)
            {
                ContadorActual--;
                SuperheroeActual = lista[ContadorActual - 1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
