using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus26 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, KlenerVAL1, KlenerVAR1, HeeriumVAL1, HeeriumVAR1;
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
            AliaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Okay! Let's go!";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "The plan is to just keep asking the people in town, Vayne?";
        }
        else if (tang == 3)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I don't know either, but let's keep it that way for now.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "If only someone generously knew about the temple, that would be fine too!";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            KlenerVAL1.SetActive(true);
            NameTagText.text = "Klener";
            dia.text = "Hohhhhh! Uncle Heeriummmm!";
        }
        else if (tang == 6)
        {
            HeeriumVAR1.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "Ohh! It's Klener! I haven't seen you visit my blacksmith shop these days hahaha!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Klener";
            dia.text = "I've been so busy with the guard lately that I haven't been able to visit you like before.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Heerium";
            dia.text = "It's okay, it's okay, if you need maintenance on your weapon just drop by me!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Heerium";
            dia.text = "Huh? The shield you're carrying looks weird? It's not like yours used to do at all!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Klener";
            dia.text = "Ah! This shield was made for her by an alchemist named Vayne!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Heerium";
            dia.text = "Alchemist?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Klener";
            dia.text = "Oh! What a coincidence Vayne!";
        }
        else if (tang == 13)
        {
            KlenerVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hi Klener! Looks like you're talking to someone close?";
        }
        else if (tang == 14)
        {
            HeeriumVAR1.SetActive(false);
            KlenerVAR1.SetActive(true);
            NameTagText.text = "Klener";
            dia.text = "That's right! This is Heerium, he is the only blacksmith in this town!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "What an honor! My name is Vayne!...";
        }
        else if (tang == 16)
        {
            KlenerVAR1.SetActive(false);
            HeeriumVAR1.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "Hahaha! I feel honored, you are the one who saved the field from the goblins that destroyed it back in the day, right?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes!... That's right...";
        }
        else if (tang == 18)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Uncle Heerium is still as funny as when we first met, right?";
        }
        else if (tang == 19)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Optimism is who he is.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Heerium";
            dia.text = "Oh! Maria and Alia with Vayne? Granted, the town's hero got two beauties like this haha!";
        }
        else if (tang == 21)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's not it, Heerium! We are just companions!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Heerium";
            dia.text = "Do you want to go on an adventure?";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! And we're looking for news about the Zexel temple.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Heerium";
            dia.text = "Temple of Zexel! Hmm, if that's the case, could you guys stop by my blacksmith shop first? I think we need some equipment!";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes! If so, we'll drop by as soon as possible!";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Heerium";
            dia.text = "Alright! See you again! Ah Maria, Alia! Do you two have anything to guide Vayne!";
        }
        else if (tang == 27)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Okay! Just let me!";
        }
        else if (tang >= 28)
        {
            CutscenesController.cus26 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus26 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}