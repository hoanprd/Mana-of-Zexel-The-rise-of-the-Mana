using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus46 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1;
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
            AliaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "I wonder if she's serious? Ordinary people will think she's crazy!";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hold on! If we don't come and try that mana land, we don't know if it's true or not.";
        }
        else if (tang == 3)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Anyway, the next trip is going to be a long one!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right! By the way, I feel so hungry! My stomach is growling!";
        }
        else if (tang == 5)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hehe... In that case, we'll just go back and replenish.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey Vayne! If you don't mind can you cook me a specialty of mana porridge?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Heh... You really like that?";
        }
        else if (tang == 8)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "I like it too! If you don't mind, can you make one for me?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "These two... I'm hungry too, well, if you two like it that much, I'll make mana porridge for you, okay?";
        }
        else if (tang == 10)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Yaaaaaaa... That's fine!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "Hehe.";
        }
        else if (tang == 12)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Let's all go back to the tavern!";
        }
        else if (tang == 13)
        {
            MariaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "All";
            dia.text = "OK!";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus46 = 1;
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
        CutscenesController.cus46 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}