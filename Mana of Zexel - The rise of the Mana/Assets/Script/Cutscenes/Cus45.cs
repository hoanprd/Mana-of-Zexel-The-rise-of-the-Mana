using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus45 : MonoBehaviour
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
            dia.text = "Hey Orina! We've got a bunch of scorpion tails! Are you satisfied?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Orina";
            dia.text = "Hey, don't raise your voice like that!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia, stop being like that, give her some respect.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Hum... I hate seeing it.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Orina";
            dia.text = "It's not bad, you guys admit it's good.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "If so, tell us how to open the gate to Orina.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Orina";
            dia.text = "Alright! Actually...";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Orina";
            dia.text = "I really don't know how to open that gate.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "What... what?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "Are you kidding me?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Orina";
            dia.text = "It's true that I don't know how to open the gate. But I know someone who can show you that gate. Those are the mana gods";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "Are you serious, Orina? We risked our lives bringing these back not to listen to such false instructions.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Orina";
            dia.text = "I'm serious! The gods are real, they created the barrier of the gate as well as the key and only they can open it.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "So if the gods are real, where should we find them?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Orina";
            dia.text = "It's going to be hard for you for the first time!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey don't go around, we're impatient!";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Orina";
            dia.text = "Calm down, there's a mana-filled patch of land south of the inferno desert, if Vayne or Maria would have sensed it if they got close to it!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Maria";
            dia.text = "Are the gods really in that land?";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Orina";
            dia.text = "No way! That land is just a place to get to the space of mana gods, whether you can find it or not depends on you.";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Vayne";
            dia.text = "... That sounds vague. From the existence of a mana god to another dimension.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Orina";
            dia.text = "Believe it or not, go there and check it out, I'm sure they'll know more interesting things than I do.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, if there's nothing else, we'll go.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Orina";
            dia.text = "Uhm, good luck.";
        }
        else if (tang >= 27)
        {
            CutscenesController.cus45 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("GroceryStore");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus45 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }
}