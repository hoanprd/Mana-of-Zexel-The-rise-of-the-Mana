using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus53 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, MariaVAR1;
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
            dia.text = "What a tired feeling!... It's annoying.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Alia, what the matter? Is the poison just recurring?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "I feel like my muscles are pinched inside.";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "You mean your body is upset inside, right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "Yes, my heart beat faster than usual.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Maybe it's because I can't stand mana in this world.";
        }
        else if (tang == 7)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Mana? That's right, Maria and I both have the ability to withstand a large amount of mana and Alia can't.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "If that's the case, how can you endure the same amount of mana as the two of you? I remember correctly, Vayne's porridge contains mana, how can I still stand it?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Perhaps the mana here is coming from everywhere, that is, your body is absorbing mana continuously, destabilizing the body's mana flow.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Do I have to wait outside until you guys finish meeting the gods? That's not fair at all!";
        }
        else if (tang == 11)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It seems so.";
        }
        else if (tang == 12)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's okay, I have a way, just create something that can suppress Alia's mana flow.";
        }
        else if (tang == 13)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Well, I never thought of that.";
        }
        else if (tang == 14)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "However, making it won't be as easy as it used to be because it will hurt your mana flow.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alia";
            dia.text = "Damage to your mana flow? You still don't understand.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Let's go back to Zexel town then I'll explain better.";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus53 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana dimension");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus53 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana dimension");
    }
}