using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus114 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, AliaVAR1, MariaVAL1, MariaVAR1, JescaVAL1, ManaGuardianVAL1, MeruVAR1;
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
            dia.text = "Ah! It's Vayne's group!";
        }
        else if (tang == 2)
        {
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "What's wrong with you guys coming here?";
        }
        else if (tang == 3)
        {
            JescaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Well, we came to help the people in the village avoid the monsters.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Meru";
            dia.text = "Monsters? They haven't come back here yet, but according to scouts outside the village, they might attack here again.";
        }
        else if (tang == 5)
        {
            MeruVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "That's why we came to protect this village!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "We'll create a barrier to stop these monsters. But we need permission from the village chief here.";
        }
        else if (tang == 7)
        {
            AliaVAR1.SetActive(false);
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Lucky that, you are free to do, I'm the village chief here.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well, that's surprising if you believe in us.";
        }
        else if (tang == 9)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            VayneVAL1.SetActive(false);
            MeruVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Glowinggggggggggggg...";
        }
        else if (tang == 10)
        {
            va2.SetActive(false);
            va1.SetActive(true);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Boundary completed.";
        }
        else if (tang == 11)
        {
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Thank you very much.";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "We also only come out of our hearts. We can't just stand by and watch others get hurt.";
        }
        else if (tang == 13)
        {
            MariaVAL1.SetActive(false);
            MeruVAR1.SetActive(false);
            NameTagText.text = "Inferno desert villager";
            dia.text = "There are monsters in the sky!";
        }
        else if (tang == 14)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's... mana gurdian?";
        }
        else if (tang == 15)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Everyone calm down, it's not a monster and it won't harm you!";
        }
        else if (tang == 16)
        {
            VayneVAL1.SetActive(false);
            ManaGuardianVAL1.SetActive(true);
            NameTagText.text = "Mana guardian";
            dia.text = "I finally found you guys.";
        }
        else if (tang == 17)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "As a mana guardian, why did you come here?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Mana guardian";
            dia.text = "The mana gods want to meet you guys. Please come over there.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne...";
        }
        else if (tang == 20)
        {
            ManaGuardianVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Uhm, we got it and we'll be right there.";
        }
        else if (tang == 21)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "We're going Mrs. Meru, goodbye Jesca!";
        }
        else if (tang == 22)
        {
            VayneVAL1.SetActive(false);
            JescaVAL1.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "Goodbye and thank you for everything!";
        }
        else if (tang >= 23)
        {
            CutscenesController.cus114 = 1;
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
        CutscenesController.cus114 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}