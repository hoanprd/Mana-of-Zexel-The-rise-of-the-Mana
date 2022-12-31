using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HubController : MonoBehaviour
{
    MenuController mc;
    public GameObject map;
    public GameObject[] MapArrow;
    public Text[] MapText;
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
    public GameObject MariaInfo;
    public Text LevelP1;
    public Text HPP1;
    public Text MPP1;
    public Text LevelP2;
    public Text HPP2;
    public Text MPP2;
    public Text LevelP3;
    public Text HPP3;
    public Text MPP3;
    public Text Zen;
    public Text QT;
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public Text num5, num6, num7;
    public Text numi1;
    public Text numi2;
    public Text numi3;
    public Text numi4, numi5, numi6, numi7, numi8;
    public int ShowLevelP1, ShowLevelP2, ShowLevelP3, ShowHPP1, ShowHPP2, ShowHPP3, ShowMPP1, ShowMPP2, ShowMPP3, ShowZen;
    public GameObject ShowVayneDetailPanel, ShowAliaDetailPanel, ShowMariaDetailPanel;
    public GameObject DShowLevelP1, DShowAttackP1, DShowHPP1, DShowMPP1, DShowSpeedP1, DShowLevelP2, DShowAttackP2, DShowHPP2, DShowMPP2, DShowSpeedP2, DShowLevelP3, DShowAttackP3, DShowHPP3, DShowMPP3, DShowSpeedP3;
    public GameObject PointPlusP1, AttackPointPlusLvP1, HPPointPlusLvP1, MPPointPlusLvP1, SpeedPointPlusLvP1, AttackPointPlusInfoP1, HPPointPlusInfoP1, MPPointPlusInfoP1, SpeedPointPlusInfoP1;
    public GameObject PointPlusP2, AttackPointPlusLvP2, HPPointPlusLvP2, MPPointPlusLvP2, SpeedPointPlusLvP2, AttackPointPlusInfoP2, HPPointPlusInfoP2, MPPointPlusInfoP2, SpeedPointPlusInfoP2;
    public GameObject PointPlusP3, AttackPointPlusLvP3, HPPointPlusLvP3, MPPointPlusLvP3, SpeedPointPlusLvP3, AttackPointPlusInfoP3, HPPointPlusInfoP3, MPPointPlusInfoP3, SpeedPointPlusInfoP3;
    public GameObject ShowVayneWeaponEquip, ShowVayneArmorEquip, ShowAliaWeaponEquip, ShowAliaArmorEquip, ShowMariaWeaponEquip, ShowMariaArmorEquip;
    public GameObject[] VayneWI, VayneAI, AliaWI, AliaAI, MariaWI, MariaAI;
    public GameObject VayneW1, VayneW2, VayneW3, VayneA1, VayneA2, VayneA3, AliaW1, AliaW2, AliaW3, AliaA1, AliaA2, AliaA3, MariaW1, MariaW2, MariaW3, MariaA1, MariaA2, MariaA3;

    // Start is called before the first frame update
    void Start()
    {
        mc = FindObjectOfType<MenuController>();

        //Map detail
        for (int i = 0; i < MapArrow.Length; i++)
        {
            if (i == Player.MapIndex)
            {
                MapArrow[i].SetActive(true);
            }

            if (i == 0 && CutscenesController.cus1 == 1)
            {
                MapText[i].text = "Wishing hill";
            }
            else if (i == 1 && CutscenesController.cus3 == 1)
            {
                MapText[i].text = "Zexel town";
            }
            else if (i == 2 && CutscenesController.cus8 == 1)
            {
                MapText[i].text = "Wishing forest";
            }
            else if (i == 3 && CutscenesController.cus35 == 1)
            {
                MapText[i].text = "Inferno desert";
            }
            else if (i == 4 && CutscenesController.cus41 == 1)
            {
                MapText[i].text = "Zexel gate";
            }
            else if (i == 5)
            {
                MapText[i].text = "Mana gate";
            }
            else if (i == 6)
            {
                MapText[i].text = "Mana dimension";
            }
            else if (i == 7)
            {
                MapText[i].text = "Mana temple";
            }
            else if (i == 8)
            {
                MapText[i].text = "Inferno volcano";
            }
            else if (i == 9)
            {
                MapText[i].text = "Inferno ice";
            }
            else if (i == 10)
            {
                MapText[i].text = "Alta inferno";
            }
            else if (i == 11)
            {
                MapText[i].text = "Zexel temple";
            }
            else if (i == 12)
            {
                MapText[i].text = "Mana Cllif";
            }
            else
            {
                MapText[i].text = "???";
            }
        }

        ShowLevelP1 = Global.LevelP1;
        ShowHPP1 = Global.CurHPP1;
        ShowMPP1 = Global.CurMPP1;

        ShowLevelP2 = Global.LevelP2;
        ShowHPP2 = Global.CurHPP2;
        ShowMPP2 = Global.CurMPP2;

        ShowLevelP3 = Global.LevelP3;
        ShowHPP3 = Global.CurHPP3;
        ShowMPP3 = Global.CurMPP3;
        ShowZen = Global.Zen;
        
        if (CutscenesController.cus12 == 0)
        {
            MariaInfo.SetActive(false);
        }

        //Show detail
        ShowP1Detail();
        ShowP1Equip();
        ShowP2Detail();
        ShowP2Equip();
        ShowP3Detail();
        ShowP3Equip();
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

        LevelP3.text = "Level " + ShowLevelP3;
        HPP3.text = "HP: " + ShowHPP3;
        MPP3.text = "MP: " + ShowMPP3;

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
        else if (CutscenesController.cus13 == 0)
            QT.text = "Let's go back to the tavern to decipher the information";
        else if (CutscenesController.cus14 == 0)
            QT.text = "Something drove the golems away, find out the cause in the east wishing hill";
        else if (CutscenesController.cus15 == 0)
            QT.text = "Something drove the golems away, find out the cause in the east wishing hill";
        else if (CutscenesController.cus16 == 0)
            QT.text = "Collect threads and mana gems for Maria to create an alchemy tool to stop the iron golem";
        else if (CutscenesController.cus17 == 0)
            QT.text = "Let's go back to the tavern to decipher the information";
        else if (CutscenesController.cus18 == 0)
            QT.text = "Get information around town about the zexel temple";
        else if (CutscenesController.cus19 == 0)
            QT.text = "Let's make a heal potion and a mana cloth to help Klener";
        else if (CutscenesController.cus20 == 0)
            QT.text = "Let's go to the wishing forest and defeat some golems";
        else if (CutscenesController.cus21 == 0)
            QT.text = "Let's go back to the town's tavern";
        else if (CutscenesController.cus22 == 0)
            QT.text = "Craft a mana shield using alchemy to give to Klener";
        else if (CutscenesController.cus23 == 0)
            QT.text = "Let's make Vayne's unique porridge";
        else if (CutscenesController.cus24 == 0)
            QT.text = "Vayne is tired, go back to the save room to rest";
        else if (CutscenesController.cus25 == 0)
            QT.text = "Let's make a bomb on request Maria";
        else if (CutscenesController.cus26 == 0)
            QT.text = "Keep looking for information about the Zexel temple around town";
        else if (CutscenesController.cus27 == 0)
            QT.text = "Let's go to the blacksmith shop of Zexel town in the south";
        else if (CutscenesController.cus28 == 0)
            QT.text = "Let's collect Heerium some iron and mana gem . Iron: 0/3\nMana gem: 0/2";
        else if (CutscenesController.cus29 == 0)
            QT.text = "Let's go back to the tavern to prepare some equipment and wait for the weapon made by Heerium";
        else if (CutscenesController.cus30 == 0)
            QT.text = "Let's go back to the tavern to prepare some equipment and wait for the weapon made by Heerium";
        else if (CutscenesController.cus31 == 0)
            QT.text = "Prepare some missing equipment to continue the journey";
        else if (CutscenesController.cus32 == 0)
            QT.text = "Maria remembered a grocery store owner on the west side of town near a tavern";
        else if (CutscenesController.cus33 == 0)
            QT.text = "Let's collect some items for Orina. Mana string: 0/2\nIron: 0/3\n Wood: 0/2";
        else if (CutscenesController.cus34 == 0)
            QT.text = "Let's make our way to the inferno desert west of Zexel town";
        else if (CutscenesController.cus35 == 0)
            QT.text = "Let's make our way to the inferno desert west of Zexel town";

        num1.text = ContainerController.DriedLeaves + "";
        num2.text = ContainerController.MorningDrop + "";
        num3.text = ContainerController.PureWater + "";
        num4.text = ContainerController.Iron + "";
        num5.text = ContainerController.ManaGem + "";
        num6.text = ContainerController.String + "";
        num7.text = ContainerController.Wood + "";

        numi1.text = ContainerController.HealPotion + "";
        numi2.text = ContainerController.ManaPotion + "";
        numi3.text = ContainerController.ElixirPotion + "";
        numi4.text = ContainerController.Bom + "";
        numi5.text = ContainerController.HoliHP + "";
        numi6.text = ContainerController.HoliMP + "";
        numi7.text = ContainerController.UltraBom + "";
        numi8.text = ContainerController.ReincarnationLife + "";
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

    public void OpenAliaPanel()
    {
        ShowAliaDetailPanel.SetActive(true);
    }

    public void OpenMariaPanel()
    {
        ShowMariaDetailPanel.SetActive(true);
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

    public void ShowP2Detail()
    {
        DShowLevelP2.GetComponent<Text>().text = "Level " + Global.LevelP2;
        DShowAttackP2.GetComponent<Text>().text = "Attack: " + Global.DamageP2;
        DShowHPP2.GetComponent<Text>().text = "HP: " + Global.CurHPP2 + "/" + Global.MaxHPP2;
        DShowMPP2.GetComponent<Text>().text = "MP: " + Global.CurMPP2 + "/" + Global.MaxMPP2;
        DShowSpeedP2.GetComponent<Text>().text = "Speed: " + Global.SpeedP2;

        PointPlusP2.GetComponent<Text>().text = "Point: " + Global.PlusPointP2;
        AttackPointPlusLvP2.GetComponent<Text>().text = "" + Global.PlusPointAttackLvP2;
        HPPointPlusLvP2.GetComponent<Text>().text = "" + Global.PlusPointHPLvP2;
        MPPointPlusLvP2.GetComponent<Text>().text = "" + Global.PlusPointMPLvP2;
        SpeedPointPlusLvP2.GetComponent<Text>().text = "" + Global.PlusPointSpeedLvP2;

        AttackPointPlusInfoP2.GetComponent<Text>().text = "Attack (need 1): +" + Global.PlusPointAttackInfoP2;
        HPPointPlusInfoP2.GetComponent<Text>().text = "HP (need 1): +" + Global.PlusPointHPInfoP2;
        MPPointPlusInfoP2.GetComponent<Text>().text = "MP (need 1): +" + Global.PlusPointMPInfoP2;
        SpeedPointPlusInfoP2.GetComponent<Text>().text = "Speed (need 2): +" + Global.PlusPointSpeedInfoP2;
    }

    public void ShowP3Detail()
    {
        DShowLevelP3.GetComponent<Text>().text = "Level " + Global.LevelP3;
        DShowAttackP3.GetComponent<Text>().text = "Attack: " + Global.DamageP3;
        DShowHPP3.GetComponent<Text>().text = "HP: " + Global.CurHPP3 + "/" + Global.MaxHPP3;
        DShowMPP3.GetComponent<Text>().text = "MP: " + Global.CurMPP3 + "/" + Global.MaxMPP3;
        DShowSpeedP3.GetComponent<Text>().text = "Speed: " + Global.SpeedP3;

        PointPlusP3.GetComponent<Text>().text = "Point: " + Global.PlusPointP3;
        AttackPointPlusLvP3.GetComponent<Text>().text = "" + Global.PlusPointAttackLvP3;
        HPPointPlusLvP3.GetComponent<Text>().text = "" + Global.PlusPointHPLvP3;
        MPPointPlusLvP3.GetComponent<Text>().text = "" + Global.PlusPointMPLvP3;
        SpeedPointPlusLvP3.GetComponent<Text>().text = "" + Global.PlusPointSpeedLvP3;

        AttackPointPlusInfoP3.GetComponent<Text>().text = "Attack (need 1): +" + Global.PlusPointAttackInfoP3;
        HPPointPlusInfoP3.GetComponent<Text>().text = "HP (need 1): +" + Global.PlusPointHPInfoP3;
        MPPointPlusInfoP3.GetComponent<Text>().text = "MP (need 1): +" + Global.PlusPointMPInfoP3;
        SpeedPointPlusInfoP3.GetComponent<Text>().text = "Speed (need 2): +" + Global.PlusPointSpeedInfoP3;
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

    public void ShowP2Equip()
    {
        for (int i = 0; i < AliaWI.Length; i++)
        {
            if (i == Global.VayneWeaponStatus)
                AliaWI[i].SetActive(true);
            else
                AliaWI[i].SetActive(false);
        }

        AliaW1.GetComponent<Text>().text = "" + Global.AliaShoes1;
        AliaW2.GetComponent<Text>().text = "" + Global.AliaShoes2;
        AliaW3.GetComponent<Text>().text = "" + Global.AliaShoes3;

        AliaA1.GetComponent<Text>().text = "" + Global.WarriorArmor1;
        AliaA2.GetComponent<Text>().text = "" + Global.WarriorArmor1;
        AliaA3.GetComponent<Text>().text = "" + Global.WarriorArmor1;
    }

    public void ShowP3Equip()
    {
        for (int i = 0; i < MariaWI.Length; i++)
        {
            if (i == Global.MariaWeaponStatus)
                MariaWI[i].SetActive(true);
            else
                MariaWI[i].SetActive(false);
        }

        MariaW1.GetComponent<Text>().text = "" + Global.MariaCrystal1;
        MariaW2.GetComponent<Text>().text = "" + Global.MariaCrystal2;
        MariaW3.GetComponent<Text>().text = "" + Global.MariaCrystal3;

        MariaA1.GetComponent<Text>().text = "" + Global.AlchemistArmor1;
        MariaA2.GetComponent<Text>().text = "" + Global.AlchemistArmor2;
        MariaA3.GetComponent<Text>().text = "" + Global.AlchemistArmor3;
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

    public void AliaWeaponEquip()
    {
        ShowAliaArmorEquip.SetActive(false);
        ShowAliaWeaponEquip.SetActive(true);
    }

    //Equip Alia weapon
    public void AliaEquipW1()
    {
        if (Global.AliaWeaponStatus == 0 && Global.AliaShoes1 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 1)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 += 20;
            Global.AliaShoes1 -= 1;
            Global.AliaWeaponStatus = 1;
            ShowP2Detail();
        }
        else if (Global.AliaWeaponStatus == 2 && Global.AliaShoes1 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 1)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 -= 60;
            Global.DamageP2 += 20;
            Global.AliaShoes2 += 1;
            Global.AliaShoes1 -= 1;
            Global.AliaWeaponStatus = 1;
            ShowP2Detail();
        }
        else if (Global.AliaWeaponStatus == 3 && Global.AliaShoes1 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 1)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 -= 100;
            Global.DamageP2 += 20;
            Global.AliaShoes3 += 1;
            Global.AliaShoes1 -= 1;
            Global.AliaWeaponStatus = 1;
            ShowP2Detail();
        }
    }

    public void AliaEquipW2()
    {
        if (Global.AliaWeaponStatus == 0 && Global.AliaShoes2 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 2)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 += 60;
            Global.AliaShoes2 -= 1;
            Global.AliaWeaponStatus = 2;
            ShowP2Detail();
        }
        else if (Global.AliaWeaponStatus == 1 && Global.AliaShoes2 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 2)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 -= 20;
            Global.DamageP2 += 60;
            Global.AliaShoes1 += 1;
            Global.AliaShoes2 -= 1;
            Global.AliaWeaponStatus = 2;
            ShowP2Detail();
        }
        else if (Global.AliaWeaponStatus == 3 && Global.AliaShoes2 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 2)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 -= 100;
            Global.DamageP2 += 60;
            Global.AliaShoes3 += 1;
            Global.AliaShoes2 -= 1;
            Global.AliaWeaponStatus = 2;
            ShowP2Detail();
        }
    }

    public void AliaEquipW3()
    {
        if (Global.AliaWeaponStatus == 0 && Global.AliaShoes3 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 3)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 += 100;
            Global.AliaShoes3 -= 1;
            Global.AliaWeaponStatus = 3;
            ShowP2Detail();
        }
        else if (Global.AliaWeaponStatus == 1 && Global.AliaShoes3 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 3)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 -= 20;
            Global.DamageP2 += 100;
            Global.AliaShoes1 += 1;
            Global.AliaShoes3 -= 1;
            Global.AliaWeaponStatus = 3;
            ShowP2Detail();
        }
        else if (Global.AliaWeaponStatus == 2 && Global.AliaShoes3 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 3)
                {
                    AliaWI[i].SetActive(true);
                }
                else
                {
                    AliaWI[i].SetActive(false);
                }
            }
            Global.DamageP2 -= 60;
            Global.DamageP2 += 100;
            Global.AliaShoes2 += 1;
            Global.AliaShoes3 -= 1;
            Global.AliaWeaponStatus = 3;
            ShowP2Detail();
        }
    }

    public void AliaArmorEquip()
    {
        ShowAliaWeaponEquip.SetActive(false);
        ShowAliaArmorEquip.SetActive(true);
    }

    //Equip Alia armor
    public void AliaEquipA1()
    {
        if (Global.AliaArmorStatus == 0 && Global.WarriorArmor1 >= 1)
        {
            for (int i = 0; i < AliaAI.Length; i++)
            {
                if (i == 1)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 += 100;
            Global.WarriorArmor1 -= 1;
            Global.AliaArmorStatus = 1;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 2 && Global.WarriorArmor1 >= 1)
        {
            for (int i = 0; i < AliaAI.Length; i++)
            {
                if (i == 1)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 -= 300;
            Global.MaxHPP2 += 100;
            Global.WarriorArmor2 += 1;
            Global.WarriorArmor1 -= 1;
            Global.AliaArmorStatus = 1;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 3 && Global.WarriorArmor1 >= 1)
        {
            for (int i = 0; i < AliaAI.Length; i++)
            {
                if (i == 1)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 -= 500;
            Global.MaxHPP2 += 100;
            Global.WarriorArmor3 += 1;
            Global.WarriorArmor1 -= 1;
            Global.AliaArmorStatus = 1;
            ShowP2Detail();
        }
    }

    public void AliaEquipA2()
    {
        if (Global.AliaArmorStatus == 0 && Global.WarriorArmor2 >= 1)
        {
            for (int i = 0; i < AliaAI.Length; i++)
            {
                if (i == 2)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 += 300;
            Global.WarriorArmor2 -= 1;
            Global.AliaArmorStatus = 2;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 1 && Global.WarriorArmor2 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 2)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 -= 100;
            Global.MaxHPP2 += 300;
            Global.WarriorArmor1 += 1;
            Global.WarriorArmor2 -= 1;
            Global.AliaArmorStatus = 2;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 3 && Global.WarriorArmor2 >= 1)
        {
            for (int i = 0; i < AliaWI.Length; i++)
            {
                if (i == 2)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 -= 500;
            Global.MaxHPP2 += 300;
            Global.WarriorArmor3 += 1;
            Global.WarriorArmor2 -= 1;
            Global.AliaArmorStatus = 2;
            ShowP2Detail();
        }
    }

    public void AliaEquipA3()
    {
        if (Global.AliaArmorStatus == 0 && Global.WarriorArmor3 >= 1)
        {
            for (int i = 0; i < AliaAI.Length; i++)
            {
                if (i == 3)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 += 500;
            Global.WarriorArmor3 -= 1;
            Global.AliaArmorStatus = 3;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 1 && Global.WarriorArmor3 >= 1)
        {
            for (int i = 0; i < AliaAI.Length; i++)
            {
                if (i == 3)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 -= 100;
            Global.MaxHPP2 += 500;
            Global.WarriorArmor1 += 1;
            Global.WarriorArmor3 -= 1;
            Global.AliaArmorStatus = 3;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 2 && Global.WarriorArmor3 >= 1)
        {
            for (int i = 0; i < AliaAI.Length; i++)
            {
                if (i == 3)
                {
                    AliaAI[i].SetActive(true);
                }
                else
                {
                    AliaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP2 -= 300;
            Global.MaxHPP2 += 500;
            Global.WarriorArmor2 += 1;
            Global.WarriorArmor3 -= 1;
            Global.AliaArmorStatus = 3;
            ShowP2Detail();
        }
    }

    public void MariaWeaponEquip()
    {
        ShowMariaArmorEquip.SetActive(false);
        ShowMariaWeaponEquip.SetActive(true);
    }

    //Equip Maria weapon
    public void MariaEquipW1()
    {
        if (Global.MariaWeaponStatus == 0 && Global.MariaCrystal1 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 1)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 += 20;
            Global.MariaCrystal1 -= 1;
            Global.MariaWeaponStatus = 1;
            ShowP3Detail();
        }
        else if (Global.MariaWeaponStatus == 2 && Global.MariaCrystal1 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 1)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 -= 60;
            Global.DamageP3 += 20;
            Global.MariaCrystal2 += 1;
            Global.MariaCrystal1 -= 1;
            Global.MariaWeaponStatus = 1;
            ShowP3Detail();
        }
        else if (Global.MariaWeaponStatus == 3 && Global.MariaCrystal1 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 1)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 -= 100;
            Global.DamageP3 += 20;
            Global.MariaCrystal3 += 1;
            Global.MariaCrystal1 -= 1;
            Global.MariaWeaponStatus = 1;
            ShowP3Detail();
        }
    }

    public void MariaEquipW2()
    {
        if (Global.MariaWeaponStatus == 0 && Global.MariaCrystal2 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 2)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 += 60;
            Global.MariaCrystal2 -= 1;
            Global.MariaWeaponStatus = 2;
            ShowP3Detail();
        }
        else if (Global.MariaWeaponStatus == 1 && Global.MariaCrystal2 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 2)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 -= 20;
            Global.DamageP3 += 60;
            Global.MariaCrystal1 += 1;
            Global.MariaCrystal2 -= 1;
            Global.MariaWeaponStatus = 2;
            ShowP3Detail();
        }
        else if (Global.MariaWeaponStatus == 3 && Global.MariaCrystal2 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 2)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 -= 100;
            Global.DamageP3 += 60;
            Global.MariaCrystal3 += 1;
            Global.MariaCrystal2 -= 1;
            Global.MariaWeaponStatus = 2;
            ShowP3Detail();
        }
    }

    public void MariaEquipW3()
    {
        if (Global.MariaWeaponStatus == 0 && Global.MariaCrystal3 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 3)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 += 100;
            Global.MariaCrystal3 -= 1;
            Global.MariaWeaponStatus = 3;
            ShowP3Detail();
        }
        else if (Global.MariaWeaponStatus == 1 && Global.MariaCrystal3 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 3)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 -= 20;
            Global.DamageP3 += 100;
            Global.MariaCrystal1 += 1;
            Global.MariaCrystal3 -= 1;
            Global.MariaWeaponStatus = 3;
            ShowP3Detail();
        }
        else if (Global.MariaWeaponStatus == 2 && Global.MariaCrystal3 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 3)
                {
                    MariaWI[i].SetActive(true);
                }
                else
                {
                    MariaWI[i].SetActive(false);
                }
            }
            Global.DamageP3 -= 60;
            Global.DamageP3 += 100;
            Global.MariaCrystal2 += 1;
            Global.MariaCrystal3 -= 1;
            Global.MariaWeaponStatus = 3;
            ShowP3Detail();
        }
    }

    public void MariaArmorEquip()
    {
        ShowMariaArmorEquip.SetActive(true);
        ShowMariaWeaponEquip.SetActive(false);
    }

    //Equip Maria armor
    public void MariaEquipA1()
    {
        if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor1 >= 1)
        {
            for (int i = 0; i < MariaAI.Length; i++)
            {
                if (i == 1)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 += 100;
            Global.AlchemistArmor1 -= 1;
            Global.MariaArmorStatus = 1;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 2 && Global.AlchemistArmor1 >= 1)
        {
            for (int i = 0; i < MariaAI.Length; i++)
            {
                if (i == 1)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 -= 300;
            Global.MaxHPP3 += 100;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.MariaArmorStatus = 1;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 3 && Global.AlchemistArmor1 >= 1)
        {
            for (int i = 0; i < MariaAI.Length; i++)
            {
                if (i == 1)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 -= 500;
            Global.MaxHPP3 += 100;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.MariaArmorStatus = 1;
            ShowP3Detail();
        }
    }

    public void MariaEquipA2()
    {
        if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor2 >= 1)
        {
            for (int i = 0; i < MariaAI.Length; i++)
            {
                if (i == 2)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 += 300;
            Global.AlchemistArmor2 -= 1;
            Global.MariaArmorStatus = 2;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 1 && Global.AlchemistArmor2 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 2)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 -= 100;
            Global.MaxHPP3 += 300;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.MariaArmorStatus = 2;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 3 && Global.AlchemistArmor2 >= 1)
        {
            for (int i = 0; i < MariaWI.Length; i++)
            {
                if (i == 2)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 -= 500;
            Global.MaxHPP3 += 300;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.MariaArmorStatus = 2;
            ShowP3Detail();
        }
    }

    public void MariaEquipA3()
    {
        if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor3 >= 1)
        {
            for (int i = 0; i < MariaAI.Length; i++)
            {
                if (i == 3)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 += 500;
            Global.AlchemistArmor3 -= 1;
            Global.MariaArmorStatus = 3;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 1 && Global.AlchemistArmor3 >= 1)
        {
            for (int i = 0; i < MariaAI.Length; i++)
            {
                if (i == 3)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 -= 100;
            Global.MaxHPP3 += 500;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.MariaArmorStatus = 3;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 2 && Global.AlchemistArmor3 >= 1)
        {
            for (int i = 0; i < MariaAI.Length; i++)
            {
                if (i == 3)
                {
                    MariaAI[i].SetActive(true);
                }
                else
                {
                    MariaAI[i].SetActive(false);
                }
            }
            Global.MaxHPP3 -= 300;
            Global.MaxHPP3 += 500;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.MariaArmorStatus = 3;
            ShowP3Detail();
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

    //Plus Alia point
    public void PlusAttackP2()
    {
        if (Global.PlusPointP2 >= 1)
        {
            Global.PlusPointP2 -= 1;
            Global.DamageP2 += 2;
            Global.PlusPointAttackLvP2 += 1;
            Global.PlusPointAttackInfoP2 += 2;
            ShowP2Detail();
        }
    }

    public void PlusHPP2()
    {
        if (Global.PlusPointP2 >= 1)
        {
            Global.PlusPointP2 -= 1;
            Global.MaxHPP2 += 5;
            Global.PlusPointHPLvP2 += 1;
            Global.PlusPointHPInfoP2 += 5;
            ShowP2Detail();
        }
    }

    public void PlusMPP2()
    {
        if (Global.PlusPointP2 >= 1)
        {
            Global.PlusPointP2 -= 1;
            Global.MaxMPP2 += 2;
            Global.PlusPointMPLvP2 += 1;
            Global.PlusPointMPInfoP2 += 2;
            ShowP2Detail();
        }
    }

    public void PlusSpeedP2()
    {
        if (Global.PlusPointP2 >= 2)
        {
            Global.PlusPointP2 -= 1;
            Global.SpeedP2 += 1;
            Global.PlusPointSpeedLvP2 += 1;
            Global.PlusPointSpeedInfoP2 += 1;
            ShowP2Detail();
        }
    }

    //Plus Maria point
    public void PlusAttackP3()
    {
        if (Global.PlusPointP3 >= 1)
        {
            Global.PlusPointP3 -= 1;
            Global.DamageP3 += 2;
            Global.PlusPointAttackLvP3 += 1;
            Global.PlusPointAttackInfoP3 += 2;
            ShowP3Detail();
        }
    }

    public void PlusHPP3()
    {
        if (Global.PlusPointP3 >= 1)
        {
            Global.PlusPointP3 -= 1;
            Global.MaxHPP3 += 5;
            Global.PlusPointHPLvP3 += 1;
            Global.PlusPointHPInfoP3 += 5;
            ShowP3Detail();
        }
    }

    public void PlusMPP3()
    {
        if (Global.PlusPointP3 >= 1)
        {
            Global.PlusPointP3 -= 1;
            Global.MaxMPP2 += 3;
            Global.PlusPointMPLvP3 += 1;
            Global.PlusPointMPInfoP3 += 2;
            ShowP3Detail();
        }
    }

    public void PlusSpeedP3()
    {
        if (Global.PlusPointP3 >= 2)
        {
            Global.PlusPointP3 -= 1;
            Global.SpeedP3 += 1;
            Global.PlusPointSpeedLvP3 += 1;
            Global.PlusPointSpeedInfoP3 += 1;
            ShowP3Detail();
        }
    }

    public void CloseVaynePanel()
    {
        ShowVayneDetailPanel.SetActive(false);
        ShowVayneWeaponEquip.SetActive(false);
        ShowVayneArmorEquip.SetActive(false);
    }

    public void CloseAliaPanel()
    {
        ShowAliaDetailPanel.SetActive(false);
        ShowAliaWeaponEquip.SetActive(false);
        ShowAliaArmorEquip.SetActive(false);
    }

    public void CloseMariaPanel()
    {
        ShowMariaDetailPanel.SetActive(false);
        ShowMariaWeaponEquip.SetActive(false);
        ShowMariaArmorEquip.SetActive(false);
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
