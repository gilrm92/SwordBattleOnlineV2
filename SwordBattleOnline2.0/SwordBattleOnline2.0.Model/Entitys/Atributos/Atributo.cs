using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwordBattleOnline.Model.Entitys.Atributos
{
    public class Atributo
    {
        protected Atributo(int valor) 
        {
            Valor = valor;
        }

        public int Valor { get; set; }

        //public int Forca { get; set; }
        //public int Agilidade { get; set; }
        //public int Resistencia { get; set; }
        //public int Precisao { get; set; }
        //public int Vida { get; set; }
        //public int Energia { get; set; }
        //public int Fadiga { get; set; }
        
        //public int GetForcaDeAtaque() 
        //{
        //    return Forca + Agilidade;
        //}

        //public int GetForcaDeDefesa()
        //{
        //    return Agilidade + Resistencia;
        //}
    }
}
