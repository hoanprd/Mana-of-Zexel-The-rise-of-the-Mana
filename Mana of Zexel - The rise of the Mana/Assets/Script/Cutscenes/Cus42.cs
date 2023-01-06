using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus42 : MonoBehaviour
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
            NameTagText.text = "Mr. Lance";
            dia.text = "Oh everyone! Haven't they all found the gate of Zexel yet? Looking so tired and sad!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alia";
            dia.text = "We found it, but we can't open the gate because we're not worthy.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "At that time, we received a message to open the gate without understanding anything.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "A message? So what is that message?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hum... It seems to be to be worthy if and only if one can break the two polar opposites and bring back peace.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Hum... I don't get it either haha!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Honestly, you always laugh at other people's pain.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I don't really get it, come to think of it, it feels like the message sent me to do something related to conflict resolution.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Reminds me of your father and his friend.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "My father's friend? When my father left, he was alone. No wonder he made friends on the way here.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "It seems so, I clearly remember he had a man with long hair who always accompanied your father on quests when he came to this village. It seems they both have the same purpose as the temple of Zexel.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "At that time, those two were always arguing, neither of them would give in.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hey Mr. Lance, do you have any information on that man?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I'm afraid no, that guy didn't give any specific information, only your father did. But remember that guy's name is Zane right.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Orina";
            dia.text = "Interesting isn't it? Did you guys find the Zexel portal?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "Yes, we found the gate but...";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Orina";
            dia.text = "But can't open it?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "... That's right. But wait, Orina, what are you doing here?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Orina";
            dia.text = "Well, I came here to give some food to Mr. Here's Lance.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Excuse me, Orina, you can just leave it on the table for now.";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Orina";
            dia.text = "Vayne! Want to know how to open the gate? Come over to my place, I can help.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really? If so, thank you in advance!";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Orina";
            dia.text = "Uhm! See you again.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Alia";
            dia.text = "I have a bad feeling about this.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Maria";
            dia.text = "Me too! How does she know how to open the gate when she's never been there?";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Vayne";
            dia.text = "Even so, as long as the gate is open, the problem is solved, let's go to Orina's place!";
        }
        else if (tang >= 27)
        {
            CutscenesController.cus42 = 1;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus42 = 1;
        SceneManager.LoadScene("Tavern");
    }
}