using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGameSystem : MonoBehaviour
{
    public GameObject SaveGamePanel;
    public Text show3;
    public GameObject show4;
    public Text showdata1;
    public Text showdata2;
    public Text showdata3;
    // Start is called before the first frame update
    void Start()
    {
        
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

        //Set quest
        PlayerPrefs.SetInt("SaveKGQD1", GlobalQuest.KillGoblinQuest);
        PlayerPrefs.SetInt("SaveHVStop1D1", GlobalQuest.HelpVillagerStop1);
        PlayerPrefs.SetInt("SaveHVStop2D1", GlobalQuest.HelpVillagerStop2);
        PlayerPrefs.SetInt("SaveHVStop3D1", GlobalQuest.HelpVillagerStop3);
        PlayerPrefs.SetInt("SaveHVD1", GlobalQuest.HelpVillagerDone);

        //Set Vayne
        PlayerPrefs.SetInt("SaveMaxHPP1D1", Global.MaxHPP1);
        PlayerPrefs.SetInt("SaveHPP1D1", Global.CurHPP1);
        PlayerPrefs.SetInt("SaveMaxMPP1D1", Global.MaxMPP1);
        PlayerPrefs.SetInt("SaveMPP1D1", Global.CurMPP1);
        PlayerPrefs.SetInt("SaveDamageP1D1", Global.DamageP1);
        PlayerPrefs.SetInt("SaveSpeedP1D1", Global.SpeedP1);
        PlayerPrefs.SetInt("SaveLevelP1D1", Global.LevelP1);
        PlayerPrefs.SetInt("SaveMaxEXPP1D1", Global.MaxEXPP1);
        PlayerPrefs.SetInt("SaveCurEXPP1D1", Global.CurEXPP1);
        PlayerPrefs.SetInt("SaveZenD1", Global.Zen);
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

        //Set item material
        PlayerPrefs.SetInt("SaveMDD1", ContainerController.MorningDrop);
        PlayerPrefs.SetInt("SaveDLD1", ContainerController.DriedLeaves);
        PlayerPrefs.SetInt("SavePWD1", ContainerController.PureWater);
        PlayerPrefs.SetInt("SaveMGD1", ContainerController.ManaGem);
        PlayerPrefs.SetInt("SaveHPD1", ContainerController.HealPotion);
        PlayerPrefs.SetInt("SaveMPD1", ContainerController.ManaPotion);
        PlayerPrefs.SetInt("SaveEPD1", ContainerController.ElixirPotion);
        PlayerPrefs.SetInt("SaveID1", ContainerController.Iron);
        PlayerPrefs.SetInt("SaveBD1", ContainerController.Bom);

        PlayerPrefs.SetInt("SaveGameD1", 1);

        show4.SetActive(true);
        show3.text = "Data Save!";
        Invoke("delay2", 2f);
    }
    public void PressSaveGameData2()
    {
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

        //Set quest
        PlayerPrefs.SetInt("SaveKGQD2", GlobalQuest.KillGoblinQuest);
        PlayerPrefs.SetInt("SaveHVStop1D2", GlobalQuest.HelpVillagerStop1);
        PlayerPrefs.SetInt("SaveHVStop2D2", GlobalQuest.HelpVillagerStop2);
        PlayerPrefs.SetInt("SaveHVStop3D2", GlobalQuest.HelpVillagerStop3);
        PlayerPrefs.SetInt("SaveHVD2", GlobalQuest.HelpVillagerDone);

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
        PlayerPrefs.SetInt("SaveZenD2", Global.Zen);
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

        //Set item material
        PlayerPrefs.SetInt("SaveMDD2", ContainerController.MorningDrop);
        PlayerPrefs.SetInt("SaveDLD2", ContainerController.DriedLeaves);
        PlayerPrefs.SetInt("SavePWD2", ContainerController.PureWater);
        PlayerPrefs.SetInt("SaveMGD2", ContainerController.ManaGem);
        PlayerPrefs.SetInt("SaveHPD2", ContainerController.HealPotion);
        PlayerPrefs.SetInt("SaveMPD2", ContainerController.ManaPotion);
        PlayerPrefs.SetInt("SaveEPD2", ContainerController.ElixirPotion);
        PlayerPrefs.SetInt("SaveID2", ContainerController.Iron);
        PlayerPrefs.SetInt("SaveBD2", ContainerController.Bom);

        PlayerPrefs.SetInt("SaveGameD2", 1);

        show4.SetActive(true);
        show3.text = "Data Save!";
        Invoke("delay2", 2f);
    }
    public void PressSaveGameData3()
    {
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

        //Set quest
        PlayerPrefs.SetInt("SaveKGQD3", GlobalQuest.KillGoblinQuest);
        PlayerPrefs.SetInt("SaveHVStop1D3", GlobalQuest.HelpVillagerStop1);
        PlayerPrefs.SetInt("SaveHVStop2D3", GlobalQuest.HelpVillagerStop2);
        PlayerPrefs.SetInt("SaveHVStop3D3", GlobalQuest.HelpVillagerStop3);
        PlayerPrefs.SetInt("SaveHVD3", GlobalQuest.HelpVillagerDone);

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
        PlayerPrefs.SetInt("SaveZenD3", Global.Zen);
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

        //Set item material
        PlayerPrefs.SetInt("SaveMDD3", ContainerController.MorningDrop);
        PlayerPrefs.SetInt("SaveDLD3", ContainerController.DriedLeaves);
        PlayerPrefs.SetInt("SavePWD3", ContainerController.PureWater);
        PlayerPrefs.SetInt("SaveMGD3", ContainerController.ManaGem);
        PlayerPrefs.SetInt("SaveHPD3", ContainerController.HealPotion);
        PlayerPrefs.SetInt("SaveMPD3", ContainerController.ManaPotion);
        PlayerPrefs.SetInt("SaveEPD3", ContainerController.ElixirPotion);
        PlayerPrefs.SetInt("SaveID3", ContainerController.Iron);
        PlayerPrefs.SetInt("SaveBD3", ContainerController.Bom);

        PlayerPrefs.SetInt("SaveGameD3", 1);

        show4.SetActive(true);
        show3.text = "Data Save!";
        Invoke("delay2", 2f);
    }
    public void PressSGBackButton()
    {
        SaveGamePanel.SetActive(false);
    }
    void delay2()
    {
        show4.SetActive(false);
    }
}
