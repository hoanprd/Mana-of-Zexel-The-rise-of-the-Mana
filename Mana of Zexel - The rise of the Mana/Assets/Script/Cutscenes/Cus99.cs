using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus99 : MonoBehaviour
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
            NameTagText.text = "Meru";
            dia.text = "I think this part I can go home on my own, I don't need you guys to follow me.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "We have to escort you back to safety!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right! Grandma got my treatment for free, so we decided to take you home.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Meru";
            dia.text = "Okay, if you guys say that, I'll have to deal with it.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "Is that... Orina?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Orina";
            dia.text = "Oh, so Alia is well again?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Of course, how could I surrender to death.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ah thank you so much Orina for pointing out the location of the mana dragon.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Orina";
            dia.text = "There's no such thing as a privilege for regular customers.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "This is the first time I've heard a pleasant word from you, Orina.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Orina";
            dia.text = "Then stop being annoyed with me.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Meru";
            dia.text = "Hmm... Are you a magician, girl?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Orina";
            dia.text = "What?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "What's wrong with Mrs. Meru?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Meru";
            dia.text = "Oh nothing... I just feel something strange. It's like leaving. We just go on.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Orina";
            dia.text = "That old lady, almost gave me goosebumps, looks like I have to hide my eyes and change my hair.";
        }
        else if (tang >= 18)
        {
            CutscenesController.cus99 = 1;
            SceneManager.LoadScene("Inferno desert");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus99 = 1;
        SceneManager.LoadScene("Inferno desert");
    }
}