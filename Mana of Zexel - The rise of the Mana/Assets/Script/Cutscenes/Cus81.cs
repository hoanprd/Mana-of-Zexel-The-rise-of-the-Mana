using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus81 : MonoBehaviour
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
            NameTagText.text = "Alasa";
            dia.text = "Ah Vayne! You're here, according to what I should do it seems to give you Zexel's ice energy core right?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes sir, so the front energy core is Zexel's ice energy core? I can feel the mana source from it.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alasa";
            dia.text = "Hahaha, that's right, not bad right? You really are a talented alchemist! So I think this energy core belongs to you.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "But if I take it, what will happen to this village?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alasa";
            dia.text = "The glacial climate will simply become colder than usual, which will cause the villagers to move to the inferno volcano or alta inferno to live.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alasa";
            dia.text = "Sadly, we can't make use of the resources in this land of inferno ice anymore.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "You don't have to worry about this, village head Alasa, Vayne can easily clone Zexel's ice energy core like when he saved Asila's village from the volcanic eruption.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right! Vayne is very good at these things!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Come on guys, I'm not that good, it's all down to luck.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alasa";
            dia.text = "Can you really make a copy of the ice energy core?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "I have to do it to see the results...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alasa";
            dia.text = "I see, I've given you the energy core anyway so make good use of it.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'll do my best.";
        }
        else if (tang >= 14)
        {
            CutscenesController.cus81 = 1;
            SceneManager.LoadScene("InsideIceCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus81 = 1;
        SceneManager.LoadScene("InsideIceCave");
    }
}