using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject LoadGamePanel;
    public Text showdata1;
    public Text showdata2;
    public Text showdata3;
    void Start()
    {
        
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
        CutscenesController.cus12 = 1;
        CutscenesController.cus50 = 0;
        CutscenesController.cus51 = 0;

        //Set quest
        GlobalQuest.KillGoblinQuest = 0;
        GlobalQuest.HelpVillagerStop1 = 0;
        GlobalQuest.HelpVillagerStop2 = 0;
        GlobalQuest.HelpVillagerStop3 = 0;
        GlobalQuest.HelpVillagerDone = 0;

        //Set point
        PlayerPrefs.SetFloat("x", 2);
        PlayerPrefs.SetFloat("y", 1);
        PlayerPrefs.SetFloat("z", 0);

        //Set Vayne
        Global.CurHPP1 = 100;
        Global.MaxHPP1 = 100;
        Global.CurMPP1 = 50;
        Global.MaxMPP1 = 50;
        Global.DamageP1 = 100;
        Global.SpeedP1 = 20;
        Global.LevelP1 = 1;
        Global.MaxEXPP1 = 40;
        Global.CurEXPP1 = 0;

        Global.PlusPointP1 = 1;

        /*Global.CurHPP1 = 1000;
        Global.MaxHPP1 = 1000;
        Global.CurMPP1 = 500;
        Global.MaxMPP1 = 500;
        Global.DamageP1 = 10;*/

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

        /*Global.CurHPP2 = 6000;
        Global.MaxHPP2 = 6000;
        Global.CurMPP2 = 320;
        Global.MaxMPP2 = 320;
        Global.DamageP2 = 100;*/

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

        /*Global.CurHPP3 = 2350;
        Global.MaxHPP3 = 2350;
        Global.CurMPP3 = 850;
        Global.MaxMPP3 = 850;
        Global.DamageP3 = 60;
        Global.SpeedP3 = 15;*/

        //Set Zen
        Global.Zen = 0;

        //Set item material
        ContainerController.MorningDrop = 0;
        ContainerController.DriedLeaves = 0;
        ContainerController.PureWater = 0;
        ContainerController.ManaGem = 0;
        ContainerController.HealPotion = 10;
        ContainerController.ManaPotion = 10;
        ContainerController.ElixirPotion = 10;
        ContainerController.Iron = 0;
        ContainerController.Bom = 10;
        ContainerController.ReincarnationLife = 10;

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
        SynthesizeSystem.ManaFireSynthesize = 0;
        SynthesizeSystem.ManaIceSynthesize = 0;

        //SceneManager.LoadScene("Cutscenes");
        //SceneManager.LoadScene("Wishing forest");
        //SceneManager.LoadScene("Mana gate");
        //SceneManager.LoadScene("BSManaGuardian 1");
        //SceneManager.LoadScene("BSGolemn 1");
        //SceneManager.LoadScene("BSIceFang 1");
        //SceneManager.LoadScene("BSInfernoBeast 1");
        //SceneManager.LoadScene("BSBlueManaSlime 1");
        //SceneManager.LoadScene("BSManaDragon 1");
        SceneManager.LoadScene("BSManaEagle 1");
    }
    public void PressLoadGame()
    {
        LoadGamePanel.SetActive(true);
    }
    public void PressLoadGameData1()
    {
        if (PlayerPrefs.GetInt("SaveGameD1") == 1)
        {
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
    public void PressExit()
    {
        Application.Quit();
    }
}
