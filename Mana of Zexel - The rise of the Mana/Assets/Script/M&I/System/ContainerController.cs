using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContainerController : MonoBehaviour
{
    public static int DriedLeaves, PureWater, MorningDrop, Wheat, String, Iron, ManaGem, Wood, ScorpionVenom, InfernoSand, ManaLiquid, ManaOre, ManaCrystal, GuardianFeather, FireOre, GoldenFeather, RedManaCrystal, Obsidian, IceOre, IceLeather, BlueManaCrystal, RedManaSlimeBall, BlueManaSlimeBall, ManaCoreFireZexel, ManaCoreIceZexel, Rock, NatureGrass, ManaDust, IceCrystal, HealPotion, ManaPotion, ElixirPotion, Bom, Porridge, ManaCloth, ManaShield, VenomKiller, ManaNecklace, ManaGenerator, Baxiata, BaxiataGem, Photonria, PhotonriaGem, ManaLiquidCatalyst, RedLiquidCatalyst, BlueLiquidCatalyst, ManaCoreFireVayne, ManaCoreIceVayne, PureObsidian, FireManaGenerator, IceManaGenerator, PowderOfLife, HoliHP, HoliMP, UltraBom, ReincarnationLife, FireOfPeace;
    public GameObject BagPanel, DriedLeavesObject, PureWaterObject, MorningDropObject, WheatObject, WoodObject, StringObject, IronObject, ManaGemObject, ScorpionVenomObject, InfernoSandObject, ManaLiquidObject, ManaOreObject, ManaCrystalObject, FireOreObject, GoldenFeatherObject, RedManaCrystalObject, ObsidianObject, RedManaSlimeBallObject, IceOreObject, IceLeatherObject, BlueManaCrystalObject, BlueManaSlimeBallObject, NatureGrassObject, ManaDustObject, RockObject, GuardianFeatherObject, IceCrystalObject, ManaCoreFireZexelObject, ManaCoreIceZexelObject;
    public GameObject HealPotionObject, ManaPotionObject, ElixirPotionObject, BomObject, PorridgeObject, ManaClothObject, ManaShieldObject, VenomKillerObject, ManaNecklaceObject, ManaGeneratorObject, BaxiataObject, BaxiataGemObject, PhotonriaObject, PhotonriaGemObject, ManaLiquidCatalystObject, RedLiquidCatalystObject, BlueLiquidCatalystObject, ManaCoreFireVayneObject, ManaCoreIceVayneObject, PureObsidianObject, FireManaGeneratorObject, IceManaGeneratorObject, PowderOfLifeObject, HoliHPObject, HoliMPObject, UltraBomObject, ReincarnationLifeObject, FireOfPeaceObject;
    public Transform MateBagList, ItemBagList;
    public static int stop, BagStatus;
    public static int DriedLeavesPick, MorningDropPick, PureWaterPick, WheatPick, StringPick, WoodPick, IronPick, ManaGemPick, ScorpionVenomPick, InfernoSandPick, ManaLiquidPick, ManaOrePick, ManaCrystalPick, FireOrePick, GoldenFeatherPick, RedManaCrystalPick, ObsidianPick, RedManaSlimeBallPick, IceOrePick, IceLeatherPick, BlueManaCrystalPick, BlueManaSlimeBallPick, NatureGrassPick, ManaDustPick, RockPick, GuardianFeatherPick, IceCrystalPick, ManaCoreFireZexelPick, ManaCoreIceZexelPick;
    public static int HealPotionPick, ManaPotionPick, ElixirPotionPick, BomPick, PorridgePick, ManaClothPick, ManaShieldPick, VenomKillerPick, ManaNecklacePick, ManaGeneratorPick, BaxiataPick, BaxiataGemPick, PhotonriaPick, PhotonriaGemPick, ManaLiquidCatalystPick, RedLiquidCatalystPick, BlueLiquidCatalystPick, ManaCoreFireVaynePick, ManaCoreIceVaynePick, PureObsidianPick, FireManaGeneratorPick, IceManaGeneratorPick, PowderOfLifePick, HoliHPPick, HoliMPPick, UltraBomPick, ReincarnationLifePick, FireOfPeacePick;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && HubController.BusyHub == false)
        {
            BagPanel.SetActive(true);
            BagStatus = 1;
            HubController.BusyHub = true;
        }

        if (DriedLeavesPick == 1)
        {
            DriedLeavesPick = 0;

            if (DriedLeaves <= 0)
            {
                DriedLeaves += 1;
                Instantiate(DriedLeavesObject, MateBagList);
            }
            else
            {
                DriedLeaves += 1;
            }
        }
        if (MorningDropPick == 1)
        {
            MorningDropPick = 0;

            if (MorningDrop <= 0)
            {
                MorningDrop += 1;
                Instantiate(MorningDropObject, MateBagList);
            }
            else
            {
                MorningDrop += 1;
            }
        }
        if (PureWaterPick == 1)
        {
            PureWaterPick = 0;

            if (PureWater <= 0)
            {
                PureWater += 1;
                Instantiate(PureWaterObject, MateBagList);
            }
            else
            {
                PureWater += 1;
            }
        }
        if (WheatPick == 1)
        {
            WheatPick = 0;

            if (Wheat <= 0)
            {
                Wheat += 1;
                Instantiate(WheatObject, MateBagList);
            }
            else
            {
                Wheat += 1;
            }
        }
        if (WoodPick == 1)
        {
            WoodPick = 0;

            if (Wood <= 0)
            {
                Wood += 1;
                Instantiate(WoodObject, MateBagList);
            }
            else
            {
                Wood += 1;
            }
        }
        if (StringPick == 1)
        {
            StringPick = 0;

            if (String <= 0)
            {
                String += 1;
                Instantiate(StringObject, MateBagList);
            }
            else
            {
                String += 1;
            }
        }
        if (IronPick == 1)
        {
            IronPick = 0;

            if (Iron <= 0)
            {
                Iron += 1;
                Instantiate(IronObject, MateBagList);
            }
            else
            {
                Iron += 1;
            }
        }
        if (ManaGemPick == 1)
        {
            ManaGemPick = 0;

            if (ManaGem <= 0)
            {
                ManaGem += 1;
                Instantiate(ManaGemObject, MateBagList);
            }
            else
            {
                ManaGem += 1;
            }
        }
        if (ScorpionVenomPick == 1)
        {
            ScorpionVenomPick = 0;

            if (ScorpionVenom <= 0)
            {
                ScorpionVenom += 1;
                Instantiate(ScorpionVenomObject, MateBagList);
            }
            else
            {
                ScorpionVenom += 1;
            }
        }
        if (InfernoSandPick == 1)
        {
            InfernoSandPick = 0;

            if (InfernoSand <= 0)
            {
                InfernoSand += 1;
                Instantiate(InfernoSandObject, MateBagList);
            }
            else
            {
                InfernoSand += 1;
            }
        }
        if (ManaLiquidPick == 1)
        {
            ManaLiquidPick = 0;

            if (ManaLiquid <= 0)
            {
                ManaLiquid += 1;
                Instantiate(ManaLiquidObject, MateBagList);
            }
            else
            {
                ManaLiquid += 1;
            }
        }
        if (ManaOrePick == 1)
        {
            ManaOrePick = 0;

            if (ManaOre <= 0)
            {
                ManaOre += 1;
                Instantiate(ManaOreObject, MateBagList);
            }
            else
            {
                ManaOre += 1;
            }
        }
        if (ManaCrystalPick == 1)
        {
            ManaCrystalPick = 0;

            if (ManaCrystal <= 0)
            {
                ManaCrystal += 1;
                Instantiate(ManaCrystalObject, MateBagList);
            }
            else
            {
                ManaCrystal += 1;
            }
        }
        if (FireOrePick == 1)
        {
            FireOrePick = 0;

            if (FireOre <= 0)
            {
                FireOre += 1;
                Instantiate(FireOreObject, MateBagList);
            }
            else
            {
                FireOre += 1;
            }
        }
        if (GoldenFeatherPick == 1)
        {
            GoldenFeatherPick = 0;

            if (GoldenFeather <= 0)
            {
                GoldenFeather += 1;
                Instantiate(GoldenFeatherObject, MateBagList);
            }
            else
            {
                GoldenFeather += 1;
            }
        }
        if (ObsidianPick == 1)
        {
            ObsidianPick = 0;

            if (Obsidian <= 0)
            {
                Obsidian += 1;
                Instantiate(ObsidianObject, MateBagList);
            }
            else
            {
                Obsidian += 1;
            }
        }
        if (RedManaSlimeBallPick == 1)
        {
            RedManaSlimeBallPick = 0;

            if (RedManaSlimeBall <= 0)
            {
                RedManaSlimeBall += 1;
                Instantiate(RedManaSlimeBallObject, MateBagList);
            }
            else
            {
                RedManaSlimeBall += 1;
            }
        }
        if (RedManaCrystalPick == 1)
        {
            RedManaCrystalPick = 0;

            if (RedManaCrystal <= 0)
            {
                RedManaCrystal += 1;
                Instantiate(RedManaCrystalObject, MateBagList);
            }
            else
            {
                RedManaCrystal += 1;
            }
        }
        if (IceOrePick == 1)
        {
            IceOrePick = 0;

            if (IceOre <= 0)
            {
                IceOre += 1;
                Instantiate(IceOreObject, MateBagList);
            }
            else
            {
                IceOre += 1;
            }
        }
        if (IceLeatherPick == 1)
        {
            IceLeatherPick = 0;

            if (IceLeather <= 0)
            {
                IceLeather += 1;
                Instantiate(IceLeatherObject, MateBagList);
            }
            else
            {
                IceLeather += 1;
            }
        }
        if (BlueManaCrystalPick == 1)
        {
            BlueManaCrystalPick = 0;

            if (BlueManaCrystal <= 0)
            {
                BlueManaCrystal += 1;
                Instantiate(BlueManaCrystalObject, MateBagList);
            }
            else
            {
                BlueManaCrystal += 1;
            }
        }
        if (NatureGrassPick == 1)
        {
            NatureGrassPick = 0;

            if (NatureGrass <= 0)
            {
                NatureGrass += 1;
                Instantiate(NatureGrassObject, MateBagList);
            }
            else
            {
                NatureGrass += 1;
            }
        }
        if (ManaDustPick == 1)
        {
            ManaDustPick = 0;

            if (ManaDust <= 0)
            {
                ManaDust += 1;
                Instantiate(ManaDustObject, MateBagList);
            }
            else
            {
                ManaDust += 1;
            }
        }
        if (RockPick == 1)
        {
            RockPick = 0;

            if (Rock <= 0)
            {
                Rock += 1;
                Instantiate(RockObject, MateBagList);
            }
            else
            {
                Rock += 1;
            }
        }
        if (GuardianFeatherPick == 1)
        {
            GuardianFeatherPick = 0;

            if (GuardianFeather <= 0)
            {
                GuardianFeather += 1;
                Instantiate(GuardianFeatherObject, MateBagList);
            }
            else
            {
                GuardianFeather += 1;
            }
        }
        if (IceCrystalPick == 1)
        {
            IceCrystalPick = 0;

            if (IceCrystal <= 0)
            {
                IceCrystal += 1;
                Instantiate(IceCrystalObject, MateBagList);
            }
            else
            {
                IceCrystal += 1;
            }
        }
        if (ManaCoreFireZexelPick == 1)
        {
            ManaCoreFireZexelPick = 0;

            if (ManaCoreFireZexel <= 0)
            {
                ManaCoreFireZexel += 1;
                Instantiate(ManaCoreFireZexelObject, MateBagList);
            }
            else
            {
                ManaCoreFireZexel += 1;
            }
        }
        if (ManaCoreIceZexelPick == 1)
        {
            ManaCoreIceZexelPick = 0;

            if (ManaCoreIceZexel <= 0)
            {
                ManaCoreIceZexel += 1;
                Instantiate(ManaCoreIceZexelObject, MateBagList);
            }
            else
            {
                ManaCoreIceZexel += 1;
            }
        }

        //Item
        if (HealPotionPick == 1)
        {
            HealPotionPick = 0;

            if (HealPotion <= 0)
            {
                HealPotion += 1;
                Instantiate(HealPotionObject, ItemBagList);
            }
            else
            {
                HealPotion += 1;
            }
        }
        if (ManaPotionPick == 1)
        {
            ManaPotionPick = 0;

            if (ManaPotion <= 0)
            {
                ManaPotion += 1;
                Instantiate(ManaPotionObject, ItemBagList);
            }
            else
            {
                ManaPotion += 1;
            }
        }
        if (ElixirPotionPick == 1)
        {
            ElixirPotionPick = 0;

            if (ElixirPotion <= 0)
            {
                ElixirPotion += 1;
                Instantiate(ElixirPotionObject, ItemBagList);
            }
            else
            {
                ElixirPotion += 1;
            }
        }
        if (BomPick == 1)
        {
            BomPick = 0;

            if (Bom <= 0)
            {
                Bom += 1;
                Instantiate(BomObject, ItemBagList);
            }
            else
            {
                Bom += 1;
            }
        }
        if (PorridgePick == 1)
        {
            PorridgePick = 0;

            if (Porridge <= 0)
            {
                Porridge += 1;
                Instantiate(PorridgeObject, ItemBagList);
            }
            else
            {
                Porridge += 1;
            }
        }
        if (ManaClothPick == 1)
        {
            ManaClothPick = 0;

            if (ManaCloth <= 0)
            {
                ManaCloth += 1;
                Instantiate(ManaClothObject, ItemBagList);
            }
            else
            {
                ManaCloth += 1;
            }
        }
        if (ManaShieldPick == 1)
        {
            ManaShieldPick = 0;

            if (ManaShield <= 0)
            {
                ManaShield += 1;
                Instantiate(ManaShieldObject, ItemBagList);
            }
            else
            {
                ManaShield += 1;
            }
        }
        if (VenomKillerPick == 1)
        {
            VenomKillerPick = 0;

            if (VenomKiller <= 0)
            {
                VenomKiller += 1;
                Instantiate(VenomKillerObject, ItemBagList);
            }
            else
            {
                VenomKiller += 1;
            }
        }
        if (ManaNecklacePick == 1)
        {
            ManaNecklacePick = 0;

            if (ManaNecklace <= 0)
            {
                ManaNecklace += 1;
                Instantiate(ManaNecklaceObject, ItemBagList);
            }
            else
            {
                ManaNecklace += 1;
            }
        }
        if (ManaGeneratorPick == 1)
        {
            ManaGeneratorPick = 0;

            if (ManaGenerator <= 0)
            {
                ManaGenerator += 1;
                Instantiate(ManaGeneratorObject, ItemBagList);
            }
            else
            {
                ManaGenerator += 1;
            }
        }
        if (BaxiataPick == 1)
        {
            BaxiataPick = 0;

            if (Baxiata <= 0)
            {
                Baxiata += 1;
                Instantiate(BaxiataObject, ItemBagList);
            }
            else
            {
                Baxiata += 1;
            }
        }
        if (BaxiataGemPick == 1)
        {
            BaxiataGemPick = 0;

            if (BaxiataGem <= 0)
            {
                BaxiataGem += 1;
                Instantiate(BaxiataGemObject, ItemBagList);
            }
            else
            {
                BaxiataGem += 1;
            }
        }
        if (PhotonriaPick == 1)
        {
            PhotonriaPick = 0;

            if (Photonria <= 0)
            {
                Photonria += 1;
                Instantiate(PhotonriaObject, ItemBagList);
            }
            else
            {
                Photonria += 1;
            }
        }
        if (PhotonriaGemPick == 1)
        {
            PhotonriaGemPick = 0;

            if (PhotonriaGem <= 0)
            {
                PhotonriaGem += 1;
                Instantiate(PhotonriaGemObject, ItemBagList);
            }
            else
            {
                PhotonriaGem += 1;
            }
        }
        if (ManaLiquidCatalystPick == 1)
        {
            ManaLiquidCatalystPick = 0;

            if (ManaLiquidCatalyst <= 0)
            {
                ManaLiquidCatalyst += 1;
                Instantiate(ManaLiquidCatalystObject, ItemBagList);
            }
            else
            {
                ManaLiquidCatalyst += 1;
            }
        }
        if (RedLiquidCatalystPick == 1)
        {
            RedLiquidCatalystPick = 0;

            if (RedLiquidCatalyst <= 0)
            {
                RedLiquidCatalyst += 1;
                Instantiate(RedLiquidCatalystObject, ItemBagList);
            }
            else
            {
                RedLiquidCatalyst += 1;
            }
        }
        if (BlueLiquidCatalystPick == 1)
        {
            BlueLiquidCatalystPick = 0;

            if (BlueLiquidCatalyst <= 0)
            {
                BlueLiquidCatalyst += 1;
                Instantiate(BlueLiquidCatalystObject, ItemBagList);
            }
            else
            {
                BlueLiquidCatalyst += 1;
            }
        }
        if (ManaCoreFireVaynePick == 1)
        {
            ManaCoreFireVaynePick = 0;

            if (ManaCoreFireVayne <= 0)
            {
                ManaCoreFireVayne += 1;
                Instantiate(ManaCoreFireVayneObject, ItemBagList);
            }
            else
            {
                ManaCoreFireVayne += 1;
            }
        }
        if (ManaCoreIceVaynePick == 1)
        {
            ManaCoreIceVaynePick = 0;

            if (ManaCoreIceVayne <= 0)
            {
                ManaCoreIceVayne += 1;
                Instantiate(ManaCoreIceVayneObject, ItemBagList);
            }
            else
            {
                ManaCoreIceVayne += 1;
            }
        }
        if (PureObsidianPick == 1)
        {
            PureObsidianPick = 0;

            if (PureObsidian <= 0)
            {
                PureObsidian += 1;
                Instantiate(PureObsidianObject, ItemBagList);
            }
            else
            {
                PureObsidian += 1;
            }
        }
        if (FireManaGeneratorPick == 1)
        {
            FireManaGeneratorPick = 0;

            if (FireManaGenerator <= 0)
            {
                FireManaGenerator += 1;
                Instantiate(FireManaGeneratorObject, ItemBagList);
            }
            else
            {
                FireManaGenerator += 1;
            }
        }
        if (IceManaGeneratorPick == 1)
        {
            IceManaGeneratorPick = 0;

            if (IceManaGenerator <= 0)
            {
                IceManaGenerator += 1;
                Instantiate(IceManaGeneratorObject, ItemBagList);
            }
            else
            {
                IceManaGenerator += 1;
            }
        }
        if (PowderOfLifePick == 1)
        {
            PowderOfLifePick = 0;

            if (PowderOfLife <= 0)
            {
                PowderOfLife += 1;
                Instantiate(PowderOfLifeObject, ItemBagList);
            }
            else
            {
                PowderOfLife += 1;
            }
        }
        if (HoliHPPick == 1)
        {
            HoliHPPick = 0;

            if (HoliHP <= 0)
            {
                HoliHP += 1;
                Instantiate(HoliHPObject, ItemBagList);
            }
            else
            {
                HoliHP += 1;
            }
        }
        if (HoliMPPick == 1)
        {
            HoliMPPick = 0;

            if (HoliMP <= 0)
            {
                HoliMP += 1;
                Instantiate(HoliMPObject, ItemBagList);
            }
            else
            {
                HoliMP += 1;
            }
        }
        if (UltraBomPick == 1)
        {
            UltraBomPick = 0;

            if (UltraBom <= 0)
            {
                UltraBom += 1;
                Instantiate(UltraBomObject, ItemBagList);
            }
            else
            {
                UltraBom += 1;
            }
        }
        if (ReincarnationLifePick == 1)
        {
            ReincarnationLifePick = 0;

            if (ReincarnationLife <= 0)
            {
                ReincarnationLife += 1;
                Instantiate(ReincarnationLifeObject, ItemBagList);
            }
            else
            {
                ReincarnationLife += 1;
            }
        }
        if (FireOfPeacePick == 1)
        {
            FireOfPeacePick = 0;

            if (FireOfPeace <= 0)
            {
                FireOfPeace += 1;
                Instantiate(FireOfPeaceObject, ItemBagList);
            }
            else
            {
                FireOfPeace += 1;
            }
        }
    }

    public void Back4()
    {
        BagPanel.SetActive(false);
        BagStatus = 0;
        HubController.BusyHub = false;
    }
}
