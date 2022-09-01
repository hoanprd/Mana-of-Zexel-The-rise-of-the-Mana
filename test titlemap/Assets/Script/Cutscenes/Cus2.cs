using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus2 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    public GameObject va2;
    public GameObject va3;
    private int tang=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
            dia.text = "Thief: You're stronger than I thought, kid.";
        else if (tang == 2)
            dia.text = "Vayne: Don't look down on a alchemist like me.";
        else if (tang == 3)
            dia.text = "Thief: Alchemist? Like I'm sacred? My comrades help me!";
        else if (tang == 4)
            dia.text = "Vayne: !!!";
        else if (tang == 5)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            dia.text = "???: I don't think so. Hya! ";
        }
        else if (tang == 6)
            dia.text = "Thief: Oh no, that brat again. Retreat!";
        else if (tang == 7)
        {
            va2.SetActive(false);
            va3.SetActive(true);
            dia.text = "Vayne: What?";
        }
        else if (tang == 8)
            dia.text = "???: That's right, run and find another job to do.";
        else if (tang == 9)
            dia.text = "Vayne: Uhm... Thanks for helping me there.";
        else if (tang == 10)
            dia.text = "???: You welcome! By the way who are you?";
        else if (tang == 11)
            dia.text = "Vayne: Oh! My name is Vayne. I'm a alchemist from the southwest of the land of Zorth.";
        else if (tang == 12)
            dia.text = "Alia: Nice to meet you Vayne! I'm Alia.";
        else if (tang == 13)
            dia.text = "Vayne: Why is a girl like you in such a dangerous desolate place.";
        else if (tang == 14)
            dia.text = "Alia: ... Well, I like to travel around Zexel town as well as help people like you.";
        else if (tang == 15)
            dia.text = "Vayne: Did you just say Zexel town? Do you know which direction I need to go?";
        else if (tang == 16)
            dia.text = "Alia: Yeah it's on the west side of this hill.";
        else if (tang == 17)
            dia.text = "Vayne: Ok! Thanks very much.";
        else if (tang == 18)
            dia.text = "Alia: Hey! Can I go with you? I can help you the way there.";
        else if (tang == 19)
            dia.text = "Vayne: Yeah, sure! It's my pleaser.";
        else if (tang == 20)
            dia.text = "Alia join the team.";
        else if (tang >= 21)
        {
            CutscenesController.cus2 = 1;
            SceneManager.LoadScene(2);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus2 = 1;
        SceneManager.LoadScene(2);
    }
}
