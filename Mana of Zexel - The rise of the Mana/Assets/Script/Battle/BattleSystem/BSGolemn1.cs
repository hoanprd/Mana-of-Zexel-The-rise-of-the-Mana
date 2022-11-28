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
    public GameObject MariaStatus;
    public GameObject MariaBar;
    public GameObject P3_panel;
    public GameObject Win_panel;
    public GameObject MariaName;
    public GameObject MariaLevel;
    public GameObject MariaExp;
    public GameObject MariaPlusExp;
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
    public Text HP2;
    public Text MP2;
    public Text HP3;
    public Text MP3;
    public Text HPE3;
    public Text EXPP1;
    public Text EXPP2;
    public Text EXPP3;
    public Text Money;
    public Text ManaGemItem;
    public Text LevelP1;
    public Text LevelP2;
    public Text LevelP3;
    public Text NumTurn;
    public GameObject lu;
    public GameObject lu2;
    public GameObject lu3;
    public GameObject HPMP;
    public GameObject NB;
    public int a1, a2, a3, aE3;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    private int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int E3Hit;
    public bool P2Available, P3Availabel;
    public int UseItemIndex;
    // Start is called before the first frame update
    void Start()
    {
        //gb = FindObjectOfType<Global>();
        pb = FindObjectOfType<PlayerBattle>();
        GB = FindObjectOfType<GolemnBattle>();
        a1 = Global.SpeedP1 / 10;
        a2 = Global.SpeedP2 / 10;
        a3 = Global.SpeedP3 / 10;
        aE3 = Global.SpeedE3 / 10;

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
        CheckE3Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();

        if (Global.SpeedP2 >= Global.SpeedE3)
        {
            if(a2 > 0 && Global.CurHPP2 > 0)
            {
                CheckE3Die();
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
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
                CheckP1P2P3Die();
                UseItemIndex = 1;
                if (show1 == 0)
                    ShowP1Panel(true);
                else
                    ShowP1Panel(false);
            }
            else if (aE3 > 0 && Global.HPE3 > 0)
            {
                CheckE3Die();
                ShowP1Panel(false);
                ShowP2Panel(false);
                ShowP3Panel(false);
                if (dem == 2)
                {
                    GB.yes_golemn = 1;
                    dem -= 1;
                    EDamage.color = Color.red;
                    EDamage.text = "-" + Global.DamageE3;
                    Invoke("delayE3", 1f);
                    Invoke("delayeE3attack2", 2f);
                }
                CheckP1Die();
                CheckP2Die();
                CheckP1P2P3Die();
            }
            else if (a3 > 0 && Global.CurHPP3 > 0 && P3Availabel == true)
            {
                CheckE3Die();
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

        HPE3.text = "HP: " + Global.HPE3.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPE3 < 0)
        {
            Global.HPE3 = 0;
            HPE3.text = "HP: " + Global.HPE3.ToString();
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
            HPE3.text = "HP: 0";
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
        dem = 2;
    }
    public void PressAttackP2()
    {
        pb.yes3 = 1;
        show2 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP2;
        Invoke("delayP2PressAttack", 1f);
        dem = 2;
    }
    public void PressAttackP3()
    {
        pb.yes5 = 1;
        show3 = 1;
        PDamage.color = Color.red;
        PDamage.text = "-" + Global.DamageP3;
        Invoke("delayP3PressAttack", 1f);
        dem = 2;
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
            dem = 2;
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
            dem = 2;
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

            if (UseItemIndex == 1)
                Global.CurHPP1 += 50;
            else if (UseItemIndex == 3)
                Global.CurHPP3 += 50;

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
            if (a1 == 0 || a3 == 0)
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

            if (UseItemIndex == 1)
                Global.CurMPP1 += 30;
            else if (UseItemIndex == 3)
                Global.CurMPP3 += 30;

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
            if (a1 == 0 || a3 == 0)
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

            if (UseItemIndex == 1)
            {
                Global.CurHPP1 += 50;
                Global.CurMPP1 += 30;
            }
            else if (UseItemIndex == 3)
            {
                Global.CurHPP3 += 50;
                Global.CurMPP3 += 30;
            }

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
            if (a1 == 0 || a3 == 0)
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
    public void UseB()
    {
        if (ContainerController.Bom > 0)
        {
            Item_panel.SetActive(false);
            Global.HPE3 -= 200;
            //showr2.SetActive(true);
            //showr1.text = "MP +50 MP +30";
            ContainerController.Bom -= 1;
            PDamage.color = Color.red;
            PDamage.text = "-200";
            a1 -= 1;
            dem_turn += 1;
            dem = 2;
            if (a1 == 0 || a3 == 0)
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
    public void CloseItemPanel()
    {
        show1 = 0;
        Item_panel.SetActive(false);
    }
    public void PressRun()
    {
        SceneManager.LoadScene("Wishing forest");
    }
    public void PressBackToTheMap2()
    {
        ContainerController.ManaGem += 1;
        SceneManager.LoadScene("Wishing forest");
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
        if (Global.CurHPP1 <= 0 && Global.CurHPP2 <= 0)
        {
            UpdateUIText();
            Invoke("delayCheckP1P2P3Die1", 1f);
            Invoke("delayCheckP1P2P3Die2", 2f);
        }
    }
    public void CheckE3Die()
    {
        if (Global.HPE3 <= 0)
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
            ManaGemItem.text = "Mana Gem +1";

            Invoke("delayCheckE3Die1", 1f);
            if (once == 0)
            {
                Invoke("delayCheckE3Die2", 2f);
                once = 1;
            }
        }
    }
    void delayE3()
    {
        CheckE3Die();
        ShowP1Panel(false);
        ShowP2Panel(false);
        ShowP3Panel(false);
        E3AttackTarget();
        EDamage.text = "";

        aE3 -= 1;
        dem_turn += 1;
        if (aE3 == 0)
        {
            a1 = Global.SpeedP1 / 10;
            a2 = Global.SpeedP2 / 10;
            a3 = Global.SpeedP3 / 10;
        }
    }

    void E3AttackTarget()
    {
        if (CutscenesController.cus12 == 0)
            E3Hit = Random.Range(1, 3);
        else if (CutscenesController.cus12 == 1)
            E3Hit = Random.Range(1, 4);

        if (E3Hit == 1 && Global.CurHPP1 > 0)
            Global.CurHPP1 -= Global.DamageE3;
        else if (E3Hit == 1 && Global.CurHPP1 <= 0)
            E3AttackTarget();
        else if (E3Hit == 2 && Global.CurHPP2 > 0)
            Global.CurHPP2 -= Global.DamageE3;
        else if (E3Hit == 2 && Global.CurHPP2 <= 0)
            E3AttackTarget();
        else if (E3Hit == 3 && Global.CurHPP3 > 0)
            Global.CurHPP3 -= Global.DamageE3;
        else if (E3Hit == 3 && Global.CurHPP3 <= 0)
            E3AttackTarget();
    }

    void delayeE3attack2()
    {
        if (dem == 1)
        {
            GB.yes_golemn = 1;
            dem -= 1;
            EDamage.color = Color.red;
            EDamage.text = "-" + Global.DamageE3;
            Invoke("delayE3", 1f);
        }
    }
    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        Global.HPE3 -= Global.DamageP1;
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPE3 -= Global.DamageP2;
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        Global.HPE3 -= Global.DamageP3;
        PDamage.text = "";
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        if (a3 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delayP1PressSkill()
    {
        Global.CurMPP1 -= 20;
        Global.HPE3 = Global.HPE3 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        if (a1 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
    }
    void delayP2PressSkill()
    {
        Global.CurMPP2 -= 20;
        Global.HPE3 = Global.HPE3 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        if (a2 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
        }
        CheckE3Die();
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

        UpdateUIText();
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        if (a3 == 0)
        {
            aE3 = Global.SpeedE3 / 10;
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
    void delayCheckE3Die1()
    {
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckE3Die2()
    {
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += 40;
        }
        if (Global.LevelP2 < 30)
        {
            Global.CurEXPP2 += 40;
        }
        if (Global.LevelP3 < 30 && P3Availabel == true)
        {
            Global.CurEXPP3 += 40;
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
        PDamage.text = "";
        showr2.SetActive(false);
    }
}
