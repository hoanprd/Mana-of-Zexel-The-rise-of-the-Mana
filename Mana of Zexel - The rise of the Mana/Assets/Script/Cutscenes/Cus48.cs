using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus48 : MonoBehaviour
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
            NameTagText.text = "Alia";
            dia.text = "It's true! After eating Vayne's porridge, there is nothing better than a refreshing rest!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's great, if you've regained your strength, I'll head south to the inferno desert to find the whereabouts of the mana gods!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Klener";
            dia.text = "Hey Vayne! Wait for me!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Klener? Is something wrong?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Klener";
            dia.text = "Well, I just heard Mr. Lance recounts that your group just sent me to the inferno desert?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Klener";
            dia.text = "And I heard there's some kind of poisonous monster there?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! It is a very large scorpion, if not treated in time, it will be very dangerous to life.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Klener";
            dia.text = "So? If so... mind you helping me collect their venom!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Collecting scorpion poison? Did the villagers get poisoned?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Klener";
            dia.text = "No! We bodyguards plan to expand the range of our guard instead of just guarding the wishing forest. We want to expand into the inferno desert.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Klener";
            dia.text = "On this occasion, I used to go to the Inferno Desert for the first time to learn about that place as well as build more bases to protect the villagers in this town of Zexel. Since there are monsters like scorpions there, I need their venom as an antidote in case.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "I see, I'm ready to help, okay Alia, Maria?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "If it's for the safety of the villagers, I'll be happy too.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "I'll join too so I don't get bored.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Klener";
            dia.text = "Thank you very much!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ah Klener! Be prepared to be on high alert because those monsters aren't as easy as the golems.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Klener";
            dia.text = "Don't worry about me, I will definitely fight with all my might!";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus48 = 1;
            SceneManager.LoadScene("Save room");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus48 = 1;
        SceneManager.LoadScene("Save room");
    }
}