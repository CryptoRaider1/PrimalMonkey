using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using PrimalMonkey.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalMonkey.Upgrades
{
    internal class BottomPath
    {
    }

    internal class SharperRocks : ModUpgrade<Monkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 155;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage = +1;
            towerModel.GetWeapon().projectile.ApplyDisplay<SharpRockProjectileDisplay>();
        }
    }

    internal class Spears : ModUpgrade<Monkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 355;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage =+ 1;
            towerModel.GetWeapon().projectile.pierce =+ 1;
            towerModel.GetWeapon().projectile.ApplyDisplay<SpearProjectileDisplay>();
        }
    }
}
