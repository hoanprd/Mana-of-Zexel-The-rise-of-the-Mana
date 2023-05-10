using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus105 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAL1, JescaVAL1, MeruVAR1;
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
            dia.text = "Oh grandma! You are back!";
        }
        else if (tang == 2)
        {
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "I'm back! Is my granddaughter at home well?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Jesca";
            dia.text = "Of course it's fine, I also prepared some premixed medicine while you were away.";
        }
        else if (tang == 4)
        {
            MeruVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "You're so good Jesca, do you want to be a great doctor like your grandmother?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Jesca";
            dia.text = "Ah, Alia, are you feeling well! I'm very happy to meet you.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Jesca";
            dia.text = "Are you thinking of stopping by here?";
        }
        else if (tang == 7)
        {
            JescaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Too bad we'll have to go back to Zexel town, if given the chance I'll visit.";
        }
        else if (tang == 8)
        {
            AliaVAR1.SetActive(false);
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "You guys better be careful. Wounds like that are hard to save.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "We'll be more careful.";
        }
        else if (tang == 10)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "By the way, Mrs. Meru, what do you mean by calling the girl we met before a magician?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Meru";
            dia.text = "Just a guess, usually magicians have silver hair as well as eye color.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Meru";
            dia.text = "But forget it, I feel like she's your friend so it should be fine.";
        }
        else if (tang == 13)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "... Anyway, we thank you very much.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Meru";
            dia.text = "It's okay, I wish you all a safe journey.";
        }
        else if (tang >= 15)
        {
            CutscenesController.cus105 = 1;
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
        CutscenesController.cus105 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}