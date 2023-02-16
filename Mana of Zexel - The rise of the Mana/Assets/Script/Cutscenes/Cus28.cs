using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus28 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, HeeriumVAR1;
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
            dia.text = "Uncle Heerium! We're back with the ingredients you need!";
        }
        else if (tang == 2)
        {
            HeeriumVAR1.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "Very timely with this abundant source of iron, the weapon will be very good hahaha!";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Damn it! Remember to make a super powerful weapon for me!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Heerium";
            dia.text = "Don't worry, just trust me hahaha! But it will take time to complete them, you can come back later!";
        }
        else if (tang == 5)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Thank you! By the way, does Uncle Heerium know about Zexel temple?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Heerium";
            dia.text = "Oh, that temple, I don't know. He met many adventurers and soldiers who were his customers who went to the temple but no one returned.";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Is that scary? Don't tell me that temple has not only monsters but also ghosts?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Heerium";
            dia.text = "I don't know but I remember there was a survivor many times when he went to that temple, remember that person looked a bit like Vayne but older.";
        }
        else if (tang == 9)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "??? Could it be that that person is my father!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Heerium";
            dia.text = "Vayne's father? Most likely, it's been over a year and I still haven't seen him, usually he loves your weapon service! Not only that, but he's also with someone who looks like a magician!";
        }
        else if (tang == 11)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Magician? Almost no mages have appeared since the war mages era.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Heerium";
            dia.text = "I just thought so!";
        }
        else if (tang == 13)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I've never met a magician either!";
        }
        else if (tang == 14)
        {
            HeeriumVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What is a magician?";
        }
        else if (tang == 15)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "I just understood that they are quite similar to alchemists but they don't make tools from mana like alchemists, they use mana to fight is chanting magic.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "Like magic? Alchemy can't do magic?";
        }
        else if (tang == 17)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "There's only a small amount of magic, so my mom used to say that magicians and alchemists don't have a difference.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well, we should go back to prepare our luggage through the desert, then Heerium will finish making weapons for us!";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus28 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("WeaponStore");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus28 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("WeaponStore");
    }
}