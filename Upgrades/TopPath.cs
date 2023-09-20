using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
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

        public override string Description => "Primal Monkey Throws Faster";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.8f;
            towerModel.GetWeapon().projectile.pierce = +1;
        }
    }
    internal class EvenFasterThrowing : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 825;

        public override string Description => "Primal Monkey Throws Even Faster";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.7f;
            towerModel.GetWeapon().projectile.pierce = +3;
        }
    }
    internal class SuperFastThrowing : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 1955;

        public override string Description => "Primal Monkey Throws so Fast The Rock Starts to Break";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.6f;
            towerModel.GetWeapon().projectile.ApplyDisplay<RockPiece>();
            towerModel.GetWeapon().emission = new ArcEmissionModel("Emission", 2, 0, 15, null, false, false);
        }
    }
    internal class RockCrushingSpeed : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 8190;

        public override string Description => "The Rocks Are Thrown so Hard it Breaks Into Multiple Pieces";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.6f;
            towerModel.GetWeapon().projectile.ApplyDisplay<CrushedRock>();
            towerModel.GetWeapon().emission = new ArcEmissionModel("Emission", 4, 0, 15, null, false, false);
        }
    }
    internal class RockDestruction : ModUpgrade<Monkey>
    {
        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 24505;

        public override string Description => "Small Pieces of Rocks Are Now Thrown From The Primal Monkey Because of The Intense Speed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.6f;
            towerModel.GetWeapon().projectile.ApplyDisplay<RockShard>();
            towerModel.GetWeapon().emission = new ArcEmissionModel("Emission", 20, 0, 15, null, false, false);
        }
    }
}
