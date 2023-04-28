using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus141 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, va3, va4, va5, va6, va7;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1, KlenerVAL1, HeeriumVAL1, OrinaVAL1, ManaElfVAL1, ZaneVAL1, ZaneVAR1;
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
            ManaElfVAL1.SetActive(true);
            NameTagText.text = "Mana elf";
            dia.text = "This is Sicxalon's soul...";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right! I hope you can transform this soul into someone who can help the world in the future, okay?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Mana elf";
            dia.text = "I see, very smart choice. We will take care of the rest and on behalf of the other mana I sincerely thank everyone.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "(The battle is really over, but the journey isn't over yet...)";
        }
        else if (tang >= 5)
        {
            CutscenesController.cus141 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana temple");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus141 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana temple");
    }
}