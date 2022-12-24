using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus21 : MonoBehaviour
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
            dia.text = "We're back at the pub! Are you all right, Klener?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Klener";
            dia.text = "Uhm! I'm fine!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is that true?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Klener";
            dia.text = "Really! It's ridiculous for a bodyguard to be seriously injured by a punch.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, I'm just a little nervous.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Klener";
            dia.text = "It's okay, but I admit you're strong. Are all alchemists that strong?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Not really. Usually alchemists were only equipped with basic combat knowledge and used tools to fight.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Klener";
            dia.text = "That's it. I can see not only using the tool but you have a strange power emanating from the staff.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well that's called mana, usually alchemists must possess a hidden power called mana.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Mana is not available to everyone, but it is extremely difficult to develop through practice, it is not only used in crafting but also in combat as a source of strength.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Klener";
            dia.text = "... I don't quite understand it either, but can mana be used as fighting power? Interesting!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Have you heard of mana before?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Klener";
            dia.text = "Yes, but actually, I just heard it from my grandfather.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "It seems this town used to have many alchemists, right?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Klener";
            dia.text = "I don't know either... A lot of people say Zexel was the only one a hundred years ago is the time my grandfather was still alive.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Klener";
            dia.text = "But my grandfather passed it on to my father and me that there are still other alchemists.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "An unnamed alchemist? Why is that?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Klener";
            dia.text = "Anyway, that's just the story being told, what matters is the present.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! By the way, if you don't mind I want to make you a new shield, okay?";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Klener";
            dia.text = "No need! I owe you a lot too!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Vayne";
            dia.text = "No debt at all! I just wanted to make a special gift. After all, a bodyguard who doesn't have a shield to protect himself, how can he protect others?";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Klener";
            dia.text = "To make a shield, it takes materials and effort, whether it's good or not is the problem.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "If I use alchemy everything will be quick! My cane is also made from alchemy easily so a shield would be easy.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Klener";
            dia.text = "If so, thanks a lot Vayne!";
        }
        else if (tang >= 25)
        {
            CutscenesController.cus21 = 1;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus21 = 1;
        SceneManager.LoadScene("Tavern");
    }
}