using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus25 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAR1;
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
            dia.text = "Just as simple as this?";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks good too! It looks small, but that's enough to destroy a mid-range golem!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "It too dangerous!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Calm down, you can make it play if it's amplified by me. That is, before throwing, transfer the amount of mana to compress them and boom.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Phew! By the way, did you learn all these alchemy knowledge on your own?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right! More precisely, I learned from a book when I was a child.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Can't believe you've been inspired by alchemy since childhood? I'm too old to even get into alchemy!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "Also nothing! If I had had a talent from a young age, things would have been different, my mother would have...";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Is something wrong with your parents?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "No... Nothing! It was just that she was too weak back then.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Maria, don't you use alchemy to help everyone in the village because of something you're obsessed with?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Maria";
            dia.text = "... Klener told you already?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "No, Klener doesn't know anything about you.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "It's really hard to hide, when I was young, there was a pandemic in town! At that time, my mother was in the medical room.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "She was very busy taking care of the patients, and it was because of this that my mother was infected.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "I couldn't stand still, so I found a way to neutralize the disease, so that's when I read the book on alchemy, which I hoped was a miracle.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Maria";
            dia.text = "It's ironic that neither my father nor the people in the village believe in alchemy because I just do something that no one else thinks of.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Unbelievable. Even so, are you continuing to study alchemy?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "Yes, but my mother was… she had reached her limit and everything had come to an end. At that time, my father and sister were just dumbfounded...";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, I get it and maybe there's a misunderstanding about you. I'm sorry!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Maria";
            dia.text = "I couldn't protect anyone and everyone didn't believe me!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Okay it's over! You did a great job to stop the iron golem out there or else the town wouldn't be so quiet right now!";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "Not only that, you taught me about alchemy. Someone like you is very respectful!";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne... I get it! Looks like fate brought the two of us together if that's the case I've made up my mind!";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Maria";
            dia.text = "I will accompany you to find your father's whereabouts.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's great, thank you and look forward to teaching!";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Maria";
            dia.text = "Looks like you've changed from before! Maybe being accompanied by a good person like you!";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hehe! If nothing else, we're ready to go!";
        }
        else if (tang >= 29)
        {
            CutscenesController.cus25 = 1;
            ContainerController.LoadingOpen = true;
            ContainerController.Bom -= 1;
            SceneManager.LoadScene("Save room");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus25 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.Bom -= 1;
        SceneManager.LoadScene("Save room");
    }
}