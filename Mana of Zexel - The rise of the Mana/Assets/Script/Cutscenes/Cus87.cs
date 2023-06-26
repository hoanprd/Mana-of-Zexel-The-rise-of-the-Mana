using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus87 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, AlasaVAL1, AlasaVAR1, ShanVAL1, ShanVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Let's get active my ice core.";
        }
        else if (tang == 2)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Glowing...";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks as good as new, village chief Alasa.";
        }
        else if (tang == 4)
        {
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "You are such a good alchemist. I think you can match the legendary alchemist Zexel hahaha.";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Great, looks like you saved both of these villages, Vayne.";
        }
        else if (tang == 6)
        {
            AlasaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Is that Shan? Are you awake already?";
        }
        else if (tang == 7)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "How are you, Shan? We're pretty worried about him, too.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Shan";
            dia.text = "I'm fine, I've taken over my selfishness. However, I won't make that mistake again.";
        }
        else if (tang == 9)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "Maria";
            dia.text = "Dark magic is very scary, it can take over the hole in the user's heart.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Shan";
            dia.text = "I know, if I hadn't shaken hands with that magician that day, everyone wouldn't be in trouble.";
        }
        else if (tang == 11)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "It's okay, as long as we can help people, it's an honor!";
        }
        else if (tang == 12)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "By the way, Shan, do you know where that magician is?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Shan";
            dia.text = "That magician? I don't know either what I remember is that he was aiming for the Zexel temple.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "The temple of Zexel, that's where my father went too...";
        }
        else if (tang == 15)
        {
            ShanVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Then can we go, Vayne? I already have enough Zexel's two cores of fire and ice mana energy.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm! I want to go back to Mr. Lance for a moment.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Here we go, say goodbye to Asila village chief for us!";
        }
        else if (tang == 18)
        {
            MariaVAL1.SetActive(false);
            AlasaVAL1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Goodbye, I wish everyone a safe journey!";
        }
        else if (tang == 19)
        {
            VayneVAR1.SetActive(false);
            ShanVAR1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Thank you everyone and see you soon!";
        }
        else if (tang >= 20)
        {
            CutscenesController.cus87 = 1;
            ContainerController.ManaCoreIceVayne -= 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("InsideIceCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus87 = 1;
        ContainerController.ManaCoreIceVayne -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }
}