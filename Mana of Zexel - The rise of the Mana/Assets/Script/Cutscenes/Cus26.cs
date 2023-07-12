using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus26 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, KlenerVAL1, KlenerVAR1, HeeriumVAL1, HeeriumVAR1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Okay! Let's go!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "The plan is to just keep asking the people in town, Vayne?";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I don't know either, but let's keep it that way for now.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "If only someone generously knew about the temple, that would be fine too!";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Hohhhhh! Uncle Heeriummmm!";
            }
            else if (tang == 6)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Ohh! It's Klener! I haven't seen you visit my blacksmith shop these days hahaha!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "I've been so busy with the guard lately that I haven't been able to visit you like before.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Heerium";
                dia.text = "It's okay, it's okay, if you need maintenance on your weapon just drop by me!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Heerium";
                dia.text = "Huh? The shield you're carrying looks weird? It's not like yours used to do at all!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Klener";
                dia.text = "Ah! This shield was made for her by an alchemist named Vayne!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Heerium";
                dia.text = "Alchemist?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "Oh! What a coincidence Vayne!";
            }
            else if (tang == 13)
            {
                KlenerVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hi Klener! Looks like you're talking to someone close?";
            }
            else if (tang == 14)
            {
                HeeriumVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "That's right! This is Heerium, he is the only blacksmith in this town!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "What an honor! My name is Vayne!...";
            }
            else if (tang == 16)
            {
                KlenerVAR1.SetActive(false);
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Hahaha! I feel honored, you are the one who saved the field from the goblins that destroyed it back in the day, right?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes!... That's right...";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Uncle Heerium is still as funny as when we first met, right?";
            }
            else if (tang == 19)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Optimism is who he is.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Heerium";
                dia.text = "Oh! Maria and Alia with Vayne? Granted, the town's hero got two beauties like this haha!";
            }
            else if (tang == 21)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's not it, Heerium! We are just companions!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Heerium";
                dia.text = "Do you want to go on an adventure?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right! And we're looking for news about the Zexel temple.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Heerium";
                dia.text = "Temple of Zexel! Hmm, if that's the case, could you guys stop by my blacksmith shop first? I think we need some equipment!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes! If so, we'll drop by as soon as possible!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Heerium";
                dia.text = "Alright! See you again! Ah Maria, Alia! Do you two have anything to guide Vayne!";
            }
            else if (tang == 27)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Okay! Just let me!";
            }
            else if (tang >= 28)
            {
                CutscenesController.cus26 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Được thôi! Chúng ta lên đường tiếp nào!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Kế hoạch cứ tiếp tục hỏi thăm người dân trong thị trấn thôi sao Vayne?";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Em cũng không biết nữa nhưng tạm thời cứ như thế đi.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Giá như có một người hào phóng biết chút thông tin về ngôi đền thì cũng được rồi nhỉ!";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Hohhhhh! Chú Heeriummmm!";
            }
            else if (tang == 6)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Ohhh! Là Klener à! Dạo này chú không thấy cháu ghé thăm tiệm rèn của ta đấy hahaha!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "Dạo này cháu bận canh gác quá nên cũng không ghé chỗ chú như trước được.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Heerium";
                dia.text = "Không sao, không sao, nếu cháu cần bảo dưỡng vũ khí cứ ghé qua ta nhé!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Heerium";
                dia.text = "Huh? Chiếc khiên cháu đang mang theo trông lạ thế? Không giống cái của chú từng làm tý nào!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Klener";
                dia.text = "À! Tấm khiên này là được một nhà giả kim tên là Vayne làm cho cháu ấy!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Heerium";
                dia.text = "Nhà giả kim ư?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "Oh! Thật trùng hợp Vayne!";
            }
            else if (tang == 13)
            {
                KlenerVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chào cậu Klener! Có vẻ cậu đang nói chuyện với một người thân thiết nhỉ?";
            }
            else if (tang == 14)
            {
                HeeriumVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Đúng thế! Đây là chú Heerium, chú ấy là thợ rèn duy nhất ở thị trấn này đấy!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật vinh hạnh! Cháu tên là Vayne!...";
            }
            else if (tang == 16)
            {
                KlenerVAR1.SetActive(false);
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Hahaha! Ta cảm thấy vinh dự mới đúng, cháu chính là người đã cứu giúp đồng ruộng khỏi bọn goblin phá hoại ngày trước đúng không?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vâng!... Đúng thế ạ...";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chú Heerium vẫn vui tính như hồi mới gặp nhỉ?";
            }
            else if (tang == 19)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Lạc quan mới là con người của chú ấy.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Heerium";
                dia.text = "Ồ! Maria và Alia đi cùng Vayne đó ư? Công nhận anh hùng của thị trấn hốt được hai mỹ nhân như thế này haha!";
            }
            else if (tang == 21)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không phải thế đâu chú Heerium! Bọn cháu chỉ là người đồng hành thôi!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Heerium";
                dia.text = "Hể bọn cháu muốn đi phiêu lưu ư?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế ạ! Và bọn cháu đang tìm hiểu tin tức về ngôi đền Zexel.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Heerium";
                dia.text = "Ngôi đền Zexel ư! Hừm, nếu vậy trước đó các cháu ghé qua chỗ tiệm rèn của ta được chứ? Ta nghĩ bọn cháu cần được trang bị một số thứ đấy!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vâng! Nếu vậy bọn cháu sẽ ghé qua sớm nhất có thể!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Heerium";
                dia.text = "Được thôi! Hẹn gặp lại nhé! À Maria, Alia! Hai cháu có gì dẫn đường Vayne nhé!";
            }
            else if (tang == 27)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ok! Cứ để cho cháu!";
            }
            else if (tang >= 28)
            {
                CutscenesController.cus26 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
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
        CutscenesController.cus26 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}