using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus97 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAL1, MariaVAR1, MeruVAR1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

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
                dia.text = "Mrs. Meru! We have already brought enough ingredients!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "It's good, she's just passed the dangerous stage but this still can't stop the poison from spreading.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is Alia still in a coma? Is this situation really okay?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Meru";
                dia.text = "I warn you that if you want to save Alia, you will need dragon mana scales to push out the amount of dark magic clinging to her body.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "But where can you get mana dragon scales?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Meru";
                dia.text = "This is... I don't know. They are almost extinc";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Do we have no other choice?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Meru";
                dia.text = "I'm afraid so, what I did with these ingredients was just to stop the wound's spread from slowing down.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Meru";
                dia.text = "If I want to save Alia, I think I have to find the mana dragon scales.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Maria, let's go ask Orina, I think she'll know what to do.";
            }
            else if (tang == 11)
            {
                MeruVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Oh, that's fine.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Alia";
                dia.text = "Uhhh...";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia try harder, I still owe you this life...";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus97 = 1;
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
                dia.text = "Bà Meru! Bọn cháu đã mang đủ nguyên liệu rồi ạ!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Tốt lắm, con bé cũng vừa qua giai đoạn nguy hiểm tuy nhiên điều này vẫn không thể ngăn vết độc ngừng lan ra.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Alia vẫn còn hôn mê ư? Tình hình này thật sự ổn chứ?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Meru";
                dia.text = "Ta báo trước là nếu muốn cứu được Alia thì cần có vảy rồng mana để có thể đẩy lượng ma thuật hắc ám đang bám vào người con bé ra ngoài.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nhưng mà vảy rồng mana cháu có thể kiếm ở đâu chứ?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Meru";
                dia.text = "Chuyện này thì... ta không biết. Hầu như bọn chúng đã tuyệt chủng rồi.";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta không còn cách nào khác ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Meru";
                dia.text = "Ta e là thế, những gì ta làm với đống nguyên liệu này chỉ để ngăn chặn tốc độ lây lan của vết thương chậm đi thôi.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Meru";
                dia.text = "Nếu muốn cứu Alia ta nghĩ phải tìm được vảy rồng mana.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chị Maria, chúng ta hãy qua hỏi thử Orina, em nghĩ rằng chị ta sẽ biết phải làm gì.";
            }
            else if (tang == 11)
            {
                MeruVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ồ, cũng được nhỉ.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Alia";
                dia.text = "Uhhh...";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia hãy cố gắng lên, tớ vẫn còn nợ cậu cái mạng này...";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus97 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus97 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}