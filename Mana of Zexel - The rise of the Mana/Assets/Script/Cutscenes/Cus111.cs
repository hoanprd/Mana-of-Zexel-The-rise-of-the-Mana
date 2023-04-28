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
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, ShanVAL1, AsilaVAL1, AlasaVAR1, ZaneVAR1;
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
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Good luck to you guys.";
        }
        else if (tang == 34)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Uhm, nothing more we're going back to Zexel town.";
        }
        else if (tang == 35)
        {
            NameTagText.text = "Shan";
            dia.text = "Goodbye!";
        }
        else if (tang >= 18)
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