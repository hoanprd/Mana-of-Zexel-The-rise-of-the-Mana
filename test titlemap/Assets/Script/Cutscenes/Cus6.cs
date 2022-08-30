using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus6 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    public GameObject va2;
    private int tang=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
            dia.text = "Vayne: Mr. Lance I've already made the healing potion.";
        else if (tang == 2)
            dia.text = "Mr. Lance: Amazing, you're faster than I thought.";
        else if (tang == 3)
            dia.text = "Vayne: Why do you want to use the healing potion for?";
        else if (tang == 4)
            dia.text = "Mr. Lance: These days, goblins regularly wreak havoc on the south side of town. The town guards often fight but the medical supplies are not enough for them, so I take the opportunity to ask for your help.";
        else if (tang == 5)
            dia.text = "Vayne: It sounds like there are dangerous places around the village, right?";
        else if (tang == 6)
            dia.text = "Mr. Lance: Yes. Those who don't have combat skills are vulnerable to outside monsters, so be careful when you're out of town.";
        else if (tang == 7)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            dia.text = "A bodyguard: Emergency! Sir Lance, the goblins had gathered in a swarm southwest of town. We need urgent help!";
        }
        else if (tang == 8)
            dia.text = "Mr. Lance: ... It's difficult. We really lack resources.";
        else if (tang == 9)
            dia.text = "Vayne: So let me. I can handle the goblins.";
        else if (tang == 10)
            dia.text = "Alia: Hey let me join you, Vayne!";
        else if (tang == 11)
            dia.text = "Mr. Lance: I really appreciate you both, thank you and good luck out there.";
        else if (tang == 12)
            dia.text = "Alia: Okay let's go Vayne!";
        else if (tang == 13)
            dia.text = "Vayne: Hey, don't be like that, Alia! Wait for me!";
        else if (tang >= 14)
        {
            PlayerPrefs.SetInt("cus6", 1);
            SceneManager.LoadScene(5);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        PlayerPrefs.SetInt("cus6", 1);
        SceneManager.LoadScene(5);
    }
}
