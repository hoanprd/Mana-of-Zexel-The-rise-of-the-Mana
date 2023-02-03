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
            NameTagText.text = "Inferno desert villager";
            dia.text = "The monster has entered the village! Everyone, please run away!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's the inferno scorpion monsters, they want to invade this village?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "Looks like something happened to them, especially the earthquake just now that drove them crazy.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "We have to help them, we can't stand by.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Be careful, Alia! That monster is more ferocious than usual, can't be subjective.";
        }
        else if (tang >= 6)
        {
            CutscenesController.cus108 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("BSInfernoScorpion 1");
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
        SceneManager.LoadScene("BSInfernoScorpion 1");
    }
}