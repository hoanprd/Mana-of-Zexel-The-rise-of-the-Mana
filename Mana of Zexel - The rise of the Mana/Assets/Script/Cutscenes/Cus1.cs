using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus1 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject va2;
    public GameObject va3;
    public GameObject va4;
    public GameObject NameTag;
    private int tang=0;
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
            NameTagText.text = "Dante";
            dia.text = "Look Zane! This must be it, Mana of Zexel.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Zane";
            dia.text = "You right. I can feel a huge amount of mana in that thing.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Dante";
            dia.text = "With this we cam help people everywhere with the fuel problem.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Dante";
            dia.text = "Right Zane?";
        }
        else if (tang == 5)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "Dante";
            dia.text = "Uh... What the?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Zane";
            dia.text = "That's pathetic, Dante.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Dante";
            dia.text = "...Uh... But why? Why you do this.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Zane";
            dia.text = "You should know that with this power, I can do anything. Even dominating this world.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Dante";
            dia.text = "...Unbelievably, I was miserably betrayed. Anyway, your selfishness and ambition will destroy you.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Zane";
            dia.text = "Hahaha. So that was your last words Dante?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Zane";
            dia.text = "It's sad that you didn't get to see the world kneeling down on me. Once I revieve Malagam, I will become the strongest.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Zane";
            dia.text = "Good night Dante. Hahahahahahaha...";
        }
        else if (tang == 13)
        {
            va2.SetActive(false);
            va3.SetActive(true);
            NameTag.SetActive(false);
            dia.text = "1 year later";
        }
        else if (tang == 14)
        {
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I'm going mom! Wish you stay healthy.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Jin";
            dia.text = "Well, it's been over a year and your father still hasn't returned. I hope you find your father again.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "I will!";
        }
        else if (tang == 17)
        {
            va3.SetActive(false);
            va4.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Phuff... Am I nearing to Zexel town yet?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Thief";
            dia.text = "Stop there kid! Give me all your jewelry and valuables things.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "Are you kidding me? A thief in middel of the day? I think I have to teach this bandit a lesson!";
        }
        else if (tang >= 20)
        {
            CutscenesController.cus1 = 1;
            SceneManager.LoadScene(11);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus1 = 1;
        SceneManager.LoadScene(11);
    }
}
