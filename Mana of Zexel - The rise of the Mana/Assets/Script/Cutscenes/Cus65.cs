using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus65 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MariaVAR1, ShanVAR1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Wolf";
            dia.text = "Hawoooooooooooooooooooo...";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Howl, there are wolves nearby!";
        }
        else if (tang == 3)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "We have to hurry or else...";
        }
        else if (tang == 4)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "It's not okay... it's not okay! They... they've surrounded us!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "!!! All prepare for battle!";
        }
        else if (tang == 6)
        {
            VayneVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Snikttttttttttttttttttt";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's...";
        }
        else if (tang == 8)
        {
            ShanVAR1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "It seems like everyone is having a hard time with the wolves in this land?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Shan! You saved us once!";
        }
        else if (tang == 10)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "You're not wearing anything else, Shan! Don't you feel cold?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Shan";
            dia.text = "I'm used to it here, so it's normal to endure the cold here.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Shan";
            dia.text = "You guys came here to meet the village chief at inferno ice, right?";
        }
        else if (tang == 13)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes... that's right! If you don't mind, we...";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Shan";
            dia.text = "I'll take you, that village to the south. Just like we are waiting for you here!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really? But aren't you a resident of the inferno volcano?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Shan";
            dia.text = "Don't ask too much if you don't want to freeze in this cold weather.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, okay, we'll follow.";
        }
        else if (tang >= 18)
        {
            CutscenesController.cus65 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno ice");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus65 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}