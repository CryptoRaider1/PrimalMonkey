using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using PrimalMonkey.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalMonkey
{
    internal class Monkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Primary;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 245;

        public override int TopPathUpgrades => 0;

        public override int MiddlePathUpgrades => 0;

        public override int BottomPathUpgrades => 0;

        public override string Description => "A Primal Monkey. Throws the Earth's Feces at You";

        public override string DisplayName => "Primal Monkey";

        public override string Portrait => "PrimalMonkey-Icon";

        public override string Icon => "PrimalMonkey-Icon";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<PrimalMonkey000Display>();
            towerModel.GetWeapon().projectile.ApplyDisplay<RockProjectileDisplay>();
        }
    }
}
