using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhiteout
{
    internal enum WhiteoutLocation
    {
        AC_AnglersDen,
        AC_ForemansRetreat,
        AC_HomesteadersRespite,
        BI_Worker_Residence_Cabin,
        BI_CanneryWorkshop,
        BRM_Substation,
        BR_HuntingLodge,
        BR_Maintenance_Shed,
        CH_Jack_Rabbit_House,
        CH_QuonsetGarage,
        DP_Hybernia,
        DP_Lighthouse,
        ML_CampOffice,
        ML_Dam,
        ML_TrappersCabin,
        MT_Church,
        MT_MiltonHouse,
        MT_Orca_Gas_Station,
        MT_ParadiseMeadowsFarmhouse,
        PV_Abandoned_Cache,
        PV_Barn,
        PV_CommunityHall,
        PV_Farmhouse,
        PV_SignalHillRadioControl

        // Missing regions: 
        /*
         * Forlon Muskeg
         * Hushed River Valley
         * Timber Wolf Mountain
         */
    }

    internal enum WhiteoutPreset
    {
        NormalWhiteout,
        Explorer,
        Fisher,
        FisherHard,
        WeaponCollector,
        Hunter,
        HunterHard,
        RopeCollector,
        Nightmare,
        Custom,
    }

    internal enum WhiteoutItem
    {
        None,
        Arrows,
        Ballistic_Vest,
        Bandages,
        Bear_Pelt,
        Bearskin_Bedroll,
        Bearskin_Coat,
        Birch_Bark,
        Bow,
        Can_Opener,
        Cooking_Pot,
        Crampons,
        Deer_Hide,
        Deerskin_Pants,
        Deerskin_Boots,
        Distress_Pistol,
        Distress_Pistol_Ammo,
        Firestriker,
        Fish,
        Fish_Cooked,
        Fishing_Lure,
        Flare,
        Flashlight,
        Hacksaw,
        Hatchet,
        HeavyHammer,
        Insulated_Flask,
        Knife,
        Lantern,
        Magnifying_Lens,
        Matches,
        Milton_Farm_Key,
        Moose_Hide,
        Moose_Hide_Bag,
        Moose_Hide_Cloak,
        Mountaineering_Rope,
        Prybar,
        Rabbit_Pelt,
        Rabbitskin_Mittens,
        Rabbitskin_Hat,
        Reclaimed_Wood,
        Reishi_Tea,
        Revolver,
        Revolver_Cartridges,
        Rifle,
        Rifle_Cartridges,
        Rosehip_Tea,
        Sewing_Kit,
        Skillet,
        Soft_or_Hard_Wood,
        Stick,
        Tinder,
        Toolbox,
        Whetstone,
        Wolfskin_Coat,
        Wolf_Pelt
    }

}
