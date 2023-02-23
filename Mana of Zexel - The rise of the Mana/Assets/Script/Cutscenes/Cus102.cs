using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus102 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, HeeriumVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Uncle Heerium! We came to ask you for a favor.";
        }
        else if (tang == 2)
        {
            HeeriumVAR1.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "Oh, it's Vayne and the others. Is there something important to you to find me?";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "We need to upgrade our weapons to become stronger.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Heerium";
            dia.text = "Hahaha... You've found the right person. It's easy to make a new weapon, but I don't have the materials.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Heerium";
            dia.text = "But if you bring me the ingredients, I'll make you new weapons.";
        }
        else if (tang == 6)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Okay, just give me the list of ingredients so we can find them.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Heerium";
            dia.text = "Let's see, this material is quite far away, but we guarantee their quality is very good. List here Vayne!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "We already know, wait for good news from us.";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus102 = 1;
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
        CutscenesController.cus102 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("WeaponStore");
    }
}