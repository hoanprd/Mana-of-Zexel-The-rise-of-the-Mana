using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus36 : MonoBehaviour
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
            NameTagText.text = "Alia";
            dia.text = "Alright! The monster has been destroyed! But it's really hard, I feel tired all over!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Are you okay, Alia? Do you look more tired than usual?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "I'm fine! Hey girl! Are you okay?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "A defenseless little girl wandering in the desert?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "???";
            dia.text = "... Thanks! Thank you for saving me!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's nothing! What's your name and why are you wandering in the desert like this?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Whose cry for help is that?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Jesca";
            dia.text = "Oh yes! My name is Jesca, I'm wandering in the middle of the desert because I'm lost!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Jesca";
            dia.text = "I often go to pick herbs for my grandfather. He is a doctor, because of his old age I want to help my grandfather with the medicine picking part.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "And so you got lost in the desert, right?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Jesca";
            dia.text = "That's right! Usually I just go around the village to pick herbs! But this time, I was curious about my surroundings, so I got lost like this.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "In that case, let us take you home!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Jesca";
            dia.text = "Heh... Thank you guys! But my grandfather told me not to listen to strangers!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "So you want to listen to the monster's stomach just now?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey Vayne! You are rude to that child!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "I was just joking!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Jesca";
            dia.text = "Hehe... I know you're not a bad person because you've already married me! I trust you guys!";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Vayne";
            dia.text = "So where's your house?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Jesca";
            dia.text = "Yes! My home is on the southwest side of the desert. I think it's quite far from here, so...";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Alia";
            dia.text = "It's okay if there are any monsters, I'll protect you!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Jesca";
            dia.text = "If so, I would like to bother you for a while!";
        }
        else if (tang >= 22)
        {
            CutscenesController.cus36 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno desert");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus36 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}