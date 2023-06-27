using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus128 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MeruVAL1, JescaVAL1, JescaVAR1;
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
            AliaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Unbelievable, that scorpion is stronger than the ones we used to hit.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's probably driven them mad since the earthquake.";
        }
        else if (tang == 3)
        {
            AliaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            MeruVAL1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Jesca! Where are you! Jesca!";
        }
        else if (tang == 4)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Mrs. Meru? Are you still okay?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Meru";
            dia.text = "I lost Jesca.";
        }
        else if (tang == 6)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Do you remember the last time you saw Jesca?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Meru";
            dia.text = "I lost her near the mana cliff southwest of this village.";
        }
        else if (tang == 8)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Maybe she's there, let us help you find it.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Meru";
            dia.text = "Thank you guys so much!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Let's go guys, Jesca needs our help.";
        }
        else if (tang == 11)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            MeruVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            JescaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "Ahhhhhhhhh!!!";
        }
        else if (tang == 13)
        {
            JescaVAL1.SetActive(false);
            NameTagText.text = "Mana eagle";
            dia.text = "Wahhhh...";
        }
        else if (tang == 14)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Get away from that hideous eagle! Hyaaaa.";
        }
        else if (tang == 15)
        {
            JescaVAR1.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "It's Alia's sister!";
        }
        else if (tang == 16)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Jesca, are you okay?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Jesca";
            dia.text = "I'm fine, luckily you got there in time. I was surrounded by these eagles so I couldn't run back to the village.";
        }
        else if (tang == 18)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Back off and let us deal with this monster!";
        }
        else if (tang >= 19)
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