using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus126 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MeruVAR1;
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
            dia.text = "Mrs. Meru, we're back!";
        }
        else if (tang == 2)
        {
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Seems to be bothering you guys a while.";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Just let us handle this. Okay, let's start the device!";
        }
        else if (tang == 4)
        {
            AliaVAL1.SetActive(false);
            MeruVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "The hand of the clock is going up as we get closer to this place, isn't it?";
        }
        else if (tang == 6)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks like the underground water of mana is under our feet. Now just dig it up.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's going to take a while because we still don't know how deep it is.";
        }
        else if (tang == 8)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Why don't we just use a lot of bombs and blow this place up!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Huh? Is this idea... a bit too much?";
        }
        else if (tang == 10)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "... I don't know.";
        }
        else if (tang == 11)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Come to think of it, if we dig it will be very time consuming and difficult to stick to the groundwater. If we use bombs to explode around, it will be easy to find and also create a big hole for the lake.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Makes sense, right? Then I'll make a lot of bombs.";
        }
        else if (tang == 13)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It's true that Alia knows how to use her head much better, let's maintain it!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey, you're not the only one who knows how to use your head!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "Okay, okay, I'll help Vayne.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey stop ignoring me!";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus126 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno desert");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus126 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}