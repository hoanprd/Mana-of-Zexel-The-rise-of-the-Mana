using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus58 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1, HeeriumVAR1;
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
            MrLanceVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Are you still not thinking of sourcing from inferno ice or inferno volcano, Heerium?";
        }
        else if (tang == 2)
        {
            HeeriumVAR1.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "Wow! You know that it has been stopped exporting for more than a year, if I have someone to export there, I have imported a large quantity.";
        }
        else if (tang == 3)
        {
            MrLanceVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Is it the Heerium? You still good isn't it?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Heerium";
            dia.text = "Oh is that Vayne? Is your journey have any difficults?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well... it's not too difficult, sir...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Heerium";
            dia.text = "Well, if you have difficulty with weapons, please stop by my place! Hahaha.";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Uncle Heerium, if I'm not mistaken I've heard you import goods from the land of inferno volcano and inferno ice, right?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Heerium";
            dia.text = "Yes, I mainly import minerals but now I don't import anymore. Is something wrong?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "We were wondering how to get there. What can you do to help us?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Heerium";
            dia.text = "To those two lands? I don't know because I've never been there but I know those two lands west of the inferno desert told by the merchants there.";
        }
        else if (tang == 11)
        {
            MariaVAL1.SetActive(false);
            MrLanceVAL1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "I advise you not to interfere too much in the private affairs of those two lands!";
        }
        else if (tang == 12)
        {
            HeeriumVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Not to interfere in privacy? What do you mean?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "In the past, this town and the mayor of the two lands have cooperated with each other like Uncle Heerium who is an importer of minerals in those two lands, but a year ago they closed the market with our town.";
        }
        else if (tang == 14)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "What do you mean between them and us?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "That's understandable, but I don't know the details.";
        }
        else if (tang == 16)
        {
            MrLanceVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I see, in that case we just have to do what's necessary.";
        }
        else if (tang == 17)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "If so, what land do you consider before Vayne?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "... I don't know. I think I should start at the volcano first because I've never been to a volcano before.";
        }
        else if (tang == 19)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Hehe, I foretell it will be hotter than the inferno desert.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "We just need to work hard from the beginning.";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Alia";
            dia.text = "Then let's go.";
        }
        else if (tang == 22)
        {
            AliaVAR1.SetActive(false);
            HeeriumVAR1.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "Good luck to you guys hahaha.";
        }
        else if (tang >= 23)
        {
            CutscenesController.cus58 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus58 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}