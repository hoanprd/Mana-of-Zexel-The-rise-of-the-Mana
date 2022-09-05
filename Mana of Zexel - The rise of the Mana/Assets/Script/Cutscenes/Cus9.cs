using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus9 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    private int tang=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
            dia.text = "Vayne: It worked! My potion has revived the field!";
        else if (tang == 2)
            dia.text = "Villager (Man) 1: Unbelievable! Is this magic?";
        else if (tang == 3)
            dia.text = "Villager (Man) 2: Nope! This is alchemy.";
        else if (tang == 4)
            dia.text = "Villager (Wonman): Amazing! Can alchemy do that?";
        else if (tang == 5)
            dia.text = "Alia: It really worked! Someday I have to try alchemy too!";
        else if (tang == 6)
            dia.text = "Vayne: It's easy to say but alchemy is hard to learn, in reality there are very few alchemists in this world.";
        else if (tang == 7)
            dia.text = "Alia: Really! All this alchemy you taught yourself?";
        else if (tang == 8)
            dia.text = "Vayne: No, I got alchemy from my mother, she's also a good alchemist.";
        else if (tang == 9)
            dia.text = "Alia: Oh. Maria is pretty much self-taught alchemy, the whole town except you she's the only alchemist I know.";
        else if (tang == 10)
            dia.text = "Vayne: Really? I also have to see what kind of person she is.";
        else if (tang == 11)
            dia.text = "Alia: Are you excited! If that's the case, then let's move on to the wishing forest!";
        else if (tang == 12)
            dia.text = "Vayne: Okay! Let's go!";
        else if (tang >= 13)
        {
            CutscenesController.cus9 = 1;
            SceneManager.LoadScene(3);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus9 = 1;
        SceneManager.LoadScene(3);
    }
}
