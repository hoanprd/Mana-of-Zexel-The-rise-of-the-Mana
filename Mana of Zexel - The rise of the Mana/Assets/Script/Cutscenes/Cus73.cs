using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus73 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, FOP;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, AsilaVAL1, AsilaVAR1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
        {
            AsilaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "In front here is the core of fire energy. Come on, Vayne, find a way to get it out safely.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes, count on me.";
        }
        else if (tang == 3)
        {
            AsilaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 4)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It worked!";
        }
        else if (tang == 5)
        {
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Wait, you just put something in instead.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's the head of Alasa's ice crystal, sir.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Asila";
            dia.text = "Ice crystals? Impossible, ice crystals only heat shock volcanoes, not stabilize the volcano!";
        }
        else if (tang == 8)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What's that? Could it be that the village chief Alasa would say this helps to get the fire core safely? He said he wanted to surprise the village chief Asila.";
        }
        else if (tang == 9)
        {
            AliaVAL1.SetActive(false);
            AsilaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Rrroooommmmmmmm...";
        }
        else if (tang == 10)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Earthquake?";
        }
        else if (tang == 11)
        {
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "No, the volcano is unstable, it will erupt.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "What is impossible!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Asila";
            dia.text = "You guys have been deceived by my brother!";
        }
        else if (tang == 14)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Everyone we have to get out of here!";
        }
        else if (tang == 15)
        {
            AsilaVAR1.SetActive(false);
            MariaVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Rrroommmmm...";
        }
        else if (tang == 16)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's not good, the path is full of lava.";
        }
        else if (tang == 17)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "No, no, I don't want to die yet.";
        }
        else if (tang == 18)
        {
            VayneVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            FOP.SetActive(true);
            NameTagText.text = "";
            dia.text = "Glowinggggg...";
        }
        else if (tang == 19)
        {
            FOP.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "What, Orina's flame is glowing again? No single...";
        }
        else if (tang == 20)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Vayne quickly use that flame instead of the ice crystal!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hyaaaaaaaaaaaaaaaaaaa...";
        }
        else if (tang == 22)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Chenggggggggggggggg...";
        }
        else if (tang == 23)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 24)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Is everyone okay?";
        }
        else if (tang == 25)
        {
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "I'm fine.";
        }
        else if (tang == 26)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Vayne! Are you okay?";
        }
        else if (tang == 27)
        {
            AsilaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Uhm, I'm fine. Orina's fire saved our lives.";
        }
        else if (tang == 28)
        {
            AliaVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "That flame, isn't it the flame from the inferno monster?";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Vayne";
            dia.text = "What is an inferno monster?";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Asila";
            dia.text = "It's okay if you don't know, but that fire is only temporary, when that fire goes out, the volcano will continue to erupt.";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Vayne";
            dia.text = "Then we can't get the fire core?";
        }
        else if (tang == 32)
        {
            AsilaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "... Surely there must be a way?";
        }
        else if (tang == 33)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Calm down we still have time to sort this out.";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Maria";
            dia.text = "Asila village chief, will you give us some time to fix this? If we can't solve it, we will return the fire core to you.";
        }
        else if (tang == 35)
        {
            AliaVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "... I hope you guys really have a way, if that's the case, then I will temporarily borrow the fire core to solve this problem.";
        }
        else if (tang == 36)
        {
            NameTagText.text = "Maria";
            dia.text = "Thank you!";
        }
        else if (tang >= 37)
        {
            CutscenesController.cus73 = 1;
            ContainerController.LoadingOpen = true;
            ContainerController.IceCrystal -= 1;
            ContainerController.FireOfPeace -= 1;
            SceneManager.LoadScene("InsideVolcanoCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus73 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.IceCrystal -= 1;
        ContainerController.FireOfPeace -= 1;
        SceneManager.LoadScene("InsideVolcanoCave");
    }
}