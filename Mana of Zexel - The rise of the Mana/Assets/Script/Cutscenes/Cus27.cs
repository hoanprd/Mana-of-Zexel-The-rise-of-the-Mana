using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus27 : MonoBehaviour
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
            NameTagText.text = "Heerium";
            dia.text = "Hahaha! Welcome to Heerium's blacksmith shop!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Heerium";
            dia.text = "Feel at home and tour around, this place offers all kinds of weapons from melee to long-range.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Heerium";
            dia.text = "Not only that, equipment like armor is also available. Do you guys find it interesting?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Yes! Interesting too!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Heerium";
            dia.text = "The store doesn't look big, but that doesn't mean it's selling crap! The warriors who are and have visited this town are consulted and equipped with the best weapons to protect themselves against dangers such as monsters.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Heerium";
            dia.text = "Even the alchemist, I think you still need my weapon!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "... Uncle Heerium! If so, do you sell weapons to alchemy?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Heerium";
            dia.text = "As long as you ask for it, it's fine.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Heerium";
            dia.text = "Alchemist?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "So can you make a weapon for me? Like the iron shoes I wear are weapons!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Heerium";
            dia.text = "It's as easy as pie haha! What's up Vayne? If you want to reach the temple, you need powerful weapons!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "If so, can you make me a weapon that is a staff that can accumulate mana?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Heerium";
            dia.text = "I can do it, but to make your weapons it has to be a bit more special and durable than your old weapons.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "If so, what is the source of the materials you need?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Heerium";
            dia.text = "Simply put, I only need iron, but for your weapons and Maria, you need more mana gems from the golems.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "I get it! Then we'll go find the source of the ingredients!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Heerium";
            dia.text = "Ok! See you again hahaha!";
        }
        else if (tang >= 20)
        {
            CutscenesController.cus27 = 1;
            SceneManager.LoadScene("WeaponStore");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus27 = 1;
        SceneManager.LoadScene("WeaponStore");
    }
}