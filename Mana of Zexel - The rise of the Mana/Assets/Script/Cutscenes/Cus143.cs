using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus143 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, va3, va4, va5, va6, va7;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1, KlenerVAL1, HeeriumVAL1, OrinaVAL1, ManaElfVAL1, ZaneVAL1, ZaneVAR1;
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
            NameTagText.text = "Vayne";
            dia.text = "(Alia isn't planning to follow me.)";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Heh? Alia!";
        }
        else if (tang == 3)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "I've been waiting for you for a while! Hihi!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'd be happy to have you with me!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "Me too, where is our new journey going?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "Let's see... or go back to your hometown, you have to go back and tell your mother what happened or else she would be very worried.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Okay! Let's go, please show me the way!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm... let's go.";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(true);
            AliaVAR1.SetActive(true);
            NameTagText.text = "";
            dia.text = "The end.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus143 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Outtro");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus143 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Outtro");
    }
}