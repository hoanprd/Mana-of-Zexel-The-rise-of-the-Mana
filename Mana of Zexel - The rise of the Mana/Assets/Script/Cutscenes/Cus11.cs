using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus11 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaDAR1, MariaDAL1;
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
            dia.text = "Look, Alia! There is a house in the middle of this secluded forest.";
        }
        else if (tang == 2)
        {
            AliaDAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Do you think that is the old house of Mr. Lance?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's possible.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Knock knock, is anyone at home?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hey wait Alia! Don't randomly knock on people's doors like that!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Relax Vayne, Maria is not angry about this.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "How are you sure this house belongs to Maria!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "???";
            dia.text = "Hey, what are you two doing in front of my house? Oh, is that Alia?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "Sister Maria! Long time no see!";
        }
        else if (tang == 10)
        {
            VayneVAL1.SetActive(false);
            MariaDAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Alright, let's talk in the house. In addition to this should not be outside for too long.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "Is this guy your boyfriend, Alia?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "No, it's not... This is...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "Okay, just kidding! No need to stress. Now let's get to the main story.";
        }
        else if (tang == 14)
        {
            AliaDAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hi Maria, my name is Vayne, an alchemist from Zorth. I need you to check the books of someone who has been to Mr. Lance 1 year ago.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "Is that person important to you?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes! That's my father, he stopped contacting my mother and me for more than a year.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "I have come here to find information about my father, please help. Book of Mr. Lance 1 year ago were recorded and stored in this house.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "Oh I get it, okay! I'll rummage through those books for you, but on one condition.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "Conditions?";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "I'm very busy, while I'm going through the books, will you get me some mana gems?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, but where can you find those here?";
        }    
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "The golems in this forest had a fair amount of mana. So if you cut them down, there will be a lot of mana gems.";
        }
        else if (tang == 23)
        {
            VayneVAR1.SetActive(false);
            AliaDAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Then it's fine for the two of us to just kill those golems.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Maria";
            dia.text = "They can be found in the southern part of this forest, be careful, they are very strong!";
        }
        else if (tang >= 25)
        {
            CutscenesController.cus11 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Wishing forest");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus11 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}
