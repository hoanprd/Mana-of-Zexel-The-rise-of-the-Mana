using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus106 : MonoBehaviour
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
            dia.text = "That monster, you've already lost, don't ever destroy other people's villages, okay?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Inferno beast";
            dia.text = "grhhh...";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "It's gone.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Looks like that thing knows what's out of the question. Maybe it's just resentful that it's been sealed here for so long.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Asila";
            dia.text = "I thank you guys, once again you saved my brothers and sisters.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alasa";
            dia.text = "I really don't know how to repay you guys?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "We don't need to repay the favor, what we do is voluntary.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alasa";
            dia.text = "Don't be a guest, I will give you this money first as the sincerity of the two of us. Please accept it.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Hehe... it's a waste not to accept it.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "";
            dia.text = "Zen +1000";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Shan";
            dia.text = "You guys are much stronger than before. Unbelievable.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "We are ready to raise our strength to fight the magician Zane.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Shan";
            dia.text = "Have you met him already?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, it was difficult to fight him at first but now we will defeat him and stop evil plots.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Shan";
            dia.text = "Good luck to you guys.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm, nothing more we're going back to Zexel town..";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Shan";
            dia.text = "Goodbye!";
        }
        else if (tang >= 18)
        {
            CutscenesController.cus106 = 1;
            SceneManager.LoadScene("Alta inferno");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus106 = 1;
        SceneManager.LoadScene("Alta inferno");
    }
}