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
        if(PlayerPrefs.GetInt("DTakeD") == 0)
        {
            ShowLevelP1 = PlayerPrefs.GetInt("SLevelP1");
            ShowHPP1 = PlayerPrefs.GetInt("SMaxHPP1");
            ShowMPP1 = PlayerPrefs.GetInt("SMaxMPP1");
            ShowLevelP2 = PlayerPrefs.GetInt("SLevelP2");
            ShowHPP2 = PlayerPrefs.GetInt("SMaxHPP2");
            ShowMPP2 = PlayerPrefs.GetInt("SMaxMPP2");
            //ShowHPP3 = PlayerPrefs.GetInt("SHPP3");
            //ShowMPP3 = PlayerPrefs.GetInt("SMPP3");
            ShowZen = PlayerPrefs.GetInt("SZen");
        }
        else if(PlayerPrefs.GetInt("DTakeD") == 1)
        {
            ShowLevelP1 = PlayerPrefs.GetInt("AfterLevelP1");
            ShowHPP1 = PlayerPrefs.GetInt("AfterHPP1");
            ShowMPP1 = PlayerPrefs.GetInt("AfterMPP1");
            ShowLevelP2 = PlayerPrefs.GetInt("AfterLevelP2");
            ShowHPP2 = PlayerPrefs.GetInt("AfterHPP2");
            ShowMPP2 = PlayerPrefs.GetInt("AfterMPP2");
            //ShowHPP3 = PlayerPrefs.GetInt("AfterHPP3");
            //ShowMPP3 = PlayerPrefs.GetInt("AfterMPP3");
            ShowZen = PlayerPrefs.GetInt("AfterZen");
        }
        if(PlayerPrefs.GetInt("cus1") == 1)
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
        if (PlayerPrefs.GetInt("cus3") == 0)
        {
            QT.text = "Go to the Zexel town on the west side of the Wishing hill";
        }
        else if (PlayerPrefs.GetInt("cus4") == 0)
            QT.text = "Let's go to the tavern of Zexel town. It's near the fountain on the west side of town";
        else if (PlayerPrefs.GetInt("cus6") == 0)
            QT.text = "Make a heal potion by using a cauldron in the save room the report to Mr. Lance. The ingredient include dried leaves and pure water";
        else if (PlayerPrefs.GetInt("cus7") == 0 && PlayerPrefs.GetInt("KGQ") < 4)
            QT.text = "There are a few goblins destroying the village southwest of zexel town. Let's beat them. Process: " + PlayerPrefs.GetInt("SKGQ").ToString() + "/4";
        else if (PlayerPrefs.GetInt("cus7") == 0 && PlayerPrefs.GetInt("KGQ") == 4)
            QT.text = "There are a few goblins destroying the village southwest of zexel town. Let's beat them. Process: " + PlayerPrefs.GetInt("SKGQ").ToString() + "/4" + " Go back to the tavern to report the situation to Mr. Lance";
        else if (PlayerPrefs.GetInt("cus9") == 0)
            QT.text = "Synthesize elixir by mixing heal potion and mana potion. Then give that to the villagers whose crops are broken. Process: " + PlayerPrefs.GetInt("HV").ToString() + "/3";
        else if (PlayerPrefs.GetInt("cus11") == 0)
            QT.text = "Go to wishing forest to find Maria, she may know Dante infomation. Wishing forest is in the southwest of the Zexel town";
        else if (PlayerPrefs.GetInt("cus12") == 0)
            QT.text = "Collect 3 mana gems to give to Maria. Mana gem can be found by defeating the golems south of the forest of wishes";
        num1.text = PlayerPrefs.GetInt("SDL") + "";
        num2.text = PlayerPrefs.GetInt("SMD") + "";
        num3.text = PlayerPrefs.GetInt("SPW") + "";
        num4.text = PlayerPrefs.GetInt("SI") + "";
        num5.text = PlayerPrefs.GetInt("SMG") + "";
        numi1.text = PlayerPrefs.GetInt("SHP") + "";
        numi2.text = PlayerPrefs.GetInt("SMP") + "";
        numi3.text = PlayerPrefs.GetInt("SEP") + "";
        numi4.text = PlayerPrefs.GetInt("SB") + "";
        if (PlayerPrefs.GetInt("SDL") > 0)
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
        }
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
