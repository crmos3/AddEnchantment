using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEnchantment
{
    class EnchantParameter
    {
        public string JapaneseName { get; set; }
        public string EnglishName { get; set; }
        public string ChinseSimplifiedName { get; set; }
        public string ChineseTraditionalName { get; set; }
        public int Rarity { get; set; }
        public int Category { get; set; }
        public float[] TreassureDrop { get; set; }
        public float StoneDrop { get; set; }
        public float TreeDrope { get; set; }
        public float RandomDrop { get; set; }
        public int[] SpecifiedEnemyDropID { get; set; }
        public float[] SpecifiedEnemyDropProb { get; set; }
        public string[] EffectName { get; set; }
        public float[] EffectValue { get; set; }
    }
}
