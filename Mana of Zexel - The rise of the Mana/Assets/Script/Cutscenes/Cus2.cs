using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus2 : MonoBehaviour
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
            NameTagText.text = "Thief";
            dia.text = "You're stronger than I thought, kid.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't look down on a alchemist like me.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Thief";
            dia.text = "Alchemist? Like I'm sacred? My comrades help me!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "!!!";
        }
        else if (tang == 5)
        {
            va1.SetActive(false);
            NameTagText.text = "???";
            dia.text = "I don't think so. Hya! ";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Thief";
            dia.text = "Oh no, that brat again. Retreat!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "What?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "???";
            dia.text = "That's right, run and find another job to do.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm... Thanks for helping me there.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "???";
            dia.text = "You welcome! By the way who are you?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Oh! My name is Vayne. I'm a alchemist from the southwest of the land of Zorth.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "Nice to meet you Vayne! I'm Alia.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Why is a girl like you in such a dangerous desolate place.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "... Well, I like to travel around Zexel town as well as help people like you.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Did you just say Zexel town? Do you know which direction I need to go?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "Yeah it's on the west side of this hill.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ok! Thanks very much.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey! Can I go with you? I can help you the way there.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yeah, sure! It's my pleaser.";
        }
        else if (tang == 20)
        {
            NameTag.SetActive(false);
            dia.text = "Alia join the team.";
        }
        else if (tang >= 21)
        {
            CutscenesController.cus2 = 1;
            SceneManager.LoadScene("Wishing hill");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus2 = 1;
        SceneManager.LoadScene("Wishing hill");
    }
}
