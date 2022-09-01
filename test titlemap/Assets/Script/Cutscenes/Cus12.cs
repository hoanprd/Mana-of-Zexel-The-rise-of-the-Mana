using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus12 : MonoBehaviour
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
            dia.text = "Alia: Hey Maria! We've already obtained some mana wood!";
        else if (tang == 2)
            dia.text = "Maria: Oh wait a minute. Ah finally see, surely the book information 1 year ago is in this.";
        else if (tang == 3)
            dia.text = "Vayne: Did you find it?";
        else if (tang == 4)
            dia.text = "Maria: Maybe so! Your father's full name is Dante Dias, right?";
        else if (tang == 5)
            dia.text = "Vayne: Oh! That's right!";
        else if (tang == 6)
            dia.text = "To be continued...";
        else if (tang >= 7)
        {
            CutscenesController.cus12 = 1;
            SceneManager.LoadScene(19);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus12 = 1;
        SceneManager.LoadScene(19);
    }
}