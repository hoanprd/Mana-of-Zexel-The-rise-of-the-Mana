using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus11 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    public GameObject va2;
    public GameObject va3;
    private int tang = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
            dia.text = "Vayne: Look, Alia! There is a house in the middle of this secluded forest.";
        else if (tang == 2)
            dia.text = "Alia: Do you think that is the old house of Mr. Lance?";
        else if (tang == 3)
            dia.text = "Vayne: It's possible.";
        else if (tang == 4)
            dia.text = "Alia: Knock knock, is anyone at home?";
        else if (tang == 5)
            dia.text = "Vayne: Hey wait Alia! Don't randomly knock on people's doors like that!";
        else if (tang == 6)
            dia.text = "Alia: Relax Vayne, Maria is not angry about this.";
        else if (tang == 7)
            dia.text = "Vayne: How are you sure this house belongs to Maria!";
        else if (tang == 8)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            dia.text = "???: Hey, what are you two doing in front of my house? Oh, is that Alia?";
        }
        else if (tang == 9)
            dia.text = "Alia: Sister Maria! Long time no see!";
        else if (tang == 10)
            dia.text = "Maria: Alright, let's talk in the house. In addition to this should not be outside for too long.";
        else if (tang == 11)
        {
            va2.SetActive(false);
            va3.SetActive(true);
            dia.text = "Maria: Is this guy your boyfriend, Alia?";
        }
        else if (tang == 12)
            dia.text = "Alia: No, it's not... This is...";
        else if (tang == 13)
            dia.text = "Maria: Okay, just kidding! No need to stress. Now let's get to the main story.";
        else if (tang == 14)
            dia.text = "Vayne: Hi Maria, my name is Vayne, an alchemist from Zorth. I need you to check the books of someone who has been to Mr. Lance 1 year ago.";
        else if (tang == 15)
            dia.text = "Maria: Is that person important to you?";
        else if (tang == 16)
            dia.text = "Vayne: Yes! That's my father, he stopped contacting my mother and me for more than a year.";
        else if (tang == 17)
            dia.text = "Vayne: I have come here to find information about my father, please help. Book of Mr. Lance 1 year ago were recorded and stored in this house.";
        else if (tang == 18)
            dia.text = "Maria: Oh I get it, okay! I'll rummage through those books for you, but on one condition.";
        else if (tang == 19)
            dia.text = "Vayne: Conditions?";
        else if (tang == 20)
            dia.text = "Maria: I'm very busy, while I'm going through the books, will you get me some mana gems?";
        else if (tang == 21)
            dia.text = "Vayne: Okay, but where can you find those here?";
        else if (tang == 22)
            dia.text = "Maria: The golems in this forest had a fair amount of mana. So if you cut them down, there will be a lot of mana gems.";
        else if (tang == 23)
            dia.text = "Alia: Then it's fine for the two of us to just kill those golems.";
        else if (tang == 24)
            dia.text = "Maria: They can be found in the southern part of this forest, be careful, they are very strong!";
        else if (tang >= 25)
        {
            CutscenesController.cus11 = 1;
            SceneManager.LoadScene(4);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus11 = 1;
        SceneManager.LoadScene(4);
    }
}
