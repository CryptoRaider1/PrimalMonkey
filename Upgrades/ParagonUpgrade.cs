using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalMonkey.Upgrades
{
    internal class ParagonUpgrade : ModParagonUpgrade<Monkey>
    {
        public override int Cost => 1567520;

        public override string DisplayName => "Hunters & Gatherers";

        public override string Description => "Makes BIG Money + Does A Lotta Damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var BananaFarmWeaponModel = towerModel.GetAttackModel(1).weapons[0];
            BananaFarmWeaponModel.projectile.GetBehavior<CashModel>().maximum = 50000;
            BananaFarmWeaponModel.projectile.GetBehavior<CashModel>().minimum = 45000;
            BananaFarmWeaponModel.GetBehavior<EmissionsPerRoundFilterModel>().count = 3;

            var PrimalMonkeyWeaponModel = towerModel.GetWeapon(0);
            PrimalMonkeyWeaponModel.projectile.GetDamageModel().damage += 75;
            PrimalMonkeyWeaponModel.projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
            PrimalMonkeyWeaponModel.rate *= 0.01f;
            towerModel.range = 120;
            towerModel.GetAttackModel(0).range = towerModel.range;
            PrimalMonkeyWeaponModel.projectile.pierce += 50;
            PrimalMonkeyWeaponModel.emission = new ArcEmissionModel("Emission", 25, 0, 35, null, false, false);
        }
    }
}
