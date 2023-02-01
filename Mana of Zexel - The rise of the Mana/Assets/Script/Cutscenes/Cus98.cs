using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus98 : MonoBehaviour
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
            NameTagText.text = "Alia";
            dia.text = "Vayne! Look at me, healthy like nothing ever happened hihi.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alia";
            dia.text = "Alia! Are you awake! It's lucky... I'm so worried.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "I'm worried too, are you sure you're okay?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Of course...";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Meru";
            dia.text = "Of course it's not completely fine. Don't get too cocky little girl, you may be in good shape but it still takes time to fully recover.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Hehe...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia I'm sorry for everything...";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "It's okay I get it... if that's the case with me, I'll act like you.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "I promise I won't make the same mistake again.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "It's been a long wait, hasn't it? The food has arrived.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "Invite everyone to a meal.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "All";
            dia.text = "Have a good meal everyone";
        }
        else if (tang >= 13)
        {
            CutscenesController.cus98 = 1;
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
        CutscenesController.cus98 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}