using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus125 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Success! Looks like new!";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Great, isn't it? But how to use it?";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Just press the start button in the middle to turn it on and off, then the energy level will be measured when mana is found.";
        }
        else if (tang == 4)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Okay, let's go back to the inferno desert!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 6)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What's wrong with Maria? Do you look a bit lost?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Nothing, I'm just thinking too much.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "(Seems like I also see my self-worth more when I'm with Vayne and Alia.)";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Let's go.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus125 = 1;
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
        CutscenesController.cus125 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Save room");
    }
}