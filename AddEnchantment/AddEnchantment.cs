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
    [BepInPlugin("com.craftopia.mod.AddEnchantment", "AddEnchantment", "2.0.0.0")]
    [BepInDependency("com.craftopia.mod.LibCraftopia", BepInDependency.DependencyFlags.HardDependency)]
    public class AddEnchantment : BaseUnityPlugin
    {

        void Awake()
        {
            this.gameObject.AddComponent<AddEnchantMng>();
        }

        void Start()
        {
            AddEnchantMng.Inst.Add();
        }

        
    }
}
