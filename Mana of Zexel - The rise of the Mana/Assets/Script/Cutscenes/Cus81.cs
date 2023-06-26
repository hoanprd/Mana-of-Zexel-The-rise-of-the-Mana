using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus81 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ManaWaterVAL1;
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
            dia.text = "We've gone through most of this forest and still nothing...";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks like the legend is just a rumor. It seems that reviving the land for the two village chiefs seems to be difficult.";
        }
        else if (tang == 3)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "... This place...";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Does Maria have something to worry about?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "... It's just that I find it a bit bleak here.";
        }
        else if (tang == 6)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looking back, we rarely go to this place, right?";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "I feel very comfortable for a place to stay. Not only that, there are no monsters here, so there's nothing to worry about.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "In the past, my mother used to take me to this place on weekends just to enjoy the fresh air of nature. It's a memory, isn't it?";
        }
        else if (tang == 9)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Don't tell me you want to stay in this forest because it contains a lot of your mother's memories?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right, hahaha, it's fun to think back on, the moments when I went to pick medicine with my mother that day were great.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "What should we do... the situation is really confusing right now.";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "???";
            dia.text = "Hmm, ... you guys are quite noisy!";
        }
        else if (tang == 13)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Huh? Just now... is there anyone around here?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "???";
            dia.text = "Looks like I have an uninvited guest.";
        }
        else if (tang == 15)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "What's under the water?";
        }
        else if (tang == 16)
        {
            VayneVAL1.SetActive(false);
            ManaWaterVAL1.SetActive(true);
            NameTagText.text = "???";
            dia.text = "Fate seems inevitable, doesn't it?";
        }
        else if (tang == 17)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "This person looks similar to the mana gods we meet.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "???";
            dia.text = "Mana god? So you went to meet the mana god?";
        }
        else if (tang == 19)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Who are you? Why did he appear at the lake like this?";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Mana water";
            dia.text = "Alright! Looks like you're not a bad person, my hunch tells me so. I am mana water, a mana that lived in the lake long ago.";
        }
        else if (tang == 21)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Could it be that you are the mana mentioned in the purifying water legend?";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Mana water";
            dia.text = "Hmm, that's been a while, hasn't it? Since the war with the magicians ended. Yes, I am the creator and guardian of this lake of purification.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Maria";
            dia.text = "It's strange, how come the people who frequent here like me have never met you mana water?";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Mana water";
            dia.text = "You don't know me but I know you every time I pass by the lake, it's just that I don't want to show up, like I said before we met by fate.";
        }
        else if (tang == 25)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Fate again? Mana god told us the same!";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Mana water";
            dia.text = "Unfortunately I'm not exactly a mana god, just a mana living in a remote place.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Mana water";
            dia.text = "All I know is that you will visit this place and it is my duty to answer your questions.";
        }
        else if (tang == 28)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "How did you know these things would happen?";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Mana water";
            dia.text = "It's best not to talk about it because it's very complicated. Just as I know you will aim for this lake of purification!";
        }
        else if (tang == 30)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Then we won't have to explain at length as well as can you help us about the water of purification?";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Mana water";
            dia.text = "Hahaha, this is naive, do you think you can get whatever you want after meeting me?";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Mana water";
            dia.text = "Purifying water is an extremely difficult result and takes time to prepare. I always keep it with me just in case. Therefore, we will need a request to exchange.";
        }
        else if (tang == 33)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "And what is that request?";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Mana water";
            dia.text = "Simple alchemist, I need you guys to give me a special medicine for my backache.";
        }
        else if (tang == 35)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Huh? Are you serious?";
        }
        else if (tang == 36)
        {
            NameTagText.text = "Mana water";
            dia.text = "Purifying water can't cure diseases, you should know that, just like I'm old because I'm not a mana god so my lifespan is limited.";
        }
        else if (tang == 37)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "You know I'm an alchemist? How could it...";
        }
        else if (tang == 38)
        {
            NameTagText.text = "Mana water";
            dia.text = "I told you it would be complicated and it's unnecessary to tell you about it, young man!";
        }
        else if (tang == 39)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Vayne, we should focus on the main issue. We really need cleansing water, don't we?";
        }
        else if (tang == 40)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "... Okay in that case we'll give you the best back pain medicine I've ever made. But you must keep your promise to exchange purifying water with us.";
        }
        else if (tang == 41)
        {
            NameTagText.text = "Mana water";
            dia.text = "Of course. You cannot lie to fate.";
        }
        else if (tang == 42)
        {
            ManaWaterVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Haizz, it's fate that these mana are so fond of mysterious puzzles.";
        }
        else if (tang >= 43)
        {
            CutscenesController.cus81 = 1;
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
        CutscenesController.cus81 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}