using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus82 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ManaWaterVAL1, ManaWaterVAR1;
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
            dia.text = "Hey mana water, give this back pain medicine a try! I think it will work!";
        }
        else if (tang == 2)
        {
            ManaWaterVAR1.SetActive(true);
            NameTagText.text = "Mana water";
            dia.text = "Hmm, wait for me!";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            ManaWaterVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 4)
        {
            ManaWaterVAL1.SetActive(true);
            NameTagText.text = "Mana water";
            dia.text = "Hmmm... it's really effective, the pain from small to large is gradually disappearing... so comfortable... hahaha.";
        }
        else if (tang == 5)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Hey old man, don't forget your promise because it's so good!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mana water";
            dia.text = "... I'm not a broken promise.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Mana water";
            dia.text = "This is the bottle of purification water. Please use it carefully.";
        }
        else if (tang == 8)
        {
            ManaWaterVAL1.SetActive(true);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks like the first problem is solved already?";
        }
        else if (tang == 9)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes, but I'm still curious about you mana water. After all, what is our destiny?";
        }
        else if (tang == 10)
        {
            MariaVAL1.SetActive(false);
            ManaWaterVAL1.SetActive(true);
            NameTagText.text = "Mana water";
            dia.text = "... I told you you will know in the future! I think you guys have more important things to do!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, then here we go!";
        }
        else if (tang == 12)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Mana water";
            dia.text = "What's wrong red haired girl?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "No... nothing, just a little nostalgic for this place. I'm going!";
        }
        else if (tang == 15)
        {
            ManaWaterVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 16)
        {
            ManaWaterVAL1.SetActive(true);
            NameTagText.text = "Mana water";
            dia.text = "It's pitiful for that girl, but she will realize her true worth.";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus82 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Wishing forest");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus82 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}