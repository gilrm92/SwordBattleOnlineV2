using SwordBattleOnline.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwordBattleOnline.Model.Entitys.Atributos
{
    public class Forca : Atributo, IForcaAtaque
    {
        public Forca(int valor) : base(valor)
        {
        }
        
    }
}