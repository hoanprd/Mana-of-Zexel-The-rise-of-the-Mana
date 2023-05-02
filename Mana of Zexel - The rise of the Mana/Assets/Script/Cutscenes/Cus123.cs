using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus123 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, JescaVAL1, JescaVAR1, MeruVAL1, MeruVAR1;
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
            JescaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "Grandma! I'm back here. We have visitors!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Meru";
            dia.text = "Wait a minute and I'll come out.";
        }
        else if (tang == 3)
        {
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Is it Vayne's group? Do you guys have something to visit?";
        }
        else if (tang == 4)
        {
            JescaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "We heard Jesca talk about the village's lack of water, so we wanted to drop by and check it out.";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Ha... It seems complicated, this is the first time that you have seen such salty water.";
        }
        else if (tang == 6)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Can you take us to see that lake?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Meru";
            dia.text = "Okay, follow me to the southwest of the village.";
        }
        else if (tang == 8)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            MariaVAL1.SetActive(false);
            MeruVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 9)
        {
            MeruVAL1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "The nature of this lake comes from underground water, it seems to have become salty due to the recent rise in sea level.";
        }
        else if (tang == 10)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Could it be the coast at the foot of the mana cliff?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Meru";
            dia.text = "I used to worry that this would happen, but I still don't know how to fix it.";
        }
        else if (tang == 12)
        {
            MeruVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "So can Vayne purify this water from being salty?";
        }
        else if (tang == 13)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It's useless because to get rid of salinity it has to be removed from the main water source but the water source is from the sea so that won't be possible.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Alia";
            dia.text = "But why wasn't this water salty in the first place?";
        }
        else if (tang == 15)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Maybe underground aquifers have the ability to filter water through the soil of this land, but as the sea level rises, the salinity cannot be filtered out and things will become worse over time.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "So what should we do?";
        }
        else if (tang == 17)
        {
            AliaVAL1.SetActive(false);
            MeruVAL1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "It's really hard, I don't ask for much from you guys but...";
        }
        else if (tang == 18)
        {
            VayneVAR1.SetActive(false);
            JescaVAR1.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "Or would you like to create a water source?";
        }
        else if (tang == 19)
        {
            MeruVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Huh? Generate water? I think it's very difficult...";
        }
        else if (tang == 20)
        {
            JescaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "The source of water...";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Maria";
            dia.text = "Is that right? Good idea too, Jesca!";
        }
        else if (tang == 22)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Can Maria do it?";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Maria";
            dia.text = "It's not about creating new water sources, it's about finding new sources of water.";
        }
        else if (tang == 24)
        {
            AliaVAL1.SetActive(false);
            MeruVAL1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Looking for a source of water? You mean find a new lake?";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right!";
        }
        else if (tang == 26)
        {
            MeruVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "But the groundwater here is all salty.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Maria";
            dia.text = "Did you forget, Vayne? It's the mana gate near here! If you notice that the mana gate has a fairly large river, the exploitation of the water there will be very good.";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "Right, that reminds me of that important point. But we don't know how to find out how the groundwater comes from the mana gate.";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Maria";
            dia.text = "That I can handle. At my old house there is a device that detects mana energy.";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Vayne";
            dia.text = "A mana detector? I still don't quite understand.";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Maria";
            dia.text = "Think twice, Vayne! The mana gate water source will have a certain amount of dissolved mana, so there will be mana in it. So we can find the source of water through mana detection that we can determine the underground water source of the mana gate.";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Vayne";
            dia.text = "I see if that's the case, then we'll just have to find that device. As for Mrs. Meru, wait for us, we can fix this.";
        }
        else if (tang == 33)
        {
            VayneVAL1.SetActive(false);
            MeruVAL1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Thank you for your concern.";
        }
        else if (tang == 34)
        {
            MariaVAR1.SetActive(false);
            JescaVAR1.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "Good luck!";
        }
        else if (tang >= 35)
        {
            CutscenesController.cus123 = 1;
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
        CutscenesController.cus123 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}