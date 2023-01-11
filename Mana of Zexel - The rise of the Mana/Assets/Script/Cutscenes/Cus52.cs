using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus52 : MonoBehaviour
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
            NameTagText.text = "Salin";
            dia.text = "Very good, humans, Salin here I have to give up to you.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "We don't want to fight, we just want to meet the mana gods.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Salin";
            dia.text = "I know what you're here for, but I just wanted to check if you're qualified to move on to the sacred world of mana.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Then we passed your test, right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Salin";
            dia.text = "Yes, I am the guardian of the world of man and mana, fate brought us together, I will open the gate to the world of mana.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you very much.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "You say destiny? That means you knew we were coming here?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Salin";
            dia.text = "Yes, the gods say that a group of people will come to meet them and it is my duty to test the strength of that group.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "So do gods really exist?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Salin";
            dia.text = "Whether gods exist or not, go ahead and see with your own eyes the world where the gods of mana reside.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Salin";
            dia.text = "One more thing, I have a gift for you for defeating me which is my feather. Use it wisely.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "";
            dia.text = "Guardian feather +1";
        }
        else if (tang >= 13)
        {
            CutscenesController.cus52 = 1;
            SceneManager.LoadScene("Mana gate");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus52 = 1;
        SceneManager.LoadScene("Mana gate");
    }
}