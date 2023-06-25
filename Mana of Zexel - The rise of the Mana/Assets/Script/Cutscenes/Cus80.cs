using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus80 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1;
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
            MrLanceVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Oh, you guys come back here to rest? Be comfortable!";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Dad, we have something to ask this time!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Well, okay. Is there something difficult that you need us for?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "It's about the purifying water legend that I heard from a young age.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Purifying water? Is it just a word of mouth?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "It was you who told me about it!";
        }
        else if (tang == 7)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Mr. Lance, can you retell that legend? May be useful for us!";
        }
        else if (tang == 8)
        {
            VayneVAR1.SetActive(false);
            NameTagText.text = "Mr. Lance";
            dia.text = "Okay, in that case we'll start.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "A long time ago when mana gods still existed and co-existed with humans.";
        }
        else if (tang == 10)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "(So the mana god is telling the truth that humans used to live with mana?)";
        }
        else if (tang == 11)
        {
            VayneVAR1.SetActive(false);
            NameTagText.text = "Mr. Lance";
            dia.text = "At that time magicians were considered a threat to mana, the war of magicians broke out, causing villages and people to be affected by dark magic.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "To avoid this loss, there was a mana who tried to find an antidote to humans because they were innocent in the war.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "That mana god has found a source of water that can produce purifying water, water that can remove dark magic. Thanks to that, the lands and innocent people are peaceful again.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "According to the story, the source of water was found in the Wishing forest.";
        }
        else if (tang == 15)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Unbelievable, were magicians so cruel at that time?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "That's what I heard from previous generations, but I don't know the truth. And no one cares about that legend anymore because there are no magicians anymore.";
        }
        else if (tang == 17)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "We encountered a kind of dark magic ravaging a land of inferno volcano and inferno ice.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Have we been there already?";
        }
        else if (tang == 19)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes, but there is a cold war there, the best way to resolve the conflict between the two sides is to remove the dark magic in that land and revive that land.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "So that's it, didn't expect dark magic to still exist.";
        }
        else if (tang == 21)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "At least we'll have a quest for purifying water in the Wishing forest!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Good luck guys.";
        }
        else if (tang >= 23)
        {
            CutscenesController.cus80 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus80 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}