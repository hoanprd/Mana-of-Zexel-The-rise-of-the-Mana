using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus7 : MonoBehaviour
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
            dia.text = "Alia: Mr. Lance, we've taken the goblins down.";
        else if (tang == 2)
            dia.text = "Mr. Lance: I don't know how to thank you both enough. You two did a great job! I will reward you two with 100 Zen.";
        else if (tang == 3)
            dia.text = "Get 100 Zen!";
        else if (tang == 4)
            dia.text = "Vayne: Anyway, did you find out my father's information Mr. Lance?";
        else if (tang == 5)
            dia.text = "Mr. Lance: I'm sorry, but I still haven't found the book containing your father's information.";
        else if (tang == 6)
            dia.text = "Mr. Lance: But I think that book might be at my old house, where my daughter is now.";
        else if (tang == 7)
            dia.text = "Alia: You mean Maria's current residence?";
        else if (tang == 8)
            dia.text = "Mr. Lance: My old house is deep in the wishing forest. Maria was also there to study alchemy.";
        else if (tang == 9)
            dia.text = "Vayne: What a hardworking person like her.";
        else if (tang == 10)
            dia.text = "Alia: Of course Vayne! She's very good, compared to her, you're just a chicken!";
        else if (tang == 11)
            dia.text = "Vayne: ...";
        else if (tang == 12)
            dia.text = "Alia: Alia: Just kidding, anyway I want to see Maria again, it's been a while since I've seen her.";
        else if (tang == 13)
            dia.text = "Mr. Lance: Be careful you two! That forest is very dangerous!";
        else if (tang == 14)
            dia.text = "Vayne: I'll consider your advice, then let's go, Alia!";
        else if (tang == 15)
            dia.text = "Alia: Ok!";
        else if (tang == 16)
            dia.text = "Mr. Lance: Those two are so passionate, hehe. Good luck both.";
        else if (tang >= 17)
        {
            PlayerPrefs.SetInt("cus7", 1);
            PlayerPrefs.SetInt("SZen", PlayerPrefs.GetInt("SZen") + 100);
            SceneManager.LoadScene(5);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        PlayerPrefs.SetInt("cus7", 1);
        if (tang >=17)
            SceneManager.LoadScene(5);
        else
        {
            PlayerPrefs.SetInt("SZen", PlayerPrefs.GetInt("SZen") + 100);
            SceneManager.LoadScene(5);
        }
    }
}
