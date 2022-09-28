using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSThief1 : MonoBehaviour
{
    PlayerBattle pb;
    ThiefBattle tb;
    public GameObject Item_panel;
    public GameObject showr2;
    public GameObject P1_panel;
    public GameObject P2_panel;
    public GameObject MariaStatus;
    public GameObject MariaBar;
    public GameObject P3_panel;
    public GameObject Win_panel;
    public GameObject MariaName;
    public GameObject MariaLevel;
    public GameObject MariaExp;
    public GameObject MariaPlusExp;
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
    public Text HP3;
    public Text MP3;
    public Text HPE1;
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
    public int a1, a2, a3, aE1;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    public int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int E1Hit;
    public bool P2Available, P3Availabel;
    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        tb = FindObjectOfType<ThiefBattle>();
        a1 = Global.SpeedP1 / 10;
        a2 = Global.SpeedP2 / 10;
        a3 = Global.SpeedP3 / 10;
        aE1 = Global.SpeedE1 / 10;

        if (CutscenesController.cus12 == 0)
        {
            MariaStatus.SetActive(false);
            MariaBar.SetActive(false);
            HP3.text = "";
            MP3.text = "";
            P3Availabel = false;
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
        CheckE1Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();
        if (Global.HPE1 <= 0)
            HPE1.text = "HP: 0";
        if (Global.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (Global.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (Global.CurHPP3 <= 0)
            HP3.text = "HP: 0";
        if (Global.SpeedP2 >= Global.SpeedE1)
        {
            if(a2 > 0 && Global.CurHPP2 > 0)
            {
                CheckE1Die();
                CheckP1Die();
                CheckP2Die();
                CheckP3Die();
                CheckP1P2P3Die();
                if(show2 == 0)
                    ShowP2Panel(true);
                else
                    ShowP2Panel(false);
            }
            else if (a1 > 0 && Global.CurHPP1 > 0)
            {
                CheckE1Die();
                CheckP1Die();
                CheckP2Die();
                CheckP3Die();
                CheckP1P2P3Die();
                if (show1 == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if (a3 > 0 && Global.CurHPP3 > 0 && P3Availabel == true)
            {
                CheckE1Die();
                CheckP1Die();
                CheckP2Die();
                CheckP3Die();
                CheckP1P2P3Die();
                if (show3 == 0)
                    ShowP3Panel(true);
                else
                    ShowP3Panel(false);
            }
            else if (aE1 > 0 && Global.HPE1 > 0)
            {
                CheckE1Die();
                ShowP1Panel(false);
                if (dem == 1)
                {
                    tb.yes_thief = 1;
                    Invoke("delayE1", 1f);
                    dem = 0;
                }
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
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

        HPE1.text = "HP: " + Global.HPE1.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPE1 < 0)
        {
            Global.HPE1 = 0;
            HPE1.text = "HP: " + Global.HPE1.ToString();
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
        Invoke("delayP1PressAttack", 1f);
        dem = 1;
    }
    public void PressAttackP2()
    {
        pb.yes3 = 1;
        show2 = 1;
        Invoke("delayP2PressAttack", 1f);
        dem = 1;
    }
    public void PressAttackP3()
    {
        pb.yes5 = 1;
        show3 = 1;
        Invoke("delayP3PressAttack", 1f);
        dem = 1;
    }
    public void PressSkill()
    {
        if (Global.CurMPP1 >= 20)
        {
            pb.yes2 = 1;
            show1 = 1;
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
            Invoke("delayP3PressSkill", 1f);
            dem = 1;
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
            dem = 1;
            dem_turn += 1;
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
            if (Global.CurMPP1 > Global.MaxMPP1)
            {
                Global.CurMPP1 = Global.MaxMPP1;
            }
            show1 = 0;
            a1 -= 1;
            dem = 1;
            dem_turn += 1;
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
            dem_turn += 1;
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
            a1 -= 1;
            dem_turn += 1;
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
        show1 = 0;
        Item_panel.SetActive(false);
    }
    public void PressRun()
    {
        SceneManager.LoadScene(2);
    }
    public void PressBackToTheMap2()
    {
        SceneManager.LoadScene(2);
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
    public void CheckP3Die()
    {
        if (Global.CurHPP3 <= 0)
        {
            pb.dead3 = 1;
        }
    }
    public void CheckP1P2P3Die()
    {
        if (Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0 && Global.CurHPP3 <=0)
        {
            UpdateUIText();
            Invoke("delayCheckP1P2P3Die1", 1f);
            Invoke("delayCheckP1P2P3Die2", 2f);
        }
    }
    public void CheckE1Die()
    {
        if (Global.HPE1 <= 0)
        {
            ShowP1Panel(false);
            ShowP2Panel(false);
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
        /*if (CutscenesController.cus12 == 0)
            E1Hit = Random.Range(1, 3);
        else if (CutscenesController.cus12 == 1)
            E1Hit = Random.Range(1, 4);

        if (E1Hit == 1 && Global.CurHPP1 > 0)
            Global.CurHPP1 -= Global.DamageE1;
        else if(E1Hit == 1 && Global.CurHPP1 <= 0 && Global.CurHPP2 > 0)
            Global.CurHPP2 -= Global.DamageE1;
        else if(E1Hit == 2 && Global.CurHPP2 >0)
            Global.CurHPP2 -= Global.DamageE1;
        else if(E1Hit == 2 && Global.CurHPP2 <= 0 && Global.CurHPP1 > 0)
            Global.CurHPP1 -= Global.DamageE1;*/

        E1AttackTarget();

        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        aE1 -= 1;
        dem_turn += 1;
        if (aE1 == 0)
        {
            a1 = Global.SpeedP1 / 10;
            a2 = Global.SpeedP2 / 10;
        }
    }
    void E1AttackTarget()
    {
        if (CutscenesController.cus12 == 0)
            E1Hit = Random.Range(1, 3);
        else if (CutscenesController.cus12 == 1)
            E1Hit = Random.Range(1, 4);

        if (E1Hit == 1 && Global.CurHPP1 > 0)
            Global.CurHPP1 -= Global.DamageE1;
        else if (E1Hit == 1 && Global.CurHPP1 <= 0)
            E1AttackTarget();
        else if (E1Hit == 2 && Global.CurHPP2 > 0)
            Global.CurHPP2 -= Global.DamageE1;
        else if (E1Hit == 2 && Global.CurHPP2 <= 0)
            E1AttackTarget();
        else if (E1Hit == 3 && Global.CurHPP3 > 0)
            Global.CurHPP3 -= Global.DamageE1;
        else if (E1Hit == 3 && Global.CurHPP3 <= 0)
            E1AttackTarget();
    }
    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        Global.HPE1 -= Global.DamageP1;
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPE1 -= Global.DamageP2;
        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        Global.HPE1 -= Global.DamageP3;
        HP3.text = "HP: " + Global.CurHPP3.ToString() + "/" + Global.MaxHPP3;
        MP3.text = "MP: " + Global.CurMPP3.ToString() + "/" + Global.MaxMPP3;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        if (a3 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delayP1PressSkill()
    {
        Global.CurMPP1 -= 20;
        Global.HPE1 = Global.HPE1 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delayP2PressSkill()
    {
        Global.CurMPP2 -= 20;
        Global.HPE1 = Global.HPE1 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        HPE1.text = "HP: " + Global.HPE1.ToString();
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        CheckE1Die();
    }
    void delayP3PressSkill()
    {
        Global.CurMPP3 -= 40;
        int HealAmount = Global.DamageP3 * 20 / 100;
        int CheckMaxhealP1 = Global.MaxHPP1 - Global.CurHPP1;
        int CheckMaxhealP2 = Global.MaxHPP2 - Global.CurHPP2;

        if (HealAmount < CheckMaxhealP1)
        {
            Global.CurHPP1 += HealAmount;
        }
        else
        {
            Global.CurHPP1 = Global.MaxHPP1;
        }
        if (HealAmount < CheckMaxhealP2)
        {
            Global.CurHPP2 += HealAmount;
        }
        else
        {
            Global.CurHPP2 = Global.MaxHPP2;
        }

        HP1.text = "HP: " + Global.CurHPP1.ToString() + "/" + Global.MaxHPP1;
        MP1.text = "MP: " + Global.CurMPP1.ToString() + "/" + Global.MaxMPP1;
        HP2.text = "HP: " + Global.CurHPP2.ToString() + "/" + Global.MaxHPP2;
        MP2.text = "MP: " + Global.CurMPP2.ToString() + "/" + Global.MaxMPP2;
        HP3.text = "HP: " + Global.CurHPP3.ToString() + "/" + Global.MaxHPP3;
        MP3.text = "MP: " + Global.CurMPP3.ToString() + "/" + Global.MaxMPP3;
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        if (a3 == 0)
        {
            aE1 = Global.SpeedE1 / 10;
        }
        //CheckE1Die();
    }
    void delayCheckP1P2P3Die1()
    {
        HPMP.SetActive(false);
        Lose_panel.SetActive(true);
    }
    void delayCheckP1P2P3Die2()
    {
        SceneManager.LoadScene(1);
    }
    void delayCheckE1Die1()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckE1Die2()
    {
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += 10;
        }
        if (Global.LevelP2 < 30)
        {
            Global.CurEXPP2 += 10;
        }
        if (Global.LevelP3 < 30 && P3Availabel == true)
        {
            Global.CurEXPP3 += 10;
        }
        Global.Zen += 10;
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
    void delayshowr()
    {
        showr2.SetActive(false);
    }
}
