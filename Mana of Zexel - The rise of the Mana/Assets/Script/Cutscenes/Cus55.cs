using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus55 : MonoBehaviour
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
            NameTagText.text = "Maria";
            dia.text = "I can feel the mana increasing in abundance.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's...";
        }
        else if (tang == 3)
        {
            NameTagText.text = "???";
            dia.text = "Welcome heroes, we mana gods are waiting for you!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Hero? Do we save the world or something?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Please introduce ourself my name is Vayne, and this is Maria, both of us are alchemists, the other is Alia.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Mana elf";
            dia.text = "I am the mana of the spirits, and the other two are the mana of stone and light. We are the descendants of the gods of mana. Nice to meet you guys.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Admittedly these gods are humble.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mana rock";
            dia.text = "We respect you because you will have a very important responsibility later.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "You mean we're going to save the world?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Mana light";
            dia.text = "Yes, it's only a matter of time now.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "We came here just to ask the mana gods how to open the gate of Zexel.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Mana elf";
            dia.text = "We know you came here to ask about it but the question is, after Vayne finds your father, what will you do next?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "... This is...";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Mana elf";
            dia.text = "Pure selfishness wouldn't be worthy of a sacred place like this. Fate let us meet, which means something will happen in the future that affects the existence of mana and humans.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "Then can you tell us about the Zexel Gate and how to open it?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Mana elf";
            dia.text = "Of course, the Zexel portal was created by the alchemist Zexel almost a hundred years ago. The gate that was originally to protect the Temple of Zexel from the bad guys.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "Avoid the bad guys? That means there's something inside the temple?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Mana elf";
            dia.text = "Yes, a hundred years ago, there was an elite mana like us named Sicxalon, back then mana and humans lived in harmony and so did Sicxalon.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "Mana used to live with humans.";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Mana elf";
            dia.text = "However, because of greed for humans taking advantage of our mana, Sicxalon didn't believe in it, but when they used Sicxalon's power to plot to monopolize mana, it made Sicxalon hate humans.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Mana elf";
            dia.text = "And so Sicxalon broke out a war between mana and humans. As for us, we watched, because the humans only used us to cover their eyes, so we didn't stop Sicxalon from going to war with the humans.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Mana elf";
            dia.text = "However, Sicxalon objected to our mana not joining the war, so he fell and wanted to destroy us to monopolize his own power.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Mana elf";
            dia.text = "At that time there was an alchemist named Zexel who defeated Sicxalon before he could destroy us, so mana and humans had a new agreement to live separately from then on. That's why we live in this independent world and don't allow humans to come here except for you.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Maria";
            dia.text = "So after that battle the temple contained something of that war, right?";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Mana elf";
            dia.text = "That's right, since Sicxalon is a mana used by humans, his hatred is still there so he can't be reincarnated and his energy is too great to be destroyed. That's why Zexel has sealed his power and soul into the Zexel temple until now.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Maria";
            dia.text = "I see, so it's the legendary story of the alchemist Zexel.";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Mana elf";
            dia.text = "To open the gate to the temple, you must have the two sources of mana energy that Zexel created as the key to the temple. Those two are the two energy cores currently stored in the land of inferno volcano and inferno ice. Let's collect them and give them to us.";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Vayne";
            dia.text = "Inferno volcano and ice? Those two lands I have never been to.";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Maria";
            dia.text = "Looks like Heerium might know about those two places, Vayne because I've heard him sell ingredients sourced from those lands.";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Mana elf";
            dia.text = "We've told what needs to be told, good luck on your quest to find those two cores.";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Vayne";
            dia.text = "We thank you for the above information.";
        }
        else if (tang >= 33)
        {
            CutscenesController.cus55 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana temple");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus55 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana temple");
    }
}