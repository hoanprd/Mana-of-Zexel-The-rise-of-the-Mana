using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus110 : MonoBehaviour
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
            NameTagText.text = "Mana elf";
            dia.text = "Thanks everyone for coming, maybe we don't have much time left.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Looks like this has something to do with the magician Zane.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Mana elf";
            dia.text = "That's right, he's trying to break the seal of Sicxalon. If Sicxalon was released, once again everyone and humans and mana would be in danger.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Then we'll go to the temple and give him a lesson.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Mana light";
            dia.text = "Wait young lady, we called you come to give this.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mana elf";
            dia.text = "This is the key to unlock the secret that you all need to know is that girl Alia.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Mana elf";
            dia.text = "This is also Zexel's last wish to wish everyone good luck.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "Are you gods already know the end result of this war?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Mana rock";
            dia.text = "Looks like it is, but we won't tell you in advance though.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "... So all of this is well known to you?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Mana elf";
            dia.text = "We have our own reasons for doing that. Please forgive us.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's just us and Zexel who are chosen to protect this peace?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Mana elf";
            dia.text = "Not really, before Zexel's generation there was another chosen one. However, that time has not yet come.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "You mean someone else got here before Zexel.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Klener";
            dia.text = "That's right, that person was the first mortal to come into contact with the gods, the first alchemist of this world.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "The world's first alchem�t is nothing more than a myth. Does that person really exist?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Mana elf";
            dia.text = "History is only partially true, the rest only people of that era know the truth. However, your immediate task is to prevent Zane from resurrecting Sicxalon.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "We got it.";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus110 = 1;
            SceneManager.LoadScene("Mana temple");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus110 = 1;
        SceneManager.LoadScene("Mana temple");
    }
}