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
        PlayerPrefs.SetInt("Savecus1D1", PlayerPrefs.GetInt("cus1"));
        PlayerPrefs.SetInt("Savecus2D1", PlayerPrefs.GetInt("cus2"));
        PlayerPrefs.SetInt("Savecus3D1", PlayerPrefs.GetInt("cus3"));
        PlayerPrefs.SetInt("Savecus4D1", PlayerPrefs.GetInt("cus4"));
        PlayerPrefs.SetInt("Savecus5D1", PlayerPrefs.GetInt("cus5"));
        PlayerPrefs.SetInt("Savecus6D1", PlayerPrefs.GetInt("cus6"));
        PlayerPrefs.SetInt("Savecus7D1", PlayerPrefs.GetInt("cus7"));
        PlayerPrefs.SetInt("Savecus8D1", PlayerPrefs.GetInt("cus8"));
        PlayerPrefs.SetInt("Savecus9D1", PlayerPrefs.GetInt("cus9"));
        PlayerPrefs.SetInt("Savecus10D1", PlayerPrefs.GetInt("cus10"));
        PlayerPrefs.SetInt("Savecus11D1", PlayerPrefs.GetInt("cus11"));
        PlayerPrefs.SetInt("Savecus12D1", PlayerPrefs.GetInt("cus12"));

        PlayerPrefs.SetInt("SaveKGQD1", PlayerPrefs.GetInt("SKGQ"));
        PlayerPrefs.SetInt("SaveHVStop1D1", PlayerPrefs.GetInt("SHVStop1"));
        PlayerPrefs.SetInt("SaveHVStop2D1", PlayerPrefs.GetInt("SHVStop2"));
        PlayerPrefs.SetInt("SaveHVStop3D1", PlayerPrefs.GetInt("SHVStop3"));
        PlayerPrefs.SetInt("SaveHVD1", PlayerPrefs.GetInt("SHV"));

        //Save player 1 (Vayne)
        PlayerPrefs.SetInt("SaveMaxHPP1D1", PlayerPrefs.GetInt("AfterMaxHPP1"));
        PlayerPrefs.SetInt("SaveHPP1D1", PlayerPrefs.GetInt("AfterHPP1"));
        PlayerPrefs.SetInt("SaveMaxMPP1D1", PlayerPrefs.GetInt("AfterMaxMPP1"));
        PlayerPrefs.SetInt("SaveMPP1D1", PlayerPrefs.GetInt("AfterMPP1"));
        PlayerPrefs.SetInt("SaveDamageP1D1", PlayerPrefs.GetInt("AfterDamageP1"));
        PlayerPrefs.SetInt("SaveSpeedP1D1", PlayerPrefs.GetInt("AfterSpeedP1"));
        PlayerPrefs.SetInt("SaveLevelP1D1", PlayerPrefs.GetInt("AfterLevelP1"));
        PlayerPrefs.SetInt("SaveMaxEXPP1D1", PlayerPrefs.GetInt("AfterMaxEXPP1"));
        PlayerPrefs.SetInt("SaveCurEXPP1D1", PlayerPrefs.GetInt("AfterCurEXPP1"));
        PlayerPrefs.SetInt("SaveZenD1", PlayerPrefs.GetInt("AfterZen"));
        //Set player 2 (Alia)
        PlayerPrefs.SetInt("SaveMaxHPP2D1", PlayerPrefs.GetInt("AfterMaxHPP2"));
        PlayerPrefs.SetInt("SaveHPP2D1", PlayerPrefs.GetInt("AfterHPP2"));
        PlayerPrefs.SetInt("SaveMaxMPP2D1", PlayerPrefs.GetInt("AfterMaxMPP2"));
        PlayerPrefs.SetInt("SaveMPP2D1", PlayerPrefs.GetInt("AfterMPP2"));
        PlayerPrefs.SetInt("SaveDamageP2D1", PlayerPrefs.GetInt("AfterDamageP2"));
        PlayerPrefs.SetInt("SaveSpeedP2D1", PlayerPrefs.GetInt("AfterSpeedP2"));
        PlayerPrefs.SetInt("SaveLevelP2D1", PlayerPrefs.GetInt("AfterLevelP2"));
        PlayerPrefs.SetInt("SaveMaxEXPP2D1", PlayerPrefs.GetInt("AfterMaxEXPP2"));
        PlayerPrefs.SetInt("SaveCurEXPP2D1", PlayerPrefs.GetInt("AfterCurEXPP2"));
        //Set M&I
        /*PlayerPrefs.SetInt("SaveMDD1", PlayerPrefs.GetInt("SMD"));
        PlayerPrefs.SetInt("SaveDLD1", PlayerPrefs.GetInt("SDL"));
        PlayerPrefs.SetInt("SavePWD1", PlayerPrefs.GetInt("SPW"));
        PlayerPrefs.SetInt("SaveMGD1", PlayerPrefs.GetInt("SMG"));
        PlayerPrefs.SetInt("SaveHPD1", PlayerPrefs.GetInt("SHP"));
        PlayerPrefs.SetInt("SaveMPD1", PlayerPrefs.GetInt("SMP"));
        PlayerPrefs.SetInt("SaveEPD1", PlayerPrefs.GetInt("SEP"));
        PlayerPrefs.SetInt("SaveID1", PlayerPrefs.GetInt("SI"));
        PlayerPrefs.SetInt("SaveBD1", PlayerPrefs.GetInt("SB"));*/

        PlayerPrefs.SetInt("SaveMDD1", ContainerController.MorningDrop);
        PlayerPrefs.SetInt("SaveDLD1", ContainerController.DriedLeaves);
        PlayerPrefs.SetInt("SavePWD1", ContainerController.PureWater);
        PlayerPrefs.SetInt("SaveMGD1", ContainerController.ManaGem);
        PlayerPrefs.SetInt("SaveHPD1", ContainerController.HealPotion);
        PlayerPrefs.SetInt("SaveMPD1", ContainerController.ManaPotion);
        PlayerPrefs.SetInt("SaveEPD1", ContainerController.ElixirPotion);
        PlayerPrefs.SetInt("SaveID1", ContainerController.Iron);
        PlayerPrefs.SetInt("SaveBD1", ContainerController.Bom);

        PlayerPrefs.SetInt("SaveDTakeDD1", PlayerPrefs.GetInt("DTakeD"));

        PlayerPrefs.SetInt("SaveGameD1", 1);

        show4.SetActive(true);
        show3.text = "Data Save!";
        Invoke("delay2", 2f);
    }
    public void PressSaveGameData2()
    {
        PlayerPrefs.SetInt("Savecus1D2", PlayerPrefs.GetInt("cus1"));
        PlayerPrefs.SetInt("Savecus2D2", PlayerPrefs.GetInt("cus2"));
        PlayerPrefs.SetInt("Savecus3D2", PlayerPrefs.GetInt("cus3"));
        PlayerPrefs.SetInt("Savecus4D2", PlayerPrefs.GetInt("cus4"));
        PlayerPrefs.SetInt("Savecus5D2", PlayerPrefs.GetInt("cus5"));
        PlayerPrefs.SetInt("Savecus6D2", PlayerPrefs.GetInt("cus6"));
        PlayerPrefs.SetInt("Savecus7D2", PlayerPrefs.GetInt("cus7"));
        PlayerPrefs.SetInt("Savecus8D2", PlayerPrefs.GetInt("cus8"));
        PlayerPrefs.SetInt("Savecus9D2", PlayerPrefs.GetInt("cus9"));
        PlayerPrefs.SetInt("Savecus10D2", PlayerPrefs.GetInt("cus10"));
        PlayerPrefs.SetInt("Savecus11D2", PlayerPrefs.GetInt("cus11"));
        PlayerPrefs.SetInt("Savecus12D2", PlayerPrefs.GetInt("cus12"));

        PlayerPrefs.SetInt("SaveKGQD2", PlayerPrefs.GetInt("SKGQ"));
        PlayerPrefs.SetInt("SaveHVStop1D2", PlayerPrefs.GetInt("SHVStop1"));
        PlayerPrefs.SetInt("SaveHVStop2D2", PlayerPrefs.GetInt("SHVStop2"));
        PlayerPrefs.SetInt("SaveHVStop3D2", PlayerPrefs.GetInt("SHVStop3"));
        PlayerPrefs.SetInt("SaveHVD2", PlayerPrefs.GetInt("SHV"));

        //Save player 1 (Vayne)
        PlayerPrefs.SetInt("SaveMaxHPP1D2", PlayerPrefs.GetInt("AfterMaxHPP1"));
        PlayerPrefs.SetInt("SaveHPP1D2", PlayerPrefs.GetInt("AfterHPP1"));
        PlayerPrefs.SetInt("SaveMaxMPP1D2", PlayerPrefs.GetInt("AfterMaxMPP1"));
        PlayerPrefs.SetInt("SaveMPP1D2", PlayerPrefs.GetInt("AfterMPP1"));
        PlayerPrefs.SetInt("SaveDamageP1D2", PlayerPrefs.GetInt("AfterDamageP1"));
        PlayerPrefs.SetInt("SaveSpeedP1D2", PlayerPrefs.GetInt("AfterSpeedP1"));
        PlayerPrefs.SetInt("SaveLevelP1D2", PlayerPrefs.GetInt("AfterLevelP1"));
        PlayerPrefs.SetInt("SaveMaxEXPP1D2", PlayerPrefs.GetInt("AfterMaxEXPP1"));
        PlayerPrefs.SetInt("SaveCurEXPP1D2", PlayerPrefs.GetInt("AfterCurEXPP1"));
        PlayerPrefs.SetInt("SaveZenD2", PlayerPrefs.GetInt("AfterZen"));
        //Set player 2 (Alia)
        PlayerPrefs.SetInt("SaveMaxHPP2D2", PlayerPrefs.GetInt("AfterMaxHPP2"));
        PlayerPrefs.SetInt("SaveHPP2D2", PlayerPrefs.GetInt("AfterHPP2"));
        PlayerPrefs.SetInt("SaveMaxMPP2D2", PlayerPrefs.GetInt("AfterMaxMPP2"));
        PlayerPrefs.SetInt("SaveMPP2D2", PlayerPrefs.GetInt("AfterMPP2"));
        PlayerPrefs.SetInt("SaveDamageP2D2", PlayerPrefs.GetInt("AfterDamageP2"));
        PlayerPrefs.SetInt("SaveSpeedP2D2", PlayerPrefs.GetInt("AfterSpeedP2"));
        PlayerPrefs.SetInt("SaveLevelP2D2", PlayerPrefs.GetInt("AfterLevelP2"));
        PlayerPrefs.SetInt("SaveMaxEXPP2D2", PlayerPrefs.GetInt("AfterMaxEXPP2"));
        PlayerPrefs.SetInt("SaveCurEXPP2D2", PlayerPrefs.GetInt("AfterCurEXPP2"));

        /*PlayerPrefs.SetInt("SaveMDD2", PlayerPrefs.GetInt("SMD"));
        PlayerPrefs.SetInt("SaveDLD2", PlayerPrefs.GetInt("SDL"));
        PlayerPrefs.SetInt("SavePWD2", PlayerPrefs.GetInt("SPW"));
        PlayerPrefs.SetInt("SaveMGD2", PlayerPrefs.GetInt("SMG"));
        PlayerPrefs.SetInt("SaveHPD2", PlayerPrefs.GetInt("SHP"));
        PlayerPrefs.SetInt("SaveMPD2", PlayerPrefs.GetInt("SMP"));
        PlayerPrefs.SetInt("SaveEPD2", PlayerPrefs.GetInt("SEP"));
        PlayerPrefs.SetInt("SaveID2", PlayerPrefs.GetInt("SI"));
        PlayerPrefs.SetInt("SaveBD2", PlayerPrefs.GetInt("SB"));*/

        PlayerPrefs.SetInt("SaveMDD2", ContainerController.MorningDrop);
        PlayerPrefs.SetInt("SaveDLD2", ContainerController.DriedLeaves);
        PlayerPrefs.SetInt("SavePWD2", ContainerController.PureWater);
        PlayerPrefs.SetInt("SaveMGD2", ContainerController.ManaGem);
        PlayerPrefs.SetInt("SaveHPD2", ContainerController.HealPotion);
        PlayerPrefs.SetInt("SaveMPD2", ContainerController.ManaPotion);
        PlayerPrefs.SetInt("SaveEPD2", ContainerController.ElixirPotion);
        PlayerPrefs.SetInt("SaveID2", ContainerController.Iron);
        PlayerPrefs.SetInt("SaveBD2", ContainerController.Bom);

        PlayerPrefs.SetInt("SaveDTakeDD2", PlayerPrefs.GetInt("DTakeD"));

        PlayerPrefs.SetInt("SaveGameD2", 1);

        show4.SetActive(true);
        show3.text = "Data Save!";
        Invoke("delay2", 2f);
    }
    public void PressSaveGameData3()
    {
        PlayerPrefs.SetInt("Savecus1D3", PlayerPrefs.GetInt("cus1"));
        PlayerPrefs.SetInt("Savecus2D3", PlayerPrefs.GetInt("cus2"));
        PlayerPrefs.SetInt("Savecus3D3", PlayerPrefs.GetInt("cus3"));
        PlayerPrefs.SetInt("Savecus4D3", PlayerPrefs.GetInt("cus4"));
        PlayerPrefs.SetInt("Savecus5D3", PlayerPrefs.GetInt("cus5"));
        PlayerPrefs.SetInt("Savecus6D3", PlayerPrefs.GetInt("cus6"));
        PlayerPrefs.SetInt("Savecus7D3", PlayerPrefs.GetInt("cus7"));
        PlayerPrefs.SetInt("Savecus8D3", PlayerPrefs.GetInt("cus8"));
        PlayerPrefs.SetInt("Savecus9D3", PlayerPrefs.GetInt("cus9"));
        PlayerPrefs.SetInt("Savecus10D3", PlayerPrefs.GetInt("cus10"));
        PlayerPrefs.SetInt("Savecus11D3", PlayerPrefs.GetInt("cus11"));
        PlayerPrefs.SetInt("Savecus12D3", PlayerPrefs.GetInt("cus12"));

        PlayerPrefs.SetInt("SaveKGQD3", PlayerPrefs.GetInt("SKGQ"));
        PlayerPrefs.SetInt("SaveHVStop1D3", PlayerPrefs.GetInt("SHVStop1"));
        PlayerPrefs.SetInt("SaveHVStop2D3", PlayerPrefs.GetInt("SHVStop2"));
        PlayerPrefs.SetInt("SaveHVStop3D3", PlayerPrefs.GetInt("SHVStop3"));
        PlayerPrefs.SetInt("SaveHVD3", PlayerPrefs.GetInt("SHV"));

        //Save player 1 (Vayne)
        PlayerPrefs.SetInt("SaveMaxHPP1D3", PlayerPrefs.GetInt("AfterMaxHPP1"));
        PlayerPrefs.SetInt("SaveHPP1D3", PlayerPrefs.GetInt("AfterHPP1"));
        PlayerPrefs.SetInt("SaveMaxMPP1D3", PlayerPrefs.GetInt("AfterMaxMPP1"));
        PlayerPrefs.SetInt("SaveMPP1D3", PlayerPrefs.GetInt("AfterMPP1"));
        PlayerPrefs.SetInt("SaveDamageP1D3", PlayerPrefs.GetInt("AfterDamageP1"));
        PlayerPrefs.SetInt("SaveSpeedP1D3", PlayerPrefs.GetInt("AfterSpeedP1"));
        PlayerPrefs.SetInt("SaveLevelP1D3", PlayerPrefs.GetInt("AfterLevelP1"));
        PlayerPrefs.SetInt("SaveMaxEXPP1D3", PlayerPrefs.GetInt("AfterMaxEXPP1"));
        PlayerPrefs.SetInt("SaveCurEXPP1D3", PlayerPrefs.GetInt("AfterCurEXPP1"));
        PlayerPrefs.SetInt("SaveZenD3", PlayerPrefs.GetInt("AfterZen"));
        //Set player 2 (Alia)
        PlayerPrefs.SetInt("SaveMaxHPP2D3", PlayerPrefs.GetInt("AfterMaxHPP2"));
        PlayerPrefs.SetInt("SaveHPP2D3", PlayerPrefs.GetInt("AfterHPP2"));
        PlayerPrefs.SetInt("SaveMaxMPP2D3", PlayerPrefs.GetInt("AfterMaxMPP2"));
        PlayerPrefs.SetInt("SaveMPP2D3", PlayerPrefs.GetInt("AfterMPP2"));
        PlayerPrefs.SetInt("SaveDamageP2D3", PlayerPrefs.GetInt("AfterDamageP2"));
        PlayerPrefs.SetInt("SaveSpeedP2D3", PlayerPrefs.GetInt("AfterSpeedP2"));
        PlayerPrefs.SetInt("SaveLevelP2D3", PlayerPrefs.GetInt("AfterLevelP2"));
        PlayerPrefs.SetInt("SaveMaxEXPP2D3", PlayerPrefs.GetInt("AfterMaxEXPP2"));
        PlayerPrefs.SetInt("SaveCurEXPP2D3", PlayerPrefs.GetInt("AfterCurEXPP2"));

        /*PlayerPrefs.SetInt("SaveMDD3", PlayerPrefs.GetInt("SMD"));
        PlayerPrefs.SetInt("SaveDLD3", PlayerPrefs.GetInt("SDL"));
        PlayerPrefs.SetInt("SavePWD3", PlayerPrefs.GetInt("SPW"));
        PlayerPrefs.SetInt("SaveMGD3", PlayerPrefs.GetInt("SMG"));
        PlayerPrefs.SetInt("SaveHPD3", PlayerPrefs.GetInt("SHP"));
        PlayerPrefs.SetInt("SaveMPD3", PlayerPrefs.GetInt("SMP"));
        PlayerPrefs.SetInt("SaveEPD3", PlayerPrefs.GetInt("SEP"));
        PlayerPrefs.SetInt("SaveID3", PlayerPrefs.GetInt("SI"));
        PlayerPrefs.SetInt("SaveBD3", PlayerPrefs.GetInt("SB"));*/

        PlayerPrefs.SetInt("SaveMDD3", ContainerController.MorningDrop);
        PlayerPrefs.SetInt("SaveDLD3", ContainerController.DriedLeaves);
        PlayerPrefs.SetInt("SavePWD3", ContainerController.PureWater);
        PlayerPrefs.SetInt("SaveMGD3", ContainerController.ManaGem);
        PlayerPrefs.SetInt("SaveHPD3", ContainerController.HealPotion);
        PlayerPrefs.SetInt("SaveMPD3", ContainerController.ManaPotion);
        PlayerPrefs.SetInt("SaveEPD3", ContainerController.ElixirPotion);
        PlayerPrefs.SetInt("SaveID3", ContainerController.Iron);
        PlayerPrefs.SetInt("SaveBD3", ContainerController.Bom);

        PlayerPrefs.SetInt("SaveDTakeDD3", PlayerPrefs.GetInt("DTakeD"));

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
