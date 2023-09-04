using MelonLoader;
using BTD_Mod_Helper;
using PrimalMonkey;

[assembly: MelonInfo(typeof(PrimalMonkey.PrimalMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.Authors)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace PrimalMonkey;

public class PrimalMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<PrimalMonkey>("PrimalMonkey loaded!");
    }
}