using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus84 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAR1, AlasaVAL1, AlasaVAR1, AsilaVAL1, AsilaVAR1;
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
            AsilaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Alasa! It's been a while since we met like this!";
        }
        else if (tang == 2)
        {
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Hum... Don't think I'm here for you. I came to see if this kid Vayne can do what he says?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Asila";
            dia.text = "... Vayne, are you ready?";
        }
        else if (tang == 4)
        {
            AsilaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I'm ready, now let's get started.";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(false);
            AlasaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 6)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "";
            dia.text = "Glowing...";
        }
        else if (tang == 7)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "The land... is green again.";
        }
        else if (tang == 8)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "This land used to contain mana too? I can feel its inherent mana mixed with Vayne's mana.";
        }
        else if (tang == 9)
        {
            AliaVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "What a land that is coming back to life...";
        }
        else if (tang == 10)
        {
            MariaVAR1.SetActive(false);
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Is this true?";
        }
        else if (tang == 11)
        {
            AsilaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Now, I've done what needed to be done, do you have any questions?";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Alasa, I... I...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alasa";
            dia.text = "Even so, I still don't trust you.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Asila";
            dia.text = "... I know it's hard but anyway, the land that our parents believed in has come back to life, with this we will combine the two villages into one and...";
        }
        else if (tang == 15)
        {
            AsilaVAL1.SetActive(false);
            AlasaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Crackkkkk... crackkkkkkkkk...";
        }
        else if (tang == 16)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "What is it?";
        }
        else if (tang == 17)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "There's something on that hill!";
        }
        else if (tang == 18)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Crackkkkkkkkkkkkkkkkkkk...";
        }
        else if (tang == 19)
        {
            NameTagText.text = "";
            dia.text = "Gruuuuuuuuuuuuuuuuuuuuuuuuhhhhhhhhhhh...";
        }
        else if (tang == 20)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "What is that! A monster!";
        }
        else if (tang == 21)
        {
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "It can't be... Inferno beast!!!";
        }
        else if (tang == 22)
        {
            VayneVAL1.SetActive(false);
            AlasaVAL1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Isn't that thing sealed a long time ago? How come it got out!";
        }
        else if (tang == 23)
        {
            AlasaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "This monster, this place has a conflict that needs to be resolved, this is not a place for you to mess around.";
        }
        else if (tang == 24)
        {
            AsilaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Chief Asila and Alasa stay back we'll deal with it.";
        }
        else if (tang == 25)
        {
            AliaVAL1.SetActive(false);
            AlasaVAL1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Where's the goddamn Shan gone! Just when we need him.";
        }
        else if (tang == 26)
        {
            VayneVAR1.SetActive(false);
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Be careful, that monster is an ancient monster so it's very strong.";
        }
        else if (tang == 27)
        {
            AlasaVAL1.SetActive(false);
            AsilaVAR1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Rest assured we are not weak. Come on up, everyone!";
        }
        else if (tang >= 28)
        {
            CutscenesController.cus84 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Alta inferno");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus84 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Alta inferno");
    }
}