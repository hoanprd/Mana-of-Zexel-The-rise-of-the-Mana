using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus57 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Okay, just put it here.";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Okay! Done!";
        }
        else if (tang == 4)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Doesn't it seem to work? She didn't feel any mana in the machine.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "No, look at how much time it took for the machine to absorb a lot of mana through its gauge.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Did you cover the barrier? But do that for what?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Of course, avoid the slimes and other creatures that attack the machine. Because the creatures here often gather in places with a lot of mana.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "I see, you're so wise.";
        }
        else if (tang == 9)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "So does this mean this is our safe place? If so, I don't have to worry about those tough slimes anymore.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Not really, they can sense our presence. So we should just leave the machine alone and only get close to it when it's in use!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "Heh... Then... I still can't get rid of the slimes.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's okay, you just need to limit coming here.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alia";
            dia.text = "Okay, okay, let's go back to town.";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus57 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana gate");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus57 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana gate");
    }
}