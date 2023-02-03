using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus118 : MonoBehaviour
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
            dia.text = "Zane! We have something to do with you!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Zane";
            dia.text = "Oh, is the little one getting better? I'm surprised.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "We will return you both capital and interest for harming innocent people.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Zane";
            dia.text = "Hahahahaha... it's too late... look at the resurrected Sicxalon.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "What monster is that!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Zane";
            dia.text = "Those two alchemists! You don't know how to use mana, this monster is what shows you the power of mana.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Zane";
            dia.text = "I can use mana to make this monster invade the world hahahaha...";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "Zane! Why do you want to invade the world like that! You can live a peaceful life with your mother Orina.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Zane";
            dia.text = "So you met my mother, is she still alive? Perhaps she already told you something about me, so I don't need to explain it anymore.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey Zane you think you'll be happy after taking revenge on this world?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Zane";
            dia.text = "Hahaha... that's right... good question! If you were me from the past then you would understand the pain I went through with this world.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Zane";
            dia.text = "Stupid people and mana too. They have destroyed my way of life, I will take their way back.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Zane";
            dia.text = "I won't let anyone suffer like me. A life hated by the world, I will destroy it!!!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "If you live only by hatred, you will never understand the meaning of life. If you think I still hold grudges, then you are wrong, I came here to fight for them, not for personal selfishness.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "I don't care how miserable you live, all I know will defeat you, that's all.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Zane";
            dia.text = "Then my world won't contain you guys. Sicxalon show me your strength.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Sicxalon";
            dia.text = "Gruuhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh...";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "That monster's mana is terrible, did Zexel ever fight with this thing!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Zane";
            dia.text = "What, kill them quickly, what are you waiting for!";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Sicxalon";
            dia.text = "Hmm.........";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Zane";
            dia.text = "No way... I've clearly mastered the sealing power... why can't I control it!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "Zane! Danger stay away from that monster!";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Zane";
            dia.text = "!!!";
        }
        else if (tang == 24)
        {
            NameTagText.text = "";
            dia.text = "Sengggggggggggggg...";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Zane";
            dia.text = "There's no way... I was killed by the monster itself!";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Alia";
            dia.text = "That's what you get you villain.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Zane";
            dia.text = "Damn... let's see how you guys deal with that monster.";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "We'll reincarnate it for you. Step aside and observe, we fight not for our selfishness but for our loved ones.";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Vayne";
            dia.text = "Come on everyone, the final battle must be won!";
        }
        else if (tang >= 30)
        {
            CutscenesController.cus113 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("BSSicxalon 1");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus113 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSSicxalon 1");
    }
}