using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus91 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAR1, ManaElfVAL1, ManaElfVAR1, ManaRockVAL1, ManaLightVAL1;
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
            ManaElfVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Mana elf";
            dia.text = "Looks like everyone found Zexel's fire and ice mana core.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right! We have obtained those two cores of energy with all our sincerity...";
        }
        else if (tang == 3)
        {
            ManaElfVAL1.SetActive(false);
            ManaRockVAL1.SetActive(true);
            NameTagText.text = "Mana rock";
            dia.text = "If you are selfish in defying both the inferno volcano and inferno ice villages, you will fail the Zexel Gate test.";
        }
        else if (tang == 4)
        {
            ManaRockVAL1.SetActive(false);
            ManaLightVAL1.SetActive(true);
            NameTagText.text = "Mana light";
            dia.text = "And you will be devoured by the mana core. However, you have passed the test wonderfully.";
        }
        else if (tang == 5)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "So resolving the conflict between the two villages is part of the challenge? Why didn't the gods foretell?";
        }
        else if (tang == 6)
        {
            ManaLightVAL1.SetActive(false);
            ManaElfVAL1.SetActive(true);
            NameTagText.text = "Mana elf";
            dia.text = "Only then will we be able to see the true heart of humans, which is also the basis of other mana's belief in you.";
        }
        else if (tang == 7)
        {
            ManaElfVAL1.SetActive(false);
            ManaRockVAL1.SetActive(true);
            NameTagText.text = "Mana rock";
            dia.text = "Don't be selfish especially between humans. That is the key to being able to make friends with other species like us mana.";
        }
        else if (tang == 8)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Then can we open the Zexel portal with these two power cores?";
        }
        else if (tang == 9)
        {
            ManaRockVAL1.SetActive(false);
            ManaElfVAL1.SetActive(true);
            NameTagText.text = "Mana elf";
            dia.text = "You just need to put two of Zexel's energy cores in front of the gate to open it.";
        }
        else if (tang == 10)
        {
            ManaElfVAL1.SetActive(false);
            ManaLightVAL1.SetActive(true);
            NameTagText.text = "Mana light";
            dia.text = "However, the main challenge begins now. What you do next will determine the fate of this place.";
        }
        else if (tang == 11)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Decide fate? I still don't understand what will happen next.";
        }
        else if (tang == 12)
        {
            ManaLightVAL1.SetActive(false);
            ManaElfVAL1.SetActive(true);
            NameTagText.text = "Mana elf";
            dia.text = "You will understand once you get there. The journey of maturity, everyone can understand that.";
        }
        else if (tang == 13)
        {
            ManaElfVAL1.SetActive(false);
            ManaRockVAL1.SetActive(true);
            NameTagText.text = "Mana rock";
            dia.text = "Zexel before his death brought temporary peace between humans and mana. Those who hold it will be those people.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "Sounds stressful, right? If so, we'll go to the gate!";
        }
        else if (tang == 15)
        {
            ManaRockVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 16)
        {
            ManaLightVAL1.SetActive(true);
            NameTagText.text = "Mana light";
            dia.text = "Are you sure they can do it?";
        }
        else if (tang == 17)
        {
            ManaElfVAR1.SetActive(true);
            NameTagText.text = "Mana elf";
            dia.text = "If Zexel believes in the next generation, then they can do it. Not only that, the red-haired alchemist, is the key to the cycle of peace continuing.";
        }
        else if (tang >= 18)
        {
            CutscenesController.cus91 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana temple");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus91 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana temple");
    }
}