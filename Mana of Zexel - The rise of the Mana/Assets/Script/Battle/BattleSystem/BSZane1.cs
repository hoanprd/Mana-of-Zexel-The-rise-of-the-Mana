using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSZane1 : MonoBehaviour
{
    PlayerBattle pb;
    ZaneBattle ZB;

    public AudioSource VayneAttackFX, AliaAttackFX, MariaAttackFX, VayneSkill1FX, VayneSkill2FX, VayneSkill3FX, AliaSkill1FX, AliaSkill2FX, AliaSkill3FX, MariaSkill1FX, MariaSkill2FX, MariaSkill3FX, EnemyAttack1FX, EnemySkill1FX, HealFX, ExplosionFX, OpenCloseFX;

    public GameObject Item_panel;
    public GameObject HPHealingEffP1, MPHealingEffP1, EPHealingEffP1, HPHealingEffP3, MPHealingEffP3, EPHealingEffP3, BomEff, ReinEff;
    public GameObject VayneAttackEffect, VayneSkill2Effect, VayneSkill3Effect, MariaAttackEffect, MariaSkill3Effect, EnemyAttack1Effect, EnemySkill1Effect;
    public GameObject showr2, showr4;
    public GameObject P1_panel;
    public GameObject P2_panel;
    public GameObject P3_panel;

    public GameObject ChooseVayneSkillPanel, ChooseAliaSkillPanel, ChooseMariaSkillPanel;
    public GameObject VayneSkill2Hide, VayneSkill3Hide, AliaSkill2Hide, AliaSkill3Hide, MariaSkill2Hide, MariaSkill3Hide;

    public GameObject Win_panel;
    public GameObject Lose_panel;

    public GameObject HPItemUI, MPItemUI, EPItemUI, BItemUI, HHPItemUI, HMPItemUI, UBItemUI, RLItemUI;

    public GameObject P2TurnStatusObject;
    public GameObject P3TurnStatusObject;

    public GameObject P1LockIcon, P2LockIcon, P3LockIcon;

    public Text P1TurnStatus;
    public Text P2TurnStatus;
    public Text P3TurnStatus;
    public Text BE6TurnStatus;

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
    public Text showr1, showr3;
    public Text HP1;
    public Text MP1;
    public Text HP2;
    public Text MP2;
    public Text HP3;
    public Text MP3;
    public Text HPBE6;
    public Text EXPP1;
    public Text EXPP2;
    public Text EXPP3;
    public Text Money;
    public Text LevelP1;
    public Text LevelP2;
    public Text LevelP3;
    public Text NumTurn;
    public GameObject lu;
    public GameObject lu2;
    public GameObject lu3;
    public GameObject HPMP;
    public GameObject NB;
    public GameObject FadeInPanel;
    public int a1, a2, a3, aBE6;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    public int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int BE6Hit;
    public int UseItemIndex, ChooseSkillIndex;
    public int BE6ANum, TurnIndex, EHeal, EMaxHeal;
    public bool GameOver, P1LockSkill, P2LockSkill, P3LockSkill;

    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        ZB = FindObjectOfType<ZaneBattle>();

        GameOver = false;
        HubController.BusyHub = true;

        if (Global.LevelP1 < 10)
        {
            VayneSkill2Hide.SetActive(false);
        }
        if (Global.LevelP1 < 20)
        {
            VayneSkill3Hide.SetActive(false);
        }
        if (Global.LevelP2 < 10)
        {
            AliaSkill2Hide.SetActive(false);
        }
        if (Global.LevelP2 < 20)
        {
            AliaSkill3Hide.SetActive(false);
        }
        if (Global.LevelP3 < 10)
        {
            MariaSkill2Hide.SetActive(false);
        }
        if (Global.LevelP3 < 20)
        {
            MariaSkill3Hide.SetActive(false);
        }


        EMaxHeal = Global.HPBE6;
        a1 = Global.SpeedP1 / 10;
        a2 = Global.SpeedP2 / 10;
        a3 = Global.SpeedP3 / 10;
        aBE6 = Global.SpeedBE6 / 10;

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
        CheckBE6Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();

        if (a2 > 0 && Global.CurHPP2 > 0 && GameOver == false)
        {
            CheckBE6Die();
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
            TurnIndex = 2;
            if (show2 == 0)
                ShowP2Panel(true);
            else
                ShowP2Panel(false);
        }
        else if (a1 > 0 && Global.CurHPP1 > 0 && GameOver == false)
        {
            CheckBE6Die();
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
            UseItemIndex = 1;
            if (show1 == 0)
                ShowP1Panel(true);
            else
                ShowP1Panel(false);
        }
        else if (aBE6 > 0 && Global.HPBE6 > 0 && GameOver == false)
        {
            CheckBE6Die();
            ShowP1Panel(false);
            ShowP2Panel(false);
            ShowP3Panel(false);
            if (dem == 2)
            {
                BE6Action();
                dem -= 1;
                if (Global.CurHPP1 > 0 && Global.CurHPP2 > 0 && Global.CurHPP3 > 0)
                    EHeal = 3;
                else if ((Global.CurHPP1 <= 0 && Global.CurHPP2 > 0 && Global.CurHPP3 > 0) || (Global.CurHPP1 > 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 > 0) || (Global.CurHPP1 > 0 && Global.CurHPP2 > 0 && Global.CurHPP3 <= 0))
                    EHeal = 2;
                else if ((Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 > 0) || (Global.CurHPP1 <= 0 && Global.CurHPP2 > 0 && Global.CurHPP3 <= 0) || (Global.CurHPP1 > 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 <= 0))
                    EHeal = 1;

                int DamgeCal = EHeal * Global.DamageBE6 + (Global.DamageBE6 * 50) / 100;
                EDamage.color = Color.red;

                if (BE6ANum <= 6)
                    EDamage.text = "-" + Global.DamageBE6;
                else
                    PDamage.text = "+" + DamgeCal;
                Invoke("delayBE6", 1f);
                Invoke("delayBE6attack2", 2f);
            }
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
        }
        else if (a3 > 0 && Global.CurHPP3 > 0 && GameOver == false)
        {
            CheckBE6Die();
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

        if (a1 == 0 && a2 == 0 && a3 == 0 && aBE6 == 0)
        {
            a1 = Global.SpeedP1 / 10;
            a2 = Global.SpeedP2 / 10;
            a3 = Global.SpeedP3 / 10;
            aBE6 = Global.SpeedBE6 / 10;
            dem = 2;
        }
        FixBug();
    }

    public void FixBug()
    {
        if (a1 == 0 && a3 != 0 && Global.CurHPP3 <= 0)
        {
            a3 = 0;
            aBE6 = 0;
        }
    }

    public void UpdateUIText()
    {
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;

        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;

        HP3.text = "HP: " + Global.CurHPP3.ToString() + "/" + Global.MaxHPP3;
        MP3.text = "MP: " + Global.CurMPP3.ToString() + "/" + Global.MaxMPP3;

        HPBE6.text = "HP: " + Global.HPBE6.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPBE6 < 0)
        {
            Global.HPBE6 = 0;
            HPBE6.text = "HP: " + Global.HPBE6.ToString();
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
            HPBE6.text = "HP: 0";
        if (Global.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (Global.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (Global.CurHPP3 <= 0)
            HP3.text = "HP: 0";

        P1TurnStatus.text = a1 + "";
        P2TurnStatus.text = a2 + "";
        P3TurnStatus.text = a3 + "";
        BE6TurnStatus.text = aBE6 + "";

        if (ContainerController.HealPotion <= 0)
        {
            HPItemUI.SetActive(false);
        }
        if (ContainerController.ManaPotion <= 0)
        {
            MPItemUI.SetActive(false);
        }
        if (ContainerController.ElixirPotion <= 0)
        {
            EPItemUI.SetActive(false);
        }
        if (ContainerController.Bom <= 0)
        {
            BItemUI.SetActive(false);
        }
        if (ContainerController.HoliHP <= 0)
        {
            HHPItemUI.SetActive(false);
        }
        if (ContainerController.HoliMP <= 0)
        {
            HMPItemUI.SetActive(false);
        }
        if (ContainerController.UltraBom <= 0)
        {
            UBItemUI.SetActive(false);
        }
        if (ContainerController.ReincarnationLife <= 0)
        {
            RLItemUI.SetActive(false);
        }
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
        VayneAttackFX.Play();
        VayneAttackEffect.SetActive(true);
        pb.yes1 = 1;
        show1 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP1;
        Invoke("delayP1PressAttack", 2f);
        dem = 2;
    }
    public void PressAttackP2()
    {
        AliaAttackFX.Play();
        pb.yes3 = 1;
        show2 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP2;
        Invoke("delayP2PressAttack", 2f);
        dem = 2;
    }
    public void PressAttackP3()
    {
        MariaAttackFX.Play();
        MariaAttackEffect.SetActive(true);
        pb.yes5 = 1;
        show3 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP3;
        Invoke("delayP3PressAttack", 2f);
        dem = 2;
    }

    public void PressSkillVayne()
    {
        if (P1LockSkill == false)
        {
            OpenCloseFX.Play();
            show1 = 1;
            ChooseVayneSkillPanel.SetActive(true);
        }
        else
        {
            showr4.SetActive(true);
            showr3.text = "Your skill have been sealed";
            Invoke("delayshowr", 2f);
        }
    }

    public void PressSkillP11()
    {
        if (Global.CurMPP1 >= 20)
        {
            VayneSkill1FX.Play();
            CloseChooseSkillVayne();
            ChooseSkillIndex = 1;
            pb.yes2 = 1;
            show1 = 1;
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 100 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }

    public void PressSkillP12()
    {
        if (Global.CurMPP1 >= 50)
        {
            VayneSkill2FX.Play();
            CloseChooseSkillVayne();
            VayneSkill2Effect.SetActive(true);
            ChooseSkillIndex = 2;
            pb.yes7 = 1;
            show1 = 1;
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 200 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }

    public void PressSkillP13()
    {
        if (Global.CurMPP1 >= 100)
        {
            VayneSkill3FX.Play();
            CloseChooseSkillVayne();
            VayneSkill3Effect.SetActive(true);
            ChooseSkillIndex = 3;
            pb.yes8 = 1;
            show1 = 1;
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 300 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }
    public void CloseChooseSkillVayne()
    {
        OpenCloseFX.Play();
        ChooseVayneSkillPanel.SetActive(false);
        show1 = 0;
    }

    public void PressSkillAlia()
    {
        if (P2LockSkill == false)
        {
            OpenCloseFX.Play();
            show2 = 1;
            ChooseAliaSkillPanel.SetActive(true);
        }
        else
        {
            showr4.SetActive(true);
            showr3.text = "Your skill have been sealed";
            Invoke("delayshowr", 2f);
        }
    }
    public void PressSkillP21()
    {
        if (Global.CurMPP2 >= 20)
        {
            AliaSkill1FX.Play();
            CloseChooseSkillAlia();
            ChooseSkillIndex = 1;
            pb.yes4 = 1;
            show2 = 1;
            int DamgeCal = Global.DamageP2 + (Global.DamageP2 * 100 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP2PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }
    public void PressSkillP22()
    {
        if (Global.CurMPP2 >= 50)
        {
            AliaSkill2FX.Play();
            CloseChooseSkillAlia();
            ChooseSkillIndex = 2;
            pb.yes9 = 1;
            show2 = 1;
            int DamgeCal = Global.DamageP2 + (Global.DamageP2 * 200 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP2PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }
    public void PressSkillP23()
    {
        if (Global.CurMPP2 >= 100)
        {
            AliaSkill3FX.Play();
            CloseChooseSkillAlia();
            ChooseSkillIndex = 3;
            pb.yes10 = 1;
            show2 = 1;
            int DamgeCal = Global.DamageP2 + (Global.DamageP2 * 300 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP2PressSkill", 2.2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }
    public void CloseChooseSkillAlia()
    {
        OpenCloseFX.Play();
        ChooseAliaSkillPanel.SetActive(false);
        show2 = 0;
    }

    public void PressSkillMaria()
    {
        if (P3LockSkill == false)
        {
            OpenCloseFX.Play();
            show3 = 1;
            ChooseMariaSkillPanel.SetActive(true);
        }
        else
        {
            showr4.SetActive(true);
            showr3.text = "Your skill have been sealed";
            Invoke("delayshowr", 2f);
        }
    }
    public void PressSkillP31()
    {
        if (Global.CurMPP3 >= 40)
        {
            MariaSkill1FX.Play();
            CloseChooseSkillMaria();
            ChooseSkillIndex = 1;
            pb.yes6 = 1;
            show3 = 1;
            int HealAmount = Global.DamageP3 * 20 / 100;
            showr2.SetActive(true);
            showr1.text = "HP +" + HealAmount;
            Invoke("delayshowr", 2f);
            Invoke("delayP3PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }
    public void PressSkillP32()
    {
        if (Global.CurMPP3 >= 80)
        {
            MariaSkill2FX.Play();
            CloseChooseSkillMaria();
            ChooseSkillIndex = 2;
            pb.yes11 = 1;
            show3 = 1;
            int HealAmount = Global.DamageP3 * 20 / 100;
            showr2.SetActive(true);
            showr1.text = "MP +" + HealAmount;
            Invoke("delayshowr", 2f);
            Invoke("delayP3PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }
    public void PressSkillP33()
    {
        if (Global.CurMPP3 >= 120)
        {
            MariaSkill3FX.Play();
            CloseChooseSkillMaria();
            MariaSkill3Effect.SetActive(true);
            ChooseSkillIndex = 3;
            pb.yes12 = 1;
            show3 = 1;
            int DamgeCal = Global.DamageP3 + (Global.DamageP3 * 300 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP3PressSkill", 2f);
            dem = 2;
        }
        else
        {
            showr2.SetActive(true);
            showr1.text = "Not enough mana";
            Invoke("delayshowr", 2f);
        }
    }
    public void CloseChooseSkillMaria()
    {
        OpenCloseFX.Play();
        ChooseMariaSkillPanel.SetActive(false);
        show3 = 0;
    }

    public void PressItem()
    {
        OpenCloseFX.Play();

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
            HealFX.Play();

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
            HealFX.Play();

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
            HealFX.Play();

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
            ExplosionFX.Play();

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
            HealFX.Play();

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
            HealFX.Play();

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
            ExplosionFX.Play();

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
            HealFX.Play();

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
        OpenCloseFX.Play();

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

    /*public void PressRun()
    {
        HubController.BusyHub = false;
        SceneManager.LoadScene("Wishing forest");
    }

    public void PressBackToTheMap2()
    {
        ContainerController.LoadingOpen = true;
        HubController.BusyHub = false;
        SceneManager.LoadScene("Cutscenes");
    }*/

    public void BE6Action()
    {
        BE6ANum = Random.Range(0, 9);
        if (BE6ANum <= 6)
        {
            EnemyAttack1FX.Play();
            ZB.yes_ZaneAttack = 1;
            EnemyAttack1Effect.SetActive(true);
        }
        else
        {
            EnemySkill1FX.Play();
            ZB.yes_ZaneSkill = 1;
            EnemySkill1Effect.SetActive(true);
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
        if (Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 <= 0)
        {
            GameOver = true;
            UpdateUIText();
            ContainerController.DestroyBag = true;
            ContainerController.stop = 0;
            Invoke("delayCheckP1P2P3Die1", 1f);
            Invoke("delayCheckP1P2P3Die2", 2f);
        }
    }
    public void CheckBE6Die()
    {
        if (Global.HPBE6 <= (EMaxHeal/ 2))
        {
            GameOver = true;
            ShowP1Panel(false);
            ShowP2Panel(false);
            ShowP3Panel(false);
            UpdateUIText();

            Invoke("delayEndBE6", 2f);
        }
    }

    void delayEndBE6()
    {
        StartCoroutine(delayEndBattle());
    }

    void delayBE6()
    {
        CheckBE6Die();
        ShowP1Panel(false);
        ShowP2Panel(false);
        ShowP3Panel(false);
        BE6AttackTarget();
        EnemyAttack1Effect.SetActive(false);
        EnemySkill1Effect.SetActive(false);
        EDamage.text = "";
        PDamage.text = "";

        aBE6 -= 1;
        dem_turn += 1;
    }

    void BE6AttackTarget()
    {
        if (BE6ANum <= 6)
        {
            pb.p1YesGetHit = 1;
            pb.p2YesGetHit = 1;
            pb.p3YesGetHit = 1;

            Global.CurHPP1 -= Global.DamageBE6;
            Global.CurHPP2 -= Global.DamageBE6;
            Global.CurHPP3 -= Global.DamageBE6;
        }
        else
        {
            pb.p1YesGetHit = 1;
            pb.p2YesGetHit = 1;
            pb.p3YesGetHit = 1;

            if (Global.CurHPP1 > 0 && Global.CurHPP2 > 0 && Global.CurHPP3 > 0)
                EHeal = 3;
            else if ((Global.CurHPP1 <= 0 && Global.CurHPP2 > 0 && Global.CurHPP3 > 0) || (Global.CurHPP1 > 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 > 0) || (Global.CurHPP1 > 0 && Global.CurHPP2 > 0 && Global.CurHPP3 <= 0))
                EHeal = 2;
            else if ((Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 > 0) || (Global.CurHPP1 <= 0 && Global.CurHPP2 > 0 && Global.CurHPP3 <= 0) || (Global.CurHPP1 > 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 <= 0))
                EHeal = 1;

            int HealCal = EHeal * Global.DamageBE6 + (Global.DamageBE6 * 50) / 100;

            if ((Global.HPBE6 + HealCal) > EMaxHeal)
                Global.HPBE6 = EMaxHeal;
            else
            {
                Global.HPBE6 += HealCal;
            }

            P1LockSkill = true;
            P2LockSkill = true;
            P3LockSkill = true;
            P1LockIcon.SetActive(true);
            P2LockIcon.SetActive(true);
            P3LockIcon.SetActive(true);
        }
    }

    void delayBE6attack2()
    {
        if (dem == 1 && GameOver == false)
        {
            BE6Action();
            dem -= 1;
            int DamgeCal = Global.DamageBE6 + (Global.DamageBE6 * 100) / 100;
            EDamage.color = Color.red;
            if (BE6ANum <= 6)
                EDamage.text = "-" + Global.DamageBE6;
            else
                PDamage.text = "+" + DamgeCal;
            Invoke("delayBE6", 1f);
        }
    }

    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        VayneAttackEffect.SetActive(false);
        Global.HPBE6 -= Global.DamageP1;
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        P1LockSkill = false;
        P1LockIcon.SetActive(false);
        CheckBE6Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPBE6 -= Global.DamageP2;
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        P2LockSkill = false;
        P2LockIcon.SetActive(false);
        CheckBE6Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        MariaAttackEffect.SetActive(false);
        Global.HPBE6 -= Global.DamageP3;
        PDamage.text = "";
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        P3LockSkill = false;
        P3LockIcon.SetActive(false);
        CheckBE6Die();
    }

    void delayP1PressSkill()
    {
        if (ChooseSkillIndex == 1)
        {
            Global.CurMPP1 -= 20;
            Global.HPBE6 = Global.HPBE6 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckBE6Die();
        }
        else if (ChooseSkillIndex == 2)
        {
            VayneSkill2Effect.SetActive(false);
            Global.CurMPP1 -= 50;
            Global.HPBE6 = Global.HPBE6 - (Global.DamageP1 + (Global.DamageP1 * 200 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckBE6Die();
        }
        else if (ChooseSkillIndex == 3)
        {
            VayneSkill3Effect.SetActive(false);
            Global.CurMPP1 -= 100;
            Global.HPBE6 = Global.HPBE6 - (Global.DamageP1 + (Global.DamageP1 * 300 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckBE6Die();
        }
    }
    void delayP2PressSkill()
    {
        if (ChooseSkillIndex == 1)
        {
            Global.CurMPP2 -= 20;
            Global.HPBE6 = Global.HPBE6 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckBE6Die();
        }
        else if (ChooseSkillIndex == 2)
        {
            Global.CurMPP2 -= 50;
            Global.HPBE6 = Global.HPBE6 - (Global.DamageP2 + (Global.DamageP2 * 200 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckBE6Die();
        }
        else if (ChooseSkillIndex == 3)
        {
            Global.CurMPP2 -= 100;
            Global.HPBE6 = Global.HPBE6 - (Global.DamageP2 + (Global.DamageP2 * 300 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckBE6Die();
        }
    }
    void delayP3PressSkill()
    {
        if (ChooseSkillIndex == 1)
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
        else if (ChooseSkillIndex == 2)
        {
            Global.CurMPP3 -= 80;
            int HealAmount = Global.DamageP3 * 20 / 100;
            int CheckMaxhealP1 = Global.MaxMPP1 - Global.CurMPP1;
            int CheckMaxhealP2 = Global.MaxMPP2 - Global.CurMPP2;

            if ((HealAmount < CheckMaxhealP1) && (Global.CurHPP1 > 0))
            {
                Global.CurMPP1 += HealAmount;
            }
            else if ((HealAmount >= CheckMaxhealP1) && (Global.CurHPP1 > 0))
            {
                Global.CurMPP1 = Global.MaxMPP1;
            }
            if ((HealAmount < CheckMaxhealP2) && (Global.CurHPP2 > 0))
            {
                Global.CurMPP2 += HealAmount;
            }
            else if ((HealAmount >= CheckMaxhealP2) && (Global.CurHPP2 > 0))
            {
                Global.CurMPP2 = Global.MaxMPP2;
            }

            UpdateUIText();
            a3 -= 1;
            show3 = 0;
            dem_turn += 1;
        }
        else if (ChooseSkillIndex == 3)
        {
            MariaSkill3Effect.SetActive(false);
            Global.CurMPP3 -= 120;
            Global.HPBE6 = Global.HPBE6 - (Global.DamageP3 + (Global.DamageP3 * 300 / 100));
            PDamage.text = "";
            a3 -= 1;
            show3 = 0;
            dem_turn += 1;
            CheckBE6Die();
        }
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
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
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
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
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
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
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
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
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
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
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
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
            show3 = 0;
        }

        showr2.SetActive(true);
        showr1.text = "";
        dem_turn += 1;
        dem = 2;
    }

    void delayUseBom()
    {
        Global.HPBE6 -= 200;
        BomEff.SetActive(false);
        if (UseItemIndex == 1)
        {
            a1 -= 1;
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            a3 -= 1;
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
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
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
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
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
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
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
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
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
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
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            a3 -= 1;
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
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
            P1LockSkill = false;
            P1LockIcon.SetActive(false);
            show1 = 0;
        }
        else if (UseItemIndex == 3)
        {
            a3 -= 1;
            P3LockSkill = false;
            P3LockIcon.SetActive(false);
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
        showr4.SetActive(false);
    }

    IEnumerator delayEndBattle()
    {
        FadeInPanel.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        ContainerController.LoadingOpen = true;
        HubController.BusyHub = false;

        yield return new WaitForSeconds(0.5f);
        FadeInPanel.SetActive(false);
        SceneManager.LoadScene("Cutscenes");
    }
}
