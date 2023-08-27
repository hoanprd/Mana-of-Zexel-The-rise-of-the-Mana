using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSGoblin1 : MonoBehaviour
{
    PlayerBattle pb;
    GoblinBattle GB;

    public AudioSource VayneAttackFX, AliaAttackFX, MariaAttackFX, VayneSkill1FX, VayneSkill2FX, VayneSkill3FX, AliaSkill1FX, AliaSkill2FX, AliaSkill3FX, MariaSkill1FX, MariaSkill2FX, MariaSkill3FX, EnemyAttackFX, HealFX, ExplosionFX, OpenCloseFX;

    public Canvas _canvas;

    public GameObject Item_panel;
    public GameObject HPHealingEffP1, MPHealingEffP1, EPHealingEffP1, HPHealingEffP3, MPHealingEffP3, EPHealingEffP3, BomEff, ReinEff;
    public GameObject VayneAttackEffect, VayneSkill2Effect, VayneSkill3Effect, MariaAttackEffect, MariaSkill3Effect;
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

    public GameObject ChooseVayneSkillPanel, ChooseAliaSkillPanel, ChooseMariaSkillPanel;
    public GameObject VayneSkill2Hide, VayneSkill3Hide, AliaSkill2Hide, AliaSkill3Hide, MariaSkill2Hide, MariaSkill3Hide;

    public GameObject Win_panel;
    public GameObject Lose_panel;

    public GameObject HPItemUI, MPItemUI, EPItemUI, BItemUI, HHPItemUI, HMPItemUI, UBItemUI, RLItemUI;

    public GameObject P2TurnStatusObject;
    public GameObject P3TurnStatusObject;

    public GameObject[] RunOff;

    public Text P1TurnStatus;
    public Text P2TurnStatus;
    public Text P3TurnStatus;
    public Text E2TurnStatus;

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
    public Text HPE2;
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
    public int a1, a2, a3, aE2;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    private int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int onceUIText;
    public static int E2Hit;
    public bool GameOver, P2Available, P3Available;
    public int UseItemIndex, ChooseSkillIndex;

    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        GB = FindObjectOfType<GoblinBattle>();

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

        a1 = Global.SpeedP1 / 10;
        a2 = Global.SpeedP2 / 10;
        a3 = Global.SpeedP3 / 10;
        aE2 = Global.SpeedE2 / 10;

        E2Hit = 0;

        if (CutscenesController.cus12 == 0)
        {
            MariaStatus.SetActive(false);
            MariaBar.SetActive(false);
            a3 = 0;
            HP3.text = "";
            MP3.text = "";
            P3Available = false;
            P3TurnStatusObject.SetActive(false);
        }
        else
        {
            MariaStatus.SetActive(true);
            MariaBar.SetActive(true);
            P3Available = true;
        }

        if (CutscenesController.cus93 == 1 && CutscenesController.cus103 == 0)
        {
            AliaStatus.SetActive(false);
            AliaBar.SetActive(false);
            a2 = 0;
            dem = 1;
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

        if (CutscenesController.cus131 == 0 && CutscenesController.cus130 == 1)
        {
            for (int i = 0; i < RunOff.Length; i++)
            {
                RunOff[i].SetActive(false);
            }
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
        CheckE2Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();

        if (Global.SpeedP2 >= Global.SpeedE2)
        {
            if (a2 > 0 && Global.CurHPP2 > 0 && P2Available == true && GameOver == false)
            {
                CheckE2Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
                if (show2 == 0)
                    ShowP2Panel(true);
                else
                    ShowP2Panel(false);
            }
            else if (a1 > 0 && Global.CurHPP1 > 0 && GameOver == false)
            {
                CheckE2Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
                UseItemIndex = 1;
                if (show1 == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if (a3 > 0 && Global.CurHPP3 > 0 && P3Available == true && GameOver == false)
            {
                CheckE2Die();
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
            else if (aE2 > 0 && Global.HPE2 > 0 && GameOver == false)
            {
                CheckE2Die();
                ShowP1Panel(false);
                ShowP2Panel(false);
                ShowP3Panel(false);
                _canvas.sortingOrder = 1;
                if (dem == 1)
                {
                    EnemyAttackFX.Play();
                    GB.yes_goblin = 1;
                    EDamage.color = Color.red;
                    EDamage.text = "-" + Global.DamageE2;
                    E2AttackTarget();
                    Invoke("delayE2", 1f);
                    dem = 0;
                }
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
            }
        }

        if (a1 == 0 && a2 == 0 && a3 == 0 && aE2 == 0)
        {
            if (P3Available == false)
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                aE2 = Global.SpeedE2 / 10;
                dem = 1;
            }
            else if (P2Available == false)
            {
                a1 = Global.SpeedP1 / 10;
                a3 = Global.SpeedP3 / 10;
                aE2 = Global.SpeedE2 / 10;
                dem = 1;
            }
            else
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                a3 = Global.SpeedP3 / 10;
                aE2 = Global.SpeedE2 / 10;
                dem = 1;
            }
        }
        FixBug();
    }

    public void FixBug()
    {
        if (a1 == 0 && a3 != 0 && Global.CurHPP3 <= 0)
        {
            a3 = 0;
            aE2 = 0;
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

        HPE2.text = "HP: " + Global.HPE2.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPE2 < 0)
        {
            Global.HPE2 = 0;
            HPE2.text = "HP: " + Global.HPE2.ToString();
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
            HPE2.text = "HP: 0";
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
        E2TurnStatus.text = aE2 + "";

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
        dem = 1;
    }
    public void PressAttackP2()
    {
        AliaAttackFX.Play();
        pb.yes3 = 1;
        show2 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP2;
        Invoke("delayP2PressAttack", 2f);
        dem = 1;
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
        dem = 1;
    }

    public void PressSkillVayne()
    {
        OpenCloseFX.Play();
        show1 = 1;
        ChooseVayneSkillPanel.SetActive(true);
    }

    public void PressSkillP11()
    {
        if (Global.CurMPP1 >= 20)
        {
            VayneSkill1FX.Play();
            ChooseVayneSkillPanel.SetActive(false);
            show1 = 0;
            ChooseSkillIndex = 1;
            pb.yes2 = 1;
            show1 = 1;
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 100 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }

    public void PressSkillP12()
    {
        if (Global.CurMPP1 >= 50)
        {
            VayneSkill2FX.Play();
            ChooseVayneSkillPanel.SetActive(false);
            show1 = 0;
            VayneSkill2Effect.SetActive(true);
            ChooseSkillIndex = 2;
            pb.yes7 = 1;
            show1 = 1;
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 200 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }

    public void PressSkillP13()
    {
        if (Global.CurMPP1 >= 100)
        {
            VayneSkill3FX.Play();
            ChooseVayneSkillPanel.SetActive(false);
            show1 = 0;
            VayneSkill3Effect.SetActive(true);
            ChooseSkillIndex = 3;
            pb.yes8 = 1;
            show1 = 1;
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 300 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }
    public void CloseChooseSkillVayne()
    {
        OpenCloseFX.Play();
        showr2.SetActive(false);
        showr1.text = "";
        ChooseVayneSkillPanel.SetActive(false);
        show1 = 0;
    }

    public void PressSkillAlia()
    {
        OpenCloseFX.Play();
        show2 = 1;
        ChooseAliaSkillPanel.SetActive(true);
    }
    public void PressSkillP21()
    {
        if (Global.CurMPP2 >= 20)
        {
            AliaSkill1FX.Play();
            ChooseAliaSkillPanel.SetActive(false);
            show2 = 0;
            ChooseSkillIndex = 1;
            pb.yes4 = 1;
            show2 = 1;
            int DamgeCal = Global.DamageP2 + (Global.DamageP2 * 100 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP2PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }
    public void PressSkillP22()
    {
        if (Global.CurMPP2 >= 50)
        {
            AliaSkill2FX.Play();
            ChooseAliaSkillPanel.SetActive(false);
            show2 = 0;
            ChooseSkillIndex = 2;
            pb.yes9 = 1;
            show2 = 1;
            int DamgeCal = Global.DamageP2 + (Global.DamageP2 * 200 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP2PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }
    public void PressSkillP23()
    {
        if (Global.CurMPP2 >= 100)
        {
            AliaSkill3FX.Play();
            ChooseAliaSkillPanel.SetActive(false);
            show2 = 0;
            ChooseSkillIndex = 3;
            pb.yes10 = 1;
            show2 = 1;
            int DamgeCal = Global.DamageP2 + (Global.DamageP2 * 300 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP2PressSkill", 2.2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }
    public void CloseChooseSkillAlia()
    {
        OpenCloseFX.Play();
        showr2.SetActive(false);
        showr1.text = "";
        ChooseAliaSkillPanel.SetActive(false);
        show2 = 0;
    }

    public void PressSkillMaria()
    {
        OpenCloseFX.Play();
        show3 = 1;
        ChooseMariaSkillPanel.SetActive(true);
    }
    public void PressSkillP31()
    {
        if (Global.CurMPP3 >= 40)
        {
            MariaSkill1FX.Play();
            ChooseMariaSkillPanel.SetActive(false);
            show3 = 0;
            ChooseSkillIndex = 1;
            pb.yes6 = 1;
            show3 = 1;
            int HealAmount = Global.DamageP3 * 20 / 100;
            showr2.SetActive(true);
            showr1.text = "HP +" + HealAmount;
            Invoke("delayshowr", 2f);
            Invoke("delayP3PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }
    public void PressSkillP32()
    {
        if (Global.CurMPP3 >= 80)
        {
            MariaSkill2FX.Play();
            ChooseMariaSkillPanel.SetActive(false);
            show3 = 0;
            ChooseSkillIndex = 2;
            pb.yes11 = 1;
            show3 = 1;
            int HealAmount = Global.DamageP3 * 20 / 100;
            showr2.SetActive(true);
            showr1.text = "MP +" + HealAmount;
            Invoke("delayshowr", 2f);
            Invoke("delayP3PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }
    public void PressSkillP33()
    {
        if (Global.CurMPP3 >= 120)
        {
            MariaSkill3FX.Play();
            ChooseMariaSkillPanel.SetActive(false);
            show3 = 0;
            MariaSkill3Effect.SetActive(true);
            ChooseSkillIndex = 3;
            pb.yes12 = 1;
            show3 = 1;
            int DamgeCal = Global.DamageP3 + (Global.DamageP3 * 300 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP3PressSkill", 2f);
            dem = 1;
        }
        else
        {
            if (onceUIText == 0)
            {
                onceUIText = 1;
                showr2.SetActive(true);
                showr1.text = "Not enough mana";
                Invoke("delayshowr", 2f);
            }
        }
    }
    public void CloseChooseSkillMaria()
    {
        OpenCloseFX.Play();
        showr2.SetActive(false);
        showr1.text = "";
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
            showr1.text = "HP +" + Global.HPValue;
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
            showr1.text = "MP +" + Global.MPValue;
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
            showr1.text = "HP +" + Global.HPValue + "MP +" + Global.MPValue;
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
            PDamage.text = "-" + Global.BomValue;
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
            showr1.text = "HP +" + Global.HoliHPValue;
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
            showr1.text = "MP +" + Global.HoliMPValue;
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
            PDamage.text = "-" + Global.UltraBomValue;
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
    public void PressRun()
    {
        HubController.BusyHub = false;
        SceneManager.LoadScene("Zexel town");
    }
    public void PressBackToTheMap2()
    {
        ContainerController.LoadingOpen = true;
        HubController.BusyHub = false;

        if (CutscenesController.cus6 == 1 && CutscenesController.cus7 == 0)
        {
            GlobalQuest.KillGoblinQuest += 1;
            if (GlobalQuest.KillGoblinQuest > 4)
                GlobalQuest.KillGoblinQuest = 4;
        }

        if (CutscenesController.cus130 == 1 && CutscenesController.cus131 == 0)
        {
            CutscenesTrigger.GoblinKillP2 += 1;
            if (CutscenesTrigger.GoblinKillP2 == 2 && CutscenesTrigger.GolemnKillP2 == 2)
            {
                SceneManager.LoadScene("Cutscenes");
            }
            else
                SceneManager.LoadScene("Zexel town");
        }
        else
            SceneManager.LoadScene("Zexel town");
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
                GameOver = true;
                UpdateUIText();
                ContainerController.DestroyBag = true;
                ContainerController.stop = 0;
                Invoke("delayCheckP1P2P3Die1", 1f);
                Invoke("delayCheckP1P2P3Die2", 2f);
            }
        }
        else if (P2Available == false)
        {
            if (Global.CurHPP1 <= 0 && Global.CurHPP3 <= 0)
            {
                GameOver = true;
                UpdateUIText();
                ContainerController.DestroyBag = true;
                ContainerController.stop = 0;
                Invoke("delayCheckP1P2P3Die1", 1f);
                Invoke("delayCheckP1P2P3Die2", 2f);
            }
        }
        else
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
    }
    public void CheckE2Die()
    {
        if (Global.HPE2 <= 0)
        {
            GameOver = true;
            ShowP1Panel(false);
            ShowP2Panel(false);
            ShowP3Panel(false);
            UpdateUIText();

            if (stop == 0)
            {
                stop = 1;

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

                if (P2Available == true)
                {
                    AliaName.SetActive(true);
                    AliaLevel.SetActive(true);
                    AliaExp.SetActive(true);
                    AliaPlusExp.SetActive(true);

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
                }

                if (P3Available == true)
                {
                    MariaName.SetActive(true);
                    MariaLevel.SetActive(true);
                    MariaExp.SetActive(true);
                    MariaPlusExp.SetActive(true);

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
                }

                Money.text = Global.Zen + " ";
            }

            Invoke("delayCheckE2Die1", 1f);
            if (once == 0)
            {
                Invoke("delayCheckE2Die2", 2f);
                once = 1;
            }
        }
    }
    void delayE2()
    {
        CheckE2Die();
        ShowP1Panel(false);

        if (E2Hit == 1 && Global.CurHPP1 > 0)
            Global.CurHPP1 -= Global.DamageE2;
        else if (E2Hit == 2 && Global.CurHPP2 > 0)
            Global.CurHPP2 -= Global.DamageE2;
        else if (E2Hit == 3 && Global.CurHPP3 > 0)
            Global.CurHPP3 -= Global.DamageE2;

        //E2AttackTarget();

        _canvas.sortingOrder = 3;
        EDamage.text = "";
        aE2 -= 1;
        dem_turn += 1;
    }

    void E2AttackTarget()
    {
        if (P3Available == false && P2Available == true)
            E2Hit = Random.Range(1, 3);
        else if (P3Available == true && P2Available == true)
            E2Hit = Random.Range(1, 4);
        else if (P3Available == true && P2Available == false)
        {
            E2Hit = Random.Range(1, 4);
            while (E2Hit == 2)
            {
                E2Hit = Random.Range(1, 4);
            }
        }

        if (E2Hit == 1 && Global.CurHPP1 > 0)
        {
            pb.p1YesGetHit = 1;
        }
        else if (E2Hit == 1 && Global.CurHPP1 <= 0)
            E2AttackTarget();
        else if (E2Hit == 2 && Global.CurHPP2 > 0)
        {
            pb.p2YesGetHit = 1;
        }
        else if (E2Hit == 2 && Global.CurHPP2 <= 0)
            E2AttackTarget();
        else if (E2Hit == 3 && Global.CurHPP3 > 0)
        {
            pb.p3YesGetHit = 1;
        }
        else if (E2Hit == 3 && Global.CurHPP3 <= 0)
            E2AttackTarget();
    }

    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        VayneAttackEffect.SetActive(false);
        Global.HPE2 -= Global.DamageP1;
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckE2Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPE2 -= Global.DamageP2;
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckE2Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        MariaAttackEffect.SetActive(false);
        Global.HPE2 -= Global.DamageP3;
        PDamage.text = "";
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        CheckE2Die();
    }

    void delayP1PressSkill()
    {
        if (ChooseSkillIndex == 1)
        {
            Global.CurMPP1 -= 20;
            Global.HPE2 = Global.HPE2 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckE2Die();
        }
        else if (ChooseSkillIndex == 2)
        {
            VayneSkill2Effect.SetActive(false);
            Global.CurMPP1 -= 50;
            Global.HPE2 = Global.HPE2 - (Global.DamageP1 + (Global.DamageP1 * 200 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckE2Die();
        }
        else if (ChooseSkillIndex == 3)
        {
            VayneSkill3Effect.SetActive(false);
            Global.CurMPP1 -= 100;
            Global.HPE2 = Global.HPE2 - (Global.DamageP1 + (Global.DamageP1 * 300 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckE2Die();
        }
    }
    void delayP2PressSkill()
    {
        if (ChooseSkillIndex == 1)
        {
            Global.CurMPP2 -= 20;
            Global.HPE2 = Global.HPE2 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckE2Die();
        }
        else if (ChooseSkillIndex == 2)
        {
            Global.CurMPP2 -= 50;
            Global.HPE2 = Global.HPE2 - (Global.DamageP2 + (Global.DamageP2 * 200 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckE2Die();
        }
        else if (ChooseSkillIndex == 3)
        {
            Global.CurMPP2 -= 100;
            Global.HPE2 = Global.HPE2 - (Global.DamageP2 + (Global.DamageP2 * 300 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckE2Die();
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
            Global.HPE2 = Global.HPE2 - (Global.DamageP3 + (Global.DamageP3 * 300 / 100));
            PDamage.text = "";
            a3 -= 1;
            show3 = 0;
            dem_turn += 1;
            CheckE2Die();
        }
    }

    void delayCheckP1P2P3Die1()
    {
        URPIns.URPOff = true;
        HPMP.SetActive(false);
        Lose_panel.SetActive(true);
    }
    void delayCheckP1P2P3Die2()
    {
        SceneManager.LoadScene("Intro");
    }
    void delayCheckE2Die1()
    {
        URPIns.URPOff = true;
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckE2Die2()
    {
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += Global.ExpE2;
        }
        if (Global.LevelP2 < 30 && P2Available == true)
        {
            Global.CurEXPP2 += Global.ExpE2;
        }
        if (Global.LevelP3 < 30 && P3Available == true)
        {
            Global.CurEXPP3 += Global.ExpE2;
        }
        Global.Zen += 20;
        while (Global.CurEXPP1 >= Global.MaxEXPP1)
        {
            lu.SetActive(true);
            Global.CurEXPP1 -= Global.MaxEXPP1;
            Global.MaxEXPP1 += 40;
            Global.LevelP1 += 1;
            Global.MaxHPP1 += 20;
            Global.MaxMPP1 += 4;
            Global.DamageP1 += 10;
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
            Global.CurHPP1 += Global.HPValue;
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
            Global.CurHPP3 += Global.HPValue;
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
            Global.CurMPP1 += Global.MPValue;
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
            Global.CurMPP3 += Global.MPValue;
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
            Global.CurHPP1 += Global.HPValue;
            Global.CurMPP1 += Global.MPValue;
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
            Global.CurHPP3 += Global.HPValue;
            Global.CurMPP3 += Global.MPValue;
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
        Global.HPE2 -= Global.BomValue;
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

    void delayUseHoliHP()
    {
        if (UseItemIndex == 1)
        {
            HPHealingEffP1.SetActive(false);
            a1 -= 1;
            Global.CurHPP1 += Global.HoliHPValue;
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
            Global.CurHPP3 += Global.HoliHPValue;
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

    void delayUseHoliMP()
    {
        if (UseItemIndex == 1)
        {
            MPHealingEffP1.SetActive(false);
            a1 -= 1;
            Global.CurMPP1 += Global.HoliMPValue;
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
            Global.CurMPP3 += Global.HoliMPValue;
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

    void delayUseUltraBom()
    {
        Global.HPE10 -= Global.UltraBomValue;
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

        Global.CurHPP1 += Global.HoliHPValue;
        Global.CurMPP1 += Global.HoliMPValue;
        Global.CurHPP2 += Global.HoliHPValue;
        Global.CurMPP2 += Global.HoliMPValue;
        Global.CurHPP3 += Global.HoliHPValue;
        Global.CurMPP3 += Global.HoliMPValue;

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
        onceUIText = 0;
    }
}
