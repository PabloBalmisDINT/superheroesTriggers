using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superheroes 
{
    class Superheroe : ObservableObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { SetProperty(ref imagen, value); }
        }


        private bool vengador;

        public bool Vengador
        {
            get { return vengador; }
            set { SetProperty(ref vengador, value); }
        }
        private bool xmen;
        public bool Xmen
        {
            get { return xmen; }
            set { SetProperty(ref xmen, value); }
        }

        private bool heroe;
        public bool Heroe
        {
            get { return heroe; }
            set { SetProperty(ref heroe, value); }
        }


        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }
    }
}