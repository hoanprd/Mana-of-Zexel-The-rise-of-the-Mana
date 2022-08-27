using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus1 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    public GameObject va2;
    public GameObject va3;
    public GameObject va4;
    private int tang=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
            dia.text = "Dante: Look Zane! This must be it, Mana of Zexel.";
        else if (tang == 2)
            dia.text = "Zane: You right. I can feel a huge amount of mana in that thing.";
        else if (tang == 3)
            dia.text = "Dante: With this we cam help people everywhere with the fuel problem.";
        else if (tang == 4)
            dia.text = "Dante: Right Zane?";
        else if (tang == 5)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            dia.text = "Dante: Uh... What the?";
        }
        else if (tang == 6)
            dia.text = "Zane: That's pathetic, Dante.";
        else if (tang == 7)
            dia.text = "Dante: ...Uh... But why? Why you do this.";
        else if (tang == 8)
            dia.text = "Zane: You should know that with this power, I can do anything. Even dominating this world.";
        else if (tang == 9)
            dia.text = "Dante: ...Unbelievably, I was miserably betrayed. Anyway, your selfishness and ambition will destroy you.";
        else if (tang == 10)
            dia.text = "Zane: Hahaha. So that was your last words Dante?";
        else if (tang == 11)
            dia.text = "Zane: It's sad that you didn't get to see the world kneeling down on me. Once I revieve Malagam, I will become the strongest.";
        else if (tang == 12)
            dia.text = "Zane: Good night Dante. Hahahahahahaha...";
        else if (tang == 13)
        {
            va2.SetActive(false);
            va3.SetActive(true);
            dia.text = "1 year later";
        }
        else if (tang == 14)
            dia.text = "Vayne: I'm going mom! Wish you stay healthy.";
        else if (tang == 15)
            dia.text = "Jin: Well, it's been over a year and your father still hasn't returned. I hope you find your father again.";
        else if (tang == 16)
            dia.text = "Vayne: I will!";
        else if (tang == 17)
        {
            va3.SetActive(false);
            va4.SetActive(true);
            dia.text = "Vayne: Phuff... Am I nearing to Zexel town yet?";
        }
        else if (tang == 18)
            dia.text = "Thief: Stop there kid! Give me all your jewelry and valuables things.";
        else if (tang == 19)
            dia.text = "Vayne: Are you kidding me? A thief in middel of the day? I think I have to teach this bandit a lesson!";
        else if (tang >= 20)
        {
            PlayerPrefs.SetInt("cus1", 1);
            SceneManager.LoadScene(20);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        PlayerPrefs.SetInt("cus1", 1);
        SceneManager.LoadScene(20);
    }
}
