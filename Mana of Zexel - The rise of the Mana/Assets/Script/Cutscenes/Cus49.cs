using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus49 : MonoBehaviour
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
            NameTagText.text = "Klener";
            dia.text = "Alright! With this amount I think it's enough to be the antidote for our team.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm! If successfully expanding the territory, the villagers will live more peacefully.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Klener";
            dia.text = "Anyway, thanks to everyone who helped me, I'll definitely return the favor!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "No need to be so serious Klener, we're friends, it's normal to help each other.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "Did you start learning the truth from Vayne, Alia?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Heh? What's so strange about the set?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Nothing, you sound a bit like Vayne.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "Really?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Klener";
            dia.text = "I'm going back the town, see you guys soon.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus49 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno desert");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus49 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}