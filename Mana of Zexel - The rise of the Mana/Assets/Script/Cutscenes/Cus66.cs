using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus66 : MonoBehaviour
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
            NameTagText.text = "Shan";
            dia.text = "They have arrived, village chief!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "???";
            dia.text = "So these are the people you reported to me! Only three people?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hello! We are people from far away lands. I am an alchemist named Vayne, the other two are Alia and Maria.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "???";
            dia.text = "The girl in the coat must be from Zexel town right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "... Yes that's right!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "???";
            dia.text = "It's been a long time since someone from Zexel town came over here, not even daring to come over.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alasa";
            dia.text = "My name is Alasa, village chief in inferno ice. I've heard reports from Shan about the reason you came here.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "... If so, you already know everything... if so...";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alasa";
            dia.text = "Are you worried that I will send you back?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alasa";
            dia.text = "Don't worry, I am much more generous than my brother Asila.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is the village chief at the inferno volcano your brother?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alasa";
            dia.text = "That's right!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "Will the village chief intend to help us?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alasa";
            dia.text = "Of course I will help you! Just like you, you need ice cores in this land, right?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's true, but doing so your village...";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Alasa";
            dia.text = "Don't worry, I have a solution to help you get both cores.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really? If so, thank you!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Alasa";
            dia.text = "But I need you guys to do some things for me first.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "So tell me what it is?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Alasa";
            dia.text = "First help me kill the ice wolves east of inferno ice, they live in packs so be careful as they are very crowded.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "We got it.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Alasa";
            dia.text = "Shan! Take care of those three people for me, and I'm a little busy right now, when you're done, come back and report back to me.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Shan";
            dia.text = "I understand, village chief.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Alia";
            dia.text = "Doesn't this village chief appear to be more aggressive than the village chief in the inferno volcano?";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Maria";
            dia.text = "Looks like it! But she had a feeling she couldn't trust him somehow.";
        }
        else if (tang >= 25)
        {
            CutscenesController.cus66 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno ice");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus66 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}