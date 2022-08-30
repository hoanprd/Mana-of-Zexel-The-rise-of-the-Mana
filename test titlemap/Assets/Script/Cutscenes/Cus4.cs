using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus4 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    private int tang=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
            dia.text = "Alia: Hey Mr. Lance, I'm back.";
        else if (tang == 2)
            dia.text = "Mr. Lance: Oh, it's Alia, what a fun day today.";
        else if (tang == 3)
            dia.text = "Alia: Today I rescued a person from bandits.";
        else if (tang == 4)
            dia.text = "Mr. Lance: Well done! So, is that the guy you're with with you?";
        else if (tang == 5)
            dia.text = "Alia: That's right! He also has combat skills.";
        else if (tang == 6)
            dia.text = "Vayne: Hello! My name is Vayne, and I am an alchemist from Zorth.";
        else if (tang == 7)
            dia.text = "Vayne: I came here to find my father who has been away from home for over a year. My father said he would stop by the town of Zexel.";
        else if (tang == 8)
            dia.text = "Mr.Lance: Is your father an adventurer too?";
        else if (tang == 9)
            dia.text = "Vayne: That's right, I hope you can remember my dad's been here before. His name is Dante, about 40 years old, wearing an adventure suit with a brown brimmed hat.";
        else if (tang == 10)
            dia.text = "Mr. Lance: Okay let me check my lottery, the adventurers who come here often go on quests to earn extra income. Maybe your father is too.";
        else if (tang == 11)
            dia.text = "Vayne: Thank you Mr. Lance!";
        else if (tang == 12)
            dia.text = "Mr. Lance: In the meantime can you do a little quest for me?";
        else if (tang == 13)
            dia.text = "Vayne: What kind a quest?";
        else if (tang == 14)
            dia.text = "Mr. Lance: You said you were an alchemist right?";
        else if (tang == 15)
            dia.text = "Vayne: That right!";
        else if (tang == 16)
            dia.text = "Mr. Lance: I need you to synthesize a heal potion, is that okay?";
        else if (tang == 17)
            dia.text = "Vayne: Yes, I accept. But I need a cauldron to synthesize.";
        else if (tang == 18)
            dia.text = "Mr. Lance: Don't worry, Alia, take this boy to your room, there's a big cauldron there.";
        else if (tang == 19)
            dia.text = "Alia: Yeah, okay Vayne, my room's on the right front door.";
        else if (tang >= 20)
        {
            PlayerPrefs.SetInt("cus4", 1);
            SceneManager.LoadScene(5);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        PlayerPrefs.SetInt("cus4", 1);
        SceneManager.LoadScene(5);
    }
}
