using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    public abstract class Personaje
    {
        #region Variables
        protected string nombre;
        protected int vida;
        protected int armadura;
        protected int poderDelArma;
        #endregion
        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public int Armadura
        {
            get { return armadura; }
            set { armadura = value; }
        }
        public int PoderDelArma
        {
            get { return poderDelArma; }
            set { poderDelArma = value; }
        }
        
        #endregion
        #region Constructor
        public Personaje() 
        {
            Nombre = "";
            Vida = 0;
            Armadura = 0;
            PoderDelArma = 0;
        }
        #endregion
        #region Metodos
        public abstract int Atacar();
        #endregion


    }
}
