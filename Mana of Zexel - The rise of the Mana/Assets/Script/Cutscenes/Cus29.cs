using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus29 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1, OrinaVAL1;
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
            OrinaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "???";
            dia.text = "Are the kids still in there?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "???";
            dia.text = "!!!";
        }
        else if (tang == 3)
        {
            OrinaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "???";
        }
        else if (tang == 4)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "What's wrong, Vayne?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Just now I felt someone watching us and passing like a shadow!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Following us? But we have nothing for others to follow!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "I don't know, but it's strange how did you feel just now?";
        }
        else if (tang == 8)
        {
            AliaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "If there's nothing, we'll just keep going, if someone is following us, we'll lose our tail if we just follow us.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm!";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus29 = 1;
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
        CutscenesController.cus29 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}