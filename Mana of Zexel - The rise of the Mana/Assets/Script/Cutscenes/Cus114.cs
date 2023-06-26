using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus114 : MonoBehaviour
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
        if (GameSettingController.GameLangPlot == 0)
        {

        }
        else
        {

        }
        if (tang == 1)
        {
            NameTag.SetActive(true);
            NameTagText.text = "Villager (Woman)";
            dia.text = "You must be Vayne right? We have been informed by Sir Alasa that we will be assisted by you to restore the damage to the village.";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right, we're here to see what we can do for you!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Have you heard the new policy of Mr. Asila and Alasa for the two villages?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "You mean both villages started to open their borders to the outside right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Yes, my family mainly deals in minerals.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "However, our mineral resources have been eaten by the inferno beast so we urgently need the lost minerals to trade on schedule but the monsters outside the village are quite aggressive. This makes it impossible for us to dig minerals.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "I see, as long as we can supply the lost minerals, can't we?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Really this will bother you.";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(false);
            NameTagText.text = "Vayne";
            dia.text = "Don't worry the monsters here won't give us a hard time. I will provide you with timely supplies.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus114 = 1;
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
        CutscenesController.cus114 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}