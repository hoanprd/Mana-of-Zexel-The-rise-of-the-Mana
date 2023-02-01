using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus13 : MonoBehaviour
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
            dia.text = "Heh? Do we owe any golems? Why are they gathered here?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "That one looks like a leader! Do they remember our faces for equating them?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "It's not like they look so weird as if they just lost something.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Then they want revenge on us!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "Not really, but prepare yourself.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Golemn";
            dia.text = "Graaaa...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Maria if you don't mind then...";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "It's okay I can fight, I'll be of little help to you guys especially in terms of recovery.";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus13 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("BSGolemn 1");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus13 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSGolemn 1");
    }
}