using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject LoadGamePanel, SettingPanel, GameSetting, GraphicSetting, SoundSetting, GameSettingButton, GraphicSettingButton, SoundSettingButton;
    public GameObject FadeOutPanel, FadeInPanel, AskDeleteLoadGamePanel;
    public Text DifficultChooseText, PlotLangueChooseText;
    public Text showdata1;
    public Text showdata2;
    public Text showdata3;
    public AudioSource MenuBGM;
    public AudioSource ClickFX;

    public int LoadGameIndex, DeleteLoadGameIndex;
    public string loadPath, CryptedPassword;
    public static bool LoadGameCheck;

    string userPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    void Start()
    {
        MenuBGM.Play();

        StartCoroutine(DelayFadeOutOff());

        LoadGameCheck = false;
        LoadGameIndex = 0;
        DeleteLoadGameIndex = 0;
    }

    void Update()
    {
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd.PRD"}"))
            showdata1.text = "Data Save!";
        else
            showdata1.text = "No Data!";
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd.PRD"}"))
            showdata2.text = "Data Save!";
        else
            showdata2.text = "No Data!";
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd.PRD"}"))
            showdata3.text = "Data Save!";
        else
            showdata3.text = "No Data!";
    }
    public void PressStartNewGame()
    {
        ClickFX.Play();

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
        CutscenesController.cus0 = 0;
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

        Global.CurHPP2 = 840;
        Global.MaxHPP2 = 840;
        Global.CurMPP2 = 121;
        Global.MaxMPP2 = 121;
        Global.DamageP2 = 450;
        Global.SpeedP2 = 40;
        Global.LevelP2 = 30;
        Global.MaxEXPP2 = 80;
        Global.CurEXPP2 = 0;

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
        ContainerController.HealPotion = 1;
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

        StartCoroutine(DelayChangeCutscense());
        //SceneManager.LoadScene("BSZane 1");
    }

    public void PressLoadGame()
    {
        ClickFX.Play();

        LoadGamePanel.SetActive(true);
    }

    public void PressLoadGameData1()
    {
        ClickFX.Play();

        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd.PRD"}"))
        {
            LoadGameIndex = 1;
            LoadGameProcess();
        }
    }
    public void PressLoadGameData2()
    {
        ClickFX.Play();

        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd.PRD"}"))
        {
            LoadGameIndex = 2;
            LoadGameProcess();
        }
    }
    public void PressLoadGameData3()
    {
        ClickFX.Play();

        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd.PRD"}"))
        {
            LoadGameIndex = 3;
            LoadGameProcess();
        }
    }

    public void LoadGameProcess()
    {
        LoadGameCheck = true;

        if (LoadGameIndex == 1)
        {
            loadPath = userPath + "/PRD Team/SaveData01/SaveD1.prd";
        }
        else if (LoadGameIndex == 2)
        {
            loadPath = userPath + "/PRD Team/SaveData02/SaveD2.prd";
        }
        else if (LoadGameIndex == 3)
        {
            loadPath = userPath + "/PRD Team/SaveData03/SaveD3.prd";
        }

        CryptSaveData csd1 = new CryptSaveData(loadPath + ".PRD", CryptedPassword);
        csd1.DecryptedSaveData();

        string json = File.ReadAllText(loadPath);
        SaveDataGlobal sdg = JsonUtility.FromJson<SaveDataGlobal>(json);

        //Load map
        Player.MapIndex = 1;

        //Load date
        DateController.GlobalDayNight = sdg.SaveGlobalDayNight;
        DateController.GlobalTime = sdg.SaveGlobalTime;
        DateController.GlobalUpHour = sdg.SaveGlobalUpHour;
        DateController.GlobalPHour = sdg.SaveGlobalPHour;
        DateController.GlobalDownHour = sdg.SaveGlobalDownHour;

        //Load cutscene
        CutscenesController.cus0 = sdg.Savecus0;
        CutscenesController.cus1 = sdg.Savecus1;
        CutscenesController.cus2 = sdg.Savecus2;
        CutscenesController.cus3 = sdg.Savecus3;
        CutscenesController.cus4 = sdg.Savecus4;
        CutscenesController.cus5 = sdg.Savecus5;
        CutscenesController.cus6 = sdg.Savecus6;
        CutscenesController.cus7 = sdg.Savecus7;
        CutscenesController.cus8 = sdg.Savecus8;
        CutscenesController.cus9 = sdg.Savecus9;
        CutscenesController.cus10 = sdg.Savecus10;
        CutscenesController.cus11 = sdg.Savecus11;
        CutscenesController.cus12 = sdg.Savecus12;
        CutscenesController.cus13 = sdg.Savecus13;
        CutscenesController.cus14 = sdg.Savecus14;
        CutscenesController.cus15 = sdg.Savecus15;
        CutscenesController.cus16 = sdg.Savecus16;
        CutscenesController.cus17 = sdg.Savecus17;
        CutscenesController.cus18 = sdg.Savecus18;
        CutscenesController.cus19 = sdg.Savecus19;
        CutscenesController.cus20 = sdg.Savecus20;
        CutscenesController.cus21 = sdg.Savecus21;
        CutscenesController.cus22 = sdg.Savecus22;
        CutscenesController.cus23 = sdg.Savecus23;
        CutscenesController.cus24 = sdg.Savecus24;
        CutscenesController.cus25 = sdg.Savecus25;
        CutscenesController.cus26 = sdg.Savecus26;
        CutscenesController.cus27 = sdg.Savecus27;
        CutscenesController.cus28 = sdg.Savecus28;
        CutscenesController.cus29 = sdg.Savecus29;
        CutscenesController.cus30 = sdg.Savecus30;
        CutscenesController.cus31 = sdg.Savecus31;
        CutscenesController.cus32 = sdg.Savecus32;
        CutscenesController.cus33 = sdg.Savecus33;
        CutscenesController.cus34 = sdg.Savecus34;
        CutscenesController.cus35 = sdg.Savecus35;
        CutscenesController.cus36 = sdg.Savecus36;
        CutscenesController.cus37 = sdg.Savecus37;
        CutscenesController.cus38 = sdg.Savecus38;
        CutscenesController.cus39 = sdg.Savecus39;
        CutscenesController.cus40 = sdg.Savecus40;
        CutscenesController.cus41 = sdg.Savecus41;
        CutscenesController.cus42 = sdg.Savecus42;
        CutscenesController.cus43 = sdg.Savecus43;
        CutscenesController.cus44 = sdg.Savecus44;
        CutscenesController.cus45 = sdg.Savecus45;
        CutscenesController.cus46 = sdg.Savecus46;
        CutscenesController.cus47 = sdg.Savecus47;
        CutscenesController.cus48 = sdg.Savecus48;
        CutscenesController.cus49 = sdg.Savecus49;
        CutscenesController.cus50 = sdg.Savecus50;
        CutscenesController.cus51 = sdg.Savecus51;
        CutscenesController.cus52 = sdg.Savecus52;
        CutscenesController.cus53 = sdg.Savecus53;
        CutscenesController.cus54 = sdg.Savecus54;
        CutscenesController.cus55 = sdg.Savecus55;
        CutscenesController.cus56 = sdg.Savecus56;
        CutscenesController.cus57 = sdg.Savecus57;
        CutscenesController.cus58 = sdg.Savecus58;
        CutscenesController.cus59 = sdg.Savecus59;
        CutscenesController.cus60 = sdg.Savecus60;
        CutscenesController.cus61 = sdg.Savecus61;
        CutscenesController.cus62 = sdg.Savecus62;
        CutscenesController.cus63 = sdg.Savecus63;
        CutscenesController.cus64 = sdg.Savecus64;
        CutscenesController.cus65 = sdg.Savecus65;
        CutscenesController.cus66 = sdg.Savecus66;
        CutscenesController.cus67 = sdg.Savecus67;
        CutscenesController.cus68 = sdg.Savecus68;
        CutscenesController.cus69 = sdg.Savecus69;
        CutscenesController.cus70 = sdg.Savecus70;
        CutscenesController.cus71 = sdg.Savecus71;
        CutscenesController.cus72 = sdg.Savecus72;
        CutscenesController.cus73 = sdg.Savecus73;
        CutscenesController.cus74 = sdg.Savecus74;
        CutscenesController.cus75 = sdg.Savecus75;
        CutscenesController.cus76 = sdg.Savecus76;
        CutscenesController.cus77 = sdg.Savecus77;
        CutscenesController.cus78 = sdg.Savecus78;
        CutscenesController.cus79 = sdg.Savecus79;
        CutscenesController.cus80 = sdg.Savecus80;
        CutscenesController.cus81 = sdg.Savecus81;
        CutscenesController.cus82 = sdg.Savecus82;
        CutscenesController.cus83 = sdg.Savecus83;
        CutscenesController.cus84 = sdg.Savecus84;
        CutscenesController.cus85 = sdg.Savecus85;
        CutscenesController.cus86 = sdg.Savecus86;
        CutscenesController.cus87 = sdg.Savecus87;
        CutscenesController.cus88 = sdg.Savecus88;
        CutscenesController.cus89 = sdg.Savecus89;
        CutscenesController.cus90 = sdg.Savecus90;
        CutscenesController.cus91 = sdg.Savecus91;
        CutscenesController.cus92 = sdg.Savecus92;
        CutscenesController.cus93 = sdg.Savecus93;
        CutscenesController.cus94 = sdg.Savecus94;
        CutscenesController.cus95 = sdg.Savecus95;
        CutscenesController.cus96 = sdg.Savecus96;
        CutscenesController.cus97 = sdg.Savecus97;
        CutscenesController.cus98 = sdg.Savecus98;
        CutscenesController.cus99 = sdg.Savecus99;
        CutscenesController.cus100 = sdg.Savecus100;
        CutscenesController.cus101 = sdg.Savecus101;
        CutscenesController.cus102 = sdg.Savecus102;
        CutscenesController.cus103 = sdg.Savecus103;
        CutscenesController.cus104 = sdg.Savecus104;
        CutscenesController.cus105 = sdg.Savecus105;
        CutscenesController.cus106 = sdg.Savecus106;
        CutscenesController.cus107 = sdg.Savecus107;
        CutscenesController.cus108 = sdg.Savecus108;
        CutscenesController.cus109 = sdg.Savecus109;
        CutscenesController.cus110 = sdg.Savecus110;
        CutscenesController.cus111 = sdg.Savecus111;
        CutscenesController.cus112 = sdg.Savecus112;
        CutscenesController.cus113 = sdg.Savecus113;
        CutscenesController.cus114 = sdg.Savecus114;
        CutscenesController.cus115 = sdg.Savecus115;
        CutscenesController.cus116 = sdg.Savecus116;
        CutscenesController.cus117 = sdg.Savecus117;
        CutscenesController.cus118 = sdg.Savecus118;
        CutscenesController.cus119 = sdg.Savecus119;
        CutscenesController.cus120 = sdg.Savecus120;
        CutscenesController.cus121 = sdg.Savecus121;
        CutscenesController.cus122 = sdg.Savecus122;
        CutscenesController.cus123 = sdg.Savecus123;
        CutscenesController.cus124 = sdg.Savecus124;
        CutscenesController.cus125 = sdg.Savecus125;
        CutscenesController.cus126 = sdg.Savecus126;
        CutscenesController.cus127 = sdg.Savecus127;
        CutscenesController.cus128 = sdg.Savecus128;
        CutscenesController.cus129 = sdg.Savecus129;
        CutscenesController.cus130 = sdg.Savecus130;
        CutscenesController.cus131 = sdg.Savecus131;
        CutscenesController.cus132 = sdg.Savecus132;
        CutscenesController.cus133 = sdg.Savecus133;
        CutscenesController.cus134 = sdg.Savecus134;
        CutscenesController.cus135 = sdg.Savecus135;
        CutscenesController.cus136 = sdg.Savecus136;
        CutscenesController.cus137 = sdg.Savecus137;
        CutscenesController.cus138 = sdg.Savecus138;
        CutscenesController.cus139 = sdg.Savecus139;
        CutscenesController.cus140 = sdg.Savecus140;
        CutscenesController.cus141 = sdg.Savecus141;
        CutscenesController.cus142 = sdg.Savecus142;
        CutscenesController.cus143 = sdg.Savecus143;
        CutscenesController.cus144 = sdg.Savecus144;

        //Load quest
        GlobalQuest.KillGoblinQuest = sdg.SaveKGQ;
        GlobalQuest.HelpVillagerStop1 = sdg.SaveHVStop1;
        GlobalQuest.HelpVillagerStop2 = sdg.SaveHVStop2;
        GlobalQuest.HelpVillagerStop3 = sdg.SaveHVStop3;
        GlobalQuest.HelpVillagerDone = sdg.SaveHV;
        CutscenesTrigger.PorridgeSyn = sdg.SavePorridgeSyn;
        CutscenesTrigger.BomSyn = sdg.SaveBomSyn;
        CutscenesTrigger.GolemnKill = sdg.SaveGolemnKill;
        CutscenesTrigger.InfernoScorpionKill = sdg.SaveInfernoScorpionKill;
        CutscenesTrigger.InfernoScorpionKillP2 = sdg.SaveInfernoScorpionKillP2;
        CutscenesTrigger.IceFangKill = sdg.SaveIceFangKill;
        CutscenesTrigger.GoblinKillP2 = sdg.SaveGoblinKillP2;
        CutscenesTrigger.GolemnKillP2 = sdg.SaveGolemnKillP2;

        //Load position 
        PlayerPrefs.SetFloat("x", 6);
        PlayerPrefs.SetFloat("y", -3);
        PlayerPrefs.SetFloat("z", 0);

        //Load Vayne
        Global.CurHPP1 = sdg.SaveHPP1;
        Global.MaxHPP1 = sdg.SaveMaxHPP1;
        Global.CurMPP1 = sdg.SaveMPP1;
        Global.MaxMPP1 = sdg.SaveMaxMPP1;
        Global.DamageP1 = sdg.SaveDamageP1;
        Global.SpeedP1 = sdg.SaveSpeedP1;
        Global.LevelP1 = sdg.SaveLevelP1;
        Global.MaxEXPP1 = sdg.SaveMaxEXPP1;
        Global.CurEXPP1 = sdg.SaveCurEXPP1;
        Global.PlusPointP1 = sdg.SavePlusPointP1;
        Global.PlusPointAttackLvP1 = sdg.SavePlusPointAttackLvP1;
        Global.PlusPointHPLvP1 = sdg.SavePlusPointHPLvP1;
        Global.PlusPointMPLvP1 = sdg.SavePlusPointMPLvP1;
        Global.PlusPointSpeedLvP1 = sdg.SavePlusPointSpeedLvP1;
        Global.PlusPointAttackInfoP1 = sdg.SavePlusPointAttackInfoP1;
        Global.PlusPointHPInfoP1 = sdg.SavePlusPointHPInfoP1;
        Global.PlusPointMPInfoP1 = sdg.SavePlusPointMPInfoP1;
        Global.PlusPointSpeedInfoP1 = sdg.SavePlusPointSpeedInfoP1;

        //Load Alia
        Global.CurHPP2 = sdg.SaveHPP2;
        Global.MaxHPP2 = sdg.SaveMaxHPP2;
        Global.CurMPP2 = sdg.SaveMPP2;
        Global.MaxMPP2 = sdg.SaveMaxMPP2;
        Global.DamageP2 = sdg.SaveDamageP2;
        Global.SpeedP2 = sdg.SaveSpeedP2;
        Global.LevelP2 = sdg.SaveLevelP2;
        Global.MaxEXPP2 = sdg.SaveMaxEXPP2;
        Global.CurEXPP2 = sdg.SaveCurEXPP2;
        Global.PlusPointP2 = sdg.SavePlusPointP2;
        Global.PlusPointAttackLvP2 = sdg.SavePlusPointAttackLvP2;
        Global.PlusPointHPLvP2 = sdg.SavePlusPointHPLvP2;
        Global.PlusPointMPLvP2 = sdg.SavePlusPointMPLvP2;
        Global.PlusPointSpeedLvP2 = sdg.SavePlusPointSpeedLvP2;
        Global.PlusPointAttackInfoP2 = sdg.SavePlusPointAttackInfoP2;
        Global.PlusPointHPInfoP2 = sdg.SavePlusPointHPInfoP2;
        Global.PlusPointMPInfoP2 = sdg.SavePlusPointMPInfoP2;
        Global.PlusPointSpeedInfoP2 = sdg.SavePlusPointSpeedInfoP2;

        //Load Maria
        Global.CurHPP3 = sdg.SaveHPP3;
        Global.MaxHPP3 = sdg.SaveMaxHPP3;
        Global.CurMPP3 = sdg.SaveMPP3;
        Global.MaxMPP3 = sdg.SaveMaxMPP3;
        Global.DamageP3 = sdg.SaveDamageP3;
        Global.SpeedP3 = sdg.SaveSpeedP3;
        Global.LevelP3 = sdg.SaveLevelP3;
        Global.MaxEXPP3 = sdg.SaveMaxEXPP3;
        Global.CurEXPP3 = sdg.SaveCurEXPP3;
        Global.PlusPointP3 = sdg.SavePlusPointP3;
        Global.PlusPointAttackLvP3 = sdg.SavePlusPointAttackLvP3;
        Global.PlusPointHPLvP3 = sdg.SavePlusPointHPLvP3;
        Global.PlusPointMPLvP3 = sdg.SavePlusPointMPLvP3;
        Global.PlusPointSpeedLvP3 = sdg.SavePlusPointSpeedLvP3;
        Global.PlusPointAttackInfoP3 = sdg.SavePlusPointAttackInfoP3;
        Global.PlusPointHPInfoP3 = sdg.SavePlusPointHPInfoP3;
        Global.PlusPointMPInfoP3 = sdg.SavePlusPointMPInfoP3;
        Global.PlusPointSpeedInfoP3 = sdg.SavePlusPointSpeedInfoP3;

        //Load Zen
        Global.Zen = sdg.SaveZen;

        //Load Weapon
        Global.VayneStaff1 = sdg.SaveVayneStaff1;
        Global.VayneStaff2 = sdg.SaveVayneStaff2;
        Global.VayneStaff3 = sdg.SaveVayneStaff3;
        Global.AliaShoes1 = sdg.SaveAliaShoes1;
        Global.AliaShoes2 = sdg.SaveAliaShoes2;
        Global.AliaShoes3 = sdg.SaveAliaShoes3;
        Global.MariaCrystal1 = sdg.SaveMariaCrystal1;
        Global.MariaCrystal2 = sdg.SaveMariaCrystal2;
        Global.MariaCrystal3 = sdg.SaveMariaCrystal3;
        Global.AlchemistArmor1 = sdg.SaveAlchemistArmor1;
        Global.AlchemistArmor2 = sdg.SaveAlchemistArmor2;
        Global.AlchemistArmor3 = sdg.SaveAlchemistArmor3;
        Global.WarriorArmor1 = sdg.SaveWarriorArmor1;
        Global.WarriorArmor2 = sdg.SaveWarriorArmor2;
        Global.WarriorArmor3 = sdg.SaveWarriorArmor3;

        //Load weapon status
        Global.VayneWeaponStatus = sdg.SaveVayneWeaponStatus;
        Global.VayneArmorStatus = sdg.SaveVayneArmorStatus;
        Global.AliaWeaponStatus = sdg.SaveAliaWeaponStatus;
        Global.AliaArmorStatus = sdg.SaveAliaArmorStatus;
        Global.MariaWeaponStatus = sdg.SaveMariaWeaponStatus;
        Global.MariaArmorStatus = sdg.SaveMariaArmorStatus;

        //Load weapon had bought
        WeaponStoreController.Bought1 = sdg.SaveBought1;
        WeaponStoreController.Bought2 = sdg.SaveBought2;
        WeaponStoreController.Bought3 = sdg.SaveBought3;
        WeaponStoreController.Bought4 = sdg.SaveBought4;
        WeaponStoreController.Bought5 = sdg.SaveBought5;
        WeaponStoreController.Bought6 = sdg.SaveBought6;
        WeaponStoreController.Bought7 = sdg.SaveBought7;
        WeaponStoreController.Bought8 = sdg.SaveBought8;
        WeaponStoreController.Bought9 = sdg.SaveBought9;
        WeaponStoreController.Bought10 = sdg.SaveBought10;
        WeaponStoreController.Bought11 = sdg.SaveBought11;
        WeaponStoreController.Bought12 = sdg.SaveBought12;
        WeaponStoreController.Bought13 = sdg.SaveBought13;
        WeaponStoreController.Bought14 = sdg.SaveBought14;
        WeaponStoreController.Bought15 = sdg.SaveBought15;

        //Load item material
        ContainerController.DriedLeaves = sdg.SaveDriedLeaves;
        ContainerController.PureWater = sdg.SavePureWater;
        ContainerController.MorningDrop = sdg.SaveMorningDrop;
        ContainerController.Wheat = sdg.SaveWheat;
        ContainerController.Wood = sdg.SaveWood;
        ContainerController.String = sdg.SaveString;
        ContainerController.Iron = sdg.SaveIron;
        ContainerController.ManaGem = sdg.SaveManaGem;
        ContainerController.ScorpionVenom = sdg.SaveScorpionVenom;
        ContainerController.InfernoSand = sdg.SaveInfernoSand;
        ContainerController.ManaLiquid = sdg.SaveManaLiquid;
        ContainerController.ManaOre = sdg.SaveManaOre;
        ContainerController.ManaCrystal = sdg.SaveManaCrystal;
        ContainerController.GuardianFeather = sdg.SaveGuardianFeather;
        ContainerController.FireOre = sdg.SaveFireOre;
        ContainerController.GoldenFeather = sdg.SaveGoldenFeather;
        ContainerController.RedManaCrystal = sdg.SaveRedManaCrystal;
        ContainerController.Obsidian = sdg.SaveObsidian;
        ContainerController.IceOre = sdg.SaveIceOre;
        ContainerController.IceLeather = sdg.SaveIceLeather;
        ContainerController.BlueManaCrystal = sdg.SaveBlueManaCrystal;
        ContainerController.RedManaSlimeBall = sdg.SaveRedManaSlimeBall;
        ContainerController.BlueManaSlimeBall = sdg.SaveBlueManaSlimeBall;
        ContainerController.ManaCoreFireZexel = sdg.SaveManaCoreFireZexel;
        ContainerController.ManaCoreIceZexel = sdg.SaveManaCoreIceZexel;
        ContainerController.Rock = sdg.SaveRock;
        ContainerController.PurifyingWater = sdg.SavePurifyingWater;
        ContainerController.NatureGrass = sdg.SaveNatureGrass;
        ContainerController.ManaDust = sdg.SaveManaDust;
        ContainerController.ManaEagleFeather = sdg.SaveManaEagleFeather;
        ContainerController.IceCrystal = sdg.SaveIceCrystal;

        //Load item
        ContainerController.HealPotion = sdg.SaveHealPotion;
        ContainerController.ManaPotion = sdg.SaveManaPotion;
        ContainerController.ElixirPotion = sdg.SaveElixirPotion;
        ContainerController.Bom = sdg.SaveBom;
        ContainerController.Porridge = sdg.SavePorridge;
        ContainerController.ManaCloth = sdg.SaveManaCloth;
        ContainerController.ManaShield = sdg.SaveManaShield;
        ContainerController.VenomKiller = sdg.SaveVenomKiller;
        ContainerController.ManaNecklace = sdg.SaveManaNecklace;
        ContainerController.ManaGenerator = sdg.SaveManaGenerator;
        ContainerController.Baxiata = sdg.SaveBaxiata;
        ContainerController.BaxiataGem = sdg.SaveBaxiataGem;
        ContainerController.Photonria = sdg.SavePhotonria;
        ContainerController.PhotonriaGem = sdg.SavePhotonriaGem;
        ContainerController.ManaLiquidCatalyst = sdg.SaveManaLiquidCatalyst;
        ContainerController.RedLiquidCatalyst = sdg.SaveRedLiquidCatalyst;
        ContainerController.BlueLiquidCatalyst = sdg.SaveBlueLiquidCatalyst;
        ContainerController.ManaCoreFireVayne = sdg.SaveManaCoreFireVayne;
        ContainerController.ManaCoreIceVayne = sdg.SaveManaCoreIceVayne;
        ContainerController.PureObsidian = sdg.SavePureObsidian;
        ContainerController.BackPainMedicine = sdg.SaveBackPainMedicine;
        ContainerController.PurifyingPotion = sdg.SavePurifyingPotion;
        ContainerController.FireManaGenerator = sdg.SaveFireManaGenerator;
        ContainerController.IceManaGenerator = sdg.SaveIceManaGenerator;
        ContainerController.BrokenManaDetector = sdg.SaveBrokenManaDetector;
        ContainerController.ManaDetector = sdg.SaveManaDetector;
        ContainerController.PowderOfLife = sdg.SavePowderOfLife;
        ContainerController.HoliHP = sdg.SaveHoliHP;
        ContainerController.HoliMP = sdg.SaveHoliMP;
        ContainerController.UltraBom = sdg.SaveUltraBom;
        ContainerController.ReincarnationLife = sdg.SaveReincarnationLife;
        ContainerController.FireOfPeace = sdg.SaveFireOfPeace;
        ContainerController.OmnipotentBoundary = sdg.SaveOmnipotentBoundary;

        //Load ManaSynthesize
        SynthesizeSystem.ManaSynthesize = sdg.SaveManaSynthesize;
        SynthesizeSystem.ManaFireSynthesize = sdg.SaveManaFireSynthesize;
        SynthesizeSystem.ManaIceSynthesize = sdg.SaveManaIceSynthesize;

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

        CryptSaveData csd2 = new CryptSaveData(loadPath, CryptedPassword);
        csd2.EncryptedSaveData();

        StartCoroutine(DelayChangeLoadGame());
    }

    public void PressDLGameD1()
    {
        ClickFX.Play();
        DeleteLoadGameIndex = 1;
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd.PRD"}"))
        {
            AskDeleteLoadGamePanel.SetActive(true);
        }
    }
    public void PressDLGameD2()
    {
        ClickFX.Play();
        DeleteLoadGameIndex = 2;
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd.PRD"}"))
        {
            AskDeleteLoadGamePanel.SetActive(true);
        }
    }
    public void PressDLGameD3()
    {
        ClickFX.Play();
        DeleteLoadGameIndex = 3;
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd.PRD"}"))
        {
            AskDeleteLoadGamePanel.SetActive(true);
        }
    }
    
    public void ConfirmDeleteLoadGame()
    {
        ClickFX.Play();
        if (DeleteLoadGameIndex == 1)
        {
            if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd.PRD"}"))
            {
                File.Delete($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd.PRD"}");
            }
        }
        else if (DeleteLoadGameIndex == 2)
        {
            if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd.PRD"}"))
            {
                File.Delete($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd.PRD"}");
            }
        }
        else if (DeleteLoadGameIndex == 3)
        {
            if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd.PRD"}"))
            {
                File.Delete($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd.PRD"}");
            }
        }

        AskDeleteLoadGamePanel.SetActive(false);
    }

    public void CancerDeleteLoadGame()
    {
        ClickFX.Play();
        DeleteLoadGameIndex = 0;
        AskDeleteLoadGamePanel.SetActive(false);
    }

    public void BackButton()
    {
        ClickFX.Play();
        LoadGamePanel.SetActive(false);
    }

    public void SettingPanelOpen()
    {
        ClickFX.Play();

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
        ClickFX.Play();

        GameSetting.SetActive(true);
        GraphicSetting.SetActive(false);
        SoundSetting.SetActive(false);

        GameSettingButton.GetComponent<Image>().color = Color.green;
        GraphicSettingButton.GetComponent<Image>().color = Color.white;
        SoundSettingButton.GetComponent<Image>().color = Color.white;
    }

    public void GraphicSettingOn()
    {
        ClickFX.Play();

        GameSetting.SetActive(false);
        GraphicSetting.SetActive(true);
        SoundSetting.SetActive(false);

        GameSettingButton.GetComponent<Image>().color = Color.white;
        GraphicSettingButton.GetComponent<Image>().color = Color.green;
        SoundSettingButton.GetComponent<Image>().color = Color.white;
    }

    public void SoundSettingOn()
    {
        ClickFX.Play();

        GameSetting.SetActive(false);
        GraphicSetting.SetActive(false);
        SoundSetting.SetActive(true);

        GameSettingButton.GetComponent<Image>().color = Color.white;
        GraphicSettingButton.GetComponent<Image>().color = Color.white;
        SoundSettingButton.GetComponent<Image>().color = Color.green;
    }

    public void SettingPanelClose()
    {
        ClickFX.Play();
        SettingPanel.SetActive(false);
    }

    public void PressExit()
    {
        ClickFX.Play();
        Application.Quit();
    }

    IEnumerator DelayChangeCutscense()
    {
        FadeInPanel.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Cutscenes");
    }

    IEnumerator DelayChangeLoadGame()
    {
        FadeInPanel.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Save room");
    }

    IEnumerator DelayFadeOutOff()
    {
        FadeOutPanel.SetActive(true);

        yield return new WaitForSeconds(1.4f);
        FadeOutPanel.SetActive(false);
    }
}
