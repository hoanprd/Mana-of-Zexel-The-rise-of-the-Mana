using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus140 : MonoBehaviour
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
            KlenerVAL1.SetActive(true);
            NameTagText.text = "Klener";
            dia.text = "Vayne, Alia you two are back!";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Uhm...";
        }
        else if (tang == 3)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Klener";
            dia.text = "Where's Maria? What is she busy with?";
        }
        else if (tang == 5)
        {
            KlenerVAL1.SetActive(false);
            MrLanceVAL1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria! She doesn't come back with us?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria! She doesn't come back with us?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Maria did... she sacrificed herself for us...";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "No... Maria you promised to come back!";
        }
        else if (tang == 9)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Mr. Lance please calm down... she made no senseless sacrifices, she saved the world... we will never forget her.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I see, I need... a quiet place just me...";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            MrLanceVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia I'm leaving town tomorrow morning, tomorrow morning we'll talk.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "Uhm... Good night.";
        }
        else if (tang >= 15)
        {
            CutscenesController.cus140 = 1;
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
        CutscenesController.cus140 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}