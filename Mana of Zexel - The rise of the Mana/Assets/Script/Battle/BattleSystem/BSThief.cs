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
    HPMPBarController bar;
    public GameObject Item_panel;
    public GameObject showr2;
    public GameObject P1_panel;
    public GameObject Win_panel;
    public GameObject Lose_panel;
    public Text PDamage;
    public Text EDamage;
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
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
    public int a1, aE1;
    public int stop=0;
    private int dem=0;
    private int once = 0;
    private int show = 0;
    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        tb = FindObjectOfType<ThiefBattle>();
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

        if (Global.SpeedP1 >= Global.SpeedE1)
        {
            if(a1 > 0 && Global.CurHPP1 > 0)
            {
                CheckE1Die();
                CheckP1Die();
                if (show == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if(aE1 > 0 && Global.HPE1 > 0)
            {
                CheckE1Die();
                ShowP1Panel(false);
                if (dem == 1)
                {
                    tb.yes_thief = 1;
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
        pb.yes1 = 1;
        show = 1;
        ShowP1Panel(false);
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP1;
        Invoke("delayP1PressAttack", 1f);
        dem = 1;
    }
    public void PressSkill()
    {
        if(Global.CurMPP1 >= 20)
        {
            pb.yes2 = 1;
            show = 1;
            ShowP1Panel(false);
            int DamgeCal = Global.DamageP1 + (Global.DamageP1 * 100 / 100);
            PDamage.color = Color.red;
            PDamage.text = "-" + DamgeCal;
            Invoke("delayP1PressSkill", 1f);
            dem = 1;
        }
    }
    public void PressItem()
    {
        show = 1;
        num1.text = ContainerController.HealPotion + "";
        num2.text = ContainerController.ManaPotion + "";
        num3.text = ContainerController.ElixirPotion + "";
        num4.text = ContainerController.Bom + "";
        Item_panel.SetActive(true);
    }
    public void UseHP()
    {
        if(ContainerController.HealPotion > 0)
        {
            Item_panel.SetActive(false);
            Global.CurHPP1 += 50;
            showr2.SetActive(true);
            showr1.text = "HP +50";
            ContainerController.HealPotion -= 1;
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
    public void UseMP()
    {
        if (ContainerController.ManaPotion > 0)
        {
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
        show = 0;
        Item_panel.SetActive(false);
    }
    public void PressRun()
    {
        //SceneManager.LoadScene(1);
    }
    public void PressBackToTheMap()
    {
        SceneManager.LoadScene("Cutscenes");
    }
    public void CheckP1Die()
    {
        if(Global.CurHPP1 <=0)
        {
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
            ShowP1Panel(false);
            HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
            MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
            HPE1.text = "HP: " + Global.HPE1.ToString();
            stop = 1;
            LevelP1.text = "Level " + Global.LevelP1;
            EXPP1.text = Global.CurEXPP1 + "/" + Global.MaxEXPP1;
            Money.text = Global.Zen + " ";
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
        ShowP1Panel(false);
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
        //Run P1 animation attack skill
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
            Global.SpeedP1 += 1;
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
        PDamage.text = "";
        showr2.SetActive(false);
    }
}
