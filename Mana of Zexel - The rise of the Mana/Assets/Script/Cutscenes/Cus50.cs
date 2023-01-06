using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus50 : MonoBehaviour
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
            dia.text = "This is... the land of mana?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "This place is full of mana, I feel it very well.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Everything around is strange, like we are in the fairy forest.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "But I still feel something is not right about the color of this land.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "You mean everything around has to be green right?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, the mana nature will bring life to the surroundings but this place is like a dead land, the ground is purple.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's like there's no life in this place.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "What... what are those?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "... That's...";
        }
        else if (tang == 10)
        {
            NameTagText.text = "???";
            dia.text = "Ergggggg";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's a slime.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "Slime? This is the first time I've encountered them, I've only seen them in books until now.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Usually they gather in places with mana like this, because their bodies need mana to sustain life.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "So should we fight?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "No need, they won't hurt us if we don't touch them.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey... Hey don't come near me... you look slimy, disgusting!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Let's just dodge them and move on.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "(Looks like Orina isn't joking around with this.)";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus50 = 1;
            SceneManager.LoadScene("Mana gate");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus50 = 1;
        SceneManager.LoadScene("Mana gate");
    }
}