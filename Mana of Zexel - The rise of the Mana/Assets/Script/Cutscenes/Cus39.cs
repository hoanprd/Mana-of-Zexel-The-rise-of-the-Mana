using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus39 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Maria! Please taking care of Alia for me!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'll use the recipe for the antidote.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Do you have the recipe for the antidote?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right! But I haven't made scorpion poison yet so I don't know if it will work.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "You're going to need a lot of scorpion tails!!";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I still have enough strength to fight Vayne!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "... My hand... it hurts!";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "You should rest, Maria and I will collect poison!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "It's okay! I can still stand it! As long as I'm still useful!";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Alia, you're so stubborn!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alright! If you're so determined, then just stand behind me, don't take the risk!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Hey Vayne! That's not okay! If Alia is in danger, we won't be able to get back in time.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "My Elixir can still hold the poison so don't worry.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Okay! So let's go find more scorpion venom and prepare an antidote.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus39 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Maria! Nhờ chị chăm sóc Alia giúp em!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em sẽ dùng công thức điều chế thuốc giải.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em có công thức điều chế thuốc giải chất độc ư?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Nhưng em chưa điều chế độc của bọ cạp nên em không biết sẽ hiệu nghiệm không nữa.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Em sẽ cần nhiều đuôi của bọ cạp lắm đấy!";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tớ vẫn còn đủ sức để chiến đấu đấy Vayne!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "... Tay của tớ... đau thật!";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cậu nên nghỉ ngơi đi, tớ và Maria sẽ thu thập nộc độc!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Không sao đâu! Tớ vẫn chịu được! Miễn là tớ vẫn có ích là được rồi!";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Alia, em cứng đầu thiệt đấy!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi! Nếu cậu kiên quyết đến thế thì hãy đứng sau tớ thôi đừng mạo hiểm là được!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Này Vayne! Như thế không ổn đâu! Alia sẽ gặp nguy hiểm thì chúng ta sẽ không trở tay kịp đâu.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thuốc Elixir của em vẫn có thể cầm cố được chất độc nên chị đừng lo.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Được thôi! Vậy chúng ta hãy đi tìm thêm nộc độc bọ cạp và điều chế thuốc giải nào.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus39 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus39 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}