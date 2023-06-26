using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus106 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
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
            AliaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Looks like things are back to normal, right? Hey Vayne, if you don't mind, make me your specialty.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Huh, you mean my masterpiece porridge?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right, I haven't eaten in a while! Hey, do you love me?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay... okay... if you want, I'll do it.";
        }
        else if (tang == 5)
        {
            AliaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 6)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "You know what, Alia, during the time you were in a coma, Vayne was very worried about you.";
        }
        else if (tang == 7)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Uhm... At that time when Vayne was about to get hurt, I acted rationally so I blocked Vayne's attack.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "Looks like that upset Vayne too.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Do you really like Vayne? Don't lie to yourself forever.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "... Don't embarrass me like that.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "Actually, I really like Vayne and have feelings for him.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "But I'm afraid he will reject my love.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "No, Vayne is starting to have feelings for you too, Alia. So do what you like, don't hide it anymore.";
        }
        else if (tang == 14)
        {
            MariaVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 15)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hey Alia, here's your porridge request. Oh, Maria, I have a spare for her too!";
        }
        else if (tang == 16)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "I'm not hungry yet, maybe I should go out for a walk, you two stay and have a good time!";
        }
        else if (tang == 17)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Heh...";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "Good luck Alia!";
        }
        else if (tang == 19)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Both";
            dia.text = "Oh hey...";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Alia";
            dia.text = "Maybe you should talk first.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "...I'm sorry about last time...";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Alia";
            dia.text = "Uhm... I don't mind that.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Vayne";
            dia.text = "I... I really like you Alia. Like that kind of love.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Alia";
            dia.text = "... Eh... Eh... I like you too Vayne...";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Vayne";
            dia.text = "Do you feel the same way... it's embarrassing because I'm not good at love.";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Alia";
            dia.text = "If so, are we lovers?";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right... haha! Let's eat porridge before it cools down.";
        }
        else if (tang == 30)
        {
            AliaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 31)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It's really comfortable outside. How are you two? Feeling all right?";
        }
        else if (tang == 32)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "We're fine. It's just a little sudden between you and Maria.";
        }
        else if (tang == 33)
        {
            NameTagText.text = "Maria";
            dia.text = "Hey Maria, have you said what you need to say to Vayne?";
        }
        else if (tang == 34)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "... Eh... we already confessed to each other.";
        }
        else if (tang == 35)
        {
            NameTagText.text = "Maria";
            dia.text = "Congratulations you two!";
        }
        else if (tang == 36)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks like our next target is Zane, we have to stop his schemes and stop him from harming others like Shan.";
        }
        else if (tang == 37)
        {
            NameTagText.text = "Maria";
            dia.text = "I agree, but we don't seem to be his opponents yet.";
        }
        else if (tang == 38)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Admittedly he's strong, if some of us get hit, it'll be just as hard as me.";
        }
        else if (tang == 39)
        {
            NameTagText.text = "Vayne";
            dia.text = "If so, we will train ourselves to become stronger.";
        }
        else if (tang == 40)
        {
            NameTagText.text = "Alia";
            dia.text = "So what should we do first?";
        }
        else if (tang == 41)
        {
            NameTagText.text = "Vayne";
            dia.text = "We have to change weapons first, so let's stop by Uncle Heerium's place.";
        }
        else if (tang == 42)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "That's a good idea, then we can go over to Orina's to see if there are any more useful items in battle.";
        }
        else if (tang == 43)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, we'll definitely become stronger.";
        }
        else if (tang >= 44)
        {
            CutscenesController.cus106 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus106 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}