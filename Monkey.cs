﻿using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using PrimalMonkey.Assets;

namespace PrimalMonkey
{
    internal class Monkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Primary;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 245;

        public override int TopPathUpgrades => 5;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 5;

        public override string Description => "A Primal Monkey. Throws the Earth's Feces at You";

        public override string DisplayName => "Primal Monkey";

        public override string Portrait => "PrimalMonkey-Icon";

        public override string Icon => "PrimalMonkey-Icon";

        public override ParagonMode ParagonMode => ParagonMode.Base555;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<PrimalMonkey000Display>();
            towerModel.GetWeapon().projectile.ApplyDisplay<RockProjectileDisplay>();
        }
        public override bool IsValidCrosspath(int[] tiers) => ModHelper.HasMod("UltimateCrosspathing") ? true : base.IsValidCrosspath(tiers);
    }
}
