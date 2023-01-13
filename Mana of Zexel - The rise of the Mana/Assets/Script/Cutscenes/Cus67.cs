using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus67 : MonoBehaviour
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
            NameTagText.text = "Shan";
            dia.text = "Chief Alasa, the three of them have killed all the wolves at your request!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alasa";
            dia.text = "Is that so! The three of you are good too! However, that is just the start.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "So what do we do next?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alasa";
            dia.text = "Your next mission is to enter the ice cave in the south of this village, which contains frozen crystals, it seems you are an alchemist right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alasa";
            dia.text = "If so, you can use mana to prevent the crystal from freezing.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alasa";
            dia.text = "After you find the ice crystals, bring them back here. I will help you get the fire core without damage to the village in the inferno volcano.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really! If so, we will try our best.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alasa";
            dia.text = "Shan! Please you to follow them.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Shan";
            dia.text = "I got it!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "Looks like this village chief likes to put us in danger.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "May he have no ill will towards us.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Shan";
            dia.text = "Hey, you two, stop talking bad about the village chief and finish the quest first.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "There's no need to be grumpy Shan, we're just wondering.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Are you a resident of inferno ice? Because I see you wearing the same outfit as the village chief Alasa.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Shan";
            dia.text = "That's right, I'm from this inferno ice village, don't talk too much and focus on entering the ice cave.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Okay.";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus67 = 1;
            SceneManager.LoadScene("Inferno ice");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus67 = 1;
        SceneManager.LoadScene("Inferno ice");
    }
}