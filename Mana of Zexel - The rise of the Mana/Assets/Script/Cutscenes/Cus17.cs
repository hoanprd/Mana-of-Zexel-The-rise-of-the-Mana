using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus17 : MonoBehaviour
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
            dia.text = "Is everyone back? What's going on, why are you in such a hurry?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Klener";
            dia.text = "Sir! Vayne's party had just stopped the iron golemn from entering the wishing forest.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "What? An iron golemn!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "You don't have to worry, we're almost done with it.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Oh, it's Maria, I miss you so much, you don't visit town very often these days, don't you?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "I've only been away from you for a month.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Come on, a month is long enough, what do you guys want to eat so that Mr. Lance here treats you to a hearty meal.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Mr. Lance, if you don't mind can you help me read the information you wrote about my father?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Oh, so you found that notebook? Alright let's take a look.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'm counting on you.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "By the way, Maria! Can't you read?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "... Father! Don't ask like that in front of everyone...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "How come I'm old, my eyes are much worse than before!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Klener";
            dia.text = "...";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "It's okay, it's okay, I can still read it like that! Haha.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "(My God, it seems Mr. Lance knows that people can't read his handwriting)";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Oh I remember, it's Dante Dias, an adventurer who used to do many quests of this tavern to earn some money and get information to the temple of Zexel.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "Temple of Zexel?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Vayne";
            dia.text = "Where is that place?";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Looks like you're new so you haven't heard of Zexel's origins.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "Zexel? What is that?";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Zexel is the name of an alchemist who lived in this town a hundred years ago. She is a very great person for stopping a monster that wants to destroy everything.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "That's why everyone built a temple and renamed this town Zexel.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is that so! A powerful alchemist a hundred years ago.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Maria";
            dia.text = "That sounds surprising, right Vayne? I wish I could meet her too!";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Alia";
            dia.text = "Looks like I haven't been to that place yet.";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Alia";
            dia.text = "If Vayne wanted to go there, there would be a lot of interesting things, right?";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Vayne";
            dia.text = "Mr. Lance do you have any information about that temple?";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "What we do know is that the temple is far from town and north of the inferno desert.";
        }
        else if (tang == 33)
        {
            NameTagText.text = "Vayne";
            dia.text = "So it's hard to get there?";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Not only is the road dangerous, but there are a lot of monsters there. That's why people in the town don't go to that temple now, so they don't know anything about the temple.";
        }
        else if (tang == 35)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's strange why people at that time built their thrones in such a dangerous place?";
        }
        else if (tang == 36)
        {
            NameTagText.text = "Maria";
            dia.text = "I heard about that desert land that was once inhabited by a tribe, for some reason that tribe lost its habitat and suffered a sandstorm that buried the entire civilization in it. sand.";
        }
        else if (tang == 37)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay anyway I didn't come here empty-handed, I'll definitely cross the desert and head to the Zexel temple.";
        }
        else if (tang == 38)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "If that's the case, you need to be mentally prepared. You can ask the merchants around town to get more information.";
        }
        else if (tang == 39)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thanks Mr. Lance! Alright everyone, let's spread out and gather information!";
        }
        else if (tang >= 40)
        {
            CutscenesController.cus17 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus17 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}