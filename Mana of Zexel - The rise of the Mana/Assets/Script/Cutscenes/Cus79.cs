using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus79 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {

        }
        else
        {

        }
        if (tang == 1)
        {
            MariaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "This land! I can feel a huge amount of mana!";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right, I also feel a tremendous amount of energy here... but...";
        }
        else if (tang == 3)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What's wrong, Vayne?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's just that we don't see any life here, the trees, the animals, all without what we see as a dead land.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "Okay Vayne! Use the potion you used to revive the farmers' rice fields in Zexel town, I believe you can do it.";
        }
        else if (tang == 6)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Interesting isn't it? I never thought using alchemy to reform the land.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "This... I'm not sure if it's possible because basically land that is damaged by physical factors can be restored easily but this land we still don't understand the cause. Why is this land dead?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "But it's also worth trying the elixir potion to revive the land. Alright let's try!";
        }
        else if (tang == 9)
        {
            MariaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 10)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Uhmmmm... Why do I feel like it hasn't changed at all?";
        }
        else if (tang == 11)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's not as easy as I thought it would be.";
        }
        else if (tang == 12)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "The land is still dry and the color of the earth is still crimson. The problem was why this land had so many mana sources but no life at all. It's absurd.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Somehow this land is dead but still retains a huge amount of mana energy.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Maria";
            dia.text = "... I don't think so... Look down at the ground at your feet and release some mana there Vayne!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is this really necessary? I see...";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "Just do it, and you'll understand what I mean!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay,...";
        }
        else if (tang == 18)
        {
            MariaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 19)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "No way, is there something on this earth resonating with your mana?";
        }
        else if (tang == 20)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "That's what I mean, something is covering this land and absorbing our mana. Although it is not large, the mana we can feel is the mana being absorbed from this land.";
        }
        else if (tang == 21)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Mana in this land is being absorbed but we don't feel anything.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "That's when we don't use mana.";
        }
        else if (tang == 23)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Then we'll find a way to get rid of what's haunting the ground. But what's the problem with that? I still don't understand.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Maria";
            dia.text = "I'm not so sure about this, something that can absorb mana is definitely not trivial.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Vayne";
            dia.text = "I mean a form of mana energy greater than us.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Maria";
            dia.text = "Yes, this mana might belong to magicians.";
        }
        else if (tang == 27)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "A magician again? After all, what is a magician?";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's not good, I don't know anything about dark magic.";
        }
        else if (tang == 29)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Me too but if we can purify the dark magic then maybe we can revive the land.";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Vayne";
            dia.text = "An item that can purify magic?";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Maria";
            dia.text = "I've only heard some people in Zexel town talk about the legend of the cleansing water for quite some time, but I don't know if it's true?";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Vayne";
            dia.text = "If so, try visiting Mr. Is Lance sure he knows?";
        }
        else if (tang == 33)
        {
            NameTagText.text = "Maria";
            dia.text = "I pray that my father doesn't get mad and gossip about this matter.";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Vayne";
            dia.text = "At least we have a clue! Let's go, let's go back to Zexel town.";
        }
        else if (tang == 35)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Hey, are you guys really ignoring me?";
        }
        else if (tang >= 36)
        {
            CutscenesController.cus79 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Alta inferno");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus79 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Alta inferno");
    }
}