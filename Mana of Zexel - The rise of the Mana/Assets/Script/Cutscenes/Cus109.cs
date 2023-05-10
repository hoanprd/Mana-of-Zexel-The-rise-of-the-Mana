using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus109 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, MariaVAR1, OrinaVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hey Orina! Are you here?";
        }
        else if (tang == 2)
        {
            OrinaVAR1.SetActive(true);
            NameTagText.text = "Orina";
            dia.text = "Huh? Hey... hey... why don't you guys knock before entering?";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Even we knock on the door, you won't open it.";
        }
        else if (tang == 4)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Hmm? Something Orina... how could she...";
        }
        else if (tang == 5)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's dark magic... Orina you're...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Orina";
            dia.text = "Boring! I was trying to change my appearance a bit with dark magic but I was interrupted by you guys.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Why are you hiding the fact that you're a magician?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Orina";
            dia.text = "I simply don't want to get in trouble. How many people understand...";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "What happened Orina... surely your past has kept you hidden until now?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Orina";
            dia.text = "It happened a long time ago... from the time of the war mages. Everyone was afraid of magicians, so they sought to destroy people like me.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Orina";
            dia.text = "That's why my husband had to die, and my children no longer trust anyone, so they left alone and left me alone.";
        }
        else if (tang == 12)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "It's cruel... you have to endure such solitude all the time... it seems we're a little too wordy for you...";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Orina";
            dia.text = "It's okay, for someone who is over a hundred years old, looking at you guys makes me feel like my past self.";
        }
        else if (tang == 14)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Are you over 100 years old? Why is she still so young?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Orina";
            dia.text = "Dark magic can do anything, even immortality.";
        }
        else if (tang == 16)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "But you don't seem to have any malice towards people.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Orina";
            dia.text = "I just want to live peacefully. But it seems my son doesn't want that.";
        }
        else if (tang == 18)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Your son? Who is that?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Orina";
            dia.text = "The one who killed your father and gave Alia a fatal wound. It was none other than Zane.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Orina";
            dia.text = "I met and talked to her almost a year ago, she has lost her humanity, I can't teach her anymore. So I really hope someone eats its evil plots to monopolize the world.";
        }
        else if (tang == 22)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "What an ironic fate...";
        }
        else if (tang == 23)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Orina, we're going to beat Zane and bring him back here to make amends. I won't leave him alone either.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Orina";
            dia.text = "Can you guys do that? If so, we'll have to ask for your help.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Orina";
            dia.text = "Oh, one more thing, I have something for you, Vayne.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is this an alchemy recipe?";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Orina";
            dia.text = "That's right, this is a recipe for making powerful items that use a lot of mana energy.";
        }
        else if (tang == 28)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "How did you get these things Orina?";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Orina";
            dia.text = "You'll know when the time comes. Maria, I can't say that.";
        }
        else if (tang == 30)
        {
            MariaVAL1.SetActive(false);
            OrinaVAR1.SetActive(false);
            NameTagText.text = "Villager";
            dia.text = "Danger, danger! Everyone go back to town, the iron golemn monster is coming!";
        }
        else if (tang == 31)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Don't tell me the iron golemn we stopped earlier broke Maria's barrier?";
        }
        else if (tang == 32)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks like we know who we should try the new powers we have, Vayne.";
        }
        else if (tang == 33)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Okay, let's give that iron golemn a fight.";
        }
        else if (tang >= 34)
        {
            CutscenesController.cus109 = 1;
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
        CutscenesController.cus109 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }
}