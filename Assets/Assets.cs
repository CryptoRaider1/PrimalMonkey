using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Unity.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalMonkey.Assets
{
    public class PrimalMonkey000Display : ModDisplay2D
    {
        protected override string TextureName => "PrimalMonkey000";
    }

    public class RockProjectileDisplay : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "Rock");
        }
    }

    public class SharpRockProjectileDisplay : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "SharpRock");
        }
    }

    public class SpearProjectileDisplay : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "Spear");
        }
    }

    public class SlingShotProjectileDisplay : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "Slingshot");
        }
    }


}
