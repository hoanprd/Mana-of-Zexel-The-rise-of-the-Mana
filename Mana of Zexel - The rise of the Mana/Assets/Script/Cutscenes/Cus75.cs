using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus75 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1;
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
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 3)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Very similar... very similar to Zexel's fire core.";
        }
        else if (tang == 4)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "So Vayne succeeded?";
        }
        else if (tang == 5)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "If you want to know success or not, you have to try to know. I think it might work because I successfully extracted and split Zexel's and mine's fire energy cores in two.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "I can feel the abundant mana energy in both of those fire energy cores.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "The question is, can the fire elemental mana you generate maintain the stability of the volcano?";
        }
        else if (tang == 8)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "In that case, let's go to the inferno volcano and replace Vayne's fire core! We don't have much time, right?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! Anyway, I've put all my heart into this clone energy core. Definitely success!";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus75 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Save room");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus75 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Save room");
    }
}