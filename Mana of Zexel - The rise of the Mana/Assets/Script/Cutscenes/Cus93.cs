using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus93 : MonoBehaviour
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
            NameTagText.text = "Vayne";
            dia.text = "Oh Orina! Are you here?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Orina";
            dia.text = "Is something wrong?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "We came here to inquire about something that absorbs magic like dragon mana scales.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Orina";
            dia.text = "Dragon scales mana? So that's it, it's also a good idea.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Do you know where it is?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Orina";
            dia.text = "Of course I know, the problem is I don't know if you guys can get it. If you want to get dragon scales, you have to fight that mana dragon.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "We have to save Alia so the danger is natural.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Orina";
            dia.text = "Okay, I don't want to waste your time either. That dragon is on the mana cliff.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Where exactly?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Orina";
            dia.text = "If I remember correctly, somewhere southwest of that inferno desert village. But that's just what I thought, but I'm not sure there's a mana dragon there.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "At least we can look around. As for dragons, I've never seen them in real life either.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Orina";
            dia.text = "The mana dragon is different from normal, it looks like a cow?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "A... cow? Does it really look like that?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Orina";
            dia.text = "That kind of dragon is quite rare anyway, if you see a flying cow, it's a mana dragon.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you, Orina, if that's the case, here we go!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Orina";
            dia.text = "Yeah, nothing.";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus93 = 1;
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
        CutscenesController.cus93 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }
}