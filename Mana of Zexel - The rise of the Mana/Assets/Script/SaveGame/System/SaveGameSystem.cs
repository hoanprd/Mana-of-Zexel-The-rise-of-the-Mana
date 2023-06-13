using System.Collections;
using System.Collections.Generic;
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

    public int SaveOverrideIndex;

    // Start is called before the first frame update
    void Start()
    {
        SaveOverrideIndex = 0;
    }

    // Update is called once per frame
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
    public void PressSaveGameData1()
    {
        ClickFX.Play();
        if (PlayerPrefs.GetInt("SaveGameD1") == 1)
        {
            SaveOverrideIndex = 1;
            AskSaveOverrideGamePanel.SetActive(true);
        }
        else
        {
            //Set date
            PlayerPrefs.SetInt("SaveGlobalDayNightD1", DateController.GlobalDayNight);
            PlayerPrefs.SetFloat("SaveGlobalTimeD1", DateController.GlobalTime);
            PlayerPrefs.SetInt("SaveGlobalUpHourD1", DateController.GlobalUpHour);
            PlayerPrefs.SetInt("SaveGlobalPHourD1", DateController.GlobalPHour);
            PlayerPrefs.SetInt("SaveGlobalDownHourD1", DateController.GlobalDownHour);

            //Set cut
            PlayerPrefs.SetInt("Savecus0D1", CutscenesController.cus0);
            PlayerPrefs.SetInt("Savecus1D1", CutscenesController.cus1);
            PlayerPrefs.SetInt("Savecus2D1", CutscenesController.cus2);
            PlayerPrefs.SetInt("Savecus3D1", CutscenesController.cus3);
            PlayerPrefs.SetInt("Savecus4D1", CutscenesController.cus4);
            PlayerPrefs.SetInt("Savecus5D1", CutscenesController.cus5);
            PlayerPrefs.SetInt("Savecus6D1", CutscenesController.cus6);
            PlayerPrefs.SetInt("Savecus7D1", CutscenesController.cus7);
            PlayerPrefs.SetInt("Savecus8D1", CutscenesController.cus8);
            PlayerPrefs.SetInt("Savecus9D1", CutscenesController.cus9);
            PlayerPrefs.SetInt("Savecus10D1", CutscenesController.cus10);
            PlayerPrefs.SetInt("Savecus11D1", CutscenesController.cus11);
            PlayerPrefs.SetInt("Savecus12D1", CutscenesController.cus12);
            PlayerPrefs.SetInt("Savecus13D1", CutscenesController.cus13);
            PlayerPrefs.SetInt("Savecus14D1", CutscenesController.cus14);
            PlayerPrefs.SetInt("Savecus15D1", CutscenesController.cus15);
            PlayerPrefs.SetInt("Savecus16D1", CutscenesController.cus16);
            PlayerPrefs.SetInt("Savecus17D1", CutscenesController.cus17);
            PlayerPrefs.SetInt("Savecus18D1", CutscenesController.cus18);
            PlayerPrefs.SetInt("Savecus19D1", CutscenesController.cus19);
            PlayerPrefs.SetInt("Savecus20D1", CutscenesController.cus20);
            PlayerPrefs.SetInt("Savecus21D1", CutscenesController.cus21);
            PlayerPrefs.SetInt("Savecus22D1", CutscenesController.cus22);
            PlayerPrefs.SetInt("Savecus23D1", CutscenesController.cus23);
            PlayerPrefs.SetInt("Savecus24D1", CutscenesController.cus24);
            PlayerPrefs.SetInt("Savecus25D1", CutscenesController.cus25);
            PlayerPrefs.SetInt("Savecus26D1", CutscenesController.cus26);
            PlayerPrefs.SetInt("Savecus27D1", CutscenesController.cus27);
            PlayerPrefs.SetInt("Savecus28D1", CutscenesController.cus28);
            PlayerPrefs.SetInt("Savecus29D1", CutscenesController.cus29);
            PlayerPrefs.SetInt("Savecus30D1", CutscenesController.cus30);
            PlayerPrefs.SetInt("Savecus31D1", CutscenesController.cus31);
            PlayerPrefs.SetInt("Savecus32D1", CutscenesController.cus32);
            PlayerPrefs.SetInt("Savecus33D1", CutscenesController.cus33);
            PlayerPrefs.SetInt("Savecus34D1", CutscenesController.cus34);
            PlayerPrefs.SetInt("Savecus35D1", CutscenesController.cus35);
            PlayerPrefs.SetInt("Savecus36D1", CutscenesController.cus36);
            PlayerPrefs.SetInt("Savecus37D1", CutscenesController.cus37);
            PlayerPrefs.SetInt("Savecus38D1", CutscenesController.cus38);
            PlayerPrefs.SetInt("Savecus39D1", CutscenesController.cus39);
            PlayerPrefs.SetInt("Savecus40D1", CutscenesController.cus40);
            PlayerPrefs.SetInt("Savecus41D1", CutscenesController.cus41);
            PlayerPrefs.SetInt("Savecus42D1", CutscenesController.cus42);
            PlayerPrefs.SetInt("Savecus43D1", CutscenesController.cus43);
            PlayerPrefs.SetInt("Savecus44D1", CutscenesController.cus44);
            PlayerPrefs.SetInt("Savecus45D1", CutscenesController.cus45);
            PlayerPrefs.SetInt("Savecus46D1", CutscenesController.cus46);
            PlayerPrefs.SetInt("Savecus47D1", CutscenesController.cus47);
            PlayerPrefs.SetInt("Savecus48D1", CutscenesController.cus48);
            PlayerPrefs.SetInt("Savecus49D1", CutscenesController.cus49);
            PlayerPrefs.SetInt("Savecus50D1", CutscenesController.cus50);
            PlayerPrefs.SetInt("Savecus51D1", CutscenesController.cus51);
            PlayerPrefs.SetInt("Savecus52D1", CutscenesController.cus52);
            PlayerPrefs.SetInt("Savecus53D1", CutscenesController.cus53);
            PlayerPrefs.SetInt("Savecus54D1", CutscenesController.cus54);
            PlayerPrefs.SetInt("Savecus55D1", CutscenesController.cus55);
            PlayerPrefs.SetInt("Savecus56D1", CutscenesController.cus56);
            PlayerPrefs.SetInt("Savecus57D1", CutscenesController.cus57);
            PlayerPrefs.SetInt("Savecus58D1", CutscenesController.cus58);
            PlayerPrefs.SetInt("Savecus59D1", CutscenesController.cus59);
            PlayerPrefs.SetInt("Savecus60D1", CutscenesController.cus60);
            PlayerPrefs.SetInt("Savecus61D1", CutscenesController.cus61);
            PlayerPrefs.SetInt("Savecus62D1", CutscenesController.cus62);
            PlayerPrefs.SetInt("Savecus63D1", CutscenesController.cus63);
            PlayerPrefs.SetInt("Savecus64D1", CutscenesController.cus64);
            PlayerPrefs.SetInt("Savecus65D1", CutscenesController.cus65);
            PlayerPrefs.SetInt("Savecus66D1", CutscenesController.cus66);
            PlayerPrefs.SetInt("Savecus67D1", CutscenesController.cus67);
            PlayerPrefs.SetInt("Savecus68D1", CutscenesController.cus68);
            PlayerPrefs.SetInt("Savecus69D1", CutscenesController.cus69);
            PlayerPrefs.SetInt("Savecus70D1", CutscenesController.cus70);
            PlayerPrefs.SetInt("Savecus71D1", CutscenesController.cus71);
            PlayerPrefs.SetInt("Savecus72D1", CutscenesController.cus72);
            PlayerPrefs.SetInt("Savecus73D1", CutscenesController.cus73);
            PlayerPrefs.SetInt("Savecus74D1", CutscenesController.cus74);
            PlayerPrefs.SetInt("Savecus75D1", CutscenesController.cus75);
            PlayerPrefs.SetInt("Savecus76D1", CutscenesController.cus76);
            PlayerPrefs.SetInt("Savecus77D1", CutscenesController.cus77);
            PlayerPrefs.SetInt("Savecus78D1", CutscenesController.cus78);
            PlayerPrefs.SetInt("Savecus79D1", CutscenesController.cus79);
            PlayerPrefs.SetInt("Savecus80D1", CutscenesController.cus80);
            PlayerPrefs.SetInt("Savecus81D1", CutscenesController.cus81);
            PlayerPrefs.SetInt("Savecus82D1", CutscenesController.cus82);
            PlayerPrefs.SetInt("Savecus83D1", CutscenesController.cus83);
            PlayerPrefs.SetInt("Savecus84D1", CutscenesController.cus84);
            PlayerPrefs.SetInt("Savecus85D1", CutscenesController.cus85);
            PlayerPrefs.SetInt("Savecus86D1", CutscenesController.cus86);
            PlayerPrefs.SetInt("Savecus87D1", CutscenesController.cus87);
            PlayerPrefs.SetInt("Savecus88D1", CutscenesController.cus88);
            PlayerPrefs.SetInt("Savecus89D1", CutscenesController.cus89);
            PlayerPrefs.SetInt("Savecus90D1", CutscenesController.cus90);
            PlayerPrefs.SetInt("Savecus91D1", CutscenesController.cus91);
            PlayerPrefs.SetInt("Savecus92D1", CutscenesController.cus92);
            PlayerPrefs.SetInt("Savecus93D1", CutscenesController.cus93);
            PlayerPrefs.SetInt("Savecus94D1", CutscenesController.cus94);
            PlayerPrefs.SetInt("Savecus95D1", CutscenesController.cus95);
            PlayerPrefs.SetInt("Savecus96D1", CutscenesController.cus96);
            PlayerPrefs.SetInt("Savecus97D1", CutscenesController.cus97);
            PlayerPrefs.SetInt("Savecus98D1", CutscenesController.cus98);
            PlayerPrefs.SetInt("Savecus99D1", CutscenesController.cus99);
            PlayerPrefs.SetInt("Savecus100D1", CutscenesController.cus100);
            PlayerPrefs.SetInt("Savecus101D1", CutscenesController.cus101);
            PlayerPrefs.SetInt("Savecus102D1", CutscenesController.cus102);
            PlayerPrefs.SetInt("Savecus103D1", CutscenesController.cus103);
            PlayerPrefs.SetInt("Savecus104D1", CutscenesController.cus104);
            PlayerPrefs.SetInt("Savecus105D1", CutscenesController.cus105);
            PlayerPrefs.SetInt("Savecus106D1", CutscenesController.cus106);
            PlayerPrefs.SetInt("Savecus107D1", CutscenesController.cus107);
            PlayerPrefs.SetInt("Savecus108D1", CutscenesController.cus108);
            PlayerPrefs.SetInt("Savecus109D1", CutscenesController.cus109);
            PlayerPrefs.SetInt("Savecus110D1", CutscenesController.cus110);
            PlayerPrefs.SetInt("Savecus111D1", CutscenesController.cus111);
            PlayerPrefs.SetInt("Savecus112D1", CutscenesController.cus112);
            PlayerPrefs.SetInt("Savecus113D1", CutscenesController.cus113);
            PlayerPrefs.SetInt("Savecus114D1", CutscenesController.cus114);
            PlayerPrefs.SetInt("Savecus115D1", CutscenesController.cus115);
            PlayerPrefs.SetInt("Savecus116D1", CutscenesController.cus116);
            PlayerPrefs.SetInt("Savecus117D1", CutscenesController.cus117);
            PlayerPrefs.SetInt("Savecus118D1", CutscenesController.cus118);
            PlayerPrefs.SetInt("Savecus119D1", CutscenesController.cus119);
            PlayerPrefs.SetInt("Savecus120D1", CutscenesController.cus120);

            //Set quest
            PlayerPrefs.SetInt("SaveKGQD1", GlobalQuest.KillGoblinQuest);
            PlayerPrefs.SetInt("SaveHVStop1D1", GlobalQuest.HelpVillagerStop1);
            PlayerPrefs.SetInt("SaveHVStop2D1", GlobalQuest.HelpVillagerStop2);
            PlayerPrefs.SetInt("SaveHVStop3D1", GlobalQuest.HelpVillagerStop3);
            PlayerPrefs.SetInt("SaveHVD1", GlobalQuest.HelpVillagerDone);
            PlayerPrefs.SetInt("SavePorridgeSynD1", CutscenesTrigger.PorridgeSyn);
            PlayerPrefs.SetInt("SaveBomSynD1", CutscenesTrigger.BomSyn);
            PlayerPrefs.SetInt("SaveGolemnKillD1", CutscenesTrigger.GolemnKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillD1", CutscenesTrigger.InfernoScorpionKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillP2D1", CutscenesTrigger.InfernoScorpionKillP2);
            PlayerPrefs.SetInt("SaveIceFangKillD1", CutscenesTrigger.IceFangKill);
            PlayerPrefs.SetInt("SaveGoblinKillP2D1", CutscenesTrigger.GoblinKillP2);
            PlayerPrefs.SetInt("SaveGolemnKillP2D1", CutscenesTrigger.GolemnKillP2);

            //Set player 1 (Vayne)
            PlayerPrefs.SetInt("SaveMaxHPP1D1", Global.MaxHPP1);
            PlayerPrefs.SetInt("SaveHPP1D1", Global.CurHPP1);
            PlayerPrefs.SetInt("SaveMaxMPP1D1", Global.MaxMPP1);
            PlayerPrefs.SetInt("SaveMPP1D1", Global.CurMPP1);
            PlayerPrefs.SetInt("SaveDamageP1D1", Global.DamageP1);
            PlayerPrefs.SetInt("SaveSpeedP1D1", Global.SpeedP1);
            PlayerPrefs.SetInt("SaveLevelP1D1", Global.LevelP1);
            PlayerPrefs.SetInt("SaveMaxEXPP1D1", Global.MaxEXPP1);
            PlayerPrefs.SetInt("SaveCurEXPP1D1", Global.CurEXPP1);
            PlayerPrefs.SetInt("SavePlusPointP1D1", Global.PlusPointP1);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP1D1", Global.PlusPointAttackLvP1);
            PlayerPrefs.SetInt("SavePlusPointHPLvP1D1", Global.PlusPointHPLvP1);
            PlayerPrefs.SetInt("SavePlusPointMPLvP1D1", Global.PlusPointMPLvP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP1D1", Global.PlusPointSpeedLvP1);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP1D1", Global.PlusPointAttackInfoP1);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP1D1", Global.PlusPointHPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP1D1", Global.PlusPointMPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP1D1", Global.PlusPointSpeedInfoP1);

            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SaveMaxHPP2D1", Global.MaxHPP2);
            PlayerPrefs.SetInt("SaveHPP2D1", Global.CurHPP2);
            PlayerPrefs.SetInt("SaveMaxMPP2D1", Global.MaxMPP2);
            PlayerPrefs.SetInt("SaveMPP2D1", Global.CurMPP2);
            PlayerPrefs.SetInt("SaveDamageP2D1", Global.DamageP2);
            PlayerPrefs.SetInt("SaveSpeedP2D1", Global.SpeedP2);
            PlayerPrefs.SetInt("SaveLevelP2D1", Global.LevelP2);
            PlayerPrefs.SetInt("SaveMaxEXPP2D1", Global.MaxEXPP2);
            PlayerPrefs.SetInt("SaveCurEXPP2D1", Global.CurEXPP2);
            PlayerPrefs.SetInt("SavePlusPointP2D1", Global.PlusPointP2);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP2D1", Global.PlusPointAttackLvP2);
            PlayerPrefs.SetInt("SavePlusPointHPLvP2D1", Global.PlusPointHPLvP2);
            PlayerPrefs.SetInt("SavePlusPointMPLvP2D1", Global.PlusPointMPLvP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP2D1", Global.PlusPointSpeedLvP2);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP2D1", Global.PlusPointAttackInfoP2);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP2D1", Global.PlusPointHPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP2D1", Global.PlusPointMPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP2D1", Global.PlusPointSpeedInfoP2);

            //Set player 3 (Maria)
            PlayerPrefs.SetInt("SaveMaxHPP3D1", Global.MaxHPP3);
            PlayerPrefs.SetInt("SaveHPP3D1", Global.CurHPP3);
            PlayerPrefs.SetInt("SaveMaxMPP3D1", Global.MaxMPP3);
            PlayerPrefs.SetInt("SaveMPP3D1", Global.CurMPP3);
            PlayerPrefs.SetInt("SaveDamageP3D1", Global.DamageP3);
            PlayerPrefs.SetInt("SaveSpeedP3D1", Global.SpeedP3);
            PlayerPrefs.SetInt("SaveLevelP3D1", Global.LevelP3);
            PlayerPrefs.SetInt("SaveMaxEXPP3D1", Global.MaxEXPP3);
            PlayerPrefs.SetInt("SaveCurEXPP3D1", Global.CurEXPP3);
            PlayerPrefs.SetInt("SavePlusPointP3D1", Global.PlusPointP3);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP3D1", Global.PlusPointAttackLvP3);
            PlayerPrefs.SetInt("SavePlusPointHPLvP3D1", Global.PlusPointHPLvP3);
            PlayerPrefs.SetInt("SavePlusPointMPLvP3D1", Global.PlusPointMPLvP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP3D1", Global.PlusPointSpeedLvP3);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP3D1", Global.PlusPointAttackInfoP3);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP3D1", Global.PlusPointHPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP3D1", Global.PlusPointMPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP3D1", Global.PlusPointSpeedInfoP3);

            //Set Zen
            PlayerPrefs.SetInt("SaveZenD1", Global.Zen);

            //Set weapon
            PlayerPrefs.SetInt("SaveVayneStaff1D1", Global.VayneStaff1);
            PlayerPrefs.SetInt("SaveVayneStaff2D1", Global.VayneStaff2);
            PlayerPrefs.SetInt("SaveVayneStaff3D1", Global.VayneStaff3);
            PlayerPrefs.SetInt("SaveAliaShoes1D1", Global.AliaShoes1);
            PlayerPrefs.SetInt("SaveAliaShoes2D1", Global.AliaShoes2);
            PlayerPrefs.SetInt("SaveAliaShoes3D1", Global.AliaShoes3);
            PlayerPrefs.SetInt("SaveMariaCrystal1D1", Global.MariaCrystal1);
            PlayerPrefs.SetInt("SaveMariaCrystal2D1", Global.MariaCrystal2);
            PlayerPrefs.SetInt("SaveMariaCrystal3D1", Global.MariaCrystal3);
            PlayerPrefs.SetInt("SaveAlchemistArmor1D1", Global.AlchemistArmor1);
            PlayerPrefs.SetInt("SaveAlchemistArmor2D1", Global.AlchemistArmor2);
            PlayerPrefs.SetInt("SaveAlchemistArmor3D1", Global.AlchemistArmor3);
            PlayerPrefs.SetInt("SaveWarriorArmor1D1", Global.WarriorArmor1);
            PlayerPrefs.SetInt("SaveWarriorArmor2D1", Global.WarriorArmor2);
            PlayerPrefs.SetInt("SaveWarriorArmor3D1", Global.WarriorArmor3);

            //Set weapon status
            PlayerPrefs.SetInt("SaveVayneWeaponStatusD1", Global.VayneWeaponStatus);
            PlayerPrefs.SetInt("SaveVayneArmorStatusD1", Global.VayneArmorStatus);
            PlayerPrefs.SetInt("SaveAliaWeaponStatusD1", Global.AliaWeaponStatus);
            PlayerPrefs.SetInt("SaveAliaArmorStatusD1", Global.AliaArmorStatus);
            PlayerPrefs.SetInt("SaveMariaWeaponStatusD1", Global.MariaWeaponStatus);
            PlayerPrefs.SetInt("SaveMariaArmorStatusD1", Global.MariaArmorStatus);

            //Set weapon had bought
            PlayerPrefs.SetInt("SaveBought1D1", WeaponStoreController.Bought1);
            PlayerPrefs.SetInt("SaveBought2D1", WeaponStoreController.Bought2);
            PlayerPrefs.SetInt("SaveBought3D1", WeaponStoreController.Bought3);
            PlayerPrefs.SetInt("SaveBought4D1", WeaponStoreController.Bought4);
            PlayerPrefs.SetInt("SaveBought5D1", WeaponStoreController.Bought5);
            PlayerPrefs.SetInt("SaveBought6D1", WeaponStoreController.Bought6);
            PlayerPrefs.SetInt("SaveBought7D1", WeaponStoreController.Bought7);
            PlayerPrefs.SetInt("SaveBought8D1", WeaponStoreController.Bought8);
            PlayerPrefs.SetInt("SaveBought9D1", WeaponStoreController.Bought9);
            PlayerPrefs.SetInt("SaveBought10D1", WeaponStoreController.Bought10);
            PlayerPrefs.SetInt("SaveBought11D1", WeaponStoreController.Bought11);
            PlayerPrefs.SetInt("SaveBought12D1", WeaponStoreController.Bought12);
            PlayerPrefs.SetInt("SaveBought13D1", WeaponStoreController.Bought13);
            PlayerPrefs.SetInt("SaveBought14D1", WeaponStoreController.Bought14);
            PlayerPrefs.SetInt("SaveBought15D1", WeaponStoreController.Bought15);

            //Set item material
            PlayerPrefs.SetInt("SaveDriedLeavesD1", ContainerController.DriedLeaves);
            PlayerPrefs.SetInt("SavePureWaterD1", ContainerController.PureWater);
            PlayerPrefs.SetInt("SaveMorningDropD1", ContainerController.MorningDrop);
            PlayerPrefs.SetInt("SaveWheatD1", ContainerController.Wheat);
            PlayerPrefs.SetInt("SaveWoodD1", ContainerController.Wood);
            PlayerPrefs.SetInt("SaveStringD1", ContainerController.String);
            PlayerPrefs.SetInt("SaveIronD1", ContainerController.Iron);
            PlayerPrefs.SetInt("SaveManaGemD1", ContainerController.ManaGem);
            PlayerPrefs.SetInt("SaveScorpionVenomD1", ContainerController.ScorpionVenom);
            PlayerPrefs.SetInt("SaveInfernoSandD1", ContainerController.InfernoSand);
            PlayerPrefs.SetInt("SaveManaLiquidD1", ContainerController.ManaLiquid);
            PlayerPrefs.SetInt("SaveManaOreD1", ContainerController.ManaOre);
            PlayerPrefs.SetInt("SaveManaCrystalD1", ContainerController.ManaCrystal);
            PlayerPrefs.SetInt("SaveGuardianFeatherD1", ContainerController.GuardianFeather);
            PlayerPrefs.SetInt("SaveFireOreD1", ContainerController.FireOre);
            PlayerPrefs.SetInt("SaveGoldenFeatherD1", ContainerController.GoldenFeather);
            PlayerPrefs.SetInt("SaveRedManaCrystalD1", ContainerController.RedManaCrystal);
            PlayerPrefs.SetInt("SaveObsidianD1", ContainerController.Obsidian);
            PlayerPrefs.SetInt("SaveIceOreD1", ContainerController.IceOre);
            PlayerPrefs.SetInt("SaveIceLeatherD1", ContainerController.IceLeather);
            PlayerPrefs.SetInt("SaveBlueManaCrystalD1", ContainerController.BlueManaCrystal);
            PlayerPrefs.SetInt("SaveRedManaSlimeBallD1", ContainerController.RedManaSlimeBall);
            PlayerPrefs.SetInt("SaveBlueManaSlimeBallD1", ContainerController.BlueManaSlimeBall);
            PlayerPrefs.SetInt("SaveManaCoreFireZexelD1", ContainerController.ManaCoreFireZexel);
            PlayerPrefs.SetInt("SaveManaCoreIceZexelD1", ContainerController.ManaCoreIceZexel);
            PlayerPrefs.SetInt("SaveRockD1", ContainerController.Rock);
            PlayerPrefs.SetInt("SaveNatureGrassD1", ContainerController.NatureGrass);
            PlayerPrefs.SetInt("SaveManaDustD1", ContainerController.ManaDust);
            PlayerPrefs.SetInt("SaveManaEagleFeatherD1", ContainerController.ManaEagleFeather);
            PlayerPrefs.SetInt("SaveIceCrystalD1", ContainerController.IceCrystal);

            //Set item
            PlayerPrefs.SetInt("SaveHealPotionD1", ContainerController.HealPotion);
            PlayerPrefs.SetInt("SaveManaPotionD1", ContainerController.ManaPotion);
            PlayerPrefs.SetInt("SaveElixirPotionD1", ContainerController.ElixirPotion);
            PlayerPrefs.SetInt("SaveBomD1", ContainerController.Bom);
            PlayerPrefs.SetInt("SavePorridgeD1", ContainerController.Porridge);
            PlayerPrefs.SetInt("SaveManaClothD1", ContainerController.ManaCloth);
            PlayerPrefs.SetInt("SaveManaShieldD1", ContainerController.ManaShield);
            PlayerPrefs.SetInt("SaveVenomKillerD1", ContainerController.VenomKiller);
            PlayerPrefs.SetInt("SaveManaNecklaceD1", ContainerController.ManaNecklace);
            PlayerPrefs.SetInt("SaveManaGeneratorD1", ContainerController.ManaGenerator);
            PlayerPrefs.SetInt("SaveBaxiataD1", ContainerController.Baxiata);
            PlayerPrefs.SetInt("SaveBaxiataGemD1", ContainerController.BaxiataGem);
            PlayerPrefs.SetInt("SavePhotonriaD1", ContainerController.Photonria);
            PlayerPrefs.SetInt("SavePhotonriaGemD1", ContainerController.PhotonriaGem);
            PlayerPrefs.SetInt("SaveManaLiquidCatalystD1", ContainerController.ManaLiquidCatalyst);
            PlayerPrefs.SetInt("SaveRedLiquidCatalystD1", ContainerController.RedLiquidCatalyst);
            PlayerPrefs.SetInt("SaveBlueLiquidCatalystD1", ContainerController.BlueLiquidCatalyst);
            PlayerPrefs.SetInt("SaveManaCoreFireVayneD1", ContainerController.ManaCoreFireVayne);
            PlayerPrefs.SetInt("SaveManaCoreIceVayneD1", ContainerController.ManaCoreIceVayne);
            PlayerPrefs.SetInt("SavePureObsidianD1", ContainerController.PureObsidian);
            PlayerPrefs.SetInt("SaveFireManaGeneratorD1", ContainerController.FireManaGenerator);
            PlayerPrefs.SetInt("SaveIceManaGeneratorD1", ContainerController.IceManaGenerator);
            PlayerPrefs.SetInt("SavePowderOfLifeD1", ContainerController.PowderOfLife);
            PlayerPrefs.SetInt("SaveHoliHPD1", ContainerController.HoliHP);
            PlayerPrefs.SetInt("SaveHoliMPD1", ContainerController.HoliMP);
            PlayerPrefs.SetInt("SaveUltraBomD1", ContainerController.UltraBom);
            PlayerPrefs.SetInt("SaveReincarnationLifeD1", ContainerController.ReincarnationLife);
            PlayerPrefs.SetInt("SaveFireOfPeaceD1", ContainerController.FireOfPeace);
            PlayerPrefs.SetInt("SaveOmnipotentBoundaryD1", ContainerController.OmnipotentBoundary);

            //Set ManaSynthesize
            PlayerPrefs.SetInt("SaveManaSynthesizeD1", SynthesizeSystem.ManaSynthesize);
            PlayerPrefs.SetInt("SaveManaFireSynthesizeD1", SynthesizeSystem.ManaFireSynthesize);
            PlayerPrefs.SetInt("SaveManaIceSynthesizeD1", SynthesizeSystem.ManaIceSynthesize);

            PlayerPrefs.SetInt("SaveGameD1", 1);

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
    }
    public void PressSaveGameData2()
    {
        ClickFX.Play();
        if (PlayerPrefs.GetInt("SaveGameD2") == 1)
        {
            SaveOverrideIndex = 2;
            AskSaveOverrideGamePanel.SetActive(true);
        }
        else
        {
            //Set date
            PlayerPrefs.SetInt("SaveGlobalDayNightD2", DateController.GlobalDayNight);
            PlayerPrefs.SetFloat("SaveGlobalTimeD2", DateController.GlobalTime);
            PlayerPrefs.SetInt("SaveGlobalUpHourD2", DateController.GlobalUpHour);
            PlayerPrefs.SetInt("SaveGlobalPHourD2", DateController.GlobalPHour);
            PlayerPrefs.SetInt("SaveGlobalDownHourD2", DateController.GlobalDownHour);

            //Set cut
            PlayerPrefs.SetInt("Savecus0D2", CutscenesController.cus0);
            PlayerPrefs.SetInt("Savecus1D2", CutscenesController.cus1);
            PlayerPrefs.SetInt("Savecus2D2", CutscenesController.cus2);
            PlayerPrefs.SetInt("Savecus3D2", CutscenesController.cus3);
            PlayerPrefs.SetInt("Savecus4D2", CutscenesController.cus4);
            PlayerPrefs.SetInt("Savecus5D2", CutscenesController.cus5);
            PlayerPrefs.SetInt("Savecus6D2", CutscenesController.cus6);
            PlayerPrefs.SetInt("Savecus7D2", CutscenesController.cus7);
            PlayerPrefs.SetInt("Savecus8D2", CutscenesController.cus8);
            PlayerPrefs.SetInt("Savecus9D2", CutscenesController.cus9);
            PlayerPrefs.SetInt("Savecus10D2", CutscenesController.cus10);
            PlayerPrefs.SetInt("Savecus11D2", CutscenesController.cus11);
            PlayerPrefs.SetInt("Savecus12D2", CutscenesController.cus12);
            PlayerPrefs.SetInt("Savecus13D2", CutscenesController.cus13);
            PlayerPrefs.SetInt("Savecus14D2", CutscenesController.cus14);
            PlayerPrefs.SetInt("Savecus15D2", CutscenesController.cus15);
            PlayerPrefs.SetInt("Savecus16D2", CutscenesController.cus16);
            PlayerPrefs.SetInt("Savecus17D2", CutscenesController.cus17);
            PlayerPrefs.SetInt("Savecus18D2", CutscenesController.cus18);
            PlayerPrefs.SetInt("Savecus19D2", CutscenesController.cus19);
            PlayerPrefs.SetInt("Savecus20D2", CutscenesController.cus20);
            PlayerPrefs.SetInt("Savecus21D2", CutscenesController.cus21);
            PlayerPrefs.SetInt("Savecus22D2", CutscenesController.cus22);
            PlayerPrefs.SetInt("Savecus23D2", CutscenesController.cus23);
            PlayerPrefs.SetInt("Savecus24D2", CutscenesController.cus24);
            PlayerPrefs.SetInt("Savecus25D2", CutscenesController.cus25);
            PlayerPrefs.SetInt("Savecus26D2", CutscenesController.cus26);
            PlayerPrefs.SetInt("Savecus27D2", CutscenesController.cus27);
            PlayerPrefs.SetInt("Savecus28D2", CutscenesController.cus28);
            PlayerPrefs.SetInt("Savecus29D2", CutscenesController.cus29);
            PlayerPrefs.SetInt("Savecus30D2", CutscenesController.cus30);
            PlayerPrefs.SetInt("Savecus31D2", CutscenesController.cus31);
            PlayerPrefs.SetInt("Savecus32D2", CutscenesController.cus32);
            PlayerPrefs.SetInt("Savecus33D2", CutscenesController.cus33);
            PlayerPrefs.SetInt("Savecus34D2", CutscenesController.cus34);
            PlayerPrefs.SetInt("Savecus35D2", CutscenesController.cus35);
            PlayerPrefs.SetInt("Savecus36D2", CutscenesController.cus36);
            PlayerPrefs.SetInt("Savecus37D2", CutscenesController.cus37);
            PlayerPrefs.SetInt("Savecus38D2", CutscenesController.cus38);
            PlayerPrefs.SetInt("Savecus39D2", CutscenesController.cus39);
            PlayerPrefs.SetInt("Savecus40D2", CutscenesController.cus40);
            PlayerPrefs.SetInt("Savecus41D2", CutscenesController.cus41);
            PlayerPrefs.SetInt("Savecus42D2", CutscenesController.cus42);
            PlayerPrefs.SetInt("Savecus43D2", CutscenesController.cus43);
            PlayerPrefs.SetInt("Savecus44D2", CutscenesController.cus44);
            PlayerPrefs.SetInt("Savecus45D2", CutscenesController.cus45);
            PlayerPrefs.SetInt("Savecus46D2", CutscenesController.cus46);
            PlayerPrefs.SetInt("Savecus47D2", CutscenesController.cus47);
            PlayerPrefs.SetInt("Savecus48D2", CutscenesController.cus48);
            PlayerPrefs.SetInt("Savecus49D2", CutscenesController.cus49);
            PlayerPrefs.SetInt("Savecus50D2", CutscenesController.cus50);
            PlayerPrefs.SetInt("Savecus51D2", CutscenesController.cus51);
            PlayerPrefs.SetInt("Savecus52D2", CutscenesController.cus52);
            PlayerPrefs.SetInt("Savecus53D2", CutscenesController.cus53);
            PlayerPrefs.SetInt("Savecus54D2", CutscenesController.cus54);
            PlayerPrefs.SetInt("Savecus55D2", CutscenesController.cus55);
            PlayerPrefs.SetInt("Savecus56D2", CutscenesController.cus56);
            PlayerPrefs.SetInt("Savecus57D2", CutscenesController.cus57);
            PlayerPrefs.SetInt("Savecus58D2", CutscenesController.cus58);
            PlayerPrefs.SetInt("Savecus59D2", CutscenesController.cus59);
            PlayerPrefs.SetInt("Savecus60D2", CutscenesController.cus60);
            PlayerPrefs.SetInt("Savecus61D2", CutscenesController.cus61);
            PlayerPrefs.SetInt("Savecus62D2", CutscenesController.cus62);
            PlayerPrefs.SetInt("Savecus63D2", CutscenesController.cus63);
            PlayerPrefs.SetInt("Savecus64D2", CutscenesController.cus64);
            PlayerPrefs.SetInt("Savecus65D2", CutscenesController.cus65);
            PlayerPrefs.SetInt("Savecus66D2", CutscenesController.cus66);
            PlayerPrefs.SetInt("Savecus67D2", CutscenesController.cus67);
            PlayerPrefs.SetInt("Savecus68D2", CutscenesController.cus68);
            PlayerPrefs.SetInt("Savecus69D2", CutscenesController.cus69);
            PlayerPrefs.SetInt("Savecus70D2", CutscenesController.cus70);
            PlayerPrefs.SetInt("Savecus71D2", CutscenesController.cus71);
            PlayerPrefs.SetInt("Savecus72D2", CutscenesController.cus72);
            PlayerPrefs.SetInt("Savecus73D2", CutscenesController.cus73);
            PlayerPrefs.SetInt("Savecus74D2", CutscenesController.cus74);
            PlayerPrefs.SetInt("Savecus75D2", CutscenesController.cus75);
            PlayerPrefs.SetInt("Savecus76D2", CutscenesController.cus76);
            PlayerPrefs.SetInt("Savecus77D2", CutscenesController.cus77);
            PlayerPrefs.SetInt("Savecus78D2", CutscenesController.cus78);
            PlayerPrefs.SetInt("Savecus79D2", CutscenesController.cus79);
            PlayerPrefs.SetInt("Savecus80D2", CutscenesController.cus80);
            PlayerPrefs.SetInt("Savecus81D2", CutscenesController.cus81);
            PlayerPrefs.SetInt("Savecus82D2", CutscenesController.cus82);
            PlayerPrefs.SetInt("Savecus83D2", CutscenesController.cus83);
            PlayerPrefs.SetInt("Savecus84D2", CutscenesController.cus84);
            PlayerPrefs.SetInt("Savecus85D2", CutscenesController.cus85);
            PlayerPrefs.SetInt("Savecus86D2", CutscenesController.cus86);
            PlayerPrefs.SetInt("Savecus87D2", CutscenesController.cus87);
            PlayerPrefs.SetInt("Savecus88D2", CutscenesController.cus88);
            PlayerPrefs.SetInt("Savecus89D2", CutscenesController.cus89);
            PlayerPrefs.SetInt("Savecus90D2", CutscenesController.cus90);
            PlayerPrefs.SetInt("Savecus91D2", CutscenesController.cus91);
            PlayerPrefs.SetInt("Savecus92D2", CutscenesController.cus92);
            PlayerPrefs.SetInt("Savecus93D2", CutscenesController.cus93);
            PlayerPrefs.SetInt("Savecus94D2", CutscenesController.cus94);
            PlayerPrefs.SetInt("Savecus95D2", CutscenesController.cus95);
            PlayerPrefs.SetInt("Savecus96D2", CutscenesController.cus96);
            PlayerPrefs.SetInt("Savecus97D2", CutscenesController.cus97);
            PlayerPrefs.SetInt("Savecus98D2", CutscenesController.cus98);
            PlayerPrefs.SetInt("Savecus99D2", CutscenesController.cus99);
            PlayerPrefs.SetInt("Savecus100D2", CutscenesController.cus100);
            PlayerPrefs.SetInt("Savecus101D2", CutscenesController.cus101);
            PlayerPrefs.SetInt("Savecus102D2", CutscenesController.cus102);
            PlayerPrefs.SetInt("Savecus103D2", CutscenesController.cus103);
            PlayerPrefs.SetInt("Savecus104D2", CutscenesController.cus104);
            PlayerPrefs.SetInt("Savecus105D2", CutscenesController.cus105);
            PlayerPrefs.SetInt("Savecus106D2", CutscenesController.cus106);
            PlayerPrefs.SetInt("Savecus107D2", CutscenesController.cus107);
            PlayerPrefs.SetInt("Savecus108D2", CutscenesController.cus108);
            PlayerPrefs.SetInt("Savecus109D2", CutscenesController.cus109);
            PlayerPrefs.SetInt("Savecus110D2", CutscenesController.cus110);
            PlayerPrefs.SetInt("Savecus111D2", CutscenesController.cus111);
            PlayerPrefs.SetInt("Savecus112D2", CutscenesController.cus112);
            PlayerPrefs.SetInt("Savecus113D2", CutscenesController.cus113);
            PlayerPrefs.SetInt("Savecus114D2", CutscenesController.cus114);
            PlayerPrefs.SetInt("Savecus115D2", CutscenesController.cus115);
            PlayerPrefs.SetInt("Savecus116D2", CutscenesController.cus116);
            PlayerPrefs.SetInt("Savecus117D2", CutscenesController.cus117);
            PlayerPrefs.SetInt("Savecus118D2", CutscenesController.cus118);
            PlayerPrefs.SetInt("Savecus119D2", CutscenesController.cus119);
            PlayerPrefs.SetInt("Savecus120D2", CutscenesController.cus120);

            //Set quest
            PlayerPrefs.SetInt("SaveKGQD2", GlobalQuest.KillGoblinQuest);
            PlayerPrefs.SetInt("SaveHVStop1D2", GlobalQuest.HelpVillagerStop1);
            PlayerPrefs.SetInt("SaveHVStop2D2", GlobalQuest.HelpVillagerStop2);
            PlayerPrefs.SetInt("SaveHVStop3D2", GlobalQuest.HelpVillagerStop3);
            PlayerPrefs.SetInt("SaveHVD2", GlobalQuest.HelpVillagerDone);
            PlayerPrefs.SetInt("SavePorridgeSynD2", CutscenesTrigger.PorridgeSyn);
            PlayerPrefs.SetInt("SaveBomSynD2", CutscenesTrigger.BomSyn);
            PlayerPrefs.SetInt("SaveGolemnKillD2", CutscenesTrigger.GolemnKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillD2", CutscenesTrigger.InfernoScorpionKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillP2D2", CutscenesTrigger.InfernoScorpionKillP2);
            PlayerPrefs.SetInt("SaveIceFangKillD2", CutscenesTrigger.IceFangKill);
            PlayerPrefs.SetInt("SaveGoblinKillP2D2", CutscenesTrigger.GoblinKillP2);
            PlayerPrefs.SetInt("SaveGolemnKillP2D2", CutscenesTrigger.GolemnKillP2);

            //Set Vayne
            PlayerPrefs.SetInt("SaveMaxHPP1D2", Global.MaxHPP1);
            PlayerPrefs.SetInt("SaveHPP1D2", Global.CurHPP1);
            PlayerPrefs.SetInt("SaveMaxMPP1D2", Global.MaxMPP1);
            PlayerPrefs.SetInt("SaveMPP1D2", Global.CurMPP1);
            PlayerPrefs.SetInt("SaveDamageP1D2", Global.DamageP1);
            PlayerPrefs.SetInt("SaveSpeedP1D2", Global.SpeedP1);
            PlayerPrefs.SetInt("SaveLevelP1D2", Global.LevelP1);
            PlayerPrefs.SetInt("SaveMaxEXPP1D2", Global.MaxEXPP1);
            PlayerPrefs.SetInt("SaveCurEXPP1D2", Global.CurEXPP1);
            PlayerPrefs.SetInt("SavePlusPointP1D2", Global.PlusPointP1);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP1D2", Global.PlusPointAttackLvP1);
            PlayerPrefs.SetInt("SavePlusPointHPLvP1D2", Global.PlusPointHPLvP1);
            PlayerPrefs.SetInt("SavePlusPointMPLvP1D2", Global.PlusPointMPLvP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP1D2", Global.PlusPointSpeedLvP1);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP1D2", Global.PlusPointAttackInfoP1);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP1D2", Global.PlusPointHPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP1D2", Global.PlusPointMPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP1D2", Global.PlusPointSpeedInfoP1);

            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SaveMaxHPP2D2", Global.MaxHPP2);
            PlayerPrefs.SetInt("SaveHPP2D2", Global.CurHPP2);
            PlayerPrefs.SetInt("SaveMaxMPP2D2", Global.MaxMPP2);
            PlayerPrefs.SetInt("SaveMPP2D2", Global.CurMPP2);
            PlayerPrefs.SetInt("SaveDamageP2D2", Global.DamageP2);
            PlayerPrefs.SetInt("SaveSpeedP2D2", Global.SpeedP2);
            PlayerPrefs.SetInt("SaveLevelP2D2", Global.LevelP2);
            PlayerPrefs.SetInt("SaveMaxEXPP2D2", Global.MaxEXPP2);
            PlayerPrefs.SetInt("SaveCurEXPP2D2", Global.CurEXPP2);
            PlayerPrefs.SetInt("SavePlusPointP2D2", Global.PlusPointP2);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP2D2", Global.PlusPointAttackLvP2);
            PlayerPrefs.SetInt("SavePlusPointHPLvP2D2", Global.PlusPointHPLvP2);
            PlayerPrefs.SetInt("SavePlusPointMPLvP2D2", Global.PlusPointMPLvP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP2D2", Global.PlusPointSpeedLvP2);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP2D2", Global.PlusPointAttackInfoP2);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP2D2", Global.PlusPointHPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP2D2", Global.PlusPointMPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP2D2", Global.PlusPointSpeedInfoP2);

            //Set player 3 (Maria)
            PlayerPrefs.SetInt("SaveMaxHPP3D2", Global.MaxHPP3);
            PlayerPrefs.SetInt("SaveHPP3D2", Global.CurHPP3);
            PlayerPrefs.SetInt("SaveMaxMPP3D2", Global.MaxMPP3);
            PlayerPrefs.SetInt("SaveMPP3D2", Global.CurMPP3);
            PlayerPrefs.SetInt("SaveDamageP3D2", Global.DamageP3);
            PlayerPrefs.SetInt("SaveSpeedP3D2", Global.SpeedP3);
            PlayerPrefs.SetInt("SaveLevelP3D2", Global.LevelP3);
            PlayerPrefs.SetInt("SaveMaxEXPP3D2", Global.MaxEXPP3);
            PlayerPrefs.SetInt("SaveCurEXPP3D2", Global.CurEXPP3);
            PlayerPrefs.SetInt("SavePlusPointP3D2", Global.PlusPointP3);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP3D2", Global.PlusPointAttackLvP3);
            PlayerPrefs.SetInt("SavePlusPointHPLvP3D2", Global.PlusPointHPLvP3);
            PlayerPrefs.SetInt("SavePlusPointMPLvP3D2", Global.PlusPointMPLvP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP3D2", Global.PlusPointSpeedLvP3);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP3D2", Global.PlusPointAttackInfoP3);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP3D2", Global.PlusPointHPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP3D2", Global.PlusPointMPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP3D2", Global.PlusPointSpeedInfoP3);

            //Set Zen
            PlayerPrefs.SetInt("SaveZenD2", Global.Zen);

            //Set weapon
            PlayerPrefs.SetInt("SaveVayneStaff1D2", Global.VayneStaff1);
            PlayerPrefs.SetInt("SaveVayneStaff2D2", Global.VayneStaff2);
            PlayerPrefs.SetInt("SaveVayneStaff3D2", Global.VayneStaff3);
            PlayerPrefs.SetInt("SaveAliaShoes1D2", Global.AliaShoes1);
            PlayerPrefs.SetInt("SaveAliaShoes2D2", Global.AliaShoes2);
            PlayerPrefs.SetInt("SaveAliaShoes3D2", Global.AliaShoes3);
            PlayerPrefs.SetInt("SaveMariaCrystal1D2", Global.MariaCrystal1);
            PlayerPrefs.SetInt("SaveMariaCrystal2D2", Global.MariaCrystal2);
            PlayerPrefs.SetInt("SaveMariaCrystal3D2", Global.MariaCrystal3);
            PlayerPrefs.SetInt("SaveAlchemistArmor1D2", Global.AlchemistArmor1);
            PlayerPrefs.SetInt("SaveAlchemistArmor2D2", Global.AlchemistArmor2);
            PlayerPrefs.SetInt("SaveAlchemistArmor3D2", Global.AlchemistArmor3);
            PlayerPrefs.SetInt("SaveWarriorArmor1D2", Global.WarriorArmor1);
            PlayerPrefs.SetInt("SaveWarriorArmor2D2", Global.WarriorArmor2);
            PlayerPrefs.SetInt("SaveWarriorArmor3D2", Global.WarriorArmor3);

            //Set weapon status
            PlayerPrefs.SetInt("SaveVayneWeaponStatusD2", Global.VayneWeaponStatus);
            PlayerPrefs.SetInt("SaveVayneArmorStatusD2", Global.VayneArmorStatus);
            PlayerPrefs.SetInt("SaveAliaWeaponStatusD2", Global.AliaWeaponStatus);
            PlayerPrefs.SetInt("SaveAliaArmorStatusD2", Global.AliaArmorStatus);
            PlayerPrefs.SetInt("SaveMariaWeaponStatusD2", Global.MariaWeaponStatus);
            PlayerPrefs.SetInt("SaveMariaArmorStatusD2", Global.MariaArmorStatus);

            //Set weapon had bought
            PlayerPrefs.SetInt("SaveBought1D2", WeaponStoreController.Bought1);
            PlayerPrefs.SetInt("SaveBought2D2", WeaponStoreController.Bought2);
            PlayerPrefs.SetInt("SaveBought3D2", WeaponStoreController.Bought3);
            PlayerPrefs.SetInt("SaveBought4D2", WeaponStoreController.Bought4);
            PlayerPrefs.SetInt("SaveBought5D2", WeaponStoreController.Bought5);
            PlayerPrefs.SetInt("SaveBought6D2", WeaponStoreController.Bought6);
            PlayerPrefs.SetInt("SaveBought7D2", WeaponStoreController.Bought7);
            PlayerPrefs.SetInt("SaveBought8D2", WeaponStoreController.Bought8);
            PlayerPrefs.SetInt("SaveBought9D2", WeaponStoreController.Bought9);
            PlayerPrefs.SetInt("SaveBought10D2", WeaponStoreController.Bought10);
            PlayerPrefs.SetInt("SaveBought11D2", WeaponStoreController.Bought11);
            PlayerPrefs.SetInt("SaveBought12D2", WeaponStoreController.Bought12);
            PlayerPrefs.SetInt("SaveBought13D2", WeaponStoreController.Bought13);
            PlayerPrefs.SetInt("SaveBought14D2", WeaponStoreController.Bought14);
            PlayerPrefs.SetInt("SaveBought15D2", WeaponStoreController.Bought15);

            //Set item material
            PlayerPrefs.SetInt("SaveDriedLeavesD2", ContainerController.DriedLeaves);
            PlayerPrefs.SetInt("SavePureWaterD2", ContainerController.PureWater);
            PlayerPrefs.SetInt("SaveMorningDropD2", ContainerController.MorningDrop);
            PlayerPrefs.SetInt("SaveWheatD2", ContainerController.Wheat);
            PlayerPrefs.SetInt("SaveWoodD2", ContainerController.Wood);
            PlayerPrefs.SetInt("SaveStringD2", ContainerController.String);
            PlayerPrefs.SetInt("SaveIronD2", ContainerController.Iron);
            PlayerPrefs.SetInt("SaveManaGemD2", ContainerController.ManaGem);
            PlayerPrefs.SetInt("SaveScorpionVenomD2", ContainerController.ScorpionVenom);
            PlayerPrefs.SetInt("SaveInfernoSandD2", ContainerController.InfernoSand);
            PlayerPrefs.SetInt("SaveManaLiquidD2", ContainerController.ManaLiquid);
            PlayerPrefs.SetInt("SaveManaOreD2", ContainerController.ManaOre);
            PlayerPrefs.SetInt("SaveManaCrystalD2", ContainerController.ManaCrystal);
            PlayerPrefs.SetInt("SaveGuardianFeatherD2", ContainerController.GuardianFeather);
            PlayerPrefs.SetInt("SaveFireOreD2", ContainerController.FireOre);
            PlayerPrefs.SetInt("SaveGoldenFeatherD2", ContainerController.GoldenFeather);
            PlayerPrefs.SetInt("SaveRedManaCrystalD2", ContainerController.RedManaCrystal);
            PlayerPrefs.SetInt("SaveObsidianD2", ContainerController.Obsidian);
            PlayerPrefs.SetInt("SaveIceOreD2", ContainerController.IceOre);
            PlayerPrefs.SetInt("SaveIceLeatherD2", ContainerController.IceLeather);
            PlayerPrefs.SetInt("SaveBlueManaCrystalD2", ContainerController.BlueManaCrystal);
            PlayerPrefs.SetInt("SaveRedManaSlimeBallD2", ContainerController.RedManaSlimeBall);
            PlayerPrefs.SetInt("SaveBlueManaSlimeBallD2", ContainerController.BlueManaSlimeBall);
            PlayerPrefs.SetInt("SaveManaCoreFireZexelD2", ContainerController.ManaCoreFireZexel);
            PlayerPrefs.SetInt("SaveManaCoreIceZexelD2", ContainerController.ManaCoreIceZexel);
            PlayerPrefs.SetInt("SaveRockD2", ContainerController.Rock);
            PlayerPrefs.SetInt("SaveNatureGrassD2", ContainerController.NatureGrass);
            PlayerPrefs.SetInt("SaveManaDustD2", ContainerController.ManaDust);
            PlayerPrefs.SetInt("SaveManaEagleFeatherD2", ContainerController.ManaEagleFeather);
            PlayerPrefs.SetInt("SaveIceCrystalD2", ContainerController.IceCrystal);

            //Set item
            PlayerPrefs.SetInt("SaveHealPotionD2", ContainerController.HealPotion);
            PlayerPrefs.SetInt("SaveManaPotionD2", ContainerController.ManaPotion);
            PlayerPrefs.SetInt("SaveElixirPotionD2", ContainerController.ElixirPotion);
            PlayerPrefs.SetInt("SaveBomD2", ContainerController.Bom);
            PlayerPrefs.SetInt("SavePorridgeD2", ContainerController.Porridge);
            PlayerPrefs.SetInt("SaveManaClothD2", ContainerController.ManaCloth);
            PlayerPrefs.SetInt("SaveManaShieldD2", ContainerController.ManaShield);
            PlayerPrefs.SetInt("SaveVenomKillerD2", ContainerController.VenomKiller);
            PlayerPrefs.SetInt("SaveManaNecklaceD2", ContainerController.ManaNecklace);
            PlayerPrefs.SetInt("SaveManaGeneratorD2", ContainerController.ManaGenerator);
            PlayerPrefs.SetInt("SaveBaxiataD2", ContainerController.Baxiata);
            PlayerPrefs.SetInt("SaveBaxiataGemD2", ContainerController.BaxiataGem);
            PlayerPrefs.SetInt("SavePhotonriaD2", ContainerController.Photonria);
            PlayerPrefs.SetInt("SavePhotonriaGemD2", ContainerController.PhotonriaGem);
            PlayerPrefs.SetInt("SaveManaLiquidCatalystD2", ContainerController.ManaLiquidCatalyst);
            PlayerPrefs.SetInt("SaveRedLiquidCatalystD2", ContainerController.RedLiquidCatalyst);
            PlayerPrefs.SetInt("SaveBlueLiquidCatalystD2", ContainerController.BlueLiquidCatalyst);
            PlayerPrefs.SetInt("SaveManaCoreFireVayneD2", ContainerController.ManaCoreFireVayne);
            PlayerPrefs.SetInt("SaveManaCoreIceVayneD2", ContainerController.ManaCoreIceVayne);
            PlayerPrefs.SetInt("SavePureObsidianD2", ContainerController.PureObsidian);
            PlayerPrefs.SetInt("SaveFireManaGeneratorD2", ContainerController.FireManaGenerator);
            PlayerPrefs.SetInt("SaveIceManaGeneratorD2", ContainerController.IceManaGenerator);
            PlayerPrefs.SetInt("SavePowderOfLifeD2", ContainerController.PowderOfLife);
            PlayerPrefs.SetInt("SaveHoliHPD2", ContainerController.HoliHP);
            PlayerPrefs.SetInt("SaveHoliMPD2", ContainerController.HoliMP);
            PlayerPrefs.SetInt("SaveUltraBomD2", ContainerController.UltraBom);
            PlayerPrefs.SetInt("SaveReincarnationLifeD2", ContainerController.ReincarnationLife);
            PlayerPrefs.SetInt("SaveFireOfPeaceD2", ContainerController.FireOfPeace);
            PlayerPrefs.SetInt("SaveOmnipotentBoundaryD2", ContainerController.OmnipotentBoundary);

            //Set ManaSynthesize
            PlayerPrefs.SetInt("SaveManaSynthesizeD2", SynthesizeSystem.ManaSynthesize);
            PlayerPrefs.SetInt("SaveManaFireSynthesizeD2", SynthesizeSystem.ManaFireSynthesize);
            PlayerPrefs.SetInt("SaveManaIceSynthesizeD2", SynthesizeSystem.ManaIceSynthesize);

            PlayerPrefs.SetInt("SaveGameD2", 1);

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
    }
    public void PressSaveGameData3()
    {
        ClickFX.Play();
        if (PlayerPrefs.GetInt("SaveGameD3") == 1)
        {
            SaveOverrideIndex = 3;
            AskSaveOverrideGamePanel.SetActive(true);
        }
        else
        {
            //Set date
            PlayerPrefs.SetInt("SaveGlobalDayNightD3", DateController.GlobalDayNight);
            PlayerPrefs.SetFloat("SaveGlobalTimeD3", DateController.GlobalTime);
            PlayerPrefs.SetInt("SaveGlobalUpHourD3", DateController.GlobalUpHour);
            PlayerPrefs.SetInt("SaveGlobalPHourD3", DateController.GlobalPHour);
            PlayerPrefs.SetInt("SaveGlobalDownHourD3", DateController.GlobalDownHour);

            //Set cut
            PlayerPrefs.SetInt("Savecus0D3", CutscenesController.cus0);
            PlayerPrefs.SetInt("Savecus1D3", CutscenesController.cus1);
            PlayerPrefs.SetInt("Savecus2D3", CutscenesController.cus2);
            PlayerPrefs.SetInt("Savecus3D3", CutscenesController.cus3);
            PlayerPrefs.SetInt("Savecus4D3", CutscenesController.cus4);
            PlayerPrefs.SetInt("Savecus5D3", CutscenesController.cus5);
            PlayerPrefs.SetInt("Savecus6D3", CutscenesController.cus6);
            PlayerPrefs.SetInt("Savecus7D3", CutscenesController.cus7);
            PlayerPrefs.SetInt("Savecus8D3", CutscenesController.cus8);
            PlayerPrefs.SetInt("Savecus9D3", CutscenesController.cus9);
            PlayerPrefs.SetInt("Savecus10D3", CutscenesController.cus10);
            PlayerPrefs.SetInt("Savecus11D3", CutscenesController.cus11);
            PlayerPrefs.SetInt("Savecus12D3", CutscenesController.cus12);
            PlayerPrefs.SetInt("Savecus13D3", CutscenesController.cus13);
            PlayerPrefs.SetInt("Savecus14D3", CutscenesController.cus14);
            PlayerPrefs.SetInt("Savecus15D3", CutscenesController.cus15);
            PlayerPrefs.SetInt("Savecus16D3", CutscenesController.cus16);
            PlayerPrefs.SetInt("Savecus17D3", CutscenesController.cus17);
            PlayerPrefs.SetInt("Savecus18D3", CutscenesController.cus18);
            PlayerPrefs.SetInt("Savecus19D3", CutscenesController.cus19);
            PlayerPrefs.SetInt("Savecus20D3", CutscenesController.cus20);
            PlayerPrefs.SetInt("Savecus21D3", CutscenesController.cus21);
            PlayerPrefs.SetInt("Savecus22D3", CutscenesController.cus22);
            PlayerPrefs.SetInt("Savecus23D3", CutscenesController.cus23);
            PlayerPrefs.SetInt("Savecus24D3", CutscenesController.cus24);
            PlayerPrefs.SetInt("Savecus25D3", CutscenesController.cus25);
            PlayerPrefs.SetInt("Savecus26D3", CutscenesController.cus26);
            PlayerPrefs.SetInt("Savecus27D3", CutscenesController.cus27);
            PlayerPrefs.SetInt("Savecus28D3", CutscenesController.cus28);
            PlayerPrefs.SetInt("Savecus29D3", CutscenesController.cus29);
            PlayerPrefs.SetInt("Savecus30D3", CutscenesController.cus30);
            PlayerPrefs.SetInt("Savecus31D3", CutscenesController.cus31);
            PlayerPrefs.SetInt("Savecus32D3", CutscenesController.cus32);
            PlayerPrefs.SetInt("Savecus33D3", CutscenesController.cus33);
            PlayerPrefs.SetInt("Savecus34D3", CutscenesController.cus34);
            PlayerPrefs.SetInt("Savecus35D3", CutscenesController.cus35);
            PlayerPrefs.SetInt("Savecus36D3", CutscenesController.cus36);
            PlayerPrefs.SetInt("Savecus37D3", CutscenesController.cus37);
            PlayerPrefs.SetInt("Savecus38D3", CutscenesController.cus38);
            PlayerPrefs.SetInt("Savecus39D3", CutscenesController.cus39);
            PlayerPrefs.SetInt("Savecus40D3", CutscenesController.cus40);
            PlayerPrefs.SetInt("Savecus41D3", CutscenesController.cus41);
            PlayerPrefs.SetInt("Savecus42D3", CutscenesController.cus42);
            PlayerPrefs.SetInt("Savecus43D3", CutscenesController.cus43);
            PlayerPrefs.SetInt("Savecus44D3", CutscenesController.cus44);
            PlayerPrefs.SetInt("Savecus45D3", CutscenesController.cus45);
            PlayerPrefs.SetInt("Savecus46D3", CutscenesController.cus46);
            PlayerPrefs.SetInt("Savecus47D3", CutscenesController.cus47);
            PlayerPrefs.SetInt("Savecus48D3", CutscenesController.cus48);
            PlayerPrefs.SetInt("Savecus49D3", CutscenesController.cus49);
            PlayerPrefs.SetInt("Savecus50D3", CutscenesController.cus50);
            PlayerPrefs.SetInt("Savecus51D3", CutscenesController.cus51);
            PlayerPrefs.SetInt("Savecus52D3", CutscenesController.cus52);
            PlayerPrefs.SetInt("Savecus53D3", CutscenesController.cus53);
            PlayerPrefs.SetInt("Savecus54D3", CutscenesController.cus54);
            PlayerPrefs.SetInt("Savecus55D3", CutscenesController.cus55);
            PlayerPrefs.SetInt("Savecus56D3", CutscenesController.cus56);
            PlayerPrefs.SetInt("Savecus57D3", CutscenesController.cus57);
            PlayerPrefs.SetInt("Savecus58D3", CutscenesController.cus58);
            PlayerPrefs.SetInt("Savecus59D3", CutscenesController.cus59);
            PlayerPrefs.SetInt("Savecus60D3", CutscenesController.cus60);
            PlayerPrefs.SetInt("Savecus61D3", CutscenesController.cus61);
            PlayerPrefs.SetInt("Savecus62D3", CutscenesController.cus62);
            PlayerPrefs.SetInt("Savecus63D3", CutscenesController.cus63);
            PlayerPrefs.SetInt("Savecus64D3", CutscenesController.cus64);
            PlayerPrefs.SetInt("Savecus65D3", CutscenesController.cus65);
            PlayerPrefs.SetInt("Savecus66D3", CutscenesController.cus66);
            PlayerPrefs.SetInt("Savecus67D3", CutscenesController.cus67);
            PlayerPrefs.SetInt("Savecus68D3", CutscenesController.cus68);
            PlayerPrefs.SetInt("Savecus69D3", CutscenesController.cus69);
            PlayerPrefs.SetInt("Savecus70D3", CutscenesController.cus70);
            PlayerPrefs.SetInt("Savecus71D3", CutscenesController.cus71);
            PlayerPrefs.SetInt("Savecus72D3", CutscenesController.cus72);
            PlayerPrefs.SetInt("Savecus73D3", CutscenesController.cus73);
            PlayerPrefs.SetInt("Savecus74D3", CutscenesController.cus74);
            PlayerPrefs.SetInt("Savecus75D3", CutscenesController.cus75);
            PlayerPrefs.SetInt("Savecus76D3", CutscenesController.cus76);
            PlayerPrefs.SetInt("Savecus77D3", CutscenesController.cus77);
            PlayerPrefs.SetInt("Savecus78D3", CutscenesController.cus78);
            PlayerPrefs.SetInt("Savecus79D3", CutscenesController.cus79);
            PlayerPrefs.SetInt("Savecus80D3", CutscenesController.cus80);
            PlayerPrefs.SetInt("Savecus81D3", CutscenesController.cus81);
            PlayerPrefs.SetInt("Savecus82D3", CutscenesController.cus82);
            PlayerPrefs.SetInt("Savecus83D3", CutscenesController.cus83);
            PlayerPrefs.SetInt("Savecus84D3", CutscenesController.cus84);
            PlayerPrefs.SetInt("Savecus85D3", CutscenesController.cus85);
            PlayerPrefs.SetInt("Savecus86D3", CutscenesController.cus86);
            PlayerPrefs.SetInt("Savecus87D3", CutscenesController.cus87);
            PlayerPrefs.SetInt("Savecus88D3", CutscenesController.cus88);
            PlayerPrefs.SetInt("Savecus89D3", CutscenesController.cus89);
            PlayerPrefs.SetInt("Savecus90D3", CutscenesController.cus90);
            PlayerPrefs.SetInt("Savecus91D3", CutscenesController.cus91);
            PlayerPrefs.SetInt("Savecus92D3", CutscenesController.cus92);
            PlayerPrefs.SetInt("Savecus93D3", CutscenesController.cus93);
            PlayerPrefs.SetInt("Savecus94D3", CutscenesController.cus94);
            PlayerPrefs.SetInt("Savecus95D3", CutscenesController.cus95);
            PlayerPrefs.SetInt("Savecus96D3", CutscenesController.cus96);
            PlayerPrefs.SetInt("Savecus97D3", CutscenesController.cus97);
            PlayerPrefs.SetInt("Savecus98D3", CutscenesController.cus98);
            PlayerPrefs.SetInt("Savecus99D3", CutscenesController.cus99);
            PlayerPrefs.SetInt("Savecus100D3", CutscenesController.cus100);
            PlayerPrefs.SetInt("Savecus101D3", CutscenesController.cus101);
            PlayerPrefs.SetInt("Savecus102D3", CutscenesController.cus102);
            PlayerPrefs.SetInt("Savecus103D3", CutscenesController.cus103);
            PlayerPrefs.SetInt("Savecus104D3", CutscenesController.cus104);
            PlayerPrefs.SetInt("Savecus105D3", CutscenesController.cus105);
            PlayerPrefs.SetInt("Savecus106D3", CutscenesController.cus106);
            PlayerPrefs.SetInt("Savecus107D3", CutscenesController.cus107);
            PlayerPrefs.SetInt("Savecus108D3", CutscenesController.cus108);
            PlayerPrefs.SetInt("Savecus109D3", CutscenesController.cus109);
            PlayerPrefs.SetInt("Savecus110D3", CutscenesController.cus110);
            PlayerPrefs.SetInt("Savecus111D3", CutscenesController.cus111);
            PlayerPrefs.SetInt("Savecus112D3", CutscenesController.cus112);
            PlayerPrefs.SetInt("Savecus113D3", CutscenesController.cus113);
            PlayerPrefs.SetInt("Savecus114D3", CutscenesController.cus114);
            PlayerPrefs.SetInt("Savecus115D3", CutscenesController.cus115);
            PlayerPrefs.SetInt("Savecus116D3", CutscenesController.cus116);
            PlayerPrefs.SetInt("Savecus117D3", CutscenesController.cus117);
            PlayerPrefs.SetInt("Savecus118D3", CutscenesController.cus118);
            PlayerPrefs.SetInt("Savecus119D3", CutscenesController.cus119);
            PlayerPrefs.SetInt("Savecus120D3", CutscenesController.cus120);

            //Set quest
            PlayerPrefs.SetInt("SaveKGQD3", GlobalQuest.KillGoblinQuest);
            PlayerPrefs.SetInt("SaveHVStop1D3", GlobalQuest.HelpVillagerStop1);
            PlayerPrefs.SetInt("SaveHVStop2D3", GlobalQuest.HelpVillagerStop2);
            PlayerPrefs.SetInt("SaveHVStop3D3", GlobalQuest.HelpVillagerStop3);
            PlayerPrefs.SetInt("SaveHVD3", GlobalQuest.HelpVillagerDone);
            PlayerPrefs.SetInt("SavePorridgeSynD3", CutscenesTrigger.PorridgeSyn);
            PlayerPrefs.SetInt("SaveBomSynD3", CutscenesTrigger.BomSyn);
            PlayerPrefs.SetInt("SaveGolemnKillD3", CutscenesTrigger.GolemnKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillD3", CutscenesTrigger.InfernoScorpionKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillP2D3", CutscenesTrigger.InfernoScorpionKillP2);
            PlayerPrefs.SetInt("SaveIceFangKillD3", CutscenesTrigger.IceFangKill);
            PlayerPrefs.SetInt("SaveGoblinKillP2D3", CutscenesTrigger.GoblinKillP2);
            PlayerPrefs.SetInt("SaveGolemnKillP2D3", CutscenesTrigger.GolemnKillP2);

            //Set Vayne
            PlayerPrefs.SetInt("SaveMaxHPP1D3", Global.MaxHPP1);
            PlayerPrefs.SetInt("SaveHPP1D3", Global.CurHPP1);
            PlayerPrefs.SetInt("SaveMaxMPP1D3", Global.MaxMPP1);
            PlayerPrefs.SetInt("SaveMPP1D3", Global.CurMPP1);
            PlayerPrefs.SetInt("SaveDamageP1D3", Global.DamageP1);
            PlayerPrefs.SetInt("SaveSpeedP1D3", Global.SpeedP1);
            PlayerPrefs.SetInt("SaveLevelP1D3", Global.LevelP1);
            PlayerPrefs.SetInt("SaveMaxEXPP1D3", Global.MaxEXPP1);
            PlayerPrefs.SetInt("SaveCurEXPP1D3", Global.CurEXPP1);
            PlayerPrefs.SetInt("SavePlusPointP1D3", Global.PlusPointP1);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP1D3", Global.PlusPointAttackLvP1);
            PlayerPrefs.SetInt("SavePlusPointHPLvP1D3", Global.PlusPointHPLvP1);
            PlayerPrefs.SetInt("SavePlusPointMPLvP1D3", Global.PlusPointMPLvP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP1D3", Global.PlusPointSpeedLvP1);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP1D3", Global.PlusPointAttackInfoP1);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP1D3", Global.PlusPointHPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP1D3", Global.PlusPointMPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP1D3", Global.PlusPointSpeedInfoP1);

            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SaveMaxHPP2D3", Global.MaxHPP2);
            PlayerPrefs.SetInt("SaveHPP2D3", Global.CurHPP2);
            PlayerPrefs.SetInt("SaveMaxMPP2D3", Global.MaxMPP2);
            PlayerPrefs.SetInt("SaveMPP2D3", Global.CurMPP2);
            PlayerPrefs.SetInt("SaveDamageP2D3", Global.DamageP2);
            PlayerPrefs.SetInt("SaveSpeedP2D3", Global.SpeedP2);
            PlayerPrefs.SetInt("SaveLevelP2D3", Global.LevelP2);
            PlayerPrefs.SetInt("SaveMaxEXPP2D3", Global.MaxEXPP2);
            PlayerPrefs.SetInt("SaveCurEXPP2D3", Global.CurEXPP2);
            PlayerPrefs.SetInt("SavePlusPointP2D3", Global.PlusPointP2);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP2D3", Global.PlusPointAttackLvP2);
            PlayerPrefs.SetInt("SavePlusPointHPLvP2D3", Global.PlusPointHPLvP2);
            PlayerPrefs.SetInt("SavePlusPointMPLvP2D3", Global.PlusPointMPLvP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP2D3", Global.PlusPointSpeedLvP2);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP2D3", Global.PlusPointAttackInfoP2);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP2D3", Global.PlusPointHPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP2D3", Global.PlusPointMPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP2D3", Global.PlusPointSpeedInfoP2);

            //Set player 3 (Maria)
            PlayerPrefs.SetInt("SaveMaxHPP3D3", Global.MaxHPP3);
            PlayerPrefs.SetInt("SaveHPP3D3", Global.CurHPP3);
            PlayerPrefs.SetInt("SaveMaxMPP3D3", Global.MaxMPP3);
            PlayerPrefs.SetInt("SaveMPP3D3", Global.CurMPP3);
            PlayerPrefs.SetInt("SaveDamageP3D3", Global.DamageP3);
            PlayerPrefs.SetInt("SaveSpeedP3D3", Global.SpeedP3);
            PlayerPrefs.SetInt("SaveLevelP3D3", Global.LevelP3);
            PlayerPrefs.SetInt("SaveMaxEXPP3D3", Global.MaxEXPP3);
            PlayerPrefs.SetInt("SaveCurEXPP3D3", Global.CurEXPP3);
            PlayerPrefs.SetInt("SavePlusPointP3D3", Global.PlusPointP3);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP3D3", Global.PlusPointAttackLvP3);
            PlayerPrefs.SetInt("SavePlusPointHPLvP3D3", Global.PlusPointHPLvP3);
            PlayerPrefs.SetInt("SavePlusPointMPLvP3D3", Global.PlusPointMPLvP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP3D3", Global.PlusPointSpeedLvP3);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP3D3", Global.PlusPointAttackInfoP3);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP3D3", Global.PlusPointHPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP3D3", Global.PlusPointMPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP3D3", Global.PlusPointSpeedInfoP3);

            //Set Zen
            PlayerPrefs.SetInt("SaveZenD3", Global.Zen);

            //Set weapon
            PlayerPrefs.SetInt("SaveVayneStaff1D3", Global.VayneStaff1);
            PlayerPrefs.SetInt("SaveVayneStaff2D3", Global.VayneStaff2);
            PlayerPrefs.SetInt("SaveVayneStaff3D3", Global.VayneStaff3);
            PlayerPrefs.SetInt("SaveAliaShoes1D3", Global.AliaShoes1);
            PlayerPrefs.SetInt("SaveAliaShoes2D3", Global.AliaShoes2);
            PlayerPrefs.SetInt("SaveAliaShoes3D3", Global.AliaShoes3);
            PlayerPrefs.SetInt("SaveMariaCrystal1D3", Global.MariaCrystal1);
            PlayerPrefs.SetInt("SaveMariaCrystal2D3", Global.MariaCrystal2);
            PlayerPrefs.SetInt("SaveMariaCrystal3D3", Global.MariaCrystal3);
            PlayerPrefs.SetInt("SaveAlchemistArmor1D3", Global.AlchemistArmor1);
            PlayerPrefs.SetInt("SaveAlchemistArmor2D3", Global.AlchemistArmor2);
            PlayerPrefs.SetInt("SaveAlchemistArmor3D3", Global.AlchemistArmor3);
            PlayerPrefs.SetInt("SaveWarriorArmor1D3", Global.WarriorArmor1);
            PlayerPrefs.SetInt("SaveWarriorArmor2D3", Global.WarriorArmor2);
            PlayerPrefs.SetInt("SaveWarriorArmor3D3", Global.WarriorArmor3);

            //Set weapon status
            PlayerPrefs.SetInt("SaveVayneWeaponStatusD3", Global.VayneWeaponStatus);
            PlayerPrefs.SetInt("SaveVayneArmorStatusD3", Global.VayneArmorStatus);
            PlayerPrefs.SetInt("SaveAliaWeaponStatusD3", Global.AliaWeaponStatus);
            PlayerPrefs.SetInt("SaveAliaArmorStatusD3", Global.AliaArmorStatus);
            PlayerPrefs.SetInt("SaveMariaWeaponStatusD3", Global.MariaWeaponStatus);
            PlayerPrefs.SetInt("SaveMariaArmorStatusD3", Global.MariaArmorStatus);

            //Set weapon had bought
            PlayerPrefs.SetInt("SaveBought1D3", WeaponStoreController.Bought1);
            PlayerPrefs.SetInt("SaveBought2D3", WeaponStoreController.Bought2);
            PlayerPrefs.SetInt("SaveBought3D3", WeaponStoreController.Bought3);
            PlayerPrefs.SetInt("SaveBought4D3", WeaponStoreController.Bought4);
            PlayerPrefs.SetInt("SaveBought5D3", WeaponStoreController.Bought5);
            PlayerPrefs.SetInt("SaveBought6D3", WeaponStoreController.Bought6);
            PlayerPrefs.SetInt("SaveBought7D3", WeaponStoreController.Bought7);
            PlayerPrefs.SetInt("SaveBought8D3", WeaponStoreController.Bought8);
            PlayerPrefs.SetInt("SaveBought9D3", WeaponStoreController.Bought9);
            PlayerPrefs.SetInt("SaveBought10D3", WeaponStoreController.Bought10);
            PlayerPrefs.SetInt("SaveBought11D3", WeaponStoreController.Bought11);
            PlayerPrefs.SetInt("SaveBought12D3", WeaponStoreController.Bought12);
            PlayerPrefs.SetInt("SaveBought13D3", WeaponStoreController.Bought13);
            PlayerPrefs.SetInt("SaveBought14D3", WeaponStoreController.Bought14);
            PlayerPrefs.SetInt("SaveBought15D3", WeaponStoreController.Bought15);

            //Set item material
            PlayerPrefs.SetInt("SaveDriedLeavesD3", ContainerController.DriedLeaves);
            PlayerPrefs.SetInt("SavePureWaterD3", ContainerController.PureWater);
            PlayerPrefs.SetInt("SaveMorningDropD3", ContainerController.MorningDrop);
            PlayerPrefs.SetInt("SaveWheatD3", ContainerController.Wheat);
            PlayerPrefs.SetInt("SaveWoodD3", ContainerController.Wood);
            PlayerPrefs.SetInt("SaveStringD3", ContainerController.String);
            PlayerPrefs.SetInt("SaveIronD3", ContainerController.Iron);
            PlayerPrefs.SetInt("SaveManaGemD3", ContainerController.ManaGem);
            PlayerPrefs.SetInt("SaveScorpionVenomD3", ContainerController.ScorpionVenom);
            PlayerPrefs.SetInt("SaveInfernoSandD3", ContainerController.InfernoSand);
            PlayerPrefs.SetInt("SaveManaLiquidD3", ContainerController.ManaLiquid);
            PlayerPrefs.SetInt("SaveManaOreD3", ContainerController.ManaOre);
            PlayerPrefs.SetInt("SaveManaCrystalD3", ContainerController.ManaCrystal);
            PlayerPrefs.SetInt("SaveGuardianFeatherD3", ContainerController.GuardianFeather);
            PlayerPrefs.SetInt("SaveFireOreD3", ContainerController.FireOre);
            PlayerPrefs.SetInt("SaveGoldenFeatherD3", ContainerController.GoldenFeather);
            PlayerPrefs.SetInt("SaveRedManaCrystalD3", ContainerController.RedManaCrystal);
            PlayerPrefs.SetInt("SaveObsidianD3", ContainerController.Obsidian);
            PlayerPrefs.SetInt("SaveIceOreD3", ContainerController.IceOre);
            PlayerPrefs.SetInt("SaveIceLeatherD3", ContainerController.IceLeather);
            PlayerPrefs.SetInt("SaveBlueManaCrystalD3", ContainerController.BlueManaCrystal);
            PlayerPrefs.SetInt("SaveRedManaSlimeBallD3", ContainerController.RedManaSlimeBall);
            PlayerPrefs.SetInt("SaveBlueManaSlimeBallD3", ContainerController.BlueManaSlimeBall);
            PlayerPrefs.SetInt("SaveManaCoreFireZexelD3", ContainerController.ManaCoreFireZexel);
            PlayerPrefs.SetInt("SaveManaCoreIceZexelD3", ContainerController.ManaCoreIceZexel);
            PlayerPrefs.SetInt("SaveRockD3", ContainerController.Rock);
            PlayerPrefs.SetInt("SaveNatureGrassD3", ContainerController.NatureGrass);
            PlayerPrefs.SetInt("SaveManaDustD3", ContainerController.ManaDust);
            PlayerPrefs.SetInt("SaveManaEagleFeatherD3", ContainerController.ManaEagleFeather);
            PlayerPrefs.SetInt("SaveIceCrystalD3", ContainerController.IceCrystal);

            //Set item
            PlayerPrefs.SetInt("SaveHealPotionD3", ContainerController.HealPotion);
            PlayerPrefs.SetInt("SaveManaPotionD3", ContainerController.ManaPotion);
            PlayerPrefs.SetInt("SaveElixirPotionD3", ContainerController.ElixirPotion);
            PlayerPrefs.SetInt("SaveBomD3", ContainerController.Bom);
            PlayerPrefs.SetInt("SavePorridgeD3", ContainerController.Porridge);
            PlayerPrefs.SetInt("SaveManaClothD3", ContainerController.ManaCloth);
            PlayerPrefs.SetInt("SaveManaShieldD3", ContainerController.ManaShield);
            PlayerPrefs.SetInt("SaveVenomKillerD3", ContainerController.VenomKiller);
            PlayerPrefs.SetInt("SaveManaNecklaceD3", ContainerController.ManaNecklace);
            PlayerPrefs.SetInt("SaveManaGeneratorD3", ContainerController.ManaGenerator);
            PlayerPrefs.SetInt("SaveBaxiataD3", ContainerController.Baxiata);
            PlayerPrefs.SetInt("SaveBaxiataGemD3", ContainerController.BaxiataGem);
            PlayerPrefs.SetInt("SavePhotonriaD3", ContainerController.Photonria);
            PlayerPrefs.SetInt("SavePhotonriaGemD3", ContainerController.PhotonriaGem);
            PlayerPrefs.SetInt("SaveManaLiquidCatalystD3", ContainerController.ManaLiquidCatalyst);
            PlayerPrefs.SetInt("SaveRedLiquidCatalystD3", ContainerController.RedLiquidCatalyst);
            PlayerPrefs.SetInt("SaveBlueLiquidCatalystD3", ContainerController.BlueLiquidCatalyst);
            PlayerPrefs.SetInt("SaveManaCoreFireVayneD3", ContainerController.ManaCoreFireVayne);
            PlayerPrefs.SetInt("SaveManaCoreIceVayneD3", ContainerController.ManaCoreIceVayne);
            PlayerPrefs.SetInt("SavePureObsidianD3", ContainerController.PureObsidian);
            PlayerPrefs.SetInt("SaveFireManaGeneratorD3", ContainerController.FireManaGenerator);
            PlayerPrefs.SetInt("SaveIceManaGeneratorD3", ContainerController.IceManaGenerator);
            PlayerPrefs.SetInt("SavePowderOfLifeD3", ContainerController.PowderOfLife);
            PlayerPrefs.SetInt("SaveHoliHPD3", ContainerController.HoliHP);
            PlayerPrefs.SetInt("SaveHoliMPD3", ContainerController.HoliMP);
            PlayerPrefs.SetInt("SaveUltraBomD3", ContainerController.UltraBom);
            PlayerPrefs.SetInt("SaveReincarnationLifeD3", ContainerController.ReincarnationLife);
            PlayerPrefs.SetInt("SaveFireOfPeaceD3", ContainerController.FireOfPeace);
            PlayerPrefs.SetInt("SaveOmnipotentBoundaryD3", ContainerController.OmnipotentBoundary);

            //Set ManaSynthesize
            PlayerPrefs.SetInt("SaveManaSynthesizeD3", SynthesizeSystem.ManaSynthesize);
            PlayerPrefs.SetInt("SaveManaFireSynthesizeD3", SynthesizeSystem.ManaFireSynthesize);
            PlayerPrefs.SetInt("SaveManaIceSynthesizeD3", SynthesizeSystem.ManaIceSynthesize);

            PlayerPrefs.SetInt("SaveGameD3", 1);

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
    }

    public void ConfirmSaveGameOverride()
    {
        ClickFX.Play();
        if (SaveOverrideIndex == 1)
        {
            //Set date
            PlayerPrefs.SetInt("SaveGlobalDayNightD1", DateController.GlobalDayNight);
            PlayerPrefs.SetFloat("SaveGlobalTimeD1", DateController.GlobalTime);
            PlayerPrefs.SetInt("SaveGlobalUpHourD1", DateController.GlobalUpHour);
            PlayerPrefs.SetInt("SaveGlobalPHourD1", DateController.GlobalPHour);
            PlayerPrefs.SetInt("SaveGlobalDownHourD1", DateController.GlobalDownHour);

            //Set cut
            PlayerPrefs.SetInt("Savecus1D1", CutscenesController.cus1);
            PlayerPrefs.SetInt("Savecus2D1", CutscenesController.cus2);
            PlayerPrefs.SetInt("Savecus3D1", CutscenesController.cus3);
            PlayerPrefs.SetInt("Savecus4D1", CutscenesController.cus4);
            PlayerPrefs.SetInt("Savecus5D1", CutscenesController.cus5);
            PlayerPrefs.SetInt("Savecus6D1", CutscenesController.cus6);
            PlayerPrefs.SetInt("Savecus7D1", CutscenesController.cus7);
            PlayerPrefs.SetInt("Savecus8D1", CutscenesController.cus8);
            PlayerPrefs.SetInt("Savecus9D1", CutscenesController.cus9);
            PlayerPrefs.SetInt("Savecus10D1", CutscenesController.cus10);
            PlayerPrefs.SetInt("Savecus11D1", CutscenesController.cus11);
            PlayerPrefs.SetInt("Savecus12D1", CutscenesController.cus12);
            PlayerPrefs.SetInt("Savecus13D1", CutscenesController.cus13);
            PlayerPrefs.SetInt("Savecus14D1", CutscenesController.cus14);
            PlayerPrefs.SetInt("Savecus15D1", CutscenesController.cus15);
            PlayerPrefs.SetInt("Savecus16D1", CutscenesController.cus16);
            PlayerPrefs.SetInt("Savecus17D1", CutscenesController.cus17);
            PlayerPrefs.SetInt("Savecus18D1", CutscenesController.cus18);
            PlayerPrefs.SetInt("Savecus19D1", CutscenesController.cus19);
            PlayerPrefs.SetInt("Savecus20D1", CutscenesController.cus20);
            PlayerPrefs.SetInt("Savecus21D1", CutscenesController.cus21);
            PlayerPrefs.SetInt("Savecus22D1", CutscenesController.cus22);
            PlayerPrefs.SetInt("Savecus23D1", CutscenesController.cus23);
            PlayerPrefs.SetInt("Savecus24D1", CutscenesController.cus24);
            PlayerPrefs.SetInt("Savecus25D1", CutscenesController.cus25);
            PlayerPrefs.SetInt("Savecus26D1", CutscenesController.cus26);
            PlayerPrefs.SetInt("Savecus27D1", CutscenesController.cus27);
            PlayerPrefs.SetInt("Savecus28D1", CutscenesController.cus28);
            PlayerPrefs.SetInt("Savecus29D1", CutscenesController.cus29);
            PlayerPrefs.SetInt("Savecus30D1", CutscenesController.cus30);
            PlayerPrefs.SetInt("Savecus31D1", CutscenesController.cus31);
            PlayerPrefs.SetInt("Savecus32D1", CutscenesController.cus32);
            PlayerPrefs.SetInt("Savecus33D1", CutscenesController.cus33);
            PlayerPrefs.SetInt("Savecus34D1", CutscenesController.cus34);
            PlayerPrefs.SetInt("Savecus35D1", CutscenesController.cus35);
            PlayerPrefs.SetInt("Savecus36D1", CutscenesController.cus36);
            PlayerPrefs.SetInt("Savecus37D1", CutscenesController.cus37);
            PlayerPrefs.SetInt("Savecus38D1", CutscenesController.cus38);
            PlayerPrefs.SetInt("Savecus39D1", CutscenesController.cus39);
            PlayerPrefs.SetInt("Savecus40D1", CutscenesController.cus40);
            PlayerPrefs.SetInt("Savecus41D1", CutscenesController.cus41);
            PlayerPrefs.SetInt("Savecus42D1", CutscenesController.cus42);
            PlayerPrefs.SetInt("Savecus43D1", CutscenesController.cus43);
            PlayerPrefs.SetInt("Savecus44D1", CutscenesController.cus44);
            PlayerPrefs.SetInt("Savecus45D1", CutscenesController.cus45);
            PlayerPrefs.SetInt("Savecus46D1", CutscenesController.cus46);
            PlayerPrefs.SetInt("Savecus47D1", CutscenesController.cus47);
            PlayerPrefs.SetInt("Savecus48D1", CutscenesController.cus48);
            PlayerPrefs.SetInt("Savecus49D1", CutscenesController.cus49);
            PlayerPrefs.SetInt("Savecus50D1", CutscenesController.cus50);
            PlayerPrefs.SetInt("Savecus51D1", CutscenesController.cus51);
            PlayerPrefs.SetInt("Savecus52D1", CutscenesController.cus52);
            PlayerPrefs.SetInt("Savecus53D1", CutscenesController.cus53);
            PlayerPrefs.SetInt("Savecus54D1", CutscenesController.cus54);
            PlayerPrefs.SetInt("Savecus55D1", CutscenesController.cus55);
            PlayerPrefs.SetInt("Savecus56D1", CutscenesController.cus56);
            PlayerPrefs.SetInt("Savecus57D1", CutscenesController.cus57);
            PlayerPrefs.SetInt("Savecus58D1", CutscenesController.cus58);
            PlayerPrefs.SetInt("Savecus59D1", CutscenesController.cus59);
            PlayerPrefs.SetInt("Savecus60D1", CutscenesController.cus60);
            PlayerPrefs.SetInt("Savecus61D1", CutscenesController.cus61);
            PlayerPrefs.SetInt("Savecus62D1", CutscenesController.cus62);
            PlayerPrefs.SetInt("Savecus63D1", CutscenesController.cus63);
            PlayerPrefs.SetInt("Savecus64D1", CutscenesController.cus64);
            PlayerPrefs.SetInt("Savecus65D1", CutscenesController.cus65);
            PlayerPrefs.SetInt("Savecus66D1", CutscenesController.cus66);
            PlayerPrefs.SetInt("Savecus67D1", CutscenesController.cus67);
            PlayerPrefs.SetInt("Savecus68D1", CutscenesController.cus68);
            PlayerPrefs.SetInt("Savecus69D1", CutscenesController.cus69);
            PlayerPrefs.SetInt("Savecus70D1", CutscenesController.cus70);
            PlayerPrefs.SetInt("Savecus71D1", CutscenesController.cus71);
            PlayerPrefs.SetInt("Savecus72D1", CutscenesController.cus72);
            PlayerPrefs.SetInt("Savecus73D1", CutscenesController.cus73);
            PlayerPrefs.SetInt("Savecus74D1", CutscenesController.cus74);
            PlayerPrefs.SetInt("Savecus75D1", CutscenesController.cus75);
            PlayerPrefs.SetInt("Savecus76D1", CutscenesController.cus76);
            PlayerPrefs.SetInt("Savecus77D1", CutscenesController.cus77);
            PlayerPrefs.SetInt("Savecus78D1", CutscenesController.cus78);
            PlayerPrefs.SetInt("Savecus79D1", CutscenesController.cus79);
            PlayerPrefs.SetInt("Savecus80D1", CutscenesController.cus80);
            PlayerPrefs.SetInt("Savecus81D1", CutscenesController.cus81);
            PlayerPrefs.SetInt("Savecus82D1", CutscenesController.cus82);
            PlayerPrefs.SetInt("Savecus83D1", CutscenesController.cus83);
            PlayerPrefs.SetInt("Savecus84D1", CutscenesController.cus84);
            PlayerPrefs.SetInt("Savecus85D1", CutscenesController.cus85);
            PlayerPrefs.SetInt("Savecus86D1", CutscenesController.cus86);
            PlayerPrefs.SetInt("Savecus87D1", CutscenesController.cus87);
            PlayerPrefs.SetInt("Savecus88D1", CutscenesController.cus88);
            PlayerPrefs.SetInt("Savecus89D1", CutscenesController.cus89);
            PlayerPrefs.SetInt("Savecus90D1", CutscenesController.cus90);
            PlayerPrefs.SetInt("Savecus91D1", CutscenesController.cus91);
            PlayerPrefs.SetInt("Savecus92D1", CutscenesController.cus92);
            PlayerPrefs.SetInt("Savecus93D1", CutscenesController.cus93);
            PlayerPrefs.SetInt("Savecus94D1", CutscenesController.cus94);
            PlayerPrefs.SetInt("Savecus95D1", CutscenesController.cus95);
            PlayerPrefs.SetInt("Savecus96D1", CutscenesController.cus96);
            PlayerPrefs.SetInt("Savecus97D1", CutscenesController.cus97);
            PlayerPrefs.SetInt("Savecus98D1", CutscenesController.cus98);
            PlayerPrefs.SetInt("Savecus99D1", CutscenesController.cus99);
            PlayerPrefs.SetInt("Savecus100D1", CutscenesController.cus100);
            PlayerPrefs.SetInt("Savecus101D1", CutscenesController.cus101);
            PlayerPrefs.SetInt("Savecus102D1", CutscenesController.cus102);
            PlayerPrefs.SetInt("Savecus103D1", CutscenesController.cus103);
            PlayerPrefs.SetInt("Savecus104D1", CutscenesController.cus104);
            PlayerPrefs.SetInt("Savecus105D1", CutscenesController.cus105);
            PlayerPrefs.SetInt("Savecus106D1", CutscenesController.cus106);
            PlayerPrefs.SetInt("Savecus107D1", CutscenesController.cus107);
            PlayerPrefs.SetInt("Savecus108D1", CutscenesController.cus108);
            PlayerPrefs.SetInt("Savecus109D1", CutscenesController.cus109);
            PlayerPrefs.SetInt("Savecus110D1", CutscenesController.cus110);
            PlayerPrefs.SetInt("Savecus111D1", CutscenesController.cus111);
            PlayerPrefs.SetInt("Savecus112D1", CutscenesController.cus112);
            PlayerPrefs.SetInt("Savecus113D1", CutscenesController.cus113);
            PlayerPrefs.SetInt("Savecus114D1", CutscenesController.cus114);
            PlayerPrefs.SetInt("Savecus115D1", CutscenesController.cus115);
            PlayerPrefs.SetInt("Savecus116D1", CutscenesController.cus116);
            PlayerPrefs.SetInt("Savecus117D1", CutscenesController.cus117);
            PlayerPrefs.SetInt("Savecus118D1", CutscenesController.cus118);
            PlayerPrefs.SetInt("Savecus119D1", CutscenesController.cus119);
            PlayerPrefs.SetInt("Savecus120D1", CutscenesController.cus120);

            //Set quest
            PlayerPrefs.SetInt("SaveKGQD1", GlobalQuest.KillGoblinQuest);
            PlayerPrefs.SetInt("SaveHVStop1D1", GlobalQuest.HelpVillagerStop1);
            PlayerPrefs.SetInt("SaveHVStop2D1", GlobalQuest.HelpVillagerStop2);
            PlayerPrefs.SetInt("SaveHVStop3D1", GlobalQuest.HelpVillagerStop3);
            PlayerPrefs.SetInt("SaveHVD1", GlobalQuest.HelpVillagerDone);
            PlayerPrefs.SetInt("SavePorridgeSynD1", CutscenesTrigger.PorridgeSyn);
            PlayerPrefs.SetInt("SaveBomSynD1", CutscenesTrigger.BomSyn);
            PlayerPrefs.SetInt("SaveGolemnKillD1", CutscenesTrigger.GolemnKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillD1", CutscenesTrigger.InfernoScorpionKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillP2D1", CutscenesTrigger.InfernoScorpionKillP2);
            PlayerPrefs.SetInt("SaveIceFangKillD1", CutscenesTrigger.IceFangKill);
            PlayerPrefs.SetInt("SaveGoblinKillP2D1", CutscenesTrigger.GoblinKillP2);
            PlayerPrefs.SetInt("SaveGolemnKillP2D1", CutscenesTrigger.GolemnKillP2);

            //Set player 1 (Vayne)
            PlayerPrefs.SetInt("SaveMaxHPP1D1", Global.MaxHPP1);
            PlayerPrefs.SetInt("SaveHPP1D1", Global.CurHPP1);
            PlayerPrefs.SetInt("SaveMaxMPP1D1", Global.MaxMPP1);
            PlayerPrefs.SetInt("SaveMPP1D1", Global.CurMPP1);
            PlayerPrefs.SetInt("SaveDamageP1D1", Global.DamageP1);
            PlayerPrefs.SetInt("SaveSpeedP1D1", Global.SpeedP1);
            PlayerPrefs.SetInt("SaveLevelP1D1", Global.LevelP1);
            PlayerPrefs.SetInt("SaveMaxEXPP1D1", Global.MaxEXPP1);
            PlayerPrefs.SetInt("SaveCurEXPP1D1", Global.CurEXPP1);
            PlayerPrefs.SetInt("SavePlusPointP1D1", Global.PlusPointP1);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP1D1", Global.PlusPointAttackLvP1);
            PlayerPrefs.SetInt("SavePlusPointHPLvP1D1", Global.PlusPointHPLvP1);
            PlayerPrefs.SetInt("SavePlusPointMPLvP1D1", Global.PlusPointMPLvP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP1D1", Global.PlusPointSpeedLvP1);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP1D1", Global.PlusPointAttackInfoP1);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP1D1", Global.PlusPointHPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP1D1", Global.PlusPointMPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP1D1", Global.PlusPointSpeedInfoP1);

            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SaveMaxHPP2D1", Global.MaxHPP2);
            PlayerPrefs.SetInt("SaveHPP2D1", Global.CurHPP2);
            PlayerPrefs.SetInt("SaveMaxMPP2D1", Global.MaxMPP2);
            PlayerPrefs.SetInt("SaveMPP2D1", Global.CurMPP2);
            PlayerPrefs.SetInt("SaveDamageP2D1", Global.DamageP2);
            PlayerPrefs.SetInt("SaveSpeedP2D1", Global.SpeedP2);
            PlayerPrefs.SetInt("SaveLevelP2D1", Global.LevelP2);
            PlayerPrefs.SetInt("SaveMaxEXPP2D1", Global.MaxEXPP2);
            PlayerPrefs.SetInt("SaveCurEXPP2D1", Global.CurEXPP2);
            PlayerPrefs.SetInt("SavePlusPointP2D1", Global.PlusPointP2);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP2D1", Global.PlusPointAttackLvP2);
            PlayerPrefs.SetInt("SavePlusPointHPLvP2D1", Global.PlusPointHPLvP2);
            PlayerPrefs.SetInt("SavePlusPointMPLvP2D1", Global.PlusPointMPLvP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP2D1", Global.PlusPointSpeedLvP2);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP2D1", Global.PlusPointAttackInfoP2);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP2D1", Global.PlusPointHPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP2D1", Global.PlusPointMPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP2D1", Global.PlusPointSpeedInfoP2);

            //Set player 3 (Maria)
            PlayerPrefs.SetInt("SaveMaxHPP3D1", Global.MaxHPP3);
            PlayerPrefs.SetInt("SaveHPP3D1", Global.CurHPP3);
            PlayerPrefs.SetInt("SaveMaxMPP3D1", Global.MaxMPP3);
            PlayerPrefs.SetInt("SaveMPP3D1", Global.CurMPP3);
            PlayerPrefs.SetInt("SaveDamageP3D1", Global.DamageP3);
            PlayerPrefs.SetInt("SaveSpeedP3D1", Global.SpeedP3);
            PlayerPrefs.SetInt("SaveLevelP3D1", Global.LevelP3);
            PlayerPrefs.SetInt("SaveMaxEXPP3D1", Global.MaxEXPP3);
            PlayerPrefs.SetInt("SaveCurEXPP3D1", Global.CurEXPP3);
            PlayerPrefs.SetInt("SavePlusPointP3D1", Global.PlusPointP3);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP3D1", Global.PlusPointAttackLvP3);
            PlayerPrefs.SetInt("SavePlusPointHPLvP3D1", Global.PlusPointHPLvP3);
            PlayerPrefs.SetInt("SavePlusPointMPLvP3D1", Global.PlusPointMPLvP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP3D1", Global.PlusPointSpeedLvP3);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP3D1", Global.PlusPointAttackInfoP3);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP3D1", Global.PlusPointHPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP3D1", Global.PlusPointMPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP3D1", Global.PlusPointSpeedInfoP3);

            //Set Zen
            PlayerPrefs.SetInt("SaveZenD1", Global.Zen);

            //Set weapon
            PlayerPrefs.SetInt("SaveVayneStaff1D1", Global.VayneStaff1);
            PlayerPrefs.SetInt("SaveVayneStaff2D1", Global.VayneStaff2);
            PlayerPrefs.SetInt("SaveVayneStaff3D1", Global.VayneStaff3);
            PlayerPrefs.SetInt("SaveAliaShoes1D1", Global.AliaShoes1);
            PlayerPrefs.SetInt("SaveAliaShoes2D1", Global.AliaShoes2);
            PlayerPrefs.SetInt("SaveAliaShoes3D1", Global.AliaShoes3);
            PlayerPrefs.SetInt("SaveMariaCrystal1D1", Global.MariaCrystal1);
            PlayerPrefs.SetInt("SaveMariaCrystal2D1", Global.MariaCrystal2);
            PlayerPrefs.SetInt("SaveMariaCrystal3D1", Global.MariaCrystal3);
            PlayerPrefs.SetInt("SaveAlchemistArmor1D1", Global.AlchemistArmor1);
            PlayerPrefs.SetInt("SaveAlchemistArmor2D1", Global.AlchemistArmor2);
            PlayerPrefs.SetInt("SaveAlchemistArmor3D1", Global.AlchemistArmor3);
            PlayerPrefs.SetInt("SaveWarriorArmor1D1", Global.WarriorArmor1);
            PlayerPrefs.SetInt("SaveWarriorArmor2D1", Global.WarriorArmor2);
            PlayerPrefs.SetInt("SaveWarriorArmor3D1", Global.WarriorArmor3);

            //Set weapon status
            PlayerPrefs.SetInt("SaveVayneWeaponStatusD1", Global.VayneWeaponStatus);
            PlayerPrefs.SetInt("SaveVayneArmorStatusD1", Global.VayneArmorStatus);
            PlayerPrefs.SetInt("SaveAliaWeaponStatusD1", Global.AliaWeaponStatus);
            PlayerPrefs.SetInt("SaveAliaArmorStatusD1", Global.AliaArmorStatus);
            PlayerPrefs.SetInt("SaveMariaWeaponStatusD1", Global.MariaWeaponStatus);
            PlayerPrefs.SetInt("SaveMariaArmorStatusD1", Global.MariaArmorStatus);

            //Set weapon had bought
            PlayerPrefs.SetInt("SaveBought1D1", WeaponStoreController.Bought1);
            PlayerPrefs.SetInt("SaveBought2D1", WeaponStoreController.Bought2);
            PlayerPrefs.SetInt("SaveBought3D1", WeaponStoreController.Bought3);
            PlayerPrefs.SetInt("SaveBought4D1", WeaponStoreController.Bought4);
            PlayerPrefs.SetInt("SaveBought5D1", WeaponStoreController.Bought5);
            PlayerPrefs.SetInt("SaveBought6D1", WeaponStoreController.Bought6);
            PlayerPrefs.SetInt("SaveBought7D1", WeaponStoreController.Bought7);
            PlayerPrefs.SetInt("SaveBought8D1", WeaponStoreController.Bought8);
            PlayerPrefs.SetInt("SaveBought9D1", WeaponStoreController.Bought9);
            PlayerPrefs.SetInt("SaveBought10D1", WeaponStoreController.Bought10);
            PlayerPrefs.SetInt("SaveBought11D1", WeaponStoreController.Bought11);
            PlayerPrefs.SetInt("SaveBought12D1", WeaponStoreController.Bought12);
            PlayerPrefs.SetInt("SaveBought13D1", WeaponStoreController.Bought13);
            PlayerPrefs.SetInt("SaveBought14D1", WeaponStoreController.Bought14);
            PlayerPrefs.SetInt("SaveBought15D1", WeaponStoreController.Bought15);

            //Set item material
            PlayerPrefs.SetInt("SaveDriedLeavesD1", ContainerController.DriedLeaves);
            PlayerPrefs.SetInt("SavePureWaterD1", ContainerController.PureWater);
            PlayerPrefs.SetInt("SaveMorningDropD1", ContainerController.MorningDrop);
            PlayerPrefs.SetInt("SaveWheatD1", ContainerController.Wheat);
            PlayerPrefs.SetInt("SaveWoodD1", ContainerController.Wood);
            PlayerPrefs.SetInt("SaveStringD1", ContainerController.String);
            PlayerPrefs.SetInt("SaveIronD1", ContainerController.Iron);
            PlayerPrefs.SetInt("SaveManaGemD1", ContainerController.ManaGem);
            PlayerPrefs.SetInt("SaveScorpionVenomD1", ContainerController.ScorpionVenom);
            PlayerPrefs.SetInt("SaveInfernoSandD1", ContainerController.InfernoSand);
            PlayerPrefs.SetInt("SaveManaLiquidD1", ContainerController.ManaLiquid);
            PlayerPrefs.SetInt("SaveManaOreD1", ContainerController.ManaOre);
            PlayerPrefs.SetInt("SaveManaCrystalD1", ContainerController.ManaCrystal);
            PlayerPrefs.SetInt("SaveGuardianFeatherD1", ContainerController.GuardianFeather);
            PlayerPrefs.SetInt("SaveFireOreD1", ContainerController.FireOre);
            PlayerPrefs.SetInt("SaveGoldenFeatherD1", ContainerController.GoldenFeather);
            PlayerPrefs.SetInt("SaveRedManaCrystalD1", ContainerController.RedManaCrystal);
            PlayerPrefs.SetInt("SaveObsidianD1", ContainerController.Obsidian);
            PlayerPrefs.SetInt("SaveIceOreD1", ContainerController.IceOre);
            PlayerPrefs.SetInt("SaveIceLeatherD1", ContainerController.IceLeather);
            PlayerPrefs.SetInt("SaveBlueManaCrystalD1", ContainerController.BlueManaCrystal);
            PlayerPrefs.SetInt("SaveRedManaSlimeBallD1", ContainerController.RedManaSlimeBall);
            PlayerPrefs.SetInt("SaveBlueManaSlimeBallD1", ContainerController.BlueManaSlimeBall);
            PlayerPrefs.SetInt("SaveManaCoreFireZexelD1", ContainerController.ManaCoreFireZexel);
            PlayerPrefs.SetInt("SaveManaCoreIceZexelD1", ContainerController.ManaCoreIceZexel);
            PlayerPrefs.SetInt("SaveRockD1", ContainerController.Rock);
            PlayerPrefs.SetInt("SaveNatureGrassD1", ContainerController.NatureGrass);
            PlayerPrefs.SetInt("SaveManaDustD1", ContainerController.ManaDust);
            PlayerPrefs.SetInt("SaveManaEagleFeatherD1", ContainerController.ManaEagleFeather);
            PlayerPrefs.SetInt("SaveIceCrystalD1", ContainerController.IceCrystal);

            //Set item
            PlayerPrefs.SetInt("SaveHealPotionD1", ContainerController.HealPotion);
            PlayerPrefs.SetInt("SaveManaPotionD1", ContainerController.ManaPotion);
            PlayerPrefs.SetInt("SaveElixirPotionD1", ContainerController.ElixirPotion);
            PlayerPrefs.SetInt("SaveBomD1", ContainerController.Bom);
            PlayerPrefs.SetInt("SavePorridgeD1", ContainerController.Porridge);
            PlayerPrefs.SetInt("SaveManaClothD1", ContainerController.ManaCloth);
            PlayerPrefs.SetInt("SaveManaShieldD1", ContainerController.ManaShield);
            PlayerPrefs.SetInt("SaveVenomKillerD1", ContainerController.VenomKiller);
            PlayerPrefs.SetInt("SaveManaNecklaceD1", ContainerController.ManaNecklace);
            PlayerPrefs.SetInt("SaveManaGeneratorD1", ContainerController.ManaGenerator);
            PlayerPrefs.SetInt("SaveBaxiataD1", ContainerController.Baxiata);
            PlayerPrefs.SetInt("SaveBaxiataGemD1", ContainerController.BaxiataGem);
            PlayerPrefs.SetInt("SavePhotonriaD1", ContainerController.Photonria);
            PlayerPrefs.SetInt("SavePhotonriaGemD1", ContainerController.PhotonriaGem);
            PlayerPrefs.SetInt("SaveManaLiquidCatalystD1", ContainerController.ManaLiquidCatalyst);
            PlayerPrefs.SetInt("SaveRedLiquidCatalystD1", ContainerController.RedLiquidCatalyst);
            PlayerPrefs.SetInt("SaveBlueLiquidCatalystD1", ContainerController.BlueLiquidCatalyst);
            PlayerPrefs.SetInt("SaveManaCoreFireVayneD1", ContainerController.ManaCoreFireVayne);
            PlayerPrefs.SetInt("SaveManaCoreIceVayneD1", ContainerController.ManaCoreIceVayne);
            PlayerPrefs.SetInt("SavePureObsidianD1", ContainerController.PureObsidian);
            PlayerPrefs.SetInt("SaveFireManaGeneratorD1", ContainerController.FireManaGenerator);
            PlayerPrefs.SetInt("SaveIceManaGeneratorD1", ContainerController.IceManaGenerator);
            PlayerPrefs.SetInt("SavePowderOfLifeD1", ContainerController.PowderOfLife);
            PlayerPrefs.SetInt("SaveHoliHPD1", ContainerController.HoliHP);
            PlayerPrefs.SetInt("SaveHoliMPD1", ContainerController.HoliMP);
            PlayerPrefs.SetInt("SaveUltraBomD1", ContainerController.UltraBom);
            PlayerPrefs.SetInt("SaveReincarnationLifeD1", ContainerController.ReincarnationLife);
            PlayerPrefs.SetInt("SaveFireOfPeaceD1", ContainerController.FireOfPeace);
            PlayerPrefs.SetInt("SaveOmnipotentBoundaryD1", ContainerController.OmnipotentBoundary);

            //Set ManaSynthesize
            PlayerPrefs.SetInt("SaveManaSynthesizeD1", SynthesizeSystem.ManaSynthesize);
            PlayerPrefs.SetInt("SaveManaFireSynthesizeD1", SynthesizeSystem.ManaFireSynthesize);
            PlayerPrefs.SetInt("SaveManaIceSynthesizeD1", SynthesizeSystem.ManaIceSynthesize);

            PlayerPrefs.SetInt("SaveGameD1", 1);

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
        else if(SaveOverrideIndex == 2)
        {
            //Set date
            PlayerPrefs.SetInt("SaveGlobalDayNightD2", DateController.GlobalDayNight);
            PlayerPrefs.SetFloat("SaveGlobalTimeD2", DateController.GlobalTime);
            PlayerPrefs.SetInt("SaveGlobalUpHourD2", DateController.GlobalUpHour);
            PlayerPrefs.SetInt("SaveGlobalPHourD2", DateController.GlobalPHour);
            PlayerPrefs.SetInt("SaveGlobalDownHourD2", DateController.GlobalDownHour);

            //Set cut
            PlayerPrefs.SetInt("Savecus1D2", CutscenesController.cus1);
            PlayerPrefs.SetInt("Savecus2D2", CutscenesController.cus2);
            PlayerPrefs.SetInt("Savecus3D2", CutscenesController.cus3);
            PlayerPrefs.SetInt("Savecus4D2", CutscenesController.cus4);
            PlayerPrefs.SetInt("Savecus5D2", CutscenesController.cus5);
            PlayerPrefs.SetInt("Savecus6D2", CutscenesController.cus6);
            PlayerPrefs.SetInt("Savecus7D2", CutscenesController.cus7);
            PlayerPrefs.SetInt("Savecus8D2", CutscenesController.cus8);
            PlayerPrefs.SetInt("Savecus9D2", CutscenesController.cus9);
            PlayerPrefs.SetInt("Savecus10D2", CutscenesController.cus10);
            PlayerPrefs.SetInt("Savecus11D2", CutscenesController.cus11);
            PlayerPrefs.SetInt("Savecus12D2", CutscenesController.cus12);
            PlayerPrefs.SetInt("Savecus13D2", CutscenesController.cus13);
            PlayerPrefs.SetInt("Savecus14D2", CutscenesController.cus14);
            PlayerPrefs.SetInt("Savecus15D2", CutscenesController.cus15);
            PlayerPrefs.SetInt("Savecus16D2", CutscenesController.cus16);
            PlayerPrefs.SetInt("Savecus17D2", CutscenesController.cus17);
            PlayerPrefs.SetInt("Savecus18D2", CutscenesController.cus18);
            PlayerPrefs.SetInt("Savecus19D2", CutscenesController.cus19);
            PlayerPrefs.SetInt("Savecus20D2", CutscenesController.cus20);
            PlayerPrefs.SetInt("Savecus21D2", CutscenesController.cus21);
            PlayerPrefs.SetInt("Savecus22D2", CutscenesController.cus22);
            PlayerPrefs.SetInt("Savecus23D2", CutscenesController.cus23);
            PlayerPrefs.SetInt("Savecus24D2", CutscenesController.cus24);
            PlayerPrefs.SetInt("Savecus25D2", CutscenesController.cus25);
            PlayerPrefs.SetInt("Savecus26D2", CutscenesController.cus26);
            PlayerPrefs.SetInt("Savecus27D2", CutscenesController.cus27);
            PlayerPrefs.SetInt("Savecus28D2", CutscenesController.cus28);
            PlayerPrefs.SetInt("Savecus29D2", CutscenesController.cus29);
            PlayerPrefs.SetInt("Savecus30D2", CutscenesController.cus30);
            PlayerPrefs.SetInt("Savecus31D2", CutscenesController.cus31);
            PlayerPrefs.SetInt("Savecus32D2", CutscenesController.cus32);
            PlayerPrefs.SetInt("Savecus33D2", CutscenesController.cus33);
            PlayerPrefs.SetInt("Savecus34D2", CutscenesController.cus34);
            PlayerPrefs.SetInt("Savecus35D2", CutscenesController.cus35);
            PlayerPrefs.SetInt("Savecus36D2", CutscenesController.cus36);
            PlayerPrefs.SetInt("Savecus37D2", CutscenesController.cus37);
            PlayerPrefs.SetInt("Savecus38D2", CutscenesController.cus38);
            PlayerPrefs.SetInt("Savecus39D2", CutscenesController.cus39);
            PlayerPrefs.SetInt("Savecus40D2", CutscenesController.cus40);
            PlayerPrefs.SetInt("Savecus41D2", CutscenesController.cus41);
            PlayerPrefs.SetInt("Savecus42D2", CutscenesController.cus42);
            PlayerPrefs.SetInt("Savecus43D2", CutscenesController.cus43);
            PlayerPrefs.SetInt("Savecus44D2", CutscenesController.cus44);
            PlayerPrefs.SetInt("Savecus45D2", CutscenesController.cus45);
            PlayerPrefs.SetInt("Savecus46D2", CutscenesController.cus46);
            PlayerPrefs.SetInt("Savecus47D2", CutscenesController.cus47);
            PlayerPrefs.SetInt("Savecus48D2", CutscenesController.cus48);
            PlayerPrefs.SetInt("Savecus49D2", CutscenesController.cus49);
            PlayerPrefs.SetInt("Savecus50D2", CutscenesController.cus50);
            PlayerPrefs.SetInt("Savecus51D2", CutscenesController.cus51);
            PlayerPrefs.SetInt("Savecus52D2", CutscenesController.cus52);
            PlayerPrefs.SetInt("Savecus53D2", CutscenesController.cus53);
            PlayerPrefs.SetInt("Savecus54D2", CutscenesController.cus54);
            PlayerPrefs.SetInt("Savecus55D2", CutscenesController.cus55);
            PlayerPrefs.SetInt("Savecus56D2", CutscenesController.cus56);
            PlayerPrefs.SetInt("Savecus57D2", CutscenesController.cus57);
            PlayerPrefs.SetInt("Savecus58D2", CutscenesController.cus58);
            PlayerPrefs.SetInt("Savecus59D2", CutscenesController.cus59);
            PlayerPrefs.SetInt("Savecus60D2", CutscenesController.cus60);
            PlayerPrefs.SetInt("Savecus61D2", CutscenesController.cus61);
            PlayerPrefs.SetInt("Savecus62D2", CutscenesController.cus62);
            PlayerPrefs.SetInt("Savecus63D2", CutscenesController.cus63);
            PlayerPrefs.SetInt("Savecus64D2", CutscenesController.cus64);
            PlayerPrefs.SetInt("Savecus65D2", CutscenesController.cus65);
            PlayerPrefs.SetInt("Savecus66D2", CutscenesController.cus66);
            PlayerPrefs.SetInt("Savecus67D2", CutscenesController.cus67);
            PlayerPrefs.SetInt("Savecus68D2", CutscenesController.cus68);
            PlayerPrefs.SetInt("Savecus69D2", CutscenesController.cus69);
            PlayerPrefs.SetInt("Savecus70D2", CutscenesController.cus70);
            PlayerPrefs.SetInt("Savecus71D2", CutscenesController.cus71);
            PlayerPrefs.SetInt("Savecus72D2", CutscenesController.cus72);
            PlayerPrefs.SetInt("Savecus73D2", CutscenesController.cus73);
            PlayerPrefs.SetInt("Savecus74D2", CutscenesController.cus74);
            PlayerPrefs.SetInt("Savecus75D2", CutscenesController.cus75);
            PlayerPrefs.SetInt("Savecus76D2", CutscenesController.cus76);
            PlayerPrefs.SetInt("Savecus77D2", CutscenesController.cus77);
            PlayerPrefs.SetInt("Savecus78D2", CutscenesController.cus78);
            PlayerPrefs.SetInt("Savecus79D2", CutscenesController.cus79);
            PlayerPrefs.SetInt("Savecus80D2", CutscenesController.cus80);
            PlayerPrefs.SetInt("Savecus81D2", CutscenesController.cus81);
            PlayerPrefs.SetInt("Savecus82D2", CutscenesController.cus82);
            PlayerPrefs.SetInt("Savecus83D2", CutscenesController.cus83);
            PlayerPrefs.SetInt("Savecus84D2", CutscenesController.cus84);
            PlayerPrefs.SetInt("Savecus85D2", CutscenesController.cus85);
            PlayerPrefs.SetInt("Savecus86D2", CutscenesController.cus86);
            PlayerPrefs.SetInt("Savecus87D2", CutscenesController.cus87);
            PlayerPrefs.SetInt("Savecus88D2", CutscenesController.cus88);
            PlayerPrefs.SetInt("Savecus89D2", CutscenesController.cus89);
            PlayerPrefs.SetInt("Savecus90D2", CutscenesController.cus90);
            PlayerPrefs.SetInt("Savecus91D2", CutscenesController.cus91);
            PlayerPrefs.SetInt("Savecus92D2", CutscenesController.cus92);
            PlayerPrefs.SetInt("Savecus93D2", CutscenesController.cus93);
            PlayerPrefs.SetInt("Savecus94D2", CutscenesController.cus94);
            PlayerPrefs.SetInt("Savecus95D2", CutscenesController.cus95);
            PlayerPrefs.SetInt("Savecus96D2", CutscenesController.cus96);
            PlayerPrefs.SetInt("Savecus97D2", CutscenesController.cus97);
            PlayerPrefs.SetInt("Savecus98D2", CutscenesController.cus98);
            PlayerPrefs.SetInt("Savecus99D2", CutscenesController.cus99);
            PlayerPrefs.SetInt("Savecus100D2", CutscenesController.cus100);
            PlayerPrefs.SetInt("Savecus101D2", CutscenesController.cus101);
            PlayerPrefs.SetInt("Savecus102D2", CutscenesController.cus102);
            PlayerPrefs.SetInt("Savecus103D2", CutscenesController.cus103);
            PlayerPrefs.SetInt("Savecus104D2", CutscenesController.cus104);
            PlayerPrefs.SetInt("Savecus105D2", CutscenesController.cus105);
            PlayerPrefs.SetInt("Savecus106D2", CutscenesController.cus106);
            PlayerPrefs.SetInt("Savecus107D2", CutscenesController.cus107);
            PlayerPrefs.SetInt("Savecus108D2", CutscenesController.cus108);
            PlayerPrefs.SetInt("Savecus109D2", CutscenesController.cus109);
            PlayerPrefs.SetInt("Savecus110D2", CutscenesController.cus110);
            PlayerPrefs.SetInt("Savecus111D2", CutscenesController.cus111);
            PlayerPrefs.SetInt("Savecus112D2", CutscenesController.cus112);
            PlayerPrefs.SetInt("Savecus113D2", CutscenesController.cus113);
            PlayerPrefs.SetInt("Savecus114D2", CutscenesController.cus114);
            PlayerPrefs.SetInt("Savecus115D2", CutscenesController.cus115);
            PlayerPrefs.SetInt("Savecus116D2", CutscenesController.cus116);
            PlayerPrefs.SetInt("Savecus117D2", CutscenesController.cus117);
            PlayerPrefs.SetInt("Savecus118D2", CutscenesController.cus118);
            PlayerPrefs.SetInt("Savecus119D2", CutscenesController.cus119);
            PlayerPrefs.SetInt("Savecus120D2", CutscenesController.cus120);

            //Set quest
            PlayerPrefs.SetInt("SaveKGQD2", GlobalQuest.KillGoblinQuest);
            PlayerPrefs.SetInt("SaveHVStop1D2", GlobalQuest.HelpVillagerStop1);
            PlayerPrefs.SetInt("SaveHVStop2D2", GlobalQuest.HelpVillagerStop2);
            PlayerPrefs.SetInt("SaveHVStop3D2", GlobalQuest.HelpVillagerStop3);
            PlayerPrefs.SetInt("SaveHVD2", GlobalQuest.HelpVillagerDone);
            PlayerPrefs.SetInt("SavePorridgeSynD2", CutscenesTrigger.PorridgeSyn);
            PlayerPrefs.SetInt("SaveBomSynD2", CutscenesTrigger.BomSyn);
            PlayerPrefs.SetInt("SaveGolemnKillD2", CutscenesTrigger.GolemnKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillD2", CutscenesTrigger.InfernoScorpionKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillP2D2", CutscenesTrigger.InfernoScorpionKillP2);
            PlayerPrefs.SetInt("SaveIceFangKillD2", CutscenesTrigger.IceFangKill);
            PlayerPrefs.SetInt("SaveGoblinKillP2D2", CutscenesTrigger.GoblinKillP2);
            PlayerPrefs.SetInt("SaveGolemnKillP2D2", CutscenesTrigger.GolemnKillP2);

            //Set Vayne
            PlayerPrefs.SetInt("SaveMaxHPP1D2", Global.MaxHPP1);
            PlayerPrefs.SetInt("SaveHPP1D2", Global.CurHPP1);
            PlayerPrefs.SetInt("SaveMaxMPP1D2", Global.MaxMPP1);
            PlayerPrefs.SetInt("SaveMPP1D2", Global.CurMPP1);
            PlayerPrefs.SetInt("SaveDamageP1D2", Global.DamageP1);
            PlayerPrefs.SetInt("SaveSpeedP1D2", Global.SpeedP1);
            PlayerPrefs.SetInt("SaveLevelP1D2", Global.LevelP1);
            PlayerPrefs.SetInt("SaveMaxEXPP1D2", Global.MaxEXPP1);
            PlayerPrefs.SetInt("SaveCurEXPP1D2", Global.CurEXPP1);
            PlayerPrefs.SetInt("SavePlusPointP1D2", Global.PlusPointP1);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP1D2", Global.PlusPointAttackLvP1);
            PlayerPrefs.SetInt("SavePlusPointHPLvP1D2", Global.PlusPointHPLvP1);
            PlayerPrefs.SetInt("SavePlusPointMPLvP1D2", Global.PlusPointMPLvP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP1D2", Global.PlusPointSpeedLvP1);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP1D2", Global.PlusPointAttackInfoP1);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP1D2", Global.PlusPointHPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP1D2", Global.PlusPointMPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP1D2", Global.PlusPointSpeedInfoP1);

            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SaveMaxHPP2D2", Global.MaxHPP2);
            PlayerPrefs.SetInt("SaveHPP2D2", Global.CurHPP2);
            PlayerPrefs.SetInt("SaveMaxMPP2D2", Global.MaxMPP2);
            PlayerPrefs.SetInt("SaveMPP2D2", Global.CurMPP2);
            PlayerPrefs.SetInt("SaveDamageP2D2", Global.DamageP2);
            PlayerPrefs.SetInt("SaveSpeedP2D2", Global.SpeedP2);
            PlayerPrefs.SetInt("SaveLevelP2D2", Global.LevelP2);
            PlayerPrefs.SetInt("SaveMaxEXPP2D2", Global.MaxEXPP2);
            PlayerPrefs.SetInt("SaveCurEXPP2D2", Global.CurEXPP2);
            PlayerPrefs.SetInt("SavePlusPointP2D2", Global.PlusPointP2);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP2D2", Global.PlusPointAttackLvP2);
            PlayerPrefs.SetInt("SavePlusPointHPLvP2D2", Global.PlusPointHPLvP2);
            PlayerPrefs.SetInt("SavePlusPointMPLvP2D2", Global.PlusPointMPLvP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP2D2", Global.PlusPointSpeedLvP2);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP2D2", Global.PlusPointAttackInfoP2);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP2D2", Global.PlusPointHPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP2D2", Global.PlusPointMPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP2D2", Global.PlusPointSpeedInfoP2);

            //Set player 3 (Maria)
            PlayerPrefs.SetInt("SaveMaxHPP3D2", Global.MaxHPP3);
            PlayerPrefs.SetInt("SaveHPP3D2", Global.CurHPP3);
            PlayerPrefs.SetInt("SaveMaxMPP3D2", Global.MaxMPP3);
            PlayerPrefs.SetInt("SaveMPP3D2", Global.CurMPP3);
            PlayerPrefs.SetInt("SaveDamageP3D2", Global.DamageP3);
            PlayerPrefs.SetInt("SaveSpeedP3D2", Global.SpeedP3);
            PlayerPrefs.SetInt("SaveLevelP3D2", Global.LevelP3);
            PlayerPrefs.SetInt("SaveMaxEXPP3D2", Global.MaxEXPP3);
            PlayerPrefs.SetInt("SaveCurEXPP3D2", Global.CurEXPP3);
            PlayerPrefs.SetInt("SavePlusPointP3D2", Global.PlusPointP3);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP3D2", Global.PlusPointAttackLvP3);
            PlayerPrefs.SetInt("SavePlusPointHPLvP3D2", Global.PlusPointHPLvP3);
            PlayerPrefs.SetInt("SavePlusPointMPLvP3D2", Global.PlusPointMPLvP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP3D2", Global.PlusPointSpeedLvP3);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP3D2", Global.PlusPointAttackInfoP3);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP3D2", Global.PlusPointHPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP3D2", Global.PlusPointMPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP3D2", Global.PlusPointSpeedInfoP3);

            //Set Zen
            PlayerPrefs.SetInt("SaveZenD2", Global.Zen);

            //Set weapon
            PlayerPrefs.SetInt("SaveVayneStaff1D2", Global.VayneStaff1);
            PlayerPrefs.SetInt("SaveVayneStaff2D2", Global.VayneStaff2);
            PlayerPrefs.SetInt("SaveVayneStaff3D2", Global.VayneStaff3);
            PlayerPrefs.SetInt("SaveAliaShoes1D2", Global.AliaShoes1);
            PlayerPrefs.SetInt("SaveAliaShoes2D2", Global.AliaShoes2);
            PlayerPrefs.SetInt("SaveAliaShoes3D2", Global.AliaShoes3);
            PlayerPrefs.SetInt("SaveMariaCrystal1D2", Global.MariaCrystal1);
            PlayerPrefs.SetInt("SaveMariaCrystal2D2", Global.MariaCrystal2);
            PlayerPrefs.SetInt("SaveMariaCrystal3D2", Global.MariaCrystal3);
            PlayerPrefs.SetInt("SaveAlchemistArmor1D2", Global.AlchemistArmor1);
            PlayerPrefs.SetInt("SaveAlchemistArmor2D2", Global.AlchemistArmor2);
            PlayerPrefs.SetInt("SaveAlchemistArmor3D2", Global.AlchemistArmor3);
            PlayerPrefs.SetInt("SaveWarriorArmor1D2", Global.WarriorArmor1);
            PlayerPrefs.SetInt("SaveWarriorArmor2D2", Global.WarriorArmor2);
            PlayerPrefs.SetInt("SaveWarriorArmor3D2", Global.WarriorArmor3);

            //Set weapon status
            PlayerPrefs.SetInt("SaveVayneWeaponStatusD2", Global.VayneWeaponStatus);
            PlayerPrefs.SetInt("SaveVayneArmorStatusD2", Global.VayneArmorStatus);
            PlayerPrefs.SetInt("SaveAliaWeaponStatusD2", Global.AliaWeaponStatus);
            PlayerPrefs.SetInt("SaveAliaArmorStatusD2", Global.AliaArmorStatus);
            PlayerPrefs.SetInt("SaveMariaWeaponStatusD2", Global.MariaWeaponStatus);
            PlayerPrefs.SetInt("SaveMariaArmorStatusD2", Global.MariaArmorStatus);

            //Set weapon had bought
            PlayerPrefs.SetInt("SaveBought1D2", WeaponStoreController.Bought1);
            PlayerPrefs.SetInt("SaveBought2D2", WeaponStoreController.Bought2);
            PlayerPrefs.SetInt("SaveBought3D2", WeaponStoreController.Bought3);
            PlayerPrefs.SetInt("SaveBought4D2", WeaponStoreController.Bought4);
            PlayerPrefs.SetInt("SaveBought5D2", WeaponStoreController.Bought5);
            PlayerPrefs.SetInt("SaveBought6D2", WeaponStoreController.Bought6);
            PlayerPrefs.SetInt("SaveBought7D2", WeaponStoreController.Bought7);
            PlayerPrefs.SetInt("SaveBought8D2", WeaponStoreController.Bought8);
            PlayerPrefs.SetInt("SaveBought9D2", WeaponStoreController.Bought9);
            PlayerPrefs.SetInt("SaveBought10D2", WeaponStoreController.Bought10);
            PlayerPrefs.SetInt("SaveBought11D2", WeaponStoreController.Bought11);
            PlayerPrefs.SetInt("SaveBought12D2", WeaponStoreController.Bought12);
            PlayerPrefs.SetInt("SaveBought13D2", WeaponStoreController.Bought13);
            PlayerPrefs.SetInt("SaveBought14D2", WeaponStoreController.Bought14);
            PlayerPrefs.SetInt("SaveBought15D2", WeaponStoreController.Bought15);

            //Set item material
            PlayerPrefs.SetInt("SaveDriedLeavesD2", ContainerController.DriedLeaves);
            PlayerPrefs.SetInt("SavePureWaterD2", ContainerController.PureWater);
            PlayerPrefs.SetInt("SaveMorningDropD2", ContainerController.MorningDrop);
            PlayerPrefs.SetInt("SaveWheatD2", ContainerController.Wheat);
            PlayerPrefs.SetInt("SaveWoodD2", ContainerController.Wood);
            PlayerPrefs.SetInt("SaveStringD2", ContainerController.String);
            PlayerPrefs.SetInt("SaveIronD2", ContainerController.Iron);
            PlayerPrefs.SetInt("SaveManaGemD2", ContainerController.ManaGem);
            PlayerPrefs.SetInt("SaveScorpionVenomD2", ContainerController.ScorpionVenom);
            PlayerPrefs.SetInt("SaveInfernoSandD2", ContainerController.InfernoSand);
            PlayerPrefs.SetInt("SaveManaLiquidD2", ContainerController.ManaLiquid);
            PlayerPrefs.SetInt("SaveManaOreD2", ContainerController.ManaOre);
            PlayerPrefs.SetInt("SaveManaCrystalD2", ContainerController.ManaCrystal);
            PlayerPrefs.SetInt("SaveGuardianFeatherD2", ContainerController.GuardianFeather);
            PlayerPrefs.SetInt("SaveFireOreD2", ContainerController.FireOre);
            PlayerPrefs.SetInt("SaveGoldenFeatherD2", ContainerController.GoldenFeather);
            PlayerPrefs.SetInt("SaveRedManaCrystalD2", ContainerController.RedManaCrystal);
            PlayerPrefs.SetInt("SaveObsidianD2", ContainerController.Obsidian);
            PlayerPrefs.SetInt("SaveIceOreD2", ContainerController.IceOre);
            PlayerPrefs.SetInt("SaveIceLeatherD2", ContainerController.IceLeather);
            PlayerPrefs.SetInt("SaveBlueManaCrystalD2", ContainerController.BlueManaCrystal);
            PlayerPrefs.SetInt("SaveRedManaSlimeBallD2", ContainerController.RedManaSlimeBall);
            PlayerPrefs.SetInt("SaveBlueManaSlimeBallD2", ContainerController.BlueManaSlimeBall);
            PlayerPrefs.SetInt("SaveManaCoreFireZexelD2", ContainerController.ManaCoreFireZexel);
            PlayerPrefs.SetInt("SaveManaCoreIceZexelD2", ContainerController.ManaCoreIceZexel);
            PlayerPrefs.SetInt("SaveRockD2", ContainerController.Rock);
            PlayerPrefs.SetInt("SaveNatureGrassD2", ContainerController.NatureGrass);
            PlayerPrefs.SetInt("SaveManaDustD2", ContainerController.ManaDust);
            PlayerPrefs.SetInt("SaveManaEagleFeatherD2", ContainerController.ManaEagleFeather);
            PlayerPrefs.SetInt("SaveIceCrystalD2", ContainerController.IceCrystal);

            //Set item
            PlayerPrefs.SetInt("SaveHealPotionD2", ContainerController.HealPotion);
            PlayerPrefs.SetInt("SaveManaPotionD2", ContainerController.ManaPotion);
            PlayerPrefs.SetInt("SaveElixirPotionD2", ContainerController.ElixirPotion);
            PlayerPrefs.SetInt("SaveBomD2", ContainerController.Bom);
            PlayerPrefs.SetInt("SavePorridgeD2", ContainerController.Porridge);
            PlayerPrefs.SetInt("SaveManaClothD2", ContainerController.ManaCloth);
            PlayerPrefs.SetInt("SaveManaShieldD2", ContainerController.ManaShield);
            PlayerPrefs.SetInt("SaveVenomKillerD2", ContainerController.VenomKiller);
            PlayerPrefs.SetInt("SaveManaNecklaceD2", ContainerController.ManaNecklace);
            PlayerPrefs.SetInt("SaveManaGeneratorD2", ContainerController.ManaGenerator);
            PlayerPrefs.SetInt("SaveBaxiataD2", ContainerController.Baxiata);
            PlayerPrefs.SetInt("SaveBaxiataGemD2", ContainerController.BaxiataGem);
            PlayerPrefs.SetInt("SavePhotonriaD2", ContainerController.Photonria);
            PlayerPrefs.SetInt("SavePhotonriaGemD2", ContainerController.PhotonriaGem);
            PlayerPrefs.SetInt("SaveManaLiquidCatalystD2", ContainerController.ManaLiquidCatalyst);
            PlayerPrefs.SetInt("SaveRedLiquidCatalystD2", ContainerController.RedLiquidCatalyst);
            PlayerPrefs.SetInt("SaveBlueLiquidCatalystD2", ContainerController.BlueLiquidCatalyst);
            PlayerPrefs.SetInt("SaveManaCoreFireVayneD2", ContainerController.ManaCoreFireVayne);
            PlayerPrefs.SetInt("SaveManaCoreIceVayneD2", ContainerController.ManaCoreIceVayne);
            PlayerPrefs.SetInt("SavePureObsidianD2", ContainerController.PureObsidian);
            PlayerPrefs.SetInt("SaveFireManaGeneratorD2", ContainerController.FireManaGenerator);
            PlayerPrefs.SetInt("SaveIceManaGeneratorD2", ContainerController.IceManaGenerator);
            PlayerPrefs.SetInt("SavePowderOfLifeD2", ContainerController.PowderOfLife);
            PlayerPrefs.SetInt("SaveHoliHPD2", ContainerController.HoliHP);
            PlayerPrefs.SetInt("SaveHoliMPD2", ContainerController.HoliMP);
            PlayerPrefs.SetInt("SaveUltraBomD2", ContainerController.UltraBom);
            PlayerPrefs.SetInt("SaveReincarnationLifeD2", ContainerController.ReincarnationLife);
            PlayerPrefs.SetInt("SaveFireOfPeaceD2", ContainerController.FireOfPeace);
            PlayerPrefs.SetInt("SaveOmnipotentBoundaryD2", ContainerController.OmnipotentBoundary);

            //Set ManaSynthesize
            PlayerPrefs.SetInt("SaveManaSynthesizeD2", SynthesizeSystem.ManaSynthesize);
            PlayerPrefs.SetInt("SaveManaFireSynthesizeD2", SynthesizeSystem.ManaFireSynthesize);
            PlayerPrefs.SetInt("SaveManaIceSynthesizeD2", SynthesizeSystem.ManaIceSynthesize);

            PlayerPrefs.SetInt("SaveGameD2", 1);

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }
        else if (SaveOverrideIndex == 3)
        {
            //Set date
            PlayerPrefs.SetInt("SaveGlobalDayNightD3", DateController.GlobalDayNight);
            PlayerPrefs.SetFloat("SaveGlobalTimeD3", DateController.GlobalTime);
            PlayerPrefs.SetInt("SaveGlobalUpHourD3", DateController.GlobalUpHour);
            PlayerPrefs.SetInt("SaveGlobalPHourD3", DateController.GlobalPHour);
            PlayerPrefs.SetInt("SaveGlobalDownHourD3", DateController.GlobalDownHour);

            //Set cut
            PlayerPrefs.SetInt("Savecus1D3", CutscenesController.cus1);
            PlayerPrefs.SetInt("Savecus2D3", CutscenesController.cus2);
            PlayerPrefs.SetInt("Savecus3D3", CutscenesController.cus3);
            PlayerPrefs.SetInt("Savecus4D3", CutscenesController.cus4);
            PlayerPrefs.SetInt("Savecus5D3", CutscenesController.cus5);
            PlayerPrefs.SetInt("Savecus6D3", CutscenesController.cus6);
            PlayerPrefs.SetInt("Savecus7D3", CutscenesController.cus7);
            PlayerPrefs.SetInt("Savecus8D3", CutscenesController.cus8);
            PlayerPrefs.SetInt("Savecus9D3", CutscenesController.cus9);
            PlayerPrefs.SetInt("Savecus10D3", CutscenesController.cus10);
            PlayerPrefs.SetInt("Savecus11D3", CutscenesController.cus11);
            PlayerPrefs.SetInt("Savecus12D3", CutscenesController.cus12);
            PlayerPrefs.SetInt("Savecus13D3", CutscenesController.cus13);
            PlayerPrefs.SetInt("Savecus14D3", CutscenesController.cus14);
            PlayerPrefs.SetInt("Savecus15D3", CutscenesController.cus15);
            PlayerPrefs.SetInt("Savecus16D3", CutscenesController.cus16);
            PlayerPrefs.SetInt("Savecus17D3", CutscenesController.cus17);
            PlayerPrefs.SetInt("Savecus18D3", CutscenesController.cus18);
            PlayerPrefs.SetInt("Savecus19D3", CutscenesController.cus19);
            PlayerPrefs.SetInt("Savecus20D3", CutscenesController.cus20);
            PlayerPrefs.SetInt("Savecus21D3", CutscenesController.cus21);
            PlayerPrefs.SetInt("Savecus22D3", CutscenesController.cus22);
            PlayerPrefs.SetInt("Savecus23D3", CutscenesController.cus23);
            PlayerPrefs.SetInt("Savecus24D3", CutscenesController.cus24);
            PlayerPrefs.SetInt("Savecus25D3", CutscenesController.cus25);
            PlayerPrefs.SetInt("Savecus26D3", CutscenesController.cus26);
            PlayerPrefs.SetInt("Savecus27D3", CutscenesController.cus27);
            PlayerPrefs.SetInt("Savecus28D3", CutscenesController.cus28);
            PlayerPrefs.SetInt("Savecus29D3", CutscenesController.cus29);
            PlayerPrefs.SetInt("Savecus30D3", CutscenesController.cus30);
            PlayerPrefs.SetInt("Savecus31D3", CutscenesController.cus31);
            PlayerPrefs.SetInt("Savecus32D3", CutscenesController.cus32);
            PlayerPrefs.SetInt("Savecus33D3", CutscenesController.cus33);
            PlayerPrefs.SetInt("Savecus34D3", CutscenesController.cus34);
            PlayerPrefs.SetInt("Savecus35D3", CutscenesController.cus35);
            PlayerPrefs.SetInt("Savecus36D3", CutscenesController.cus36);
            PlayerPrefs.SetInt("Savecus37D3", CutscenesController.cus37);
            PlayerPrefs.SetInt("Savecus38D3", CutscenesController.cus38);
            PlayerPrefs.SetInt("Savecus39D3", CutscenesController.cus39);
            PlayerPrefs.SetInt("Savecus40D3", CutscenesController.cus40);
            PlayerPrefs.SetInt("Savecus41D3", CutscenesController.cus41);
            PlayerPrefs.SetInt("Savecus42D3", CutscenesController.cus42);
            PlayerPrefs.SetInt("Savecus43D3", CutscenesController.cus43);
            PlayerPrefs.SetInt("Savecus44D3", CutscenesController.cus44);
            PlayerPrefs.SetInt("Savecus45D3", CutscenesController.cus45);
            PlayerPrefs.SetInt("Savecus46D3", CutscenesController.cus46);
            PlayerPrefs.SetInt("Savecus47D3", CutscenesController.cus47);
            PlayerPrefs.SetInt("Savecus48D3", CutscenesController.cus48);
            PlayerPrefs.SetInt("Savecus49D3", CutscenesController.cus49);
            PlayerPrefs.SetInt("Savecus50D3", CutscenesController.cus50);
            PlayerPrefs.SetInt("Savecus51D3", CutscenesController.cus51);
            PlayerPrefs.SetInt("Savecus52D3", CutscenesController.cus52);
            PlayerPrefs.SetInt("Savecus53D3", CutscenesController.cus53);
            PlayerPrefs.SetInt("Savecus54D3", CutscenesController.cus54);
            PlayerPrefs.SetInt("Savecus55D3", CutscenesController.cus55);
            PlayerPrefs.SetInt("Savecus56D3", CutscenesController.cus56);
            PlayerPrefs.SetInt("Savecus57D3", CutscenesController.cus57);
            PlayerPrefs.SetInt("Savecus58D3", CutscenesController.cus58);
            PlayerPrefs.SetInt("Savecus59D3", CutscenesController.cus59);
            PlayerPrefs.SetInt("Savecus60D3", CutscenesController.cus60);
            PlayerPrefs.SetInt("Savecus61D3", CutscenesController.cus61);
            PlayerPrefs.SetInt("Savecus62D3", CutscenesController.cus62);
            PlayerPrefs.SetInt("Savecus63D3", CutscenesController.cus63);
            PlayerPrefs.SetInt("Savecus64D3", CutscenesController.cus64);
            PlayerPrefs.SetInt("Savecus65D3", CutscenesController.cus65);
            PlayerPrefs.SetInt("Savecus66D3", CutscenesController.cus66);
            PlayerPrefs.SetInt("Savecus67D3", CutscenesController.cus67);
            PlayerPrefs.SetInt("Savecus68D3", CutscenesController.cus68);
            PlayerPrefs.SetInt("Savecus69D3", CutscenesController.cus69);
            PlayerPrefs.SetInt("Savecus70D3", CutscenesController.cus70);
            PlayerPrefs.SetInt("Savecus71D3", CutscenesController.cus71);
            PlayerPrefs.SetInt("Savecus72D3", CutscenesController.cus72);
            PlayerPrefs.SetInt("Savecus73D3", CutscenesController.cus73);
            PlayerPrefs.SetInt("Savecus74D3", CutscenesController.cus74);
            PlayerPrefs.SetInt("Savecus75D3", CutscenesController.cus75);
            PlayerPrefs.SetInt("Savecus76D3", CutscenesController.cus76);
            PlayerPrefs.SetInt("Savecus77D3", CutscenesController.cus77);
            PlayerPrefs.SetInt("Savecus78D3", CutscenesController.cus78);
            PlayerPrefs.SetInt("Savecus79D3", CutscenesController.cus79);
            PlayerPrefs.SetInt("Savecus80D3", CutscenesController.cus80);
            PlayerPrefs.SetInt("Savecus81D3", CutscenesController.cus81);
            PlayerPrefs.SetInt("Savecus82D3", CutscenesController.cus82);
            PlayerPrefs.SetInt("Savecus83D3", CutscenesController.cus83);
            PlayerPrefs.SetInt("Savecus84D3", CutscenesController.cus84);
            PlayerPrefs.SetInt("Savecus85D3", CutscenesController.cus85);
            PlayerPrefs.SetInt("Savecus86D3", CutscenesController.cus86);
            PlayerPrefs.SetInt("Savecus87D3", CutscenesController.cus87);
            PlayerPrefs.SetInt("Savecus88D3", CutscenesController.cus88);
            PlayerPrefs.SetInt("Savecus89D3", CutscenesController.cus89);
            PlayerPrefs.SetInt("Savecus90D3", CutscenesController.cus90);
            PlayerPrefs.SetInt("Savecus91D3", CutscenesController.cus91);
            PlayerPrefs.SetInt("Savecus92D3", CutscenesController.cus92);
            PlayerPrefs.SetInt("Savecus93D3", CutscenesController.cus93);
            PlayerPrefs.SetInt("Savecus94D3", CutscenesController.cus94);
            PlayerPrefs.SetInt("Savecus95D3", CutscenesController.cus95);
            PlayerPrefs.SetInt("Savecus96D3", CutscenesController.cus96);
            PlayerPrefs.SetInt("Savecus97D3", CutscenesController.cus97);
            PlayerPrefs.SetInt("Savecus98D3", CutscenesController.cus98);
            PlayerPrefs.SetInt("Savecus99D3", CutscenesController.cus99);
            PlayerPrefs.SetInt("Savecus100D3", CutscenesController.cus100);
            PlayerPrefs.SetInt("Savecus101D3", CutscenesController.cus101);
            PlayerPrefs.SetInt("Savecus102D3", CutscenesController.cus102);
            PlayerPrefs.SetInt("Savecus103D3", CutscenesController.cus103);
            PlayerPrefs.SetInt("Savecus104D3", CutscenesController.cus104);
            PlayerPrefs.SetInt("Savecus105D3", CutscenesController.cus105);
            PlayerPrefs.SetInt("Savecus106D3", CutscenesController.cus106);
            PlayerPrefs.SetInt("Savecus107D3", CutscenesController.cus107);
            PlayerPrefs.SetInt("Savecus108D3", CutscenesController.cus108);
            PlayerPrefs.SetInt("Savecus109D3", CutscenesController.cus109);
            PlayerPrefs.SetInt("Savecus110D3", CutscenesController.cus110);
            PlayerPrefs.SetInt("Savecus111D3", CutscenesController.cus111);
            PlayerPrefs.SetInt("Savecus112D3", CutscenesController.cus112);
            PlayerPrefs.SetInt("Savecus113D3", CutscenesController.cus113);
            PlayerPrefs.SetInt("Savecus114D3", CutscenesController.cus114);
            PlayerPrefs.SetInt("Savecus115D3", CutscenesController.cus115);
            PlayerPrefs.SetInt("Savecus116D3", CutscenesController.cus116);
            PlayerPrefs.SetInt("Savecus117D3", CutscenesController.cus117);
            PlayerPrefs.SetInt("Savecus118D3", CutscenesController.cus118);
            PlayerPrefs.SetInt("Savecus119D3", CutscenesController.cus119);
            PlayerPrefs.SetInt("Savecus120D3", CutscenesController.cus120);

            //Set quest
            PlayerPrefs.SetInt("SaveKGQD3", GlobalQuest.KillGoblinQuest);
            PlayerPrefs.SetInt("SaveHVStop1D3", GlobalQuest.HelpVillagerStop1);
            PlayerPrefs.SetInt("SaveHVStop2D3", GlobalQuest.HelpVillagerStop2);
            PlayerPrefs.SetInt("SaveHVStop3D3", GlobalQuest.HelpVillagerStop3);
            PlayerPrefs.SetInt("SaveHVD3", GlobalQuest.HelpVillagerDone);
            PlayerPrefs.SetInt("SavePorridgeSynD3", CutscenesTrigger.PorridgeSyn);
            PlayerPrefs.SetInt("SaveBomSynD3", CutscenesTrigger.BomSyn);
            PlayerPrefs.SetInt("SaveGolemnKillD3", CutscenesTrigger.GolemnKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillD3", CutscenesTrigger.InfernoScorpionKill);
            PlayerPrefs.SetInt("SaveInfernoScorpionKillP2D3", CutscenesTrigger.InfernoScorpionKillP2);
            PlayerPrefs.SetInt("SaveIceFangKillD3", CutscenesTrigger.IceFangKill);
            PlayerPrefs.SetInt("SaveGoblinKillP2D3", CutscenesTrigger.GoblinKillP2);
            PlayerPrefs.SetInt("SaveGolemnKillP2D3", CutscenesTrigger.GolemnKillP2);

            //Set Vayne
            PlayerPrefs.SetInt("SaveMaxHPP1D3", Global.MaxHPP1);
            PlayerPrefs.SetInt("SaveHPP1D3", Global.CurHPP1);
            PlayerPrefs.SetInt("SaveMaxMPP1D3", Global.MaxMPP1);
            PlayerPrefs.SetInt("SaveMPP1D3", Global.CurMPP1);
            PlayerPrefs.SetInt("SaveDamageP1D3", Global.DamageP1);
            PlayerPrefs.SetInt("SaveSpeedP1D3", Global.SpeedP1);
            PlayerPrefs.SetInt("SaveLevelP1D3", Global.LevelP1);
            PlayerPrefs.SetInt("SaveMaxEXPP1D3", Global.MaxEXPP1);
            PlayerPrefs.SetInt("SaveCurEXPP1D3", Global.CurEXPP1);
            PlayerPrefs.SetInt("SavePlusPointP1D3", Global.PlusPointP1);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP1D3", Global.PlusPointAttackLvP1);
            PlayerPrefs.SetInt("SavePlusPointHPLvP1D3", Global.PlusPointHPLvP1);
            PlayerPrefs.SetInt("SavePlusPointMPLvP1D3", Global.PlusPointMPLvP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP1D3", Global.PlusPointSpeedLvP1);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP1D3", Global.PlusPointAttackInfoP1);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP1D3", Global.PlusPointHPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP1D3", Global.PlusPointMPInfoP1);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP1D3", Global.PlusPointSpeedInfoP1);

            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SaveMaxHPP2D3", Global.MaxHPP2);
            PlayerPrefs.SetInt("SaveHPP2D3", Global.CurHPP2);
            PlayerPrefs.SetInt("SaveMaxMPP2D3", Global.MaxMPP2);
            PlayerPrefs.SetInt("SaveMPP2D3", Global.CurMPP2);
            PlayerPrefs.SetInt("SaveDamageP2D3", Global.DamageP2);
            PlayerPrefs.SetInt("SaveSpeedP2D3", Global.SpeedP2);
            PlayerPrefs.SetInt("SaveLevelP2D3", Global.LevelP2);
            PlayerPrefs.SetInt("SaveMaxEXPP2D3", Global.MaxEXPP2);
            PlayerPrefs.SetInt("SaveCurEXPP2D3", Global.CurEXPP2);
            PlayerPrefs.SetInt("SavePlusPointP2D3", Global.PlusPointP2);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP2D3", Global.PlusPointAttackLvP2);
            PlayerPrefs.SetInt("SavePlusPointHPLvP2D3", Global.PlusPointHPLvP2);
            PlayerPrefs.SetInt("SavePlusPointMPLvP2D3", Global.PlusPointMPLvP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP2D3", Global.PlusPointSpeedLvP2);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP2D3", Global.PlusPointAttackInfoP2);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP2D3", Global.PlusPointHPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP2D3", Global.PlusPointMPInfoP2);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP2D3", Global.PlusPointSpeedInfoP2);

            //Set player 3 (Maria)
            PlayerPrefs.SetInt("SaveMaxHPP3D3", Global.MaxHPP3);
            PlayerPrefs.SetInt("SaveHPP3D3", Global.CurHPP3);
            PlayerPrefs.SetInt("SaveMaxMPP3D3", Global.MaxMPP3);
            PlayerPrefs.SetInt("SaveMPP3D3", Global.CurMPP3);
            PlayerPrefs.SetInt("SaveDamageP3D3", Global.DamageP3);
            PlayerPrefs.SetInt("SaveSpeedP3D3", Global.SpeedP3);
            PlayerPrefs.SetInt("SaveLevelP3D3", Global.LevelP3);
            PlayerPrefs.SetInt("SaveMaxEXPP3D3", Global.MaxEXPP3);
            PlayerPrefs.SetInt("SaveCurEXPP3D3", Global.CurEXPP3);
            PlayerPrefs.SetInt("SavePlusPointP3D3", Global.PlusPointP3);
            PlayerPrefs.SetInt("SavePlusPointAttackLvP3D3", Global.PlusPointAttackLvP3);
            PlayerPrefs.SetInt("SavePlusPointHPLvP3D3", Global.PlusPointHPLvP3);
            PlayerPrefs.SetInt("SavePlusPointMPLvP3D3", Global.PlusPointMPLvP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedLvP3D3", Global.PlusPointSpeedLvP3);
            PlayerPrefs.SetInt("SavePlusPointAttackInfoP3D3", Global.PlusPointAttackInfoP3);
            PlayerPrefs.SetInt("SavePlusPointHPInfoP3D3", Global.PlusPointHPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointMPInfoP3D3", Global.PlusPointMPInfoP3);
            PlayerPrefs.SetInt("SavePlusPointSpeedInfoP3D3", Global.PlusPointSpeedInfoP3);

            //Set Zen
            PlayerPrefs.SetInt("SaveZenD3", Global.Zen);

            //Set weapon
            PlayerPrefs.SetInt("SaveVayneStaff1D3", Global.VayneStaff1);
            PlayerPrefs.SetInt("SaveVayneStaff2D3", Global.VayneStaff2);
            PlayerPrefs.SetInt("SaveVayneStaff3D3", Global.VayneStaff3);
            PlayerPrefs.SetInt("SaveAliaShoes1D3", Global.AliaShoes1);
            PlayerPrefs.SetInt("SaveAliaShoes2D3", Global.AliaShoes2);
            PlayerPrefs.SetInt("SaveAliaShoes3D3", Global.AliaShoes3);
            PlayerPrefs.SetInt("SaveMariaCrystal1D3", Global.MariaCrystal1);
            PlayerPrefs.SetInt("SaveMariaCrystal2D3", Global.MariaCrystal2);
            PlayerPrefs.SetInt("SaveMariaCrystal3D3", Global.MariaCrystal3);
            PlayerPrefs.SetInt("SaveAlchemistArmor1D3", Global.AlchemistArmor1);
            PlayerPrefs.SetInt("SaveAlchemistArmor2D3", Global.AlchemistArmor2);
            PlayerPrefs.SetInt("SaveAlchemistArmor3D3", Global.AlchemistArmor3);
            PlayerPrefs.SetInt("SaveWarriorArmor1D3", Global.WarriorArmor1);
            PlayerPrefs.SetInt("SaveWarriorArmor2D3", Global.WarriorArmor2);
            PlayerPrefs.SetInt("SaveWarriorArmor3D3", Global.WarriorArmor3);

            //Set weapon status
            PlayerPrefs.SetInt("SaveVayneWeaponStatusD3", Global.VayneWeaponStatus);
            PlayerPrefs.SetInt("SaveVayneArmorStatusD3", Global.VayneArmorStatus);
            PlayerPrefs.SetInt("SaveAliaWeaponStatusD3", Global.AliaWeaponStatus);
            PlayerPrefs.SetInt("SaveAliaArmorStatusD3", Global.AliaArmorStatus);
            PlayerPrefs.SetInt("SaveMariaWeaponStatusD3", Global.MariaWeaponStatus);
            PlayerPrefs.SetInt("SaveMariaArmorStatusD3", Global.MariaArmorStatus);

            //Set weapon had bought
            PlayerPrefs.SetInt("SaveBought1D3", WeaponStoreController.Bought1);
            PlayerPrefs.SetInt("SaveBought2D3", WeaponStoreController.Bought2);
            PlayerPrefs.SetInt("SaveBought3D3", WeaponStoreController.Bought3);
            PlayerPrefs.SetInt("SaveBought4D3", WeaponStoreController.Bought4);
            PlayerPrefs.SetInt("SaveBought5D3", WeaponStoreController.Bought5);
            PlayerPrefs.SetInt("SaveBought6D3", WeaponStoreController.Bought6);
            PlayerPrefs.SetInt("SaveBought7D3", WeaponStoreController.Bought7);
            PlayerPrefs.SetInt("SaveBought8D3", WeaponStoreController.Bought8);
            PlayerPrefs.SetInt("SaveBought9D3", WeaponStoreController.Bought9);
            PlayerPrefs.SetInt("SaveBought10D3", WeaponStoreController.Bought10);
            PlayerPrefs.SetInt("SaveBought11D3", WeaponStoreController.Bought11);
            PlayerPrefs.SetInt("SaveBought12D3", WeaponStoreController.Bought12);
            PlayerPrefs.SetInt("SaveBought13D3", WeaponStoreController.Bought13);
            PlayerPrefs.SetInt("SaveBought14D3", WeaponStoreController.Bought14);
            PlayerPrefs.SetInt("SaveBought15D3", WeaponStoreController.Bought15);

            //Set item material
            PlayerPrefs.SetInt("SaveDriedLeavesD3", ContainerController.DriedLeaves);
            PlayerPrefs.SetInt("SavePureWaterD3", ContainerController.PureWater);
            PlayerPrefs.SetInt("SaveMorningDropD3", ContainerController.MorningDrop);
            PlayerPrefs.SetInt("SaveWheatD3", ContainerController.Wheat);
            PlayerPrefs.SetInt("SaveWoodD3", ContainerController.Wood);
            PlayerPrefs.SetInt("SaveStringD3", ContainerController.String);
            PlayerPrefs.SetInt("SaveIronD3", ContainerController.Iron);
            PlayerPrefs.SetInt("SaveManaGemD3", ContainerController.ManaGem);
            PlayerPrefs.SetInt("SaveScorpionVenomD3", ContainerController.ScorpionVenom);
            PlayerPrefs.SetInt("SaveInfernoSandD3", ContainerController.InfernoSand);
            PlayerPrefs.SetInt("SaveManaLiquidD3", ContainerController.ManaLiquid);
            PlayerPrefs.SetInt("SaveManaOreD3", ContainerController.ManaOre);
            PlayerPrefs.SetInt("SaveManaCrystalD3", ContainerController.ManaCrystal);
            PlayerPrefs.SetInt("SaveGuardianFeatherD3", ContainerController.GuardianFeather);
            PlayerPrefs.SetInt("SaveFireOreD3", ContainerController.FireOre);
            PlayerPrefs.SetInt("SaveGoldenFeatherD3", ContainerController.GoldenFeather);
            PlayerPrefs.SetInt("SaveRedManaCrystalD3", ContainerController.RedManaCrystal);
            PlayerPrefs.SetInt("SaveObsidianD3", ContainerController.Obsidian);
            PlayerPrefs.SetInt("SaveIceOreD3", ContainerController.IceOre);
            PlayerPrefs.SetInt("SaveIceLeatherD3", ContainerController.IceLeather);
            PlayerPrefs.SetInt("SaveBlueManaCrystalD3", ContainerController.BlueManaCrystal);
            PlayerPrefs.SetInt("SaveRedManaSlimeBallD3", ContainerController.RedManaSlimeBall);
            PlayerPrefs.SetInt("SaveBlueManaSlimeBallD3", ContainerController.BlueManaSlimeBall);
            PlayerPrefs.SetInt("SaveManaCoreFireZexelD3", ContainerController.ManaCoreFireZexel);
            PlayerPrefs.SetInt("SaveManaCoreIceZexelD3", ContainerController.ManaCoreIceZexel);
            PlayerPrefs.SetInt("SaveRockD3", ContainerController.Rock);
            PlayerPrefs.SetInt("SaveNatureGrassD3", ContainerController.NatureGrass);
            PlayerPrefs.SetInt("SaveManaDustD3", ContainerController.ManaDust);
            PlayerPrefs.SetInt("SaveManaEagleFeatherD3", ContainerController.ManaEagleFeather);
            PlayerPrefs.SetInt("SaveIceCrystalD3", ContainerController.IceCrystal);

            //Set item
            PlayerPrefs.SetInt("SaveHealPotionD3", ContainerController.HealPotion);
            PlayerPrefs.SetInt("SaveManaPotionD3", ContainerController.ManaPotion);
            PlayerPrefs.SetInt("SaveElixirPotionD3", ContainerController.ElixirPotion);
            PlayerPrefs.SetInt("SaveBomD3", ContainerController.Bom);
            PlayerPrefs.SetInt("SavePorridgeD3", ContainerController.Porridge);
            PlayerPrefs.SetInt("SaveManaClothD3", ContainerController.ManaCloth);
            PlayerPrefs.SetInt("SaveManaShieldD3", ContainerController.ManaShield);
            PlayerPrefs.SetInt("SaveVenomKillerD3", ContainerController.VenomKiller);
            PlayerPrefs.SetInt("SaveManaNecklaceD3", ContainerController.ManaNecklace);
            PlayerPrefs.SetInt("SaveManaGeneratorD3", ContainerController.ManaGenerator);
            PlayerPrefs.SetInt("SaveBaxiataD3", ContainerController.Baxiata);
            PlayerPrefs.SetInt("SaveBaxiataGemD3", ContainerController.BaxiataGem);
            PlayerPrefs.SetInt("SavePhotonriaD3", ContainerController.Photonria);
            PlayerPrefs.SetInt("SavePhotonriaGemD3", ContainerController.PhotonriaGem);
            PlayerPrefs.SetInt("SaveManaLiquidCatalystD3", ContainerController.ManaLiquidCatalyst);
            PlayerPrefs.SetInt("SaveRedLiquidCatalystD3", ContainerController.RedLiquidCatalyst);
            PlayerPrefs.SetInt("SaveBlueLiquidCatalystD3", ContainerController.BlueLiquidCatalyst);
            PlayerPrefs.SetInt("SaveManaCoreFireVayneD3", ContainerController.ManaCoreFireVayne);
            PlayerPrefs.SetInt("SaveManaCoreIceVayneD3", ContainerController.ManaCoreIceVayne);
            PlayerPrefs.SetInt("SavePureObsidianD3", ContainerController.PureObsidian);
            PlayerPrefs.SetInt("SaveFireManaGeneratorD3", ContainerController.FireManaGenerator);
            PlayerPrefs.SetInt("SaveIceManaGeneratorD3", ContainerController.IceManaGenerator);
            PlayerPrefs.SetInt("SavePowderOfLifeD3", ContainerController.PowderOfLife);
            PlayerPrefs.SetInt("SaveHoliHPD3", ContainerController.HoliHP);
            PlayerPrefs.SetInt("SaveHoliMPD3", ContainerController.HoliMP);
            PlayerPrefs.SetInt("SaveUltraBomD3", ContainerController.UltraBom);
            PlayerPrefs.SetInt("SaveReincarnationLifeD3", ContainerController.ReincarnationLife);
            PlayerPrefs.SetInt("SaveFireOfPeaceD3", ContainerController.FireOfPeace);
            PlayerPrefs.SetInt("SaveOmnipotentBoundaryD3", ContainerController.OmnipotentBoundary);

            //Set ManaSynthesize
            PlayerPrefs.SetInt("SaveManaSynthesizeD3", SynthesizeSystem.ManaSynthesize);
            PlayerPrefs.SetInt("SaveManaFireSynthesizeD3", SynthesizeSystem.ManaFireSynthesize);
            PlayerPrefs.SetInt("SaveManaIceSynthesizeD3", SynthesizeSystem.ManaIceSynthesize);

            PlayerPrefs.SetInt("SaveGameD3", 1);

            show4.SetActive(true);
            show3.text = "Data Save!";
            Invoke("delay2", 2f);
        }

        AskSaveOverrideGamePanel.SetActive(false);
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
