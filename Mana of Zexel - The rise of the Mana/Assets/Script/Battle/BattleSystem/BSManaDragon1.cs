using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BSManaDragon1 : MonoBehaviour
{
    PlayerBattle pb;
    ManaDragonBattle MDB;

    [SerializeField] private Camera cam;

    public AudioSource VayneAttackFX, AliaAttackFX, MariaAttackFX, VayneSkill1FX, VayneSkill2FX, VayneSkill3FX, AliaSkill1FX, AliaSkill2FX, AliaSkill3FX, MariaSkill1FX, MariaSkill2FX, MariaSkill3FX, EnemyAttack1FX, EnemyAttack2FX, EnemySkillChargeFX, EnemySkill1FX, HealFX, ExplosionFX, OpenCloseFX;

    public GameObject[] _canvasObject;

    public GameObject Item_panel;
    public GameObject HPHealingEffP1, MPHealingEffP1, EPHealingEffP1, HPHealingEffP3, MPHealingEffP3, EPHealingEffP3, BomEff, ReinEff;
    public GameObject VayneAttackEffect, VayneSkill2Effect, VayneSkill3Effect, MariaAttackEffect, MariaSkill3Effect;
    public GameObject showr2;
    public GameObject P1_panel;
    public GameObject P2_panel;
    public GameObject P3_panel;

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

    public GameObject SkillChargeSign;

    public Text P1TurnStatus;
    public Text P3TurnStatus;
    public Text BE3TurnStatus;

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
    public Text HPBE3;
    public Text EXPP1;
    public Text EXPP2;
    public Text EXPP3;
    public Text Money;
    public Text DragonScalesManaItem;
    public Text LevelP1;
    public Text LevelP2;
    public Text LevelP3;
    public Text NumTurn;
    public GameObject lu;
    public GameObject lu2;
    public GameObject lu3;
    public GameObject HPMP;
    public GameObject NB;
    public int a1, a2, a3, aBE3;
    public int stop = 0;
    private int dem = 0;
    private int dem_turn = 1;
    private int once = 0;
    public int show1 = 0;
    public int show2 = 0;
    public int show3 = 0;
    public int onceUIText;
    public int BE3Hit;
    public bool GameOver, P2Available;
    public int UseItemIndex, ChooseSkillIndex;
    public int BE3ANum, TurnIndex, BossSkillCharge, BossSkillEngage, BossSkillBreak, BeforeBreakSkillDamageCal, AfterBreakDamageCal, BreakDamageCal, BreakDamageIndex;
    private float zoomChange, zoom, zoomMultiplier, minZoom, maxZoom, velocity, smoothTime;
    private bool zoomStart, zoomDone;

    // Start is called before the first frame update
    void Start()
    {
        pb = FindObjectOfType<PlayerBattle>();
        MDB = FindObjectOfType<ManaDragonBattle>();

        CanvasDisplay(false);
        zoomChange = 0f;
        zoom = cam.orthographicSize;
        zoomMultiplier = 4f;
        minZoom = 1f;
        maxZoom = 5f;
        velocity = 0f;
        smoothTime = 0.25f;
        zoomStart = false;
        zoomDone = false;
        StartCoroutine(CamZoomDisplay());

        GameOver = false;
        HubController.BusyHub = true;
        onceUIText = 0;

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
        aBE3 = Global.SpeedBE3 / 10;

        BreakDamageIndex = 0;
        BossSkillCharge = 0;

        if (CutscenesController.cus93 == 1 && CutscenesController.cus103 == 0)
        {
            AliaStatus.SetActive(false);
            AliaBar.SetActive(false);
            a2 = 0;
            dem = 1;
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
        if (zoomStart == true && zoomChange <= 5)
        {
            zoomChange += Time.deltaTime;
            zoom += zoomChange * zoomMultiplier;
            zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref velocity, smoothTime);
        }

        CheckBE3Die();
        CheckP1P2P3Die();
        CheckP1Die();
        CheckP2Die();
        CheckP3Die();
        UpdateUIText();

        if (a2 > 0 && Global.CurHPP2 > 0 && P2Available == true && GameOver == false && zoomDone == true)
        {
            CheckBE3Die();
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
            TurnIndex = 2;
            if (show2 == 0)
                ShowP2Panel(true);
            else
                ShowP2Panel(false);
        }
        else if (a1 > 0 && Global.CurHPP1 > 0 && GameOver == false && zoomDone == true)
        {
            CheckBE3Die();
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
            UseItemIndex = 1;
            if (show1 == 0)
                ShowP1Panel(true);
            else
                ShowP1Panel(false);
        }
        else if (a3 > 0 && Global.CurHPP3 > 0 && GameOver == false && zoomDone == true)
        {
            CheckBE3Die();
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
        else if (aBE3 > 0 && Global.HPBE3 > 0 && GameOver == false && zoomDone == true)
        {
            CheckBE3Die();
            ShowP1Panel(false);
            ShowP2Panel(false);
            ShowP3Panel(false);
            if (dem == 1)
            {
                BE3Action();

                if (BossSkillCharge == 1)
                {
                    dem = 0;
                }
                else
                {
                    dem -= 1;
                }

                EDamage.color = Color.red;
                if (BE3ANum <= 5)
                    EDamage.text = "-" + Global.DamageBE3;

                Invoke("delayBE3", 2f);
            }
            CheckP1Die();
            CheckP2Die();
            CheckP1P2P3Die();
        }

        if (a1 == 0 && a2 == 0 && a3 == 0 && aBE3 == 0)
        {
            if (P2Available == false)
            {
                a1 = Global.SpeedP1 / 10;
                a3 = Global.SpeedP3 / 10;
                aBE3 = Global.SpeedBE3 / 10;
                dem = 1;
            }
            else
            {
                a1 = Global.SpeedP1 / 10;
                a2 = Global.SpeedP2 / 10;
                a3 = Global.SpeedP3 / 10;
                aBE3 = Global.SpeedBE3 / 10;
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
            aBE3 = 0;
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

        HP3.text = "HP: " + Global.CurHPP3.ToString() + "/" + Global.MaxHPP3;
        MP3.text = "MP: " + Global.CurMPP3.ToString() + "/" + Global.MaxMPP3;

        HPBE3.text = "HP: " + Global.HPBE3.ToString();

        NumTurn.text = "Turn " + dem_turn.ToString();

        if (Global.HPBE3 < 0)
        {
            Global.HPBE3 = 0;
            HPBE3.text = "HP: " + Global.HPBE3.ToString();
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
            HPBE3.text = "HP: 0";
        if (Global.CurHPP1 <= 0)
            HP1.text = "HP: 0";
        if (Global.CurHPP2 <= 0)
            HP2.text = "HP: 0";
        if (Global.CurHPP3 <= 0)
            HP3.text = "HP: 0";

        P1TurnStatus.text = a1 + "";
        P3TurnStatus.text = a3 + "";
        BE3TurnStatus.text = aBE3 + "";

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
        HubController.BusyHub = false;
        SceneManager.LoadScene("Mana cliff");
    }
    public void PressBackToTheMap2()
    {
        ContainerController.LoadingOpen = true;
        HubController.BusyHub = false;

        if (CutscenesController.cus100 == 0 && CutscenesController.cus99 == 1)
        {
            SceneManager.LoadScene("Cutscenes");
        }
        else
            SceneManager.LoadScene("Mana cliff");
    }

    public void BE3Action()
    {
        if (BossSkillCharge == 1)
        {
            AfterBreakDamageCal = Global.HPBE3;
            BreakDamageCal = BeforeBreakSkillDamageCal - AfterBreakDamageCal;

            if (BreakDamageCal >= 400)
            {
                PDamage.color = Color.red;
                PDamage.text = "Skill break!";
            }
            else
            {
                EnemySkill1FX.Play();
                MDB.yes_ManaDragonSkill = 1;
                int DamgeCal = Global.DamageBE3 + Global.DamageBE3 * 300 / 100;
                EDamage.color = Color.red;
                EDamage.text = "-" + DamgeCal;
            }
        }
        else
        {
            BE3ANum = Random.Range(1, 11);
            if (BE3ANum <= 3)
            {
                EnemyAttack1FX.Play();
                MDB.yes_ManaDragonAttack1 = 1;
            }
            else if (BE3ANum == 4 || BE3ANum == 5)
            {
                EnemyAttack2FX.Play();
                MDB.yes_ManaDragonAttack2 = 1;
            }
            else
            {
                EnemySkillChargeFX.Play();
                MDB.yes_ManaDragonSkillCharge = 1;
                BossSkillCharge = 1;
                SkillChargeSign.SetActive(true);
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
        if (P2Available == false)
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
    public void CheckBE3Die()
    {
        if (Global.HPBE3 <= 0)
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
                DragonScalesManaItem.text = "Dragon scales mana +1";
            }

            Invoke("delayCheckBE3Die1", 1f);
            if (once == 0)
            {
                Invoke("delayCheckBE3Die2", 2f);
                once = 1;
            }
        }
    }
    void delayBE3()
    {
        CheckBE3Die();
        ShowP1Panel(false);
        ShowP2Panel(false);
        ShowP3Panel(false);

        if (BossSkillCharge == 1)
        {
            if (BossSkillEngage == 1)
            {
                AfterBreakDamageCal = Global.HPBE3;
                BreakDamageCal = BeforeBreakSkillDamageCal - AfterBreakDamageCal;

                if (BreakDamageCal >= 400)
                {
                    BreakDamageCal = 0;
                    BeforeBreakSkillDamageCal = 0;
                    AfterBreakDamageCal = 0;
                    BreakDamageIndex = 0;
                    BossSkillCharge = 0;
                    BossSkillEngage = 0;
                    SkillChargeSign.SetActive(false);
                }
                else
                {
                    Global.CurHPP1 -= Global.DamageBE3 + (Global.DamageBE3 * 300 / 100);
                    Global.CurHPP2 -= Global.DamageBE3 + (Global.DamageBE3 * 300 / 100);
                    Global.CurHPP3 -= Global.DamageBE3 + (Global.DamageBE3 * 300 / 100);
                    BossSkillCharge = 0;
                    BossSkillEngage = 0;
                    SkillChargeSign.SetActive(false);
                }
            }
            else
            {
                if (BreakDamageIndex == 0)
                {
                    BeforeBreakSkillDamageCal = Global.HPBE3;
                    BreakDamageIndex = 1;
                }
                BossSkillEngage = 1;
            }

            EDamage.text = "";
            PDamage.text = "";
            dem = 0;
            aBE3 = 0;
            dem_turn += 1;
        }
        else
        {
            BE3AttackTarget();
            EDamage.text = "";

            aBE3 -= 1;
            dem_turn += 1;
        }
    }

    void BE3AttackTarget()
    {
        if (P2Available == false)
        {
            BE3Hit = Random.Range(1, 4);
            while (BE3Hit == 2)
            {
                BE3Hit = Random.Range(1, 4);
            }
        }

        if (BE3Hit == 1 && Global.CurHPP1 > 0)
        {
            if (BE3ANum <= 3)
            {
                pb.p1YesGetHit = 1;
                Global.CurHPP1 -= Global.DamageBE3;
            }
            else if (BE3ANum <= 5)
            {
                pb.p1YesGetHit = 1;
                Global.CurMPP1 -= 30;
                if (Global.CurMPP1 < 0)
                    Global.CurMPP1 = 0;
            }
        }
        else if (BE3Hit == 1 && Global.CurHPP1 <= 0)
            BE3AttackTarget();
        else if (BE3Hit == 2 && Global.CurHPP2 > 0)
        {
            if (BE3ANum <= 3)
            {
                pb.p2YesGetHit = 1;
                Global.CurHPP2 -= Global.DamageBE3;
            }
            else if (BE3ANum <= 5)
            {
                pb.p2YesGetHit = 1;
                Global.CurMPP2 -= 30;
                if (Global.CurMPP2 < 0)
                    Global.CurMPP2 = 0;
            }
        }
        else if (BE3Hit == 2 && Global.CurHPP2 <= 0)
            BE3AttackTarget();
        else if (BE3Hit == 3 && Global.CurHPP3 > 0)
        {
            if (BE3ANum <= 3)
            {
                pb.p3YesGetHit = 1;
                Global.CurHPP3 -= Global.DamageBE3;
            }
            else if (BE3ANum <= 5)
            {
                pb.p3YesGetHit = 1;
                Global.CurMPP3 -= 30;
                if (Global.CurMPP3 < 0)
                    Global.CurMPP3 = 0;
            }
        }
        else if (BE3Hit == 3 && Global.CurHPP3 <= 0)
            BE3AttackTarget();
    }

    void delayP1PressAttack()
    {
        ShowP1Panel(false);
        VayneAttackEffect.SetActive(false);
        Global.HPBE3 -= Global.DamageP1;
        PDamage.text = "";
        a1 -= 1;
        show1 = 0;
        dem_turn += 1;
        CheckBE3Die();
    }
    void delayP2PressAttack()
    {
        ShowP2Panel(false);
        Global.HPBE3 -= Global.DamageP2;
        PDamage.text = "";
        a2 -= 1;
        show2 = 0;
        dem_turn += 1;
        CheckBE3Die();
    }
    void delayP3PressAttack()
    {
        ShowP3Panel(false);
        MariaAttackEffect.SetActive(false);
        Global.HPBE3 -= Global.DamageP3;
        PDamage.text = "";
        a3 -= 1;
        show3 = 0;
        dem_turn += 1;
        CheckBE3Die();
    }

    void delayP1PressSkill()
    {
        if (ChooseSkillIndex == 1)
        {
            Global.CurMPP1 -= 20;
            Global.HPBE3 = Global.HPBE3 - (Global.DamageP1 + (Global.DamageP1 * 100 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckBE3Die();
        }
        else if (ChooseSkillIndex == 2)
        {
            VayneSkill2Effect.SetActive(false);
            Global.CurMPP1 -= 50;
            Global.HPBE3 = Global.HPBE3 - (Global.DamageP1 + (Global.DamageP1 * 200 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckBE3Die();
        }
        else if (ChooseSkillIndex == 3)
        {
            VayneSkill3Effect.SetActive(false);
            Global.CurMPP1 -= 100;
            Global.HPBE3 = Global.HPBE3 - (Global.DamageP1 + (Global.DamageP1 * 300 / 100));
            PDamage.text = "";
            a1 -= 1;
            show1 = 0;
            dem_turn += 1;
            CheckBE3Die();
        }
    }
    void delayP2PressSkill()
    {
        if (ChooseSkillIndex == 1)
        {
            Global.CurMPP2 -= 20;
            Global.HPBE3 = Global.HPBE3 - (Global.DamageP2 + (Global.DamageP2 * 100 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckBE3Die();
        }
        else if (ChooseSkillIndex == 2)
        {
            Global.CurMPP2 -= 50;
            Global.HPBE3 = Global.HPBE3 - (Global.DamageP2 + (Global.DamageP2 * 200 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckBE3Die();
        }
        else if (ChooseSkillIndex == 3)
        {
            Global.CurMPP2 -= 100;
            Global.HPBE3 = Global.HPBE3 - (Global.DamageP2 + (Global.DamageP2 * 300 / 100));
            PDamage.text = "";
            a2 -= 1;
            show2 = 0;
            dem_turn += 1;
            CheckBE3Die();
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
            Global.HPBE3 = Global.HPBE3 - (Global.DamageP3 + (Global.DamageP3 * 300 / 100));
            PDamage.text = "";
            a3 -= 1;
            show3 = 0;
            dem_turn += 1;
            CheckBE3Die();
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
    void delayCheckBE3Die1()
    {
        URPIns.URPOff = true;
        HPMP.SetActive(false);
        Win_panel.SetActive(true);
    }
    void delayCheckBE3Die2()
    {
        if (Global.LevelP1 < 30)
        {
            Global.CurEXPP1 += Global.ExpBE3;
        }
        if (Global.LevelP2 < 30 && P2Available == true)
        {
            Global.CurEXPP2 += Global.ExpBE3;
        }
        if (Global.LevelP3 < 30)
        {
            Global.CurEXPP3 += Global.ExpBE3;
        }
        Global.Zen += Global.ExpBE3;
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
        Global.HPBE3 -= Global.BomValue;
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

    public void CanvasDisplay(bool actived)
    {
        if (actived == true)
        {
            for (int i = 0; i < _canvasObject.Length; i++)
            {
                _canvasObject[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < _canvasObject.Length; i++)
            {
                _canvasObject[i].SetActive(false);
            }
        }
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

    IEnumerator CamZoomDisplay()
    {
        yield return new WaitForSeconds(2f);
        zoomStart = true;

        yield return new WaitForSeconds(2f);
        zoomDone = true;
        CanvasDisplay(true);
    }
}
