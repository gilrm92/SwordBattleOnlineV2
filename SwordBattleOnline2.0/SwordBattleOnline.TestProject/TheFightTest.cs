using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwordBattleOnline.Model.Entitys;
using SwordBattleOnline.Model.Enums;
using SwordBattleOnline.Model.Entitys.Atributos;
using System.Collections.Generic;

namespace SwordBattleOnline.TestProject
{
    [TestClass]
    public class TheFightTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var personagem1 = new Personagem();
            personagem1.Nome = "Billy";
            personagem1.Sexo = SexoEnum.Masculino;
            personagem1.Atributos = MontarAtributosBilly();
            personagem1.Equipamento = MontarEquipamentoBilly();

            var personagem2 = new Personagem();
            personagem2.Nome = "Felipa";
            personagem2.Sexo = SexoEnum.Feminino;
            personagem2.Atributos = MontarAtributosFelipa();
            personagem2.Equipamento = MontarEquipamentoFelipa();

            personagem1.AtaqueBasico(personagem2);

            Assert.IsTrue(personagem2.Atributos.Where(a => a is Vida).Single().Valor == 399);
        }

        private Equipamento MontarEquipamentoFelipa()
        {
            return new Equipamento
            {
                ArmaPrimaria = new Item { Nome = "Espada de esgrima bugada" }
            };
        }

        private IList<Atributo> MontarAtributosFelipa()
        {
            var atributos = new List<Atributo>();

            var forca = new Forca(2);
            var agilidade = new Agilidade(3);
            var resistencia = new Resistencia(2);
            var vida = new Vida(400);

            atributos.Add(forca);
            atributos.Add(agilidade);
            atributos.Add(resistencia);
            atributos.Add(vida);

            return atributos;
        }

        private Equipamento MontarEquipamentoBilly()
        {
            return new Equipamento
            {
                ArmaPrimaria = new Item { Nome = "Espada louca" }
            };
        }

        private IList<Atributo> MontarAtributosBilly()
        {
            var atributos = new List<Atributo>();

            var forca = new Forca(4);
            var agilidade = new Agilidade(2);
            var resistencia = new Resistencia(2);
            var vida = new Vida(400);

            atributos.Add(forca);
            atributos.Add(agilidade);
            atributos.Add(resistencia);
            atributos.Add(vida);

            return atributos;
        }

    }
}
