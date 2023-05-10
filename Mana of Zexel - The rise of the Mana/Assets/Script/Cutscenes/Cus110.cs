using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus110 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, ShanVAL1;
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
            dia.text = "Granted, we're much stronger than before!";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "That's right, with this we can fight the magician Zane!";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "We must not be complacent, though.";
        }
        else if (tang == 4)
        {
            MariaVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Hoh... phoo... Hoh... phoo...";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Shan";
            dia.text = "Is it Vayne? Is that Vayne?";
        }
        else if (tang == 6)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Is that person Shan? Why have you come this far?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Shan";
            dia.text = "Please help the two villages in inferno volcano and inferno ice go Vayne!";
        }
        else if (tang == 8)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What's wrong, Shan? Calm down.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Shan";
            dia.text = "The monster inferno is back. It became more ferocious than before!";
        }
        else if (tang == 10)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "So that monster hasn't given up yet. All right, we'll give it a full blow this time.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Shan";
            dia.text = "Sorry to bother everyone.";
        }
        else if (tang == 12)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Don't worry, we're also excited about this new power and need some sandbags to fight!";
        }
        else if (tang >= 13)
        {
            CutscenesController.cus110 = 1;
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
        CutscenesController.cus110 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}