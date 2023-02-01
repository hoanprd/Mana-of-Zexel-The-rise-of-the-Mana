using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus62 : MonoBehaviour
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
            dia.text = "Hey Heerium! We brought some presents for this uncle!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Heerium";
            dia.text = "Oh yeah? Then thank you very much!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Heerium";
            dia.text = "Wow! This is the ore in the land of the inferno volcano! You guys are already there!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! We haven't been able to get through inferno ice yet because we haven't gotten the energy core to open the Zexel portal yet at the inferno volcano.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Heerium";
            dia.text = "Why can't you get that?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "Because the village chief there said if you take the energy core there, the land will be engulfed in flames.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Heerium";
            dia.text = "Hum... So that core of energy sustains the village.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "I'm afraid it will be the same in inferno ice, because the energy cores keep the people alive there.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "That means we'll never be able to open the Zexel Gate.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "It's a headache, we're still stuck anyway!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Heerium";
            dia.text = "It's hard to admit, no one wants to take away someone else's source of life.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Heerium";
            dia.text = "But I think you guys should go to inferno ice and see if things are different.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "But we can't get the core there...";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Heerium";
            dia.text = "It's not! I mean in that land it's the opposite of the inferno volcano. Surely there is a way to fix this. Come and try it and you'll see.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay then we'll go to inferno ice.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Heerium";
            dia.text = "I will expect good news from you.";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus62 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("WeaponStore");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus62 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("WeaponStore");
    }
}