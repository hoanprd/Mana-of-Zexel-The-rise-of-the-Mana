using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus83 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1, MrLanceVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Success! Success! This is the magic purification potion!";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "That's amazing Vayne! Let's solve the remaining problem!";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Not bad...";
        }
        else if (tang == 4)
        {
            MariaVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            NameTagText.text = "Mr. Lance";
            dia.text = "Ah... yah... My back!";
        }
        else if (tang == 5)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Huh, Mr. Lance? What's wrong with your back?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I don't know why I've been having back pain lately. Probably due to old age!";
        }
        else if (tang == 7)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "This... we have a solution for you because I know the recipe for back pain very well!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Really?";
        }
        else if (tang == 9)
        {
            MrLanceVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Vayne, You are tired of making a lot of things just now, let me take care of this!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, I'll take a break then.";
        }
        else if (tang == 11)
        {
            MariaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Okay, Dad, you can put this on your back!";
        }
        else if (tang == 13)
        {
            MrLanceVAR1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria! You know my back hurts so I can't...";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "You mean ask me to put some medicine on your back, don't you?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Hehe... that's right!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "No! There's no way I would do that in front of these two.";
        }
        else if (tang == 17)
        {
            MrLanceVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "If you don't mind we can go out...";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "Are you faking it...";
        }
        else if (tang == 19)
        {
            AliaVAR1.SetActive(false);
            MrLanceVAR1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Not really! Yah... it hurts...";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "You two go out, my father just wants to lose face in front of you!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Hey... wait, I feel like my back pain is gone!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "Are you planning to run away? Let me show you what the filial piety of your daughter is.";
        }
        else if (tang == 23)
        {
            MariaVAL1.SetActive(false);
            MrLanceVAR1.SetActive(false);
            NameTagText.text = "Mr. Lance";
            dia.text = "Yahhhhhhhhhh...";
        }
        else if (tang == 24)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "This is the first time I've seen such a scary Maria!";
        }
        else if (tang == 25)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Maybe we shouldn't touch her like that. Really scary!";
        }
        else if (tang >= 26)
        {
            CutscenesController.cus83 = 1;
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
        CutscenesController.cus83 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Save room");
    }
}