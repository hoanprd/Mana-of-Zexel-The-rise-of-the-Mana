using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus32 : MonoBehaviour
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
            dia.text = "Hello! Is any body here?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "Is the store empty?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Maybe the shop owner went out?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "If the shop owner goes out, they should leave the notice board and lock the door!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Boring! And looking around, isn't this a grocery store! The items here look so creepy!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Her shop is always like that, that's why a lot of people think she's eccentric!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "???";
            dia.text = "Eccentric? Did you guys come here to speak ill of people?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ahhh... We're sorry, we were just curious!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Hehe! We're just joking! Please... ignore!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Ehhhh... Is she the owner of the shop?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Orina";
            dia.text = "That's right! My name is Orina and I'm the owner of your eccentric grocery store!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Orina";
            dia.text = "What are you guys doing here! I hope you guys don't come here to harass me!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Actually, we heard that you know a lot of things like the history and places around this town! So...";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "We wanted to ask you if you know anything about Zexel temple and how to get there!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Orina";
            dia.text = "Temple of Zexel? Hmm... Okay then I know that!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "If so, please help us!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Orina";
            dia.text = "Huh? Help? Do you think that if you come to my shop and say bad things, I will help you guys? In your dream.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "We're really sorry! But please help us! Please!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Orina";
            dia.text = "Hmm! Really hate it! I thought it would be something cool instead of a bunch of people coming in just to make you mad! Okay, if you feel guilty, then atone for it!";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "We're ready to redeem!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Maria";
            dia.text = "Hey Vayne! Don't be so weak! If she asks for something impossible, it's no use!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "I know but without outside help we can hardly continue the journey! Anyway we are the ones to blame!";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Maria";
            dia.text = "... Okay! If you don't mind, we are willing to listen to your request, Orina!";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Orina";
            dia.text = "Then you can hear better! What we want is simple! Bring me some materials after Mana string, Iron and Wood. Each ingredient will need 5 of those!";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Vayne";
            dia.text = "No problem! But please keep your promise to help us!";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Orina";
            dia.text = "Of course! I swear on my honor!";
        }
        else if (tang >= 27)
        {
            CutscenesController.cus32 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("GroceryStore");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus32 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }
}