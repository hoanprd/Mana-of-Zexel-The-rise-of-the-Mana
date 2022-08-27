using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus5 : MonoBehaviour
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
            dia.text = "Alia: Here is my room! Be as natural as you are at home.";
        else if (tang == 2)
            dia.text = "Vayne: Mr. Lance let you rent this room too?";
        else if (tang == 3)
            dia.text = "Alia: That's right, actually Maria let me stay for free.";
        else if (tang == 4)
            dia.text = "Vayne: Maria? Who is that?";
        else if (tang == 5)
            dia.text = "Alia: Well, she is the daughter of Mr. Lance, the one who saved me and gave me the place I am now.";
        else if (tang == 6)
            dia.text = "Alia: Another special thing is that she is also an alchemist like you.";
        else if (tang == 7)
            dia.text = "Vayne: So that's it, no wonder I can see a large cauldron in the corner of the room over there.";
        else if (tang == 8)
            dia.text = "Alia: Anyway, like I said, make yourself at home.";
        else if (tang == 9)
            dia.text = "Vayne: Thank you Alia!";
        else if (tang >= 10)
        {
            PlayerPrefs.SetInt("cus5", 1);
            SceneManager.LoadScene(6);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        PlayerPrefs.SetInt("cus5", 1);
        SceneManager.LoadScene(6);
    }
}
