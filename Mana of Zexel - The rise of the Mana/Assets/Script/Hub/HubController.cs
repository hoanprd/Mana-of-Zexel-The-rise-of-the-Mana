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
    public GameObject ShowVayneDetailPanel;
    public GameObject DShowLevelP1, DShowAttackP1, DShowHPP1, DShowMPP1, DShowSpeedP1;
    public GameObject PointPlusP1, AttackPointPlusLvP1, HPPointPlusLvP1, MPPointPlusLvP1, SpeedPointPlusLvP1, AttackPointPlusInfoP1, HPPointPlusInfoP1, MPPointPlusInfoP1, SpeedPointPlusInfoP1;
    public GameObject ShowVayneWeaponEquip, ShowVayneArmorEquip;
    public GameObject[] VayneWI, VayneAI;
    public GameObject VayneW1, VayneW2, VayneW3, VayneA1, VayneA2, VayneA3;

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

        //Show detail
        ShowP1Detail();
        ShowP1Equip();
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
    public void OpenVaynePanel()
    {
        ShowVayneDetailPanel.SetActive(true);
    }

    public void ShowP1Detail()
    {
        DShowLevelP1.GetComponent<Text>().text = "Level " + Global.LevelP1;
        DShowAttackP1.GetComponent<Text>().text = "Attack: " + Global.DamageP1;
        DShowHPP1.GetComponent<Text>().text = "HP: " + Global.CurHPP1 + "/" + Global.MaxHPP1;
        DShowMPP1.GetComponent<Text>().text = "MP: " + Global.CurMPP1 + "/" + Global.MaxMPP1;
        DShowSpeedP1.GetComponent<Text>().text = "Speed: " + Global.SpeedP1;

        PointPlusP1.GetComponent<Text>().text = "Point: " + Global.PlusPointP1;
        AttackPointPlusLvP1.GetComponent<Text>().text = "" + Global.PlusPointAttackLvP1;
        HPPointPlusLvP1.GetComponent<Text>().text = "" + Global.PlusPointHPLvP1;
        MPPointPlusLvP1.GetComponent<Text>().text = "" + Global.PlusPointMPLvP1;
        SpeedPointPlusLvP1.GetComponent<Text>().text = "" + Global.PlusPointSpeedLvP1;

        AttackPointPlusInfoP1.GetComponent<Text>().text = "Attack (need 1): +" + Global.PlusPointAttackInfoP1;
        HPPointPlusInfoP1.GetComponent<Text>().text = "HP (need 1): +" + Global.PlusPointHPInfoP1;
        MPPointPlusInfoP1.GetComponent<Text>().text = "MP (need 1): +" + Global.PlusPointMPInfoP1;
        SpeedPointPlusInfoP1.GetComponent<Text>().text = "Speed (need 2): +" + Global.PlusPointSpeedInfoP1;
    }

    public void ShowP1Equip()
    {
        for (int i = 0; i < VayneWI.Length; i++)
        {
            if (i == Global.VayneWeaponStatus)
                VayneWI[i].SetActive(true);
            else
                VayneWI[i].SetActive(false);
        }

        VayneW1.GetComponent<Text>().text = "" + Global.VayneStaff1;
        VayneW2.GetComponent<Text>().text = "" + Global.VayneStaff2;
        VayneW3.GetComponent<Text>().text = "" + Global.VayneStaff3;

        VayneA1.GetComponent<Text>().text = "" + Global.AlchemistArmor1;
        VayneA2.GetComponent<Text>().text = "" + Global.AlchemistArmor2;
        VayneA3.GetComponent<Text>().text = "" + Global.AlchemistArmor3;
    }

    public void VayneWeaponEquip()
    {
        ShowVayneArmorEquip.SetActive(false);
        ShowVayneWeaponEquip.SetActive(true);
    }

    //Equip Vayne weapon
    public void VayneEquipW1()
    {
        if (Global.VayneWeaponStatus == 0 && Global.VayneStaff1 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if(i == 1)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 += 20;
            Global.VayneStaff1 -= 1;
            Global.VayneWeaponStatus = 1;
            ShowP1Detail();
        }
        else if (Global.VayneWeaponStatus == 2 && Global.VayneStaff1 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 1)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 -= 60;
            Global.DamageP1 += 20;
            Global.VayneStaff2 += 1;
            Global.VayneStaff1 -= 1;
            Global.VayneWeaponStatus = 1;
            ShowP1Detail();
        }
        else if (Global.VayneWeaponStatus == 3 && Global.VayneStaff1 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 1)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 -= 100;
            Global.DamageP1 += 20;
            Global.VayneStaff3 += 1;
            Global.VayneStaff1 -= 1;
            Global.VayneWeaponStatus = 1;
            ShowP1Detail();
        }
    }

    public void VayneEquipW2()
    {
        if (Global.VayneWeaponStatus == 0 && Global.VayneStaff2 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 2)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 += 60;
            Global.VayneStaff2 -= 1;
            Global.VayneWeaponStatus = 2;
            ShowP1Detail();
        }
        else if (Global.VayneWeaponStatus == 1 && Global.VayneStaff2 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 2)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 -= 20;
            Global.DamageP1 += 60;
            Global.VayneStaff1 += 1;
            Global.VayneStaff2 -= 1;
            Global.VayneWeaponStatus = 2;
            ShowP1Detail();
        }
        else if (Global.VayneWeaponStatus == 3 && Global.VayneStaff2 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 2)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 -= 100;
            Global.DamageP1 += 60;
            Global.VayneStaff3 += 1;
            Global.VayneStaff2 -= 1;
            Global.VayneWeaponStatus = 2;
            ShowP1Detail();
        }
    }

    public void VayneEquipW3()
    {
        if (Global.VayneWeaponStatus == 0 && Global.VayneStaff3 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 3)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 += 100;
            Global.VayneStaff3 -= 1;
            Global.VayneWeaponStatus = 3;
            ShowP1Detail();
        }
        else if (Global.VayneWeaponStatus == 1 && Global.VayneStaff3 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 3)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 -= 20;
            Global.DamageP1 += 100;
            Global.VayneStaff1 += 1;
            Global.VayneStaff3 -= 1;
            Global.VayneWeaponStatus = 3;
            ShowP1Detail();
        }
        else if (Global.VayneWeaponStatus == 2 && Global.VayneStaff3 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 3)
                {
                    VayneWI[i].SetActive(true);
                }
                else
                {
                    VayneWI[i].SetActive(false);
                }
            }
            Global.DamageP1 -= 60;
            Global.DamageP1 += 100;
            Global.VayneStaff2 += 1;
            Global.VayneStaff3 -= 1;
            Global.VayneWeaponStatus = 3;
            ShowP1Detail();
        }
    }

    public void VayneArmorEquip()
    {
        ShowVayneWeaponEquip.SetActive(false);
        ShowVayneArmorEquip.SetActive(true);
    }

    //Equip Vayne armor
    public void VayneEquipA1()
    {
        if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor1 >= 1)
        {
            for (int i = 0; i < VayneAI.Length; i++)
            {
                if (i == 1)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 += 100;
            Global.AlchemistArmor1 -= 1;
            Global.VayneArmorStatus = 1;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 2 && Global.AlchemistArmor1 >= 1)
        {
            for (int i = 0; i < VayneAI.Length; i++)
            {
                if (i == 1)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 -= 300;
            Global.MaxHPP1 += 100;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.VayneArmorStatus = 1;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 3 && Global.AlchemistArmor1 >= 1)
        {
            for (int i = 0; i < VayneAI.Length; i++)
            {
                if (i == 1)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 -= 500;
            Global.MaxHPP1 += 100;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.VayneArmorStatus = 1;
            ShowP1Detail();
        }
    }

    public void VayneEquipA2()
    {
        if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor2 >= 1)
        {
            for (int i = 0; i < VayneAI.Length; i++)
            {
                if (i == 2)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 += 300;
            Global.AlchemistArmor2 -= 1;
            Global.VayneArmorStatus = 2;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 1 && Global.AlchemistArmor2 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 2)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 -= 100;
            Global.MaxHPP1 += 300;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.VayneArmorStatus = 2;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 3 && Global.AlchemistArmor2 >= 1)
        {
            for (int i = 0; i < VayneWI.Length; i++)
            {
                if (i == 2)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 -= 500;
            Global.MaxHPP1 += 300;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.VayneArmorStatus = 2;
            ShowP1Detail();
        }
    }

    public void VayneEquipA3()
    {
        if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor3 >= 1)
        {
            for (int i = 0; i < VayneAI.Length; i++)
            {
                if (i == 3)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 += 500;
            Global.AlchemistArmor3 -= 1;
            Global.VayneArmorStatus = 3;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 1 && Global.AlchemistArmor3 >= 1)
        {
            for (int i = 0; i < VayneAI.Length; i++)
            {
                if (i == 3)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 -= 100;
            Global.MaxHPP1 += 500;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.VayneArmorStatus = 3;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 2 && Global.AlchemistArmor3 >= 1)
        {
            for (int i = 0; i < VayneAI.Length; i++)
            {
                if (i == 3)
                {
                    VayneAI[i].SetActive(true);
                }
                else
                {
                    VayneAI[i].SetActive(false);
                }
            }
            Global.MaxHPP1 -= 300;
            Global.MaxHPP1 += 500;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.VayneArmorStatus = 3;
            ShowP1Detail();
        }
    }

    //Plus Vayne point
    public void PlusAttackP1()
    {
        if (Global.PlusPointP1 >= 1)
        {
            Global.PlusPointP1 -= 1;
            Global.DamageP1 += 2;
            Global.PlusPointAttackLvP1 += 1;
            Global.PlusPointAttackInfoP1 += 2;
            ShowP1Detail();
        }
    }

    public void PlusHPP1()
    {
        if (Global.PlusPointP1 >= 1)
        {
            Global.PlusPointP1 -= 1;
            Global.MaxHPP1 += 5;
            Global.PlusPointHPLvP1 += 1;
            Global.PlusPointHPInfoP1 += 5;
            ShowP1Detail();
        }
    }

    public void PlusMPP1()
    {
        if (Global.PlusPointP1 >= 1)
        {
            Global.PlusPointP1 -= 1;
            Global.MaxMPP1 += 2;
            Global.PlusPointMPLvP1 += 1;
            Global.PlusPointMPInfoP1 += 2;
            ShowP1Detail();
        }
    }

    public void PlusSpeedP1()
    {
        if (Global.PlusPointP1 >= 2)
        {
            Global.PlusPointP1 -= 1;
            Global.SpeedP1 += 1;
            Global.PlusPointSpeedLvP1 += 1;
            Global.PlusPointSpeedInfoP1 += 1;
            ShowP1Detail();
        }
    }

    public void CloseVaynePanel()
    {
        ShowVayneDetailPanel.SetActive(false);
        ShowVayneWeaponEquip.SetActive(false);
        ShowVayneArmorEquip.SetActive(false);
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
