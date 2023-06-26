using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus119 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, va3;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {

        }
        else
        {

        }
        if (tang == 1)
        {
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Maybe we should split up to make the search easier.";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Ok!!!";
        }
        else if (tang == 3)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 4)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "There are no clues here either.";
        }
        else if (tang == 5)
        {
            va2.SetActive(false);
            va3.SetActive(true);
            MariaVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 6)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Let's see, we're not here yet...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey, there's someone over there!";
        }
        else if (tang == 8)
        {
            AliaVAL1.SetActive(false);
            NameTagText.text = "???";
            dia.text = "Who is that?";
        }
        else if (tang == 9)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Hey guys, there's a strange man in this corner!";
        }
        else if (tang == 10)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "???";
            dia.text = " Hey don't make me lose my mind! Luckily not a monster.";
        }
        else if (tang == 11)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Are you the husband of someone in the village of inferno ice?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Yes, I already have a wife, could it be...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Your wife is worried about you! Why are you here?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Actually after the attack of the inferno beast I lost my wedding ring but I told my wife that I will go down to the ice cave to get the ring back.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Maybe she didn't hear you out of panic.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "I've already worried my wife but I can't come back with my lost wedding ring because it's our keepsake.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, we'll help you get the ring back.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Really? Thanks everyone!";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus119 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("InsideIceCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus119 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }
}