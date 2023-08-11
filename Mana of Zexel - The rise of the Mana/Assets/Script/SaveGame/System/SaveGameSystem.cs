using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SaveGameSystem : MonoBehaviour
{
    public GameObject SaveGamePanel, AskSaveOverrideGamePanel;
    public Text show3;
    public GameObject show4;
    public Text showdata1;
    public Text showdata2;
    public Text showdata3;
    public AudioSource ClickFX;

    public int SaveIndex, SaveOverrideIndex;
    public string CryptedPassword;
    string userPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    // Start is called before the first frame update
    void Start()
    {
        SaveIndex = 0;
        SaveOverrideIndex = 0;

        if (!Directory.Exists($"{userPath}\\{"PRD Team"}"))
        {
            Directory.CreateDirectory($"{userPath}\\{"PRD Team"}");
        }
    }

    // Update is called once per frame
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

    public void PressSaveGameData1()
    {
        ClickFX.Play();
        SaveIndex = 1;
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd.PRD"}"))
        {
            SaveOverrideIndex = 1;
            AskSaveOverrideGamePanel.SetActive(true);
        }
        else
        {
            SaveDataProccess();
        }
    }

    public void PressSaveGameData2()
    {
        ClickFX.Play();
        SaveIndex = 2;
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd.PRD"}"))
        {
            SaveOverrideIndex = 2;
            AskSaveOverrideGamePanel.SetActive(true);
        }
        else
        {
            SaveDataProccess();
        }
    }

    public void PressSaveGameData3()
    {
        ClickFX.Play();
        SaveIndex = 3;
        if (File.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd.PRD"}"))
        {
            SaveOverrideIndex = 3;
            AskSaveOverrideGamePanel.SetActive(true);
        }
        else
        {
            SaveDataProccess();
        }
    }

    public void ConfirmSaveGameOverride()
    {
        ClickFX.Play();
        if (SaveOverrideIndex == 1)
        {
            SaveDataProccessOverride();
        }
        else if(SaveOverrideIndex == 2)
        {
            SaveDataProccessOverride();
        }
        else if (SaveOverrideIndex == 3)
        {
            SaveDataProccessOverride();
        }

        AskSaveOverrideGamePanel.SetActive(false);
    }

    public void SaveDataProccess()
    {
        SaveDataGlobal sdg = new SaveDataGlobal();

        //Set date
        sdg.SaveGlobalDayNight = DateController.GlobalDayNight;
        sdg.SaveGlobalTime = DateController.GlobalTime;
        sdg.SaveGlobalUpHour = DateController.GlobalUpHour;
        sdg.SaveGlobalPHour = DateController.GlobalPHour;
        sdg.SaveGlobalDownHour = DateController.GlobalDownHour;

        //Set cut
        sdg.Savecus0 = CutscenesController.cus0;
        sdg.Savecus1 = CutscenesController.cus1;
        sdg.Savecus2 = CutscenesController.cus2;
        sdg.Savecus3 = CutscenesController.cus3;
        sdg.Savecus4 = CutscenesController.cus4;
        sdg.Savecus5 = CutscenesController.cus5;
        sdg.Savecus6 = CutscenesController.cus6;
        sdg.Savecus7 = CutscenesController.cus7;
        sdg.Savecus8 = CutscenesController.cus8;
        sdg.Savecus9 = CutscenesController.cus9;
        sdg.Savecus10 = CutscenesController.cus10;
        sdg.Savecus11 = CutscenesController.cus11;
        sdg.Savecus12 = CutscenesController.cus12;
        sdg.Savecus13 = CutscenesController.cus13;
        sdg.Savecus14 = CutscenesController.cus14;
        sdg.Savecus15 = CutscenesController.cus15;
        sdg.Savecus16 = CutscenesController.cus16;
        sdg.Savecus17 = CutscenesController.cus17;
        sdg.Savecus18 = CutscenesController.cus18;
        sdg.Savecus19 = CutscenesController.cus19;
        sdg.Savecus20 = CutscenesController.cus20;
        sdg.Savecus21 = CutscenesController.cus21;
        sdg.Savecus22 = CutscenesController.cus22;
        sdg.Savecus23 = CutscenesController.cus23;
        sdg.Savecus24 = CutscenesController.cus24;
        sdg.Savecus25 = CutscenesController.cus25;
        sdg.Savecus26 = CutscenesController.cus26;
        sdg.Savecus27 = CutscenesController.cus27;
        sdg.Savecus28 = CutscenesController.cus28;
        sdg.Savecus29 = CutscenesController.cus29;
        sdg.Savecus30 = CutscenesController.cus30;
        sdg.Savecus31 = CutscenesController.cus31;
        sdg.Savecus32 = CutscenesController.cus32;
        sdg.Savecus33 = CutscenesController.cus33;
        sdg.Savecus34 = CutscenesController.cus34;
        sdg.Savecus35 = CutscenesController.cus35;
        sdg.Savecus36 = CutscenesController.cus36;
        sdg.Savecus37 = CutscenesController.cus37;
        sdg.Savecus38 = CutscenesController.cus38;
        sdg.Savecus39 = CutscenesController.cus39;
        sdg.Savecus40 = CutscenesController.cus40;
        sdg.Savecus41 = CutscenesController.cus41;
        sdg.Savecus42 = CutscenesController.cus42;
        sdg.Savecus43 = CutscenesController.cus43;
        sdg.Savecus44 = CutscenesController.cus44;
        sdg.Savecus45 = CutscenesController.cus45;
        sdg.Savecus46 = CutscenesController.cus46;
        sdg.Savecus47 = CutscenesController.cus47;
        sdg.Savecus48 = CutscenesController.cus48;
        sdg.Savecus49 = CutscenesController.cus49;
        sdg.Savecus50 = CutscenesController.cus50;
        sdg.Savecus51 = CutscenesController.cus51;
        sdg.Savecus52 = CutscenesController.cus52;
        sdg.Savecus53 = CutscenesController.cus53;
        sdg.Savecus54 = CutscenesController.cus54;
        sdg.Savecus55 = CutscenesController.cus55;
        sdg.Savecus56 = CutscenesController.cus56;
        sdg.Savecus57 = CutscenesController.cus57;
        sdg.Savecus58 = CutscenesController.cus58;
        sdg.Savecus59 = CutscenesController.cus59;
        sdg.Savecus60 = CutscenesController.cus60;
        sdg.Savecus61 = CutscenesController.cus61;
        sdg.Savecus62 = CutscenesController.cus62;
        sdg.Savecus63 = CutscenesController.cus63;
        sdg.Savecus64 = CutscenesController.cus64;
        sdg.Savecus65 = CutscenesController.cus65;
        sdg.Savecus66 = CutscenesController.cus66;
        sdg.Savecus67 = CutscenesController.cus67;
        sdg.Savecus68 = CutscenesController.cus68;
        sdg.Savecus69 = CutscenesController.cus69;
        sdg.Savecus70 = CutscenesController.cus70;
        sdg.Savecus71 = CutscenesController.cus71;
        sdg.Savecus72 = CutscenesController.cus72;
        sdg.Savecus73 = CutscenesController.cus73;
        sdg.Savecus74 = CutscenesController.cus74;
        sdg.Savecus75 = CutscenesController.cus75;
        sdg.Savecus76 = CutscenesController.cus76;
        sdg.Savecus77 = CutscenesController.cus77;
        sdg.Savecus78 = CutscenesController.cus78;
        sdg.Savecus79 = CutscenesController.cus79;
        sdg.Savecus80 = CutscenesController.cus80;
        sdg.Savecus81 = CutscenesController.cus81;
        sdg.Savecus82 = CutscenesController.cus82;
        sdg.Savecus83 = CutscenesController.cus83;
        sdg.Savecus84 = CutscenesController.cus84;
        sdg.Savecus85 = CutscenesController.cus85;
        sdg.Savecus86 = CutscenesController.cus86;
        sdg.Savecus87 = CutscenesController.cus87;
        sdg.Savecus88 = CutscenesController.cus88;
        sdg.Savecus89 = CutscenesController.cus89;
        sdg.Savecus90 = CutscenesController.cus90;
        sdg.Savecus91 = CutscenesController.cus91;
        sdg.Savecus92 = CutscenesController.cus92;
        sdg.Savecus93 = CutscenesController.cus93;
        sdg.Savecus94 = CutscenesController.cus94;
        sdg.Savecus95 = CutscenesController.cus95;
        sdg.Savecus96 = CutscenesController.cus96;
        sdg.Savecus97 = CutscenesController.cus97;
        sdg.Savecus98 = CutscenesController.cus98;
        sdg.Savecus99 = CutscenesController.cus99;
        sdg.Savecus100 = CutscenesController.cus100;
        sdg.Savecus101 = CutscenesController.cus101;
        sdg.Savecus102 = CutscenesController.cus102;
        sdg.Savecus103 = CutscenesController.cus103;
        sdg.Savecus104 = CutscenesController.cus104;
        sdg.Savecus105 = CutscenesController.cus105;
        sdg.Savecus106 = CutscenesController.cus106;
        sdg.Savecus107 = CutscenesController.cus107;
        sdg.Savecus108 = CutscenesController.cus108;
        sdg.Savecus109 = CutscenesController.cus109;
        sdg.Savecus110 = CutscenesController.cus110;
        sdg.Savecus111 = CutscenesController.cus111;
        sdg.Savecus112 = CutscenesController.cus112;
        sdg.Savecus113 = CutscenesController.cus113;
        sdg.Savecus114 = CutscenesController.cus114;
        sdg.Savecus115 = CutscenesController.cus115;
        sdg.Savecus116 = CutscenesController.cus116;
        sdg.Savecus117 = CutscenesController.cus117;
        sdg.Savecus118 = CutscenesController.cus118;
        sdg.Savecus119 = CutscenesController.cus119;
        sdg.Savecus120 = CutscenesController.cus120;
        sdg.Savecus121 = CutscenesController.cus121;
        sdg.Savecus122 = CutscenesController.cus122;
        sdg.Savecus123 = CutscenesController.cus123;
        sdg.Savecus124 = CutscenesController.cus124;
        sdg.Savecus125 = CutscenesController.cus125;
        sdg.Savecus126 = CutscenesController.cus126;
        sdg.Savecus127 = CutscenesController.cus127;
        sdg.Savecus128 = CutscenesController.cus128;
        sdg.Savecus129 = CutscenesController.cus129;
        sdg.Savecus130 = CutscenesController.cus130;
        sdg.Savecus131 = CutscenesController.cus131;
        sdg.Savecus132 = CutscenesController.cus132;
        sdg.Savecus133 = CutscenesController.cus133;
        sdg.Savecus134 = CutscenesController.cus134;
        sdg.Savecus135 = CutscenesController.cus135;
        sdg.Savecus136 = CutscenesController.cus136;
        sdg.Savecus137 = CutscenesController.cus137;
        sdg.Savecus138 = CutscenesController.cus138;
        sdg.Savecus139 = CutscenesController.cus139;
        sdg.Savecus140 = CutscenesController.cus140;
        sdg.Savecus141 = CutscenesController.cus141;
        sdg.Savecus142 = CutscenesController.cus142;
        sdg.Savecus143 = CutscenesController.cus143;
        sdg.Savecus144 = CutscenesController.cus144;

        //Set extra cus
        sdg.Savecuse1 = ExtraCutscenesController.cuse1;
        sdg.Savecuse2 = ExtraCutscenesController.cuse2;
        sdg.Savecuse3 = ExtraCutscenesController.cuse3;
        sdg.Savecuse4 = ExtraCutscenesController.cuse4;
        sdg.Savecuse5 = ExtraCutscenesController.cuse5;

        //Set quest
        sdg.SaveKGQ = GlobalQuest.KillGoblinQuest;
        sdg.SaveHVStop1 = GlobalQuest.HelpVillagerStop1;
        sdg.SaveHVStop2 = GlobalQuest.HelpVillagerStop2;
        sdg.SaveHVStop3 = GlobalQuest.HelpVillagerStop3;
        sdg.SaveHV = GlobalQuest.HelpVillagerDone;
        sdg.SavePorridgeSyn = CutscenesTrigger.PorridgeSyn;
        sdg.SaveBomSyn = CutscenesTrigger.BomSyn;
        sdg.SaveGolemnKill = CutscenesTrigger.GolemnKill;
        sdg.SaveInfernoScorpionKill = CutscenesTrigger.InfernoScorpionKill;
        sdg.SaveInfernoScorpionKillP2 = CutscenesTrigger.InfernoScorpionKillP2;
        sdg.SaveIceFangKill = CutscenesTrigger.IceFangKill;
        sdg.SaveGoblinKillP2 = CutscenesTrigger.GoblinKillP2;
        sdg.SaveGolemnKillP2 = CutscenesTrigger.GolemnKillP2;

        //Set player 1 (Vayne)
        sdg.SaveMaxHPP1 = Global.MaxHPP1;
        sdg.SaveHPP1 = Global.CurHPP1;
        sdg.SaveMaxMPP1 = Global.MaxMPP1;
        sdg.SaveMPP1 = Global.CurMPP1;
        sdg.SaveDamageP1 = Global.DamageP1;
        sdg.SaveSpeedP1 = Global.SpeedP1;
        sdg.SaveLevelP1 = Global.LevelP1;
        sdg.SaveMaxEXPP1 = Global.MaxEXPP1;
        sdg.SaveCurEXPP1 = Global.CurEXPP1;
        sdg.SavePlusPointP1 = Global.PlusPointP1;
        sdg.SavePlusPointAttackLvP1 = Global.PlusPointHPLvP1;
        sdg.SavePlusPointHPLvP1 = Global.PlusPointHPLvP1;
        sdg.SavePlusPointMPLvP1 = Global.PlusPointMPLvP1;
        sdg.SavePlusPointSpeedLvP1 = Global.PlusPointSpeedLvP1;
        sdg.SavePlusPointAttackInfoP1 = Global.PlusPointAttackInfoP1;
        sdg.SavePlusPointHPInfoP1 = Global.PlusPointHPInfoP1;
        sdg.SavePlusPointMPInfoP1 = Global.PlusPointMPInfoP1;
        sdg.SavePlusPointSpeedInfoP1 = Global.PlusPointSpeedInfoP1;

        //Set player 2 (Alia)
        sdg.SaveMaxHPP2 = Global.MaxHPP2;
        sdg.SaveHPP2 = Global.CurHPP2;
        sdg.SaveMaxMPP2 = Global.MaxMPP2;
        sdg.SaveMPP2 = Global.CurMPP2;
        sdg.SaveDamageP2 = Global.DamageP2;
        sdg.SaveSpeedP2 = Global.SpeedP2;
        sdg.SaveLevelP2 = Global.LevelP2;
        sdg.SaveMaxEXPP2 = Global.MaxEXPP2;
        sdg.SaveCurEXPP2 = Global.CurEXPP2;
        sdg.SavePlusPointP2 = Global.PlusPointP2;
        sdg.SavePlusPointAttackLvP2 = Global.PlusPointHPLvP2;
        sdg.SavePlusPointHPLvP2 = Global.PlusPointHPLvP2;
        sdg.SavePlusPointMPLvP2 = Global.PlusPointMPLvP2;
        sdg.SavePlusPointSpeedLvP2 = Global.PlusPointSpeedLvP2;
        sdg.SavePlusPointAttackInfoP2 = Global.PlusPointAttackInfoP2;
        sdg.SavePlusPointHPInfoP2 = Global.PlusPointHPInfoP2;
        sdg.SavePlusPointMPInfoP2 = Global.PlusPointMPInfoP2;
        sdg.SavePlusPointSpeedInfoP2 = Global.PlusPointSpeedInfoP2;

        //Set player 3 (Maria)
        sdg.SaveMaxHPP3 = Global.MaxHPP3;
        sdg.SaveHPP3 = Global.CurHPP3;
        sdg.SaveMaxMPP3 = Global.MaxMPP3;
        sdg.SaveMPP3 = Global.CurMPP3;
        sdg.SaveDamageP3 = Global.DamageP3;
        sdg.SaveSpeedP3 = Global.SpeedP3;
        sdg.SaveLevelP3 = Global.LevelP3;
        sdg.SaveMaxEXPP3 = Global.MaxEXPP3;
        sdg.SaveCurEXPP3 = Global.CurEXPP3;
        sdg.SavePlusPointP3 = Global.PlusPointP3;
        sdg.SavePlusPointAttackLvP3 = Global.PlusPointHPLvP3;
        sdg.SavePlusPointHPLvP3 = Global.PlusPointHPLvP3;
        sdg.SavePlusPointMPLvP3 = Global.PlusPointMPLvP3;
        sdg.SavePlusPointSpeedLvP3 = Global.PlusPointSpeedLvP3;
        sdg.SavePlusPointAttackInfoP3 = Global.PlusPointAttackInfoP3;
        sdg.SavePlusPointHPInfoP3 = Global.PlusPointHPInfoP3;
        sdg.SavePlusPointMPInfoP3 = Global.PlusPointMPInfoP3;
        sdg.SavePlusPointSpeedInfoP3 = Global.PlusPointSpeedInfoP3;

        //Set Zen
        sdg.SaveZen = Global.Zen;

        //Set weapon
        sdg.SaveVayneStaff1 = Global.VayneStaff1;
        sdg.SaveVayneStaff2 = Global.VayneStaff2;
        sdg.SaveVayneStaff3 = Global.VayneStaff3;
        sdg.SaveAliaShoes1 = Global.AliaShoes1;
        sdg.SaveAliaShoes2 = Global.AliaShoes2;
        sdg.SaveAliaShoes3 = Global.AliaShoes3;
        sdg.SaveMariaCrystal1 = Global.MariaCrystal1;
        sdg.SaveMariaCrystal2 = Global.MariaCrystal2;
        sdg.SaveMariaCrystal3 = Global.MariaCrystal3;
        sdg.SaveAlchemistArmor1 = Global.AlchemistArmor1;
        sdg.SaveAlchemistArmor2 = Global.AlchemistArmor2;
        sdg.SaveAlchemistArmor3 = Global.AlchemistArmor3;
        sdg.SaveWarriorArmor1 = Global.WarriorArmor1;
        sdg.SaveWarriorArmor2 = Global.WarriorArmor2;
        sdg.SaveWarriorArmor3 = Global.WarriorArmor3;

        //Set weapon status
        sdg.SaveVayneWeaponStatus = Global.VayneWeaponStatus;
        sdg.SaveVayneArmorStatus = Global.VayneArmorStatus;
        sdg.SaveAliaWeaponStatus = Global.AliaWeaponStatus;
        sdg.SaveAliaArmorStatus = Global.AliaArmorStatus;
        sdg.SaveMariaWeaponStatus = Global.MariaWeaponStatus;
        sdg.SaveMariaArmorStatus = Global.MariaArmorStatus;

        //Set weapon had bought
        sdg.SaveAlchemistArmor1HadBought = WeaponStoreController.AlchemistArmor1HadBought;
        sdg.SaveAlchemistArmor2HadBought = WeaponStoreController.AlchemistArmor2HadBought;
        sdg.SaveAlchemistArmor3HadBought = WeaponStoreController.AlchemistArmor3HadBought;
        sdg.SaveBought1 = WeaponStoreController.Bought1;
        sdg.SaveBought2 = WeaponStoreController.Bought2;
        sdg.SaveBought3 = WeaponStoreController.Bought3;
        sdg.SaveBought4 = WeaponStoreController.Bought4;
        sdg.SaveBought5 = WeaponStoreController.Bought5;
        sdg.SaveBought6 = WeaponStoreController.Bought6;
        sdg.SaveBought7 = WeaponStoreController.Bought7;
        sdg.SaveBought8 = WeaponStoreController.Bought8;
        sdg.SaveBought9 = WeaponStoreController.Bought9;
        sdg.SaveBought10 = WeaponStoreController.Bought10;
        sdg.SaveBought11 = WeaponStoreController.Bought11;
        sdg.SaveBought12 = WeaponStoreController.Bought12;
        sdg.SaveBought13 = WeaponStoreController.Bought13;
        sdg.SaveBought14 = WeaponStoreController.Bought14;
        sdg.SaveBought15 = WeaponStoreController.Bought15;

        //Set item material
        sdg.SaveDriedLeaves = ContainerController.DriedLeaves;
        sdg.SavePureWater = ContainerController.PureWater;
        sdg.SaveMorningDrop = ContainerController.MorningDrop;
        sdg.SaveWheat = ContainerController.Wheat;
        sdg.SaveWood = ContainerController.Wood;
        sdg.SaveString = ContainerController.String;
        sdg.SaveIron = ContainerController.Iron;
        sdg.SaveManaGem = ContainerController.ManaGem;
        sdg.SaveScorpionVenom = ContainerController.ScorpionVenom;
        sdg.SaveInfernoSand = ContainerController.InfernoSand;
        sdg.SaveManaLiquid = ContainerController.ManaLiquid;
        sdg.SaveManaOre = ContainerController.ManaOre;
        sdg.SaveManaCrystal = ContainerController.ManaCrystal;
        sdg.SaveGuardianFeather = ContainerController.GuardianFeather;
        sdg.SaveFireOre = ContainerController.FireOre;
        sdg.SaveGoldenFeather = ContainerController.GoldenFeather;
        sdg.SaveRedManaCrystal = ContainerController.RedManaCrystal;
        sdg.SaveObsidian = ContainerController.Obsidian;
        sdg.SaveIceOre = ContainerController.IceOre;
        sdg.SaveIceLeather = ContainerController.IceLeather;
        sdg.SaveBlueManaCrystal = ContainerController.BlueManaCrystal;
        sdg.SaveRedManaSlimeBall = ContainerController.RedManaSlimeBall;
        sdg.SaveBlueManaSlimeBall = ContainerController.BlueManaSlimeBall;
        sdg.SaveManaCoreFireZexel = ContainerController.ManaCoreFireZexel;
        sdg.SaveManaCoreIceZexel = ContainerController.ManaCoreIceZexel;
        sdg.SaveRock = ContainerController.Rock;
        sdg.SavePurifyingWater = ContainerController.PurifyingWater;
        sdg.SaveNatureGrass = ContainerController.NatureGrass;
        sdg.SaveManaDust = ContainerController.ManaDust;
        sdg.SaveManaEagleFeather = ContainerController.ManaEagleFeather;
        sdg.SaveIceCrystal = ContainerController.IceCrystal;

        //Set item
        sdg.SaveHealPotion = ContainerController.HealPotion;
        sdg.SaveManaPotion = ContainerController.ManaPotion;
        sdg.SaveElixirPotion = ContainerController.ElixirPotion;
        sdg.SaveBom = ContainerController.Bom;
        sdg.SavePorridge = ContainerController.Porridge;
        sdg.SaveManaCloth = ContainerController.ManaCloth;
        sdg.SaveManaShield = ContainerController.ManaShield;
        sdg.SaveVenomKiller = ContainerController.VenomKiller;
        sdg.SaveManaNecklace = ContainerController.ManaNecklace;
        sdg.SaveManaGenerator = ContainerController.ManaGenerator;
        sdg.SaveBaxiata = ContainerController.Baxiata;
        sdg.SaveBaxiataGem = ContainerController.BaxiataGem;
        sdg.SavePhotonria = ContainerController.Photonria;
        sdg.SavePhotonriaGem = ContainerController.PhotonriaGem;
        sdg.SaveManaLiquidCatalyst = ContainerController.ManaLiquidCatalyst;
        sdg.SaveRedLiquidCatalyst = ContainerController.RedLiquidCatalyst;
        sdg.SaveBlueLiquidCatalyst = ContainerController.BlueLiquidCatalyst;
        sdg.SaveManaCoreFireVayne = ContainerController.ManaCoreFireVayne;
        sdg.SaveManaCoreIceVayne = ContainerController.ManaCoreIceVayne;
        sdg.SavePureObsidian = ContainerController.PureObsidian;
        sdg.SaveBackPainMedicine = ContainerController.BackPainMedicine;
        sdg.SavePurifyingPotion = ContainerController.PurifyingPotion;
        sdg.SaveFireManaGenerator = ContainerController.FireManaGenerator;
        sdg.SaveIceManaGenerator = ContainerController.IceManaGenerator;
        sdg.SaveBrokenManaDetector = ContainerController.BrokenManaDetector;
        sdg.SaveManaDetector = ContainerController.ManaDetector;
        sdg.SavePowderOfLife = ContainerController.PowderOfLife;
        sdg.SaveHoliHP = ContainerController.HoliHP;
        sdg.SaveHoliMP = ContainerController.HoliMP;
        sdg.SaveUltraBom = ContainerController.UltraBom;
        sdg.SaveReincarnationLife = ContainerController.ReincarnationLife;
        sdg.SaveFireOfPeace = ContainerController.FireOfPeace;
        sdg.SaveOmnipotentBoundary = ContainerController.OmnipotentBoundary;

        //Set ManaSynthesize
        sdg.SaveManaSynthesize = SynthesizeSystem.ManaSynthesize;
        sdg.SaveManaFireSynthesize = SynthesizeSystem.ManaFireSynthesize;
        sdg.SaveManaIceSynthesize = SynthesizeSystem.ManaIceSynthesize;

        if (SaveIndex == 1)
        {
            string json = JsonUtility.ToJson(sdg, true);

            if (!Directory.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData01"}"))
            {
                Directory.CreateDirectory($"{userPath}\\{"PRD Team"}\\{"SaveData01"}");
            }

            File.WriteAllText(userPath + "/PRD Team/SaveData01/SaveD1.prd", json);

            CryptSaveData csd2 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd"}", CryptedPassword);
            csd2.EncryptedSaveData();

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
        else if (SaveIndex == 2)
        {
            string json = JsonUtility.ToJson(sdg, true);
            if (!Directory.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData02"}"))
            {
                Directory.CreateDirectory($"{userPath}\\{"PRD Team"}\\{"SaveData02"}");
            }

            File.WriteAllText(userPath + "/PRD Team/SaveData02/SaveD2.prd", json);

            CryptSaveData csd2 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd"}", CryptedPassword);
            csd2.EncryptedSaveData();

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
        else if (SaveIndex == 3)
        {
            string json = JsonUtility.ToJson(sdg, true);
            if (!Directory.Exists($"{userPath}\\{"PRD Team"}\\{"SaveData03"}"))
            {
                Directory.CreateDirectory($"{userPath}\\{"PRD Team"}\\{"SaveData03"}");
            }

            File.WriteAllText(userPath + "/PRD Team/SaveData03/SaveD3.prd", json);

            CryptSaveData csd2 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd"}", CryptedPassword);
            csd2.EncryptedSaveData();

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
    }

    public void SaveDataProccessOverride()
    {
        SaveDataGlobal sdg = new SaveDataGlobal();

        //Set date
        sdg.SaveGlobalDayNight = DateController.GlobalDayNight;
        sdg.SaveGlobalTime = DateController.GlobalTime;
        sdg.SaveGlobalUpHour = DateController.GlobalUpHour;
        sdg.SaveGlobalPHour = DateController.GlobalPHour;
        sdg.SaveGlobalDownHour = DateController.GlobalDownHour;

        //Set cut
        sdg.Savecus0 = CutscenesController.cus0;
        sdg.Savecus1 = CutscenesController.cus1;
        sdg.Savecus2 = CutscenesController.cus2;
        sdg.Savecus3 = CutscenesController.cus3;
        sdg.Savecus4 = CutscenesController.cus4;
        sdg.Savecus5 = CutscenesController.cus5;
        sdg.Savecus6 = CutscenesController.cus6;
        sdg.Savecus7 = CutscenesController.cus7;
        sdg.Savecus8 = CutscenesController.cus8;
        sdg.Savecus9 = CutscenesController.cus9;
        sdg.Savecus10 = CutscenesController.cus10;
        sdg.Savecus11 = CutscenesController.cus11;
        sdg.Savecus12 = CutscenesController.cus12;
        sdg.Savecus13 = CutscenesController.cus13;
        sdg.Savecus14 = CutscenesController.cus14;
        sdg.Savecus15 = CutscenesController.cus15;
        sdg.Savecus16 = CutscenesController.cus16;
        sdg.Savecus17 = CutscenesController.cus17;
        sdg.Savecus18 = CutscenesController.cus18;
        sdg.Savecus19 = CutscenesController.cus19;
        sdg.Savecus20 = CutscenesController.cus20;
        sdg.Savecus21 = CutscenesController.cus21;
        sdg.Savecus22 = CutscenesController.cus22;
        sdg.Savecus23 = CutscenesController.cus23;
        sdg.Savecus24 = CutscenesController.cus24;
        sdg.Savecus25 = CutscenesController.cus25;
        sdg.Savecus26 = CutscenesController.cus26;
        sdg.Savecus27 = CutscenesController.cus27;
        sdg.Savecus28 = CutscenesController.cus28;
        sdg.Savecus29 = CutscenesController.cus29;
        sdg.Savecus30 = CutscenesController.cus30;
        sdg.Savecus31 = CutscenesController.cus31;
        sdg.Savecus32 = CutscenesController.cus32;
        sdg.Savecus33 = CutscenesController.cus33;
        sdg.Savecus34 = CutscenesController.cus34;
        sdg.Savecus35 = CutscenesController.cus35;
        sdg.Savecus36 = CutscenesController.cus36;
        sdg.Savecus37 = CutscenesController.cus37;
        sdg.Savecus38 = CutscenesController.cus38;
        sdg.Savecus39 = CutscenesController.cus39;
        sdg.Savecus40 = CutscenesController.cus40;
        sdg.Savecus41 = CutscenesController.cus41;
        sdg.Savecus42 = CutscenesController.cus42;
        sdg.Savecus43 = CutscenesController.cus43;
        sdg.Savecus44 = CutscenesController.cus44;
        sdg.Savecus45 = CutscenesController.cus45;
        sdg.Savecus46 = CutscenesController.cus46;
        sdg.Savecus47 = CutscenesController.cus47;
        sdg.Savecus48 = CutscenesController.cus48;
        sdg.Savecus49 = CutscenesController.cus49;
        sdg.Savecus50 = CutscenesController.cus50;
        sdg.Savecus51 = CutscenesController.cus51;
        sdg.Savecus52 = CutscenesController.cus52;
        sdg.Savecus53 = CutscenesController.cus53;
        sdg.Savecus54 = CutscenesController.cus54;
        sdg.Savecus55 = CutscenesController.cus55;
        sdg.Savecus56 = CutscenesController.cus56;
        sdg.Savecus57 = CutscenesController.cus57;
        sdg.Savecus58 = CutscenesController.cus58;
        sdg.Savecus59 = CutscenesController.cus59;
        sdg.Savecus60 = CutscenesController.cus60;
        sdg.Savecus61 = CutscenesController.cus61;
        sdg.Savecus62 = CutscenesController.cus62;
        sdg.Savecus63 = CutscenesController.cus63;
        sdg.Savecus64 = CutscenesController.cus64;
        sdg.Savecus65 = CutscenesController.cus65;
        sdg.Savecus66 = CutscenesController.cus66;
        sdg.Savecus67 = CutscenesController.cus67;
        sdg.Savecus68 = CutscenesController.cus68;
        sdg.Savecus69 = CutscenesController.cus69;
        sdg.Savecus70 = CutscenesController.cus70;
        sdg.Savecus71 = CutscenesController.cus71;
        sdg.Savecus72 = CutscenesController.cus72;
        sdg.Savecus73 = CutscenesController.cus73;
        sdg.Savecus74 = CutscenesController.cus74;
        sdg.Savecus75 = CutscenesController.cus75;
        sdg.Savecus76 = CutscenesController.cus76;
        sdg.Savecus77 = CutscenesController.cus77;
        sdg.Savecus78 = CutscenesController.cus78;
        sdg.Savecus79 = CutscenesController.cus79;
        sdg.Savecus80 = CutscenesController.cus80;
        sdg.Savecus81 = CutscenesController.cus81;
        sdg.Savecus82 = CutscenesController.cus82;
        sdg.Savecus83 = CutscenesController.cus83;
        sdg.Savecus84 = CutscenesController.cus84;
        sdg.Savecus85 = CutscenesController.cus85;
        sdg.Savecus86 = CutscenesController.cus86;
        sdg.Savecus87 = CutscenesController.cus87;
        sdg.Savecus88 = CutscenesController.cus88;
        sdg.Savecus89 = CutscenesController.cus89;
        sdg.Savecus90 = CutscenesController.cus90;
        sdg.Savecus91 = CutscenesController.cus91;
        sdg.Savecus92 = CutscenesController.cus92;
        sdg.Savecus93 = CutscenesController.cus93;
        sdg.Savecus94 = CutscenesController.cus94;
        sdg.Savecus95 = CutscenesController.cus95;
        sdg.Savecus96 = CutscenesController.cus96;
        sdg.Savecus97 = CutscenesController.cus97;
        sdg.Savecus98 = CutscenesController.cus98;
        sdg.Savecus99 = CutscenesController.cus99;
        sdg.Savecus100 = CutscenesController.cus100;
        sdg.Savecus101 = CutscenesController.cus101;
        sdg.Savecus102 = CutscenesController.cus102;
        sdg.Savecus103 = CutscenesController.cus103;
        sdg.Savecus104 = CutscenesController.cus104;
        sdg.Savecus105 = CutscenesController.cus105;
        sdg.Savecus106 = CutscenesController.cus106;
        sdg.Savecus107 = CutscenesController.cus107;
        sdg.Savecus108 = CutscenesController.cus108;
        sdg.Savecus109 = CutscenesController.cus109;
        sdg.Savecus110 = CutscenesController.cus110;
        sdg.Savecus111 = CutscenesController.cus111;
        sdg.Savecus112 = CutscenesController.cus112;
        sdg.Savecus113 = CutscenesController.cus113;
        sdg.Savecus114 = CutscenesController.cus114;
        sdg.Savecus115 = CutscenesController.cus115;
        sdg.Savecus116 = CutscenesController.cus116;
        sdg.Savecus117 = CutscenesController.cus117;
        sdg.Savecus118 = CutscenesController.cus118;
        sdg.Savecus119 = CutscenesController.cus119;
        sdg.Savecus120 = CutscenesController.cus120;
        sdg.Savecus121 = CutscenesController.cus121;
        sdg.Savecus122 = CutscenesController.cus122;
        sdg.Savecus123 = CutscenesController.cus123;
        sdg.Savecus124 = CutscenesController.cus124;
        sdg.Savecus125 = CutscenesController.cus125;
        sdg.Savecus126 = CutscenesController.cus126;
        sdg.Savecus127 = CutscenesController.cus127;
        sdg.Savecus128 = CutscenesController.cus128;
        sdg.Savecus129 = CutscenesController.cus129;
        sdg.Savecus130 = CutscenesController.cus130;
        sdg.Savecus131 = CutscenesController.cus131;
        sdg.Savecus132 = CutscenesController.cus132;
        sdg.Savecus133 = CutscenesController.cus133;
        sdg.Savecus134 = CutscenesController.cus134;
        sdg.Savecus135 = CutscenesController.cus135;
        sdg.Savecus136 = CutscenesController.cus136;
        sdg.Savecus137 = CutscenesController.cus137;
        sdg.Savecus138 = CutscenesController.cus138;
        sdg.Savecus139 = CutscenesController.cus139;
        sdg.Savecus140 = CutscenesController.cus140;
        sdg.Savecus141 = CutscenesController.cus141;
        sdg.Savecus142 = CutscenesController.cus142;
        sdg.Savecus143 = CutscenesController.cus143;
        sdg.Savecus144 = CutscenesController.cus144;

        //Set extra cus
        sdg.Savecuse1 = ExtraCutscenesController.cuse1;
        sdg.Savecuse2 = ExtraCutscenesController.cuse2;
        sdg.Savecuse3 = ExtraCutscenesController.cuse3;
        sdg.Savecuse4 = ExtraCutscenesController.cuse4;
        sdg.Savecuse5 = ExtraCutscenesController.cuse5;

        //Set quest
        sdg.SaveKGQ = GlobalQuest.KillGoblinQuest;
        sdg.SaveHVStop1 = GlobalQuest.HelpVillagerStop1;
        sdg.SaveHVStop2 = GlobalQuest.HelpVillagerStop2;
        sdg.SaveHVStop3 = GlobalQuest.HelpVillagerStop3;
        sdg.SaveHV = GlobalQuest.HelpVillagerDone;
        sdg.SavePorridgeSyn = CutscenesTrigger.PorridgeSyn;
        sdg.SaveBomSyn = CutscenesTrigger.BomSyn;
        sdg.SaveGolemnKill = CutscenesTrigger.GolemnKill;
        sdg.SaveInfernoScorpionKill = CutscenesTrigger.InfernoScorpionKill;
        sdg.SaveInfernoScorpionKillP2 = CutscenesTrigger.InfernoScorpionKillP2;
        sdg.SaveIceFangKill = CutscenesTrigger.IceFangKill;
        sdg.SaveGoblinKillP2 = CutscenesTrigger.GoblinKillP2;
        sdg.SaveGolemnKillP2 = CutscenesTrigger.GolemnKillP2;

        //Set player 1 (Vayne)
        sdg.SaveMaxHPP1 = Global.MaxHPP1;
        sdg.SaveHPP1 = Global.CurHPP1;
        sdg.SaveMaxMPP1 = Global.MaxMPP1;
        sdg.SaveMPP1 = Global.CurMPP1;
        sdg.SaveDamageP1 = Global.DamageP1;
        sdg.SaveSpeedP1 = Global.SpeedP1;
        sdg.SaveLevelP1 = Global.LevelP1;
        sdg.SaveMaxEXPP1 = Global.MaxEXPP1;
        sdg.SaveCurEXPP1 = Global.CurEXPP1;
        sdg.SavePlusPointP1 = Global.PlusPointP1;
        sdg.SavePlusPointAttackLvP1 = Global.PlusPointHPLvP1;
        sdg.SavePlusPointHPLvP1 = Global.PlusPointHPLvP1;
        sdg.SavePlusPointMPLvP1 = Global.PlusPointMPLvP1;
        sdg.SavePlusPointSpeedLvP1 = Global.PlusPointSpeedLvP1;
        sdg.SavePlusPointAttackInfoP1 = Global.PlusPointAttackInfoP1;
        sdg.SavePlusPointHPInfoP1 = Global.PlusPointHPInfoP1;
        sdg.SavePlusPointMPInfoP1 = Global.PlusPointMPInfoP1;
        sdg.SavePlusPointSpeedInfoP1 = Global.PlusPointSpeedInfoP1;

        //Set player 2 (Alia)
        sdg.SaveMaxHPP2 = Global.MaxHPP2;
        sdg.SaveHPP2 = Global.CurHPP2;
        sdg.SaveMaxMPP2 = Global.MaxMPP2;
        sdg.SaveMPP2 = Global.CurMPP2;
        sdg.SaveDamageP2 = Global.DamageP2;
        sdg.SaveSpeedP2 = Global.SpeedP2;
        sdg.SaveLevelP2 = Global.LevelP2;
        sdg.SaveMaxEXPP2 = Global.MaxEXPP2;
        sdg.SaveCurEXPP2 = Global.CurEXPP2;
        sdg.SavePlusPointP2 = Global.PlusPointP2;
        sdg.SavePlusPointAttackLvP2 = Global.PlusPointHPLvP2;
        sdg.SavePlusPointHPLvP2 = Global.PlusPointHPLvP2;
        sdg.SavePlusPointMPLvP2 = Global.PlusPointMPLvP2;
        sdg.SavePlusPointSpeedLvP2 = Global.PlusPointSpeedLvP2;
        sdg.SavePlusPointAttackInfoP2 = Global.PlusPointAttackInfoP2;
        sdg.SavePlusPointHPInfoP2 = Global.PlusPointHPInfoP2;
        sdg.SavePlusPointMPInfoP2 = Global.PlusPointMPInfoP2;
        sdg.SavePlusPointSpeedInfoP2 = Global.PlusPointSpeedInfoP2;

        //Set player 3 (Maria)
        sdg.SaveMaxHPP3 = Global.MaxHPP3;
        sdg.SaveHPP3 = Global.CurHPP3;
        sdg.SaveMaxMPP3 = Global.MaxMPP3;
        sdg.SaveMPP3 = Global.CurMPP3;
        sdg.SaveDamageP3 = Global.DamageP3;
        sdg.SaveSpeedP3 = Global.SpeedP3;
        sdg.SaveLevelP3 = Global.LevelP3;
        sdg.SaveMaxEXPP3 = Global.MaxEXPP3;
        sdg.SaveCurEXPP3 = Global.CurEXPP3;
        sdg.SavePlusPointP3 = Global.PlusPointP3;
        sdg.SavePlusPointAttackLvP3 = Global.PlusPointHPLvP3;
        sdg.SavePlusPointHPLvP3 = Global.PlusPointHPLvP3;
        sdg.SavePlusPointMPLvP3 = Global.PlusPointMPLvP3;
        sdg.SavePlusPointSpeedLvP3 = Global.PlusPointSpeedLvP3;
        sdg.SavePlusPointAttackInfoP3 = Global.PlusPointAttackInfoP3;
        sdg.SavePlusPointHPInfoP3 = Global.PlusPointHPInfoP3;
        sdg.SavePlusPointMPInfoP3 = Global.PlusPointMPInfoP3;
        sdg.SavePlusPointSpeedInfoP3 = Global.PlusPointSpeedInfoP3;

        //Set Zen
        sdg.SaveZen = Global.Zen;

        //Set weapon
        sdg.SaveVayneStaff1 = Global.VayneStaff1;
        sdg.SaveVayneStaff2 = Global.VayneStaff2;
        sdg.SaveVayneStaff3 = Global.VayneStaff3;
        sdg.SaveAliaShoes1 = Global.AliaShoes1;
        sdg.SaveAliaShoes2 = Global.AliaShoes2;
        sdg.SaveAliaShoes3 = Global.AliaShoes3;
        sdg.SaveMariaCrystal1 = Global.MariaCrystal1;
        sdg.SaveMariaCrystal2 = Global.MariaCrystal2;
        sdg.SaveMariaCrystal3 = Global.MariaCrystal3;
        sdg.SaveAlchemistArmor1 = Global.AlchemistArmor1;
        sdg.SaveAlchemistArmor2 = Global.AlchemistArmor2;
        sdg.SaveAlchemistArmor3 = Global.AlchemistArmor3;
        sdg.SaveWarriorArmor1 = Global.WarriorArmor1;
        sdg.SaveWarriorArmor2 = Global.WarriorArmor2;
        sdg.SaveWarriorArmor3 = Global.WarriorArmor3;

        //Set weapon status
        sdg.SaveVayneWeaponStatus = Global.VayneWeaponStatus;
        sdg.SaveVayneArmorStatus = Global.VayneArmorStatus;
        sdg.SaveAliaWeaponStatus = Global.AliaWeaponStatus;
        sdg.SaveAliaArmorStatus = Global.AliaArmorStatus;
        sdg.SaveMariaWeaponStatus = Global.MariaWeaponStatus;
        sdg.SaveMariaArmorStatus = Global.MariaArmorStatus;

        //Set weapon had bought
        sdg.SaveAlchemistArmor1HadBought = WeaponStoreController.AlchemistArmor1HadBought;
        sdg.SaveAlchemistArmor2HadBought = WeaponStoreController.AlchemistArmor2HadBought;
        sdg.SaveAlchemistArmor3HadBought = WeaponStoreController.AlchemistArmor3HadBought;
        sdg.SaveBought1 = WeaponStoreController.Bought1;
        sdg.SaveBought2 = WeaponStoreController.Bought2;
        sdg.SaveBought3 = WeaponStoreController.Bought3;
        sdg.SaveBought4 = WeaponStoreController.Bought4;
        sdg.SaveBought5 = WeaponStoreController.Bought5;
        sdg.SaveBought6 = WeaponStoreController.Bought6;
        sdg.SaveBought7 = WeaponStoreController.Bought7;
        sdg.SaveBought8 = WeaponStoreController.Bought8;
        sdg.SaveBought9 = WeaponStoreController.Bought9;
        sdg.SaveBought10 = WeaponStoreController.Bought10;
        sdg.SaveBought11 = WeaponStoreController.Bought11;
        sdg.SaveBought12 = WeaponStoreController.Bought12;
        sdg.SaveBought13 = WeaponStoreController.Bought13;
        sdg.SaveBought14 = WeaponStoreController.Bought14;
        sdg.SaveBought15 = WeaponStoreController.Bought15;

        //Set item material
        sdg.SaveDriedLeaves = ContainerController.DriedLeaves;
        sdg.SavePureWater = ContainerController.PureWater;
        sdg.SaveMorningDrop = ContainerController.MorningDrop;
        sdg.SaveWheat = ContainerController.Wheat;
        sdg.SaveWood = ContainerController.Wood;
        sdg.SaveString = ContainerController.String;
        sdg.SaveIron = ContainerController.Iron;
        sdg.SaveManaGem = ContainerController.ManaGem;
        sdg.SaveScorpionVenom = ContainerController.ScorpionVenom;
        sdg.SaveInfernoSand = ContainerController.InfernoSand;
        sdg.SaveManaLiquid = ContainerController.ManaLiquid;
        sdg.SaveManaOre = ContainerController.ManaOre;
        sdg.SaveManaCrystal = ContainerController.ManaCrystal;
        sdg.SaveGuardianFeather = ContainerController.GuardianFeather;
        sdg.SaveFireOre = ContainerController.FireOre;
        sdg.SaveGoldenFeather = ContainerController.GoldenFeather;
        sdg.SaveRedManaCrystal = ContainerController.RedManaCrystal;
        sdg.SaveObsidian = ContainerController.Obsidian;
        sdg.SaveIceOre = ContainerController.IceOre;
        sdg.SaveIceLeather = ContainerController.IceLeather;
        sdg.SaveBlueManaCrystal = ContainerController.BlueManaCrystal;
        sdg.SaveRedManaSlimeBall = ContainerController.RedManaSlimeBall;
        sdg.SaveBlueManaSlimeBall = ContainerController.BlueManaSlimeBall;
        sdg.SaveManaCoreFireZexel = ContainerController.ManaCoreFireZexel;
        sdg.SaveManaCoreIceZexel = ContainerController.ManaCoreIceZexel;
        sdg.SaveRock = ContainerController.Rock;
        sdg.SavePurifyingWater = ContainerController.PurifyingWater;
        sdg.SaveNatureGrass = ContainerController.NatureGrass;
        sdg.SaveManaDust = ContainerController.ManaDust;
        sdg.SaveManaEagleFeather = ContainerController.ManaEagleFeather;
        sdg.SaveIceCrystal = ContainerController.IceCrystal;

        //Set item
        sdg.SaveHealPotion = ContainerController.HealPotion;
        sdg.SaveManaPotion = ContainerController.ManaPotion;
        sdg.SaveElixirPotion = ContainerController.ElixirPotion;
        sdg.SaveBom = ContainerController.Bom;
        sdg.SavePorridge = ContainerController.Porridge;
        sdg.SaveManaCloth = ContainerController.ManaCloth;
        sdg.SaveManaShield = ContainerController.ManaShield;
        sdg.SaveVenomKiller = ContainerController.VenomKiller;
        sdg.SaveManaNecklace = ContainerController.ManaNecklace;
        sdg.SaveManaGenerator = ContainerController.ManaGenerator;
        sdg.SaveBaxiata = ContainerController.Baxiata;
        sdg.SaveBaxiataGem = ContainerController.BaxiataGem;
        sdg.SavePhotonria = ContainerController.Photonria;
        sdg.SavePhotonriaGem = ContainerController.PhotonriaGem;
        sdg.SaveManaLiquidCatalyst = ContainerController.ManaLiquidCatalyst;
        sdg.SaveRedLiquidCatalyst = ContainerController.RedLiquidCatalyst;
        sdg.SaveBlueLiquidCatalyst = ContainerController.BlueLiquidCatalyst;
        sdg.SaveManaCoreFireVayne = ContainerController.ManaCoreFireVayne;
        sdg.SaveManaCoreIceVayne = ContainerController.ManaCoreIceVayne;
        sdg.SavePureObsidian = ContainerController.PureObsidian;
        sdg.SaveBackPainMedicine = ContainerController.BackPainMedicine;
        sdg.SavePurifyingPotion = ContainerController.PurifyingPotion;
        sdg.SaveFireManaGenerator = ContainerController.FireManaGenerator;
        sdg.SaveIceManaGenerator = ContainerController.IceManaGenerator;
        sdg.SaveBrokenManaDetector = ContainerController.BrokenManaDetector;
        sdg.SaveManaDetector = ContainerController.ManaDetector;
        sdg.SavePowderOfLife = ContainerController.PowderOfLife;
        sdg.SaveHoliHP = ContainerController.HoliHP;
        sdg.SaveHoliMP = ContainerController.HoliMP;
        sdg.SaveUltraBom = ContainerController.UltraBom;
        sdg.SaveReincarnationLife = ContainerController.ReincarnationLife;
        sdg.SaveFireOfPeace = ContainerController.FireOfPeace;
        sdg.SaveOmnipotentBoundary = ContainerController.OmnipotentBoundary;

        //Set ManaSynthesize
        sdg.SaveManaSynthesize = SynthesizeSystem.ManaSynthesize;
        sdg.SaveManaFireSynthesize = SynthesizeSystem.ManaFireSynthesize;
        sdg.SaveManaIceSynthesize = SynthesizeSystem.ManaIceSynthesize;

        if (SaveOverrideIndex == 1)
        {
            string json = JsonUtility.ToJson(sdg, true);
            CryptSaveData csd1 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd.PRD"}", CryptedPassword);

            csd1.DecryptedSaveData();

            File.WriteAllText(userPath + "/PRD Team/SaveData01/SaveD1.prd", json);

            CryptSaveData csd2 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData01"}\\{"SaveD1.prd"}", CryptedPassword);
            csd2.EncryptedSaveData();

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
        else if (SaveOverrideIndex == 2)
        {
            string json = JsonUtility.ToJson(sdg, true);
            CryptSaveData csd1 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd.PRD"}", CryptedPassword);

            csd1.DecryptedSaveData();

            File.WriteAllText(userPath + "/PRD Team/SaveData02/SaveD2.prd", json);

            CryptSaveData csd2 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData02"}\\{"SaveD2.prd"}", CryptedPassword);
            csd2.EncryptedSaveData();

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
        else if (SaveOverrideIndex == 3)
        {
            string json = JsonUtility.ToJson(sdg, true);
            CryptSaveData csd1 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd.PRD"}", CryptedPassword);

            csd1.DecryptedSaveData();

            File.WriteAllText(userPath + "/PRD Team/SaveData03/SaveD3.prd", json);

            CryptSaveData csd2 = new CryptSaveData($"{userPath}\\{"PRD Team"}\\{"SaveData03"}\\{"SaveD3.prd"}", CryptedPassword);
            csd2.EncryptedSaveData();

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
    }

    public void CancerSaveGameOverride()
    {
        ClickFX.Play();
        AskSaveOverrideGamePanel.SetActive(false);
    }

    public void PressSGBackButton()
    {
        ClickFX.Play();
        HubController.BusyHub = false;
        SaveGamePanel.SetActive(false);
        SaveOverrideIndex = 0;
    }
    void delay2()
    {
        show4.SetActive(false);
    }
}
