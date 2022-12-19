using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus19 : MonoBehaviour
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
            dia.text = "Okay Klener! I brought the items you requested!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Klener";
            dia.text = "Thank you, you're really fast. I will definitely repay this favor.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's okay, I don't mind about gratitude, as long as it helps people.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Klener";
            dia.text = "You're really kind, since coming to town you've helped a lot of people.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well, I said as long as everyone's happy it's fine.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Klener";
            dia.text = "Okay then I don't want to bother you anymore.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Wait Klener! Are you planning to use these items to fight?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Klener";
            dia.text = "That's right!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Do you have an urgent mission? Needing a mana barrier, are you planning to fight golems?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Klener";
            dia.text = "Actually, I want to push the golems near the town and it's not a quest but I decide for myself.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "You should have said this sooner! Let me join you!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Klener";
            dia.text = "But what about your investigation?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "I told you, as long as I help others I'm happy enough, my father must be proud of me for that too.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Klener";
            dia.text = "You're really nice! Thank you so much Vayne!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Shall we start at the wishing forest first?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Klener";
            dia.text = "Okay! The two of us will protect the people of this town!";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus19 = 1;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus19 = 1;
        SceneManager.LoadScene("Tavern");
    }
}