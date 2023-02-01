using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus72 : MonoBehaviour
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
            NameTagText.text = "Maria";
            dia.text = "It's hotter than outside, we won't be able to stay long in here.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, as long as there's nothing in the way we can easily get into the depths of the volcano.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Asila";
            dia.text = "It's not that easy, this is where slimes gather.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Heh? Another slime? Why so much.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "(In that case, the ice cave last time, I found the ice energy core.)";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Wow, where did Shan go?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "He's not coming with us?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Asila";
            dia.text = "Shan told me he had business in inferno ice so he left first, so please protect me this time!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "In that case, I'll clear the way for these slimes!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alia";
            dia.text = "... It's true that God has no eyes on me....";
        }
        else if (tang >= 11)
        {
            CutscenesController.cus72 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("InsideVolcanoCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus72 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideVolcanoCave");
    }
}