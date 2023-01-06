using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus44 : MonoBehaviour
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
            dia.text = "This should be enough for Orina's request.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "This job is dangerous. I wonder if she really helps us wholeheartedly?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "She's really evil making us do dangerous things.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Maybe Orina has her own reasons. Which is weird, what kind of grocery store sells poisons like this?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "Come to think of it, what is she planning to use this for? She's not an apothecary like anyone else in town buys this.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "Very suspicious indeed. Did she know anything about alchemy?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "I don't know but Orina is a real mystery.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "Let's hurry back before more monsters attack us!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "(Usually poison for making potions, if she knows alchemy but isn't an alchemist, that's odd...)";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "(Never mind, this doesn't affect me much)";
        }
        else if (tang >= 11)
        {
            CutscenesController.cus44 = 1;
            SceneManager.LoadScene("Inferno desert");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus44 = 1;
        SceneManager.LoadScene("Inferno desert");
    }
}