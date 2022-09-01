using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus10 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    private int tang = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
            dia.text = "Alia: Looks like this journey will be long, right?";
        else if (tang == 2)
            dia.text = "Vayne: That's right! But I will never give up!";
        else if (tang == 3)
            dia.text = "Alia: ... Hey Vayne, how do you feel about me?";
        else if (tang == 4)
            dia.text = "Vayne: How is it? I don't quite understand.";
        else if (tang == 5)
            dia.text = "Alia: Like I'm useful or annoying! More specifically, what kind of person am I in your eyes from personality to attitude... for example.";
        else if (tang == 6)
            dia.text = "Vayne: ... I don't even know how to be specific. But I see that you are a very good person, without you, I would have lost my way.";
        else if (tang == 7)
            dia.text = "Alia: ...Is that all?";
        else if (tang == 8)
            dia.text = "Vayne: That's basically it. Anyway, I'm only allowed to relax when I find my dad's whereabouts.";
        else if (tang == 9)
            dia.text = "Alia: Uhm...";
        else if (tang >= 10)
        {
            CutscenesController.cus10 = 1;
            SceneManager.LoadScene(4);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus10 = 1;
        SceneManager.LoadScene(4);
    }
}
