using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus16 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject va2;
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
            NameTagText.text = "Maria";
            dia.text = "Okay! This is enough to make a barrier to stop that golemn!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'm counting on you.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "You two wait for me a bit, but Alia, is your cauldron still okay?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Everything is fine, I think Vayne is still good to use.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "Well, then everything will be quick!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "I also have some of my mana preloaded.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Then thank you very much! Vayne";
        }
        else if (tang == 8)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Done! This is what helps us lock the golemn's feet for a while.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Just that simple? This thing looks like a cloth.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "This is not just a cloth, but a cloth filled with mana.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "I get it! Usually the golems will have a source of mana in them, if we combine the mana and resist them they can't advance.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right, this curtain is like a short barrier to prevent that golemn from going deep as well as a layer to protect the city from golemn.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "Come on show me how it works!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "Okay let's go!";
        }
        else if (tang == 16)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "It really worked!";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Alia";
            dia.text = "The golemn looks more scared!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "This is also just a temporary form, after a while this curtain will expire!";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "In that case, we just need to make more.";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Maria";
            dia.text = "That's fine for now. We will find a way to solve it still the best.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm! I'll admit you're really good, I've never done these things before.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Maria";
            dia.text = "The recipe is simple, you just need to transfer the mana into the cloth made from the extremely strong thread of this forest and combine them to create a net.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Vayne";
            dia.text = "Maybe I'll try to stop this golemn-like monster from entering town.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Maria";
            dia.text = "If so, I'll ask you to do it.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Vayne";
            dia.text = "Anyway, the danger is over, we should go back to town, I still have something to investigate!";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Klener";
            dia.text = "Oh is that guy Vayne?";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hmmm who is that?";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Klener";
            dia.text = "I'm Mr.'s town bodyguard named Klener. Here's Lance, I'm here to give an update on the golems who've been revolting lately.";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Alia";
            dia.text = "Brother Klener doesn't have to worry because Vayne and Maria are done with it.";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Klener";
            dia.text = "Maria too? Hello Maria, long time no see.";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Maria";
            dia.text = "It's okay, the iron golemn won't dare to go deep into the town.";
        }
        else if (tang == 33)
        {
            NameTagText.text = "Klener";
            dia.text = "Iron Golemn! How could such a dangerous monster be here.";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Vayne";
            dia.text = "We'll find out later, now we should get back before the other monsters attack.";
        }
        else if (tang == 35)
        {
            NameTagText.text = "Klener";
            dia.text = "Well in that case I'll take you all back to town as a bodyguard.";
        }
        else if (tang == 36)
        {
            NameTagText.text = "Alia";
            dia.text = "Klener is serious too!";
        }
        else if (tang >= 37)
        {
            CutscenesController.cus16 = 1;
            ContainerController.LoadingOpen = true;
            MapController.ZexelTownToTavern = false;
            MapController.ZexelTownToWishingForest = true;
            SceneManager.LoadScene("Wishing forest");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus16 = 1;
        ContainerController.LoadingOpen = true;
        MapController.ZexelTownToTavern = false;
        MapController.ZexelTownToWishingForest = true;
        SceneManager.LoadScene("Wishing forest");
    }
}