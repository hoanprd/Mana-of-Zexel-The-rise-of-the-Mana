using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus107 : MonoBehaviour
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
            NameTagText.text = "Alia";
            dia.text = "It's exciting, we'll definitely win against Zane.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "I told you not to be so subjective. Even if we're strong, that doesn't mean Zane will lose to us. Magicians have many dangerous tricks.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Okay, I won't let my guard down.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "";
            dia.text = "Rrrrrrrrrrroooommmmmmmmmmmmmmmmm....";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "!!! The ground is shaking...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "What's going on!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Earthquake?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "";
            dia.text = "Rrrrrrrrrrrroommmmmmmmmmm...";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "It stop.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "Is it really an ordinary earthquake or is something going on?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Inferno desert villager";
            dia.text = "Save us! Save us!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is there a cry for help from the inferno desert village?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "Looks like there's something there.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "It's not okay, Mrs. Meru and Jesca might be in danger. We have to go there.";
        }
        else if (tang >= 15)
        {
            CutscenesController.cus107 = 1;
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
        CutscenesController.cus107 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}