using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus124 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1;
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
            MariaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Finally back in this house!";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "I think you've only been adventuring with us for less than a month, but you already miss your old home.";
        }
        else if (tang == 3)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Come on, stop teasing each other. We have to find the mana detector as soon as posible.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Honestly, it will take a bit of time because I often leave things in the house so it will take time to find them.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Oh my god... okay let us help you find it.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Don't touch my sensitive things.";
        }
        else if (tang == 7)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            MariaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 8)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Admittedly, Maria's room is full of books.";
        }
        else if (tang == 9)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I find it very messy.";
        }
        else if (tang == 10)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Where is it? Do you remember where it is...";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "What is this? Diary of...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "Hey don't touch my private stuff!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alia";
            dia.text = "I'm sorry, I'm just curious!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "Phew... That diary is really important to me so I have to keep it safe.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alia";
            dia.text = "Are these your memories with your mother?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "Yes, I and my mother lived a simple life in this forest. The mana detector was a product that I created to find ingredients for my mother's potions as well as for alchemy.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Maria";
            dia.text = "Even though I'm not a doctor like your mother, I've tried my best in being helpful to everyone I know.";
        }
        else if (tang == 18)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hey Maria, is this round device?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right, that's it!";
        }
        else if (tang == 20)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "It looks very old.";
        }
        else if (tang == 21)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I think it doesn't work anymore.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "It seems so, can't blame the device for being old.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "Interesting isn't it? I didn't expect you to be able to make such a useful item since I was a child when I only know how to make potions.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Vayne";
            dia.text = "Anyway, I think this device can be repaired. Let's go get the cauldron and fix it with your alchemy.";
        }
        else if (tang >= 25)
        {
            CutscenesController.cus124 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Wishing forest");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus124 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}