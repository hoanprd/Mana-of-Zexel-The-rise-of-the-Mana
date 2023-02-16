using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus30 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Maria! What do you need to craft?";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Just adding bombs is enough!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay then let's make some potions with bombs! Please sit down and wait for a while.";
        }
        else if (tang == 4)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "It's good to admit that alchemy is good too! Can make potions, weapons and even food!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "... Ehhhhh, I must have been doing boring things at that time, so you must be bored!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "... What a quick change of nature! Is it true that seeing a handsome man changes your personality?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Heh... Nope! No. of course!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "Really, every time I mention him, it's...";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "Me and Vayne are just friends!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "Huh? Did you mention Vayne?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "But who else?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "Who knows? But you don't have to hide it from me! What a sad day when you were with me! When meeting Vayne, it's like a monkey jumping to Vayne!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey... Come on, don't embarrass me!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "All right! I won't tease you anymore.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alia";
            dia.text = "Never mind, I'm mad at you!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "... Come on, I'm just joking, are you angry?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Maria";
            dia.text = "It's not funny at all!";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "... Hehe I'm happy enough!!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Alia";
            dia.text = "Such a wicked you are!";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "I promise to make up for a meal!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Alia";
            dia.text = "Your meal was never as good as Vayne's!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Alia";
            dia.text = "Heh...";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Maria";
            dia.text = "Oh, I really like Vayne!";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Alia";
            dia.text = "... Why do you like to press me like that!!!";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Maria";
            dia.text = "Don't be angry, don't be angry.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Alia";
            dia.text = "Stop talking to me!!!";
        }
        else if (tang >= 28)
        {
            CutscenesController.cus30 = 1;
            ContainerController.LoadingOpen = true;
            MapController.TavernToSaveRoom = true;
            MapController.ZexelTownToTavern = false;
            SceneManager.LoadScene("Save room");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus30 = 1;
        ContainerController.LoadingOpen = true;
        MapController.TavernToSaveRoom = true;
        MapController.ZexelTownToTavern = false;
        SceneManager.LoadScene("Save room");
    }
}