using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSInfernoBeast1 : MonoBehaviour
{
    PlayerBattle pb;
    InfernoBeastBattle IBB;

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

    public GameObject Win_panel;
    public GameObject Lose_panel;

    public GameObject SkillChargeSign;
    public Text P1TurnStatus;
    public Text P2TurnStatus;
    public Text P3TurnStatus;
    public Text BE2TurnStatus;

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
    public Text HPBE2;
    public Text EXPP1;
    public Text EXPP2;
    public Text EXPP3;
    public Text Money;
    //public Text ManaGemItem;
    public Text LevelP1;
    public Text LevelP2;
    public Text LevelP3;
    public Text NumTurn;
    public GameObject lu;
    public GameObject lu2;
    public GameObject lu3;
    public GameObject HPMP;
    public GameObject NB;
    public int a1, a2, a3, aBE2;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    public int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int BE2Hit;
    public bool P2Available, P3Availabel;
    public int UseItemIndex;
    public int BE2ANum, TurnIndex, BossSkillCharge, BossSkillEngage, BossSkillBreak, BeforeBreakSkillDamageCal, AfterBreakDamageCal, BreakDamageCal, BreakDamageIndex;

    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        IBB = FindObjectOfType<InfernoBeastBattle>();
        a1 = Global.SpeedP1 / 10;
        a2 = Global.SpeedP2 / 10;
        a3 = Global.SpeedP3 / 10;
        aBE2 = Global.SpeedBE2 / 10;
        HPMPBarController.EIndex = 11;
        BreakDamageIndex = 0;
        BossSkillCharge = 0;

        if (CutscenesController.cus12 == 0)
        {
            MariaStatus.SetActive(false);
            MariaBar.SetActive(false);
            HP3.text = "";
            MP3.text = "";
            P3Availabel = false;
            a3 = 0;
        }
        else
        {
            MariaStatus.SetActive(true);
            MariaBar.SetActive(true);
            P3Availabel = true;
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
        CheckBE2Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();

        if (Global.SpeedP2 >= Global.SpeedBE2)
        {
            if(a2 > 0 && Global.CurHPP2 > 0)
            {
                CheckBE2Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
                TurnIndex = 2;
                if(show2 == 0)
                    ShowP2Panel(true);
                else
                    ShowP2Panel(false);
            }
            else if (aBE2 > 0 && Global.HPBE2 > 0)
            {
                CheckBE2Die();
                ShowP1Panel(false);
                ShowP2Panel(false);
                ShowP3Panel(false);
                if (dem == 3)
                {
                    BE2Action();

                    if (BossSkillCharge == 1)
                    {
                        dem = 0;
                    }
                    else
                    {
                        dem -= 1;
                    }

                    EDamage.color = Color.red;
                    if (BE2ANum <= 4)
                        EDamage.text = "-" + Global.DamageBE2;

                    Invoke("delayBE2", 1f);
                    Invoke("delayBE2attack2", 2f);
                    Invoke("delayBE2attack3", 4f);
                }
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
            }
            else if (a1 > 0 && Global.CurHPP1 > 0)
            {
                CheckBE2Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
                UseItemIndex = 1;
                if (show1 == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if (a3 > 0 && Global.CurHPP3 > 0 && P3Availabel == true)
            {
                CheckBE2Die();
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
        }

        if (a1 == 0 && a2 == 0 && a3 == 0 && aBE2 == 0)
        {
            if (CutscenesController.cus12 == 0)
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                aBE2 = Global.SpeedBE2 / 10;
            }
            else
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                a3 = Global.SpeedP3 / 10;
                aBE2 = Global.SpeedBE2 / 10;
            }
        }
    }

    public void UpdateUIText()
    {
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;

        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;

        if (P3Availabel == true)
        {
            HP3.text = "HP: " + Global.CurHPP3.ToString() + "/" + Global.MaxHPP3;
            MP3.text = "MP: " + Global.CurMPP3.ToString() + "/" + Global.MaxMPP3;
        }

        HPBE2.text = "HP: " + Global.HPBE2.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPBE2 < 0)
        {
            Global.HPBE2 = 0;
            HPBE2.text = "HP: " + Global.HPBE2.ToString();
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
            HPBE2.text = "HP: 0";
        if (Global.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (Global.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (Global.CurHPP3 <= 0)
            HP3.text = "HP: 0";

        P1TurnStatus.text = a1 + "";
        P2TurnStatus.text = a2 + "";
        P3TurnStatus.text = a3 + "";
        BE2TurnStatus.text = aBE2 + "";
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
        SceneManager.LoadScene("Alta inferno");
    }
    public void PressBackToTheMap2()
    {
        //ContainerController.ManaGem += 10;
        SceneManager.LoadScene("Alta inferno");
    }

    public void BE2Action()
    {
        if (BossSkillCharge == 1)
        {
            AfterBreakDamageCal = Global.HPBE2;
            BreakDamageCal = BeforeBreakSkillDamageCal - AfterBreakDamageCal;

            if (BreakDamageCal >= 400)
            {
                PDamage.color = Color.red;
                PDamage.text = "Skill break!";
            }
            else
            {
                IBB.yes_InfernoBeastSkill = 1;
                int DamgeCal = Global.DamageBE2 + Global.DamageBE2 * 300 / 100;
                EDamage.color = Color.red;
                EDamage.text = "-" + DamgeCal;
            }
        }
        else
        {
            BE2ANum = Random.Range(1, 11);
            if (BE2ANum <= 2)
            {
                IBB.yes_InfernoBeastAttack1 = 1;
            }
            else if (BE2ANum == 3 || BE2ANum == 4)
            {
                IBB.yes_InfernoBeastAttack2 = 1;
            }
            else
            {
                IBB.yes_InfernoBeastSkillCharge = 1;
                BossSkillCharge = 1;
                SkillChargeSign.SetActive(true);
            }
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
        if (CutscenesController.cus12 == 0)
        {
            if (Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0)
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
    public void CheckBE2Die()
    {
        if (Global.HPBE2 <= 0)
        {
            ShowP1Panel(false);
            ShowP2Panel(false);
            ShowP3Panel(false);
            UpdateUIText();
            stop = 1;

            LevelP1.text = "Level " + Global.LevelP1;
            EXPP1.text = Global.CurEXPP1 + "/" + Global.MaxEXPP1;

            LevelP2.text = "Level " + Global.LevelP2;
            EXPP2.text = Global.CurEXPP2 + "/" + Global.MaxEXPP2;

            if (P3Availabel == true)
            {
                MariaName.SetActive(true);
                MariaLevel.SetActive(true);
                MariaExp.SetActive(true);
                MariaPlusExp.SetActive(true);
                LevelP3.text = "Level " + Global.LevelP3;
                EXPP3.text = Global.CurEXPP3 + "/" + Global.MaxEXPP3;
            }

            Money.text = Global.Zen + " ";
            //ManaGemItem.text = "Mana Gem +10";

            Invoke("delayCheckBE2Die1", 1f);
            if (once == 0)
            {
                Invoke("delayCheckBE2Die2", 2f);
                once = 1;
            }
        }
    }
    void delayBE2()
    {
        CheckBE2Die();
        ShowP1Panel(false);
        ShowP2Panel(false);
        ShowP3Panel(false);

        if (BossSkillCharge == 1)
        {
            if (BossSkillEngage == 1)
            {
                AfterBreakDamageCal = Global.HPBE2;
                BreakDamageCal = BeforeBreakSkillDamageCal - AfterBreakDamageCal;

                if (BreakDamageCal >= 400)
                {
                    BreakDamageCal = 0;
                    BeforeBreakSkillDamageCal = 0;
                    AfterBreakDamageCal = 0;
                    BreakDamageIndex = 0;
                    BossSkillCharge = 0;
                    BossSkillEngage = 0;
                    SkillChargeSign.SetActive(false);
                }
                else
                {
                    Global.CurHPP1 -= Global.DamageBE2 + (Global.DamageBE2 * 300 / 100);
                    Global.CurHPP2 -= Global.DamageBE2 + (Global.DamageBE2 * 300 / 100);
                    Global.CurHPP3 -= Global.DamageBE2 + (Global.DamageBE2 * 300 / 100);
                    BossSkillCharge = 0;
                    BossSkillEngage = 0;
                    SkillChargeSign.SetActive(false);
                }
            }
            else
            {
                if (BreakDamageIndex == 0)
                {
                    BeforeBreakSkillDamageCal = Global.HPBE2;
                    BreakDamageIndex = 1;
                }
                BossSkillEngage = 1;
            }

            EDamage.text = "";
            PDamage.text = "";
            dem = 0;
            aBE2 = 0;
            dem_turn += 1;
        }
        else
        {
            BE2AttackTarget();
            EDamage.text = "";

            aBE2 -= 1;
            dem_turn += 1;
        }
    }

    void BE2AttackTarget()
    {
        if (CutscenesController.cus12 == 0)
            BE2Hit = Random.Range(1, 3);
        else if (CutscenesController.cus12 == 1)
            BE2Hit = Random.Range(1, 4);

        if (BE2Hit == 1 && Global.CurHPP1 > 0)
        {
            if (BE2ANum <= 6)
            {
                Global.CurHPP1 -= Global.DamageBE2;
            }
        }
        else if (BE2Hit == 1 && Global.CurHPP1 <= 0)
            BE2AttackTarget();
        else if (BE2Hit == 2 && Global.CurHPP2 > 0)
        {
            if (BE2ANum <= 6)
            {
                Global.CurHPP2 -= Global.DamageBE2;
            }
        }
        else if (BE2Hit == 2 && Global.CurHPP2 <= 0)
            BE2AttackTarget();
        else if (BE2Hit == 3 && Global.CurHPP3 > 0)
        {
            if (BE2ANum <= 6)
            {
                Global.CurHPP3 -= Global.DamageBE2;
            }
        }
        else if (BE2Hit == 3 && Global.CurHPP3 <= 0)
            BE2AttackTarget();
    }

    void delayBE2attack2()
    {
        if (dem == 2)
        {
            IBB.yes_InfernoBeastAttack1 = 1;
            dem -= 1;

            EDamage.color = Color.red;
            EDamage.text = "-" + Global.DamageBE2;

            Invoke("delayBE2", 1f);
        }
    }

    void delayBE2attack3()
    {
        if (dem == 1)
        {
            IBB.yes_InfernoBeastAttack2 = 1;
            dem -= 1;

            EDamage.color = Color.red;
            EDamage.text = "-" + Global.DamageBE2;

            Invoke("delayBE2", 1f);
        }
    }

    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        Global.HPBE2 -= Global.DamageP1;
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckBE2Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPBE2 -= Global.DamageP2;
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckBE2Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        Global.HPBE2 -= Global.DamageP3;
        PDamage.text = "";
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        CheckBE2Die();
    }
    void delayP1PressSkill()
    {
        Global.CurMPP1 -= 20;
        Global.HPBE2 = Global.HPBE2 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckBE2Die();
    }
    void delayP2PressSkill()
    {
        Global.CurMPP2 -= 20;
        Global.HPBE2 = Global.HPBE2 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckBE2Die();
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
    void delayCheckBE2Die1()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckBE2Die2()
    {
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += 120;
        }
        if (Global.LevelP2 < 30)
        {
            Global.CurEXPP2 += 120;
        }
        if (Global.LevelP3 < 30 && P3Availabel == true)
        {
            Global.CurEXPP3 += 120;
        }
        Global.Zen += 120;
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
        dem = 3;
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
        dem = 3;
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
        dem = 3;
    }

    void delayUseBom()
    {
        Global.HPBE2 -= 200;
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
        dem = 3;
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
        dem = 3;
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
        dem = 3;
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
        dem = 3;
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

        dem = 3;
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
