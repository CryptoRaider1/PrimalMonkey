using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using PrimalMonkey.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;

namespace PrimalMonkey.Upgrades
{
    internal class MiddlePath
    {
    }

    internal class BuildFarms : ModUpgrade<Monkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 400;
        public override string Description => "Builds The Farms";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce =+ 1;
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 1;
        }
    }

    internal class PlantBananas : ModUpgrade<Monkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 2;

        public override int Cost => 800;
        public override string Description => "Plants The Bananas";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce = +1;
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 1;
        }
    }

    internal class CollectBananas : ModUpgrade<Monkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 3;

        public override int Cost => 3200;

        public override string Description => "The Primal Monkey Now Generates 300 Cash Per Round With Revenue From The Bananas";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce = +1;
            var bananaFarmAttackModel = Game.instance.model.GetTowerFromId("BananaFarm-003").GetAttackModel().Duplicate();
            bananaFarmAttackModel.name = "PrimalMonkey_";
            bananaFarmAttackModel.weapons[0].projectile.GetBehavior<CashModel>().maximum = 20;
            bananaFarmAttackModel.weapons[0].projectile.GetBehavior<CashModel>().minimum = 20;
            bananaFarmAttackModel.weapons[0].GetBehavior<EmissionsPerRoundFilterModel>().count = 15;
            towerModel.AddBehavior(bananaFarmAttackModel);
        }
    }
    internal class HigherDemand : ModUpgrade<Monkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 4;
        public override int Cost => 12000;
        public override string Description => "Now Makes 1050 Cash Per Round";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var CashModel = towerModel.GetAttackModel(1).weapons[0].projectile.GetBehavior<CashModel>();
            CashModel.maximum = 70;
            CashModel.minimum = 70;
        }
    }
    internal class ExtremelyHighDemand : ModUpgrade<Monkey>
    {
        public override int Path => MIDDLE;
        public override int Tier => 5;
        public override int Cost => 65000;

        public override string Description => "Now Makes 3500 Cash Per Round";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var CashModel = towerModel.GetAttackModel(1).weapons[0].projectile.GetBehavior<CashModel>();
            CashModel.maximum = 100;
            CashModel.minimum = 100;
            towerModel.GetAttackModel(1).weapons[0].GetBehavior<EmissionsPerRoundFilterModel>().count = 35;
        }
    }
}
