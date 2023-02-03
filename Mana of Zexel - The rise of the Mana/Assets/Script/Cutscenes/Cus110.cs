using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus110 : MonoBehaviour
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
            NameTagText.text = "Jesca";
            dia.text = "Ahhhhhhhhh!!!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Mana eagle";
            dia.text = "Wahhhh...";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Get away from that hideous eagle! Hyaaaa.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Jesca";
            dia.text = "It's Alia's sister!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "Jesca, are you okay?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Jesca";
            dia.text = "I'm fine, luckily you got there in time. I was surrounded by these eagles so I couldn't run back to the village.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "It good that you are fine! May you go back to the village, Mrs. Meru is worried about you!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Jesca";
            dia.text = "Yes! But what's going on in the world, suddenly there's an earthquake and the monsters become more ferocious.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "I don't know, but this means something bad is about to happen.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus110 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana cliff");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus110 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana cliff");
    }
}