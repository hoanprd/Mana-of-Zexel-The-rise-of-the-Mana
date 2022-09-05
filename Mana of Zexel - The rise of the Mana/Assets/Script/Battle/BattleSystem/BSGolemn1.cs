using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSGolemn1 : MonoBehaviour
{
    //Global gb;
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
        //gb = FindObjectOfType<Global>();
        pb = FindObjectOfType<PlayerBattle>();
        GB = FindObjectOfType<GolemnBattle>();
        a1 = Global.SpeedP1 / 10;
        Debug.Log(Global.SpeedP2);
        a2 = Global.SpeedP2 / 10;
        Debug.Log(a2);
        aE3 = Global.SpeedE3 / 10;
        if (Global.CurHPP1 > 0)
            pb.dead1 = 0;
        if (Global.CurHPP2 > 0)
            pb.dead2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CheckE3Die();
        CheckP1P2Die();
        CheckP1Die();
        CheckP2Die();
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        HPE3.text = "HP: " + Global.HPE3.ToString();
        NumTurn.text = "Turn " + dem_turn.ToString();
        if (Global.HPE3 <= 0)
            HPE3.text = "HP: 0";
        if (Global.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (Global.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (Global.SpeedP2 >= Global.SpeedE3)
        {
            if(a2 > 0 && Global.CurHPP2 > 0)
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
            else if (a1 > 0 && Global.CurHPP1 > 0)
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
            else if (aE3 > 0 && Global.HPE3 > 0)
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
        if (Global.CurMPP1 >= 20)
        {
            pb.yes2 = 1;
            show1 = 1;
            Invoke("delay2", 1f);
            dem = 2;
        }
    }
    public void PressSkillP2()
    {
        if (Global.CurMPP2 >= 20)
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
        num1.text = ContainerController.HealPotion + "";
        num2.text = ContainerController.ManaPotion + "";
        num3.text = ContainerController.ElixirPotion + "";
        num4.text = ContainerController.Bom + "";
        Item_panel.SetActive(true);
    }
    public void UseHP()
    {
        if (ContainerController.HealPotion > 0)
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
            show1 = 0;
            a1 -= 1;
            dem = 2;
            dem_turn += 1;
            if (a1 == 0)
            {
                aE3 = Global.SpeedE3 / 10;
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
            if (Global.CurMPP1 > Global.MaxMPP1)
            {
                Global.CurMPP1 = Global.MaxMPP1;
            }
            show1 = 0;
            a1 -= 1;
            dem = 2;
            dem_turn += 1;
            if (a1 == 0)
            {
                aE3 = Global.SpeedE3 / 10;
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
            dem_turn += 1;
            dem = 2;
            if (a1 == 0)
            {
                aE3 = Global.SpeedE2 / 10;
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
            Global.HPE3 -= 200;
            //showr2.SetActive(true);
            //showr1.text = "MP +50 MP +30";
            ContainerController.Bom -= 1;
            a1 -= 1;
            dem_turn += 1;
            dem = 2;
            if (a1 == 0)
            {
                aE3 = Global.SpeedE2 / 10;
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
        SceneManager.LoadScene(4);
    }
    public void PressBackToTheMap2()
    {
        ContainerController.ManaGem += 1;
        SceneManager.LoadScene(4);
    }
    public void CheckP1Die()
    {
        if(Global.CurHPP1 <= 0)
        {
            pb.dead1 = 1;
        }
    }
    public void CheckP2Die()
    {
        if(Global.CurHPP2 <= 0)
        {
            pb.dead2 = 1;
        }
    }
    public void CheckP1P2Die()
    {
        if (Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0)
        {
            HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
            MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
            HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
            MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
            HPE3.text = "HP: " + Global.HPE3.ToString();
            Invoke("delay3", 1f);
            Invoke("delay4", 2f);
        }
    }
    public void CheckE3Die()
    {
        if (Global.HPE3 <= 0)
        {
            ShowP1Panel(false);
            ShowP2Panel(false);
            HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
            MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
            HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
            MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
            HPE3.text = "HP: " + Global.HPE3.ToString();
            HPE3.text = "HP: 0";
            stop = 1;
            LevelP1.text = "Level " + Global.LevelP1;
            EXPP1.text = Global.CurEXPP1 + "/" + Global.MaxEXPP1;
            Money.text = Global.Zen + " ";
            LevelP2.text = "Level " + Global.LevelP2;
            EXPP2.text = Global.CurEXPP2 + "/" + Global.MaxEXPP2;
            Invoke("delay5", 1f);
            if (once == 0)
            {
                Invoke("delay6", 2f);
                once = 1;
            }
        }
    }
    void delay()
    {
        CheckE3Die();
        ShowP1Panel(false);
        E3Hit = Random.Range(1, 3);
        if(E3Hit == 1 && Global.CurHPP1 > 0)
            Global.CurHPP1 -= Global.DamageE3;
        else if(E3Hit == 1 && Global.CurHPP1 <= 0 && Global.CurHPP2 > 0)
            Global.CurHPP2 -= Global.DamageE3;
        else if(E3Hit == 2 && Global.CurHPP2 >0)
            Global.CurHPP2 -= Global.DamageE3;
        else if(E3Hit == 2 && Global.CurHPP2 <= 0 && Global.CurHPP1 > 0)
            Global.CurHPP1 -= Global.DamageE3;
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE3.text = "HP: " + Global.HPE3.ToString();
        aE3 -= 1;
        dem_turn += 1;
        if (aE3 == 0)
        {
            a1 = Global.SpeedP1 / 10;
            a2 = Global.SpeedP2 / 10;
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
        Global.HPE3 -= Global.DamageP1;
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE3.text = "HP: " + Global.HPE3.ToString();
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delay7()
    {
        ShowP2Panel(false);
        Global.HPE3 -= Global.DamageP2;
        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        HPE3.text = "HP: " + Global.HPE3.ToString();
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delay2()
    {
        Global.CurMPP1 -= 20;
        Global.HPE3 = Global.HPE3 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE3.text = "HP: " + Global.HPE3.ToString();
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delay8()
    {
        Global.CurMPP2 -= 20;
        Global.HPE3 = Global.HPE3 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        HPE3.text = "HP: " + Global.HPE3.ToString();
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
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
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += 40;
        }
        if (Global.LevelP2 < 30)
        {
            Global.CurEXPP2 += 40;
        }
        Global.Zen += 40;
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
        Money.text = Global.Zen + " ";
        NB.SetActive(true);
    }
    void delayshowr()
    {
        showr2.SetActive(false);
    }
}
