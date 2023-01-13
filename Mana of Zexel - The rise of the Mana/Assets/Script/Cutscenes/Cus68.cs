using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus68 : MonoBehaviour
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
            dia.text = "Oh my gosh! It's even colder in here! My hand... as if I can't feel it anymore...";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "I can feel an abundance of mana here.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "Me too... it's cold to admit.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "(Is there a core of energy here?)";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "(Slime so there's a high percentage of mana core is here!)";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "What! Slime? Those filthy things too...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Shan";
            dia.text = "Are you afraid of slimes?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "It's nothing... they just look disgusting.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "By the way, Shan, usually people in the villages in the two regions of the inferno volcano and inferno ice often interact with each other?";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Shan";
            dia.text = "No, it's just me who frequents.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Just you?";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Shan";
            dia.text = "I am the servant of both village chiefs, my father is from inferno ice and my mother is from inferno volcano.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Weird...";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Shan";
            dia.text = "You don't need to care about me or about these two villages. Let's focus on finding ice crystals.";
        }
        else if (tang >= 15)
        {
            CutscenesController.cus68 = 1;
            SceneManager.LoadScene("InsideIceCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus68 = 1;
        SceneManager.LoadScene("InsideIceCave");
    }
}