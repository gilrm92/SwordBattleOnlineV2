using SwordBattleOnline.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwordBattleOnline.Model.Entitys.Atributos
{
    public class Agilidade : Atributo, IForcaAtaque, IForcaDefesa
    {
        public Agilidade(int valor) : base(valor)
        { 
        }
    }
}