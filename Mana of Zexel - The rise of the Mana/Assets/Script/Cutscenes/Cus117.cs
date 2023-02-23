using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus117 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1, ZexelVAR1;
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
            NameTagText.text = "";
            dia.text = "Glowinggggggg...";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Another Zexel illusion. After all, she wants to show us something.";
        }
        else if (tang == 3)
        {
            ZexelVAR1.SetActive(true);
            NameTagText.text = "Zexel";
            dia.text = "Dear everyone, it seems fate has arranged according to what I predicted.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Zexel";
            dia.text = "Long ago after the battle between me and Sicxalon ended, I had a peaceful life.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Zexel";
            dia.text = "But I know well that the peace will crumble someday like now. That's why I hope future generations don't make the same mistake I did.";
        }
        else if (tang == 6)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Zexel's mistake?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Zexel";
            dia.text = "I have a family, my beloved daughter Alia. I was not able to fulfill the role of a mother completely.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Zexel";
            dia.text = "In order to prolong the seal of Sicxalon, I must sacrifice my life in this temple. Since I didn't want her to live a lonely life, I gave her the option of hibernation for her.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Zexel";
            dia.text = "I want it to have a new life once it wakes up. A life where she doesn't need me. I'm sorry Alia!";
        }
        else if (tang == 10)
        {
            MariaVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "This... I... have started to remember! Memories of my mother are flooding back...";
        }
        else if (tang == 11)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "What? Is Alia really Zexel's daughter?";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "If so, that would clear up a lot of questions.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Zexel";
            dia.text = "I implore the chosen ones to save this world, defeat Sicxalon completely and don't make your future suffer like me.";
        }
        else if (tang == 14)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "... So that's the whole truth...";
        }
        else if (tang == 15)
        {
            VayneVAL1.SetActive(false);
            ZexelVAR1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "That day, I woke up and fought with the temple intruders Vayne and Zane's father.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "That's when I lost the battle and lost my memory. And Maria saved me.";
        }
        else if (tang == 17)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "... You don't have to worry about that anymore Alia. I've got you and new friends, I've created a new life for myself and have no regrets about the past.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right... I still have everyone around.";
        }
        else if (tang == 19)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Surely if your mother saw you now, she would be happy too.";
        }
        else if (tang == 20)
        {
            AliaVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Rrrrrrroommmmmmm...";
        }
        else if (tang == 21)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Let's go guys, I can feel Zane's dark energy at the temple's main gate!";
        }
        else if (tang >= 22)
        {
            CutscenesController.cus112 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel temple");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus112 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel temple");
    }
}