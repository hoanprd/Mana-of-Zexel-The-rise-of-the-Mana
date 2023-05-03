using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus111 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ShanVAL1, AsilaVAL1, AlasaVAR1, ZaneVAR1;
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
            dia.text = "That monster, you've already lost, don't ever destroy other people's villages, okay?";
        }
        else if (tang == 2)
        {
            AliaVAL1.SetActive(false);
            NameTagText.text = "Inferno beast";
            dia.text = "grhhh...";
        }
        else if (tang == 3)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It's unconscious.";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks like that thing knows what's out of the question. Maybe it's just resentful that it's been sealed here for so long.";
        }
        else if (tang == 5)
        {
            MariaVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "I thank you guys, once again you saved my brothers and sisters.";
        }
        else if (tang == 6)
        {
            VayneVAR1.SetActive(false);
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "I really don't know how to repay you guys?";
        }
        else if (tang == 7)
        {
            AsilaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "We don't need to repay the favor, what we do is voluntary.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alasa";
            dia.text = "Don't be a guest, I will give you this money first as the sincerity of the two of us. Please accept it.";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Hehe... it's a waste not to accept it.";
        }
        else if (tang == 10)
        {
            MariaVAL1.SetActive(false);
            AlasaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Zen +1000";
        }
        else if (tang == 11)
        {
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "You guys are much stronger than before. Unbelievable.";
        }
        else if (tang == 12)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "We are ready to raise our strength to fight the magician Zane.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Shan";
            dia.text = "Have you met him already?";
        }
        else if (tang == 14)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes, it was difficult to fight him at first but now we will defeat him and stop evil plots.";
        }
        else if (tang == 15)
        {
            ShanVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Blinkkkkkk...";
        }
        else if (tang == 16)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "That monster is gone, what happened?";
        }
        else if (tang == 17)
        {
            ZaneVAR1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "Hahaha, looks like you've become stronger than before. It seem the girl who was severely injured by me has already recovered.";
        }
        else if (tang == 18)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Zane! What are you doing here?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Zane";
            dia.text = "Just visiting this inferno monster for a bit, thanks to you guys defeating me I can easily absorb it.";
        }
        else if (tang == 20)
        {
            VayneVAL1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "You bastard! What is your goal after all?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Zane";
            dia.text = "Oh, you're the kid who wants revenge on your parents, isn't it? I'm just helping you do it.";
        }
        else if (tang == 22)
        {
            ShanVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Stop joking around Zane, we don't have time to listen to your jokes like that.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Zane";
            dia.text = "Hahaha, you still haven't experienced what my nightmare is like. When everyone in this world hates you.";
        }
        else if (tang == 24)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "What do you mean?";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Zane";
            dia.text = "A time when magicians were hated and hunted to death. I'm one of the lucky ones to be alive, so I'm just giving back to this world my pain.";
        }
        else if (tang == 26)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's pointless, that era is over, what's the point of holding a grudge in your heart?";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Zane";
            dia.text = "You ask yourself Vayne, do you hold a grudge against me?";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "... I...";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Zane";
            dia.text = "Anyway, the conversation was interesting. I should just get back to my work.";
        }
        else if (tang == 30)
        {
            VayneVAL1.SetActive(false);
            ZaneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Blinkkkkkkk...";
        }
        else if (tang == 31)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "We're not going to leave him alone in this.";
        }
        else if (tang == 32)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Definitely give him a lesson.";
        }
        else if (tang == 33)
        {
            MariaVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            NameTagText.text = "Villager (Man)";
            dia.text = "Sir Asila! Everyone has been moved to a safe location, we're here to help you fight monsters!";
        }
        else if (tang == 34)
        {
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Oh, thanks everyone, but the monster is done.";
        }
        else if (tang == 35)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Really! Did you two deal with it?";
        }
        else if (tang == 36)
        {
            NameTagText.text = "Asila";
            dia.text = "Actually, this group of adventurers defeated that monster.";
        }
        else if (tang == 37)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "The three of you are our benefactors!";
        }
        else if (tang == 38)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's okay, consider us a reliable ally.";
        }
        else if (tang == 39)
        {
            NameTagText.text = "Asila";
            dia.text = "How's the damage done?";
        }
        else if (tang == 40)
        {
            VayneVAR1.SetActive(false);
            NameTagText.text = "Villager (Man)";
            dia.text = "Well, the situation in our village has a few houses damaged, it will be difficult to fix because of the ancient raw materials we have to import from outside...";
        }
        else if (tang == 41)
        {
            NameTagText.text = "Asila";
            dia.text = "That's hard.";
        }
        else if (tang == 42)
        {
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "If we open the border to the outside from now on, it will take time to get used to the new lifestyle.";
        }
        else if (tang == 43)
        {
            NameTagText.text = "Asila";
            dia.text = "But who's the internal damage we haven't solved yet. Unless...";
        }
        else if (tang == 44)
        {
            NameTagText.text = "Asila";
            dia.text = "Vayne, it seems a bit selfish but...";
        }
        else if (tang == 45)
        {
            AlasaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "You don't have to be afraid Vayne will help you.";
        }
        else if (tang == 46)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Huh? I mean can help what I can.";
        }
        else if (tang == 47)
        {
            NameTagText.text = "Asila";
            dia.text = "You just need to help the villagers deal with the damage from the inferno beast attack just now. That will help us a lot while we will start to open the border to the outside. Think of it as dividing the work to treat.";
        }
        else if (tang == 48)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What's up Vayne? We can make friends with these two villages with our help.";
        }
        else if (tang == 49)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's fine, I'll use alchemy to help everyone.";
        }
        else if (tang == 50)
        {
            NameTagText.text = "Asila";
            dia.text = "Thank you, Mr. Vayne, you are indeed our benefactor. If anything, please visit the villagers to ask about the situation comfortably!";
        }
        else if (tang == 51)
        {
            VayneVAR1.SetActive(false);
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "I think I will need you to help my villagers too Vayne, thank you very much indeed.";
        }
        else if (tang == 52)
        {
            AlasaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Everyone please be optimistic and believe, I will do my best for everyone.";
        }
        else if (tang >= 53)
        {
            CutscenesController.cus111 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Alta inferno");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus111 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Alta inferno");
    }
}