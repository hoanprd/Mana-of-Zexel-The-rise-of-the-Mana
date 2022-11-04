using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus12 : MonoBehaviour
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
            dia.text = "Hey Maria! We've already obtained some mana wood!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Maria";
            dia.text = "Oh wait a minute. Ah finally see, surely the book information 1 year ago is in this.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Did you find it?";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Maybe so! Your father's full name is Dante Dias, right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Oh! That's right!";
        }
        else if (tang == 6)
        {
            NameTag.SetActive(false);
            dia.text = "To be continued...";
        }
        else if (tang >= 7)
        {
            CutscenesController.cus12 = 1;
            SceneManager.LoadScene("EndDemo");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus12 = 1;
        SceneManager.LoadScene("EndDemo");
    }
}