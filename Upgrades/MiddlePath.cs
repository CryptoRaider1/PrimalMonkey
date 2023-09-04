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
    internal class MiddlePath
    {
    }

    internal class BuildFarms : ModUpgrade<Monkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 400;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce =+ 1;
        }
    }

    internal class PlantBananas : ModUpgrade<Monkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 2;

        public override int Cost => 800;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce = +1;
        }
    }
}
