using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HubController : MonoBehaviour
{
    MenuController mc;
    public GameObject map;
    public GameObject info;
    public GameObject quest;
    public GameObject bag;
    public GameObject esc;
    public GameObject showDL;
    public GameObject showMD;
    public GameObject showPW;
    public GameObject showI;
    public GameObject showMG;
    public GameObject showHP;
    public GameObject showMP;
    public GameObject showEP;
    public GameObject showB;
    public GameObject showp31;
    public GameObject showp32;
    public GameObject showp33;
    public GameObject showp34;
    public Text LevelP1;
    public Text HPP1;
    public Text MPP1;
    public Text LevelP2;
    public Text HPP2;
    public Text MPP2;
    public Text HPP3;
    public Text MPP3;
    public Text Zen;
    public Text QT;
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public Text num5;
    public Text numi1;
    public Text numi2;
    public Text numi3;
    public Text numi4;
    public int ShowLevelP1, ShowLevelP2, ShowHPP1, ShowHPP2, ShowHPP3, ShowMPP1, ShowMPP2, ShowMPP3, ShowZen;

    // Start is called before the first frame update
    void Start()
    {
        mc = FindObjectOfType<MenuController>();

        ShowLevelP1 = Global.LevelP1;
        ShowHPP1 = Global.CurHPP1;
        ShowMPP1 = Global.CurMPP1;
        ShowLevelP2 = Global.LevelP2;
        ShowHPP2 = Global.CurHPP2;
        ShowMPP2 = Global.CurMPP2;
        ShowZen = Global.Zen;
        
        if (CutscenesController.cus1 == 1)
        {
            showp31.SetActive(false);
            showp32.SetActive(false);
            showp33.SetActive(false);
            showp34.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            map.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            info.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            esc.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            quest.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            bag.SetActive(true);
        }
        LevelP1.text = "Level " + ShowLevelP1;
        HPP1.text = "HP: " + ShowHPP1;
        MPP1.text = "MP: " + ShowMPP1;
        LevelP2.text = "Level " + ShowLevelP2;
        HPP2.text = "HP: " + ShowHPP2;
        MPP2.text = "MP: " + ShowMPP2;
        Zen.text = ShowZen + " ";
        if (CutscenesController.cus3 == 0)
        {
            QT.text = "Go to the Zexel town on the west side of the Wishing hill";
        }
        else if (CutscenesController.cus4 == 0)
            QT.text = "Let's go to the tavern of Zexel town. It's near the fountain on the west side of town";
        else if (CutscenesController.cus6 == 0)
            QT.text = "Make a heal potion by using a cauldron in the save room the report to Mr. Lance. The ingredient include dried leaves and pure water";
        else if (CutscenesController.cus7 == 0 && GlobalQuest.KillGoblinQuest < 4)
            QT.text = "There are a few goblins destroying the village southwest of zexel town. Let's beat them. Process: " + GlobalQuest.KillGoblinQuest.ToString() + "/4";
        else if (CutscenesController.cus7 == 0 && GlobalQuest.KillGoblinQuest == 4)
            QT.text = "There are a few goblins destroying the village southwest of zexel town. Let's beat them. Process: " + GlobalQuest.KillGoblinQuest.ToString() + "/4" + " Go back to the tavern to report the situation to Mr. Lance";
        else if (CutscenesController.cus9 == 0)
            QT.text = "Synthesize elixir by mixing heal potion and mana potion. Then give that to the villagers whose crops are broken. Process: " + GlobalQuest.HelpVillagerDone.ToString() + "/3";
        else if (CutscenesController.cus11 == 0)
            QT.text = "Go to wishing forest to find Maria, she may know Dante infomation. Wishing forest is in the southwest of the Zexel town";
        else if (CutscenesController.cus12 == 0)
            QT.text = "Collect 3 mana gems to give to Maria. Mana gem can be found by defeating the golems south of the forest of wishes";

        num1.text = ContainerController.DriedLeaves + "";
        num2.text = ContainerController.MorningDrop + "";
        num3.text = ContainerController.PureWater + "";
        num4.text = ContainerController.Iron + "";
        num5.text = ContainerController.ManaGem + "";

        numi1.text = ContainerController.HealPotion + "";
        numi2.text = ContainerController.ManaPotion + "";
        numi3.text = ContainerController.ElixirPotion + "";
        numi4.text = ContainerController.Bom + "";

        /*if (PlayerPrefs.GetInt("SDL") > 0)
        {
            showDL.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SMD") > 0)
        {
            showMD.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SPW") > 0)
        {
            showPW.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SI") > 0)
        {
            showI.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SMG") > 0)
        {
            showMG.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SHP") > 0)
        {
            showHP.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SMP") > 0)
        {
            showMP.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SEP") > 0)
        {
            showEP.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SB") > 0)
        {
            showB.SetActive(true);
        }*/
    }
    public void Back1()
    {
        map.SetActive(false);
    }
    public void Back2()
    {
        info.SetActive(false);
    }
    public void Back3()
    {
        quest.SetActive(false);
    }
    public void Back4()
    {
        bag.SetActive(false);
    }
    public void BackToGame()
    {
        esc.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
