using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using BepInEx;
using LibCraftopia.Enchant;
using LibCraftopia.Helper;

namespace AddEnchantment
{
    public class AddEnchantMng : SingletonMonoBehaviour<AddEnchantMng>
    {

        public static Action<EnchantParameter, EnchantSetting> CallBack;

        protected override void OnUnityAwake()
        { 
        }

        public void Add()
        {
            var files = SerchFiles();
            List<EnchantSetting> adding = new List<EnchantSetting>();
            foreach (var fileName in files)
            {
                //try
                //{
                var json = ReadFile(fileName);
                var parameter = Parse(json);
                var enchant = Build(parameter);
                adding.Add(enchant);
                CallBack?.Invoke(parameter, enchant);
                //}
                //catch
                //{
                UnityEngine.Debug.Log("Error occuerd in " + fileName);
                //}
            }
            EnchantHelper.Inst.AddEnchant(adding.ToArray());
        }

        private string[] SerchFiles()
        {
            string path = @"BepInEx\plugins\AddEnchant\enchant";
            if (!Directory.Exists(path))
            {
                UnityEngine.Debug.Log("Directory does not exist. Crated new directory");
                Directory.CreateDirectory(path);
            }
            return Directory.GetFiles(path, "*.json", SearchOption.AllDirectories);
        }

        private string ReadFile(string fileName)
        {
            UnityEngine.Debug.Log("reading " + fileName);
            StreamReader sr = new StreamReader(fileName);
            string str = sr.ReadToEnd();
            sr.Close();
            return str;
        }

        private EnchantParameter Parse(string json)
        {
            var p = JsonSerializer.Deserialize<EnchantParameter>(json);
            return p;
        }


        private EnchantSetting Build(EnchantParameter p)
        {
            var enchant = EnchantSetting.Create();
            if (p.ID == 0)
            {
                enchant.NewId();
            }
            else
            {
                enchant.Id(p.ID);
            }
            enchant.LimitedCategoryId(p.Category);
            enchant.Rarity((Oc.Item.EnchantRarity)p.Rarity);
            enchant.ProbInTreasureBox(p.TreassureDrop);
            enchant.ProbInStoneDrop(p.StoneDrop);
            enchant.ProbInTreeDrop(p.TreeDrope);
            enchant.ProbInEnemyDrop(p.SpecifiedEnemyDropID, p.SpecifiedEnemyDropProb);

            if (p.EffectName.Length != p.EffectName.Length)
                throw new Exception("EffectName.Length is not same EffectName.Value");
            for (int i = 0; i < p.EffectName.Length; i++)
            {
                enchant.Effect(p.EffectName[i], p.EffectValue[i]);
            }
            UnityEngine.Debug.Log(p.JapaneseName);
            var displayName = LocalizationHelper.Inst.AddEnchantDisplayName(enchant.AssignedID);
            if (p.JapaneseName != null)
            {
                displayName.Languages[LocalizationHelper.Inst.JapaneseIndex] = p.JapaneseName;
            }
            if (p.EnglishName != null)
            {
                displayName.Languages[LocalizationHelper.Inst.EnglishIndex] = p.EnglishName;
            }
            if (p.ChinseSimplifiedName != null)
            {
                displayName.Languages[LocalizationHelper.Inst.ChineseSimplifiedIndex] = p.ChinseSimplifiedName;
            }
            if (p.ChinseSimplifiedName != null)
            {
                displayName.Languages[LocalizationHelper.Inst.ChineseTraditionalIndex] = p.ChineseTraditionalName;
            }
            return enchant;
        }
    }
}
