using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus109 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, AliaVAR1, MariaVAR1, MeruVAL1;
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
            MeruVAL1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Jesca! Where are you! Jessica!";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Mrs. Meru? Are you still okay?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Meru";
            dia.text = "It's Vayne's group, I've lost Jesca.";
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
        else if (tang >= 11)
        {
            CutscenesController.cus109 = 1;
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
        CutscenesController.cus109 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}