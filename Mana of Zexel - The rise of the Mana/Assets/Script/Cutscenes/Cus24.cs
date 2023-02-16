using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus24 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Phew! It's tiring to admit.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Since I came to this town, many things have surprised me!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "I seem to understand why my father likes to go to so many places, I also find it interesting.";
        }
        else if (tang == 4)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Hey Vayne!...";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Heh? Sister Maria? Why don't you knock on the door?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "This was originally your room, right?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Even so... what if I have my own business?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "Stop stressing, I just came to ask.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'm fine but there's nothing to worry about!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "Well then, you're an alchemist, aren't you? Don't you know that I can make something destructive to use as a weapon?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "You mean my staff weapon?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "More precisely, throwing weapons like bombs?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well, back then, I mainly made pharmaceuticals, but I didn't throw weapons like bombs!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "Is that so! If so, you'll need to know.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "But to make a bomb requires hard to find materials...";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "Last time you went to collect some mana gems from the golems, right?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, can they make bombs?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right! Materials that contain mana can all make bombs if you increase your mana, it will be very strong.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "The recipe is very simple, just put the amount of mana into the mana gem and compress them under the iron sphere.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "So that's it! I'll try it out.";
        }
        else if (tang >= 21)
        {
            CutscenesController.cus24 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Save room");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus24 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Save room");
    }
}