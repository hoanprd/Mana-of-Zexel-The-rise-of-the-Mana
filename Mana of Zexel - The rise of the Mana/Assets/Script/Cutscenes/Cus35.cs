using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus35 : MonoBehaviour
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
            dia.text = "Damn hot!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "You're the coolest, Alia! When I only carry armor on your body instead of a coat like you.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Come on, don't lie to me like that!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "The desert here is like hell fire! Looks like this inferno makes this desert so hot!!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "We just need to go north and follow the cliffs and we won't get lost!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "???";
            dia.text = "Ahhhhhhhhhhhhhhhh... Someone please save me!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Whose cry for help is that?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Over there!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "A girl! The scorpion monsters are trying to eat that girl!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "???";
            dia.text = "Someone save me!!!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hyaaaaaa! Girl, step back and let me handle this!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "???";
            dia.text = "Yes!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alia";
            dia.text = "Dare to bully people in this desert? I will not forgive!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "Be careful! These monsters are not like the monsters we met before!";
        }
        else if (tang >= 15)
        {
            CutscenesController.cus35 = 1;
            ContainerController.LoadingOpen = true;
            HPMPBarController.EIndex = 4;
            SceneManager.LoadScene("BSInfernoScorpion 1");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus35 = 1;
        ContainerController.LoadingOpen = true;
        HPMPBarController.EIndex = 4;
        SceneManager.LoadScene("BSInfernoScorpion 1");
    }
}