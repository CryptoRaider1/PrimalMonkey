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
            towerModel.GetWeapon().projectile.GetDamageModel().damage =+ 2;
            towerModel.GetWeapon().projectile.ApplyDisplay<SharpRockProjectileDisplay>();
        }
    }

    internal class Spears : ModUpgrade<Monkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 2;

        public override int Cost => 655;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage =+ 1;
            towerModel.GetWeapon().projectile.pierce =+ 1;
            towerModel.GetWeapon().projectile.ApplyDisplay<SpearProjectileDisplay>();
        }
    }

    internal class SlingShot : ModUpgrade<Monkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 3;

        public override int Cost => 1955;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage =+ 4;
            towerModel.range =+ 15;
            towerModel.GetAttackModel().range =+ 15;
            towerModel.GetWeapon().projectile.ApplyDisplay<SlingShotProjectileDisplay>();
        }
    }

    internal class Bow : ModUpgrade<Monkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 4;

        public override int Cost => 5955;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage =+ 3;
            towerModel.GetWeapon().projectile.pierce =+ 3;
            towerModel.range = +15;
            towerModel.GetAttackModel().range =+ 15;
        }
    }

    internal class LongBow : ModUpgrade<Monkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 5;

        public override int Cost => 15955;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.GetDamageModel().damage =+ 9;
            towerModel.GetWeapon().projectile.pierce =+ 6;
            towerModel.range = +15;
            towerModel.GetAttackModel().range =+ 15;
        }
    }
}
