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
    internal class FasterThrowing : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 355;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.8f;
        }
    }
    internal class EvenFasterThrowing : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 825;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.7f;
        }
    }
    internal class SuperFastThrowing : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 1955;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.6f;
            towerModel.GetWeapon().projectile.ApplyDisplay<RockPiece>();
        }
    }
    internal class RockCrushingSpeed : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 8190;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.6f;
            towerModel.GetWeapon().projectile.ApplyDisplay<CrushedRock>();
        }
    }
    internal class RockDestruction : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 24505;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.6f;
            towerModel.GetWeapon().projectile.ApplyDisplay<RockShard>();
        }
    }
}
