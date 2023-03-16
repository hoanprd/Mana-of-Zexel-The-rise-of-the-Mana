using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject LoadGamePanel, SettingPanel, GameSetting, GraphicSetting, SoundSetting, GameSettingButton, GraphicSettingButton, SoundSettingButton;
    public Text DifficultChooseText, PlotLangueChooseText;
    public Text showdata1;
    public Text showdata2;
    public Text showdata3;

    public static bool LoadGameCheck;

    void Start()
    {
        LoadGameCheck = false;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("SaveGameD1") == 1)
            showdata1.text = "Data Save!";
        else
            showdata1.text = "No Data!";
        if (PlayerPrefs.GetInt("SaveGameD2") == 1)
            showdata2.text = "Data Save!";
        else
            showdata2.text = "No Data!";
        if (PlayerPrefs.GetInt("SaveGameD3") == 1)
            showdata3.text = "Data Save!";
        else
            showdata3.text = "No Data!";
    }
    public void PressStartNewGame()
    {
        //Set date
        DateController.StartGlobalTime = true;

        //SetMapIndex
        Player.MapIndex = 0;

        //Set weapon
        Global.VayneStaff1 = 0;
        Global.VayneStaff2 = 0;
        Global.VayneStaff3 = 0;
        Global.AliaShoes1 = 0;
        Global.AliaShoes2 = 0;
        Global.AliaShoes3 = 0;
        Global.MariaCrystal1 = 0;
        Global.MariaCrystal2 = 0;
        Global.MariaCrystal3 = 0;
        Global.AlchemistArmor1 = 0;
        Global.AlchemistArmor2 = 0;
        Global.AlchemistArmor3 = 0;
        Global.WarriorArmor1 = 0;
        Global.WarriorArmor2 = 0;
        Global.WarriorArmor3 = 0;

        //Set cut
        CutscenesController.cus1 = 0;
        CutscenesController.cus2 = 0;
        CutscenesController.cus3 = 0;
        CutscenesController.cus4 = 0;
        CutscenesController.cus5 = 0;
        CutscenesController.cus6 = 0;
        CutscenesController.cus7 = 0;
        CutscenesController.cus8 = 0;
        CutscenesController.cus9 = 0;
        CutscenesController.cus10 = 0;
        CutscenesController.cus11 = 0;
        CutscenesController.cus12 = 0;
        CutscenesController.cus13 = 0;
        CutscenesController.cus14 = 0;
        CutscenesController.cus15 = 0;
        CutscenesController.cus16 = 0;
        CutscenesController.cus17 = 0;
        CutscenesController.cus18 = 0;
        CutscenesController.cus19 = 0;
        CutscenesController.cus20 = 0;
        CutscenesController.cus21 = 0;
        CutscenesController.cus22 = 0;
        CutscenesController.cus23 = 0;
        CutscenesController.cus24 = 0;
        CutscenesController.cus25 = 0;
        CutscenesController.cus26 = 0;
        CutscenesController.cus27 = 0;
        CutscenesController.cus28 = 0;
        CutscenesController.cus29 = 0;
        CutscenesController.cus30 = 0;
        CutscenesController.cus31 = 0;
        CutscenesController.cus32 = 0;
        CutscenesController.cus33 = 0;
        CutscenesController.cus34 = 0;
        CutscenesController.cus35 = 0;
        CutscenesController.cus36 = 0;
        CutscenesController.cus37 = 0;
        CutscenesController.cus38 = 0;
        CutscenesController.cus39 = 0;
        CutscenesController.cus40 = 0;
        CutscenesController.cus41 = 0;
        CutscenesController.cus42 = 0;
        CutscenesController.cus43 = 0;
        CutscenesController.cus44 = 0;
        CutscenesController.cus45 = 0;
        CutscenesController.cus46 = 0;
        CutscenesController.cus47 = 0;
        CutscenesController.cus48 = 0;
        CutscenesController.cus49 = 0;
        CutscenesController.cus50 = 0;
        CutscenesController.cus51 = 0;
        CutscenesController.cus52 = 0;
        CutscenesController.cus53 = 0;
        CutscenesController.cus54 = 0;
        CutscenesController.cus55 = 0;
        CutscenesController.cus56 = 0;
        CutscenesController.cus57 = 0;
        CutscenesController.cus58 = 0;
        CutscenesController.cus59 = 0;
        CutscenesController.cus60 = 0;
        CutscenesController.cus61 = 0;
        CutscenesController.cus62 = 0;
        CutscenesController.cus63 = 0;
        CutscenesController.cus64 = 0;
        CutscenesController.cus65 = 0;
        CutscenesController.cus66 = 0;
        CutscenesController.cus67 = 0;
        CutscenesController.cus68 = 0;
        CutscenesController.cus69 = 0;
        CutscenesController.cus70 = 0;
        CutscenesController.cus71 = 0;
        CutscenesController.cus72 = 0;
        CutscenesController.cus73 = 0;
        CutscenesController.cus74 = 0;
        CutscenesController.cus75 = 0;
        CutscenesController.cus76 = 0;
        CutscenesController.cus77 = 0;
        CutscenesController.cus78 = 0;
        CutscenesController.cus79 = 0;
        CutscenesController.cus80 = 0;
        CutscenesController.cus81 = 0;
        CutscenesController.cus82 = 0;
        CutscenesController.cus83 = 0;
        CutscenesController.cus84 = 0;
        CutscenesController.cus85 = 0;
        CutscenesController.cus86 = 0;
        CutscenesController.cus87 = 0;
        CutscenesController.cus88 = 0;
        CutscenesController.cus89 = 0;
        CutscenesController.cus90 = 0;
        CutscenesController.cus91 = 0;
        CutscenesController.cus92 = 0;
        CutscenesController.cus93 = 0;
        CutscenesController.cus94 = 0;
        CutscenesController.cus95 = 0;
        CutscenesController.cus96 = 0;
        CutscenesController.cus97 = 0;
        CutscenesController.cus98 = 0;
        CutscenesController.cus99 = 0;
        CutscenesController.cus100 = 0;
        CutscenesController.cus101 = 0;
        CutscenesController.cus102 = 0;
        CutscenesController.cus103 = 0;
        CutscenesController.cus104 = 0;
        CutscenesController.cus105 = 0;
        CutscenesController.cus106 = 0;
        CutscenesController.cus107 = 0;
        CutscenesController.cus108 = 0;
        CutscenesController.cus109 = 0;
        CutscenesController.cus110 = 0;
        CutscenesController.cus111 = 0;
        CutscenesController.cus112 = 0;
        CutscenesController.cus113 = 0;
        CutscenesController.cus114 = 0;
        CutscenesController.cus115 = 0;
        CutscenesController.cus116 = 0;
        CutscenesController.cus117 = 0;
        CutscenesController.cus118 = 0;
        CutscenesController.cus119 = 0;
        CutscenesController.cus120 = 0;


        //Set quest
        GlobalQuest.KillGoblinQuest = 0;
        GlobalQuest.HelpVillagerStop1 = 0;
        GlobalQuest.HelpVillagerStop2 = 0;
        GlobalQuest.HelpVillagerStop3 = 0;
        GlobalQuest.HelpVillagerDone = 0;
        CutscenesTrigger.PorridgeSyn = 0;
        CutscenesTrigger.BomSyn = 0;
        CutscenesTrigger.GolemnKill = 0;
        CutscenesTrigger.InfernoScorpionKill = 0;
        CutscenesTrigger.InfernoScorpionKillP2 = 0;
        CutscenesTrigger.IceFangKill = 0;
        CutscenesTrigger.GoblinKillP2 = 0;
        CutscenesTrigger.GolemnKillP2 = 0;

        //Set point
        PlayerPrefs.SetFloat("x", 2);
        PlayerPrefs.SetFloat("y", 1);
        PlayerPrefs.SetFloat("z", 0);

        //Set Vayne
        Global.CurHPP1 = 100;
        Global.MaxHPP1 = 100;
        Global.CurMPP1 = 50;
        Global.MaxMPP1 = 50;
        Global.DamageP1 = 10;
        Global.SpeedP1 = 20;
        Global.LevelP1 = 1;
        Global.MaxEXPP1 = 40;
        Global.CurEXPP1 = 0;

        Global.PlusPointP1 = 1;

        /*Global.CurHPP1 = 1200;
        Global.MaxHPP1 = 1200;
        Global.CurMPP1 = 170;
        Global.MaxMPP1 = 170;
        Global.DamageP1 = 410;
        Global.SpeedP1 = 30;
        Global.LevelP1 = 30;
        Global.MaxEXPP1 = 40;
        Global.CurEXPP1 = 0;*/

        //Set Alia
        Global.CurHPP2 = 60;
        Global.MaxHPP2 = 60;
        Global.CurMPP2 = 32;
        Global.MaxMPP2 = 32;
        Global.DamageP2 = 15;
        Global.SpeedP2 = 30;
        Global.LevelP2 = 2;
        Global.MaxEXPP2 = 80;
        Global.CurEXPP2 = 0;

        Global.PlusPointP2 = 2;

        /*Global.CurHPP2 = 840;
        Global.MaxHPP2 = 840;
        Global.CurMPP2 = 121;
        Global.MaxMPP2 = 121;
        Global.DamageP2 = 450;
        Global.SpeedP2 = 40;
        Global.LevelP2 = 30;
        Global.MaxEXPP2 = 80;
        Global.CurEXPP2 = 0;*/

        //Set Maria
        Global.CurHPP3 = 235;
        Global.MaxHPP3 = 235;
        Global.CurMPP3 = 85;
        Global.MaxMPP3 = 85;
        Global.DamageP3 = 60;
        Global.SpeedP3 = 15;
        Global.LevelP3 = 5;
        Global.MaxEXPP3 = 200;
        Global.CurEXPP3 = 0;

        Global.PlusPointP3 = 5;

        Global.CurHPP3 = 1360;
        Global.MaxHPP3 = 1360;
        Global.CurMPP3 = 220;
        Global.MaxMPP3 = 220;
        Global.DamageP3 = 410;
        Global.SpeedP3 = 20;
        Global.LevelP3 = 30;
        Global.MaxEXPP3 = 200;
        Global.CurEXPP3 = 0;

        //Set Zen
        Global.Zen = 0;

        //Set item material
        ContainerController.DriedLeaves = 0;
        ContainerController.PureWater = 0;
        ContainerController.MorningDrop = 0;
        ContainerController.Wheat = 0;
        ContainerController.Wood = 0;
        ContainerController.String = 0;
        ContainerController.Iron = 0;
        ContainerController.ManaGem = 0;
        ContainerController.ScorpionVenom = 0;
        ContainerController.InfernoSand = 0;
        ContainerController.ManaLiquid = 0;
        ContainerController.ManaOre = 0;
        ContainerController.ManaCrystal = 0;
        ContainerController.GuardianFeather = 0;
        ContainerController.FireOre = 0;
        ContainerController.GoldenFeather = 0;
        ContainerController.RedManaCrystal = 0;
        ContainerController.Obsidian = 0;
        ContainerController.IceOre = 0;
        ContainerController.IceLeather = 0;
        ContainerController.BlueManaCrystal = 0;
        ContainerController.RedManaSlimeBall = 0;
        ContainerController.BlueManaSlimeBall = 0;
        ContainerController.ManaCoreFireZexel = 0;
        ContainerController.ManaCoreIceZexel = 0;
        ContainerController.Rock = 0;
        ContainerController.NatureGrass = 0;
        ContainerController.ManaDust = 0;
        ContainerController.ManaEagleFeather = 0;
        ContainerController.IceCrystal = 0;

        //Set item
        ContainerController.HealPotion = 0;
        ContainerController.ManaPotion = 0;
        ContainerController.ElixirPotion = 0;
        ContainerController.Bom = 0;
        ContainerController.Porridge = 0;
        ContainerController.ManaCloth = 0;
        ContainerController.ManaShield = 0;
        ContainerController.VenomKiller = 0;
        ContainerController.ManaNecklace = 0;
        ContainerController.ManaGenerator = 0;
        ContainerController.Baxiata = 0;
        ContainerController.BaxiataGem = 0;
        ContainerController.Photonria = 0;
        ContainerController.PhotonriaGem = 0;
        ContainerController.ManaLiquidCatalyst = 0;
        ContainerController.RedLiquidCatalyst = 0;
        ContainerController.BlueLiquidCatalyst = 0;
        ContainerController.ManaCoreFireVayne = 0;
        ContainerController.ManaCoreIceVayne = 0;
        ContainerController.PureObsidian = 0;
        ContainerController.FireManaGenerator = 0;
        ContainerController.IceManaGenerator = 0;
        ContainerController.PowderOfLife = 0;
        ContainerController.HoliHP = 0;
        ContainerController.HoliMP = 0;
        ContainerController.UltraBom = 0;
        ContainerController.ReincarnationLife = 0;
        ContainerController.FireOfPeace = 0;
        ContainerController.OmnipotentBoundary = 0;

        //Set weapon had bought
        WeaponStoreController.Bought1 = 0;
        WeaponStoreController.Bought2 = 0;
        WeaponStoreController.Bought3 = 0;
        WeaponStoreController.Bought4 = 0;
        WeaponStoreController.Bought5 = 0;
        WeaponStoreController.Bought6 = 0;
        WeaponStoreController.Bought7 = 0;
        WeaponStoreController.Bought8 = 0;
        WeaponStoreController.Bought9 = 0;
        WeaponStoreController.Bought10 = 0;
        WeaponStoreController.Bought11 = 0;
        WeaponStoreController.Bought12 = 0;
        WeaponStoreController.Bought13 = 0;
        WeaponStoreController.Bought14 = 0;
        WeaponStoreController.Bought15 = 0;

        //Set map posi
        MapController.WishingHillToZexelTown = false;
        MapController.ZexelTownToTavern = false;
        MapController.TavernToSaveRoom = false;
        MapController.ZexelTownToWishingForest = false;
        MapController.ZexelTownToInfernoDesert = false;
        MapController.ZexelTownToWishingHill = false;
        MapController.TavernToZexelTown = false;
        MapController.SaveRoomToTavern = false;
        MapController.WishingForestToZexelTown = false;
        MapController.InfernoDesertToZexelTown = false;
        MapController.InfernoDesertToZexelGate = false;
        MapController.ZexelGateToInfernoDesert = false;
        MapController.InfernoDesertToManaGate = false;
        MapController.ManaGateToInfernoDesert = false;
        MapController.InfernoDesertToInfernoVolcano = false;
        MapController.InfernoVolcanoToInfernoDesert = false;
        MapController.InfernoDesertToInfernoIce = false;
        MapController.InfernoIceToInfernoDesert = false;
        MapController.InfernoDesertToManaCliff = false;
        MapController.ManaCliffToInfernoDesert = false;
        MapController.ManaGateToManaDimension = false;
        MapController.ManaDimensionToManaGate = false;
        MapController.ManaDimensionToManaTemple = false;
        MapController.ManaTempleToManaDimension = false;
        MapController.InfernoVolcanoToInsideVolcanoCave = false;
        MapController.InsideVolcanoCaveToInfernoVolcano = false;
        MapController.InfernoVolcanoToAltaInferno = false;
        MapController.AltaInfernoToInfernoVolcano = false;
        MapController.InfernoIceToInsideIceCave = false;
        MapController.InsideIceCaveToInfernoIce = false;
        MapController.InfernoIceToAltaInferno = false;
        MapController.AltaInfernoToInfernoIce = false;
        MapController.ZexelGateToZexelTemple = false;
        MapController.ZexelTempleToZexelGate = false;

        //Set ManaSynthesize
        SynthesizeSystem.ManaSynthesize = 100;
        SynthesizeSystem.ManaFireSynthesize = 100;
        SynthesizeSystem.ManaIceSynthesize = 100;

        SceneManager.LoadScene("Cutscenes");
        //SceneManager.LoadScene("BSBlueManaSlime 1");
    }

    public void PressLoadGame()
    {
        LoadGamePanel.SetActive(true);
    }

    public void PressLoadGameData1()
    {
        if (PlayerPrefs.GetInt("SaveGameD1") == 1)
        {
            LoadGameCheck = true;

            //Load map
            Player.MapIndex = 1;

            //Load date
            DateController.GlobalDayNight = PlayerPrefs.GetInt("SaveGlobalDayNightD1");
            DateController.GlobalTime = PlayerPrefs.GetFloat("SaveGlobalTimeD1");
            DateController.GlobalUpHour = PlayerPrefs.GetInt("SaveGlobalUpHourD1");
            DateController.GlobalPHour = PlayerPrefs.GetInt("SaveGlobalPHourD1");
            DateController.GlobalDownHour = PlayerPrefs.GetInt("SaveGlobalDownHourD1");

            CutscenesController.cus1 = PlayerPrefs.GetInt("Savecus1D1");
            CutscenesController.cus2 = PlayerPrefs.GetInt("Savecus2D1");
            CutscenesController.cus3 = PlayerPrefs.GetInt("Savecus3D1");
            CutscenesController.cus4 = PlayerPrefs.GetInt("Savecus4D1");
            CutscenesController.cus5 = PlayerPrefs.GetInt("Savecus5D1");
            CutscenesController.cus6 = PlayerPrefs.GetInt("Savecus6D1");
            CutscenesController.cus7 = PlayerPrefs.GetInt("Savecus7D1");
            CutscenesController.cus8 = PlayerPrefs.GetInt("Savecus8D1");
            CutscenesController.cus9 = PlayerPrefs.GetInt("Savecus9D1");
            CutscenesController.cus10 = PlayerPrefs.GetInt("Savecus10D1");
            CutscenesController.cus11 = PlayerPrefs.GetInt("Savecus11D1");
            CutscenesController.cus12 = PlayerPrefs.GetInt("Savecus12D1");
            CutscenesController.cus13 = PlayerPrefs.GetInt("Savecus13D1");
            CutscenesController.cus14 = PlayerPrefs.GetInt("Savecus14D1");
            CutscenesController.cus15 = PlayerPrefs.GetInt("Savecus15D1");
            CutscenesController.cus16 = PlayerPrefs.GetInt("Savecus16D1");
            CutscenesController.cus17 = PlayerPrefs.GetInt("Savecus17D1");
            CutscenesController.cus18 = PlayerPrefs.GetInt("Savecus18D1");
            CutscenesController.cus19 = PlayerPrefs.GetInt("Savecus19D1");
            CutscenesController.cus20 = PlayerPrefs.GetInt("Savecus20D1");
            CutscenesController.cus21 = PlayerPrefs.GetInt("Savecus21D1");
            CutscenesController.cus22 = PlayerPrefs.GetInt("Savecus22D1");
            CutscenesController.cus23 = PlayerPrefs.GetInt("Savecus23D1");
            CutscenesController.cus24 = PlayerPrefs.GetInt("Savecus24D1");
            CutscenesController.cus25 = PlayerPrefs.GetInt("Savecus25D1");
            CutscenesController.cus26 = PlayerPrefs.GetInt("Savecus26D1");
            CutscenesController.cus27 = PlayerPrefs.GetInt("Savecus27D1");
            CutscenesController.cus28 = PlayerPrefs.GetInt("Savecus28D1");
            CutscenesController.cus29 = PlayerPrefs.GetInt("Savecus29D1");
            CutscenesController.cus30 = PlayerPrefs.GetInt("Savecus30D1");
            CutscenesController.cus31 = PlayerPrefs.GetInt("Savecus31D1");
            CutscenesController.cus32 = PlayerPrefs.GetInt("Savecus32D1");
            CutscenesController.cus33 = PlayerPrefs.GetInt("Savecus33D1");
            CutscenesController.cus34 = PlayerPrefs.GetInt("Savecus34D1");
            CutscenesController.cus35 = PlayerPrefs.GetInt("Savecus35D1");
            CutscenesController.cus36 = PlayerPrefs.GetInt("Savecus36D1");
            CutscenesController.cus37 = PlayerPrefs.GetInt("Savecus37D1");
            CutscenesController.cus38 = PlayerPrefs.GetInt("Savecus38D1");
            CutscenesController.cus39 = PlayerPrefs.GetInt("Savecus39D1");
            CutscenesController.cus40 = PlayerPrefs.GetInt("Savecus40D1");
            CutscenesController.cus41 = PlayerPrefs.GetInt("Savecus41D1");
            CutscenesController.cus42 = PlayerPrefs.GetInt("Savecus42D1");
            CutscenesController.cus43 = PlayerPrefs.GetInt("Savecus43D1");
            CutscenesController.cus44 = PlayerPrefs.GetInt("Savecus44D1");
            CutscenesController.cus45 = PlayerPrefs.GetInt("Savecus45D1");
            CutscenesController.cus46 = PlayerPrefs.GetInt("Savecus46D1");
            CutscenesController.cus47 = PlayerPrefs.GetInt("Savecus47D1");
            CutscenesController.cus48 = PlayerPrefs.GetInt("Savecus48D1");
            CutscenesController.cus49 = PlayerPrefs.GetInt("Savecus49D1");
            CutscenesController.cus50 = PlayerPrefs.GetInt("Savecus50D1");
            CutscenesController.cus51 = PlayerPrefs.GetInt("Savecus51D1");
            CutscenesController.cus52 = PlayerPrefs.GetInt("Savecus52D1");
            CutscenesController.cus53 = PlayerPrefs.GetInt("Savecus53D1");
            CutscenesController.cus54 = PlayerPrefs.GetInt("Savecus54D1");
            CutscenesController.cus55 = PlayerPrefs.GetInt("Savecus55D1");
            CutscenesController.cus56 = PlayerPrefs.GetInt("Savecus56D1");
            CutscenesController.cus57 = PlayerPrefs.GetInt("Savecus57D1");
            CutscenesController.cus58 = PlayerPrefs.GetInt("Savecus58D1");
            CutscenesController.cus59 = PlayerPrefs.GetInt("Savecus59D1");
            CutscenesController.cus60 = PlayerPrefs.GetInt("Savecus60D1");
            CutscenesController.cus61 = PlayerPrefs.GetInt("Savecus61D1");
            CutscenesController.cus62 = PlayerPrefs.GetInt("Savecus62D1");
            CutscenesController.cus63 = PlayerPrefs.GetInt("Savecus63D1");
            CutscenesController.cus64 = PlayerPrefs.GetInt("Savecus64D1");
            CutscenesController.cus65 = PlayerPrefs.GetInt("Savecus65D1");
            CutscenesController.cus66 = PlayerPrefs.GetInt("Savecus66D1");
            CutscenesController.cus67 = PlayerPrefs.GetInt("Savecus67D1");
            CutscenesController.cus68 = PlayerPrefs.GetInt("Savecus68D1");
            CutscenesController.cus69 = PlayerPrefs.GetInt("Savecus69D1");
            CutscenesController.cus70 = PlayerPrefs.GetInt("Savecus70D1");
            CutscenesController.cus71 = PlayerPrefs.GetInt("Savecus71D1");
            CutscenesController.cus72 = PlayerPrefs.GetInt("Savecus72D1");
            CutscenesController.cus73 = PlayerPrefs.GetInt("Savecus73D1");
            CutscenesController.cus74 = PlayerPrefs.GetInt("Savecus74D1");
            CutscenesController.cus75 = PlayerPrefs.GetInt("Savecus75D1");
            CutscenesController.cus76 = PlayerPrefs.GetInt("Savecus76D1");
            CutscenesController.cus77 = PlayerPrefs.GetInt("Savecus77D1");
            CutscenesController.cus78 = PlayerPrefs.GetInt("Savecus78D1");
            CutscenesController.cus79 = PlayerPrefs.GetInt("Savecus79D1");
            CutscenesController.cus80 = PlayerPrefs.GetInt("Savecus80D1");
            CutscenesController.cus81 = PlayerPrefs.GetInt("Savecus81D1");
            CutscenesController.cus82 = PlayerPrefs.GetInt("Savecus82D1");
            CutscenesController.cus83 = PlayerPrefs.GetInt("Savecus83D1");
            CutscenesController.cus84 = PlayerPrefs.GetInt("Savecus84D1");
            CutscenesController.cus85 = PlayerPrefs.GetInt("Savecus85D1");
            CutscenesController.cus86 = PlayerPrefs.GetInt("Savecus86D1");
            CutscenesController.cus87 = PlayerPrefs.GetInt("Savecus87D1");
            CutscenesController.cus88 = PlayerPrefs.GetInt("Savecus88D1");
            CutscenesController.cus89 = PlayerPrefs.GetInt("Savecus89D1");
            CutscenesController.cus90 = PlayerPrefs.GetInt("Savecus90D1");
            CutscenesController.cus91 = PlayerPrefs.GetInt("Savecus91D1");
            CutscenesController.cus92 = PlayerPrefs.GetInt("Savecus92D1");
            CutscenesController.cus93 = PlayerPrefs.GetInt("Savecus93D1");
            CutscenesController.cus94 = PlayerPrefs.GetInt("Savecus94D1");
            CutscenesController.cus95 = PlayerPrefs.GetInt("Savecus95D1");
            CutscenesController.cus96 = PlayerPrefs.GetInt("Savecus96D1");
            CutscenesController.cus97 = PlayerPrefs.GetInt("Savecus97D1");
            CutscenesController.cus98 = PlayerPrefs.GetInt("Savecus98D1");
            CutscenesController.cus99 = PlayerPrefs.GetInt("Savecus99D1");
            CutscenesController.cus100 = PlayerPrefs.GetInt("Savecus100D1");
            CutscenesController.cus101 = PlayerPrefs.GetInt("Savecus101D1");
            CutscenesController.cus102 = PlayerPrefs.GetInt("Savecus102D1");
            CutscenesController.cus103 = PlayerPrefs.GetInt("Savecus103D1");
            CutscenesController.cus104 = PlayerPrefs.GetInt("Savecus104D1");
            CutscenesController.cus105 = PlayerPrefs.GetInt("Savecus105D1");
            CutscenesController.cus106 = PlayerPrefs.GetInt("Savecus106D1");
            CutscenesController.cus107 = PlayerPrefs.GetInt("Savecus107D1");
            CutscenesController.cus108 = PlayerPrefs.GetInt("Savecus108D1");
            CutscenesController.cus109 = PlayerPrefs.GetInt("Savecus109D1");
            CutscenesController.cus110 = PlayerPrefs.GetInt("Savecus110D1");
            CutscenesController.cus111 = PlayerPrefs.GetInt("Savecus111D1");
            CutscenesController.cus112 = PlayerPrefs.GetInt("Savecus112D1");
            CutscenesController.cus113 = PlayerPrefs.GetInt("Savecus113D1");
            CutscenesController.cus114 = PlayerPrefs.GetInt("Savecus114D1");
            CutscenesController.cus115 = PlayerPrefs.GetInt("Savecus115D1");
            CutscenesController.cus116 = PlayerPrefs.GetInt("Savecus116D1");
            CutscenesController.cus117 = PlayerPrefs.GetInt("Savecus117D1");
            CutscenesController.cus118 = PlayerPrefs.GetInt("Savecus118D1");
            CutscenesController.cus119 = PlayerPrefs.GetInt("Savecus119D1");
            CutscenesController.cus120 = PlayerPrefs.GetInt("Savecus120D1");

            //Load quest
            GlobalQuest.KillGoblinQuest = PlayerPrefs.GetInt("SaveKGQD1");
            GlobalQuest.HelpVillagerStop1 = PlayerPrefs.GetInt("SaveHVStop1D1");
            GlobalQuest.HelpVillagerStop2 = PlayerPrefs.GetInt("SaveHVStop2D1");
            GlobalQuest.HelpVillagerStop3 = PlayerPrefs.GetInt("SaveHVStop3D1");
            GlobalQuest.HelpVillagerDone = PlayerPrefs.GetInt("SaveHVD1");
            CutscenesTrigger.PorridgeSyn = PlayerPrefs.GetInt("SavePorridgeSynD1");
            CutscenesTrigger.BomSyn = PlayerPrefs.GetInt("SaveBomSynD1");
            CutscenesTrigger.GolemnKill = PlayerPrefs.GetInt("SaveGolemnKillD1");
            CutscenesTrigger.InfernoScorpionKill = PlayerPrefs.GetInt("SaveInfernoScorpionKillD1");
            CutscenesTrigger.InfernoScorpionKillP2 = PlayerPrefs.GetInt("SaveInfernoScorpionKillP2D1");
            CutscenesTrigger.IceFangKill = PlayerPrefs.GetInt("SaveIceFangKillD1");
            CutscenesTrigger.GoblinKillP2 = PlayerPrefs.GetInt("SaveGoblinKillP2D1");
            CutscenesTrigger.GolemnKillP2 = PlayerPrefs.GetInt("SaveGolemnKillP2D1");

            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);

            //Load Vayne
            Global.CurHPP1 = PlayerPrefs.GetInt("SaveHPP1D1");
            Global.MaxHPP1 = PlayerPrefs.GetInt("SaveMaxHPP1D1");
            Global.CurMPP1 = PlayerPrefs.GetInt("SaveMPP1D1");
            Global.MaxMPP1 = PlayerPrefs.GetInt("SaveMaxMPP1D1");
            Global.DamageP1 = PlayerPrefs.GetInt("SaveDamageP1D1");
            Global.SpeedP1 = PlayerPrefs.GetInt("SaveSpeedP1D1");
            Global.LevelP1 = PlayerPrefs.GetInt("SaveLevelP1D1");
            Global.MaxEXPP1 = PlayerPrefs.GetInt("SaveMaxEXPP1D1");
            Global.CurEXPP1 = PlayerPrefs.GetInt("SaveCurEXPP1D1");
            Global.PlusPointP1 = PlayerPrefs.GetInt("SavePlusPointP1D1");
            Global.PlusPointAttackLvP1 = PlayerPrefs.GetInt("SavePlusPointAttackLvP1D1");
            Global.PlusPointHPLvP1 = PlayerPrefs.GetInt("SavePlusPointHPLvP1D1");
            Global.PlusPointMPLvP1 = PlayerPrefs.GetInt("SavePlusPointMPLvP1D1");
            Global.PlusPointSpeedLvP1 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP1D1");
            Global.PlusPointAttackInfoP1 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP1D1");
            Global.PlusPointHPInfoP1 = PlayerPrefs.GetInt("SavePlusPointHPInfoP1D1");
            Global.PlusPointMPInfoP1 = PlayerPrefs.GetInt("SavePlusPointMPInfoP1D1");
            Global.PlusPointSpeedInfoP1 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP1D1");

            //Load Alia
            Global.CurHPP2 = PlayerPrefs.GetInt("SaveHPP2D1");
            Global.MaxHPP2 = PlayerPrefs.GetInt("SaveMaxHPP2D1");
            Global.CurMPP2 = PlayerPrefs.GetInt("SaveMPP2D1");
            Global.MaxMPP2 = PlayerPrefs.GetInt("SaveMaxMPP2D1");
            Global.DamageP2 = PlayerPrefs.GetInt("SaveDamageP2D1");
            Global.SpeedP2 = PlayerPrefs.GetInt("SaveSpeedP2D1");
            Global.LevelP2 = PlayerPrefs.GetInt("SaveLevelP2D1");
            Global.MaxEXPP2 = PlayerPrefs.GetInt("SaveMaxEXPP2D1");
            Global.CurEXPP2 = PlayerPrefs.GetInt("SaveCurEXPP2D1");
            Global.PlusPointP2 = PlayerPrefs.GetInt("SavePlusPointP2D1");
            Global.PlusPointAttackLvP2 = PlayerPrefs.GetInt("SavePlusPointAttackLvP2D1");
            Global.PlusPointHPLvP2 = PlayerPrefs.GetInt("SavePlusPointHPLvP2D1");
            Global.PlusPointMPLvP2 = PlayerPrefs.GetInt("SavePlusPointMPLvP2D1");
            Global.PlusPointSpeedLvP2 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP2D1");
            Global.PlusPointAttackInfoP2 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP2D1");
            Global.PlusPointHPInfoP2 = PlayerPrefs.GetInt("SavePlusPointHPInfoP2D1");
            Global.PlusPointMPInfoP2 = PlayerPrefs.GetInt("SavePlusPointMPInfoP2D1");
            Global.PlusPointSpeedInfoP2 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP2D1");

            //Load Maria
            Global.CurHPP3 = PlayerPrefs.GetInt("SaveHPP3D1");
            Global.MaxHPP3 = PlayerPrefs.GetInt("SaveMaxHPP3D1");
            Global.CurMPP3 = PlayerPrefs.GetInt("SaveMPP3D1");
            Global.MaxMPP3 = PlayerPrefs.GetInt("SaveMaxMPP3D1");
            Global.DamageP3 = PlayerPrefs.GetInt("SaveDamageP3D1");
            Global.SpeedP3 = PlayerPrefs.GetInt("SaveSpeedP3D1");
            Global.LevelP3 = PlayerPrefs.GetInt("SaveLevelP3D1");
            Global.MaxEXPP3 = PlayerPrefs.GetInt("SaveMaxEXPP3D1");
            Global.CurEXPP3 = PlayerPrefs.GetInt("SaveCurEXPP3D1");
            Global.PlusPointP3 = PlayerPrefs.GetInt("SavePlusPointP3D1");
            Global.PlusPointAttackLvP3 = PlayerPrefs.GetInt("SavePlusPointAttackLvP3D1");
            Global.PlusPointHPLvP3 = PlayerPrefs.GetInt("SavePlusPointHPLvP3D1");
            Global.PlusPointMPLvP3 = PlayerPrefs.GetInt("SavePlusPointMPLvP3D1");
            Global.PlusPointSpeedLvP3 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP3D1");
            Global.PlusPointAttackInfoP3 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP3D1");
            Global.PlusPointHPInfoP3 = PlayerPrefs.GetInt("SavePlusPointHPInfoP3D1");
            Global.PlusPointMPInfoP3 = PlayerPrefs.GetInt("SavePlusPointMPInfoP3D1");
            Global.PlusPointSpeedInfoP3 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP3D1");

            //Load Zen
            Global.Zen = PlayerPrefs.GetInt("SaveZenD1");

            //Load Weapon
            Global.VayneStaff1 = PlayerPrefs.GetInt("SaveVayneStaff1D1");
            Global.VayneStaff2 = PlayerPrefs.GetInt("SaveVayneStaff2D1");
            Global.VayneStaff3 = PlayerPrefs.GetInt("SaveVayneStaff3D1");
            Global.AliaShoes1 = PlayerPrefs.GetInt("SaveAliaShoes1D1");
            Global.AliaShoes2 = PlayerPrefs.GetInt("SaveAliaShoes2D1");
            Global.AliaShoes3 = PlayerPrefs.GetInt("SaveAliaShoes3D1");
            Global.MariaCrystal1 = PlayerPrefs.GetInt("SaveMariaCrystal1D1");
            Global.MariaCrystal2 = PlayerPrefs.GetInt("SaveMariaCrystal2D1");
            Global.MariaCrystal3 = PlayerPrefs.GetInt("SaveMariaCrystal3D1");
            Global.AlchemistArmor1 = PlayerPrefs.GetInt("SaveAlchemistArmor1D1");
            Global.AlchemistArmor2 = PlayerPrefs.GetInt("SaveAlchemistArmor2D1");
            Global.AlchemistArmor3 = PlayerPrefs.GetInt("SaveAlchemistArmor3D1");
            Global.WarriorArmor1 = PlayerPrefs.GetInt("SaveWarriorArmor1D1");
            Global.WarriorArmor2 = PlayerPrefs.GetInt("SaveWarriorArmor2D1");
            Global.WarriorArmor3 = PlayerPrefs.GetInt("SaveWarriorArmor3D1");

            //Load weapon status
            Global.VayneWeaponStatus = PlayerPrefs.GetInt("SaveVayneWeaponStatusD1");
            Global.VayneArmorStatus = PlayerPrefs.GetInt("SaveVayneArmorStatusD1");
            Global.AliaWeaponStatus = PlayerPrefs.GetInt("SaveAliaWeaponStatusD1");
            Global.AliaArmorStatus = PlayerPrefs.GetInt("SaveAliaArmorStatusD1");
            Global.MariaWeaponStatus = PlayerPrefs.GetInt("SaveMariaWeaponStatusD1");
            Global.MariaArmorStatus = PlayerPrefs.GetInt("SaveMariaArmorStatusD1");

            //Load weapon had bought
            WeaponStoreController.Bought1 = PlayerPrefs.GetInt("SaveBought1D1");
            WeaponStoreController.Bought2 = PlayerPrefs.GetInt("SaveBought2D1");
            WeaponStoreController.Bought3 = PlayerPrefs.GetInt("SaveBought3D1");
            WeaponStoreController.Bought4 = PlayerPrefs.GetInt("SaveBought4D1");
            WeaponStoreController.Bought5 = PlayerPrefs.GetInt("SaveBought5D1");
            WeaponStoreController.Bought6 = PlayerPrefs.GetInt("SaveBought6D1");
            WeaponStoreController.Bought7 = PlayerPrefs.GetInt("SaveBought7D1");
            WeaponStoreController.Bought8 = PlayerPrefs.GetInt("SaveBought8D1");
            WeaponStoreController.Bought9 = PlayerPrefs.GetInt("SaveBought9D1");
            WeaponStoreController.Bought10 = PlayerPrefs.GetInt("SaveBought10D1");
            WeaponStoreController.Bought11 = PlayerPrefs.GetInt("SaveBought11D1");
            WeaponStoreController.Bought12 = PlayerPrefs.GetInt("SaveBought12D1");
            WeaponStoreController.Bought13 = PlayerPrefs.GetInt("SaveBought13D1");
            WeaponStoreController.Bought14 = PlayerPrefs.GetInt("SaveBought14D1");
            WeaponStoreController.Bought15 = PlayerPrefs.GetInt("SaveBought15D1");

            //Load item material
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDriedLeavesD1");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePureWaterD1");
            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMorningDropD1");
            ContainerController.Wheat = PlayerPrefs.GetInt("SaveWheatD1");
            ContainerController.Wood = PlayerPrefs.GetInt("SaveWoodD1");
            ContainerController.String = PlayerPrefs.GetInt("SaveStringD1");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveIronD1");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveManaGemD1");
            ContainerController.ScorpionVenom = PlayerPrefs.GetInt("SaveScorpionVenomD1");
            ContainerController.InfernoSand = PlayerPrefs.GetInt("SaveInfernoSandD1");
            ContainerController.ManaLiquid = PlayerPrefs.GetInt("SaveManaLiquidD1");
            ContainerController.ManaOre = PlayerPrefs.GetInt("SaveManaOreD1");
            ContainerController.ManaCrystal = PlayerPrefs.GetInt("SaveManaCrystalD1"); ;
            ContainerController.GuardianFeather = PlayerPrefs.GetInt("SaveGuardianFeatherD1");
            ContainerController.FireOre = PlayerPrefs.GetInt("SaveFireOreD1");
            ContainerController.GoldenFeather = PlayerPrefs.GetInt("SaveGoldenFeatherD1");
            ContainerController.RedManaCrystal = PlayerPrefs.GetInt("SaveRedManaCrystalD1");
            ContainerController.Obsidian = PlayerPrefs.GetInt("SaveObsidianD1");
            ContainerController.IceOre = PlayerPrefs.GetInt("SaveIceOreD1");
            ContainerController.IceLeather = PlayerPrefs.GetInt("SaveIceLeatherD1");
            ContainerController.BlueManaCrystal = PlayerPrefs.GetInt("SaveBlueManaCrystalD1");
            ContainerController.RedManaSlimeBall = PlayerPrefs.GetInt("SaveRedManaSlimeBallD1");
            ContainerController.BlueManaSlimeBall = PlayerPrefs.GetInt("SaveBlueManaSlimeBallD1");
            ContainerController.ManaCoreFireZexel = PlayerPrefs.GetInt("SaveManaCoreFireZexelD1");
            ContainerController.ManaCoreIceZexel = PlayerPrefs.GetInt("SaveManaCoreIceZexelD1");
            ContainerController.Rock = PlayerPrefs.GetInt("SaveRockD1");
            ContainerController.NatureGrass = PlayerPrefs.GetInt("SaveNatureGrassD1");
            ContainerController.ManaDust = PlayerPrefs.GetInt("SaveManaDustD1");
            ContainerController.ManaEagleFeather = PlayerPrefs.GetInt("SaveManaEagleFeatherD1");
            ContainerController.IceCrystal = PlayerPrefs.GetInt("SaveIceCrystalD1");

            //Load item
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHealPotionD1");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveManaPotionD1");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveElixirPotionD1");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBomD1");
            ContainerController.Porridge = PlayerPrefs.GetInt("SavePorridgeD1");
            ContainerController.ManaCloth = PlayerPrefs.GetInt("SaveManaClothD1");
            ContainerController.ManaShield = PlayerPrefs.GetInt("SaveManaShieldD1");
            ContainerController.VenomKiller = PlayerPrefs.GetInt("SaveVenomKillerD1");
            ContainerController.ManaNecklace = PlayerPrefs.GetInt("SaveManaNecklaceD1");
            ContainerController.ManaGenerator = PlayerPrefs.GetInt("SaveManaGeneratorD1");
            ContainerController.Baxiata = PlayerPrefs.GetInt("SaveBaxiataD1");
            ContainerController.BaxiataGem = PlayerPrefs.GetInt("SaveBaxiataGemD1");
            ContainerController.Photonria = PlayerPrefs.GetInt("SavePhotonriaD1");
            ContainerController.PhotonriaGem = PlayerPrefs.GetInt("SavePhotonriaGemD1");
            ContainerController.ManaLiquidCatalyst = PlayerPrefs.GetInt("SaveManaLiquidCatalystD1");
            ContainerController.RedLiquidCatalyst = PlayerPrefs.GetInt("SaveRedLiquidCatalystD1");
            ContainerController.BlueLiquidCatalyst = PlayerPrefs.GetInt("SaveBlueLiquidCatalystD1");
            ContainerController.ManaCoreFireVayne = PlayerPrefs.GetInt("SaveManaCoreFireVayneD1");
            ContainerController.ManaCoreIceVayne = PlayerPrefs.GetInt("SaveManaCoreIceVayneD1");
            ContainerController.PureObsidian = PlayerPrefs.GetInt("SavePureObsidianD1");
            ContainerController.FireManaGenerator = PlayerPrefs.GetInt("SaveFireManaGeneratorD1");
            ContainerController.IceManaGenerator = PlayerPrefs.GetInt("SaveIceManaGeneratorD1");
            ContainerController.PowderOfLife = PlayerPrefs.GetInt("SavePowderOfLifeD1");
            ContainerController.HoliHP = PlayerPrefs.GetInt("SaveHoliHPD1");
            ContainerController.HoliMP = PlayerPrefs.GetInt("SaveHoliMPD1");
            ContainerController.UltraBom = PlayerPrefs.GetInt("SaveUltraBomD1");
            ContainerController.ReincarnationLife = PlayerPrefs.GetInt("SaveReincarnationLifeD1");
            ContainerController.FireOfPeace = PlayerPrefs.GetInt("SaveFireOfPeaceD1");
            ContainerController.OmnipotentBoundary = PlayerPrefs.GetInt("SaveOmnipotentBoundaryD1");

            //Load ManaSynthesize
            SynthesizeSystem.ManaSynthesize = PlayerPrefs.GetInt("SaveManaSynthesizeD1");
            SynthesizeSystem.ManaFireSynthesize = PlayerPrefs.GetInt("SaveManaFireSynthesizeD1");
            SynthesizeSystem.ManaIceSynthesize = PlayerPrefs.GetInt("SaveManaIceSynthesizeD1");

            //Load map posi
            MapController.WishingHillToZexelTown = false;
            MapController.ZexelTownToTavern = false;
            MapController.TavernToSaveRoom = true;
            MapController.ZexelTownToWishingForest = false;
            MapController.ZexelTownToInfernoDesert = false;
            MapController.ZexelTownToWishingHill = false;
            MapController.TavernToZexelTown = false;
            MapController.SaveRoomToTavern = false;
            MapController.WishingForestToZexelTown = false;
            MapController.InfernoDesertToZexelTown = false;
            MapController.InfernoDesertToZexelGate = false;
            MapController.ZexelGateToInfernoDesert = false;
            MapController.InfernoDesertToManaGate = false;
            MapController.ManaGateToInfernoDesert = false;
            MapController.InfernoDesertToInfernoVolcano = false;
            MapController.InfernoVolcanoToInfernoDesert = false;
            MapController.InfernoDesertToInfernoIce = false;
            MapController.InfernoIceToInfernoDesert = false;
            MapController.InfernoDesertToManaCliff = false;
            MapController.ManaCliffToInfernoDesert = false;
            MapController.ManaGateToManaDimension = false;
            MapController.ManaDimensionToManaGate = false;
            MapController.ManaDimensionToManaTemple = false;
            MapController.ManaTempleToManaDimension = false;
            MapController.InfernoVolcanoToInsideVolcanoCave = false;
            MapController.InsideVolcanoCaveToInfernoVolcano = false;
            MapController.InfernoVolcanoToAltaInferno = false;
            MapController.AltaInfernoToInfernoVolcano = false;
            MapController.InfernoIceToInsideIceCave = false;
            MapController.InsideIceCaveToInfernoIce = false;
            MapController.InfernoIceToAltaInferno = false;
            MapController.AltaInfernoToInfernoIce = false;
            MapController.ZexelGateToZexelTemple = false;
            MapController.ZexelTempleToZexelGate = false;

            SceneManager.LoadScene("Save room");
        }
    }
    public void PressLoadGameData2()
    {
        if (PlayerPrefs.GetInt("SaveGameD2") == 1)
        {
            LoadGameCheck = true;

            //Load map
            Player.MapIndex = 1;

            //Load date
            DateController.GlobalDayNight = PlayerPrefs.GetInt("SaveGlobalDayNightD2");
            DateController.GlobalTime = PlayerPrefs.GetFloat("SaveGlobalTimeD2");
            DateController.GlobalUpHour = PlayerPrefs.GetInt("SaveGlobalUpHourD2");
            DateController.GlobalPHour = PlayerPrefs.GetInt("SaveGlobalPHourD2");
            DateController.GlobalDownHour = PlayerPrefs.GetInt("SaveGlobalDownHourD2");

            CutscenesController.cus1 = PlayerPrefs.GetInt("Savecus1D2");
            CutscenesController.cus2 = PlayerPrefs.GetInt("Savecus2D2");
            CutscenesController.cus3 = PlayerPrefs.GetInt("Savecus3D2");
            CutscenesController.cus4 = PlayerPrefs.GetInt("Savecus4D2");
            CutscenesController.cus5 = PlayerPrefs.GetInt("Savecus5D2");
            CutscenesController.cus6 = PlayerPrefs.GetInt("Savecus6D2");
            CutscenesController.cus7 = PlayerPrefs.GetInt("Savecus7D2");
            CutscenesController.cus8 = PlayerPrefs.GetInt("Savecus8D2");
            CutscenesController.cus9 = PlayerPrefs.GetInt("Savecus9D2");
            CutscenesController.cus10 = PlayerPrefs.GetInt("Savecus10D2");
            CutscenesController.cus11 = PlayerPrefs.GetInt("Savecus11D2");
            CutscenesController.cus12 = PlayerPrefs.GetInt("Savecus12D2");
            CutscenesController.cus13 = PlayerPrefs.GetInt("Savecus13D2");
            CutscenesController.cus14 = PlayerPrefs.GetInt("Savecus14D2");
            CutscenesController.cus15 = PlayerPrefs.GetInt("Savecus15D2");
            CutscenesController.cus16 = PlayerPrefs.GetInt("Savecus16D2");
            CutscenesController.cus17 = PlayerPrefs.GetInt("Savecus17D2");
            CutscenesController.cus18 = PlayerPrefs.GetInt("Savecus18D2");
            CutscenesController.cus19 = PlayerPrefs.GetInt("Savecus19D2");
            CutscenesController.cus20 = PlayerPrefs.GetInt("Savecus20D2");
            CutscenesController.cus21 = PlayerPrefs.GetInt("Savecus21D2");
            CutscenesController.cus22 = PlayerPrefs.GetInt("Savecus22D2");
            CutscenesController.cus23 = PlayerPrefs.GetInt("Savecus23D2");
            CutscenesController.cus24 = PlayerPrefs.GetInt("Savecus24D2");
            CutscenesController.cus25 = PlayerPrefs.GetInt("Savecus25D2");
            CutscenesController.cus26 = PlayerPrefs.GetInt("Savecus26D2");
            CutscenesController.cus27 = PlayerPrefs.GetInt("Savecus27D2");
            CutscenesController.cus28 = PlayerPrefs.GetInt("Savecus28D2");
            CutscenesController.cus29 = PlayerPrefs.GetInt("Savecus29D2");
            CutscenesController.cus30 = PlayerPrefs.GetInt("Savecus30D2");
            CutscenesController.cus31 = PlayerPrefs.GetInt("Savecus31D2");
            CutscenesController.cus32 = PlayerPrefs.GetInt("Savecus32D2");
            CutscenesController.cus33 = PlayerPrefs.GetInt("Savecus33D2");
            CutscenesController.cus34 = PlayerPrefs.GetInt("Savecus34D2");
            CutscenesController.cus35 = PlayerPrefs.GetInt("Savecus35D2");
            CutscenesController.cus36 = PlayerPrefs.GetInt("Savecus36D2");
            CutscenesController.cus37 = PlayerPrefs.GetInt("Savecus37D2");
            CutscenesController.cus38 = PlayerPrefs.GetInt("Savecus38D2");
            CutscenesController.cus39 = PlayerPrefs.GetInt("Savecus39D2");
            CutscenesController.cus40 = PlayerPrefs.GetInt("Savecus40D2");
            CutscenesController.cus41 = PlayerPrefs.GetInt("Savecus41D2");
            CutscenesController.cus42 = PlayerPrefs.GetInt("Savecus42D2");
            CutscenesController.cus43 = PlayerPrefs.GetInt("Savecus43D2");
            CutscenesController.cus44 = PlayerPrefs.GetInt("Savecus44D2");
            CutscenesController.cus45 = PlayerPrefs.GetInt("Savecus45D2");
            CutscenesController.cus46 = PlayerPrefs.GetInt("Savecus46D2");
            CutscenesController.cus47 = PlayerPrefs.GetInt("Savecus47D2");
            CutscenesController.cus48 = PlayerPrefs.GetInt("Savecus48D2");
            CutscenesController.cus49 = PlayerPrefs.GetInt("Savecus49D2");
            CutscenesController.cus50 = PlayerPrefs.GetInt("Savecus50D2");
            CutscenesController.cus51 = PlayerPrefs.GetInt("Savecus51D2");
            CutscenesController.cus52 = PlayerPrefs.GetInt("Savecus52D2");
            CutscenesController.cus53 = PlayerPrefs.GetInt("Savecus53D2");
            CutscenesController.cus54 = PlayerPrefs.GetInt("Savecus54D2");
            CutscenesController.cus55 = PlayerPrefs.GetInt("Savecus55D2");
            CutscenesController.cus56 = PlayerPrefs.GetInt("Savecus56D2");
            CutscenesController.cus57 = PlayerPrefs.GetInt("Savecus57D2");
            CutscenesController.cus58 = PlayerPrefs.GetInt("Savecus58D2");
            CutscenesController.cus59 = PlayerPrefs.GetInt("Savecus59D2");
            CutscenesController.cus60 = PlayerPrefs.GetInt("Savecus60D2");
            CutscenesController.cus61 = PlayerPrefs.GetInt("Savecus61D2");
            CutscenesController.cus62 = PlayerPrefs.GetInt("Savecus62D2");
            CutscenesController.cus63 = PlayerPrefs.GetInt("Savecus63D2");
            CutscenesController.cus64 = PlayerPrefs.GetInt("Savecus64D2");
            CutscenesController.cus65 = PlayerPrefs.GetInt("Savecus65D2");
            CutscenesController.cus66 = PlayerPrefs.GetInt("Savecus66D2");
            CutscenesController.cus67 = PlayerPrefs.GetInt("Savecus67D2");
            CutscenesController.cus68 = PlayerPrefs.GetInt("Savecus68D2");
            CutscenesController.cus69 = PlayerPrefs.GetInt("Savecus69D2");
            CutscenesController.cus70 = PlayerPrefs.GetInt("Savecus70D2");
            CutscenesController.cus71 = PlayerPrefs.GetInt("Savecus71D2");
            CutscenesController.cus72 = PlayerPrefs.GetInt("Savecus72D2");
            CutscenesController.cus73 = PlayerPrefs.GetInt("Savecus73D2");
            CutscenesController.cus74 = PlayerPrefs.GetInt("Savecus74D2");
            CutscenesController.cus75 = PlayerPrefs.GetInt("Savecus75D2");
            CutscenesController.cus76 = PlayerPrefs.GetInt("Savecus76D2");
            CutscenesController.cus77 = PlayerPrefs.GetInt("Savecus77D2");
            CutscenesController.cus78 = PlayerPrefs.GetInt("Savecus78D2");
            CutscenesController.cus79 = PlayerPrefs.GetInt("Savecus79D2");
            CutscenesController.cus80 = PlayerPrefs.GetInt("Savecus80D2");
            CutscenesController.cus81 = PlayerPrefs.GetInt("Savecus81D2");
            CutscenesController.cus82 = PlayerPrefs.GetInt("Savecus82D2");
            CutscenesController.cus83 = PlayerPrefs.GetInt("Savecus83D2");
            CutscenesController.cus84 = PlayerPrefs.GetInt("Savecus84D2");
            CutscenesController.cus85 = PlayerPrefs.GetInt("Savecus85D2");
            CutscenesController.cus86 = PlayerPrefs.GetInt("Savecus86D2");
            CutscenesController.cus87 = PlayerPrefs.GetInt("Savecus87D2");
            CutscenesController.cus88 = PlayerPrefs.GetInt("Savecus88D2");
            CutscenesController.cus89 = PlayerPrefs.GetInt("Savecus89D2");
            CutscenesController.cus90 = PlayerPrefs.GetInt("Savecus90D2");
            CutscenesController.cus91 = PlayerPrefs.GetInt("Savecus91D2");
            CutscenesController.cus92 = PlayerPrefs.GetInt("Savecus92D2");
            CutscenesController.cus93 = PlayerPrefs.GetInt("Savecus93D2");
            CutscenesController.cus94 = PlayerPrefs.GetInt("Savecus94D2");
            CutscenesController.cus95 = PlayerPrefs.GetInt("Savecus95D2");
            CutscenesController.cus96 = PlayerPrefs.GetInt("Savecus96D2");
            CutscenesController.cus97 = PlayerPrefs.GetInt("Savecus97D2");
            CutscenesController.cus98 = PlayerPrefs.GetInt("Savecus98D2");
            CutscenesController.cus99 = PlayerPrefs.GetInt("Savecus99D2");
            CutscenesController.cus100 = PlayerPrefs.GetInt("Savecus100D2");
            CutscenesController.cus101 = PlayerPrefs.GetInt("Savecus101D2");
            CutscenesController.cus102 = PlayerPrefs.GetInt("Savecus102D2");
            CutscenesController.cus103 = PlayerPrefs.GetInt("Savecus103D2");
            CutscenesController.cus104 = PlayerPrefs.GetInt("Savecus104D2");
            CutscenesController.cus105 = PlayerPrefs.GetInt("Savecus105D2");
            CutscenesController.cus106 = PlayerPrefs.GetInt("Savecus106D2");
            CutscenesController.cus107 = PlayerPrefs.GetInt("Savecus107D2");
            CutscenesController.cus108 = PlayerPrefs.GetInt("Savecus108D2");
            CutscenesController.cus109 = PlayerPrefs.GetInt("Savecus109D2");
            CutscenesController.cus110 = PlayerPrefs.GetInt("Savecus110D2");
            CutscenesController.cus111 = PlayerPrefs.GetInt("Savecus111D2");
            CutscenesController.cus112 = PlayerPrefs.GetInt("Savecus112D2");
            CutscenesController.cus113 = PlayerPrefs.GetInt("Savecus113D2");
            CutscenesController.cus114 = PlayerPrefs.GetInt("Savecus114D2");
            CutscenesController.cus115 = PlayerPrefs.GetInt("Savecus115D2");
            CutscenesController.cus116 = PlayerPrefs.GetInt("Savecus116D2");
            CutscenesController.cus117 = PlayerPrefs.GetInt("Savecus117D2");
            CutscenesController.cus118 = PlayerPrefs.GetInt("Savecus118D2");
            CutscenesController.cus119 = PlayerPrefs.GetInt("Savecus119D2");
            CutscenesController.cus120 = PlayerPrefs.GetInt("Savecus120D2");

            //Load quest
            GlobalQuest.KillGoblinQuest = PlayerPrefs.GetInt("SaveKGQD2");
            GlobalQuest.HelpVillagerStop1 = PlayerPrefs.GetInt("SaveHVStop1D2");
            GlobalQuest.HelpVillagerStop2 = PlayerPrefs.GetInt("SaveHVStop2D2");
            GlobalQuest.HelpVillagerStop3 = PlayerPrefs.GetInt("SaveHVStop3D2");
            GlobalQuest.HelpVillagerDone = PlayerPrefs.GetInt("SaveHVD2");
            CutscenesTrigger.PorridgeSyn = PlayerPrefs.GetInt("SavePorridgeSynD2");
            CutscenesTrigger.BomSyn = PlayerPrefs.GetInt("SaveBomSynD2");
            CutscenesTrigger.GolemnKill = PlayerPrefs.GetInt("SaveGolemnKillD2");
            CutscenesTrigger.InfernoScorpionKill = PlayerPrefs.GetInt("SaveInfernoScorpionKillD2");
            CutscenesTrigger.InfernoScorpionKillP2 = PlayerPrefs.GetInt("SaveInfernoScorpionKillP2D2");
            CutscenesTrigger.IceFangKill = PlayerPrefs.GetInt("SaveIceFangKillD2");
            CutscenesTrigger.GoblinKillP2 = PlayerPrefs.GetInt("SaveGoblinKillP2D2");
            CutscenesTrigger.GolemnKillP2 = PlayerPrefs.GetInt("SaveGolemnKillP2D2");

            //Set point
            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);

            //Load Vayne
            Global.CurHPP1 = PlayerPrefs.GetInt("SaveHPP1D2");
            Global.MaxHPP1 = PlayerPrefs.GetInt("SaveMaxHPP1D2");
            Global.CurMPP1 = PlayerPrefs.GetInt("SaveMPP1D2");
            Global.MaxMPP1 = PlayerPrefs.GetInt("SaveMaxMPP1D2");
            Global.DamageP1 = PlayerPrefs.GetInt("SaveDamageP1D2");
            Global.SpeedP1 = PlayerPrefs.GetInt("SaveSpeedP1D2");
            Global.LevelP1 = PlayerPrefs.GetInt("SaveLevelP1D2");
            Global.MaxEXPP1 = PlayerPrefs.GetInt("SaveMaxEXPP1D2");
            Global.CurEXPP1 = PlayerPrefs.GetInt("SaveCurEXPP1D2");
            Global.PlusPointP1 = PlayerPrefs.GetInt("SavePlusPointP1D2");
            Global.PlusPointAttackLvP1 = PlayerPrefs.GetInt("SavePlusPointAttackLvP1D2");
            Global.PlusPointHPLvP1 = PlayerPrefs.GetInt("SavePlusPointHPLvP1D2");
            Global.PlusPointMPLvP1 = PlayerPrefs.GetInt("SavePlusPointMPLvP1D2");
            Global.PlusPointSpeedLvP1 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP1D2");
            Global.PlusPointAttackInfoP1 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP1D2");
            Global.PlusPointHPInfoP1 = PlayerPrefs.GetInt("SavePlusPointHPInfoP1D2");
            Global.PlusPointMPInfoP1 = PlayerPrefs.GetInt("SavePlusPointMPInfoP1D2");
            Global.PlusPointSpeedInfoP1 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP1D2");

            //Load Alia
            Global.CurHPP2 = PlayerPrefs.GetInt("SaveHPP2D2");
            Global.MaxHPP2 = PlayerPrefs.GetInt("SaveMaxHPP2D2");
            Global.CurMPP2 = PlayerPrefs.GetInt("SaveMPP2D2");
            Global.MaxMPP2 = PlayerPrefs.GetInt("SaveMaxMPP2D2");
            Global.DamageP2 = PlayerPrefs.GetInt("SaveDamageP2D2");
            Global.SpeedP2 = PlayerPrefs.GetInt("SaveSpeedP2D2");
            Global.LevelP2 = PlayerPrefs.GetInt("SaveLevelP2D2");
            Global.MaxEXPP2 = PlayerPrefs.GetInt("SaveMaxEXPP2D2");
            Global.CurEXPP2 = PlayerPrefs.GetInt("SaveCurEXPP2D2");
            Global.PlusPointP2 = PlayerPrefs.GetInt("SavePlusPointP2D2");
            Global.PlusPointAttackLvP2 = PlayerPrefs.GetInt("SavePlusPointAttackLvP2D2");
            Global.PlusPointHPLvP2 = PlayerPrefs.GetInt("SavePlusPointHPLvP2D2");
            Global.PlusPointMPLvP2 = PlayerPrefs.GetInt("SavePlusPointMPLvP2D2");
            Global.PlusPointSpeedLvP2 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP2D2");
            Global.PlusPointAttackInfoP2 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP2D2");
            Global.PlusPointHPInfoP2 = PlayerPrefs.GetInt("SavePlusPointHPInfoP2D2");
            Global.PlusPointMPInfoP2 = PlayerPrefs.GetInt("SavePlusPointMPInfoP2D2");
            Global.PlusPointSpeedInfoP2 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP2D2");

            //Load Maria
            Global.CurHPP3 = PlayerPrefs.GetInt("SaveHPP3D2");
            Global.MaxHPP3 = PlayerPrefs.GetInt("SaveMaxHPP3D2");
            Global.CurMPP3 = PlayerPrefs.GetInt("SaveMPP3D2");
            Global.MaxMPP3 = PlayerPrefs.GetInt("SaveMaxMPP3D2");
            Global.DamageP3 = PlayerPrefs.GetInt("SaveDamageP3D2");
            Global.SpeedP3 = PlayerPrefs.GetInt("SaveSpeedP3D2");
            Global.LevelP3 = PlayerPrefs.GetInt("SaveLevelP3D2");
            Global.MaxEXPP3 = PlayerPrefs.GetInt("SaveMaxEXPP3D2");
            Global.CurEXPP3 = PlayerPrefs.GetInt("SaveCurEXPP3D2");
            Global.PlusPointP3 = PlayerPrefs.GetInt("SavePlusPointP3D2");
            Global.PlusPointAttackLvP3 = PlayerPrefs.GetInt("SavePlusPointAttackLvP3D2");
            Global.PlusPointHPLvP3 = PlayerPrefs.GetInt("SavePlusPointHPLvP3D2");
            Global.PlusPointMPLvP3 = PlayerPrefs.GetInt("SavePlusPointMPLvP3D2");
            Global.PlusPointSpeedLvP3 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP3D2");
            Global.PlusPointAttackInfoP3 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP3D2");
            Global.PlusPointHPInfoP3 = PlayerPrefs.GetInt("SavePlusPointHPInfoP3D2");
            Global.PlusPointMPInfoP3 = PlayerPrefs.GetInt("SavePlusPointMPInfoP3D2");
            Global.PlusPointSpeedInfoP3 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP3D2");

            //Set Zen
            Global.Zen = PlayerPrefs.GetInt("SaveZenD2");

            //Load Weapon
            Global.VayneStaff1 = PlayerPrefs.GetInt("SaveVayneStaff1D2");
            Global.VayneStaff2 = PlayerPrefs.GetInt("SaveVayneStaff2D2");
            Global.VayneStaff3 = PlayerPrefs.GetInt("SaveVayneStaff3D2");
            Global.AliaShoes1 = PlayerPrefs.GetInt("SaveAliaShoes1D2");
            Global.AliaShoes2 = PlayerPrefs.GetInt("SaveAliaShoes2D2");
            Global.AliaShoes3 = PlayerPrefs.GetInt("SaveAliaShoes3D2");
            Global.MariaCrystal1 = PlayerPrefs.GetInt("SaveMariaCrystal1D2");
            Global.MariaCrystal2 = PlayerPrefs.GetInt("SaveMariaCrystal2D2");
            Global.MariaCrystal3 = PlayerPrefs.GetInt("SaveMariaCrystal3D2");
            Global.AlchemistArmor1 = PlayerPrefs.GetInt("SaveAlchemistArmor1D2");
            Global.AlchemistArmor2 = PlayerPrefs.GetInt("SaveAlchemistArmor2D2");
            Global.AlchemistArmor3 = PlayerPrefs.GetInt("SaveAlchemistArmor3D2");
            Global.WarriorArmor1 = PlayerPrefs.GetInt("SaveWarriorArmor1D2");
            Global.WarriorArmor2 = PlayerPrefs.GetInt("SaveWarriorArmor2D2");
            Global.WarriorArmor3 = PlayerPrefs.GetInt("SaveWarriorArmor3D2");

            //Load weapon status
            Global.VayneWeaponStatus = PlayerPrefs.GetInt("SaveVayneWeaponStatusD2");
            Global.VayneArmorStatus = PlayerPrefs.GetInt("SaveVayneArmorStatusD2");
            Global.AliaWeaponStatus = PlayerPrefs.GetInt("SaveAliaWeaponStatusD2");
            Global.AliaArmorStatus = PlayerPrefs.GetInt("SaveAliaArmorStatusD2");
            Global.MariaWeaponStatus = PlayerPrefs.GetInt("SaveMariaWeaponStatusD2");
            Global.MariaArmorStatus = PlayerPrefs.GetInt("SaveMariaArmorStatusD2");

            //Load weapon had bought
            WeaponStoreController.Bought1 = PlayerPrefs.GetInt("SaveBought1D2");
            WeaponStoreController.Bought2 = PlayerPrefs.GetInt("SaveBought2D2");
            WeaponStoreController.Bought3 = PlayerPrefs.GetInt("SaveBought3D2");
            WeaponStoreController.Bought4 = PlayerPrefs.GetInt("SaveBought4D2");
            WeaponStoreController.Bought5 = PlayerPrefs.GetInt("SaveBought5D2");
            WeaponStoreController.Bought6 = PlayerPrefs.GetInt("SaveBought6D2");
            WeaponStoreController.Bought7 = PlayerPrefs.GetInt("SaveBought7D2");
            WeaponStoreController.Bought8 = PlayerPrefs.GetInt("SaveBought8D2");
            WeaponStoreController.Bought9 = PlayerPrefs.GetInt("SaveBought9D2");
            WeaponStoreController.Bought10 = PlayerPrefs.GetInt("SaveBought10D2");
            WeaponStoreController.Bought11 = PlayerPrefs.GetInt("SaveBought11D2");
            WeaponStoreController.Bought12 = PlayerPrefs.GetInt("SaveBought12D2");
            WeaponStoreController.Bought13 = PlayerPrefs.GetInt("SaveBought13D2");
            WeaponStoreController.Bought14 = PlayerPrefs.GetInt("SaveBought14D2");
            WeaponStoreController.Bought15 = PlayerPrefs.GetInt("SaveBought15D2");

            //Load item material
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDriedLeavesD2");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePureWaterD2");
            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMorningDropD2");
            ContainerController.Wheat = PlayerPrefs.GetInt("SaveWheatD2");
            ContainerController.Wood = PlayerPrefs.GetInt("SaveWoodD2");
            ContainerController.String = PlayerPrefs.GetInt("SaveStringD2");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveIronD2");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveManaGemD2");
            ContainerController.ScorpionVenom = PlayerPrefs.GetInt("SaveScorpionVenomD2");
            ContainerController.InfernoSand = PlayerPrefs.GetInt("SaveInfernoSandD2");
            ContainerController.ManaLiquid = PlayerPrefs.GetInt("SaveManaLiquidD2");
            ContainerController.ManaOre = PlayerPrefs.GetInt("SaveManaOreD2");
            ContainerController.ManaCrystal = PlayerPrefs.GetInt("SaveManaCrystalD2"); ;
            ContainerController.GuardianFeather = PlayerPrefs.GetInt("SaveGuardianFeatherD2");
            ContainerController.FireOre = PlayerPrefs.GetInt("SaveFireOreD2");
            ContainerController.GoldenFeather = PlayerPrefs.GetInt("SaveGoldenFeatherD2");
            ContainerController.RedManaCrystal = PlayerPrefs.GetInt("SaveRedManaCrystalD2");
            ContainerController.Obsidian = PlayerPrefs.GetInt("SaveObsidianD2");
            ContainerController.IceOre = PlayerPrefs.GetInt("SaveIceOreD2");
            ContainerController.IceLeather = PlayerPrefs.GetInt("SaveIceLeatherD2");
            ContainerController.BlueManaCrystal = PlayerPrefs.GetInt("SaveBlueManaCrystalD2");
            ContainerController.RedManaSlimeBall = PlayerPrefs.GetInt("SaveRedManaSlimeBallD2");
            ContainerController.BlueManaSlimeBall = PlayerPrefs.GetInt("SaveBlueManaSlimeBallD2");
            ContainerController.ManaCoreFireZexel = PlayerPrefs.GetInt("SaveManaCoreFireZexelD2");
            ContainerController.ManaCoreIceZexel = PlayerPrefs.GetInt("SaveManaCoreIceZexelD2");
            ContainerController.Rock = PlayerPrefs.GetInt("SaveRockD2");
            ContainerController.NatureGrass = PlayerPrefs.GetInt("SaveNatureGrassD2");
            ContainerController.ManaDust = PlayerPrefs.GetInt("SaveManaDustD2");
            ContainerController.ManaEagleFeather = PlayerPrefs.GetInt("SaveManaEagleFeatherD2");
            ContainerController.IceCrystal = PlayerPrefs.GetInt("SaveIceCrystalD2");

            //Load item
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHealPotionD2");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveManaPotionD2");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveElixirPotionD2");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBomD2");
            ContainerController.Porridge = PlayerPrefs.GetInt("SavePorridgeD2");
            ContainerController.ManaCloth = PlayerPrefs.GetInt("SaveManaClothD2");
            ContainerController.ManaShield = PlayerPrefs.GetInt("SaveManaShieldD2");
            ContainerController.VenomKiller = PlayerPrefs.GetInt("SaveVenomKillerD2");
            ContainerController.ManaNecklace = PlayerPrefs.GetInt("SaveManaNecklaceD2");
            ContainerController.ManaGenerator = PlayerPrefs.GetInt("SaveManaGeneratorD2");
            ContainerController.Baxiata = PlayerPrefs.GetInt("SaveBaxiataD2");
            ContainerController.BaxiataGem = PlayerPrefs.GetInt("SaveBaxiataGemD2");
            ContainerController.Photonria = PlayerPrefs.GetInt("SavePhotonriaD2");
            ContainerController.PhotonriaGem = PlayerPrefs.GetInt("SavePhotonriaGemD2");
            ContainerController.ManaLiquidCatalyst = PlayerPrefs.GetInt("SaveManaLiquidCatalystD2");
            ContainerController.RedLiquidCatalyst = PlayerPrefs.GetInt("SaveRedLiquidCatalystD2");
            ContainerController.BlueLiquidCatalyst = PlayerPrefs.GetInt("SaveBlueLiquidCatalystD2");
            ContainerController.ManaCoreFireVayne = PlayerPrefs.GetInt("SaveManaCoreFireVayneD2");
            ContainerController.ManaCoreIceVayne = PlayerPrefs.GetInt("SaveManaCoreIceVayneD2");
            ContainerController.PureObsidian = PlayerPrefs.GetInt("SavePureObsidianD2");
            ContainerController.FireManaGenerator = PlayerPrefs.GetInt("SaveFireManaGeneratorD2");
            ContainerController.IceManaGenerator = PlayerPrefs.GetInt("SaveIceManaGeneratorD2");
            ContainerController.PowderOfLife = PlayerPrefs.GetInt("SavePowderOfLifeD2");
            ContainerController.HoliHP = PlayerPrefs.GetInt("SaveHoliHPD2");
            ContainerController.HoliMP = PlayerPrefs.GetInt("SaveHoliMPD2");
            ContainerController.UltraBom = PlayerPrefs.GetInt("SaveUltraBomD2");
            ContainerController.ReincarnationLife = PlayerPrefs.GetInt("SaveReincarnationLifeD2");
            ContainerController.FireOfPeace = PlayerPrefs.GetInt("SaveFireOfPeaceD2");
            ContainerController.OmnipotentBoundary = PlayerPrefs.GetInt("SaveOmnipotentBoundaryD2");

            //Load ManaSynthesize
            SynthesizeSystem.ManaSynthesize = PlayerPrefs.GetInt("SaveManaSynthesizeD2");
            SynthesizeSystem.ManaFireSynthesize = PlayerPrefs.GetInt("SaveManaFireSynthesizeD2");
            SynthesizeSystem.ManaIceSynthesize = PlayerPrefs.GetInt("SaveManaIceSynthesizeD2");

            //Load map posi
            MapController.WishingHillToZexelTown = false;
            MapController.ZexelTownToTavern = false;
            MapController.TavernToSaveRoom = true;
            MapController.ZexelTownToWishingForest = false;
            MapController.ZexelTownToInfernoDesert = false;
            MapController.ZexelTownToWishingHill = false;
            MapController.TavernToZexelTown = false;
            MapController.SaveRoomToTavern = false;
            MapController.WishingForestToZexelTown = false;
            MapController.InfernoDesertToZexelTown = false;
            MapController.InfernoDesertToZexelGate = false;
            MapController.ZexelGateToInfernoDesert = false;
            MapController.InfernoDesertToManaGate = false;
            MapController.ManaGateToInfernoDesert = false;
            MapController.InfernoDesertToInfernoVolcano = false;
            MapController.InfernoVolcanoToInfernoDesert = false;
            MapController.InfernoDesertToInfernoIce = false;
            MapController.InfernoIceToInfernoDesert = false;
            MapController.InfernoDesertToManaCliff = false;
            MapController.ManaCliffToInfernoDesert = false;
            MapController.ManaGateToManaDimension = false;
            MapController.ManaDimensionToManaGate = false;
            MapController.ManaDimensionToManaTemple = false;
            MapController.ManaTempleToManaDimension = false;
            MapController.InfernoVolcanoToInsideVolcanoCave = false;
            MapController.InsideVolcanoCaveToInfernoVolcano = false;
            MapController.InfernoVolcanoToAltaInferno = false;
            MapController.AltaInfernoToInfernoVolcano = false;
            MapController.InfernoIceToInsideIceCave = false;
            MapController.InsideIceCaveToInfernoIce = false;
            MapController.InfernoIceToAltaInferno = false;
            MapController.AltaInfernoToInfernoIce = false;
            MapController.ZexelGateToZexelTemple = false;
            MapController.ZexelTempleToZexelGate = false;

            SceneManager.LoadScene("Save room");
        }
    }
    public void PressLoadGameData3()
    {
        if (PlayerPrefs.GetInt("SaveGameD3") == 1)
        {
            LoadGameCheck = true;

            //Load map
            Player.MapIndex = 1;

            //Load date
            DateController.GlobalDayNight = PlayerPrefs.GetInt("SaveGlobalDayNightD3");
            DateController.GlobalTime = PlayerPrefs.GetFloat("SaveGlobalTimeD3");
            DateController.GlobalUpHour = PlayerPrefs.GetInt("SaveGlobalUpHourD3");
            DateController.GlobalPHour = PlayerPrefs.GetInt("SaveGlobalPHourD3");
            DateController.GlobalDownHour = PlayerPrefs.GetInt("SaveGlobalDownHourD3");

            //Set cut
            CutscenesController.cus1 = PlayerPrefs.GetInt("Savecus1D3");
            CutscenesController.cus2 = PlayerPrefs.GetInt("Savecus2D3");
            CutscenesController.cus3 = PlayerPrefs.GetInt("Savecus3D3");
            CutscenesController.cus4 = PlayerPrefs.GetInt("Savecus4D3");
            CutscenesController.cus5 = PlayerPrefs.GetInt("Savecus5D3");
            CutscenesController.cus6 = PlayerPrefs.GetInt("Savecus6D3");
            CutscenesController.cus7 = PlayerPrefs.GetInt("Savecus7D3");
            CutscenesController.cus8 = PlayerPrefs.GetInt("Savecus8D3");
            CutscenesController.cus9 = PlayerPrefs.GetInt("Savecus9D3");
            CutscenesController.cus10 = PlayerPrefs.GetInt("Savecus10D3");
            CutscenesController.cus11 = PlayerPrefs.GetInt("Savecus11D3");
            CutscenesController.cus12 = PlayerPrefs.GetInt("Savecus12D3");
            CutscenesController.cus13 = PlayerPrefs.GetInt("Savecus13D3");
            CutscenesController.cus14 = PlayerPrefs.GetInt("Savecus14D3");
            CutscenesController.cus15 = PlayerPrefs.GetInt("Savecus15D3");
            CutscenesController.cus16 = PlayerPrefs.GetInt("Savecus16D3");
            CutscenesController.cus17 = PlayerPrefs.GetInt("Savecus17D3");
            CutscenesController.cus18 = PlayerPrefs.GetInt("Savecus18D3");
            CutscenesController.cus19 = PlayerPrefs.GetInt("Savecus19D3");
            CutscenesController.cus20 = PlayerPrefs.GetInt("Savecus20D3");
            CutscenesController.cus21 = PlayerPrefs.GetInt("Savecus21D3");
            CutscenesController.cus22 = PlayerPrefs.GetInt("Savecus22D3");
            CutscenesController.cus23 = PlayerPrefs.GetInt("Savecus23D3");
            CutscenesController.cus24 = PlayerPrefs.GetInt("Savecus24D3");
            CutscenesController.cus25 = PlayerPrefs.GetInt("Savecus25D3");
            CutscenesController.cus26 = PlayerPrefs.GetInt("Savecus26D3");
            CutscenesController.cus27 = PlayerPrefs.GetInt("Savecus27D3");
            CutscenesController.cus28 = PlayerPrefs.GetInt("Savecus28D3");
            CutscenesController.cus29 = PlayerPrefs.GetInt("Savecus29D3");
            CutscenesController.cus30 = PlayerPrefs.GetInt("Savecus30D3");
            CutscenesController.cus31 = PlayerPrefs.GetInt("Savecus31D3");
            CutscenesController.cus32 = PlayerPrefs.GetInt("Savecus32D3");
            CutscenesController.cus33 = PlayerPrefs.GetInt("Savecus33D3");
            CutscenesController.cus34 = PlayerPrefs.GetInt("Savecus34D3");
            CutscenesController.cus35 = PlayerPrefs.GetInt("Savecus35D3");
            CutscenesController.cus36 = PlayerPrefs.GetInt("Savecus36D3");
            CutscenesController.cus37 = PlayerPrefs.GetInt("Savecus37D3");
            CutscenesController.cus38 = PlayerPrefs.GetInt("Savecus38D3");
            CutscenesController.cus39 = PlayerPrefs.GetInt("Savecus39D3");
            CutscenesController.cus40 = PlayerPrefs.GetInt("Savecus40D3");
            CutscenesController.cus41 = PlayerPrefs.GetInt("Savecus41D3");
            CutscenesController.cus42 = PlayerPrefs.GetInt("Savecus42D3");
            CutscenesController.cus43 = PlayerPrefs.GetInt("Savecus43D3");
            CutscenesController.cus44 = PlayerPrefs.GetInt("Savecus44D3");
            CutscenesController.cus45 = PlayerPrefs.GetInt("Savecus45D3");
            CutscenesController.cus46 = PlayerPrefs.GetInt("Savecus46D3");
            CutscenesController.cus47 = PlayerPrefs.GetInt("Savecus47D3");
            CutscenesController.cus48 = PlayerPrefs.GetInt("Savecus48D3");
            CutscenesController.cus49 = PlayerPrefs.GetInt("Savecus49D3");
            CutscenesController.cus50 = PlayerPrefs.GetInt("Savecus50D3");
            CutscenesController.cus51 = PlayerPrefs.GetInt("Savecus51D3");
            CutscenesController.cus52 = PlayerPrefs.GetInt("Savecus52D3");
            CutscenesController.cus53 = PlayerPrefs.GetInt("Savecus53D3");
            CutscenesController.cus54 = PlayerPrefs.GetInt("Savecus54D3");
            CutscenesController.cus55 = PlayerPrefs.GetInt("Savecus55D3");
            CutscenesController.cus56 = PlayerPrefs.GetInt("Savecus56D3");
            CutscenesController.cus57 = PlayerPrefs.GetInt("Savecus57D3");
            CutscenesController.cus58 = PlayerPrefs.GetInt("Savecus58D3");
            CutscenesController.cus59 = PlayerPrefs.GetInt("Savecus59D3");
            CutscenesController.cus60 = PlayerPrefs.GetInt("Savecus60D3");
            CutscenesController.cus61 = PlayerPrefs.GetInt("Savecus61D3");
            CutscenesController.cus62 = PlayerPrefs.GetInt("Savecus62D3");
            CutscenesController.cus63 = PlayerPrefs.GetInt("Savecus63D3");
            CutscenesController.cus64 = PlayerPrefs.GetInt("Savecus64D3");
            CutscenesController.cus65 = PlayerPrefs.GetInt("Savecus65D3");
            CutscenesController.cus66 = PlayerPrefs.GetInt("Savecus66D3");
            CutscenesController.cus67 = PlayerPrefs.GetInt("Savecus67D3");
            CutscenesController.cus68 = PlayerPrefs.GetInt("Savecus68D3");
            CutscenesController.cus69 = PlayerPrefs.GetInt("Savecus69D3");
            CutscenesController.cus70 = PlayerPrefs.GetInt("Savecus70D3");
            CutscenesController.cus71 = PlayerPrefs.GetInt("Savecus71D3");
            CutscenesController.cus72 = PlayerPrefs.GetInt("Savecus72D3");
            CutscenesController.cus73 = PlayerPrefs.GetInt("Savecus73D3");
            CutscenesController.cus74 = PlayerPrefs.GetInt("Savecus74D3");
            CutscenesController.cus75 = PlayerPrefs.GetInt("Savecus75D3");
            CutscenesController.cus76 = PlayerPrefs.GetInt("Savecus76D3");
            CutscenesController.cus77 = PlayerPrefs.GetInt("Savecus77D3");
            CutscenesController.cus78 = PlayerPrefs.GetInt("Savecus78D3");
            CutscenesController.cus79 = PlayerPrefs.GetInt("Savecus79D3");
            CutscenesController.cus80 = PlayerPrefs.GetInt("Savecus80D3");
            CutscenesController.cus81 = PlayerPrefs.GetInt("Savecus81D3");
            CutscenesController.cus82 = PlayerPrefs.GetInt("Savecus82D3");
            CutscenesController.cus83 = PlayerPrefs.GetInt("Savecus83D3");
            CutscenesController.cus84 = PlayerPrefs.GetInt("Savecus84D3");
            CutscenesController.cus85 = PlayerPrefs.GetInt("Savecus85D3");
            CutscenesController.cus86 = PlayerPrefs.GetInt("Savecus86D3");
            CutscenesController.cus87 = PlayerPrefs.GetInt("Savecus87D3");
            CutscenesController.cus88 = PlayerPrefs.GetInt("Savecus88D3");
            CutscenesController.cus89 = PlayerPrefs.GetInt("Savecus89D3");
            CutscenesController.cus90 = PlayerPrefs.GetInt("Savecus90D3");
            CutscenesController.cus91 = PlayerPrefs.GetInt("Savecus91D3");
            CutscenesController.cus92 = PlayerPrefs.GetInt("Savecus92D3");
            CutscenesController.cus93 = PlayerPrefs.GetInt("Savecus93D3");
            CutscenesController.cus94 = PlayerPrefs.GetInt("Savecus94D3");
            CutscenesController.cus95 = PlayerPrefs.GetInt("Savecus95D3");
            CutscenesController.cus96 = PlayerPrefs.GetInt("Savecus96D3");
            CutscenesController.cus97 = PlayerPrefs.GetInt("Savecus97D3");
            CutscenesController.cus98 = PlayerPrefs.GetInt("Savecus98D3");
            CutscenesController.cus99 = PlayerPrefs.GetInt("Savecus99D3");
            CutscenesController.cus100 = PlayerPrefs.GetInt("Savecus100D3");
            CutscenesController.cus101 = PlayerPrefs.GetInt("Savecus101D3");
            CutscenesController.cus102 = PlayerPrefs.GetInt("Savecus102D3");
            CutscenesController.cus103 = PlayerPrefs.GetInt("Savecus103D3");
            CutscenesController.cus104 = PlayerPrefs.GetInt("Savecus104D3");
            CutscenesController.cus105 = PlayerPrefs.GetInt("Savecus105D3");
            CutscenesController.cus106 = PlayerPrefs.GetInt("Savecus106D3");
            CutscenesController.cus107 = PlayerPrefs.GetInt("Savecus107D3");
            CutscenesController.cus108 = PlayerPrefs.GetInt("Savecus108D3");
            CutscenesController.cus109 = PlayerPrefs.GetInt("Savecus109D3");
            CutscenesController.cus110 = PlayerPrefs.GetInt("Savecus110D3");
            CutscenesController.cus111 = PlayerPrefs.GetInt("Savecus111D3");
            CutscenesController.cus112 = PlayerPrefs.GetInt("Savecus112D3");
            CutscenesController.cus113 = PlayerPrefs.GetInt("Savecus113D3");
            CutscenesController.cus114 = PlayerPrefs.GetInt("Savecus114D3");
            CutscenesController.cus115 = PlayerPrefs.GetInt("Savecus115D3");
            CutscenesController.cus116 = PlayerPrefs.GetInt("Savecus116D3");
            CutscenesController.cus117 = PlayerPrefs.GetInt("Savecus117D3");
            CutscenesController.cus118 = PlayerPrefs.GetInt("Savecus118D3");
            CutscenesController.cus119 = PlayerPrefs.GetInt("Savecus119D3");
            CutscenesController.cus120 = PlayerPrefs.GetInt("Savecus120D3");

            //Load quest
            PlayerPrefs.SetInt("SKGQ", PlayerPrefs.GetInt("SaveKGQD3"));
            GlobalQuest.HelpVillagerStop1 = PlayerPrefs.GetInt("SaveHVStop1D3");
            GlobalQuest.HelpVillagerStop2 = PlayerPrefs.GetInt("SaveHVStop2D3");
            GlobalQuest.HelpVillagerStop3 = PlayerPrefs.GetInt("SaveHVStop3D3");
            GlobalQuest.HelpVillagerDone = PlayerPrefs.GetInt("SaveHVD3");
            CutscenesTrigger.PorridgeSyn = PlayerPrefs.GetInt("SavePorridgeSynD3");
            CutscenesTrigger.BomSyn = PlayerPrefs.GetInt("SaveBomSynD3");
            CutscenesTrigger.GolemnKill = PlayerPrefs.GetInt("SaveGolemnKillD3");
            CutscenesTrigger.InfernoScorpionKill = PlayerPrefs.GetInt("SaveInfernoScorpionKillD3");
            CutscenesTrigger.InfernoScorpionKillP2 = PlayerPrefs.GetInt("SaveInfernoScorpionKillP2D3");
            CutscenesTrigger.IceFangKill = PlayerPrefs.GetInt("SaveIceFangKillD3");
            CutscenesTrigger.GoblinKillP2 = PlayerPrefs.GetInt("SaveGoblinKillP2D3");
            CutscenesTrigger.GolemnKillP2 = PlayerPrefs.GetInt("SaveGolemnKillP2D3");

            //Load point
            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);

            //Load Vayne
            Global.CurHPP1 = PlayerPrefs.GetInt("SaveHPP1D3");
            Global.MaxHPP1 = PlayerPrefs.GetInt("SaveMaxHPP1D3");
            Global.CurMPP1 = PlayerPrefs.GetInt("SaveMPP1D3");
            Global.MaxMPP1 = PlayerPrefs.GetInt("SaveMaxMPP1D3");
            Global.DamageP1 = PlayerPrefs.GetInt("SaveDamageP1D3");
            Global.SpeedP1 = PlayerPrefs.GetInt("SaveSpeedP1D3");
            Global.LevelP1 = PlayerPrefs.GetInt("SaveLevelP1D3");
            Global.MaxEXPP1 = PlayerPrefs.GetInt("SaveMaxEXPP1D3");
            Global.CurEXPP1 = PlayerPrefs.GetInt("SaveCurEXPP1D3");
            Global.PlusPointP1 = PlayerPrefs.GetInt("SavePlusPointP1D3");
            Global.PlusPointAttackLvP1 = PlayerPrefs.GetInt("SavePlusPointAttackLvP1D3");
            Global.PlusPointHPLvP1 = PlayerPrefs.GetInt("SavePlusPointHPLvP1D3");
            Global.PlusPointMPLvP1 = PlayerPrefs.GetInt("SavePlusPointMPLvP1D3");
            Global.PlusPointSpeedLvP1 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP1D3");
            Global.PlusPointAttackInfoP1 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP1D3");
            Global.PlusPointHPInfoP1 = PlayerPrefs.GetInt("SavePlusPointHPInfoP1D3");
            Global.PlusPointMPInfoP1 = PlayerPrefs.GetInt("SavePlusPointMPInfoP1D3");
            Global.PlusPointSpeedInfoP1 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP1D3");

            //Load Alia
            Global.CurHPP2 = PlayerPrefs.GetInt("SaveHPP2D3");
            Global.MaxHPP2 = PlayerPrefs.GetInt("SaveMaxHPP2D3");
            Global.CurMPP2 = PlayerPrefs.GetInt("SaveMPP2D3");
            Global.MaxMPP2 = PlayerPrefs.GetInt("SaveMaxMPP2D3");
            Global.DamageP2 = PlayerPrefs.GetInt("SaveDamageP2D3");
            Global.SpeedP2 = PlayerPrefs.GetInt("SaveSpeedP2D3");
            Global.LevelP2 = PlayerPrefs.GetInt("SaveLevelP2D3");
            Global.MaxEXPP2 = PlayerPrefs.GetInt("SaveMaxEXPP2D3");
            Global.CurEXPP2 = PlayerPrefs.GetInt("SaveCurEXPP2D3");
            Global.PlusPointP2 = PlayerPrefs.GetInt("SavePlusPointP2D3");
            Global.PlusPointAttackLvP2 = PlayerPrefs.GetInt("SavePlusPointAttackLvP2D3");
            Global.PlusPointHPLvP2 = PlayerPrefs.GetInt("SavePlusPointHPLvP2D3");
            Global.PlusPointMPLvP2 = PlayerPrefs.GetInt("SavePlusPointMPLvP2D3");
            Global.PlusPointSpeedLvP2 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP2D3");
            Global.PlusPointAttackInfoP2 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP2D3");
            Global.PlusPointHPInfoP2 = PlayerPrefs.GetInt("SavePlusPointHPInfoP2D3");
            Global.PlusPointMPInfoP2 = PlayerPrefs.GetInt("SavePlusPointMPInfoP2D3");
            Global.PlusPointSpeedInfoP2 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP2D3");

            //Load Maria
            Global.CurHPP3 = PlayerPrefs.GetInt("SaveHPP3D3");
            Global.MaxHPP3 = PlayerPrefs.GetInt("SaveMaxHPP3D3");
            Global.CurMPP3 = PlayerPrefs.GetInt("SaveMPP3D3");
            Global.MaxMPP3 = PlayerPrefs.GetInt("SaveMaxMPP3D3");
            Global.DamageP3 = PlayerPrefs.GetInt("SaveDamageP3D3");
            Global.SpeedP3 = PlayerPrefs.GetInt("SaveSpeedP3D3");
            Global.LevelP3 = PlayerPrefs.GetInt("SaveLevelP3D3");
            Global.MaxEXPP3 = PlayerPrefs.GetInt("SaveMaxEXPP3D3");
            Global.CurEXPP3 = PlayerPrefs.GetInt("SaveCurEXPP3D3");
            Global.PlusPointP3 = PlayerPrefs.GetInt("SavePlusPointP3D3");
            Global.PlusPointAttackLvP3 = PlayerPrefs.GetInt("SavePlusPointAttackLvP3D3");
            Global.PlusPointHPLvP3 = PlayerPrefs.GetInt("SavePlusPointHPLvP3D3");
            Global.PlusPointMPLvP3 = PlayerPrefs.GetInt("SavePlusPointMPLvP3D3");
            Global.PlusPointSpeedLvP3 = PlayerPrefs.GetInt("SavePlusPointSpeedLvP3D3");
            Global.PlusPointAttackInfoP3 = PlayerPrefs.GetInt("SavePlusPointAttackInfoP3D3");
            Global.PlusPointHPInfoP3 = PlayerPrefs.GetInt("SavePlusPointHPInfoP3D3");
            Global.PlusPointMPInfoP3 = PlayerPrefs.GetInt("SavePlusPointMPInfoP3D3");
            Global.PlusPointSpeedInfoP3 = PlayerPrefs.GetInt("SavePlusPointSpeedInfoP3D3");

            //Load Zen
            Global.Zen = PlayerPrefs.GetInt("SaveZenD3");

            //Load Weapon
            Global.VayneStaff1 = PlayerPrefs.GetInt("SaveVayneStaff1D3");
            Global.VayneStaff2 = PlayerPrefs.GetInt("SaveVayneStaff2D3");
            Global.VayneStaff3 = PlayerPrefs.GetInt("SaveVayneStaff3D3");
            Global.AliaShoes1 = PlayerPrefs.GetInt("SaveAliaShoes1D3");
            Global.AliaShoes2 = PlayerPrefs.GetInt("SaveAliaShoes2D3");
            Global.AliaShoes3 = PlayerPrefs.GetInt("SaveAliaShoes3D3");
            Global.MariaCrystal1 = PlayerPrefs.GetInt("SaveMariaCrystal1D3");
            Global.MariaCrystal2 = PlayerPrefs.GetInt("SaveMariaCrystal2D3");
            Global.MariaCrystal3 = PlayerPrefs.GetInt("SaveMariaCrystal3D3");
            Global.AlchemistArmor1 = PlayerPrefs.GetInt("SaveAlchemistArmor1D3");
            Global.AlchemistArmor2 = PlayerPrefs.GetInt("SaveAlchemistArmor2D3");
            Global.AlchemistArmor3 = PlayerPrefs.GetInt("SaveAlchemistArmor3D3");
            Global.WarriorArmor1 = PlayerPrefs.GetInt("SaveWarriorArmor1D3");
            Global.WarriorArmor2 = PlayerPrefs.GetInt("SaveWarriorArmor2D3");
            Global.WarriorArmor3 = PlayerPrefs.GetInt("SaveWarriorArmor3D3");

            //Load weapon status
            Global.VayneWeaponStatus = PlayerPrefs.GetInt("SaveVayneWeaponStatusD3");
            Global.VayneArmorStatus = PlayerPrefs.GetInt("SaveVayneArmorStatusD3");
            Global.AliaWeaponStatus = PlayerPrefs.GetInt("SaveAliaWeaponStatusD3");
            Global.AliaArmorStatus = PlayerPrefs.GetInt("SaveAliaArmorStatusD3");
            Global.MariaWeaponStatus = PlayerPrefs.GetInt("SaveMariaWeaponStatusD3");
            Global.MariaArmorStatus = PlayerPrefs.GetInt("SaveMariaArmorStatusD3");

            //Load weapon had bought
            WeaponStoreController.Bought1 = PlayerPrefs.GetInt("SaveBought1D3");
            WeaponStoreController.Bought2 = PlayerPrefs.GetInt("SaveBought2D3");
            WeaponStoreController.Bought3 = PlayerPrefs.GetInt("SaveBought3D3");
            WeaponStoreController.Bought4 = PlayerPrefs.GetInt("SaveBought4D3");
            WeaponStoreController.Bought5 = PlayerPrefs.GetInt("SaveBought5D3");
            WeaponStoreController.Bought6 = PlayerPrefs.GetInt("SaveBought6D3");
            WeaponStoreController.Bought7 = PlayerPrefs.GetInt("SaveBought7D3");
            WeaponStoreController.Bought8 = PlayerPrefs.GetInt("SaveBought8D3");
            WeaponStoreController.Bought9 = PlayerPrefs.GetInt("SaveBought9D3");
            WeaponStoreController.Bought10 = PlayerPrefs.GetInt("SaveBought10D3");
            WeaponStoreController.Bought11 = PlayerPrefs.GetInt("SaveBought11D3");
            WeaponStoreController.Bought12 = PlayerPrefs.GetInt("SaveBought12D3");
            WeaponStoreController.Bought13 = PlayerPrefs.GetInt("SaveBought13D3");
            WeaponStoreController.Bought14 = PlayerPrefs.GetInt("SaveBought14D3");
            WeaponStoreController.Bought15 = PlayerPrefs.GetInt("SaveBought15D3");

            //Load item material
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDriedLeavesD3");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePureWaterD3");
            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMorningDropD3");
            ContainerController.Wheat = PlayerPrefs.GetInt("SaveWheatD3");
            ContainerController.Wood = PlayerPrefs.GetInt("SaveWoodD3");
            ContainerController.String = PlayerPrefs.GetInt("SaveStringD3");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveIronD3");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveManaGemD3");
            ContainerController.ScorpionVenom = PlayerPrefs.GetInt("SaveScorpionVenomD3");
            ContainerController.InfernoSand = PlayerPrefs.GetInt("SaveInfernoSandD3");
            ContainerController.ManaLiquid = PlayerPrefs.GetInt("SaveManaLiquidD3");
            ContainerController.ManaOre = PlayerPrefs.GetInt("SaveManaOreD3");
            ContainerController.ManaCrystal = PlayerPrefs.GetInt("SaveManaCrystalD3"); ;
            ContainerController.GuardianFeather = PlayerPrefs.GetInt("SaveGuardianFeatherD3");
            ContainerController.FireOre = PlayerPrefs.GetInt("SaveFireOreD3");
            ContainerController.GoldenFeather = PlayerPrefs.GetInt("SaveGoldenFeatherD3");
            ContainerController.RedManaCrystal = PlayerPrefs.GetInt("SaveRedManaCrystalD3");
            ContainerController.Obsidian = PlayerPrefs.GetInt("SaveObsidianD3");
            ContainerController.IceOre = PlayerPrefs.GetInt("SaveIceOreD3");
            ContainerController.IceLeather = PlayerPrefs.GetInt("SaveIceLeatherD3");
            ContainerController.BlueManaCrystal = PlayerPrefs.GetInt("SaveBlueManaCrystalD3");
            ContainerController.RedManaSlimeBall = PlayerPrefs.GetInt("SaveRedManaSlimeBallD3");
            ContainerController.BlueManaSlimeBall = PlayerPrefs.GetInt("SaveBlueManaSlimeBallD3");
            ContainerController.ManaCoreFireZexel = PlayerPrefs.GetInt("SaveManaCoreFireZexelD3");
            ContainerController.ManaCoreIceZexel = PlayerPrefs.GetInt("SaveManaCoreIceZexelD3");
            ContainerController.Rock = PlayerPrefs.GetInt("SaveRockD3");
            ContainerController.NatureGrass = PlayerPrefs.GetInt("SaveNatureGrassD3");
            ContainerController.ManaDust = PlayerPrefs.GetInt("SaveManaDustD3");
            ContainerController.ManaEagleFeather = PlayerPrefs.GetInt("SaveManaEagleFeatherD3");
            ContainerController.IceCrystal = PlayerPrefs.GetInt("SaveIceCrystalD3");

            //Load item
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHealPotionD3");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveManaPotionD3");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveElixirPotionD3");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBomD3");
            ContainerController.Porridge = PlayerPrefs.GetInt("SavePorridgeD3");
            ContainerController.ManaCloth = PlayerPrefs.GetInt("SaveManaClothD3");
            ContainerController.ManaShield = PlayerPrefs.GetInt("SaveManaShieldD3");
            ContainerController.VenomKiller = PlayerPrefs.GetInt("SaveVenomKillerD3");
            ContainerController.ManaNecklace = PlayerPrefs.GetInt("SaveManaNecklaceD3");
            ContainerController.ManaGenerator = PlayerPrefs.GetInt("SaveManaGeneratorD3");
            ContainerController.Baxiata = PlayerPrefs.GetInt("SaveBaxiataD3");
            ContainerController.BaxiataGem = PlayerPrefs.GetInt("SaveBaxiataGemD3");
            ContainerController.Photonria = PlayerPrefs.GetInt("SavePhotonriaD3");
            ContainerController.PhotonriaGem = PlayerPrefs.GetInt("SavePhotonriaGemD3");
            ContainerController.ManaLiquidCatalyst = PlayerPrefs.GetInt("SaveManaLiquidCatalystD3");
            ContainerController.RedLiquidCatalyst = PlayerPrefs.GetInt("SaveRedLiquidCatalystD3");
            ContainerController.BlueLiquidCatalyst = PlayerPrefs.GetInt("SaveBlueLiquidCatalystD3");
            ContainerController.ManaCoreFireVayne = PlayerPrefs.GetInt("SaveManaCoreFireVayneD3");
            ContainerController.ManaCoreIceVayne = PlayerPrefs.GetInt("SaveManaCoreIceVayneD3");
            ContainerController.PureObsidian = PlayerPrefs.GetInt("SavePureObsidianD3");
            ContainerController.FireManaGenerator = PlayerPrefs.GetInt("SaveFireManaGeneratorD3");
            ContainerController.IceManaGenerator = PlayerPrefs.GetInt("SaveIceManaGeneratorD3");
            ContainerController.PowderOfLife = PlayerPrefs.GetInt("SavePowderOfLifeD3");
            ContainerController.HoliHP = PlayerPrefs.GetInt("SaveHoliHPD3");
            ContainerController.HoliMP = PlayerPrefs.GetInt("SaveHoliMPD3");
            ContainerController.UltraBom = PlayerPrefs.GetInt("SaveUltraBomD3");
            ContainerController.ReincarnationLife = PlayerPrefs.GetInt("SaveReincarnationLifeD3");
            ContainerController.FireOfPeace = PlayerPrefs.GetInt("SaveFireOfPeaceD3");
            ContainerController.OmnipotentBoundary = PlayerPrefs.GetInt("SaveOmnipotentBoundaryD3");

            //Load ManaSynthesize
            SynthesizeSystem.ManaSynthesize = PlayerPrefs.GetInt("SaveManaSynthesizeD3");
            SynthesizeSystem.ManaFireSynthesize = PlayerPrefs.GetInt("SaveManaFireSynthesizeD3");
            SynthesizeSystem.ManaIceSynthesize = PlayerPrefs.GetInt("SaveManaIceSynthesizeD3");

            //Load map posi
            MapController.WishingHillToZexelTown = false;
            MapController.ZexelTownToTavern = false;
            MapController.TavernToSaveRoom = true;
            MapController.ZexelTownToWishingForest = false;
            MapController.ZexelTownToInfernoDesert = false;
            MapController.ZexelTownToWishingHill = false;
            MapController.TavernToZexelTown = false;
            MapController.SaveRoomToTavern = false;
            MapController.WishingForestToZexelTown = false;
            MapController.InfernoDesertToZexelTown = false;
            MapController.InfernoDesertToZexelGate = false;
            MapController.ZexelGateToInfernoDesert = false;
            MapController.InfernoDesertToManaGate = false;
            MapController.ManaGateToInfernoDesert = false;
            MapController.InfernoDesertToInfernoVolcano = false;
            MapController.InfernoVolcanoToInfernoDesert = false;
            MapController.InfernoDesertToInfernoIce = false;
            MapController.InfernoIceToInfernoDesert = false;
            MapController.InfernoDesertToManaCliff = false;
            MapController.ManaCliffToInfernoDesert = false;
            MapController.ManaGateToManaDimension = false;
            MapController.ManaDimensionToManaGate = false;
            MapController.ManaDimensionToManaTemple = false;
            MapController.ManaTempleToManaDimension = false;
            MapController.InfernoVolcanoToInsideVolcanoCave = false;
            MapController.InsideVolcanoCaveToInfernoVolcano = false;
            MapController.InfernoVolcanoToAltaInferno = false;
            MapController.AltaInfernoToInfernoVolcano = false;
            MapController.InfernoIceToInsideIceCave = false;
            MapController.InsideIceCaveToInfernoIce = false;
            MapController.InfernoIceToAltaInferno = false;
            MapController.AltaInfernoToInfernoIce = false;
            MapController.ZexelGateToZexelTemple = false;
            MapController.ZexelTempleToZexelGate = false;

            SceneManager.LoadScene("Save room");
        }
    }
    public void PressDLGameD1()
    {
        PlayerPrefs.SetInt("SaveGameD1", 0);
    }
    public void PressDLGameD2()
    {
        PlayerPrefs.SetInt("SaveGameD2", 0);
    }
    public void PressDLGameD3()
    {
        PlayerPrefs.SetInt("SaveGameD3", 0);
    }
    public void BackButton()
    {
        LoadGamePanel.SetActive(false);
    }

    public void SettingPanelOpen()
    {
        SettingPanel.SetActive(true);

        GameSetting.SetActive(true);
        GraphicSetting.SetActive(false);
        SoundSetting.SetActive(false);

        GameSettingButton.GetComponent<Image>().color = Color.green;
        GraphicSettingButton.GetComponent<Image>().color = Color.white;
        SoundSettingButton.GetComponent<Image>().color = Color.white;
    }

    public void GameSettingOn()
    {
        GameSetting.SetActive(true);
        GraphicSetting.SetActive(false);
        SoundSetting.SetActive(false);

        GameSettingButton.GetComponent<Image>().color = Color.green;
        GraphicSettingButton.GetComponent<Image>().color = Color.white;
        SoundSettingButton.GetComponent<Image>().color = Color.white;
    }

    public void GameDiffucltL()
    {
        DifficultChooseText.text = "Normal";
    }

    public void GameDiffucltR()
    {
        DifficultChooseText.text = "Hard";
    }

    public void GamePlotLangueL()
    {
        PlotLangueChooseText.text = "English";
    }

    public void GamePlotLangueR()
    {
        PlotLangueChooseText.text = "Vietnamese";
    }

    public void GraphicSettingOn()
    {
        GameSetting.SetActive(false);
        GraphicSetting.SetActive(true);
        SoundSetting.SetActive(false);

        GameSettingButton.GetComponent<Image>().color = Color.white;
        GraphicSettingButton.GetComponent<Image>().color = Color.green;
        SoundSettingButton.GetComponent<Image>().color = Color.white;
    }

    public void SoundSettingOn()
    {
        GameSetting.SetActive(false);
        GraphicSetting.SetActive(false);
        SoundSetting.SetActive(true);

        GameSettingButton.GetComponent<Image>().color = Color.white;
        GraphicSettingButton.GetComponent<Image>().color = Color.white;
        SoundSettingButton.GetComponent<Image>().color = Color.green;
    }

    public void SettingPanelClose()
    {
        SettingPanel.SetActive(false);
    }

    public void PressExit()
    {
        Application.Quit();
    }
}
