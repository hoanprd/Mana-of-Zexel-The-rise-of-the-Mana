using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus18 : MonoBehaviour
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
            NameTagText.text = "Klener";
            dia.text = "Vayne! If you don't mind, could you help me with something?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "What's your problem, Klener?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Klener";
            dia.text = "I just wanted you to make some healing potions and mana shields for me.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'll do it easily when it comes to recovery, but the mana shield is the same as Maria?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Klener";
            dia.text = "Is that shield made by Maria? Maybe I asked the wrong person, sorry!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "No problem, I just learned the recipe and wanted to try it out. You can trust me!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Klener";
            dia.text = "So? If so, then I'm bothering you!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Wait a minute, I'll be right in!";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus18 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus18 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}