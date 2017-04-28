using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwordBattleOnline.Model.Entitys
{
    public class Item
    {
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public IList<IModificador> Modificadores { get; set; }

        public int GetValorModificador<T>()
        {
            return Modificadores.Where(m => m is T).FirstOrDefault().ValorModificador;
        }
    }

    public enum Tipo 
    { 
        Espada, Arco, Escudo, Cajado
    }
}
