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
    }
}
