using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus109 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks like the monster just now is the last one to deal with.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alia";
            dia.text = "Why did they attack inside the town so suddenly, they don't dare to go deep into the town these days.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "Something provoked them. Surely the earthquake just now had something to do with this.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria, are you all right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "I'm fine, you are fine dad! Phuhhh...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Klener";
            dia.text = "Thank you, Vayne, the people have been safely evacuated.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Luckily no one was hurt... There's someone up there...";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mana guardian";
            dia.text = "Looks like everyone cleaned up the monsters before I got there.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "As a mana guardian, why are you here?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Mana guardian";
            dia.text = "The mana gods want to meet those people. Please come over there.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm, we got it and we'll be right there.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "Dad, please go to a safe place, we will be back soon.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "Klener I'm counting on you here!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Klener";
            dia.text = "Of course, I'll protect everyone.";
        }
        else if (tang >= 16)
        {
            CutscenesController.cus109 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus109 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}