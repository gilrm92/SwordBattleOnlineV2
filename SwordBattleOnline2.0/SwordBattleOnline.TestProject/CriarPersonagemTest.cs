using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwordBattleOnline.Model.Entitys;
using SwordBattleOnline.Model.Enums;
using SwordBattleOnline.Model.Entitys.Atributos;
using System.Collections.Generic;

namespace SwordBattleOnline.TestProject
{
    [TestClass]
    public class CriarPersonagemTest
    {
        [TestMethod]
        public void DeveCriarUmPersonagem()
        {
            var personagem = new Personagem();
            personagem.Nome = "Billy";
            personagem.Sexo = SexoEnum.Masculino;
            personagem.Atributos = MontarAtributos();
            personagem.Equipamento = MontarEquipamento();
        }

        private Equipamento MontarEquipamento()
        {
            var equipamento = new Equipamento();
            equipamento.ArmaPrimaria = MontarEspadaIniciante();
            
            return equipamento;
        }

        private Item MontarEspadaIniciante()
        {
            var item = new Item();
            item.Nome = "Espada Iniciante";
            item.Tipo = "Espada";

            return item;
        }
        
        private IList<Atributo> MontarAtributos() 
        {
            var atributos = new List<Atributo>();

            var forca = new Forca(1);
            var agilidade = new Agilidade(1);
            var resistencia = new Resistencia(1);
            var vida = new Vida(200);
             
            atributos.Add(forca);
            atributos.Add(agilidade);
            atributos.Add(resistencia);
            atributos.Add(vida);

            return atributos;
        }
    }
}
