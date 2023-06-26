using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus100 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, MariaVAL1, MariaVAR1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Mana dragon";
            dia.text = "Grahhhhhhhhhhh...";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Ha... ha... ha... Maria hold that dragon back!";
        }
        else if (tang == 3)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Come on Vayne!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hyaaaaaaaa...";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Senggggggggggggg...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mana dragon";
            dia.text = "Grahhhhhhhh...";
        }
        else if (tang == 7)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It flew away...";
        }
        else if (tang == 8)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hehe... Luckily I got the dragon scales in time.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Well done Vayne, with this we can Alia.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay! We're going to... um... huh... hump...";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne! Are you alright?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Maybe I tried too hard.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "I'm tired too but we still have a few things to deal with.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'm fine, Alia is waiting for us.";
        }
        else if (tang >= 15)
        {
            CutscenesController.cus100 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana cliff");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus100 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana cliff");
    }
}