using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YuGinventory.Models
{
    public class ReferenceCard
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //[DisplayFormat(DataFormatString = "")]
        public CardType Type { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public string Text { get; set; }
        public string SetId { get; set; }

        public enum CardType
        {
            NORMAL_MONSTER,
            EFFECT_MONSTER,
            PENDULUM_MONSTER,
            RITUAL_MONSTER,
            FUSION_MONSTER,
            SYNCHRO_MONSTER,
            XYZ_MONSTER,
            NORMAL_SPELL,
            QUICK_PLAY_SPELL,
            CONTINUOUS_SPELL,
            FIELD_SPELL,
            RITUAL_SPELL,
            NORMAL_TRAP,
            CONTINUOUS_TRAP,
            COUNTER_TRAP
        }

        Dictionary<CardType, string> TypeDictionary { get; } = new Dictionary<CardType, string>();

        private void InitTypeDictionary()
        {
            //Monsters
            TypeDictionary.Add(CardType.NORMAL_MONSTER, "Normal Monster");
            TypeDictionary.Add(CardType.EFFECT_MONSTER, "Effect Monster");
            TypeDictionary.Add(CardType.PENDULUM_MONSTER, "Pendulum Monster");
            TypeDictionary.Add(CardType.RITUAL_MONSTER, "Ritual Monster");
            TypeDictionary.Add(CardType.FUSION_MONSTER, "Fusion Monster");
            TypeDictionary.Add(CardType.SYNCHRO_MONSTER, "Synchro Monster");
            TypeDictionary.Add(CardType.XYZ_MONSTER, "Xyz Monster");

            //Spells
            TypeDictionary.Add(CardType.NORMAL_SPELL, "Normal Spell");
            TypeDictionary.Add(CardType.QUICK_PLAY_SPELL, "Quick-Play Spell");
            TypeDictionary.Add(CardType.CONTINUOUS_SPELL, "Continuous Spell");
            TypeDictionary.Add(CardType.FIELD_SPELL, "Field Spell");
            TypeDictionary.Add(CardType.RITUAL_SPELL, "Ritual Spell");

            //Traps
            TypeDictionary.Add(CardType.NORMAL_TRAP, "Normal Trap");
            TypeDictionary.Add(CardType.CONTINUOUS_TRAP, "Continuous Trap");
            TypeDictionary.Add(CardType.COUNTER_TRAP, "Counter Spell");
        }

        //public string GetTypeDesc => TypeDictionary[Type];
    }
}
