using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSThief : MonoBehaviour
{
    PlayerBattle pb;
    ThiefBattle tb;

    public AudioSource VayneAttackFX, VayneSkill1FX, VayneSkill2FX, VayneSkill3FX, EnemyAttackFX, HealFX, OpenCloseFX;

    public GameObject Item_panel;
    public GameObject VayneAttackEffect, HPHealingEffP1, MPHealingEffP1;
    public GameObject showr2;
    public GameObject P1_panel;
    public GameObject Win_panel;
    public GameObject Lose_panel;
    public GameObject HPItemUI, MPItemUI;
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
    public Text HPE1;
    public Text EXPP1;
    public Text Money;
    public Text LevelP1;
    public GameObject lu;
    public GameObject HPMP;
    public GameObject NB;
    public GameObject ChooseVayneSkillPanel;
    public GameObject VayneSkill2Hide, VayneSkill3Hide;
    public GameObject TutorialImage1, TutorialImage2, TutorialImage3, TutorialImage4;
    public int a1, aE1;
    public int stop=0;
    private int dem=0;
    private int once = 0;
    private int show = 0;
    public int onceUIText;
    public int UseItemIndex, ChooseSkillIndex;
    public bool GameOver, Tutorial1, Tutorial2, Tutorial3, Tutorial4;

    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        tb = FindObjectOfType<ThiefBattle>();

        Tutorial1 = Tutorial2 = Tutorial3 = Tutorial4 = true;
        TutorialImage1.SetActive(true);

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

        a1 = Global.SpeedP1 / 10;
        aE1 = Global.SpeedE1 / 10;
    }

    // Update is called once per frame
    void Update()
    {
        CheckE1Die();
        CheckP1Die();
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        if(Global.HPE1 <= 0)
            HPE1.text = "HP: 0";

        if (ContainerController.HealPotion <= 0)
        {
            HPItemUI.SetActive(false);
        }
        if (ContainerController.ManaPotion <= 0)
        {
            MPItemUI.SetActive(false);
        }

        if (Global.SpeedP1 >= Global.SpeedE1)
        {
            if(a1 > 0 && Global.CurHPP1 > 0 && GameOver == false)
            {
                CheckE1Die();
                CheckP1Die();
                if (show == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if(aE1 > 0 && Global.HPE1 > 0 && GameOver == false)
            {
                CheckE1Die();
                ShowP1Panel(false);
                if (dem == 1)
                {
                    EnemyAttackFX.Play();
                    tb.yes_thief = 1;
                    pb.p1YesGetHit = 1;
                    EDamage.color = Color.red;
                    EDamage.text = "-" + Global.DamageE1;
                    Invoke("delayE1", 1f);
                    dem = 0;
                }
                CheckP1Die();
                if (aE1 == 0)
                {
                    a1 = Global.SpeedP1 / 10;
                }
            }
        }
        else if(Global.SpeedP1 < Global.SpeedE1)
        {
            if (aE1 != 0)
            {
                CheckE1Die();
                ShowP1Panel(false);
                if (dem == 1)
                {
                    tb.yes_thief = 1;
                    pb.p1YesGetHit = 1;
                    EDamage.color = Color.red;
                    EDamage.text = "-" + Global.DamageE1;
                    Invoke("delayE1", 1f);
                    dem = 0;
                }
                CheckP1Die();
                if (aE1 == 0)
                {
                    a1 = Global.SpeedP1 / 10;
                }
            }
            else if (a1 != 0)
            {
                CheckE1Die();
                CheckP1Die();
                ShowP1Panel(true);
            }
        }

        /*if (a1 == 0 && aE1 == 0)
        {
            a1 = Global.SpeedP1 / 10;
            aE1 = aE1 = Global.SpeedE1 / 10; ;
        }*/
    }
    public void ShowP1Panel(bool isshow)
    {
        if (P1_panel)
        {
            P1_panel.SetActive(isshow);
        }
    }
    public void PressAttack()
    {
        VayneAttackFX.Play();
        if (Tutorial1 == true)
        {
            TutorialImage1.SetActive(false);
        }
        VayneAttackEffect.SetActive(true);
        pb.yes1 = 1;
        show = 1;
        ShowP1Panel(false);
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP1;
        Invoke("delayP1PressAttack", 2f);
        dem = 1;
    }
    public void PressSkillVayne()
    {
        OpenCloseFX.Play();
        show = 1;
        ChooseVayneSkillPanel.SetActive(true);
    }

    public void PressSkillP11()
    {
        if (Global.CurMPP1 >= 20)
        {
            VayneSkill1FX.Play();
            if (Tutorial2 == true)
            {
                TutorialImage2.SetActive(false);
            }
            ChooseVayneSkillPanel.SetActive(false);
            show = 0;
            ChooseSkillIndex = 1;
            pb.yes2 = 1;
            show = 1;
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
                Invoke("delayshowr2", 2f);
            }
        }
    }
    public void CloseChooseSkillVayne()
    {
        OpenCloseFX.Play();
        showr2.SetActive(false);
        showr1.text = "";
        ChooseVayneSkillPanel.SetActive(false);
        show = 0;
    }

    public void PressItem()
    {
        OpenCloseFX.Play();
        show = 1;
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
        if(ContainerController.HealPotion > 0)
        {
            HealFX.Play();
            if (Tutorial3 == true)
            {
                TutorialImage3.SetActive(false);
            }
            HPHealingEffP1.SetActive(true);
            Item_panel.SetActive(false);
            showr2.SetActive(true);
            showr1.text = "HP +" + Global.HPValue;
            Invoke("delayshowr", 2f);
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
            MPHealingEffP1.SetActive(true);
            Item_panel.SetActive(false);
            Global.CurMPP1 += 30;
            showr2.SetActive(true);
            showr1.text = "MP +30";
            ContainerController.ManaPotion -= 1;
            if (Global.CurHPP1 > Global.MaxHPP1)
            {
                Global.CurHPP1 = Global.MaxHPP1;
            }
            a1 -= 1;
            dem = 1;
            if (a1 == 0)
            {
                aE1 = Global.SpeedE1 / 10;
            }
            Invoke("delayshowr", 2f);
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
            Global.CurHPP1 += 50;
            Global.CurMPP1 += 30;
            showr2.SetActive(true);
            showr1.text = "MP +50 MP +30";
            ContainerController.ElixirPotion -= 1;
            if (Global.CurHPP1 > Global.MaxHPP1)
            {
                Global.CurHPP1 = Global.MaxHPP1;
            }
            if (Global.CurMPP1 > Global.MaxMPP1)
            {
                Global.CurMPP1 = Global.MaxMPP1;
            }
            a1 -= 1;
            dem = 1;
            if (a1 == 0)
            {
                aE1 = Global.SpeedE1 / 10;
            }
            Invoke("delayshowr", 2f);
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
            Global.HPE1 -= 200;
            //showr2.SetActive(true);
            //showr1.text = "MP +50 MP +30";
            ContainerController.Bom -= 1;
            PDamage.color = Color.red;
            PDamage.text = "-200";
            a1 -= 1;
            dem = 1;
            if (a1 == 0)
            {
                aE1 = Global.SpeedE1 / 10;
            }
            Invoke("delayshowr", 2f);
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
        show = 0;
        Item_panel.SetActive(false);
    }
    public void PressRun()
    {
        //SceneManager.LoadScene(1);
    }
    public void PressBackToTheMap()
    {
        HubController.BusyHub = false;
        SceneManager.LoadScene("Cutscenes");
    }
    public void CheckP1Die()
    {
        if(Global.CurHPP1 <= 0)
        {
            GameOver = true;
            HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
            MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
            HPE1.text = "HP: " + Global.HPE1.ToString();
            Invoke("delayCheckP1Die1", 1f);
            Invoke("delayCheckP1Die2", 2f);
        }
    }
    public void CheckE1Die()
    {
        if(Global.HPE1 <= 0)
        {
            GameOver = true;
            ShowP1Panel(false);
            HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
            MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
            HPE1.text = "HP: " + Global.HPE1.ToString();

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

                Money.text = Global.Zen + "";
            }

            Invoke("delayCheckE1Die1", 1f);
            if (once == 0)
            {
                Invoke("delayCheckE1Die2", 2f);
                once = 1;
            }
        }
    }
    void delayE1()
    {
        CheckE1Die();
        ShowP1Panel(false);
        Global.CurHPP1 -= Global.DamageE1;
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        EDamage.text = "";
        aE1 -= 1;
        if (aE1 == 0)
        {
            a1 = Global.SpeedP1 / 10;
        }
    }
    void delayP1PressAttack()
    {
        if (Tutorial1 == true)
        {
            Tutorial1 = false;
            TutorialImage2.SetActive(true);
        }
        ShowP1Panel(false);
        VayneAttackEffect.SetActive(false);
        Global.HPE1 -= Global.DamageP1;
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        PDamage.text = "";
        a1 -= 1;
        show = 0;
        if (a1 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delayP1PressSkill()
    {
        if (Tutorial2 == true)
        {
            Tutorial2 = false;
            TutorialImage3.SetActive(true);
        }
        ShowP1Panel(false);
        Global.CurMPP1 -= 20;
        Global.HPE1 = Global.HPE1 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        PDamage.text = "";
        a1 -= 1;
        show = 0;
        if (a1 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delayCheckP1Die1()
    {
        HPMP.SetActive(false);
        Lose_panel.SetActive(true);
    }
    void delayCheckP1Die2()
    {
        SceneManager.LoadScene("Intro");
    }
    void delayCheckE1Die1()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckE1Die2()
    {
        if(Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += 10;
        }
        Global.Zen += 10;
        while(Global.CurEXPP1 >= Global.MaxEXPP1)
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
        Money.text = Global.Zen + " ";
        NB.SetActive(true);
    }
    void delayshowr()
    {
        if (Tutorial3 == true)
        {
            Tutorial3 = false;
            TutorialImage4.SetActive(true);
            if (Tutorial4 == true)
            {
                Tutorial4 = false;
                StartCoroutine(CloseTutorial4());
            }
        }
        Global.CurHPP1 += Global.HPValue;
        ContainerController.HealPotion -= 1;
        if (Global.CurHPP1 > Global.MaxHPP1)
        {
            Global.CurHPP1 = Global.MaxHPP1;
        }
        show = 0;
        a1 -= 1;
        dem = 1;
        if (a1 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        HPHealingEffP1.SetActive(false);
        MPHealingEffP1.SetActive(false);
        PDamage.text = "";
        showr2.SetActive(false);
    }

    void delayshowr2()
    {
        if (a1 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }

        showr2.SetActive(false);
        showr1.text = "";

        onceUIText = 0;
    }

    IEnumerator CloseTutorial4()
    {
        yield return new WaitForSeconds(8f);
        TutorialImage4.SetActive(false);
    }
}
