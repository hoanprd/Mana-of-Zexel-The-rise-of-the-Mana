using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus88 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1, ZaneVAL1, ZaneVAR1;
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
            dia.text = "Is this the temple of Zexel? I feel...";
        }
        else if (tang == 2)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            AliaVAL1.SetActive(false);
            NameTagText.text = "???";
            dia.text = "Alia... Alia... Where are you?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Mommy!!!";
        }
        else if (tang == 4)
        {
            va2.SetActive(false);
            va1.SetActive(true);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "(What is this, just now...)";
        }
        else if (tang == 5)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Is something wrong, Alia?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Ah... it's nothing!";
        }
        else if (tang == 7)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "The air around here feels suffocating.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "Should we split up, Vayne?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "It seems so...";
        }
        else if (tang == 10)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Krakkkk... Krakkkk...";
        }
        else if (tang == 11)
        {
            ZaneVAL1.SetActive(true);
            NameTagText.text = "???";
            dia.text = "Oh, I can't believe anyone can get in here!";
        }
        else if (tang == 12)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Who is that? This source of power...";
        }
        else if (tang == 13)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "I can feel the dark mana energy like Shan's. What the hell.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "???";
            dia.text = "This kid and that red-haired girl, you two are magicians, why do you have so much mana in them.";
        }
        else if (tang == 15)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "We are alchemists named Vayne and Maria, the other is our friend Alia.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Zane";
            dia.text = "I'm a bit rude, aren't I? My name is Zane and I am a magician.";
        }
        else if (tang == 17)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Zane? That was the name of the magician Shan had mentioned.";
        }
        else if (tang == 18)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "!!! It turned out that he was the guy who lured Shan to destroy two villages inferno volcano and inferno ice.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Zane";
            dia.text = "Destroy? That has nothing to do with us. The girl named Alia looks familiar, doesn't she?";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "Then you know the man named Dante?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Zane";
            dia.text = "Dante? Oh... you mean the gentle guy I mutilated him a year ago?";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "!!! What did you just say? My father was taken by you...";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Zane";
            dia.text = "He's already dead. But what does he have to do with you?";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Vayne";
            dia.text = "I am his son!!!";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Zane";
            dia.text = "So? That's right, don't remind me he has a son. Looks like we got to meet that kid right here.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Vayne";
            dia.text = "Bastard!!! I will not forgive you!";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Zane";
            dia.text = "Hey don't be so hasty, okay?";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hyaaaaaaa...";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Zane";
            dia.text = "You're too young, kid! Shield!";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Zane";
            dia.text = "Sengggggggggg....";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Vayne";
            dia.text = "I can't get through him.";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Zane";
            dia.text = "Die you brat with a milky mouth.";
        }
        else if (tang == 33)
        {
            ZaneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Vayne! Watch...";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia!";
        }
        else if (tang == 35)
        {
            AliaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "Alia";
            dia.text = "Ahhhhhhhhh...";
        }
        else if (tang == 36)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Aliaaaaaa!";
        }
        else if (tang == 37)
        {
            ZaneVAR1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "You're lucky that girl died for you. I'm busy with my own business, see you later.";
        }
        else if (tang == 38)
        {
            ZaneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Alia! It's not okay, that attack is a critical hit.";
        }
        else if (tang == 39)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'm sorry... Alia...";
        }
        else if (tang == 40)
        {
            NameTagText.text = "Maria";
            dia.text = "Quickly bring her back to Mr. Lance go. She won't be able to withstand this attack for long.";
        }
        else if (tang >= 41)
        {
            CutscenesController.cus88 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel temple");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus88 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel temple");
    }
}