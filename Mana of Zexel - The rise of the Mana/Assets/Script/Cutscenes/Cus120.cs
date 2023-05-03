using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus120 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAR1, AliaVAL1, MariaVAR1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Villager (Man)";
            dia.text = "It's hard, isn't it? I've searched everywhere!";
        }
        else if (tang == 2)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 3)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Huh? What's shiny in that corner?";
        }
        else if (tang == 4)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "What did you find, Alia?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "Is this the ring that man is looking for?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "That's right! That's the ring!";
        }
        else if (tang == 7)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks like you made a big contribution today, Alia.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "Hihi, it's a small matter!";
        }
        else if (tang == 9)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "And there's a lot of luck, isn't it?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Come on, I did my best for everyone!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Anyway, we shouldn't stay here long and let's go back to the village, I don't want my wife to worry.";
        }
        else if (tang >= 12)
        {
            CutscenesController.cus120 = 1;
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
        CutscenesController.cus120 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }
}