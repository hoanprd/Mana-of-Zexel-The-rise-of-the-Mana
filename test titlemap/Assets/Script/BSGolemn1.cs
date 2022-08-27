using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSGolemn1 : MonoBehaviour
{
    Global gb;
    PlayerBattle pb;
    GolemnBattle GB;
    public GameObject Item_panel;
    public GameObject showr2;
    public GameObject P1_panel;
    public GameObject P2_panel;
    public GameObject Win_panel;
    public GameObject Lose_panel;
    public Text num1;
    public Text num2;
    public Text num3;
    public Text num4;
    public Text showr1;
    public Text HP1;
    public Text MP1;
    public Text HP2;
    public Text MP2;
    public Text HPE3;
    public Text EXPP1;
    public Text EXPP2;
    public Text Money;
    public Text LevelP1;
    public Text LevelP2;
    public Text NumTurn;
    public GameObject lu;
    public GameObject lu2;
    public GameObject HPMP;
    public GameObject NB;
    public int a1, a2, aE3;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    private int show1 = 0;
    public int show2 = 0;
    public int E3Hit;
    // Start is called before the first frame update
    void Start()
    {
        gb = FindObjectOfType<Global>();
        pb = FindObjectOfType<PlayerBattle>();
        GB = FindObjectOfType<GolemnBattle>();
        a1 = gb.SpeedP1 / 10;
        Debug.Log(gb.SpeedP2);
        a2 = gb.SpeedP2 / 10;
        Debug.Log(a2);
        aE3 = gb.SpeedE3 / 10;
        if (gb.CurHPP1 > 0)
            pb.dead1 = 0;
        if (gb.CurHPP2 > 0)
            pb.dead2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CheckE3Die();
        CheckP1P2Die();
        CheckP1Die();
        CheckP2Die();
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HP2.text = "HP: " + gb.CurHPP2.ToString() + "/" + gb.MaxHPP2;
        MP2.text = "MP: " + gb.CurMPP2.ToString() + "/" + gb.MaxMPP2;
        HPE3.text = "HP: " + gb.HPE3.ToString();
        NumTurn.text = "Turn " + dem_turn.ToString();
        if (gb.HPE3 <= 0)
            HPE3.text = "HP: 0";
        if (gb.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (gb.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (gb.SpeedP2 >= gb.SpeedE3)
        {
            if(a2 > 0 && gb.CurHPP2 > 0)
            {
                CheckE3Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2Die();
                if(show2 == 0)
                    ShowP2Panel(true);
                else
                    ShowP2Panel(false);
            }
            else if (a1 > 0 && gb.CurHPP1 > 0)
            {
                CheckE3Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2Die();
                if (show1 == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if (aE3 > 0 && gb.HPE3 > 0)
            {
                CheckE3Die();
                ShowP1Panel(false);
                if (dem == 2)
                {
                    GB.yes_golemn = 1;
                    dem -= 1;
                    Invoke("delay", 1f);
                    Invoke("delaye3attack2", 2f);
                }
                CheckP1Die();
                CheckP2Die();
                CheckP1P2Die();
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
    public void ShowP2Panel(bool isshow)
    {
        if (P2_panel)
        {
            P2_panel.SetActive(isshow);
        }
    }
    public void PressAttack()
    {
        pb.yes1 = 1;
        show1 = 1;
        Invoke("delay1", 1f);
        dem = 2;
    }
    public void PressAttackP2()
    {
        pb.yes3 = 1;
        show2 = 1;
        Invoke("delay7", 1f);
        dem = 2;
    }
    public void PressSkill()
    {
        if (gb.CurMPP1 >= 20)
        {
            pb.yes2 = 1;
            show1 = 1;
            Invoke("delay2", 1f);
            dem = 2;
        }
    }
    public void PressSkillP2()
    {
        if (gb.CurMPP2 >= 20)
        {
            pb.yes4 = 1;
            show2 = 1;
            Invoke("delay8", 1f);
            dem = 2;
        }
    }
    public void PressItem()
    {
        show1 = 1;
        num1.text = PlayerPrefs.GetInt("SHP") + "";
        num2.text = PlayerPrefs.GetInt("SMP") + "";
        num3.text = PlayerPrefs.GetInt("SEP") + "";
        num4.text = PlayerPrefs.GetInt("SB") + "";
        Item_panel.SetActive(true);
    }
    public void UseHP()
    {
        if (PlayerPrefs.GetInt("SHP") > 0)
        {
            Item_panel.SetActive(false);
            gb.CurHPP1 += 50;
            showr2.SetActive(true);
            showr1.text = "HP +50";
            PlayerPrefs.SetInt("SHP", PlayerPrefs.GetInt("SHP") - 1);
            if (gb.CurHPP1 > gb.MaxHPP1)
            {
                gb.CurHPP1 = gb.MaxHPP1;
            }
            show1 = 0;
            a1 -= 1;
            dem = 2;
            dem_turn += 1;
            if (a1 == 0)
            {
                aE3 = gb.SpeedE3 / 10;
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
            PlayerPrefs.SetInt("SMP", PlayerPrefs.GetInt("SMP") - 1);
            if (gb.CurMPP1 > gb.MaxMPP1)
            {
                gb.CurMPP1 = gb.MaxMPP1;
            }
            show1 = 0;
            a1 -= 1;
            dem = 2;
            dem_turn += 1;
            if (a1 == 0)
            {
                aE3 = gb.SpeedE3 / 10;
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
            PlayerPrefs.SetInt("SEP", PlayerPrefs.GetInt("SEP") - 1);
            if (gb.CurHPP1 > gb.MaxHPP1)
            {
                gb.CurHPP1 = gb.MaxHPP1;
            }
            if (gb.CurMPP1 > gb.MaxMPP1)
            {
                gb.CurMPP1 = gb.MaxMPP1;
            }
            a1 -= 1;
            dem_turn += 1;
            dem = 2;
            if (a1 == 0)
            {
                aE3 = gb.SpeedE2 / 10;
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
            gb.HPE3 -= 200;
            //showr2.SetActive(true);
            //showr1.text = "MP +50 MP +30";
            PlayerPrefs.SetInt("SB", PlayerPrefs.GetInt("SB") - 1);
            a1 -= 1;
            dem_turn += 1;
            dem = 2;
            if (a1 == 0)
            {
                aE3 = gb.SpeedE2 / 10;
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
        show1 = 0;
        Item_panel.SetActive(false);
    }
    public void PressRun()
    {
        PlayerPrefs.SetInt("AfterHPP1", gb.CurHPP1);
        PlayerPrefs.SetInt("AfterMPP1", gb.CurMPP1);
        PlayerPrefs.SetInt("AfterHPP2", gb.CurHPP2);
        PlayerPrefs.SetInt("AfterMPP2", gb.CurMPP2);
        PlayerPrefs.SetInt("DTakeD", 1);
        SceneManager.LoadScene(4);
    }
    public void PressBackToTheMap2()
    {
        /*if(PlayerPrefs.GetInt("cus6") == 1 && PlayerPrefs.GetInt("cus7") == 0)
        {
            PlayerPrefs.SetInt("KGQ", PlayerPrefs.GetInt("KGQ") + 1);
            if (PlayerPrefs.GetInt("KGQ") > 4)
                PlayerPrefs.SetInt("KGQ", 4);
        }*/
        PlayerPrefs.SetInt("SMG", PlayerPrefs.GetInt("SMG") + 1);
        SceneManager.LoadScene(4);
    }
    public void CheckP1Die()
    {
        if(gb.CurHPP1 <= 0)
        {
            pb.dead1 = 1;
        }
    }
    public void CheckP2Die()
    {
        if(gb.CurHPP2 <= 0)
        {
            pb.dead2 = 1;
        }
    }
    public void CheckP1P2Die()
    {
        if (gb.CurHPP1 <= 0 && gb.CurHPP2 <= 0)
        {
            HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
            MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
            HP2.text = "HP: " + gb.CurHPP2.ToString() + "/" + gb.MaxHPP2;
            MP2.text = "MP: " + gb.CurMPP2.ToString() + "/" + gb.MaxMPP2;
            HPE3.text = "HP: " + gb.HPE3.ToString();
            Invoke("delay3", 1f);
            Invoke("delay4", 2f);
        }
    }
    public void CheckE3Die()
    {
        if (gb.HPE3 <= 0)
        {
            ShowP1Panel(false);
            ShowP2Panel(false);
            HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
            MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
            HP2.text = "HP: " + gb.CurHPP2.ToString() + "/" + gb.MaxHPP2;
            MP2.text = "MP: " + gb.CurMPP2.ToString() + "/" + gb.MaxMPP2;
            HPE3.text = "HP: " + gb.HPE3.ToString();
            HPE3.text = "HP: 0";
            stop = 1;
            LevelP1.text = "Level " + gb.LevelP1;
            EXPP1.text = gb.CurEXPP1 + "/" + gb.MaxEXPP1;
            Money.text = gb.Zen + " ";
            LevelP2.text = "Level " + gb.LevelP2;
            EXPP2.text = gb.CurEXPP2 + "/" + gb.MaxEXPP2;
            PlayerPrefs.SetInt("AfterHPP1", gb.CurHPP1);
            PlayerPrefs.SetInt("AfterMPP1", gb.CurMPP1);
            PlayerPrefs.SetInt("AfterHPP2", gb.CurHPP2);
            PlayerPrefs.SetInt("AfterMPP2", gb.CurMPP2);
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

            PlayerPrefs.SetInt("AfterCurEXPP2", gb.CurEXPP2);
            PlayerPrefs.SetInt("AfterMaxEXPP2", gb.MaxEXPP2);
            PlayerPrefs.SetInt("AfterLevelP2", gb.LevelP2);
            PlayerPrefs.SetInt("AfterMaxHPP2", gb.MaxHPP2);
            PlayerPrefs.SetInt("AfterMaxMPP2", gb.MaxMPP2);
            PlayerPrefs.SetInt("AfterDamageP2", gb.DamageP2);
            PlayerPrefs.SetInt("AfterSpeedP2", gb.SpeedP2);
        }
    }
    void delay()
    {
        CheckE3Die();
        ShowP1Panel(false);
        E3Hit = Random.Range(1, 3);
        if(E3Hit == 1 && gb.CurHPP1 > 0)
            gb.CurHPP1 -= gb.DamageE3;
        else if(E3Hit == 1 && gb.CurHPP1 <= 0 && gb.CurHPP2 > 0)
            gb.CurHPP2 -= gb.DamageE3;
        else if(E3Hit == 2 && gb.CurHPP2 >0)
            gb.CurHPP2 -= gb.DamageE3;
        else if(E3Hit == 2 && gb.CurHPP2 <= 0 && gb.CurHPP1 > 0)
            gb.CurHPP1 -= gb.DamageE3;
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HPE3.text = "HP: " + gb.HPE3.ToString();
        aE3 -= 1;
        dem_turn += 1;
        if (aE3 == 0)
        {
            a1 = gb.SpeedP1 / 10;
            a2 = gb.SpeedP2 / 10;
        }
    }
    void delaye3attack2()
    {
        if (dem == 1)
        {
            GB.yes_golemn = 1;
            dem -= 1;
            Invoke("delay", 1f);
        }
    }
    void delay1()
    {
        ShowP1Panel(false);
        gb.HPE3 -= gb.DamageP1;
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HPE3.text = "HP: " + gb.HPE3.ToString();
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE3 = gb.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delay7()
    {
        ShowP2Panel(false);
        gb.HPE3 -= gb.DamageP2;
        HP2.text = "HP: " + gb.CurHPP2.ToString() + "/" + gb.MaxHPP2;
        MP2.text = "MP: " + gb.CurMPP2.ToString() + "/" + gb.MaxMPP2;
        HPE3.text = "HP: " + gb.HPE3.ToString();
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE3 = gb.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delay2()
    {
        gb.CurMPP1 -= 20;
        gb.HPE3 = gb.HPE3 - (gb.DamageP1 + (gb.DamageP1 * 100 / 100));
        HP1.text = "HP: " + gb.CurHPP1.ToString() + "/" + gb.MaxHPP1;
        MP1.text = "MP: " + gb.CurMPP1.ToString() + "/" + gb.MaxMPP1;
        HPE3.text = "HP: " + gb.HPE3.ToString();
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE3 = gb.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delay8()
    {
        gb.CurMPP2 -= 20;
        gb.HPE3 = gb.HPE3 - (gb.DamageP2 + (gb.DamageP2 * 100 / 100));
        HP2.text = "HP: " + gb.CurHPP2.ToString() + "/" + gb.MaxHPP2;
        MP2.text = "MP: " + gb.CurMPP2.ToString() + "/" + gb.MaxMPP2;
        HPE3.text = "HP: " + gb.HPE3.ToString();
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE3 = gb.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delay3()
    {
        HPMP.SetActive(false);
        Lose_panel.SetActive(true);
    }
    void delay4()
    {
        SceneManager.LoadScene(1);
    }
    void delay5()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delay6()
    {
        if (gb.LevelP1 < 30)
        {
            gb.CurEXPP1 += 40;
        }
        if (gb.LevelP2 < 30)
        {
            gb.CurEXPP2 += 40;
        }
        gb.Zen += 40;
        while (gb.CurEXPP1 >= gb.MaxEXPP1)
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
        while (gb.CurEXPP2 >= gb.MaxEXPP2)
        {
            lu2.SetActive(true);
            gb.CurEXPP2 -= gb.MaxEXPP2;
            gb.MaxEXPP2 += 40;
            gb.LevelP2 += 1;
            gb.MaxHPP2 += 10;
            gb.MaxMPP2 += 3;
            gb.DamageP2 += 15;
            gb.SpeedP2 += 1;
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
        if (gb.LevelP2 < 30)
        {
            LevelP2.text = "Level " + gb.LevelP2;
            EXPP2.text = gb.CurEXPP2 + "/" + gb.MaxEXPP2;
        }
        else
        {
            LevelP2.text = "Level Max";
            EXPP2.text = "MAX";
        }
        Money.text = gb.Zen + " ";
        NB.SetActive(true);
    }
    void delayshowr()
    {
        showr2.SetActive(false);
    }
}
