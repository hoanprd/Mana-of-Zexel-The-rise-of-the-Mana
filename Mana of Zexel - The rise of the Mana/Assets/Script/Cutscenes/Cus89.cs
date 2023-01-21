using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus89 : MonoBehaviour
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
            dia.text = "Uhhhh....";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Wait a minute, I'll create a cure.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "Come on Alia...";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "What happened?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "Alia dealt the fatal blow of the magician who had followed Vayne's father.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Let's see...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "... It's not good, I've never seen such a serious injury.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia, hurry and drink!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Uhm...";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "Ahhh...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's not okay, the wound is still spreading... why is that!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "This is a corrosive attack on the body, only magic can remove it from the body.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "No way, mana doesn't work either?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alia";
            dia.text = "Vayne...";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'm sorry... I was so angry... Damn, there must be a way!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Orina";
            dia.text = "... This dark magic, must be that Zane guy.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "Orina? What is she doing here?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Orina";
            dia.text = "I saw you guys rushing back to town, so I stopped by to check it out. It seems that Alia's situation is not good at all.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "Damn... it's my fault...";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Orina";
            dia.text = "Hey Vayne! Instead of sitting here whining, go to the southwest of the inferno desert. There is a magic healer in that small village.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really?";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Orina";
            dia.text = "She's tough! Try to convince him to come here.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, I'll go to that doctor! Alia, wait for me!";
        }
        else if (tang >= 25)
        {
            CutscenesController.cus89 = 1;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus89 = 1;
        SceneManager.LoadScene("Tavern");
    }
}