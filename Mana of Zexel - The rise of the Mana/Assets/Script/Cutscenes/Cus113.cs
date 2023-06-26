using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus113 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
    public GameObject NameTag;
    private int tang = 0, stop = 0;

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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I got the wood you needed!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Thank you very much! You arrived just in time as I prepared some other materials!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "I wonder what materials people can build houses from in the past?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "A long time ago Alta inferno had a forest and it was a valuable source of natural materials that we had.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "So, it seems like everyone's life becomes difficult after losing that land.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Yes, from the source of water to the medicinal herbs here is very scarce, but your group has revived the land. In a few years, everything will be back to normal.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "I would like to give you some of my sincerity in return, please accept.";
        }
        else if (tang == 8)
        {
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Zen +200";
            if (stop == 0)
            {
                stop = 1;
                Global.Zen += 200;
            }
        }
        else if (tang >= 9)
        {
            CutscenesController.cus113 = 1;
            ContainerController.Wood -= 10;
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
        CutscenesController.cus113 = 1;
        ContainerController.Wood -= 10;
        ContainerController.LoadingOpen = true;
        if (tang < 8)
        {
            Global.Zen += 200;
        }
        SceneManager.LoadScene("Inferno volcano");
    }
}