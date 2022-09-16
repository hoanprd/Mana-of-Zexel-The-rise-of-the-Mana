using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus3 : MonoBehaviour
{
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaDAR1;
    private int tang=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
        {
            AliaDAR1.SetActive(true);
            dia.text = "Alia: We have arrived at Zexel town!";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            dia.text = "Vayne: Thank you, Alia. Amazingly, this town is so bustling, the children look so happy.";
        }
        else if (tang == 3)
            dia.text = "Alia: Of course, I really like this town.";
        else if (tang == 4)
            dia.text = "Vayne: So your hometown is here?";
        else if (tang == 5)
            dia.text = "Alia: ...Well, it's not.";
        else if (tang == 6)
            dia.text = "Vayne: So you come for a far place like me too?";
        else if (tang == 7)
            dia.text = "Alia: Actually, I have amnesia and have been traveling in this town for over a year. I only remember my name.";
        else if (tang == 8)
            dia.text = "Vayne: ... That so sad.";
        else if (tang == 9)
            dia.text = "Alia: It's okay, I'm still happy to be here.";
        else if (tang == 10)
            dia.text = "Alia: But what did you come here for?";
        else if (tang == 11)
            dia.text = "Vayne: Well, I'm here to find my dad. He is an adventurer and came here 1 year ago but he has not returned or sent any reply.";
        else if (tang == 12)
            dia.text = "Alia: So you came here to find his whereabouts?";
        else if (tang == 13)
            dia.text = "Vayne: Yes. Now I don't know where to get this information from.";
        else if (tang == 14)
            dia.text = "Alia: I know a good place to look for information. Go to the tavern where adventurers go.";
        else if (tang == 15)
            dia.text = "Vayne: That's a good idea, I'll ask you to take me there.";
        else if (tang == 16)
            dia.text = "Alia: Ok, no problem, the tavern is on the west side of town.";
        else if (tang >= 17)
        {
            CutscenesController.cus3 = 1;
            SceneManager.LoadScene(3);
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus3 = 1;
        SceneManager.LoadScene(3);
    }
}
