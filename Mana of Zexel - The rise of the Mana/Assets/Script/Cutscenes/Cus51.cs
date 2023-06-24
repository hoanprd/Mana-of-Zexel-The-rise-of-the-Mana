using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus51 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, ManaGuardianVAR1;
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
            NameTagText.text = "???";
            dia.text = "???: Stop there, human.";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "!!!";
        }
        else if (tang == 3)
        {
            ManaGuardianVAR1.SetActive(true);
            NameTagText.text = "???";
            dia.text = "You dare to go to this sacred place? I won't let you go any further.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Wait, we're not here to fight.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "???";
            dia.text = "Shut up and fight, I don't believe any human word.";
        }
        else if (tang == 6)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "We have to fight Vayne, this guy seems to want to destroy us.";
        }
        else if (tang == 7)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "I can sense a huge amount of mana from this guy.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "???";
            dia.text = "Let's start the battle! Graaaaaaaa!!!";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus51 = 1;
            ContainerController.LoadingOpen = true;
            HPMPBarController.EIndex = 21;
            SceneManager.LoadScene("BSManaGuardian 1");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus51 = 1;
        ContainerController.LoadingOpen = true;
        HPMPBarController.EIndex = 21;
        SceneManager.LoadScene("BSManaGuardian 1");
    }
}