using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus112 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
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
            NameTagText.text = "Villager (Man)";
            dia.text = "You must be Vayne right? We have been informed by Sir Alasa that we will be assisted by you to restore the damage to the village.";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right, hopefully we can be of some help!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "I heard you guys are from Zexel town right?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Actually that's my current residence, do you have any request from the outside?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "You see my house was broken by the inferno beast, the materials here are quite few for building such as wood.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "That's why I need you to help me get some wood, okay?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Wood? This is simple, but it will take some time to transport from the forest near Zexel town.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Then thank you, please spare your time.";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus112 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno volcano");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus112 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}