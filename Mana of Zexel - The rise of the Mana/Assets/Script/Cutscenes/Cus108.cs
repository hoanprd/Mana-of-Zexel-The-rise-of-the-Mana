using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus108 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAR1, HeeriumVAL1;
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
            HeeriumVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "You guys are back, have you found the ingredients?";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It might take a while, but we managed to source those good quality ingredients.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Heerium";
            dia.text = "Looks good, okay with this material I'm going to make the best weapons and armor I can to help you guys.";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "By the way, Heerium, have you seen the merchants from the two villages of inferno volcano and inferno ice often come here?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Heerium";
            dia.text = "Oh yes, those two villages have already opened their doors to export mineral resources to other places. I also started doing business with them again.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Heerium";
            dia.text = "And what do we have to do with this? You listen to Mr. Is it true that Lance said that they helped them resolve their conflicts to open the border gate to other villages?";
        }
        else if (tang == 7)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Hehe... that's right, Heerium.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Heerium";
            dia.text = "We're really good, now let's make a new weapon.";
        }
        else if (tang == 9)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "We're counting on you, Herium. Now let's go over to Orina's to see what's new.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus108 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("WeaponStore");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus108 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("WeaponStore");
    }
}