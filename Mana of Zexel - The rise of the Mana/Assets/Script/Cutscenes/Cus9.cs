using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus9 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject NameTag;
    private int tang=0;

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
            dia.text = "It worked! My potion has revived the field!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Villager (Man) 1";
            dia.text = "Unbelievable! Is this magic?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Villager (Man) 2";
            dia.text = "Nope! This is alchemy.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Villager (Wonman)";
            dia.text = "Amazing! Can alchemy do that?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Alia";
            dia.text = "It really worked! Someday I have to try alchemy too!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's easy to say but alchemy is hard to learn, in reality there are very few alchemists in this world.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Really! All this alchemy you taught yourself?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "No, I got alchemy from my mother, she's also a good alchemist.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Alia";
            dia.text = "Oh. Maria is pretty much self-taught alchemy, the whole town except you she's the only alchemist I know.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really? I also have to see what kind of person she is.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alia";
            dia.text = "Are you excited! If that's the case, then let's move on to the wishing forest!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay! Let's go!";
        }
        else if (tang >= 13)
        {
            CutscenesController.cus9 = 1;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus9 = 1;
        SceneManager.LoadScene("Zexel town");
    }
}
