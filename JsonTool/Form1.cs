using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LibCraftopia.Enchant;

namespace JsonTool
{
    public partial class Form1 : Form
    {

        static readonly string[] EnchantRarity =
        {
            "Common",
            "UnCommon",
            "Rare",
            "SuperRare",
            "UltraRare",
            "Epic",
            "Legendary",
            "OverLegendary"
        };

        static readonly Dictionary<string, int> CategoryDict = new Dictionary<string, int>()
        {
            {"Normal", 0},
            {"Equipment", 10000 },
            {"Item", 30000 }
        };

        static Dictionary<string, int> EnemyName = new Dictionary<string, int>()
        {
            {"ゴリラ",4},
            {"クマ",9},
            {"爆弾タル",10},
            {"ゴブリンウォーリア",11},
            {"ゴブリンシャーマン",12},
            {"ゴブリンヒーラー",13},
            {"ゴブリンバード",14},
            {"バッファロー",15},
            {"キリン",16},
            {"ゾウ",17},
            {"イノシシ",18},
            {"ラクダ",19},
            {"ニワトリ",20},
            {"ヒツジ",21},
            {"ウシ",22},
            {"シカ",23},
            {"キツネ",24},
            {"ウミネコ",25},
            {"オオカミ",26},
            {"一匹オオカミ",27},
            {"ブタ",28},
            {"ストームチキン",29},
            {"ストームオオカミ",30},
            {"ドラゴン",31},
            {"回転のこぎり",32},
            {"ワニ",33},
            {"モノ",38},
            {"エンシェントゴーレム",39},
            {"リザードアックス",40},
            {"リザードソード",41},
            {"村人アレクサンドリア",100},
            {"盗賊ケビン",101},
            {"受付係ファン",102}
        };

        private Dictionary<string, float> EnemyList = new Dictionary<string, float>();

        private Dictionary<string, float> EffectList = new Dictionary<string, float>();

        public Form1()
        {
            InitializeComponent();
            foreach (var rarity in EnchantRarity)
            {
                Rarity.Items.Add(rarity);
            }
            Rarity.SelectedIndex = 0;
            foreach (var c in CategoryDict)
            {
                Category.Items.Add(c.Key);
            }
            Category.SelectedIndex = 0;
            foreach (var e in EnemyName)
            {
                Enemy.Items.Add(e.Key);
            }
            Enemy.SelectedIndex = 0;
            foreach (var e in EnemyName)
            {
                Enemy.Items.Add(e.Key);
            }
            Enemy.SelectedIndex = 0;
            foreach (var e in LibCraftopia.Enchant.EnchantSetting.EffectName)
            {
                Effect.Items.Add(e);
            }
            Effect.SelectedIndex = 0;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                var str = File.ReadAllText(openFileDialog1.FileName);
                var enchant = JsonSerializer.Deserialize<AddEnchantment.EnchantParameter>(str);
                JapaneseName.Text = enchant.JapaneseName;
                EnglishName.Text = enchant.EnglishName;
                ChineseSimplifiedName.Text = enchant.ChinseSimplifiedName;
                ChineseTraditionalName.Text = enchant.ChineseTraditionalName;
                Rarity.Text = EnchantRarity[enchant.Rarity];
                Category.Text = CategoryDict.First(pair => pair.Value == enchant.Category).Key;
                Stone.Value = (decimal)enchant.StoneDrop;
                Tree.Value = (decimal)enchant.TreeDrope;
                Random.Value = (decimal)enchant.RandomDrop;
                TreassureProbs0.Value = (decimal)enchant.TreassureDrop[0];
                TreassureProbs1.Value = (decimal)enchant.TreassureDrop[1];
                TreassureProbs2.Value = (decimal)enchant.TreassureDrop[2];
                TreassureProbs3.Value = (decimal)enchant.TreassureDrop[3];
                TreassureProbs4.Value = (decimal)enchant.TreassureDrop[4];
                for (int i = 0; i < enchant.SpecifiedEnemyDropID.Length; i++)
                {
                    var id = enchant.SpecifiedEnemyDropID[i];
                    var name = EnemyName.First(pair => pair.Value == id).Key;
                    EnemyList[name] = enchant.SpecifiedEnemyDropProb[i];
                }
                UpdateEnemyProbsList();
                for(int i = 0; i < enchant.EffectName.Length; i++)
                {
                    EffectList[enchant.EffectName[i]] = enchant.EffectValue[i];
                }
                UpdateEffectValueList();
                ExtraValue.Text = enchant.ExtraValue;
                EnchantID.Value = enchant.ID;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                var enchant = new AddEnchantment.EnchantParameter();
                enchant.JapaneseName = JapaneseName.Text;
                enchant.EnglishName = EnglishName.Text;
                enchant.ChinseSimplifiedName = ChineseSimplifiedName.Text;
                enchant.ChineseTraditionalName = ChineseTraditionalName.Text;
                enchant.Rarity = Array.IndexOf(EnchantRarity, Rarity.Text);
                enchant.Category = CategoryDict[Category.Text];
                enchant.StoneDrop = (float)Stone.Value;
                enchant.TreeDrope = (float)Tree.Value;
                enchant.RandomDrop = (float)Random.Value;
                enchant.TreassureDrop = new float[] {
                    (float)TreassureProbs0.Value,
                    (float)TreassureProbs1.Value,
                    (float)TreassureProbs2.Value,
                    (float)TreassureProbs3.Value,
                    (float)TreassureProbs4.Value,
                };
                enchant.SpecifiedEnemyDropID = new int[EnemyList.Count];
                enchant.SpecifiedEnemyDropProb = new float[EnemyList.Count];
                int i = 0;
                foreach(var pair in EnemyList) {
                    enchant.SpecifiedEnemyDropID[i] = EnemyName[pair.Key];
                    enchant.SpecifiedEnemyDropProb[i] = pair.Value;
                    i++;
                }
                enchant.EffectName = new string[EffectList.Count];
                enchant.EffectValue = new float[EffectList.Count];
                i = 0;
                foreach(var pair in EffectList)
                {
                    enchant.EffectName[i] = pair.Key;
                    enchant.EffectValue[i] = pair.Value;
                    i++;
                }
                enchant.ExtraValue = ExtraValue.Text;
                enchant.ID = (int)EnchantID.Value;
                var str = JsonSerializer.Serialize(enchant);
                File.WriteAllText(saveFileDialog1.FileName, str);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnemyAdd_Click(object sender, EventArgs e)
        {
            var enemy = Enemy.Text;
            var value = (float)EnemyProbs.Value;
            EnemyList[enemy] = value;
            UpdateEnemyProbsList();
        }

        private void UpdateEnemyProbsList()
        {
            EnemyProbsList.Items.Clear();
            foreach (var pair in EnemyList)
            {
                var str = string.Format("{0}:{1}", pair.Key, pair.Value);
                EnemyProbsList.Items.Add(str);
            }
        }

        private void EnemyRemove_Click(object sender, EventArgs e)
        {
            EnemyList.Remove(Enemy.Text);
            UpdateEnemyProbsList();
        }

        private void EnemyClear_Click(object sender, EventArgs e)
        {
            EnemyList.Clear();
            UpdateEnemyProbsList();
        }

        private void EffectAdd_Click(object sender, EventArgs e)
        {
            var effect = Effect.Text;
            var value = (float)EffectValue.Value;
            EffectList[effect] = value;
            UpdateEffectValueList();
        }

        private void EffectRemove_Click(object sender, EventArgs e)
        {
            EffectList.Remove(Effect.Text);
            UpdateEffectValueList();
        }

        private void EffectClear_Click(object sender, EventArgs e)
        {
            EffectList.Clear();
            UpdateEffectValueList();
        }

        private void UpdateEffectValueList()
        {
            EffectValuesList.Items.Clear();
            foreach (var pair in EffectList)
            {
                var str = string.Format("{0}:{1}", pair.Key, pair.Value);
                EffectValuesList.Items.Add(str);
            }
        }

        private void EnemyProbsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnemyProbsList.SelectedItems.Count > 0)
            {
                var item = (string)EnemyProbsList.SelectedItems[0];
                var results = Regex.Matches(item, "[^:]+");
                Enemy.SelectedIndex = GetIndex(Enemy, results[0].Value);
                EnemyProbs.Value = decimal.Parse(results[1].Value);
            }
        }

        private int GetIndex(ComboBox box, string str)
        {
            for(int i = 0; i < box.Items.Count; i++)
            {
                var item = box.Items[i];
                if (item.Equals(str))
                {
                    return i;
                }
            }
            throw new Exception("");
        }

        private void EffectValuesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EffectValuesList.SelectedItems.Count > 0)
            {
                var item = (string)EffectValuesList.SelectedItems[0];
                var results = Regex.Matches(item, "[^:]+");
                Effect.SelectedIndex = GetIndex(Effect, results[0].Value);
                EffectValue.Value = decimal.Parse(results[1].Value);
            }
        }
    }
}
