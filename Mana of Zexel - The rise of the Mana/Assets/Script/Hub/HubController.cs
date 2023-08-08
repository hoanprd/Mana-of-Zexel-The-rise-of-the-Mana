using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HubController : MonoBehaviour
{
    public AudioSource ClickHubFX, OpenHubFX, EquipFX;

    public GameObject map;
    public GameObject[] MapArrow;
    public Text[] MapText;
    public GameObject info;
    public GameObject quest;
    public GameObject esc;
    public GameObject MariaInfo;
    public GameObject EquipTextVayne, EquipTextAlia, EquipTextMaria;
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
    public int ShowLevelP1, ShowLevelP2, ShowLevelP3, ShowHPP1, ShowHPP2, ShowHPP3, ShowMPP1, ShowMPP2, ShowMPP3, ShowZen;
    public int PlusPointIndex;
    public static bool BusyHub;
    public GameObject ShowVayneDetailPanel, ShowAliaDetailPanel, ShowMariaDetailPanel;
    public GameObject DShowLevelP1, DShowAttackP1, DShowHPP1, DShowMPP1, DShowSpeedP1, DShowLevelP2, DShowAttackP2, DShowHPP2, DShowMPP2, DShowSpeedP2, DShowLevelP3, DShowAttackP3, DShowHPP3, DShowMPP3, DShowSpeedP3;
    public GameObject PointPlusP1, AttackPointPlusLvP1, HPPointPlusLvP1, MPPointPlusLvP1, SpeedPointPlusLvP1, AttackPointPlusInfoP1, HPPointPlusInfoP1, MPPointPlusInfoP1, SpeedPointPlusInfoP1;
    public GameObject PointPlusP2, AttackPointPlusLvP2, HPPointPlusLvP2, MPPointPlusLvP2, SpeedPointPlusLvP2, AttackPointPlusInfoP2, HPPointPlusInfoP2, MPPointPlusInfoP2, SpeedPointPlusInfoP2;
    public GameObject PointPlusP3, AttackPointPlusLvP3, HPPointPlusLvP3, MPPointPlusLvP3, SpeedPointPlusLvP3, AttackPointPlusInfoP3, HPPointPlusInfoP3, MPPointPlusInfoP3, SpeedPointPlusInfoP3;
    public GameObject ConfirmPlusPointVaynePanel, ConfirmPlusPointAliaPanel, ConfirmPlusPointMariaPanel;
    public GameObject ShowVayneWeaponEquip, ShowVayneArmorEquip, ShowAliaWeaponEquip, ShowAliaArmorEquip, ShowMariaWeaponEquip, ShowMariaArmorEquip;
    public GameObject[] VayneWI, VayneAI, AliaWI, AliaAI, MariaWI, MariaAI;
    public GameObject VayneEmptySlotW1, VayneEmptySlotW2, VayneEmptySlotW3, VayneEmptySlotA1, VayneEmptySlotA2, VayneEmptySlotA3, AliaEmptySlotW1, AliaEmptySlotW2, AliaEmptySlotW3, AliaEmptySlotA1, AliaEmptySlotA2, AliaEmptySlotA3, MariaEmptySlotW1, MariaEmptySlotW2, MariaEmptySlotW3, MariaEmptySlotA1, MariaEmptySlotA2, MariaEmptySlotA3, VayneW1, VayneW2, VayneW3, VayneA1, VayneA2, VayneA3, AliaW1, AliaW2, AliaW3, AliaA1, AliaA2, AliaA3, MariaW1, MariaW2, MariaW3, MariaA1, MariaA2, MariaA3;
    public GameObject Bag;
    public GameObject TimePanel, HubPanel;

    // Start is called before the first frame update
    void Start()
    {
        BusyHub = false;

        if (ContainerController.stop != 1)
        {
            ContainerController.stop = 1;
            Instantiate(Bag);
        }

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
            else if (i == 5 && CutscenesController.cus50 == 1)
            {
                MapText[i].text = "Mana gate";
            }
            else if (i == 6 && CutscenesController.cus52 == 1)
            {
                MapText[i].text = "Mana dimension";
            }
            else if (i == 7 && CutscenesController.cus54 == 1)
            {
                MapText[i].text = "Mana temple";
            }
            else if (i == 8 && CutscenesController.cus58 == 1)
            {
                MapText[i].text = "Inferno volcano";
            }
            else if (i == 9 && CutscenesController.cus64 == 1)
            {
                MapText[i].text = "Inferno ice";
            }
            else if (i == 10 && CutscenesController.cus79 == 1)
            {
                MapText[i].text = "Alta inferno";
            }
            else if (i == 11 && CutscenesController.cus88 == 1)
            {
                MapText[i].text = "Zexel temple";
            }
            else if (i == 12 && CutscenesController.cus94 == 1)
            {
                MapText[i].text = "Mana Cllif";
            }
            else
            {
                MapText[i].text = "???";
            }
        }

        /*ShowLevelP1 = Global.LevelP1;
        ShowHPP1 = Global.CurHPP1;
        ShowMPP1 = Global.CurMPP1;

        ShowLevelP2 = Global.LevelP2;
        ShowHPP2 = Global.CurHPP2;
        ShowMPP2 = Global.CurMPP2;

        ShowLevelP3 = Global.LevelP3;
        ShowHPP3 = Global.CurHPP3;
        ShowMPP3 = Global.CurMPP3;
        ShowZen = Global.Zen;*/
        
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
        /*if (ContainerController.BagStatus == 1)
        {
            TimePanel.SetActive(false);
            HubPanel.SetActive(false);
        }
        else if (ContainerController.BagStatus == 0)
        {
            TimePanel.SetActive(true);
            HubPanel.SetActive(true);
        }*/

        if (Input.GetKeyDown(KeyCode.M) && BusyHub == false && ContainerController.LoadingOpen == false)
        {
            OpenHubFX.Play();
            Player.TextDisplay = true;
            map.SetActive(true);
            BusyHub = true;
        }
        else if (Input.GetKeyDown(KeyCode.I) && BusyHub == false && ContainerController.LoadingOpen == false)
        {
            OpenHubFX.Play();
            Player.TextDisplay = true;
            info.SetActive(true);
            BusyHub = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && BusyHub == false && ContainerController.LoadingOpen == false)
        {
            OpenHubFX.Play();
            Player.TextDisplay = true;
            esc.SetActive(true);
            BusyHub = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && BusyHub == false && ContainerController.LoadingOpen == false)
        {
            OpenHubFX.Play();
            Player.TextDisplay = true;
            quest.SetActive(true);
            BusyHub = true;
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

        LevelP1.text = "Level " + ShowLevelP1;
        HPP1.text = "HP: " + ShowHPP1;
        MPP1.text = "MP: " + ShowMPP1;

        LevelP2.text = "Level " + ShowLevelP2;
        HPP2.text = "HP: " + ShowHPP2;
        MPP2.text = "MP: " + ShowMPP2;

        LevelP3.text = "Level " + ShowLevelP3;
        HPP3.text = "HP: " + ShowHPP3;
        MPP3.text = "MP: " + ShowMPP3;

        ShowZen = Global.Zen;
        Zen.text = ShowZen + " ";

        ShowP1Equip();
        ShowP2Equip();
        ShowP3Equip();

        if (Global.VayneStaff1 > 0)
        {
            VayneEmptySlotW1.SetActive(false);
        }
        if (Global.VayneStaff2 > 0)
        {
            VayneEmptySlotW2.SetActive(false);
        }
        if (Global.VayneStaff3 > 0)
        {
            VayneEmptySlotW3.SetActive(false);
        }
        if (Global.AlchemistArmor1 > 0)
        {
            VayneEmptySlotA1.SetActive(false);
        }
        if (Global.AlchemistArmor2 > 0)
        {
            VayneEmptySlotA2.SetActive(false);
        }
        if (Global.AlchemistArmor3 > 0)
        {
            VayneEmptySlotA3.SetActive(false);
        }
        if (Global.AliaShoes1 > 0)
        {
            AliaEmptySlotW1.SetActive(false);
        }
        if (Global.AliaShoes2 > 0)
        {
            AliaEmptySlotW2.SetActive(false);
        }
        if (Global.AliaShoes3 > 0)
        {
            AliaEmptySlotW3.SetActive(false);
        }
        if (Global.WarriorArmor1 > 0)
        {
            AliaEmptySlotA1.SetActive(false);
        }
        if (Global.WarriorArmor2 > 0)
        {
            AliaEmptySlotA2.SetActive(false);
        }
        if (Global.WarriorArmor3 > 0)
        {
            AliaEmptySlotA3.SetActive(false);
        }
        if (Global.MariaCrystal1 > 0)
        {
            MariaEmptySlotW1.SetActive(false);
        }
        if (Global.MariaCrystal2 > 0)
        {
            MariaEmptySlotW2.SetActive(false);
        }
        if (Global.MariaCrystal3 > 0)
        {
            MariaEmptySlotW3.SetActive(false);
        }
        if (Global.AlchemistArmor1 > 0)
        {
            MariaEmptySlotA1.SetActive(false);
        }
        if (Global.AlchemistArmor2 > 0)
        {
            MariaEmptySlotA2.SetActive(false);
        }
        if (Global.AlchemistArmor3 > 0)
        {
            MariaEmptySlotA3.SetActive(false);
        }

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
        else if (CutscenesController.cus8 == 0)
            QT.text = "Take a walk around Zexel town to find more information";
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
            QT.text = "Collect at least 4 string and 2 mana gems for Maria to create an alchemy tool to stop the iron golem\nCommit those materials at the tavern";
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
            QT.text = "Let's make Vayne's unique porridge then give the porridge to the group waiting at the tavern";
        else if (CutscenesController.cus24 == 0)
            QT.text = "Vayne is tired, go back to the save room to rest";
        else if (CutscenesController.cus25 == 0)
            QT.text = "Let's make a bomb on request Maria";
        else if (CutscenesController.cus26 == 0)
            QT.text = "Keep looking for information about the Zexel temple around town";
        else if (CutscenesController.cus27 == 0)
            QT.text = "Let's go to the blacksmith shop of Zexel town in the south";
        else if (CutscenesController.cus28 == 0)
            QT.text = "Let's collect Heerium some iron and mana gem . Iron: 3\nMana gem: 2\nRevisit to the weapon store to confirm the quest when the quest requirements are enough";
        else if (CutscenesController.cus29 == 0)
            QT.text = "Let's go back to the tavern to prepare some equipment and wait for the weapon made by Heerium";
        else if (CutscenesController.cus30 == 0)
            QT.text = "Let's go back to the tavern to prepare some equipment and wait for the weapon made by Heerium";
        else if (CutscenesController.cus31 == 0)
            QT.text = "Keep looking for information about the Zexel temple around town";
        else if (CutscenesController.cus32 == 0)
            QT.text = "Maria remembered a grocery store owner on the west side of town near a tavern";
        else if (CutscenesController.cus33 == 0)
            QT.text = "Let's collect some items for Orina. String: 2\nIron: 3\n Wood: 2\nRevisit to the grocery store to confirm the quest when the quest requirements are enough";
        else if (CutscenesController.cus34 == 0)
            QT.text = "Let's make our way to the inferno desert west of Zexel town";
        else if (CutscenesController.cus35 == 0)
            QT.text = "Let's make our way to the inferno desert west of Zexel town";
        else if (CutscenesController.cus36 == 0)
            QT.text = "Let's make our way to the inferno desert west of Zexel town";
        else if (CutscenesController.cus37 == 0)
            QT.text = "Help Jesca find her home and protect her from dangerous monsters, there is a village in the southwest of the desert";
        else if (CutscenesController.cus38 == 0)
            QT.text = "Head north of the desert to find the gate of Zexel";
        else if (CutscenesController.cus39 == 0)
            QT.text = "Alia has been poisoned, go back to Zexel town's pub to find an antidote";
        else if (CutscenesController.cus40 == 0)
            QT.text = "Collect the poisonous tail of the inferno scorpion to make an antidote for Alia";
        else if (CutscenesController.cus41 == 0)
            QT.text = "Let's proceed to Zexel gate in the north inferno desert";
        else if (CutscenesController.cus42 == 0)
            QT.text = "Let's go back to the tavern in Zexel town to find information";
        else if (CutscenesController.cus43 == 0)
            QT.text = "Let's go to Orina's grocery store to find the solution to open the Zexel Gate";
        else if (CutscenesController.cus44 == 0)
            QT.text = "Defeat some scorpions in the inferno desert to get their venom";
        else if (CutscenesController.cus45 == 0)
            QT.text = "Return to Orina's grocery store to complete the assigned quest";
        else if (CutscenesController.cus46 == 0)
            QT.text = "Let's go back to the town's tavern";
        else if (CutscenesController.cus47 == 0)
            QT.text = "Let's make Vayne's unique porridge";
        else if (CutscenesController.cus48 == 0)
            QT.text = "Let's make Vayne's unique porridge";
        else if (CutscenesController.cus49 == 0)
            QT.text = "Help Klener destroy and collect scorpion venom in the inferno desert";
        else if (CutscenesController.cus50 == 0)
            QT.text = "Let's go to the place of mana gods in the south inferno desert";
        else if (CutscenesController.cus51 == 0)
            QT.text = "Continue deep into the land of mana gate";
        else if (CutscenesController.cus52 == 0)
            QT.text = "Continue deep into the land of mana gate";
        else if (CutscenesController.cus53 == 0)
            QT.text = "Continue deep into the land of mana dimension";
        else if (CutscenesController.cus54 == 0)
            QT.text = "Let's synthesize a jewelry that can absorb mana for Alia";
        else if (CutscenesController.cus55 == 0)
            QT.text = "Continue deep into the land of mana dimension to find mana temple";
        else if (CutscenesController.cus56 == 0)
            QT.text = "Let's go back to the tavern in Zexel town";
        else if (CutscenesController.cus57 == 0)
            QT.text = "Let's make a mana generator and receiver and place it at the mana gate";
        else if (CutscenesController.cus58 == 0)
            QT.text = "Let's go back to the tavern in Zexel town";
        else if (CutscenesController.cus59 == 0)
            QT.text = "Head to the inferno volcano to the west of the inferno desert";
        else if (CutscenesController.cus60 == 0)
            QT.text = "Search the village in inferno volcano and ask about the villagers there";
        else if (CutscenesController.cus61 == 0)
            QT.text = "Let's head southwest of the inferno volcano to see if the village chief wants to meet or not";
        else if (CutscenesController.cus62 == 0)
            QT.text = "Let's collect some minerals around Inferno Volcano and return to Heerium's weapon store. Fire Ore: 4\nRevisit to the weapon store to confirm the quest when the quest requirements are enough";
        else if (CutscenesController.cus63 == 0)
            QT.text = "Head to the inferno ice to the west of the inferno desert";
        else if (CutscenesController.cus64 == 0)
            QT.text = "Head to the inferno ice to the west of the inferno desert";
        else if (CutscenesController.cus65 == 0)
            QT.text = "Search the village in inferno ice and ask about the villagers there";
        else if (CutscenesController.cus66 == 0)
            QT.text = "Head south to inferno ice to meet the village chief there";
        else if (CutscenesController.cus67 == 0)
            QT.text = "Kill the wolves at east of inferno ice and report back when you're done. Process: " + CutscenesTrigger.IceFangKill + "/4";
        else if (CutscenesController.cus68 == 0)
            QT.text = "Enter the ice cave south of the village of inferno ice";
        else if (CutscenesController.cus69 == 0)
            QT.text = "Let's go deeper in the cave and find ice crystals";
        else if (CutscenesController.cus70 == 0)
            QT.text = "Go back and report to the village chief inferno ice";
        else if (CutscenesController.cus71 == 0)
            QT.text = "Go to the village of inferno volcano and talk to the village chief how to get the Zexel fire core";
        else if (CutscenesController.cus72 == 0)
            QT.text = "Go inside the cave of the inferno volcano";
        else if (CutscenesController.cus73 == 0)
            QT.text = "Go deep inside the cave of the inferno volcano";
        else if (CutscenesController.cus74 == 0)
            QT.text = "Let's return to the pub of Zexel town to find a solution to the eruption of the volcano";
        else if (CutscenesController.cus75 == 0)
            QT.text = "Let's synthesize a copy of Zexel's fire energy core";
        else if (CutscenesController.cus76 == 0)
            QT.text = "Let's go deep inside the volcanic cave to proceed to place Vayne's fire mana energy core";
        else if (CutscenesController.cus77 == 0)
            QT.text = "Go to the village chief Asila in the inferno volcano village to understand the conflict going on";
        else if (CutscenesController.cus78 == 0)
            QT.text = "Go to the village chief Alasa in the village of inferno ice to convince him of the restoration of the land of alta inferno to remove the conflict";
        else if (CutscenesController.cus79 == 0)
            QT.text = "Let's go to the land in alta inferno to see the situation, the location of alta inferno to the west of inferno volcano and inferno ice";
        else if (CutscenesController.cus80 == 0)
            QT.text = "The land was covered by dark magic, Mr. Lance may know about the legend of the purification potion, so go back to the tavern to inquire";
        else if (CutscenesController.cus81 == 0)
            QT.text = "Find the source of purification water in the wishing forest";
        else if (CutscenesController.cus82 == 0)
            QT.text = "Craft and give mana water special back pain medicine";
        else if (CutscenesController.cus83 == 0)
            QT.text = "Use purification water to make purification potions and revive the land of alta inferno";
        else if (CutscenesController.cus84 == 0)
            QT.text = "Use the magic purification potion and the four potion elixir potions to revive the land of alta inferno";
        else if (CutscenesController.cus85 == 0)
            QT.text = "";
        else if (CutscenesController.cus86 == 0)
            QT.text = "Find the village chief Alasa who is deep in the ice cave in inferno ice";
        else if (CutscenesController.cus87 == 0)
            QT.text = "Let's clone Zexel's ice mana core and replace it in the ice cave inferno ice";
        else if (CutscenesController.cus88 == 0)
            QT.text = "Let's go back to Mr.'s tavern. Lance in Zexel town, Vayne has an idea";
        else if (CutscenesController.cus89 == 0)
            QT.text = "Synthesize generators and collectors of elemental mana and place them in two caves in the land of inferno volcano, inferno ice";
        else if (CutscenesController.cus90 == 0)
            QT.text = "Synthesize generators and collectors of elemental mana and place them in two caves in the land of inferno volcano, inferno ice";
        else if (CutscenesController.cus91 == 0)
            QT.text = "Go to the mana temple to find the gods about Zexel's two mana cores";
        else if (CutscenesController.cus92 == 0)
            QT.text = "Let's proceed to Zexel gate and proceed to open the gate";
        else if (CutscenesController.cus93 == 0)
            QT.text = "Let's go inside the temple of Zexel";
        else if (CutscenesController.cus94 == 0)
            QT.text = "Hurry back to Mr. Lance to find a way to heal Alia's wound";
        else if (CutscenesController.cus95 == 0)
            QT.text = "Head to the village southwest of the inferno desert to find a healer who can eliminate dark magic";
        else if (CutscenesController.cus96 == 0)
            QT.text = "Let's take Mrs. Meru back to the tavern in Zexel town";
        else if (CutscenesController.cus97 == 0)
            QT.text = "Let's collect the ingredients for Mrs. Meru to make the potion. Nature grass: 4, Red mana slime: 4, Blue mana slime: 4, Scorpion venom: 4\nCommit those materials at the tavern";
        else if (CutscenesController.cus98 == 0)
            QT.text = "Go to Orina's grocery store to inquire about dragon mana scales information";
        else if (CutscenesController.cus99 == 0)
            QT.text = "Head to the mana cliff southwest of the inferno desert village to search for the mana dragon";
        else if (CutscenesController.cus100 == 0)
            QT.text = "";
        else if (CutscenesController.cus101 == 0)
            QT.text = "Let's return to the tavern in Zexel town with the mana dragon scales collected";
        else if (CutscenesController.cus102 == 0)
            QT.text = "Let's take a walk around town waiting for Alia to get better";
        else if (CutscenesController.cus103 == 0)
            QT.text = "Let's go back to the tavern to take a break";
        else if (CutscenesController.cus104 == 0)
            QT.text = "Let's escort Mrs. Meru back to the village inferno desert";
        else if (CutscenesController.cus105 == 0)
            QT.text = "Let's escort Mrs. Meru back to the village inferno desert";
        else if (CutscenesController.cus106 == 0)
            QT.text = "Let's return to the tavern in Zexel town to rest and discuss the next strategy";
        else if (CutscenesController.cus107 == 0)
            QT.text = "The whole party wants to become stronger so stop by the Heerium to buy new equipment";
        else if (CutscenesController.cus108 == 0)
            QT.text = "Find the materials needed so that Heerium can craft powerful new equipment. Fire ore: 3, Red mana crystal: 3, Ice ore: 3, Blue mana crystal: 3, Mana dust: 3\nRevisit to the weapon store to confirm the quest when the quest requirements are enough";
        else if (CutscenesController.cus109 == 0)
            QT.text = "Stop by Orina's place to find out new items";
        else if (CutscenesController.cus110 == 0)
            QT.text = "Defeat the iron golem in the wishing forest to test your team's new strength";
        else if (CutscenesController.cus111 == 0)
            QT.text = "The inferno beast is back in alta inferno, go there and stop its destruction";
        else if (CutscenesController.cus112 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus113 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus114 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus115 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus116 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus117 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus118 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus119 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus120 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus121 == 0)
            QT.text = "We need to help the villagers who are struggling in the two villages of inferno volcano and inferno ice";
        else if (CutscenesController.cus122 == 0)
            QT.text = "Let's return to Zexel town to prepare for the battle with Zane";
        else if (CutscenesController.cus123 == 0)
            QT.text = "Follow Jesca to the village of Inferno desert to learn about the village situation";
        else if (CutscenesController.cus124 == 0)
            QT.text = "Let's go to Maria's old house in the Wishing forest to find the mana detector";
        else if (CutscenesController.cus125 == 0)
            QT.text = "Let's repair the mana detector from the old one you just found";
        else if (CutscenesController.cus126 == 0)
            QT.text = "Head to the village of Inferno desert to use the detector";
        else if (CutscenesController.cus127 == 0)
            QT.text = "You need to use 3 Ultra bombs to dig up the lake area";
        else if (CutscenesController.cus128 == 0)
            QT.text = "";
        else if (CutscenesController.cus129 == 0)
            QT.text = "";
        else if (CutscenesController.cus130 == 0)
            QT.text = "Let's return to Zexel town to prepare for the battle with Zane";
        else if (CutscenesController.cus131 == 0)
            QT.text = "Defeat all the monsters and protect the people of Zexel town";
        else if (CutscenesController.cus132 == 0)
            QT.text = "Make a barrier that covers Zexel town to protect everyone in the village";
        else if (CutscenesController.cus133 == 0)
            QT.text = "Come to the village in Inferno desert to use the barrier to protect everyone";
        else if (CutscenesController.cus134 == 0)
            QT.text = "Come to the mana temple to hear the messages of the mana gods";
        else if (CutscenesController.cus135 == 0)
            QT.text = "Let's go inside the temple of Zexel";
        else if (CutscenesController.cus136 == 0)
            QT.text = "Enter the room of truth located on the right hand side of the temple of Zexel";
        else if (CutscenesController.cus137 == 0)
            QT.text = "Zane is behind the main door of the temple of Zexel, stop his evil plot and prepare for the final battle";
        else if (CutscenesController.cus138 == 0)
            QT.text = "";
        else if (CutscenesController.cus139 == 0)
            QT.text = "";
        else if (CutscenesController.cus140 == 0)
            QT.text = "The final battle is over, let's return to Zexel town";
        else if (CutscenesController.cus141 == 0)
            QT.text = "It's time to hand over Sicxalon's soul to the Mana gods at the Mana temple";
        else if (CutscenesController.cus142 == 0)
            QT.text = "Let's return to Zexel town and rest at the tavern until tomorrow";
        else if (CutscenesController.cus143 == 0)
            QT.text = "Time to leave Zexel town, go back to wishing hill";
        else if (CutscenesController.cus144 == 0)
            QT.text = "";
    }
    public void Back1()
    {
        ClickHubFX.Play();
        map.SetActive(false);
        BusyHub = false;
    }
    public void Back2()
    {
        ClickHubFX.Play();
        info.SetActive(false);
        BusyHub = false;
    }
    public void Back3()
    {
        ClickHubFX.Play();
        quest.SetActive(false);
        BusyHub = false;
    }

    public void OpenVaynePanel()
    {
        ClickHubFX.Play();
        ShowVayneDetailPanel.SetActive(true);
    }

    public void OpenAliaPanel()
    {
        ClickHubFX.Play();
        ShowAliaDetailPanel.SetActive(true);
    }

    public void OpenMariaPanel()
    {
        ClickHubFX.Play();
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
        EquipFX.Play();
        ShowVayneArmorEquip.SetActive(false);
        ShowVayneWeaponEquip.SetActive(true);
    }

    //Equip Vayne weapon
    public void VayneEquipW1()
    {
        if (Global.VayneWeaponStatus == 0 && Global.VayneStaff1 >= 1)
        {
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
        EquipFX.Play();
        ShowVayneWeaponEquip.SetActive(false);
        ShowVayneArmorEquip.SetActive(true);
    }

    //Equip Vayne armor
    public void VayneEquipA1()
    {
        if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor1 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor1 -= 1;
            Global.VayneArmorStatus = 1;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor1 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.VayneArmorStatus == 2 && Global.AlchemistArmor1 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.VayneArmorStatus = 1;
            ShowP1Detail();
        }
        else if(Global.VayneArmorStatus == 2 && Global.AlchemistArmor1 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.VayneArmorStatus == 3 && Global.AlchemistArmor1 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.VayneArmorStatus = 1;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 3 && Global.AlchemistArmor1 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void VayneEquipA2()
    {
        if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor2 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor2 -= 1;
            Global.VayneArmorStatus = 2;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor2 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.VayneArmorStatus == 1 && Global.AlchemistArmor2 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.VayneArmorStatus = 2;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 1 && Global.AlchemistArmor2 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.VayneArmorStatus == 3 && Global.AlchemistArmor2 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.VayneArmorStatus = 2;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 3 && Global.AlchemistArmor2 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void VayneEquipA3()
    {
        if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor3 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor3 -= 1;
            Global.VayneArmorStatus = 3;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 0 && Global.AlchemistArmor3 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.VayneArmorStatus == 1 && Global.AlchemistArmor3 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.VayneArmorStatus = 3;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 1 && Global.AlchemistArmor3 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.VayneArmorStatus == 2 && Global.AlchemistArmor3 >= 1 && Global.CurHPP1 == Global.MaxHPP1)
        {
            EquipFX.Play();
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
            Global.CurHPP1 = Global.MaxHPP1;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.VayneArmorStatus = 3;
            ShowP1Detail();
        }
        else if (Global.VayneArmorStatus == 2 && Global.AlchemistArmor3 >= 1 && Global.CurHPP1 < Global.MaxHPP1)
        {
            EquipTextVayne.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void AliaWeaponEquip()
    {
        EquipFX.Play();
        ShowAliaArmorEquip.SetActive(false);
        ShowAliaWeaponEquip.SetActive(true);
    }

    //Equip Alia weapon
    public void AliaEquipW1()
    {
        if (Global.AliaWeaponStatus == 0 && Global.AliaShoes1 >= 1)
        {
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
        EquipFX.Play();
        ShowAliaWeaponEquip.SetActive(false);
        ShowAliaArmorEquip.SetActive(true);
    }

    //Equip Alia armor
    public void AliaEquipA1()
    {
        if (Global.AliaArmorStatus == 0 && Global.WarriorArmor1 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor1 -= 1;
            Global.AliaArmorStatus = 1;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 0 && Global.WarriorArmor1 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.AliaArmorStatus == 2 && Global.WarriorArmor1 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor2 += 1;
            Global.WarriorArmor1 -= 1;
            Global.AliaArmorStatus = 1;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 2 && Global.WarriorArmor1 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.AliaArmorStatus == 3 && Global.WarriorArmor1 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor3 += 1;
            Global.WarriorArmor1 -= 1;
            Global.AliaArmorStatus = 1;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 3 && Global.WarriorArmor1 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void AliaEquipA2()
    {
        if (Global.AliaArmorStatus == 0 && Global.WarriorArmor2 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor2 -= 1;
            Global.AliaArmorStatus = 2;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 0 && Global.WarriorArmor2 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.AliaArmorStatus == 1 && Global.WarriorArmor2 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor1 += 1;
            Global.WarriorArmor2 -= 1;
            Global.AliaArmorStatus = 2;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 1 && Global.WarriorArmor2 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.AliaArmorStatus == 3 && Global.WarriorArmor2 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor3 += 1;
            Global.WarriorArmor2 -= 1;
            Global.AliaArmorStatus = 2;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 3 && Global.WarriorArmor2 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void AliaEquipA3()
    {
        if (Global.AliaArmorStatus == 0 && Global.WarriorArmor3 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor3 -= 1;
            Global.AliaArmorStatus = 3;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 0 && Global.WarriorArmor3 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.AliaArmorStatus == 1 && Global.WarriorArmor3 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor1 += 1;
            Global.WarriorArmor3 -= 1;
            Global.AliaArmorStatus = 3;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 1 && Global.WarriorArmor3 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.AliaArmorStatus == 2 && Global.WarriorArmor3 >= 1 && Global.CurHPP2 == Global.MaxHPP2)
        {
            EquipFX.Play();
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
            Global.CurHPP2 = Global.MaxHPP2;
            Global.WarriorArmor2 += 1;
            Global.WarriorArmor3 -= 1;
            Global.AliaArmorStatus = 3;
            ShowP2Detail();
        }
        else if (Global.AliaArmorStatus == 2 && Global.WarriorArmor3 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextAlia.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void MariaWeaponEquip()
    {
        EquipFX.Play();
        ShowMariaArmorEquip.SetActive(false);
        ShowMariaWeaponEquip.SetActive(true);
    }

    //Equip Maria weapon
    public void MariaEquipW1()
    {
        if (Global.MariaWeaponStatus == 0 && Global.MariaCrystal1 >= 1)
        {
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
            EquipFX.Play();
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
        EquipFX.Play();
        ShowMariaArmorEquip.SetActive(true);
        ShowMariaWeaponEquip.SetActive(false);
    }

    //Equip Maria armor
    public void MariaEquipA1()
    {
        if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor1 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor1 -= 1;
            Global.MariaArmorStatus = 1;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor1 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.MariaArmorStatus == 2 && Global.AlchemistArmor1 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.MariaArmorStatus = 1;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 2 && Global.AlchemistArmor1 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.MariaArmorStatus == 3 && Global.AlchemistArmor1 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor1 -= 1;
            Global.MariaArmorStatus = 1;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 3 && Global.AlchemistArmor1 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void MariaEquipA2()
    {
        if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor2 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor2 -= 1;
            Global.MariaArmorStatus = 2;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor2 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.MariaArmorStatus == 1 && Global.AlchemistArmor2 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.MariaArmorStatus = 2;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 1 && Global.AlchemistArmor2 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.MariaArmorStatus == 3 && Global.AlchemistArmor2 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor3 += 1;
            Global.AlchemistArmor2 -= 1;
            Global.MariaArmorStatus = 2;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 3 && Global.AlchemistArmor2 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    public void MariaEquipA3()
    {
        if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor3 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor3 -= 1;
            Global.MariaArmorStatus = 3;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 0 && Global.AlchemistArmor3 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.MariaArmorStatus == 1 && Global.AlchemistArmor3 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor1 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.MariaArmorStatus = 3;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 1 && Global.AlchemistArmor3 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }

        if (Global.MariaArmorStatus == 2 && Global.AlchemistArmor3 >= 1 && Global.CurHPP3 == Global.MaxHPP3)
        {
            EquipFX.Play();
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
            Global.CurHPP3 = Global.MaxHPP3;
            Global.AlchemistArmor2 += 1;
            Global.AlchemistArmor3 -= 1;
            Global.MariaArmorStatus = 3;
            ShowP3Detail();
        }
        else if (Global.MariaArmorStatus == 2 && Global.AlchemistArmor3 >= 1 && Global.CurHPP2 < Global.MaxHPP2)
        {
            EquipTextMaria.SetActive(true);
            StartCoroutine(DelayEquipText());
        }
    }

    //Plus Vayne point
    public void PlusAttackP1()
    {
        if (Global.PlusPointP1 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 1;
            ConfirmPlusPointVaynePanel.SetActive(true);
        }
    }

    public void PlusHPP1()
    {
        if (Global.PlusPointP1 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 2;
            ConfirmPlusPointVaynePanel.SetActive(true);
        }
    }

    public void PlusMPP1()
    {
        if (Global.PlusPointP1 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 3;
            ConfirmPlusPointVaynePanel.SetActive(true);
        }
    }

    public void PlusSpeedP1()
    {
        if (Global.PlusPointP1 >= 2)
        {
            ClickHubFX.Play();
            PlusPointIndex = 4;
            ConfirmPlusPointVaynePanel.SetActive(true);
        }
    }

    //Plus Alia point
    public void PlusAttackP2()
    {
        if (Global.PlusPointP2 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 1;
            ConfirmPlusPointAliaPanel.SetActive(true);
        }
    }

    public void PlusHPP2()
    {
        if (Global.PlusPointP2 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 2;
            ConfirmPlusPointAliaPanel.SetActive(true);
        }
    }

    public void PlusMPP2()
    {
        if (Global.PlusPointP2 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 3;
            ConfirmPlusPointAliaPanel.SetActive(true);
        }
    }

    public void PlusSpeedP2()
    {
        if (Global.PlusPointP2 >= 2)
        {
            ClickHubFX.Play();
            PlusPointIndex = 4;
            ConfirmPlusPointAliaPanel.SetActive(true);
        }
    }

    //Plus Maria point
    public void PlusAttackP3()
    {
        if (Global.PlusPointP3 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 1;
            ConfirmPlusPointMariaPanel.SetActive(true);
        }
    }

    public void PlusHPP3()
    {
        if (Global.PlusPointP3 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 2;
            ConfirmPlusPointMariaPanel.SetActive(true);
        }
    }

    public void PlusMPP3()
    {
        if (Global.PlusPointP3 >= 1)
        {
            ClickHubFX.Play();
            PlusPointIndex = 3;
            ConfirmPlusPointMariaPanel.SetActive(true);
        }
    }

    public void PlusSpeedP3()
    {
        if (Global.PlusPointP3 >= 2)
        {
            ClickHubFX.Play();
            PlusPointIndex = 4;
            ConfirmPlusPointMariaPanel.SetActive(true);
        }
    }

    public void ConfirmPlusPointVayne()
    {
        ClickHubFX.Play();
        if (PlusPointIndex == 1)
        {
            Global.PlusPointP1 -= 1;
            Global.DamageP1 += 2;
            Global.PlusPointAttackLvP1 += 1;
            Global.PlusPointAttackInfoP1 += 2;
        }
        else if (PlusPointIndex == 2)
        {
            Global.PlusPointP1 -= 1;
            Global.MaxHPP1 += 5;
            Global.PlusPointHPLvP1 += 1;
            Global.PlusPointHPInfoP1 += 5;
        }
        else if (PlusPointIndex == 3)
        {
            Global.PlusPointP1 -= 1;
            Global.MaxMPP1 += 2;
            Global.PlusPointMPLvP1 += 1;
            Global.PlusPointMPInfoP1 += 2;
        }
        else if (PlusPointIndex == 4)
        {
            Global.PlusPointP1 -= 2;
            Global.SpeedP1 += 1;
            Global.PlusPointSpeedLvP1 += 1;
            Global.PlusPointSpeedInfoP1 += 1;
        }
        ShowP1Detail();
        PlusPointIndex = 0;
        ConfirmPlusPointVaynePanel.SetActive(false);
    }

    public void ConfirmPlusPointAlia()
    {
        ClickHubFX.Play();
        if (PlusPointIndex == 1)
        {
            Global.PlusPointP2 -= 1;
            Global.DamageP2 += 2;
            Global.PlusPointAttackLvP2 += 1;
            Global.PlusPointAttackInfoP2 += 2;
        }
        else if (PlusPointIndex == 2)
        {
            Global.PlusPointP2 -= 1;
            Global.MaxHPP2 += 5;
            Global.PlusPointHPLvP2 += 1;
            Global.PlusPointHPInfoP2 += 5;
        }
        else if (PlusPointIndex == 3)
        {
            Global.PlusPointP2 -= 1;
            Global.MaxMPP2 += 2;
            Global.PlusPointMPLvP2 += 1;
            Global.PlusPointMPInfoP2 += 2;
        }
        else if (PlusPointIndex == 4)
        {
            Global.PlusPointP2 -= 2;
            Global.SpeedP2 += 1;
            Global.PlusPointSpeedLvP2 += 1;
            Global.PlusPointSpeedInfoP2 += 1;
        }
        ShowP2Detail();
        PlusPointIndex = 0;
        ConfirmPlusPointAliaPanel.SetActive(false);
    }

    public void ConfirmPlusPointMaria()
    {
        ClickHubFX.Play();
        if (PlusPointIndex == 1)
        {
            Global.PlusPointP3 -= 1;
            Global.DamageP3 += 2;
            Global.PlusPointAttackLvP3 += 1;
            Global.PlusPointAttackInfoP3 += 2;
        }
        else if (PlusPointIndex == 2)
        {
            Global.PlusPointP3 -= 1;
            Global.MaxHPP3 += 5;
            Global.PlusPointHPLvP3 += 1;
            Global.PlusPointHPInfoP3 += 5;
        }
        else if (PlusPointIndex == 3)
        {
            Global.PlusPointP3 -= 1;
            Global.MaxMPP3 += 2;
            Global.PlusPointMPLvP3 += 1;
            Global.PlusPointMPInfoP3 += 2;
        }
        else if (PlusPointIndex == 4)
        {
            Global.PlusPointP3 -= 2;
            Global.SpeedP3 += 1;
            Global.PlusPointSpeedLvP3 += 1;
            Global.PlusPointSpeedInfoP3 += 1;
        }
        ShowP3Detail();
        PlusPointIndex = 0;
        ConfirmPlusPointMariaPanel.SetActive(false);
    }

    public void CancerPlusPoint()
    {
        ClickHubFX.Play();
        PlusPointIndex = 0;
        ConfirmPlusPointVaynePanel.SetActive(false);
        ConfirmPlusPointAliaPanel.SetActive(false);
        ConfirmPlusPointMariaPanel.SetActive(false);
    }

    public void CloseVaynePanel()
    {
        ClickHubFX.Play();
        ShowVayneDetailPanel.SetActive(false);
        ShowVayneWeaponEquip.SetActive(false);
        ShowVayneArmorEquip.SetActive(false);
    }

    public void CloseAliaPanel()
    {
        ClickHubFX.Play();
        ShowAliaDetailPanel.SetActive(false);
        ShowAliaWeaponEquip.SetActive(false);
        ShowAliaArmorEquip.SetActive(false);
    }

    public void CloseMariaPanel()
    {
        ClickHubFX.Play();
        ShowMariaDetailPanel.SetActive(false);
        ShowMariaWeaponEquip.SetActive(false);
        ShowMariaArmorEquip.SetActive(false);
    }

    public void BackToGame()
    {
        ClickHubFX.Play();
        esc.SetActive(false);
        BusyHub = false;
    }

    public void ExitGame()
    {
        ClickHubFX.Play();
        Application.Quit();
    }

    IEnumerator DelayEquipText()
    {
        yield return new WaitForSeconds(2f);
        EquipTextVayne.SetActive(false);
        EquipTextAlia.SetActive(false);
        EquipTextMaria.SetActive(false);
    }
}
