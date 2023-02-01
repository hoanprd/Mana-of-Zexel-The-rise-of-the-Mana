using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus111 : MonoBehaviour
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
            NameTagText.text = "";
            dia.text = "Glowinggggg...";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "Is this light... an illusion of Zexel?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Zexel";
            dia.text = "Welcome, you must have the key to the room of truth to get through here, I hope you all go further to the east of the temple to reach the room of truth.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Gone... Zexel wants us to go to the room of truth.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "";
            dia.text = "Rrroommmmm...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Another earthquake!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Looks like we don't have much time, let's hurry to the room of truth.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "... (This feeling feels very familiar but what is it?)";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus111 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel temple");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus111 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel temple");
    }
}