using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus47 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1;
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
            dia.text = "... Pheh... I thought it was going to be easy but it wasn't.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "What should I do after all... Father... Will he still be alive? And where is dad...";
        }
        else if (tang == 3)
        {
            NameTagText.text = "";
            dia.text = "Knock knock";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Come in!";
        }
        else if (tang == 5)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It's me. Every time I enter the room, it's like there's something on my mind?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "Oh, Maria! Actually... actually I'm starting to get tired of what happened.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Will we have the strength to keep going?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "No matter what, you're not alone Vayne! Is it possible that you already have Alia and me?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you! I'm worried that there will come a time when one of us will encounter something as serious as Alia was poisoned just now.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "It's true that going on an adventure outside the world is fraught with dangers, but each trip will be an interesting lesson.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "I feel like I've grown since meeting you, Vayne.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "So? It sounds a bit funny, but it's true.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "By the way, are you the one who saved Alia?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right! Do you have any questions?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't you have any questions about Alia?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Maria";
            dia.text = "You mean I don't know anything about Alia?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "Actually, I don't really care about Alia's identity. What I remember at the time, Alia got lost near the west side of this town in a serious condition.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "What I do is save people. And I was surprised that Alia remembers nothing about herself except her name. She was afraid that it would remind Alia of pain, so she did not dare to help Alia remember the past.";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is that all? As for me, it seems that Alia seems to get along with everyone and is funny. It's very rare that I meet someone with such a personality.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "Hey Vayne! Do you really feel that way about Alia?";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "What do you mean? Alia asked me the same question before.";
        }
        else if (tang == 24)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Hey Vayne, are you done with your specialty?";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well, I'm almost done, wait a minute!";
        }
        else if (tang == 26)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks like you two will need more time together.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Vayne";
            dia.text = "What do you mean by that?";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Maria";
            dia.text = "It's nothing. Just keep doing your job, I won't bother you anymore";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Vayne";
            dia.text = "My feelings for Alia?";
        }
        else if (tang >= 30)
        {
            CutscenesController.cus47 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Save room");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus47 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Save room");
    }
}