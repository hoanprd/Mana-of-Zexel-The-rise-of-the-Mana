using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus92 : MonoBehaviour
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
            dia.text = "Mrs. Meru! We have already brought enough ingredients!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Meru";
            dia.text = "It's good, she's just passed the dangerous stage but this still can't stop the poison from spreading.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "Is Alia still in a coma? Is this situation really okay?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Meru";
            dia.text = "I warn you that if you want to save Alia, you will need dragon mana scales to push out the amount of dark magic clinging to her body.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "But where can you get mana dragon scales?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Meru";
            dia.text = "This is... I don't know. They are almost extinc";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Do we have no other choice?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Meru";
            dia.text = "I'm afraid so, what I did with these ingredients was just to stop the wound's spread from slowing down.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Meru";
            dia.text = "If I want to save Alia, I think I have to find the mana dragon scales.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Maria, let's go ask Orina, I think she'll know what to do.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "Oh, that's fine.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "Uhhh...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia try harder, I still owe you this life...";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus92 = 1;
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
        CutscenesController.cus92 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}