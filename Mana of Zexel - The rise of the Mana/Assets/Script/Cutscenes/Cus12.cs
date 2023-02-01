using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus12 : MonoBehaviour
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
            dia.text = "Hey Maria! We've already obtained some mana gem!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "Oh wait a minute. Ah finally see, surely the book information 1 year ago is in this.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Did you find it?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Maybe so! Your father's full name is Dante Dias, right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Oh! That's right! Do you have specific information?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Actually... Only Mr. Lance knows";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Why only Mr. Lance knows?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "Simply no one can read my father's handwriting... not even me";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Heh? Are you kidding me? Never mind, we just have to go back to Mr. Lance";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "Sorry for bothering you guys just now!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "It's okay, Maria! If you don't mind, we can take the notebook to Mr. Lance";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "Uhm, then here's the notebook, keep it safe";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "By the way, if you two don't mind, can I come with you?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's OK! I'd love to, but do you have a job in town?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "It's really nothing, I just saw you two having an interesting adventure so I wanted to go along";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Just that? Looks like you also like to explore";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "Of course, I'm an alchemist anyway, so it's only natural to go exploring in search of ingredients";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "I got it! If so, please help me with my alchemy experience";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "Nice to work with you guys";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus12 = 1;
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
        CutscenesController.cus12 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}