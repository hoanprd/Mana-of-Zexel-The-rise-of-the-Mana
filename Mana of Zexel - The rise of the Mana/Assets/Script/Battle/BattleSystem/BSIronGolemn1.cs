using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSIronGolemn1 : MonoBehaviour
{
    PlayerBattle pb;
    IronGolemnBattle IGB;
    public GameObject Item_panel;
    public GameObject HPHealingEffP1, MPHealingEffP1, EPHealingEffP1, HPHealingEffP3, MPHealingEffP3, EPHealingEffP3, BomEff, ReinEff;
    public GameObject showr2;
    public GameObject P1_panel;
    public GameObject P2_panel;
    public GameObject P3_panel;

    public GameObject MariaStatus;
    public GameObject MariaBar;
    public GameObject MariaName;
    public GameObject MariaLevel;
    public GameObject MariaExp;
    public GameObject MariaPlusExp;

    public GameObject AliaStatus;
    public GameObject AliaBar;
    public GameObject AliaName;
    public GameObject AliaLevel;
    public GameObject AliaExp;
    public GameObject AliaPlusExp;

    public GameObject Win_panel;
    public GameObject Lose_panel;

    public GameObject P2TurnStatusObject;
    public GameObject P3TurnStatusObject;
    public Text P1TurnStatus;
    public Text P2TurnStatus;
    public Text P3TurnStatus;
    public Text BE4TurnStatus;

    public Text PDamage;
    public Text EDamage;
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public Text num5;
    public Text num6;
    public Text num7;
    public Text num8;
    public Text showr1;
    public Text HP1;
    public Text MP1;
    public Text HP2;
    public Text MP2;
    public Text HP3;
    public Text MP3;
    public Text HPBE4;
    public Text EXPP1;
    public Text EXPP2;
    public Text EXPP3;
    public Text Money;
    public Text ManaGemItem;
    public Text LevelP1;
    public Text LevelP2;
    public Text LevelP3;
    public Text NumTurn;
    public GameObject lu;
    public GameObject lu2;
    public GameObject lu3;
    public GameObject HPMP;
    public GameObject NB;
    public int a1, a2, a3, aBE4;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    public int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int BE4Hit;
    public bool P2Available, P3Available;
    public int UseItemIndex;
    public int BE4ANum, TurnIndex;

    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        IGB = FindObjectOfType<IronGolemnBattle>();
        a1 = Global.SpeedP1 / 10;
        a2 = Global.SpeedP2 / 10;
        a3 = Global.SpeedP3 / 10;
        aBE4 = Global.SpeedBE4 / 10;

        if (CutscenesController.cus12 == 0)
        {
            MariaStatus.SetActive(false);
            MariaBar.SetActive(false);
            HP3.text = "";
            MP3.text = "";
            P3Available = false;
            a3 = 0;
            P3TurnStatusObject.SetActive(false);
        }
        else
        {
            MariaStatus.SetActive(true);
            MariaBar.SetActive(true);
            P3Available = true;
        }

        if (CutscenesController.cus50 == 1 && CutscenesController.cus51 == 0)
        {
            AliaStatus.SetActive(false);
            AliaBar.SetActive(false);
            a2 = 0;
            HP2.text = "";
            MP2.text = "";
            P2Available = false;
            P2TurnStatusObject.SetActive(false);
        }
        else
        {
            AliaStatus.SetActive(true);
            AliaBar.SetActive(true);
            P2Available = true;
        }

        if (Global.CurHPP1 > 0)
            pb.dead1 = 0;
        if (Global.CurHPP2 > 0)
            pb.dead2 = 0;
        if (Global.CurHPP3 > 0)
            pb.dead3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CheckBE4Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();

        if (a2 > 0 && Global.CurHPP2 > 0 && P2Available == true)
        {
            CheckBE4Die();
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
            TurnIndex = 2;
            if (show2 == 0)
                ShowP2Panel(true);
            else
                ShowP2Panel(false);
        }
        else if (a1 > 0 && Global.CurHPP1 > 0)
        {
            CheckBE4Die();
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
            UseItemIndex = 1;
            if (show1 == 0)
                ShowP1Panel(true);
            else
                ShowP1Panel(false);
        }
        else if (aBE4 > 0 && Global.HPBE4 > 0)
        {
            CheckBE4Die();
            ShowP1Panel(false);
            ShowP2Panel(false);
            ShowP3Panel(false);
            if (dem == 3)
            {
                BE4Action();
                dem -= 1;
                int DamgeCal = Global.DamageBE4 + (Global.DamageBE4 * 100) / 100;
                EDamage.color = Color.red;
                if (BE4ANum <= 7)
                    EDamage.text = "-" + Global.DamageBE4;
                else
                    EDamage.text = "-" + DamgeCal;
                Invoke("delayBE4", 1f);
                Invoke("delayBE4attack2", 2f);
                Invoke("delayBE4attack3", 4f);
            }
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
        }
        else if (a3 > 0 && Global.CurHPP3 > 0 && P3Available == true)
        {
            CheckBE4Die();
            CheckP1Die();
            CheckP2Die();
            CheckP3Die();
            CheckP1P2P3Die();
            UseItemIndex = 3;
            if (show3 == 0)
                ShowP3Panel(true);
            else
                ShowP3Panel(false);
        }

        if (a1 == 0 && a2 == 0 && a3 == 0 && aBE4 == 0)
        {
            if (P3Available == false)
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                aBE4 = Global.SpeedBE4 / 10;
            }
            else if (P2Available == false)
            {
                a1 = Global.SpeedP1 / 10;
                a3 = Global.SpeedP3 / 10;
                aBE4 = Global.SpeedE9 / 10;
            }
            else
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                a3 = Global.SpeedP3 / 10;
                aBE4 = Global.SpeedBE4 / 10;
            }
        }
    }

    public void UpdateUIText()
    {
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;

        if (P2Available == true)
        {
            HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
            MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        }

        if (P3Available == true)
        {
            HP3.text = "HP: " + Global.CurHPP3.ToString() + "/" + Global.MaxHPP3;
            MP3.text = "MP: " + Global.CurMPP3.ToString() + "/" + Global.MaxMPP3;
        }

        HPBE4.text = "HP: " + Global.HPBE4.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPBE4 < 0)
        {
            Global.HPBE4 = 0;
            HPBE4.text = "HP: " + Global.HPBE4.ToString();
        }
        else if (Global.CurHPP1 < 0)
        {
            Global.CurHPP1 = 0;
            HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        }
        else if (Global.CurHPP2 < 0)
        {
            Global.CurHPP2 = 0;
            HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        }
        else if (Global.CurHPP3 < 0)
        {
            Global.CurHPP3 = 0;
            HP3.text = "HP: " + Global.CurHPP3.ToString() + "/" + Global.MaxHPP3;
        }

        if (Global.HPE2 <= 0)
            HPBE4.text = "HP: 0";
        if (Global.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (Global.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (Global.CurHPP3 <= 0)
            HP3.text = "HP: 0";

        P1TurnStatus.text = a1 + "";
        if (P2Available == true)
            P2TurnStatus.text = a2 + "";
        if (P3Available == true)
            P3TurnStatus.text = a3 + "";
        BE4TurnStatus.text = aBE4 + "";
    }

    public void ShowP1Panel(bool isshow)
    {
        if (P1_panel)
        {
            P1_panel.SetActive(isshow);
        }
    }
    public void ShowP2Panel(bool isshow)
    {
        if (P2_panel)
        {
            P2_panel.SetActive(isshow);
        }
    }
    public void ShowP3Panel(bool isshow)
    {
        if (P3_panel)
        {
            P3_panel.SetActive(isshow);
        }
    }
    public void PressAttack()
    {
        pb.yes1 = 1;
        show1 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP1;
        Invoke("delayP1PressAttack", 1f);
        dem = 3;
    }
    public void PressAttackP2()
    {
        pb.yes3 = 1;
        show2 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP2;
        Invoke("delayP2PressAttack", 1f);
        dem = 3;
    }
    public void PressAttackP3()
    {
        pb.yes5 = 1;
        show3 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP3;
        Invoke("delayP3PressAttack", 1f);
        dem = 3;
    }
    public void PressSkill()
    {
        if (Global.CurMPP1 >= 20)
        {
            pb.yes2 = 1;
            show1 = 1;
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 100 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 1f);
            dem = 3;
        }
    }
    public void PressSkillP2()
    {
        if (Global.CurMPP2 >= 20)
        {
            pb.yes4 = 1;
            show2 = 1;
            int DamgeCal = Global.DamageP2 + (Global.DamageP2 * 100 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP2PressSkill", 1f);
            dem = 3;
        }
    }
    public void PressSkillP3()
    {
        if (Global.CurMPP3 >= 40)
        {
            pb.yes6 = 1;
            show3 = 1;
            int HealAmount = Global.DamageP3 * 20 / 100;
            showr2.SetActive(true);
            showr1.text = "HP +" + HealAmount;
            Invoke("delayshowr", 2f);
            Invoke("delayP3PressSkill", 1f);
            dem = 3;
        }
    }
    public void PressItem()
    {
        if (UseItemIndex == 1)
        {
            show1 = 1;
        }
        else if (UseItemIndex == 3)
        {
            show3 = 1;
        }
        num1.text = ContainerController.HealPotion + "";
        num2.text = ContainerController.ManaPotion + "";
        num3.text = ContainerController.ElixirPotion + "";
        num4.text = ContainerController.Bom + "";
        num5.text = ContainerController.HoliHP + "";
        num6.text = ContainerController.HoliMP + "";
        num7.text = ContainerController.UltraBom + "";
        num8.text = ContainerController.ReincarnationLife + "";
        Item_panel.SetActive(true);
    }
    public void UseHP()
    {
        if (ContainerController.HealPotion > 0)
        {
            Item_panel.SetActive(false);

            if (UseItemIndex == 1)
            {
                HPHealingEffP1.SetActive(true);
            }
            else if (UseItemIndex == 3)
            {
                HPHealingEffP3.SetActive(true);
            }

            showr2.SetActive(true);
            showr1.text = "HP +50";
            ContainerController.HealPotion -= 1;
            Invoke("delayUseHP", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }
    public void UseMP()
    {
        if (ContainerController.ManaPotion > 0)
        {
            Item_panel.SetActive(false);

            if (UseItemIndex == 1)
            {
                MPHealingEffP1.SetActive(true);
            }
            else if (UseItemIndex == 3)
            {
                MPHealingEffP3.SetActive(true);
            }

            showr2.SetActive(true);
            showr1.text = "MP +30";
            ContainerController.ManaPotion -= 1;
            Invoke("delayUseMP", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }
    public void UseEP()
    {
        if (ContainerController.ElixirPotion > 0)
        {
            Item_panel.SetActive(false);

            if (UseItemIndex == 1)
            {
                EPHealingEffP1.SetActive(true);
            }
            else if (UseItemIndex == 3)
            {
                EPHealingEffP3.SetActive(true);
            }

            ContainerController.ElixirPotion -= 1;
            showr2.SetActive(true);
            showr1.text = "MP +50 MP +30";
            Invoke("delayUseEP", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }
    public void UseB()
    {
        if (ContainerController.Bom > 0)
        {
            Item_panel.SetActive(false);
            BomEff.SetActive(true);
            ContainerController.Bom -= 1;
            PDamage.color = Color.red;
            PDamage.text = "-200";
            Invoke("delayUseBom", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }

    public void UseHoliHP()
    {
        if (ContainerController.HoliHP > 0)
        {
            Item_panel.SetActive(false);

            if (UseItemIndex == 1)
            {
                HPHealingEffP1.SetActive(true);
            }
            else if (UseItemIndex == 3)
            {
                HPHealingEffP3.SetActive(true);
            }

            showr2.SetActive(true);
            showr1.text = "HP +200";
            ContainerController.HoliHP -= 1;
            Invoke("delayUseHoliHP", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }

    public void UseHoliMP()
    {
        if (ContainerController.HoliMP > 0)
        {
            Item_panel.SetActive(false);

            if (UseItemIndex == 1)
            {
                HPHealingEffP1.SetActive(true);
            }
            else if (UseItemIndex == 3)
            {
                HPHealingEffP3.SetActive(true);
            }

            showr2.SetActive(true);
            showr1.text = "MP +80";
            ContainerController.HoliMP -= 1;
            Invoke("delayUseHoliMP", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }

    public void UseUltraBom()
    {
        if (ContainerController.UltraBom > 0)
        {
            Item_panel.SetActive(false);
            BomEff.SetActive(true);
            ContainerController.UltraBom -= 1;
            PDamage.color = Color.red;
            PDamage.text = "-500";
            Invoke("delayUseUltraBom", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }

    public void UseRL()
    {
        if (ContainerController.ReincarnationLife > 0)
        {
            Item_panel.SetActive(false);
            ReinEff.SetActive(true);
            ContainerController.ReincarnationLife -= 1;
            Invoke("delayUseReincarnationLife", 2f);
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough item";
            Invoke("delayshowr", 2f);
        }
    }

    public void CloseItemPanel()
    {
        if (UseItemIndex == 1)
        {
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            show3 = 0;
        }
        Item_panel.SetActive(false);
    }
    public void PressRun()
    {
        SceneManager.LoadScene("Wishing forest");
    }
    public void PressBackToTheMap2()
    {
        ContainerController.ManaGem += 10;
        SceneManager.LoadScene("Wishing forest");
    }

    public void BE4Action()
    {
        BE4ANum = Random.Range(0, 9);
        if (BE4ANum <= 7)
        {
            IGB.yes_IronGolemnAttack = 1;
        }
        else
        {
            IGB.yes_IronGolemnSkill = 1;
        }
    }
    public void CheckP1Die()
    {
        if(Global.CurHPP1 <= 0)
        {
            pb.dead1 = 1;
            a1 = 0;
        }
    }
    public void CheckP2Die()
    {
        if(Global.CurHPP2 <= 0)
        {
            pb.dead2 = 1;
            a2 = 0;
        }
    }
    public void CheckP3Die()
    {
        if (Global.CurHPP3 <= 0)
        {
            pb.dead3 = 1;
            a3 = 0;
        }
    }
    public void CheckP1P2P3Die()
    {
        if (P3Available == false)
        {
            if (Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0)
            {
                UpdateUIText();
                Invoke("delayCheckP1P2P3Die1", 1f);
                Invoke("delayCheckP1P2P3Die2", 2f);
            }
        }
        else if (P2Available == false)
        {
            if (Global.CurHPP1 <= 0 && Global.CurHPP3 <= 0)
            {
                UpdateUIText();
                Invoke("delayCheckP1P2P3Die1", 1f);
                Invoke("delayCheckP1P2P3Die2", 2f);
            }
        }
        else
        {
            if (Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 <= 0)
            {
                UpdateUIText();
                Invoke("delayCheckP1P2P3Die1", 1f);
                Invoke("delayCheckP1P2P3Die2", 2f);
            }
        }
    }
    public void CheckBE4Die()
    {
        if (Global.HPBE4 <= 0)
        {
            ShowP1Panel(false);
            ShowP2Panel(false);
            ShowP3Panel(false);
            UpdateUIText();
            stop = 1;

            LevelP1.text = "Level " + Global.LevelP1;
            EXPP1.text = Global.CurEXPP1 + "/" + Global.MaxEXPP1;

            if (P2Available == true)
            {
                AliaName.SetActive(true);
                AliaLevel.SetActive(true);
                AliaExp.SetActive(true);
                AliaPlusExp.SetActive(true);
                LevelP2.text = "Level " + Global.LevelP2;
                EXPP2.text = Global.CurEXPP2 + "/" + Global.MaxEXPP2;
            }

            if (P3Available == true)
            {
                MariaName.SetActive(true);
                MariaLevel.SetActive(true);
                MariaExp.SetActive(true);
                MariaPlusExp.SetActive(true);
                LevelP3.text = "Level " + Global.LevelP3;
                EXPP3.text = Global.CurEXPP3 + "/" + Global.MaxEXPP3;
            }

            Money.text = Global.Zen + " ";
            ManaGemItem.text = "Mana Gem +10";

            Invoke("delayCheckBE4Die1", 1f);
            if (once == 0)
            {
                Invoke("delayCheckBE4Die2", 2f);
                once = 1;
            }
        }
    }
    void delayBE4()
    {
        CheckBE4Die();
        ShowP1Panel(false);
        ShowP2Panel(false);
        ShowP3Panel(false);
        BE4AttackTarget();
        EDamage.text = "";

        aBE4 -= 1;
        dem_turn += 1;
    }

    void BE4AttackTarget()
    {
        if (P3Available == false && P2Available == true)
            BE4Hit = Random.Range(1, 3);
        else if (P3Available == true && P2Available == true)
            BE4Hit = Random.Range(1, 4);
        else if (P3Available == true && P2Available == false)
        {
            BE4Hit = Random.Range(1, 4);
            while (BE4Hit == 2)
            {
                BE4Hit = Random.Range(1, 4);
            }
        }

        if (BE4Hit == 1 && Global.CurHPP1 > 0)
        {
            if (BE4ANum <= 7)
            {
                Global.CurHPP1 -= Global.DamageBE4;
            }
            else
            {
                Global.CurHPP1 -= Global.DamageBE4 + ((Global.DamageBE4 * 100) / 100);
            }
        }
        else if (BE4Hit == 1 && Global.CurHPP1 <= 0)
            BE4AttackTarget();
        else if (BE4Hit == 2 && Global.CurHPP2 > 0)
        {
            if (BE4ANum <= 7)
            {
                Global.CurHPP2 -= Global.DamageBE4;
            }
            else
            {
                Global.CurHPP2 -= Global.DamageBE4 + ((Global.DamageBE4 * 100) / 100);
            }
        }
        else if (BE4Hit == 2 && Global.CurHPP2 <= 0)
            BE4AttackTarget();
        else if (BE4Hit == 3 && Global.CurHPP3 > 0)
        {
            if (BE4ANum <= 7)
            {
                Global.CurHPP3 -= Global.DamageBE4;
            }
            else
            {
                Global.CurHPP3 -= Global.DamageBE4 + ((Global.DamageBE4 * 100) / 100);
            }
        }
        else if (BE4Hit == 3 && Global.CurHPP3 <= 0)
            BE4AttackTarget();
    }

    void delayBE4attack2()
    {
        if (dem == 2)
        {
            BE4Action();
            dem -= 1;
            int DamgeCal = Global.DamageBE4 + (Global.DamageBE4 * 100) / 100;
            EDamage.color = Color.red;
            if (BE4ANum <= 7)
                EDamage.text = "-" + Global.DamageBE4;
            else
                EDamage.text = "-" + DamgeCal;
            Invoke("delayBE4", 1f);
        }
    }

    void delayBE4attack3()
    {
        if (dem == 1)
        {
            BE4Action();
            dem -= 1;
            int DamgeCal = Global.DamageBE4 + (Global.DamageBE4 * 100) / 100;
            EDamage.color = Color.red;
            if (BE4ANum <= 7)
                EDamage.text = "-" + Global.DamageBE4;
            else
                EDamage.text = "-" + DamgeCal;
            Invoke("delayBE4", 1f);
        }
    }

    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        Global.HPBE4 -= Global.DamageP1;
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckBE4Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPBE4 -= Global.DamageP2;
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckBE4Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        Global.HPBE4 -= Global.DamageP3;
        PDamage.text = "";
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        CheckBE4Die();
    }
    void delayP1PressSkill()
    {
        Global.CurMPP1 -= 20;
        Global.HPBE4 = Global.HPBE4 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckBE4Die();
    }
    void delayP2PressSkill()
    {
        Global.CurMPP2 -= 20;
        Global.HPBE4 = Global.HPBE4 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckBE4Die();
    }
    void delayP3PressSkill()
    {
        Global.CurMPP3 -= 40;
        int HealAmount = Global.DamageP3 * 20 / 100;
        int CheckMaxhealP1 = Global.MaxHPP1 - Global.CurHPP1;
        int CheckMaxhealP2 = Global.MaxHPP2 - Global.CurHPP2;

        if ((HealAmount < CheckMaxhealP1) && (Global.CurHPP1 > 0))
        {
            Global.CurHPP1 += HealAmount;
        }
        else if ((HealAmount >= CheckMaxhealP1) && (Global.CurHPP1 > 0))
        {
            Global.CurHPP1 = Global.MaxHPP1;
        }
        if ((HealAmount < CheckMaxhealP2) && (Global.CurHPP2 > 0))
        {
            Global.CurHPP2 += HealAmount;
        }
        else if ((HealAmount >= CheckMaxhealP2) && (Global.CurHPP2 > 0))
        {
            Global.CurHPP2 = Global.MaxHPP2;
        }

        UpdateUIText();
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
    }
    void delayCheckP1P2P3Die1()
    {
        HPMP.SetActive(false);
        Lose_panel.SetActive(true);
    }
    void delayCheckP1P2P3Die2()
    {
        SceneManager.LoadScene("Intro");
    }
    void delayCheckBE4Die1()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckBE4Die2()
    {
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += 360;
        }
        if (Global.LevelP2 < 30 && P2Available == true)
        {
            Global.CurEXPP2 += 360;
        }
        if (Global.LevelP3 < 30 && P3Available == true)
        {
            Global.CurEXPP3 += 360;
        }
        Global.Zen += 360;
        while (Global.CurEXPP1 >= Global.MaxEXPP1)
        {
            lu.SetActive(true);
            Global.CurEXPP1 -= Global.MaxEXPP1;
            Global.MaxEXPP1 += 40;
            Global.LevelP1 += 1;
            Global.MaxHPP1 += 20;
            Global.MaxMPP1 += 4;
            Global.DamageP1 += 10;
            Global.SpeedP1 += 1;
            Global.PlusPointP1 += 1;
        }
        while (Global.CurEXPP2 >= Global.MaxEXPP2)
        {
            lu2.SetActive(true);
            Global.CurEXPP2 -= Global.MaxEXPP2;
            Global.MaxEXPP2 += 40;
            Global.LevelP2 += 1;
            Global.MaxHPP2 += 10;
            Global.MaxMPP2 += 3;
            Global.DamageP2 += 15;
            Global.SpeedP2 += 1;
            Global.PlusPointP2 += 1;
        }
        while (Global.CurEXPP3 >= Global.MaxEXPP3)
        {
            lu3.SetActive(true);
            Global.CurEXPP3 -= Global.MaxEXPP3;
            Global.MaxEXPP3 += 40;
            Global.LevelP3 += 1;
            Global.MaxHPP3 += 25;
            Global.MaxMPP3 += 5;
            Global.DamageP3 += 10;
            Global.SpeedP3 += 1;
            Global.PlusPointP3 += 1;
        }
        if (Global.LevelP1 < 30)
        {
            LevelP1.text = "Level " + Global.LevelP1;
            EXPP1.text = Global.CurEXPP1 + "/" + Global.MaxEXPP1;
        }
        else
        {
            LevelP1.text = "Level Max";
            EXPP1.text = "MAX";
        }
        if (Global.LevelP2 < 30)
        {
            LevelP2.text = "Level " + Global.LevelP2;
            EXPP2.text = Global.CurEXPP2 + "/" + Global.MaxEXPP2;
        }
        else
        {
            LevelP2.text = "Level Max";
            EXPP2.text = "MAX";
        }
        if (Global.LevelP3 < 30)
        {
            LevelP3.text = "Level " + Global.LevelP3;
            EXPP3.text = Global.CurEXPP3 + "/" + Global.MaxEXPP3;
        }
        else
        {
            LevelP3.text = "Level Max";
            EXPP3.text = "MAX";
        }
        Money.text = Global.Zen + " ";
        NB.SetActive(true);
    }
    void delayUseHP()
    {
        if (UseItemIndex == 1)
        {
            HPHealingEffP1.SetActive(false);
            a1 -= 1;
            Global.CurHPP1 += 50;
            if (Global.CurHPP1 > Global.MaxHPP1)
            {
                Global.CurHPP1 = Global.MaxHPP1;
            }
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            HPHealingEffP3.SetActive(false);
            a3 -= 1;
            Global.CurHPP3 += 50;
            if (Global.CurHPP3 > Global.MaxHPP3)
            {
                Global.CurHPP3 = Global.MaxHPP3;
            }
            show3 = 0;
        }

        showr2.SetActive(true);
        showr1.text = "";
        dem = 2;
        dem_turn += 1;
    }

    void delayUseMP()
    {
        if (UseItemIndex == 1)
        {
            MPHealingEffP1.SetActive(false);
            a1 -= 1;
            Global.CurMPP1 += 30;
            if (Global.CurMPP1 > Global.MaxMPP1)
            {
                Global.CurMPP1 = Global.MaxMPP1;
            }
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            MPHealingEffP3.SetActive(false);
            a3 -= 1;
            Global.CurMPP3 += 30;
            if (Global.CurMPP3 > Global.MaxMPP3)
            {
                Global.CurMPP3 = Global.MaxMPP3;
            }
            show3 = 0;
        }

        showr2.SetActive(true);
        showr1.text = "";
        dem = 2;
        dem_turn += 1;
    }

    void delayUseEP()
    {
        if (UseItemIndex == 1)
        {
            EPHealingEffP1.SetActive(false);
            a1 -= 1;
            Global.CurHPP1 += 50;
            Global.CurMPP1 += 30;
            if (Global.CurHPP1 > Global.MaxHPP1)
            {
                Global.CurHPP1 = Global.MaxHPP1;
            }
            if (Global.CurMPP1 > Global.MaxMPP1)
            {
                Global.CurMPP1 = Global.MaxMPP1;
            }
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            EPHealingEffP3.SetActive(false);
            a3 -= 1;
            Global.CurHPP3 += 50;
            Global.CurMPP3 += 30;
            if (Global.CurHPP3 > Global.MaxHPP3)
            {
                Global.CurHPP3 = Global.MaxHPP3;
            }
            if (Global.CurMPP3 > Global.MaxMPP3)
            {
                Global.CurMPP3 = Global.MaxMPP3;
            }
            show3 = 0;
        }

        showr2.SetActive(true);
        showr1.text = "";
        dem_turn += 1;
        dem = 2;
    }

    void delayUseBom()
    {
        Global.HPBE4 -= 200;
        BomEff.SetActive(false);
        if (UseItemIndex == 1)
        {
            a1 -= 1;
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            a3 -= 1;
            show3 = 0;
        }
        PDamage.text = "";
        dem = 2;
        dem_turn += 1;
    }

    void delayUseHoliHP()
    {
        if (UseItemIndex == 1)
        {
            HPHealingEffP1.SetActive(false);
            a1 -= 1;
            Global.CurHPP1 += 200;
            if (Global.CurHPP1 > Global.MaxHPP1)
            {
                Global.CurHPP1 = Global.MaxHPP1;
            }
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            HPHealingEffP3.SetActive(false);
            a3 -= 1;
            Global.CurHPP3 += 200;
            if (Global.CurHPP3 > Global.MaxHPP3)
            {
                Global.CurHPP3 = Global.MaxHPP3;
            }
            show3 = 0;
        }

        showr2.SetActive(true);
        showr1.text = "";
        dem = 2;
        dem_turn += 1;
    }

    void delayUseHoliMP()
    {
        if (UseItemIndex == 1)
        {
            MPHealingEffP1.SetActive(false);
            a1 -= 1;
            Global.CurMPP1 += 80;
            if (Global.CurMPP1 > Global.MaxMPP1)
            {
                Global.CurMPP1 = Global.MaxMPP1;
            }
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            MPHealingEffP3.SetActive(false);
            a3 -= 1;
            Global.CurMPP3 += 80;
            if (Global.CurMPP3 > Global.MaxMPP3)
            {
                Global.CurMPP3 = Global.MaxMPP3;
            }
            show3 = 0;
        }

        showr2.SetActive(true);
        showr1.text = "";
        dem = 2;
        dem_turn += 1;
    }

    void delayUseUltraBom()
    {
        Global.HPE10 -= 500;
        BomEff.SetActive(false);
        if (UseItemIndex == 1)
        {
            a1 -= 1;
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            a3 -= 1;
            show3 = 0;
        }
        PDamage.text = "";
        dem = 2;
        dem_turn += 1;
    }

    public void delayUseReincarnationLife()
    {
        ReinEff.SetActive(false);

        pb.dead1 = 0;
        pb.dead2 = 0;
        pb.dead3 = 0;

        Global.CurHPP1 += 100;
        Global.CurMPP1 += 50;
        Global.CurHPP2 += 100;
        Global.CurMPP2 += 50;
        Global.CurHPP3 += 100;
        Global.CurMPP3 += 50;

        if (Global.CurHPP1 > Global.MaxHPP1)
            Global.CurHPP1 = Global.MaxHPP1;
        if (Global.CurMPP1 > Global.MaxMPP1)
            Global.CurMPP1 = Global.MaxMPP1;
        if (Global.CurHPP2 > Global.MaxHPP2)
            Global.CurHPP2 = Global.MaxHPP2;
        if (Global.CurMPP2 > Global.MaxMPP2)
            Global.CurMPP2 = Global.MaxMPP2;
        if (Global.CurHPP3 > Global.MaxHPP3)
            Global.CurHPP3 = Global.MaxHPP3;
        if (Global.CurMPP3 > Global.MaxMPP3)
            Global.CurMPP3 = Global.MaxMPP3;

        if (UseItemIndex == 1)
        {
            a1 -= 1;
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            a3 -= 1;
            show3 = 0;
        }

        dem = 2;
        dem_turn += 1;
    }

    void delayshowr()
    {
        HPHealingEffP1.SetActive(false);
        HPHealingEffP3.SetActive(false);
        MPHealingEffP1.SetActive(false);
        MPHealingEffP3.SetActive(false);
        EPHealingEffP1.SetActive(false);
        EPHealingEffP3.SetActive(false);
        ReinEff.SetActive(false);
        showr2.SetActive(false);
    }
}
