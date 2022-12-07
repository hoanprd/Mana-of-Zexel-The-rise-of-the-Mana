using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSSicxalon1 : MonoBehaviour
{
    PlayerBattle pb;
    SicxalonBattle SB;

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
    public Text PDamage;
    public Text EDamage;
    public Text EDamage2;
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public Text num9;
    public Text showr1;
    public Text HP1;
    public Text MP1;
    public Text HP2;
    public Text MP2;
    public Text HP3;
    public Text MP3;
    public Text HPBE5;
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
    public GameObject SicxalonManaAttack;
    public int a1, a2, a3, aBE5;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    public int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int BE5Hit;
    public bool P2Available, P3Available;
    public int UseItemIndex;
    public int BE5ANum, TurnIndex, BossSkillCharge, BossSkillEngage, BossSkillBreak, BeforeBreakSkillDamageCal, AfterBreakDamageCal, BreakDamageCal, BreakDamageIndex;

    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        SB = FindObjectOfType<SicxalonBattle>();
        a1 = Global.SpeedP1 / 10;
        a2 = Global.SpeedP2 / 10;
        a3 = Global.SpeedP3 / 10;
        aBE5 = Global.SpeedBE5 / 10;
        HPMPBarController.EIndex = 11;
        BreakDamageIndex = 0;
        BossSkillCharge = 0;

        if (CutscenesController.cus12 == 0)
        {
            MariaStatus.SetActive(false);
            MariaBar.SetActive(false);
            HP3.text = "";
            MP3.text = "";
            P3Available = false;
            a3 = 0;
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
        CheckBE5Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();

        if (Global.SpeedP2 >= Global.SpeedBE5)
        {
            if(a2 > 0 && Global.CurHPP2 > 0 && P2Available == true)
            {
                CheckBE5Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
                TurnIndex = 2;
                if(show2 == 0)
                    ShowP2Panel(true);
                else
                    ShowP2Panel(false);
            }
            else if (a1 > 0 && Global.CurHPP1 > 0)
            {
                CheckBE5Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
                UseItemIndex = 1;
                if (show1 == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if (a3 > 0 && Global.CurHPP3 > 0 && P3Available == true)
            {
                CheckBE5Die();
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
            else if (aBE5 > 0 && Global.HPBE5 > 0)
            {
                CheckBE5Die();
                ShowP1Panel(false);
                ShowP2Panel(false);
                ShowP3Panel(false);
                if (dem == 1)
                {
                    BE5Action();

                    if (BossSkillCharge == 1)
                    {
                        dem = 0;
                    }
                    else
                    {
                        dem -= 1;
                    }

                    EDamage.color = Color.red;
                    EDamage2.color = Color.blue;
                    if (BE5ANum <= 3)
                        EDamage.text = "-" + Global.DamageBE5;
                    else if (BE5ANum > 3 && BE5ANum <= 5)
                    {
                        EDamage.text = "-" + Global.DamageBE5;
                        EDamage2.text = "- 50";
                    }
                    else if (BE5ANum == 6)
                        EDamage.text = "-999999";

                    Invoke("delayBE5", 1f);
                }
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
            }
        }

        if (a1 == 0 && a2 == 0 && a3 == 0 && aBE5 == 0)
        {
            if (CutscenesController.cus12 == 0)
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                aBE5 = Global.SpeedBE5 / 10;
            }
            else if (P2Available == false)
            {
                a1 = Global.SpeedP1 / 10;
                a3 = Global.SpeedP3 / 10;
                aBE5 = Global.SpeedBE5 / 10;
            }
            else
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                a3 = Global.SpeedP3 / 10;
                aBE5 = Global.SpeedBE5 / 10;
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

        HPBE5.text = "HP: " + Global.HPBE5.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPBE5 < 0)
        {
            Global.HPBE5 = 0;
            HPBE5.text = "HP: " + Global.HPBE5.ToString();
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

        if (Global.CurMPP1 < 0)
        {
            Global.CurMPP1 = 0;
            MP1.text = "HP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        }
        else if (Global.CurMPP2 < 0)
        {
            Global.CurMPP2 = 0;
            MP2.text = "HP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        }
        else if (Global.CurMPP3 < 0)
        {
            Global.CurMPP3 = 0;
            MP3.text = "HP: " + Global.CurMPP3.ToString() + "/" + Global.MaxMPP3;
        }

        if (Global.HPE2 <= 0)
            HPBE5.text = "HP: 0";
        if (Global.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (Global.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (Global.CurHPP3 <= 0)
            HP3.text = "HP: 0";
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
        dem = 1;
    }
    public void PressAttackP2()
    {
        pb.yes3 = 1;
        show2 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP2;
        Invoke("delayP2PressAttack", 1f);
        dem = 1;
    }
    public void PressAttackP3()
    {
        pb.yes5 = 1;
        show3 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP3;
        Invoke("delayP3PressAttack", 1f);
        dem = 1;
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
            dem = 1;
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
            dem = 1;
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
            dem = 1;
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
        num9.text = ContainerController.ReincarnationLife + "";
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
        SceneManager.LoadScene("Cutscenes");
    }
    public void PressBackToTheMap2()
    {
        //ContainerController.ManaGem += 10;
        SceneManager.LoadScene("Cutscenes");
    }

    public void BE5Action()
    {
        if (BossSkillCharge == 1)
        {
            AfterBreakDamageCal = Global.HPBE5;
            BreakDamageCal = BeforeBreakSkillDamageCal - AfterBreakDamageCal;

            if (BreakDamageCal >= 4000)
            {
                PDamage.color = Color.red;
                PDamage.text = "Skill break!";
            }
            else
            {
                SB.yes_SicxalonSkill1 = 1;
                SicxalonManaAttack.SetActive(true);
                int DamgeCal = Global.DamageBE5 + Global.DamageBE5 * 300 / 100;
                EDamage.color = Color.red;
                EDamage.text = "-" + DamgeCal;
            }
        }
        else
        {
            BE5ANum = Random.Range(1, 11);
            if (BE5ANum <= 3)
            {
                SB.yes_SicxalonAttack1 = 1;
            }
            else if (BE5ANum == 4 || BE5ANum == 5)
            {
                SB.yes_SicxalonAttack2 = 1;
            }
            else if (BE5ANum == 6)
            {
                SB.yes_SicxalonSkill2 = 1;
            }
            else
            {
                SB.yes_SicxalonSkillCharge = 1;
                BossSkillCharge = 1;
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
    public void CheckBE5Die()
    {
        if (Global.HPBE5 <= 0)
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

            Invoke("delayCheckBE5Die1", 1f);
            if (once == 0)
            {
                Invoke("delayCheckBE5Die2", 2f);
                once = 1;
            }
        }
    }
    void delayBE5()
    {
        CheckBE5Die();
        ShowP1Panel(false);
        ShowP2Panel(false);
        ShowP3Panel(false);

        if (BossSkillCharge == 1)
        {
            if (BossSkillEngage == 1)
            {
                AfterBreakDamageCal = Global.HPBE5;
                BreakDamageCal = BeforeBreakSkillDamageCal - AfterBreakDamageCal;

                if (BreakDamageCal >= 4000)
                {
                    BreakDamageCal = 0;
                    BeforeBreakSkillDamageCal = 0;
                    AfterBreakDamageCal = 0;
                    BreakDamageIndex = 0;
                    BossSkillCharge = 0;
                    BossSkillEngage = 0;
                }
                else
                {
                    Global.CurHPP1 -= Global.DamageBE5 + (Global.DamageBE5 * 300 / 100);
                    Global.CurHPP2 -= Global.DamageBE5 + (Global.DamageBE5 * 300 / 100);
                    Global.CurHPP3 -= Global.DamageBE5 + (Global.DamageBE5 * 300 / 100);
                    BossSkillCharge = 0;
                    BossSkillEngage = 0;
                    SicxalonManaAttack.SetActive(false);
                }
            }
            else
            {
                if (BreakDamageIndex == 0)
                {
                    BeforeBreakSkillDamageCal = Global.HPBE5;
                    BreakDamageIndex = 1;
                }
                BossSkillEngage = 1;
            }

            EDamage.text = "";
            PDamage.text = "";
            dem = 0;
            aBE5 = 0;
            dem_turn += 1;
        }
        else
        {
            BE5AttackTarget();
            EDamage.text = "";

            aBE5 -= 1;
            dem_turn += 1;
        }
    }

    void BE5AttackTarget()
    {
        if (P3Available == false && P2Available == true)
            BE5Hit = Random.Range(1, 3);
        else if (P3Available == true && P2Available == true)
            BE5Hit = Random.Range(1, 4);
        else if (P3Available == true && P2Available == false)
        {
            BE5Hit = Random.Range(1, 4);
            while (BE5Hit == 2)
            {
                BE5Hit = Random.Range(1, 4);
            }
        }

        if (BE5Hit == 1 && Global.CurHPP1 > 0)
        {
            if (BE5ANum <= 3)
            {
                Global.CurHPP1 -= Global.DamageBE5;
            }
            else if (BE5ANum == 4 || BE5ANum == 5)
            {
                Global.CurHPP1 -= Global.DamageBE5;
                Global.CurMPP1 -= 50;
            }
            else if (BE5ANum == 6)
            {
                Global.CurHPP1 = 0;
                Global.CurMPP1 = 0;
            }
        }
        else if (BE5Hit == 1 && Global.CurHPP1 <= 0)
            BE5AttackTarget();
        else if (BE5Hit == 2 && Global.CurHPP2 > 0)
        {
            if (BE5ANum <= 3)
            {
                Global.CurHPP2 -= Global.DamageBE5;
            }
            else if (BE5ANum == 4 || BE5ANum == 5)
            {
                Global.CurHPP2 -= Global.DamageBE5;
                Global.CurMPP2 -= 50;
            }
            else if (BE5ANum == 6)
            {
                Global.CurHPP2 = 0;
                Global.CurMPP2 = 0;
            }
        }
        else if (BE5Hit == 2 && Global.CurHPP2 <= 0)
            BE5AttackTarget();
        else if (BE5Hit == 3 && Global.CurHPP3 > 0)
        {
            if (BE5ANum <= 3)
            {
                Global.CurHPP3 -= Global.DamageBE5;
            }
            else if (BE5ANum == 4 || BE5ANum == 5)
            {
                Global.CurHPP3 -= Global.DamageBE5;
                Global.CurMPP3 -= 50;
            }
            else if (BE5ANum == 6)
            {
                Global.CurHPP3 = 0;
                Global.CurMPP3 = 0;
            }
        }
        else if (BE5Hit == 3 && Global.CurHPP3 <= 0)
            BE5AttackTarget();
    }

    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        Global.HPBE5 -= Global.DamageP1;
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckBE5Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPBE5 -= Global.DamageP2;
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckBE5Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        Global.HPBE5 -= Global.DamageP3;
        PDamage.text = "";
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        CheckBE5Die();
    }
    void delayP1PressSkill()
    {
        Global.CurMPP1 -= 20;
        Global.HPBE5 = Global.HPBE5 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckBE5Die();
    }
    void delayP2PressSkill()
    {
        Global.CurMPP2 -= 20;
        Global.HPBE5 = Global.HPBE5 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckBE5Die();
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
    void delayCheckBE5Die1()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckBE5Die2()
    {
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += 120;
        }
        if (Global.LevelP2 < 30 && P2Available == true)
        {
            Global.CurEXPP2 += 120;
        }
        if (Global.LevelP3 < 30 && P3Available == true)
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
        dem = 1;
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
        dem = 1;
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
        dem = 1;
    }

    void delayUseBom()
    {
        Global.HPBE5 -= 200;
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
        dem = 1;
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

        dem = 1;
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
