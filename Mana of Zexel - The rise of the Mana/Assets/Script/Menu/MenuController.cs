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
        Global.AlchemistArmor1 = 0;
        Global.AlchemistArmor2 = 0;
        Global.AlchemistArmor3 = 0;
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

        Global.CurHPP1 = 1200;
        Global.MaxHPP1 = 1200;
        Global.CurMPP1 = 170;
        Global.MaxMPP1 = 170;
        Global.DamageP1 = 410;
        Global.SpeedP1 = 30;
        Global.LevelP1 = 30;
        Global.MaxEXPP1 = 40;
        Global.CurEXPP1 = 0;

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
        ContainerController.MorningDrop = 0;
        ContainerController.DriedLeaves = 0;
        ContainerController.PureWater = 0;
        ContainerController.ManaGem = 0;
        ContainerController.Iron = 0;

        //Set item
        ContainerController.HealPotion = 0;
        ContainerController.ManaPotion = 0;
        ContainerController.ElixirPotion = 0;
        ContainerController.Bom = 10;
        ContainerController.HoliHP = 4;
        ContainerController.HoliMP = 4;
        ContainerController.UltraBom = 4;
        ContainerController.ReincarnationLife = 4;

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

        //Set ManaSynthesize
        SynthesizeSystem.ManaSynthesize = 100;
        SynthesizeSystem.ManaFireSynthesize = 100;
        SynthesizeSystem.ManaIceSynthesize = 100;

        SceneManager.LoadScene("Cutscenes");
        //SceneManager.LoadScene("BSSicxalon 1");
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

            Player.MapIndex = 1;

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

            GlobalQuest.KillGoblinQuest = PlayerPrefs.GetInt("SaveKGQD1");
            GlobalQuest.HelpVillagerStop1 = PlayerPrefs.GetInt("SaveHVStop1D1");
            GlobalQuest.HelpVillagerStop2 = PlayerPrefs.GetInt("SaveHVStop2D1");
            GlobalQuest.HelpVillagerStop3 = PlayerPrefs.GetInt("SaveHVStop3D1");
            GlobalQuest.HelpVillagerDone = PlayerPrefs.GetInt("SaveHVD1");

            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);

            //Set Vayne
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

            //Set Alia
            Global.CurHPP2 = PlayerPrefs.GetInt("SaveHPP2D1");
            Global.MaxHPP2 = PlayerPrefs.GetInt("SaveMaxHPP2D1");
            Global.CurMPP2 = PlayerPrefs.GetInt("SaveMPP2D1");
            Global.MaxMPP2 = PlayerPrefs.GetInt("SaveMaxMPP2D1");
            Global.DamageP2 = PlayerPrefs.GetInt("SaveDamageP2D1");
            Global.SpeedP2 = PlayerPrefs.GetInt("SaveSpeedP2D1");
            Global.LevelP2 = PlayerPrefs.GetInt("SaveLevelP2D1");
            Global.MaxEXPP2 = PlayerPrefs.GetInt("SaveMaxEXPP2D1");
            Global.CurEXPP2 = PlayerPrefs.GetInt("SaveCurEXPP2D1");

            //Set Zen
            Global.Zen = PlayerPrefs.GetInt("SaveZenD1");

            //Set Weapon
            Global.VayneStaff1 = PlayerPrefs.GetInt("SaveVayneStaff1D1");
            Global.VayneStaff2 = PlayerPrefs.GetInt("SaveVayneStaff2D1");
            Global.VayneStaff3 = PlayerPrefs.GetInt("SaveVayneStaff3D1");
            Global.AlchemistArmor1 = PlayerPrefs.GetInt("SaveAlchemistArmor1D1");
            Global.AlchemistArmor2 = PlayerPrefs.GetInt("SaveAlchemistArmor2D1");
            Global.AlchemistArmor3 = PlayerPrefs.GetInt("SaveAlchemistArmor3D1");

            //Set item material
            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMDD1");
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDLD1");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePWD1");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveMGD1");
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHPD1");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveMPD1");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveEPD1");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveID1");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBD1");

            SceneManager.LoadScene("Save room");
        }
    }
    public void PressLoadGameData2()
    {
        if (PlayerPrefs.GetInt("SaveGameD2") == 1)
        {
            LoadGameCheck = true;

            Player.MapIndex = 1;

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

            //Set quest
            GlobalQuest.KillGoblinQuest = PlayerPrefs.GetInt("SaveKGQD2");
            GlobalQuest.HelpVillagerStop1 = PlayerPrefs.GetInt("SaveHVStop1D2");
            GlobalQuest.HelpVillagerStop2 = PlayerPrefs.GetInt("SaveHVStop2D2");
            GlobalQuest.HelpVillagerStop3 = PlayerPrefs.GetInt("SaveHVStop3D2");
            GlobalQuest.HelpVillagerDone = PlayerPrefs.GetInt("SaveHVD2");

            //Set point
            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);

            //Set Vayne
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

            //Set Alia
            Global.CurHPP2 = PlayerPrefs.GetInt("SaveHPP2D2");
            Global.MaxHPP2 = PlayerPrefs.GetInt("SaveMaxHPP2D2");
            Global.CurMPP2 = PlayerPrefs.GetInt("SaveMPP2D2");
            Global.MaxMPP2 = PlayerPrefs.GetInt("SaveMaxMPP2D2");
            Global.DamageP2 = PlayerPrefs.GetInt("SaveDamageP2D2");
            Global.SpeedP2 = PlayerPrefs.GetInt("SaveSpeedP2D2");
            Global.LevelP2 = PlayerPrefs.GetInt("SaveLevelP2D2");
            Global.MaxEXPP2 = PlayerPrefs.GetInt("SaveMaxEXPP2D2");
            Global.CurEXPP2 = PlayerPrefs.GetInt("SaveCurEXPP2D2");

            //Set Zen
            Global.Zen = PlayerPrefs.GetInt("SaveZenD2");

            //Set Weapon
            Global.VayneStaff1 = PlayerPrefs.GetInt("SaveVayneStaff1D2");
            Global.VayneStaff2 = PlayerPrefs.GetInt("SaveVayneStaff2D2");
            Global.VayneStaff3 = PlayerPrefs.GetInt("SaveVayneStaff3D2");
            Global.AlchemistArmor1 = PlayerPrefs.GetInt("SaveAlchemistArmor1D2");
            Global.AlchemistArmor2 = PlayerPrefs.GetInt("SaveAlchemistArmor2D2");
            Global.AlchemistArmor3 = PlayerPrefs.GetInt("SaveAlchemistArmor3D2");

            //Set item material
            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMDD2");
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDLD2");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePWD2");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveMGD2");
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHPD2");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveMPD2");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveEPD2");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveID2");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBD2");

            SceneManager.LoadScene("Save room");
        }
    }
    public void PressLoadGameData3()
    {
        if (PlayerPrefs.GetInt("SaveGameD3") == 1)
        {
            LoadGameCheck = true;

            Player.MapIndex = 1;

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

            //Set quest
            PlayerPrefs.SetInt("SKGQ", PlayerPrefs.GetInt("SaveKGQD3"));
            GlobalQuest.HelpVillagerStop1 = PlayerPrefs.GetInt("SaveHVStop1D3");
            GlobalQuest.HelpVillagerStop2 = PlayerPrefs.GetInt("SaveHVStop2D3");
            GlobalQuest.HelpVillagerStop3 = PlayerPrefs.GetInt("SaveHVStop3D3");
            GlobalQuest.HelpVillagerDone = PlayerPrefs.GetInt("SaveHVD3");

            //Set point
            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);

            //Set Vayne
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

            //Set Alia
            Global.CurHPP2 = PlayerPrefs.GetInt("SaveHPP2D3");
            Global.MaxHPP2 = PlayerPrefs.GetInt("SaveMaxHPP2D3");
            Global.CurMPP2 = PlayerPrefs.GetInt("SaveMPP2D3");
            Global.MaxMPP2 = PlayerPrefs.GetInt("SaveMaxMPP2D3");
            Global.DamageP2 = PlayerPrefs.GetInt("SaveDamageP2D3");
            Global.SpeedP2 = PlayerPrefs.GetInt("SaveSpeedP2D3");
            Global.LevelP2 = PlayerPrefs.GetInt("SaveLevelP2D3");
            Global.MaxEXPP2 = PlayerPrefs.GetInt("SaveMaxEXPP2D3");
            Global.CurEXPP2 = PlayerPrefs.GetInt("SaveCurEXPP2D3");

            //Set Zen
            Global.Zen = PlayerPrefs.GetInt("SaveZenD3");

            //Set Weapon
            Global.VayneStaff1 = PlayerPrefs.GetInt("SaveVayneStaff1D3");
            Global.VayneStaff2 = PlayerPrefs.GetInt("SaveVayneStaff2D3");
            Global.VayneStaff3 = PlayerPrefs.GetInt("SaveVayneStaff3D3");
            Global.AlchemistArmor1 = PlayerPrefs.GetInt("SaveAlchemistArmor1D3");
            Global.AlchemistArmor2 = PlayerPrefs.GetInt("SaveAlchemistArmor2D3");
            Global.AlchemistArmor3 = PlayerPrefs.GetInt("SaveAlchemistArmor3D3");

            //Set item material
            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMDD3");
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDLD3");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePWD3");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveMGD3");
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHPD3");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveMPD3");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveEPD3");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveID3");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBD3");

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
