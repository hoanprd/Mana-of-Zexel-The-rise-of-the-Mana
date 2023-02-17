using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus94 : MonoBehaviour
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
            NameTagText.text = "Maria";
            dia.text = "We've come a long way and still haven't met any dragons.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Anyway, I'll keep looking, I'm sure I'll find it.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "??? Something just flew by.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Something, it's very loud.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mana dragon";
            dia.text = "Gruhhhhhhhhhhhhhhhhhh...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "It looks like a real cow inside.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hey dragon! We don't want to hurt you, we just want one of your scales okay?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Mana dragon";
            dia.text = "Gruhhhhhhhhhhhhhhh...";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne, not all dragons understand and are friendly with humans.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "If that's the case, then we'll have to use force.";
        }
        else if (tang >= 12)
        {
            CutscenesController.cus94 = 1;
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
        CutscenesController.cus94 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana cliff");
    }
}