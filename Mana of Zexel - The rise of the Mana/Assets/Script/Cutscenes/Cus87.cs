using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus87 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
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
            NameTagText.text = "Vayne";
            dia.text = "We just need to put two mana cores like this?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alia";
            dia.text = "Still no response?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Heh? Two energy cores flying towards the door scene?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "";
            dia.text = "Glowinggggggggggggg...";
        }
        else if (tang == 5)
        {
            NameTagText.text = "";
            dia.text = "Rammmmmmmmmmmmmmm...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "The door is open!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Can we go in already?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "Come on, maybe your father is waiting there, Vayne.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Take it easy, be careful of traps and monsters around.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "What a passionate youth.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "???";
            dia.text = "I just felt something coming.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "???";
            dia.text = "That's annoying, it seems the Sicxalon revival has been put on hold. But that's okay, everything happened faster than I expected hahahahahaaa...";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus87 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel gate");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus87 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel gate");
    }
}