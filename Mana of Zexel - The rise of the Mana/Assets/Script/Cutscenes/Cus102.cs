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
    public GameObject VayneVAL1, MariaVAR1;
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
            dia.text = "...";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Are you still thinking about that Zane?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm... I'm really confused. Even after this, what will you do next?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Surely you never thought your father would be proud of you for anything, right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "What do you mean?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Before my mother passed away, I tried to do everything to make my mother proud so she could rest in peace.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Surely you have to do something to make your father proud, even if he's in heaven, he's happy.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "But that magician Zane, what is he planning to do? Was his goal merely Zexel's mana core stored in the temple?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "I don't know, but if Sicxalon's seal is broken it won't be good.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Did the mana gods say we're heroes? Is it fate or...";
        }
        else if (tang == 11)
        {
            VayneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "Mr. Lance";
            dia.text = "Hey, are you two out there? It's time to eat!";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes, we'll be right in.";
        }
        else if (tang >= 13)
        {
            CutscenesController.cus102 = 1;
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
        CutscenesController.cus102 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}