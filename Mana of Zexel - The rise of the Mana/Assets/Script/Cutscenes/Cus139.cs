using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus139 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va0, va1, va2, va3;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ZaneVAL1, ZaneVAR1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {

        }
        else
        {

        }
        if (tang == 1)
        {
            NameTag.SetActive(true);
            NameTagText.text = "Sicxalon";
            dia.text = "Grrruuuhhhhhhhhhhhhhhhhhhhhhhhh...";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "This monster is terrible if you destroy it, it will all explode.";
        }
        else if (tang == 3)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "What should we do, it has weakened a lot.";
        }
        else if (tang == 4)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "If we don't destroy it, there's only a way to seal it like my mother did.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "...Wait, I have an idea.";
        }
        else if (tang == 6)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "What are you going to do, Vayne? Don't go near that monster!";
        }
        else if (tang == 7)
        {
            MariaVAR1.SetActive(false);
            NameTagText.text = "Vayne";
            dia.text = "I will reincarnate it, it will definitely help the next generation.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Now submit to me Hyaaaaaaa!!!";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Sengggggggggggggggg...";
        }
        else if (tang == 10)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "That's...";
        }
        else if (tang == 11)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "The soul of Sicxalon. I have succeeded!";
        }
        else if (tang == 12)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Well done, Vayne!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "With this, just give the gods mana and they can do the rest.";
        }
        else if (tang == 14)
        {
            AliaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 15)
        {
            ZaneVAL1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "Bastard, how dare you... I can't lose like that.";
        }
        else if (tang == 16)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Shut up, you're no longer capable of fighting, give up, we're lucky we haven't hit you yet.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Zane";
            dia.text = "Pity me... hahahahaha I'll let you all go to hell with me!";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Zane";
            dia.text = "I'll blow them all up!!!";
        }
        else if (tang == 19)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Stop it Zane!";
        }
        else if (tang == 20)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Mana shield!";
        }
        else if (tang == 21)
        {
            ZaneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Sister Maria! What are you thinking of doing!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne, Alia both of you can't die, you both have a bright future, get out of here quickly.";
        }
        else if (tang == 23)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "No... can't leave you alone!";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Maria";
            dia.text = "Our journey isn't long but I've come to realize some things... some things called sacrifices are required to protect those we love.";
        }
        else if (tang == 25)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "... Sister Mariaa!!!";
        }
        else if (tang == 26)
        {
            AliaVAL1.SetActive(false);
            ZaneVAL1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "You wants to die with me...";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right! Don't try to touch my two friends.";
        }
        else if (tang == 28)
        {
            ZaneVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I'll take you out!";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Maria";
            dia.text = "Mana shield pushes Vayne away!";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ahhh... Sister Maria!";
        }
        else if (tang == 31)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Rrroommmmmmm...";
        }
        else if (tang == 32)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "No! The wall has fallen...";
        }
        else if (tang == 33)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Damn... we have to get out Maria...";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Alia";
            dia.text = "No... can't leave Maria like that...";
        }
        else if (tang == 35)
        {
            NameTagText.text = "Vayne";
            dia.text = "We have to get out quickly or we'll be buried here... we can't let her make a meaningless sacrifice! Hic...";
        }
        else if (tang == 36)
        {
            NameTagText.text = "Alia";
            dia.text = "Hic... hic... Impossible...";
        }
        else if (tang == 37)
        {
            va2.SetActive(false);
            va1.SetActive(true);
            AliaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "(I'm sorry and thank you Maria...)";
        }
        else if (tang == 38)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Hmm... looks like I can close my eyes peacefully, right?";
        }
        else if (tang == 39)
        {
            ZaneVAR1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "Nooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
        }
        else if (tang == 40)
        {
            NameTagText.text = "Maria";
            dia.text = "(Father, I'm sorry I didn't keep my promise. Goodbye everyone.)";
        }
        else if (tang == 41)
        {
            va1.SetActive(false);
            va0.SetActive(true);
            MariaVAL1.SetActive(false);
            ZaneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Bbbbbbbbbbbbbbbbbbbbbbbbooooooooooooooooooooooooooooommmmmmmmmmmmmmmmmmmmmmmmmmm...";
        }
        else if (tang == 42)
        {
            va0.SetActive(false);
            va3.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 43)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hoh phoh... Hoh phoh... Alia! Alia where are you!";
        }
        else if (tang == 44)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Huh... Vayne! I'm ok!";
        }
        else if (tang == 45)
        {
            NameTagText.text = "Vayne";
            dia.text = "Luckily, we're all safe!";
        }
        else if (tang == 46)
        {
            NameTagText.text = "Alia";
            dia.text = "Sister Maria! She...";
        }
        else if (tang == 47)
        {
            NameTagText.text = "Vayne";
            dia.text = "I can't feel any trace of her anymore... she saved us...";
        }
        else if (tang == 48)
        {
            NameTagText.text = "Alia";
            dia.text = "Hic... no way...";
        }
        else if (tang == 49)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't worry Maria, we survived. Thank you, Maria!";
        }
        else if (tang >= 50)
        {
            CutscenesController.cus139 = 1;
            ContainerController.LoadingOpen = true;
            MapController.ZexelTempleToZexelGate = true;
            SceneManager.LoadScene("Zexel gate");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus139 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel gate");
    }
}