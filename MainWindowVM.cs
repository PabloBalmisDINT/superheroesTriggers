using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes
{
    class MainWindowVM : ObservableObject
    {
        //Campos con getters y setters
        private ListaSuperheroesService servicioHeroes = new ListaSuperheroesService();
        readonly private List<Superheroe> lista = servicioHeroes.GetSamples();
        
        private Superheroe superheroeActual;
        public Superheroe SuperheroeActual 
        { 
            get { return superheroeActual; }
            set 
            {
                SetProperty(ref superheroeActual, value);
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
                SetProperty(ref contadorActual, value);
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
                SetProperty(ref totalHeroes, value);
            }
        }

        //Constructor
        public MainWindowVM()
        {
            SuperheroeActual = lista.FirstOrDefault();
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

    }
}
