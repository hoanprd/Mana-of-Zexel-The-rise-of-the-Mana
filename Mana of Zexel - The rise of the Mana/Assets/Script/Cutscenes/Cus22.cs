using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus22 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, KlenerVAL1, KlenerVAR1;
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
                dia.text = "Klener! The shield that accompanies you for your next journey is complete!";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "That fast! Unbelievable.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "I told you this is easy for me!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Alchemy is really cool. If you had come to this town earlier, everyone would be happy!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "There's no need to praise me so much! After all, without me, there's still Maria who's also an alchemist.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "I'll tell you. Maria has almost no interest in using alchemy to help the villagers like you!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "So she just uses alchemy for personal use?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Klener";
                dia.text = "Not really...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "So tired! Been wandering around town all day with no information about that temple.";
            }
            else if (tang == 10)
            {
                KlenerVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We still have time so stay calm.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Oh! You two are back! Let's take a break after all, it's been a long day.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Wouldn't you be disheartened if there was still no information about Zexel temple today?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Even so, I have another source of motivation to have fun! Right, Klener?";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Right... That's right!";
            }
            else if (tang == 15)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Huh? Why does this Klener look so confused as if something awkward just happened?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "It's nothing... It's just that I feel a little uncomfortable when... when I'm hungry!";
            }
            else if (tang == 17)
            {
                KlenerVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Heh?";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I admit I'm hungry! Hey Mr. Lance if you don't mind,...";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Wait, let me treat this meal. I haven't used alchemy to cook since then, have I?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Alia";
                dia.text = "Huh? Can alchemy cook?";
            }
            else if (tang == 21)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Interesting isn't it?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Of course alchemy can cook! Just like mixing spices into food!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "If you don't mind, I'll take a moment to make the specialty I usually make back home.";
            }
            else if (tang == 24)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's not a problem to wait! Isn't that right, Maria, Klener?";
            }
            else if (tang == 25)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Of course!";
            }
            else if (tang == 26)
            {
                MariaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Uhm, I'm free too.";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, everyone wait for me!";
            }
            else if (tang >= 28)
            {
                CutscenesController.cus22 = 1;
                ContainerController.ManaShield -= 1;
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
                dia.text = "Klener! Tấm khiên đồng hành cùng cậu cho những cuộc hành trình tiếp theo đã hoàn thành rồi này!";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Nhanh như vậy ư! Không thể tin được.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ đã bảo rồi chuyện này dễ đối với tớ thôi!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Thật sự giả kim thuật rất đỉnh. Nếu như cậu đến thị trấn này sớm hơn có vẻ mọi người sẽ hạnh phúc lắm!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không cần phải ca ngợi tớ đến thế đâu! Dù sao không có tớ thì vẫn có chị Maria cũng là một nhà giả kim mà.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "Tớ nói cho cậu biết. Maria hầu như không quan tâm đến việc dùng giả kim thuật để giúp người dân trong làng giống cậu đâu!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hả vậy chị ấy chỉ dùng giả kim thuật cho mục đích cá nhân thôi ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Klener";
                dia.text = "Not really...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Phù mệt thật! Cả ngày lưu lạc quanh thị trấn mà chả có thông tin gì về ngôi đền ấy.";
            }
            else if (tang == 10)
            {
                KlenerVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta vẫn còn thời gian mà nên cứ bình tĩnh.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Oh! Hai người quay về rồi à! Chúng ta nghỉ ngơi tý thôi dù sao hôm nay là một ngày dài mà.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Cậu không chán nản nếu ngày nay vẫn chưa có thông tin gì về ngôi đền Zexel ư?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cho dù thế nhưng tớ đã có nguồn động lực khác để vui vẻ rồi! Đúng không Klener?";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Đúng... Đúng thế!";
            }
            else if (tang == 15)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hể? Klener này sao nhìn mặt kiểu lúng túng thế bộ có chuyện gì khó xử vừa xảy ra à?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "Không có gì cả... Chỉ là em thấy hơi khó chịu khi... khi đói bụng thôi!";
            }
            else if (tang == 17)
            {
                KlenerVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Heh?";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Công nhận đói bụng thật! Này Mr. Lance nếu không phiền,...";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Khoan đã hãy để buổi ăn này tớ đãi cho. Từ lúc đến đây tớ vẫn chưa dùng giả kim thuật để nấu ăn nhỉ?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Alia";
                dia.text = "Hể? Giả kim thuật có thể nấu ăn ư?";
            }
            else if (tang == 21)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thú vị nhỉ?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tất nhiên giả kim thuật có thể nấu ăn được rồi! Cũng như việc trộn gia vị vào thức ăn thôi!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu không phiền tớ sẽ mất một chút thời gian để làm đặc sản của tớ thường làm khi ở quê nhà.";
            }
            else if (tang == 24)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chuyện chờ đợi không thành vấn đề đâu! Đúng không Maria, Klener?";
            }
            else if (tang == 25)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Tất nhiên rồi!";
            }
            else if (tang == 26)
            {
                MariaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Uhm, tớ cũng miễn bàn.";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi phiền mọi người đợi mình nhé!";
            }
            else if (tang >= 28)
            {
                CutscenesController.cus22 = 1;
                ContainerController.ManaShield -= 1;
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
        CutscenesController.cus22 = 1;
        ContainerController.ManaShield -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}