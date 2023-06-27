using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus141 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, ManaElfVAL1;
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
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "This is Sicxalon's soul...";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right! I hope you can transform this soul into someone who can help the world in the future, okay?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mana elf";
                dia.text = "I see, very smart choice. We will take care of the rest and on behalf of the other mana I sincerely thank everyone.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "May I ask how many of you will know this ending? Even the fact that Maria sacrificed her life and you guys did nothing?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mana elf";
                dia.text = "It's really beyond our expectations. What we do know is that we believe in the people who will defeat Sicxalon and bring back its inherent peace.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana elf";
                dia.text = "We are really sorry for everyone's sacrifice. From now on we won't come into contact with your world to avoid the unfortunate incident in the past.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay,... looks like my job is done.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mana elf";
                dia.text = "It's over but you won't stop thinking about the past right?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "(The battle is really over, but the journey isn't over yet...)";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "It seems so, from now on I will live the life I choose. Being an alchemist like my parents once believed in me and I will not tolerate people who use mana or anything related to do evil.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Mana elf";
                dia.text = "We are very pleased to meet an alchemist like you Vayne! Best of luck on the rest of your journey!";
            }
            else if (tang >= 12)
            {
                CutscenesController.cus141 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Đây là linh hồn của Sicxalon...";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Tôi mong rằng các vị có thể hóa kiếp linh hồn này trở thành một người có thể giúp ích cho thế giới sau này được chứ?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Ta đã hiểu, sự lựa chọn rất thông minh. Bọn ta sẽ lo phần còn lại và thay mặt các mana khác ta chân thành cảm ơn mọi người.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cho tôi hỏi là mấy người sẽ biết trước kết cục này ư? Kể cả việc Maria hy sinh mạng sống cô ấy và các người không làm gì ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Chuyện thật sự nằm ngoài dự đoán của chúng ta. Những gì bọn ta biết là tin tưởng vào mấy người sẽ đánh bại được Sicxalon và mang lại sự bình yên vốn có.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Chúng tôi thật sự rất tiếc cho sự hy sinh của mọi người. Từ giờ chúng tôi sẽ không tiếp xúc với thế giới của mấy người để tránh sự việc đáng tiếc xảy ra trong quá khứ.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi,... có vẻ việc của tôi đã hết rồi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Cho mọi chuyện đã kết thúc nhưng cậu sẽ không dừng bước suy nghĩ về quá khứ đúng không?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "(Trận chiến đã thực sự kết thúc rồi nhưng mà cuộc hành trình này vẫn chưa dừng lại được...)";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ là thế, từ giờ tôi sẽ sống một cuộc sống mà tôi chọn. Trở thành một nhà giả kim như ba mẹ tôi đã từng tin tưởng vào tôi cũng như tôi sẽ không tha cho những kẻ sử dụng mana hoặc bất cứ thứ gì liên quan để làm việc xấu xa.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Chúng tôi rất hân hạnh khi được gặp một nhà giả kim như cậu đấy Vayne! Chúc thượng lộ bình an trên chặng đường còn lại!";
            }
            else if (tang >= 12)
            {
                CutscenesController.cus141 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus141 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana temple");
    }
}