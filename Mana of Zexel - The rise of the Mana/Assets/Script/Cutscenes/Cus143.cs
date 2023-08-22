using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus143 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1;
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
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(Alia isn't planning to follow me?)";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Vayne";
                dia.text = "Heh? Alia!";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I've been waiting for you for a while! Hihi!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'd be happy to have you with me!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Me too, where is our new journey going?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Let's see... or go back to my hometown, I have to go back and tell my mother what happened or else she would be very worried.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Okay! Let's go, please show me the way!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm... let's go.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "This is not simply an alchemist's journey.";
            }
            else if (tang == 10)
            {
                dia.text = "This is the story to kick off a life full of enthusiasm.";
            }
            else if (tang == 11)
            {
                dia.text = "Sometimes we will encounter difficult things in life.";
            }
            else if (tang == 12)
            {
                dia.text = "Just accept it and go through it, everything will be easier.";
            }
            else if (tang == 13)
            {
                dia.text = "That's called maturity, and that growth isn't the same for everyone.";
            }
            else if (tang == 14)
            {
                dia.text = "Live a happy life with the people you love.";
            }
            else if (tang == 15)
            {
                dia.text = "The end.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus143 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Outtro");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(Alia không tính đi theo mình ư?)";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Vayne";
                dia.text = "Heh? Alia!";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Em đợi anh hơi lâu đấy! Hihi!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Anh rất vui nếu có em đi cùng đấy!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Em cũng vậy, nào cuộc hành trình mới của chúng ta sẽ đi đâu đây?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Để xem nào... hay là về quê nhà của anh đi, anh phải về báo cáo cho mẹ anh biết đã xảy ra chuyện gì chứ không là bà ấy sẽ lo lắng lắm.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Được! Khởi hành thôi, anh dẫn đường cho em đi!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm... chúng ta đi thôi.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Đây không trình đơn giản là một cuộc hành trình của một nhà giả kim.";
            }
            else if (tang == 10)
            {
                dia.text = "Đây là câu chuyện để khởi động một cuộc sống đầy nhiệt huyết.";
            }
            else if (tang == 11)
            {
                dia.text = "Đôi khi chúng ta sẽ gặp những điều khó khăn trông cuộc sống.";
            }
            else if (tang == 12)
            {
                dia.text = "Chỉ cần chấp nhận và trải qua là mọi chuyện sẽ dễ dàng hơn.";
            }
            else if (tang == 13)
            {
                dia.text = "Đó gọi là sự trưởng thành, và sự trưởng thành đó không phải ai cũng giống nhau.";
            }
            else if (tang == 14)
            {
                dia.text = "Hãy sống một sống thật hạnh phúc theo ý mình cùng với những mà mình yêu quý.";
            }
            else if (tang == 15)
            {
                dia.text = "Kết thúc.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus143 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Outtro");
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
        CutscenesController.cus143 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Outtro");
    }
}