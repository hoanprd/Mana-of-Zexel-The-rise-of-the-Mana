using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus128 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, JescaVAL1, JescaVAR1;
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
            JescaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "Ahhhhhhhhh!!!";
        }
        else if (tang == 2)
        {
            JescaVAL1.SetActive(false);
            NameTagText.text = "Mana eagle";
            dia.text = "Wahhhh...";
        }
        else if (tang == 3)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Get away from that hideous eagle! Hyaaaa.";
        }
        else if (tang == 4)
        {
            JescaVAR1.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "It's Alia's sister!";
        }
        else if (tang == 5)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
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
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
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
            CutscenesController.cus128 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("BSManaEagle 1");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus128 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSManaEagle 1");
    }
}