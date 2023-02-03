using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus113 : MonoBehaviour
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
            dia.text = "Barrier operation protect everyone in this town.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "";
            dia.text = "Glowinggggggggggggggg...";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "With this we can have some peace of mind.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! But we are not allowed to rest yet, there is still an inferno desert village in need of protection.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Father? Why are you going out like this, it's dangerous here!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I'm just a little worried, I don't want you to be in danger like this.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "... I've decided, if I stay weak, I won't be able to protect anyone.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "But you're my only relative, if something happens... we'll know what to do.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "I rarely see you worrying about me like this, after all, I have Vayne and Alia, we will definitely return safely.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "We're going to deal with some things now, don't worry.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Promise me you'll come back.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "It's too much for me to act like you're going to war. I promise to return to my father.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Good luck.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "Uhm, let's go Vayne, Alia, we're starting to be the heroes of the world.";
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
            MapController.TavernToSaveRoom = false;
            MapController.WishingForestToZexelTown = true;
            SceneManager.LoadScene("Zexel town");
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
        MapController.TavernToSaveRoom = false;
        MapController.WishingForestToZexelTown = true;
        SceneManager.LoadScene("Zexel town");
    }
}