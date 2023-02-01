using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus90 : MonoBehaviour
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
            dia.text = "Damn where is that doctor? I searched and couldn't find it.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "Try asking the villagers around?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Hey, what little girl? Let me ask you...";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Jesca";
            dia.text = "Huh? Was it Vayne and Maria?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "So it's you, Jesca? You still good there.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Jesca";
            dia.text = "Are you okay? What about brothers and sisters? And where is Alia, isn't she going with you two?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Sister Alia is seriously injured by dark magic, I'm looking for a magic healer somewhere in this village. Do you know that person?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Jesca";
            dia.text = "The doctor? In this village there is only one doctor and that is my grandmother!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "In that case, can you take me to your grandmother's place?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Jesca";
            dia.text = "Of course! Follow me!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "???";
            dia.text = "Oh, so this is the group that rescued your grandson from those inferno scorpions? That is a pleasure.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Jesca";
            dia.text = "Everyone, this is Meru, she is my grandmother, the only and talented doctor in this village!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ma'am, can you follow me back to Zexel town and help me heal my friend who got hit by a magician's attack?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Jesca";
            dia.text = "Magician? Looks serious. All right, I'm grateful to you anyway, so I'll treat your friend. However, in terms of cost...";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Jesca";
            dia.text = "Hey grandma, their friend is the only benefactor in my life!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Meru";
            dia.text = "Oh okay, I'll treat it for free! Now take me there to see what the situation is.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you very much!";
        }
        else if (tang >= 19)
        {
            CutscenesController.cus90 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno desert");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus90 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}