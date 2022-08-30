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
        /*PlayerPrefs.SetInt("cus1", 0);
        PlayerPrefs.SetInt("cus2", 0);
        PlayerPrefs.SetInt("cus3", 0);
        PlayerPrefs.SetInt("cus4", 0);
        PlayerPrefs.SetInt("cus5", 0);
        PlayerPrefs.SetInt("cus6", 0);
        PlayerPrefs.SetInt("cus7", 0);
        PlayerPrefs.SetInt("cus8", 0);
        PlayerPrefs.SetInt("cus9", 0);
        PlayerPrefs.SetInt("cus10", 0);
        PlayerPrefs.SetInt("cus11", 0);
        PlayerPrefs.SetInt("cus12", 0);*/

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

        PlayerPrefs.SetInt("SKGQ", 0);
        PlayerPrefs.SetInt("SHVStop1", 0);
        PlayerPrefs.SetInt("SHVStop2", 0);
        PlayerPrefs.SetInt("SHVStop3", 0);
        PlayerPrefs.SetInt("SHV", 0);

        PlayerPrefs.SetFloat("x", 2);
        PlayerPrefs.SetFloat("y", 1);
        PlayerPrefs.SetFloat("z", 0);
        //Set player 1 (Vayne)
        PlayerPrefs.SetInt("SMaxHPP1", 100);
        PlayerPrefs.SetInt("SMaxMPP1", 50);
        PlayerPrefs.SetInt("SDamageP1", 10);
        PlayerPrefs.SetInt("SSpeedP1", 20);
        PlayerPrefs.SetInt("SLevelP1", 1);
        PlayerPrefs.SetInt("SMaxEXPP1", 40);
        PlayerPrefs.SetInt("SCurEXPP1", 0);
        PlayerPrefs.SetInt("SZen", 0);
        PlayerPrefs.SetInt("AfterMaxHPP1", 100);
        PlayerPrefs.SetInt("AfterHPP1", 100);
        PlayerPrefs.SetInt("AfterMaxMPP1", 50);
        PlayerPrefs.SetInt("AfterMPP1", 50);
        PlayerPrefs.SetInt("AfterDamageP1", 10);
        PlayerPrefs.SetInt("AfterSpeedP1", 20);
        PlayerPrefs.SetInt("AfterLevelP1", 1);
        PlayerPrefs.SetInt("AfterMaxEXPP1", 40);
        PlayerPrefs.SetInt("AfterCurEXPP1", 0);
        PlayerPrefs.SetInt("AfterZen", 0);
        //Set player 2 (Alia)
        PlayerPrefs.SetInt("SMaxHPP2", 60);
        PlayerPrefs.SetInt("SMaxMPP2", 32);
        PlayerPrefs.SetInt("SDamageP2", 15);
        PlayerPrefs.SetInt("SSpeedP2", 30);
        PlayerPrefs.SetInt("SLevelP2", 2);
        PlayerPrefs.SetInt("SMaxEXPP2", 80);
        PlayerPrefs.SetInt("SCurEXPP2", 0);
        PlayerPrefs.SetInt("AfterMaxHPP2", 60);
        PlayerPrefs.SetInt("AfterHPP2", 60);
        PlayerPrefs.SetInt("AfterMaxMPP2", 32);
        PlayerPrefs.SetInt("AfterMPP2", 32);
        PlayerPrefs.SetInt("AfterDamageP2", 15);
        PlayerPrefs.SetInt("AfterSpeedP2", 30);
        PlayerPrefs.SetInt("AfterLevelP2", 2);
        PlayerPrefs.SetInt("AfterMaxEXPP2", 80);
        PlayerPrefs.SetInt("AfterCurEXPP2", 0);
        //Set item material
        /*PlayerPrefs.SetInt("SMD", 0);
        PlayerPrefs.SetInt("SDL", 0);
        PlayerPrefs.SetInt("SPW", 0);
        PlayerPrefs.SetInt("SMG", 0);
        PlayerPrefs.SetInt("SHP", 0);
        PlayerPrefs.SetInt("SMP", 0);
        PlayerPrefs.SetInt("SEP", 0);
        PlayerPrefs.SetInt("SI", 0);
        PlayerPrefs.SetInt("SB", 0);*/
        ContainerController.MorningDrop = 0;
        ContainerController.DriedLeaves = 0;
        ContainerController.PureWater = 0;
        ContainerController.ManaGem = 0;
        ContainerController.HealPotion = 0;
        ContainerController.ManaPotion = 0;
        ContainerController.ElixirPotion = 0;
        ContainerController.Iron = 0;
        ContainerController.Bom = 0;

        PlayerPrefs.SetInt("DTakeD", 0);

        PlayerPrefs.SetInt("CPosi1", 0);
        PlayerPrefs.SetInt("BPosi1", 0);
        PlayerPrefs.SetInt("CPosi2", 0);
        PlayerPrefs.SetInt("BPosi2", 0);
        PlayerPrefs.SetInt("CPosi3", 0);
        PlayerPrefs.SetInt("BPosi3", 0);
        PlayerPrefs.SetInt("CPosi4", 0);
        PlayerPrefs.SetInt("BPosi4", 0);

        SceneManager.LoadScene(7);
    }
    public void PressLoadGame()
    {
        LoadGamePanel.SetActive(true);
    }
    public void PressLoadGameData1()
    {
        if (PlayerPrefs.GetInt("SaveGameD1") == 1)
        {
            /*PlayerPrefs.SetInt("cus1", PlayerPrefs.GetInt("Savecus1D1"));
            PlayerPrefs.SetInt("cus2", PlayerPrefs.GetInt("Savecus2D1"));
            PlayerPrefs.SetInt("cus3", PlayerPrefs.GetInt("Savecus3D1"));
            PlayerPrefs.SetInt("cus4", PlayerPrefs.GetInt("Savecus4D1"));
            PlayerPrefs.SetInt("cus5", PlayerPrefs.GetInt("Savecus5D1"));
            PlayerPrefs.SetInt("cus6", PlayerPrefs.GetInt("Savecus6D1"));
            PlayerPrefs.SetInt("cus7", PlayerPrefs.GetInt("Savecus7D1"));
            PlayerPrefs.SetInt("cus8", PlayerPrefs.GetInt("Savecus8D1"));
            PlayerPrefs.SetInt("cus9", PlayerPrefs.GetInt("Savecus9D1"));
            PlayerPrefs.SetInt("cus10", PlayerPrefs.GetInt("Savecus10D1"));
            PlayerPrefs.SetInt("cus11", PlayerPrefs.GetInt("Savecus11D1"));
            PlayerPrefs.SetInt("cus12", PlayerPrefs.GetInt("Savecus12D1"));*/
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

            PlayerPrefs.SetInt("SKGQ", PlayerPrefs.GetInt("SaveKGQD1"));
            PlayerPrefs.SetInt("SHVStop1", PlayerPrefs.GetInt("SaveHVStop1D1"));
            PlayerPrefs.SetInt("SHVStop2", PlayerPrefs.GetInt("SaveHVStop2D1"));
            PlayerPrefs.SetInt("SHVStop3", PlayerPrefs.GetInt("SaveHVStop3D1"));
            PlayerPrefs.SetInt("SHV", PlayerPrefs.GetInt("SaveHVD1"));

            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            Debug.Log(PlayerPrefs.GetInt("SaveZenD1"));
            //Set player 1 (Vayne)
            PlayerPrefs.SetInt("SMaxHPP1", PlayerPrefs.GetInt("SaveMaxHPP1D1"));
            PlayerPrefs.SetInt("SMaxMPP1", PlayerPrefs.GetInt("SaveMaxMPP1D1"));
            PlayerPrefs.SetInt("SDamageP1", PlayerPrefs.GetInt("SaveDamageP1D1"));
            PlayerPrefs.SetInt("SSpeedP1", PlayerPrefs.GetInt("SaveSpeedP1D1"));
            PlayerPrefs.SetInt("SLevelP1", PlayerPrefs.GetInt("SaveLevelP1D1"));
            PlayerPrefs.SetInt("SMaxEXPP1", PlayerPrefs.GetInt("SaveMaxEXPP1D1"));
            PlayerPrefs.SetInt("SCurEXPP1", PlayerPrefs.GetInt("SaveCurEXPP1D1"));
            PlayerPrefs.SetInt("SZen", PlayerPrefs.GetInt("SaveZenD1"));

            PlayerPrefs.SetInt("AfterMaxHPP1", PlayerPrefs.GetInt("SaveMaxHPP1D1"));
            PlayerPrefs.SetInt("AfterHPP1", PlayerPrefs.GetInt("SaveHPP1D1"));
            PlayerPrefs.SetInt("AfterMaxMPP1", PlayerPrefs.GetInt("SaveMaxMPP1D1"));
            PlayerPrefs.SetInt("AfterMPP1", PlayerPrefs.GetInt("SaveMPP1D1"));
            PlayerPrefs.SetInt("AfterDamageP1", PlayerPrefs.GetInt("SaveDamageP1D1"));
            PlayerPrefs.SetInt("AfterSpeedP1", PlayerPrefs.GetInt("SaveSpeedP1D1"));
            PlayerPrefs.SetInt("AfterLevelP1", PlayerPrefs.GetInt("SaveLevelP1D1"));
            PlayerPrefs.SetInt("AfterMaxEXPP1", PlayerPrefs.GetInt("SaveMaxEXPP1D1"));
            PlayerPrefs.SetInt("AfterCurEXPP1", PlayerPrefs.GetInt("SaveCurEXPP1D1"));
            PlayerPrefs.SetInt("AfterZen", PlayerPrefs.GetInt("SaveZenD1"));
            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SMaxHPP2", PlayerPrefs.GetInt("SaveMaxHPP2D1"));
            PlayerPrefs.SetInt("SMaxMPP2", PlayerPrefs.GetInt("SaveMaxMPP2D1"));
            PlayerPrefs.SetInt("SDamageP2", PlayerPrefs.GetInt("SaveDamageP2D1"));
            PlayerPrefs.SetInt("SSpeedP2", PlayerPrefs.GetInt("SaveSpeedP2D1"));
            PlayerPrefs.SetInt("SLevelP2", PlayerPrefs.GetInt("SaveLevelP2D1"));
            PlayerPrefs.SetInt("SMaxEXPP2", PlayerPrefs.GetInt("SaveMaxEXPP2D1"));
            PlayerPrefs.SetInt("SCurEXPP2", PlayerPrefs.GetInt("SaveCurEXPP2D1"));

            PlayerPrefs.SetInt("AfterMaxHPP2", PlayerPrefs.GetInt("SaveMaxHPP2D1"));
            PlayerPrefs.SetInt("AfterHPP2", PlayerPrefs.GetInt("SaveHPP2D1"));
            PlayerPrefs.SetInt("AfterMaxMPP2", PlayerPrefs.GetInt("SaveMaxMPP2D1"));
            PlayerPrefs.SetInt("AfterMPP2", PlayerPrefs.GetInt("SaveMPP2D1"));
            PlayerPrefs.SetInt("AfterDamageP2", PlayerPrefs.GetInt("SaveDamageP2D1"));
            PlayerPrefs.SetInt("AfterSpeedP2", PlayerPrefs.GetInt("SaveSpeedP2D1"));
            PlayerPrefs.SetInt("AfterLevelP2", PlayerPrefs.GetInt("SaveLevelP2D1"));
            PlayerPrefs.SetInt("AfterMaxEXPP2", PlayerPrefs.GetInt("SaveMaxEXPP2D1"));
            PlayerPrefs.SetInt("AfterCurEXPP2", PlayerPrefs.GetInt("SaveCurEXPP2D1"));

            /*PlayerPrefs.SetInt("SMD", PlayerPrefs.GetInt("SaveMDD1"));
            PlayerPrefs.SetInt("SDL", PlayerPrefs.GetInt("SaveDLD1"));
            PlayerPrefs.SetInt("SPW", PlayerPrefs.GetInt("SavePWD1"));
            PlayerPrefs.SetInt("SMG", PlayerPrefs.GetInt("SaveMGD1"));
            PlayerPrefs.SetInt("SHP", PlayerPrefs.GetInt("SaveHPD1"));
            PlayerPrefs.SetInt("SMP", PlayerPrefs.GetInt("SaveMPD1"));
            PlayerPrefs.SetInt("SEP", PlayerPrefs.GetInt("SaveEPD1"));
            PlayerPrefs.SetInt("SI", PlayerPrefs.GetInt("SaveID1"));
            PlayerPrefs.SetInt("SB", PlayerPrefs.GetInt("SaveBD1"));*/

            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMDD1");
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDLD1");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePWD1");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveMGD1");
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHPD1");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveMPD1");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveEPD1");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveID1");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBD1");

            PlayerPrefs.SetInt("DTakeD", PlayerPrefs.GetInt("SaveDTakeDD1"));

            SceneManager.LoadScene(6);
        }
    }
    public void PressLoadGameData2()
    {
        if (PlayerPrefs.GetInt("SaveGameD2") == 1)
        {
            /*PlayerPrefs.SetInt("cus1", PlayerPrefs.GetInt("Savecus1D2"));
            PlayerPrefs.SetInt("cus2", PlayerPrefs.GetInt("Savecus2D2"));
            PlayerPrefs.SetInt("cus3", PlayerPrefs.GetInt("Savecus3D2"));
            PlayerPrefs.SetInt("cus4", PlayerPrefs.GetInt("Savecus4D2"));
            PlayerPrefs.SetInt("cus5", PlayerPrefs.GetInt("Savecus5D2"));
            PlayerPrefs.SetInt("cus6", PlayerPrefs.GetInt("Savecus6D2"));
            PlayerPrefs.SetInt("cus7", PlayerPrefs.GetInt("Savecus7D2"));
            PlayerPrefs.SetInt("cus8", PlayerPrefs.GetInt("Savecus8D2"));
            PlayerPrefs.SetInt("cus9", PlayerPrefs.GetInt("Savecus9D2"));
            PlayerPrefs.SetInt("cus10", PlayerPrefs.GetInt("Savecus10D2"));
            PlayerPrefs.SetInt("cus11", PlayerPrefs.GetInt("Savecus11D2"));
            PlayerPrefs.SetInt("cus12", PlayerPrefs.GetInt("Savecus12D2"));*/
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

            PlayerPrefs.SetInt("SKGQ", PlayerPrefs.GetInt("SaveKGQD2"));
            PlayerPrefs.SetInt("SHVStop1", PlayerPrefs.GetInt("SaveHVStop1D2"));
            PlayerPrefs.SetInt("SHVStop2", PlayerPrefs.GetInt("SaveHVStop2D2"));
            PlayerPrefs.SetInt("SHVStop3", PlayerPrefs.GetInt("SaveHVStop3D2"));
            PlayerPrefs.SetInt("SHV", PlayerPrefs.GetInt("SaveHVD2"));

            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            Debug.Log(PlayerPrefs.GetInt("SaveZenD2"));
            //Set player 1 (Vayne)
            PlayerPrefs.SetInt("SMaxHPP1", PlayerPrefs.GetInt("SaveMaxHPP1D2"));
            PlayerPrefs.SetInt("SMaxMPP1", PlayerPrefs.GetInt("SaveMaxMPP1D2"));
            PlayerPrefs.SetInt("SDamageP1", PlayerPrefs.GetInt("SaveDamageP1D2"));
            PlayerPrefs.SetInt("SSpeedP1", PlayerPrefs.GetInt("SaveSpeedP1D2"));
            PlayerPrefs.SetInt("SLevelP1", PlayerPrefs.GetInt("SaveLevelP1D2"));
            PlayerPrefs.SetInt("SMaxEXPP1", PlayerPrefs.GetInt("SaveMaxEXPP1D2"));
            PlayerPrefs.SetInt("SCurEXPP1", PlayerPrefs.GetInt("SaveCurEXPP1D2"));
            PlayerPrefs.SetInt("SZen", PlayerPrefs.GetInt("SaveZenD2"));

            PlayerPrefs.SetInt("AfterMaxHPP1", PlayerPrefs.GetInt("SaveMaxHPP1D2"));
            PlayerPrefs.SetInt("AfterHPP1", PlayerPrefs.GetInt("SaveHPP1D2"));
            PlayerPrefs.SetInt("AfterMaxMPP1", PlayerPrefs.GetInt("SaveMaxMPP1D2"));
            PlayerPrefs.SetInt("AfterMPP1", PlayerPrefs.GetInt("SaveMPP1D2"));
            PlayerPrefs.SetInt("AfterDamageP1", PlayerPrefs.GetInt("SaveDamageP1D2"));
            PlayerPrefs.SetInt("AfterSpeedP1", PlayerPrefs.GetInt("SaveSpeedP1D2"));
            PlayerPrefs.SetInt("AfterLevelP1", PlayerPrefs.GetInt("SaveLevelP1D2"));
            PlayerPrefs.SetInt("AfterMaxEXPP1", PlayerPrefs.GetInt("SaveMaxEXPP1D2"));
            PlayerPrefs.SetInt("AfterCurEXPP1", PlayerPrefs.GetInt("SaveCurEXPP1D2"));
            PlayerPrefs.SetInt("AfterZen", PlayerPrefs.GetInt("SaveZenD2"));
            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SMaxHPP2", PlayerPrefs.GetInt("SaveMaxHPP2D2"));
            PlayerPrefs.SetInt("SMaxMPP2", PlayerPrefs.GetInt("SaveMaxMPP2D2"));
            PlayerPrefs.SetInt("SDamageP2", PlayerPrefs.GetInt("SaveDamageP2D2"));
            PlayerPrefs.SetInt("SSpeedP2", PlayerPrefs.GetInt("SaveSpeedP2D2"));
            PlayerPrefs.SetInt("SLevelP2", PlayerPrefs.GetInt("SaveLevelP2D2"));
            PlayerPrefs.SetInt("SMaxEXPP2", PlayerPrefs.GetInt("SaveMaxEXPP2D2"));
            PlayerPrefs.SetInt("SCurEXPP2", PlayerPrefs.GetInt("SaveCurEXPP2D2"));

            PlayerPrefs.SetInt("AfterMaxHPP2", PlayerPrefs.GetInt("SaveMaxHPP2D2"));
            PlayerPrefs.SetInt("AfterHPP2", PlayerPrefs.GetInt("SaveHPP2D2"));
            PlayerPrefs.SetInt("AfterMaxMPP2", PlayerPrefs.GetInt("SaveMaxMPP2D2"));
            PlayerPrefs.SetInt("AfterMPP2", PlayerPrefs.GetInt("SaveMPP2D2"));
            PlayerPrefs.SetInt("AfterDamageP2", PlayerPrefs.GetInt("SaveDamageP2D2"));
            PlayerPrefs.SetInt("AfterSpeedP2", PlayerPrefs.GetInt("SaveSpeedP2D2"));
            PlayerPrefs.SetInt("AfterLevelP2", PlayerPrefs.GetInt("SaveLevelP2D2"));
            PlayerPrefs.SetInt("AfterMaxEXPP2", PlayerPrefs.GetInt("SaveMaxEXPP2D2"));
            PlayerPrefs.SetInt("AfterCurEXPP2", PlayerPrefs.GetInt("SaveCurEXPP2D2"));

            /*PlayerPrefs.SetInt("SMD", PlayerPrefs.GetInt("SaveMDD2"));
            PlayerPrefs.SetInt("SDL", PlayerPrefs.GetInt("SaveDLD2"));
            PlayerPrefs.SetInt("SPW", PlayerPrefs.GetInt("SavePWD2"));
            PlayerPrefs.SetInt("SMG", PlayerPrefs.GetInt("SaveMGD2"));
            PlayerPrefs.SetInt("SHP", PlayerPrefs.GetInt("SaveHPD2"));
            PlayerPrefs.SetInt("SMP", PlayerPrefs.GetInt("SaveMPD2"));
            PlayerPrefs.SetInt("SEP", PlayerPrefs.GetInt("SaveEPD2"));
            PlayerPrefs.SetInt("SI", PlayerPrefs.GetInt("SaveID2"));
            PlayerPrefs.SetInt("SB", PlayerPrefs.GetInt("SaveBD2"));*/

            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMDD2");
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDLD2");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePWD2");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveMGD2");
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHPD2");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveMPD2");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveEPD2");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveID2");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBD2");

            PlayerPrefs.SetInt("DTakeD", PlayerPrefs.GetInt("SaveDTakeDD2"));

            SceneManager.LoadScene(6);
        }
    }
    public void PressLoadGameData3()
    {
        if (PlayerPrefs.GetInt("SaveGameD3") == 1)
        {
            /*PlayerPrefs.SetInt("cus1", PlayerPrefs.GetInt("Savecus1D3"));
            PlayerPrefs.SetInt("cus2", PlayerPrefs.GetInt("Savecus2D3"));
            PlayerPrefs.SetInt("cus3", PlayerPrefs.GetInt("Savecus3D3"));
            PlayerPrefs.SetInt("cus4", PlayerPrefs.GetInt("Savecus4D3"));
            PlayerPrefs.SetInt("cus5", PlayerPrefs.GetInt("Savecus5D3"));
            PlayerPrefs.SetInt("cus6", PlayerPrefs.GetInt("Savecus6D3"));
            PlayerPrefs.SetInt("cus7", PlayerPrefs.GetInt("Savecus7D3"));
            PlayerPrefs.SetInt("cus8", PlayerPrefs.GetInt("Savecus8D3"));
            PlayerPrefs.SetInt("cus9", PlayerPrefs.GetInt("Savecus9D3"));
            PlayerPrefs.SetInt("cus10", PlayerPrefs.GetInt("Savecus10D3"));
            PlayerPrefs.SetInt("cus11", PlayerPrefs.GetInt("Savecus11D3"));
            PlayerPrefs.SetInt("cus12", PlayerPrefs.GetInt("Savecus12D3"));*/
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

            PlayerPrefs.SetInt("SKGQ", PlayerPrefs.GetInt("SaveKGQD3"));
            PlayerPrefs.SetInt("SHVStop1", PlayerPrefs.GetInt("SaveHVStop1D3"));
            PlayerPrefs.SetInt("SHVStop2", PlayerPrefs.GetInt("SaveHVStop2D3"));
            PlayerPrefs.SetInt("SHVStop3", PlayerPrefs.GetInt("SaveHVStop3D3"));
            PlayerPrefs.SetInt("SHV", PlayerPrefs.GetInt("SaveHVD3"));

            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            Debug.Log(PlayerPrefs.GetInt("SaveZenD3"));
            //Set player 1 (Vayne)
            PlayerPrefs.SetInt("SMaxHPP1", PlayerPrefs.GetInt("SaveMaxHPP1D3"));
            PlayerPrefs.SetInt("SMaxMPP1", PlayerPrefs.GetInt("SaveMaxMPP1D3"));
            PlayerPrefs.SetInt("SDamageP1", PlayerPrefs.GetInt("SaveDamageP1D3"));
            PlayerPrefs.SetInt("SSpeedP1", PlayerPrefs.GetInt("SaveSpeedP1D3"));
            PlayerPrefs.SetInt("SLevelP1", PlayerPrefs.GetInt("SaveLevelP1D3"));
            PlayerPrefs.SetInt("SMaxEXPP1", PlayerPrefs.GetInt("SaveMaxEXPP1D3"));
            PlayerPrefs.SetInt("SCurEXPP1", PlayerPrefs.GetInt("SaveCurEXPP1D3"));
            PlayerPrefs.SetInt("SZen", PlayerPrefs.GetInt("SaveZenD3"));

            PlayerPrefs.SetInt("AfterMaxHPP1", PlayerPrefs.GetInt("SaveMaxHPP1D3"));
            PlayerPrefs.SetInt("AfterHPP1", PlayerPrefs.GetInt("SaveHPP1D3"));
            PlayerPrefs.SetInt("AfterMaxMPP1", PlayerPrefs.GetInt("SaveMaxMPP1D3"));
            PlayerPrefs.SetInt("AfterMPP1", PlayerPrefs.GetInt("SaveMPP1D3"));
            PlayerPrefs.SetInt("AfterDamageP1", PlayerPrefs.GetInt("SaveDamageP1D3"));
            PlayerPrefs.SetInt("AfterSpeedP1", PlayerPrefs.GetInt("SaveSpeedP1D3"));
            PlayerPrefs.SetInt("AfterLevelP1", PlayerPrefs.GetInt("SaveLevelP1D3"));
            PlayerPrefs.SetInt("AfterMaxEXPP1", PlayerPrefs.GetInt("SaveMaxEXPP1D3"));
            PlayerPrefs.SetInt("AfterCurEXPP1", PlayerPrefs.GetInt("SaveCurEXPP1D3"));
            PlayerPrefs.SetInt("AfterZen", PlayerPrefs.GetInt("SaveZenD3"));
            //Set player 2 (Alia)
            PlayerPrefs.SetInt("SMaxHPP2", PlayerPrefs.GetInt("SaveMaxHPP2D3"));
            PlayerPrefs.SetInt("SMaxMPP2", PlayerPrefs.GetInt("SaveMaxMPP2D3"));
            PlayerPrefs.SetInt("SDamageP2", PlayerPrefs.GetInt("SaveDamageP2D3"));
            PlayerPrefs.SetInt("SSpeedP2", PlayerPrefs.GetInt("SaveSpeedP2D3"));
            PlayerPrefs.SetInt("SLevelP2", PlayerPrefs.GetInt("SaveLevelP2D3"));
            PlayerPrefs.SetInt("SMaxEXPP2", PlayerPrefs.GetInt("SaveMaxEXPP2D3"));
            PlayerPrefs.SetInt("SCurEXPP2", PlayerPrefs.GetInt("SaveCurEXPP2D3"));

            PlayerPrefs.SetInt("AfterMaxHPP2", PlayerPrefs.GetInt("SaveMaxHPP2D3"));
            PlayerPrefs.SetInt("AfterHPP2", PlayerPrefs.GetInt("SaveHPP2D3"));
            PlayerPrefs.SetInt("AfterMaxMPP2", PlayerPrefs.GetInt("SaveMaxMPP2D3"));
            PlayerPrefs.SetInt("AfterMPP2", PlayerPrefs.GetInt("SaveMPP2D3"));
            PlayerPrefs.SetInt("AfterDamageP2", PlayerPrefs.GetInt("SaveDamageP2D3"));
            PlayerPrefs.SetInt("AfterSpeedP2", PlayerPrefs.GetInt("SaveSpeedP2D3"));
            PlayerPrefs.SetInt("AfterLevelP2", PlayerPrefs.GetInt("SaveLevelP2D3"));
            PlayerPrefs.SetInt("AfterMaxEXPP2", PlayerPrefs.GetInt("SaveMaxEXPP2D3"));
            PlayerPrefs.SetInt("AfterCurEXPP2", PlayerPrefs.GetInt("SaveCurEXPP2D3"));

            /*PlayerPrefs.SetInt("SMD", PlayerPrefs.GetInt("SaveMDD3"));
            PlayerPrefs.SetInt("SDL", PlayerPrefs.GetInt("SaveDLD3"));
            PlayerPrefs.SetInt("SPW", PlayerPrefs.GetInt("SavePWD3"));
            PlayerPrefs.SetInt("SMG", PlayerPrefs.GetInt("SaveMGD3"));
            PlayerPrefs.SetInt("SHP", PlayerPrefs.GetInt("SaveHPD3"));
            PlayerPrefs.SetInt("SMP", PlayerPrefs.GetInt("SaveMPD3"));
            PlayerPrefs.SetInt("SEP", PlayerPrefs.GetInt("SaveEPD3"));
            PlayerPrefs.SetInt("SI", PlayerPrefs.GetInt("SaveID3"));
            PlayerPrefs.SetInt("SB", PlayerPrefs.GetInt("SaveBD3"));*/

            ContainerController.MorningDrop = PlayerPrefs.GetInt("SaveMDD3");
            ContainerController.DriedLeaves = PlayerPrefs.GetInt("SaveDLD3");
            ContainerController.PureWater = PlayerPrefs.GetInt("SavePWD3");
            ContainerController.ManaGem = PlayerPrefs.GetInt("SaveMGD3");
            ContainerController.HealPotion = PlayerPrefs.GetInt("SaveHPD3");
            ContainerController.ManaPotion = PlayerPrefs.GetInt("SaveMPD3");
            ContainerController.ElixirPotion = PlayerPrefs.GetInt("SaveEPD3");
            ContainerController.Iron = PlayerPrefs.GetInt("SaveID3");
            ContainerController.Bom = PlayerPrefs.GetInt("SaveBD3");

            PlayerPrefs.SetInt("DTakeD", PlayerPrefs.GetInt("SaveDTakeDD3"));

            SceneManager.LoadScene(6);
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
