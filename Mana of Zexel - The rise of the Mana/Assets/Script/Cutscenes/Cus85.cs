using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus85 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1, AlasaVAL1, AlasaVAR1, AsilaVAL1, AsilaVAR1, ShanVAR1;
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
            AsilaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "They have already defeated that monster!";
        }
        else if (tang == 2)
        {
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Unbelievable!";
        }
        else if (tang == 3)
        {
            AsilaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks like this monster is strong too. Why is it here?";
        }
        else if (tang == 4)
        {
            AlasaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks like it came from that cliff... Wait, someone was there, right?";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Quickly stop that guy! Hyaaaaaaaa...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "Don't thing to run away... Mana shield!";
        }
        else if (tang == 7)
        {
            AliaVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "???";
            dia.text = "!!!";
        }
        else if (tang == 8)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "There's no turning back! Want to show up!";
        }
        else if (tang == 9)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's...";
        }
        else if (tang == 10)
        {
            AliaVAL1.SetActive(false);
            AlasaVAL1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "Shan! Is it you, Shan?";
        }
        else if (tang == 11)
        {
            VayneVAR1.SetActive(false);
            ShanVAR1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Damn! Release me!";
        }
        else if (tang == 12)
        {
            AlasaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "What is this?";
        }
        else if (tang == 13)
        {
            ShanVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Look at Shan's right hand there's something...";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "That thing is quite similar to mana but darker than usual...";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "It's dark magic... those who use it will have negative energy take over their bodies.";
        }
        else if (tang == 16)
        {
            MariaVAR1.SetActive(false);
            ShanVAR1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Damn! You bastards. If those two village chiefs die, I'll have my revenge!";
        }
        else if (tang == 17)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Revenge what?";
        }
        else if (tang == 18)
        {
            AliaVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Shan, why are you like that? We didn't do anything wrong, why...";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Shan";
            dia.text = "You bastards don't understand me. It was because of two people who cut two lands that my mother died of illness without anyone helping. My father was too sad to follow my mother.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Shan";
            dia.text = "I am the only one living a life full of suffering!!! You must die!!!";
        }
        else if (tang == 21)
        {
            AsilaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "!!!";
        }
        else if (tang == 22)
        {
            ShanVAR1.SetActive(false);
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Impossible! We did not know this.";
        }
        else if (tang == 23)
        {
            VayneVAL1.SetActive(false);
            AlasaVAL1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "I never thought something like this would happen!";
        }
        else if (tang == 24)
        {
            AlasaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Wait Shan, every conflict has a solution.";
        }
        else if (tang == 25)
        {
            AsilaVAR1.SetActive(false);
            ShanVAR1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Shut up, we have no way back. Don't pity me!";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Vayne";
            dia.text = "No, we and the two chiefs don't hate you, the problem is that you haven't shared your story with us, how can we solve it.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Shan";
            dia.text = "... Hucc... Father... mother...";
        }
        else if (tang == 28)
        {
            VayneVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Shan, I... I'm sorry for ignoring this...";
        }
        else if (tang == 29)
        {
            AsilaVAL1.SetActive(false);
            AlasaVAL1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "We will definitely make up for your pain, Shan... this was an unexpected incident.";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Shan";
            dia.text = "Finally destroyed this land in vain...";
        }
        else if (tang == 31)
        {
            AlasaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It was you who destroyed the alta inferno?";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Shan";
            dia.text = "That's right... that's right, everything I do is aided by the magician.";
        }
        else if (tang == 33)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Who is that assistant magician?";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Shan";
            dia.text = "I only knew his name was Zane a year ago he was with a man named Dante. He took advantage of the darkness in my heart to make things like this.";
        }
        else if (tang == 35)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "... My father used to come here!";
        }
        else if (tang == 36)
        {
            ShanVAR1.SetActive(false);
            AlasaVAR1.SetActive(true);
            NameTagText.text = "Alasa";
            dia.text = "I'm sorry Shan, just like brother Asila, I'm so sorry for not believing you...";
        }
        else if (tang == 37)
        {
            VayneVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Alasa, you... you really forgive me?";
        }
        else if (tang == 38)
        {
            NameTagText.text = "Alasa";
            dia.text = "That's right! Come on Shan, come back to me, I won't hold any grudge against you anyway, we're the ones to blame.";
        }
        else if (tang == 39)
        {
            AsilaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "...All right, village chief...";
        }
        else if (tang == 40)
        {
            NameTagText.text = "Alasa";
            dia.text = "Vayne! Everyone, follow me to get Zexel's ice energy core.";
        }
        else if (tang == 41)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you so much village chief!";
        }
        else if (tang == 42)
        {
            NameTagText.text = "Alasa";
            dia.text = "I am the one who is indebted.";
        }
        else if (tang == 43)
        {
            AlasaVAR1.SetActive(false);
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Thank you very much too Vayne!";
        }
        else if (tang == 44)
        {
            NameTagText.text = "Vayne";
            dia.text = "No problem, we're happy to help.";
        }
        else if (tang >= 45)
        {
            CutscenesController.cus85 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Alta inferno");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus85 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Alta inferno");
    }
}