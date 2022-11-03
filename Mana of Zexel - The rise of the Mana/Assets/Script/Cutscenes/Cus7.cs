using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus7 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Mr. Lance, we've taken the goblins down.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I don't know how to thank you both enough. You two did a great job! I will reward you two with 100 Zen.";
        }
        else if (tang == 3)
        {
            NameTag.SetActive(false);
            dia.text = "Get 100 Zen!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Anyway, did you find out my father's information Mr. Lance?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I'm sorry, but I still haven't found the book containing your father's information.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "But I think that book might be at my old house, where my daughter is now.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "You mean Maria's current residence?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "My old house is deep in the wishing forest. Maria was also there to study alchemy.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "What a hardworking person like her.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Of course Vayne! She's very good, compared to her, you're just a chicken!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "Alia: Just kidding, anyway I want to see Maria again, it's been a while since I've seen her.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Be careful you two! That forest is very dangerous!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'll consider your advice, then let's go, Alia!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alia";
            dia.text = "Ok!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Those two are so passionate, hehe. Good luck both.";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus7 = 1;
            Global.Zen += 100;
            SceneManager.LoadScene(5);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus7 = 1;
        if (tang >=17)
            SceneManager.LoadScene(5);
        else
        {
            Global.Zen += 100;
            SceneManager.LoadScene(5);
        }
    }
}
