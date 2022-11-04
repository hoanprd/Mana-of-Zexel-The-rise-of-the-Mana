using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus8 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject NameTag;
    private int tang=0;
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
            NameTagText.text = "Villager (Man) 1";
            dia.text = "Oh my god! The goblins have ruined my fields!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Villager (Man) 2";
            dia.text = "Me too, unbelievable!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "If this takes a year to get the crop back.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Villager (Man) 1";
            dia.text = "But how will we live until the end of this year?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "... The villagers look very sad. I have never seen such a tragic scene.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey Vayne! Is there any way you can help them?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "You mean using alchemy to help them?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right! You just need to stir the cauldron to create something that revives the fields.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Back then, I only made things that aid in combat.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "So try changing it? I believe you can do it!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alright! Let me think, if a combination of heal potion and mana potion can do something!";
        }
        else if (tang == 12)
        {
            dia.text = "Alia: Even though I don't understand anything about alchemy, it's fine just to try, right?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Maybe. I'll try my best to help this town.";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus8 = 1;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus8 = 1;
        SceneManager.LoadScene("Zexel town");
    }
}
