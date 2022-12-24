using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus23 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Delicious food has arrived!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alia";
            dia.text = "Ahhh! Great, I'm so hungry!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hehee";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "... This just porridge?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Klener";
            dia.text = "... Is this really just porridge?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "It doesn't matter if it's porridge or not, everyone just taste it! It's very unusual!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "... Woah!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Klener";
            dia.text = "... Huh?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "... It's just porridge! But wait, there is something very strange in this bowl of porridge, I feel like I am getting better than usual.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hehe, Maria please take a look?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "The feeling of eating is full of coffee!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "This feeling is having mana infused inside.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, that's the mana porridge. To make a nutritious dish, porridge is a reasonable thing because liquid food will help the body absorb the mana inside faster, making the body full of energy.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "Interesting, back then I thought alchemy was only used as a healing item instead of that food.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's very simple, but as long as the alchemist's mana is infused, any dish will be delicious.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "If so, I have a lot to try.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Alia";
            dia.text = "Delicious! Hey Vayne, you do this often.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "Of course as long as people like it. Anyway, let's all eat well and prepare for the information search, and I'll go and prepare some little alchemy tools.";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus23 = 1;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus23 = 1;
        SceneManager.LoadScene("Tavern");
    }
}