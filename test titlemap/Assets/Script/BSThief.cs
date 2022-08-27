using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSThief : MonoBehaviour
{
    Global gb;
    PlayerBattle pb;
    ThiefBattle tb;
    public GameObject Item_panel;
    public GameObject showr2;
    public GameObject P1_panel;
    public GameObject Win_panel;
    public GameObject Lose_panel;
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
        gb = FindObjectOfType<Global>();
        pb = FindObjectOfType<PlayerBattle>();
        tb = FindObjectOfType<ThiefBattle>();
        a1 = gb.SpeedP1 / 10;
        aE1 = gb.SpeedE1 / 10;
    }

    // Update is called once per frame
    void Update()
    {
        CheckE1Die();
        CheckP1Die();
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HPE1.text = "HP: " + gb.HPE1.ToString();
        if(gb.HPE1 <= 0)
            HPE1.text = "HP: 0";

        if (gb.SpeedP1 >= gb.SpeedE1)
        {
            if(a1 > 0 && gb.CurHPP1 > 0)
            {
                CheckE1Die();
                CheckP1Die();
                if (show == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if(aE1 > 0 && gb.HPE1 > 0)
            {
                CheckE1Die();
                ShowP1Panel(false);
                if (dem == 1)
                {
                    tb.yes_thief = 1;
                    Invoke("delay", 1f);
                    dem = 0;
                }
                CheckP1Die();
                if (aE1 == 0)
                {
                    a1 = gb.SpeedP1 / 10;
                }
            }
        }
        else if(gb.SpeedP1 < gb.SpeedE1)
        {
            if (aE1 != 0)
            {
                CheckE1Die();
                ShowP1Panel(false);
                if (dem == 1)
                {
                    tb.yes_thief = 1;
                    Invoke("delay", 1f);
                    dem = 0;
                }
                CheckP1Die();
                if (aE1 == 0)
                {
                    a1 = gb.SpeedP1 / 10;
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
        Invoke("delay1", 1f);
        dem = 1;
    }
    public void PressSkill()
    {
        if(gb.CurMPP1 >= 20)
        {
            pb.yes2 = 1;
            show = 1;
            ShowP1Panel(false);
            Invoke("delay2", 1f);
            dem = 1;
        }
    }
    public void PressItem()
    {
        show = 1;
        num1.text = PlayerPrefs.GetInt("SHP") + "";
        num2.text = PlayerPrefs.GetInt("SMP") + "";
        num3.text = PlayerPrefs.GetInt("SEP") + "";
        num4.text = PlayerPrefs.GetInt("SB") + "";
        Item_panel.SetActive(true);
    }
    public void UseHP()
    {
        if(PlayerPrefs.GetInt("SHP") > 0)
        {
            Item_panel.SetActive(false);
            gb.CurHPP1 += 50;
            showr2.SetActive(true);
            showr1.text = "HP +50";
            if(gb.CurHPP1 > gb.MaxHPP1)
            {
                gb.CurHPP1 = gb.MaxHPP1;
            }
            a1 -= 1;
            dem = 1;
            if (a1 == 0)
            {
                aE1 = gb.SpeedE1 / 10;
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
        if (PlayerPrefs.GetInt("SMP") > 0)
        {
            Item_panel.SetActive(false);
            gb.CurMPP1 += 30;
            showr2.SetActive(true);
            showr1.text = "MP +30";
            if (gb.CurHPP1 > gb.MaxHPP1)
            {
                gb.CurHPP1 = gb.MaxHPP1;
            }
            a1 -= 1;
            dem = 1;
            if (a1 == 0)
            {
                aE1 = gb.SpeedE1 / 10;
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
        if (PlayerPrefs.GetInt("SEP") > 0)
        {
            Item_panel.SetActive(false);
            gb.CurHPP1 += 50;
            gb.CurMPP1 += 30;
            showr2.SetActive(true);
            showr1.text = "MP +50 MP +30";
            if (gb.CurHPP1 > gb.MaxHPP1)
            {
                gb.CurHPP1 = gb.MaxHPP1;
            }
            if (gb.CurMPP1 > gb.MaxMPP1)
            {
                gb.CurMPP1 = gb.MaxMPP1;
            }
            a1 -= 1;
            dem = 1;
            if (a1 == 0)
            {
                aE1 = gb.SpeedE1 / 10;
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
        if (PlayerPrefs.GetInt("SB") > 0)
        {
            Item_panel.SetActive(false);
            gb.HPE1 -= 200;
            //showr2.SetActive(true);
            //showr1.text = "MP +50 MP +30";
            a1 -= 1;
            dem = 1;
            if (a1 == 0)
            {
                aE1 = gb.SpeedE1 / 10;
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
        //PlayerPrefs.SetInt("AfterHPP1", gb.CurHPP1);
        //PlayerPrefs.SetInt("AfterMPP1", gb.CurMPP1);
        //PlayerPrefs.SetInt("DTakeD", 1);
        //SceneManager.LoadScene(1);
    }
    public void PressBackToTheMap()
    {
        SceneManager.LoadScene(8);
    }
    public void CheckP1Die()
    {
        if(gb.CurHPP1 <=0)
        {
            HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
            MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
            HPE1.text = "HP: " + gb.HPE1.ToString();
            Invoke("delay3", 1f);
            Invoke("delay4", 2f);
        }
    }
    public void CheckE1Die()
    {
        if(gb.HPE1 <= 0)
        {
            ShowP1Panel(false);
            HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
            MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
            HPE1.text = "HP: " + gb.HPE1.ToString();
            stop = 1;
            LevelP1.text = "Level " + gb.LevelP1;
            EXPP1.text = gb.CurEXPP1 + "/" + gb.MaxEXPP1;
            Money.text = gb.Zen + " ";
            PlayerPrefs.SetInt("AfterHPP1", gb.CurHPP1);
            PlayerPrefs.SetInt("AfterMPP1", gb.CurMPP1);
            PlayerPrefs.SetInt("DTakeD", 1);
            Invoke("delay5", 1f);
            if (once == 0)
            {
                Invoke("delay6", 2f);
                once = 1;
            }
            PlayerPrefs.SetInt("AfterCurEXPP1", gb.CurEXPP1);
            PlayerPrefs.SetInt("AfterMaxEXPP1", gb.MaxEXPP1);
            PlayerPrefs.SetInt("AfterZen", gb.Zen);
            PlayerPrefs.SetInt("AfterLevelP1", gb.LevelP1);
            PlayerPrefs.SetInt("AfterMaxHPP1", gb.MaxHPP1);
            PlayerPrefs.SetInt("AfterMaxMPP1", gb.MaxMPP1);
            PlayerPrefs.SetInt("AfterDamageP1", gb.DamageP1);
            PlayerPrefs.SetInt("AfterSpeedP1", gb.SpeedP1);
        }
    }
    void delay()
    {
        CheckE1Die();
        ShowP1Panel(false);
        gb.CurHPP1 -= gb.DamageE1;
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HPE1.text = "HP: " + gb.HPE1.ToString();
        aE1 -= 1;
        if (aE1 == 0)
        {
            a1 = gb.SpeedP1 / 10;
        }
    }
    void delay1()
    {
        ShowP1Panel(false);
        gb.HPE1 -= gb.DamageP1;
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HPE1.text = "HP: " + gb.HPE1.ToString();
        a1 -= 1;
        show = 0;
        if (a1 == 0)
        {
            aE1 = gb.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delay2()
    {
        //Run P1 animation attack skill
        ShowP1Panel(false);
        gb.CurMPP1 -= 20;
        gb.HPE1 = gb.HPE1 - (gb.DamageP1 + (gb.DamageP1 * 100 / 100));
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HPE1.text = "HP: " + gb.HPE1.ToString();
        a1 -= 1;
        show = 0;
        if (a1 == 0)
        {
            aE1 = gb.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delay3()
    {
        HPMP.SetActive(false);
        Lose_panel.SetActive(true);
    }
    void delay4()
    {
        SceneManager.LoadScene(0);
    }
    void delay5()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delay6()
    {
        if(gb.LevelP1 < 30)
        {
            gb.CurEXPP1 += 10;
        }
        gb.Zen += 10;
        while(gb.CurEXPP1 >= gb.MaxEXPP1)
        {
            lu.SetActive(true);
            gb.CurEXPP1 -= gb.MaxEXPP1;
            gb.MaxEXPP1 += 40;
            gb.LevelP1 += 1;
            gb.MaxHPP1 += 20;
            gb.MaxMPP1 += 4;
            gb.DamageP1 += 10;
            gb.SpeedP1 += 1;
        }
        if (gb.LevelP1 < 30)
        {
            LevelP1.text = "Level " + gb.LevelP1;
            EXPP1.text = gb.CurEXPP1 + "/" + gb.MaxEXPP1;
        }
        else
        {
            LevelP1.text = "Level Max";
            EXPP1.text = "MAX";
        }
        Money.text = gb.Zen + " ";
        NB.SetActive(true);
    }
    void delayshowr()
    {
        showr2.SetActive(false);
    }
}
