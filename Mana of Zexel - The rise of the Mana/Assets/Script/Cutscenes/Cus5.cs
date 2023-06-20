using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus5 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject[] TutorialImage;
    public GameObject va1, TutorialPanel;
    public GameObject VayneVAR1, AliaVAL1;
    public GameObject NameTag;
    private int tang, TuTang;

    // Start is called before the first frame update
    void Start()
    {
        tang = TuTang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
        {
            AliaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Here is my room! Be as natural as you are at home.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Mr. Lance let you rent this room too?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right, actually Maria let me stay for free.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Maria? Who is that?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "Well, she is the daughter of Mr. Lance, the one who saved me and gave me the place I am now.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Another special thing is that she is also an alchemist like you.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "So that's it, no wonder I can see a large cauldron in the corner of the room over there.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "Anyway, like I said, make yourself at home.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you Alia!";
        }
        else if (tang >= 10)
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
        if (TuTang > 1)
            TuTang -= 1;

        CheckTutorialStatus();
    }

    public void PressRTutorialButton()
    {
        TuTang += 1;

        if (TuTang > 1)
        {
            CutscenesController.cus5 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Save room");
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
