using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus122 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, JescaVAL1;
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
            AliaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "It's exciting, we'll definitely win against Zane.";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "I told you not to be so subjective. Even if we're strong, that doesn't mean Zane will lose to us. Magicians have many dangerous tricks.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Okay, I won't let my guard down.";
        }
        else if (tang == 4)
        {
            AliaVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Rrrrrrrrrrroooommmmmmmmmmmmmmmmm....";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "!!! The ground is shaking...";
        }
        else if (tang == 6)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What's going on!";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Earthquake?";
        }
        else if (tang == 8)
        {
            MariaVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Rrrrrrrrrrrroommmmmmmmmmm...";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It stop.";
        }
        else if (tang == 10)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Is it really an ordinary earthquake or is something going on?";
        }
        else if (tang == 11)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            JescaVAL1.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "It's dangerous, I have to collect it quickly and then return.";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Jesca";
            dia.text = "Huh? Is that Vayne's group? Do you guys have any business to come over here?";
        }
        else if (tang == 13)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Jesca? We just stopped by here for a little business. Why are you out here alone?";
        }
        else if (tang == 14)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Don't tell me you're taking the risk of picking medicine again?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Jesca";
            dia.text = "No, that's not it, I'm just collecting cacti.";
        }
        else if (tang == 16)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Collecting cactus? To do what?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Jesca";
            dia.text = "It's also complicated, my village is running out of water right now. So everyone uses every source of water they can find like a cactus.";
        }
        else if (tang == 18)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Did your village all have a source of water these days?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Jesca";
            dia.text = "Yes, my villagers use water from a river to create a large lake but the recent shoreline has made it salty through groundwater.";
        }
        else if (tang == 20)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Has this just happened or is it cyclical?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Jesca";
            dia.text = "My grandma said this is the first time this has happened to me so it's really hard to deal with.";
        }
        else if (tang == 22)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Well, if that's the case, why don't we drop by to have a look.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Jesca";
            dia.text = "Yes, please come over to my place.";
        }
        else if (tang >= 24)
        {
            CutscenesController.cus122 = 1;
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
        CutscenesController.cus122 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}