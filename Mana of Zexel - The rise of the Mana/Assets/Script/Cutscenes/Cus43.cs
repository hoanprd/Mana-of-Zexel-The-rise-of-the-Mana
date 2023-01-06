using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus43 : MonoBehaviour
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
            dia.text = "Orina! Is you at home?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "Where is she going again?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Heh? Ahhhh... There are ghosts!!!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Orina";
            dia.text = "Hey, it's me! Am I a ghost?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Calm down Alia. Hey Orina, why do you like snooping behind people's backs?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Orina";
            dia.text = "Snooping behind? That's right, what if I like standing here?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "In that case, your customer will run away!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Orina";
            dia.text = "I don't care, let's go collect some poisonous tails of scorpions in the inferno desert, then I'll show you how to open the Zexel portal.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "Go get some dangerous stuff for you again, Orina?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Orina";
            dia.text = "Do I want to help for free? In your dream! Anyway, Vayne said that if I want to collect anything, I can just ask Vayne to help me, right?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ehh... That is.. hehe.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "It seems troublesome.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey Orina, don't take advantage of people's kindness!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Orina";
            dia.text = "Taking advantage? Do you not want me to help you open the Zexel portal?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alright! We'll go get the scorpion venom tail, as long as you promise to help us.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Orina";
            dia.text = "That's right! Hurry up and go if you don't want to waste time.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Alia";
            dia.text = "It's true that the stingy woman is evil.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Orina";
            dia.text = "Heh? You want to fight, kid?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "All right, Alia! Let's go out of here.";
        }
        else if (tang >= 20)
        {
            CutscenesController.cus43 = 1;
            SceneManager.LoadScene("GroceryStore");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus43 = 1;
        SceneManager.LoadScene("GroceryStore");
    }
}