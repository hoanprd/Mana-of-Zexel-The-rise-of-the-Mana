using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus60 : MonoBehaviour
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
            dia.text = "We've reached the village! Let's see, where should we find the village chief?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "???";
            dia.text = "Heh? Are you guys from outside the village?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Oh yes! Yes, we come from far away.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "???";
            dia.text = "Really? Where are you going, what's wrong? Here we do not receive regular guests if there is nothing related to the village, then bother everyone.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Actually, we need to meet the village chief to discuss...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "???";
            dia.text = "Talk about what?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "... Please help us, we need to see the village chief and we don't have any bad intentions!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "???";
            dia.text = "... I'm not the village chief to make decisions.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "In that case, just ask the village chief first, right?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "???";
            dia.text = "That's annoying... well let me tell the village chief if he wants to see you guys. Come to the south-west of this town there's a rather large house waiting for us.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Thank you very much! Oh, what's your name?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Shan";
            dia.text = "My name is Shan! It's just Shan.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "...Thank you Shan...";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus60 = 1;
            SceneManager.LoadScene("Inferno volcano");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus60 = 1;
        SceneManager.LoadScene("Inferno volcano");
    }
}