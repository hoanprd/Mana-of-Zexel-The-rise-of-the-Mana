using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus6 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject va2;
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
            NameTagText.text = "Vayne";
            dia.text = "Mr. Lance I've already made the healing potion.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Amazing, you're faster than I thought.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Why do you want to use the healing potion for?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "These days, goblins regularly wreak havoc on the south side of town. The town guards often fight but the medical supplies are not enough for them, so I take the opportunity to ask for your help.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "It sounds like there are dangerous places around the village, right?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Yes. Those who don't have combat skills are vulnerable to outside monsters, so be careful when you're out of town.";
        }
        else if (tang == 7)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "Klener";
            dia.text = "Emergency! Sir Lance, the goblins had gathered in a swarm southwest of town. We need urgent help!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "... It's difficult. We really lack resources.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "So let me. I can handle the goblins.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey let me join you, Vayne!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I really appreciate you both, thank you and good luck out there.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "Okay let's go Vayne!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hey, don't be like that, Alia! Wait for me!";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus6 = 1;
            SceneManager.LoadScene(5);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus6 = 1;
        SceneManager.LoadScene(5);
    }
}
