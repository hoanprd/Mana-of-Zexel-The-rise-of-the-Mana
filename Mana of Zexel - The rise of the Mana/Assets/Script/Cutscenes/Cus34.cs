using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus34 : MonoBehaviour
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
            dia.text = "Is everyone ready? Ahead is the inferno desert full of dangers!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "I've been ready from the moment I came to this town!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "I'm ready too! It's so exciting to be with a group of people like this!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's weird too! I think when I get to town everything will be as normal as I will be alone on this journey!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "But looking back, things are different! Not only have comrades like Maria and Alia, but also know many people in this town!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Hehe! You mean like it was fate that we met?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right! If it wasn't for fate, I'd be lying at home now, bored to death because I couldn't explore the world around me!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "You guys are so... Anyway thank you all for letting me have this precious experience!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Come on, let's go!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "All";
            dia.text = "Let's go!";
        }
        else if (tang >= 11)
        {
            CutscenesController.cus34 = 1;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus34 = 1;
        SceneManager.LoadScene("Zexel town");
    }
}