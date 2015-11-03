using SwordBattleOnline.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwordBattleOnline.Model.Entitys.Atributos;
using SwordBattleOnline.Model.Interfaces;

namespace SwordBattleOnline.Model.Entitys
{
    public class Personagem
    {
        public string Nome { get; set; }
        public SexoEnum Sexo { get; set; }
        public IList<Atributo> Atributos { get; set; }
        public Equipamento Equipamento { get; set; }

        public void AtaqueBasico(Personagem personagem)
        {
            var FaAtacante = GetValorDeAtributosDoTipo<IForcaAtaque>();
            var FdDefensor = personagem.GetValorDeAtributosDoTipo<IForcaDefesa>();

            if (FaAtacante > FdDefensor)
                personagem.RemovePontosDeVida(FaAtacante - FdDefensor);
        }

        private void RemovePontosDeVida(int pontosRemover)
        {
            var atributoVida = Atributos.Where(a => a is Vida).Single();
            atributoVida.Valor -= pontosRemover; 
        }

        public int GetValorDeAtributosDoTipo<T>()
        {
            var atributos = Atributos.Where(a => a is T);
            int valor = 0;

            foreach (var atributo in atributos)
            {
                valor += atributo.Valor;
            }

            return valor;
        }

    }
}