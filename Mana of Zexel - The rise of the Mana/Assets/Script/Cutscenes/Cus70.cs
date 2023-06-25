using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus70 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, FOP;
    public GameObject VayneVAL1, VayneVAR1, MariaVAL1, ShanVAL1, AlasaVAR1;
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
            ShanVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Alasa village chief, we have found the ice crystal!";
        }
        else if (tang == 2)
        {
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Just in time! I've finished making this stick that holds this ice crystal.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alasa";
            dia.text = " With this ice crystal, three people can obtain this fire energy core without any problems.";
        }
        else if (tang == 4)
        {
            ShanVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Will this prevent the village at the inferno volcano from being destroyed?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alasa";
            dia.text = "That's right. Shan! Lead them to the inferno volcano and tell Asila that she can get the fire core.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alasa";
            dia.text = "Oh one more thing, don't tell me this is an ice crystal from inferno ice, I want to surprise my brother!";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "... Surprise?";
        }
        else if (tang == 8)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "... Okay, if that's what you want, we'll keep quiet about the ice crystals.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alasa";
            dia.text = "Hahaha, okay I'll give this to you Vayne, good luck. After obtaining the fire core, I will give you the ice energy core.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes... Huh?";
        }
        else if (tang == 11)
        {
            VayneVAL1.SetActive(false);
            AlasaVAR1.SetActive(false);
            FOP.SetActive(true);
            NameTagText.text = "";
            dia.text = "Glowinggggggggggggggggg.............";
        }
        else if (tang == 12)
        {
            FOP.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "(What! Is the thing Orina gave me that is glowing again?)";
        }
        else if (tang == 13)
        {
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Any questions, Vayne?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "No it nothing, here we go.";
        }
        else if (tang == 15)
        {
            VayneVAL1.SetActive(false);
            AlasaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 16)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Just now, was the glowing thing Orina's, Vayne?";
        }
        else if (tang == 17)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right, it seems to react to ice crystals.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "May we be able to safely obtain the fire core.";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus70 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno ice");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus70 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}