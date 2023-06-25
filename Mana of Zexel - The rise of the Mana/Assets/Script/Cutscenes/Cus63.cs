using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus63 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, FOP;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1, OrinaVAL1;
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
            dia.text = "Maybe the next trip will be longer.";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Huh? It's Orina!";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            OrinaVAL1.SetActive(true);
            NameTagText.text = "Orina";
            dia.text = "You guys look tough, don't you?";
        }
        else if (tang == 4)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It's a long story...";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Orina";
            dia.text = "Needless to say, I came here to give Vayne this.";
        }
        else if (tang == 6)
        {
            OrinaVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            FOP.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 7)
        {
            FOP.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "What is this?";
        }
        else if (tang == 8)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "A fire?";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(false);
            OrinaVAL1.SetActive(true);
            NameTagText.text = "Orina";
            dia.text = "Use it when necessary, Vayne! Think of this as a reward for the trouble I caused you guys! Out of debt! Good bye!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey Orina! You still haven't said what this thing does!";
        }
        else if (tang == 11)
        {
            OrinaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "... What a mysterious person.";
        }
        else if (tang >= 13)
        {
            CutscenesController.cus63 = 1;
            ContainerController.LoadingOpen = true;
            ContainerController.FireOfPeacePick = 1;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus63 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.FireOfPeacePick = 1;
        SceneManager.LoadScene("Zexel town");
    }
}