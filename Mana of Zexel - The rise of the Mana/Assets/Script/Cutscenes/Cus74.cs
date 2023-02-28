using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus74 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject[] TutorialImage;
    public GameObject va1, TutorialPanel;
    public GameObject VayneVAR1, AliaVAL1, MariaVAL1;
    public GameObject NameTag;
    private int tang = 0, TuTang = 0;

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
            dia.text = "Vayne, do you have a way to deal with this? But I don't know anything then.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I'm really confused too.";
        }
        else if (tang == 3)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "I think there's a way to deal with that volcano.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne, you mentioned the element of mana before, right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, mana also has elements and in total there are five basic elements of mana. Consists of fire, ice, wind, earth and thunder.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "In that case, can you create an energy core containing fire energy?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "I don't know. If there was a prototype like this, I would make a copy but contain my mana instead of Zexel's.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "As long as the volcano is stable, it doesn't matter whose mana. The important thing is that we need Zexel's power core to open the portal.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, I'll do my best! This time will be like the first time I do something important that I have never encountered.";
        }
        else if (tang == 10)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "I believe you will succeed, Vayne, as long as you have the heart, everything will go well.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "The problem is that I only see my mother using elemental mana to craft. So I'm not sure I'll succeed the first time. If it fails, Zexel's energy core will also be destroyed.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "I only have one chance. Certain! Definitely not fail!";
        }
        else if (tang >= 13)
        {
            TutorialPanel.SetActive(true);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        TutorialPanel.SetActive(true);
    }

    public void PressLTutorialButton()
    {
        if (TuTang > 0)
            TuTang -= 1;

        CheckTutorialStatus();
    }

    public void PressRTutorialButton()
    {
        TuTang += 1;

        if (TuTang > 1)
        {
            CutscenesController.cus74 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Tavern");
        }

        CheckTutorialStatus();
    }

    public void CheckTutorialStatus()
    {
        for (int i = 0; i < TutorialImage.Length; i++)
        {
            if (i == TuTang)
            {
                TutorialImage[i].SetActive(true);
            }
            else
            {
                TutorialImage[i].SetActive(false);
            }
        }
    }
}