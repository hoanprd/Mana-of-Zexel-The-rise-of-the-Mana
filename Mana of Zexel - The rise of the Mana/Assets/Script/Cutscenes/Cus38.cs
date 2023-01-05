using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus38 : MonoBehaviour
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
            dia.text = "We've come a long way to the north!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "Hummm... Look at Vayne the ground here is shallower than usual!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "That means we're near the gate area?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "It's possible, just keep going.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "... Vay...ne!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia? What is going on?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Heh? ...Alia! Why is your face so bad!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "I don't know! This feeling... feels like my head is spinning around!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "Let me see!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "It's not okay! Alia has been poisoned! The sting on the hand must have been caused by the scorpion monsters!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "If so, it's dangerous! We have to go back to Zexel town!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "Do you have an antidote?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "I don't have one but I have a way to find the antidote!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "Okay, then let's go back to town!";
        }
        else if (tang >= 16)
        {
            CutscenesController.cus38 = 1;
            SceneManager.LoadScene("Inferno desert");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus38 = 1;
        SceneManager.LoadScene("Inferno desert");
    }
}