using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus3 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaDAR1;
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
            AliaDAR1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "We have arrived at Zexel town!";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Thank you, Alia. Amazingly, this town is so bustling, the children look so happy.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Of course, I really like this town.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "So your hometown is here?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "...Well, it's not.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "So you come for a far place like me too?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Actually, I have amnesia and have been traveling in this town for over a year. I only remember my name.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "... That so sad.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "It's okay, I'm still happy to be here.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "But what did you come here for?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well, I'm here to find my dad. He is an adventurer and came here 1 year ago but he has not returned or sent any reply.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "So you came here to find his whereabouts?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes. Now I don't know where to get this information from.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "I know a good place to look for information. Go to the tavern where adventurers go.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's a good idea, I'll ask you to take me there.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "Ok, no problem, the tavern is on the west side of town.";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus3 = 1;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus3 = 1;
        SceneManager.LoadScene("Zexel town");
    }
}
