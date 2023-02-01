using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus108 : MonoBehaviour
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
            NameTagText.text = "Vayne";
            dia.text = "!!! The town is being attacked by monsters...";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "It's not okay, everyone in town is like my father.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Hurry up we have to defeat them.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Those monsters don't get around anymore.";
        }
        else if (tang >= 5)
        {
            CutscenesController.cus108 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus108 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}