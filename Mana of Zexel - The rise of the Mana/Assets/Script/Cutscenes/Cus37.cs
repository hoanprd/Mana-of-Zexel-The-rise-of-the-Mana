using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus37 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAR1, JescaVAL1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        StartCoroutine(DelayBGM());
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                JescaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Ah! There is my village!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Wow! To think there was a village in a desert like this!";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Doesn't it look hot around here?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Jesca";
                dia.text = "Actually, if you go to the southwest of the village, you will reach a cliff near the coast, so the temperature here is blown by the wind.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "So that's it, if I have a chance, I will visit here again!";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey Jessica! Where is your house?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Jesca";
                dia.text = "My house is at the southwest end of the village, you can go home anyway, thank you very much!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Jesca";
                dia.text = "Without you, I wouldn't be standing here talking anymore.";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nothing! Next time I remember not to venture that far!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Jesca";
                dia.text = "By the way, I still don't know your names.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "My name is Vayne and the lady in the coat is Maria, the two of us are alchemists. The other sister's name is Alia, you can tell she's a warrior.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Jesca";
                dia.text = "Your style of dressing must be from far away! Why did you come to this desert!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well, actually, the other two only helped me find Zexel's temple, so I came here.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Jesca";
                dia.text = "The Temple of Zexel! Very few people go there because they are stopped by a very large gate.";
            }
            else if (tang == 15)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "The gate? You mean the Zexel gate?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Jesca";
                dia.text = "That's right! The gate is on the north side of this desert, but it won't open to those who deserve it.";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Is the gate open only to the worthy?";
            }
            else if (tang == 18)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You mean we have to do something to get through the gate?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Jesca";
                dia.text = "I think so, anyway, that's all I heard from my grandfather!";
            }
            else if (tang == 20)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I get it! Then we will leave now, good bye!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Jesca";
                dia.text = "Do you need to stay in the village for 1 night?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "No need! Today there is still plenty of time. See you soon, Jessica!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Jesca";
                dia.text = "I understand! Thank you guys and see you again!";
            }
            else if (tang >= 24)
            {
                CutscenesController.cus37 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                JescaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Ah! Đã đến ngôi làng của em rồi!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Woah! Không ngờ lại có một ngôi làng ở khu sa mạc như này á!";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Trông xung quanh đây cũng không nóng lắm nhỉ?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Jesca";
                dia.text = "Thực ra thì nếu anh chị tiến về tây nam của khu làng sẽ đến được một vách đá gần bờ biển nên nhiệt độ nơi đây được gió thổi mát.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ra là thế nếu có dịp mình sẽ ghé lại đây tham quan mới được!";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này Jesca! Nhà em ở đâu thế?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Jesca";
                dia.text = "Nhà em ở tận cùng phía tây nam ngôi làng, anh chị có thể về được rồi dù sao thì em cảm ơn anh chị nhiều!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Jesca";
                dia.text = "Không có anh chị chắc em không còn đứng đây nói chuyện nữa rồi.";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không có gì! Lần sau em nhớ không được mạo hiểm đi xa như thế đấy!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Jesca";
                dia.text = "À mà, em vẫn chưa biết tên của anh chị.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Anh tên là Vayne còn chị mặc áo khoác tên là Maria, 2 người bọn anh là nhà giả kim. Chị còn lại tên là Alia, có thể biết chị ấy là một chiến binh.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Jesca";
                dia.text = "Phong cách ăn mặc của anh chị chắc là người xa đến rồi! Lý do gì mà anh chị lại đến khu sa mạc này!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "À thật ra 2 người kia chỉ giúp anh đi tìm ngôi đền của Zexel nên mới đến đây.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Jesca";
                dia.text = "Ngôi đền của Zexel ư! Hầu như ít ai lại đến đó lắm vì bị cánh cổng rất lớn chặng lại.";
            }
            else if (tang == 15)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cánh cổng ư? Ý em là cánh cổng Zexel?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Jesca";
                dia.text = "Đúng thế! Cánh cổng nằm phía bắc sa mạc này nhưng cánh cổng ấy sẽ không mở cho những người xứng đáng đâu.";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cánh cổng chỉ mở cho những xứng đáng thôi ư?";
            }
            else if (tang == 18)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ý em là bọn chị phải làm gì đó mới qua được cánh cổng ư?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Jesca";
                dia.text = "Em nghĩ là thế, dù sao thì em cũng chỉ nghe ông nội của em kể lại thế thôi!";
            }
            else if (tang == 20)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Anh hiểu rồi! Vậy thì em mau về nhà đi, anh chị đi đây!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Jesca";
                dia.text = "Anh chị có cần ký túc lại ngôi làng 1 đêm không?";
            }
            else if (tang == 22)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không cần đâu! Ngày nay vẫn còn nhiều thời gian. Hẹn gặp lại nhé Jesca!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Jesca";
                dia.text = "Vâng! Cảm ơn anh chị và hẹn gặp lại!";
            }
            else if (tang >= 24)
            {
                CutscenesController.cus37 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
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
        CutscenesController.cus37 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}