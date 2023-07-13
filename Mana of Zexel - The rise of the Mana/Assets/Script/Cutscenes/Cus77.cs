using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus77 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, AsilaVAL1;
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
                AsilaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Alright! I will tell you what happened before and when our two villages were closed to the outside world.";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Asila";
                dia.text = "When our parents died, that was the ruler of both inferno volcano and inferno ice villages. Me and my brother Alasa are the next rulers.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Asila";
                dia.text = "Alasa and I used to get along well, when we became village chiefs, my brother and I both wanted to separate the independent land and only trade in goods. The work as well as the goods of the two sides are exchanged daily. Here we supply minerals and ores for heat-powered tools. Alasa will supply cold products such as ice and apparel.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Makes sense! Both villages use their strengths and weaknesses to help each other, but why are the two of them independent of each other?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Asila";
                dia.fontSize = 28;
                dia.text = "That's right! We thought that when the whole village combined the territory like my parents did before, it would be difficult to manage, so I thought it would be best to split it up. At that time, we also exported goods from both sides to other villages. However, since I am the only one in charge of the export items, as my brother's duty, I don't want my brother to do as much work as I do. But Alasa disagrees.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Asila";
                dia.fontSize = 30;
                dia.text = "However, Alasa wanted in return for the control of the land of alta inferno which is located to the west of both villages.";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Alta inferno? I have never heard of that land.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Asila";
                dia.text = "Of course the people outside our village don't know that. It is a fertile land used for farming and providing food for our two villages.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Asila";
                dia.text = "You know, my brother's personality is somewhat monopolistic, so I also accept letting his rule that fertile land. Until, one day...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Asila";
                dia.text = "Someone destroyed that land, making the crops in that land no longer exist. And the only person my brother suspects is me. I swore with honor that I did not do it and no one wanted to, but Alasa did not believe me.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "So the village you two had a conflict with.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Asila";
                dia.text = "My brother's distrust makes me very regretful about dividing the two villages like this. I wish my brother could understand and forgive me. Because of that, Alasa's export goods were also banned, and to avoid outside knowing about the conflict between the two villages, I cut off contact with the outside so that others wouldn't take advantage of the conflict between the two villages.";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "So it is. This is difficult to resolve if one party has lost the trust of the other.";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... So you will continue to live in isolation like this forever?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Asila";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia... this thing...";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "You think there's no way, but in fact you're running away from it. Your brother must have felt as sad as you!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Asila";
                dia.text = "My brother feels the same way?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Alia";
                dia.text = "Think if the land of alta inferno is restored then everything will be solved!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Asila";
                dia.text = "Restore the land?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Alia";
                dia.text = "That's right! Vayne once revived the rice crop for farmers in the town of Zexel. Nothing is impossible.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Asila";
                dia.text = "I don't think Alasa will believe this.";
            }
            else if (tang == 23)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "If so, we'll help you with this. We'll go there and tell your brother about the alta inferno reinstatement.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Asila";
                dia.text = "You... can you do it?";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia said I saved a fertile land once, I'll probably do it again. Alia, thanks for giving me the idea.";
            }
            else if (tang == 26)
            {
                AsilaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks like you can think too, Alia!";
            }
            else if (tang == 27)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nothing! But we have to convince the village chief Alasa first.";
            }
            else if (tang == 28)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm!";
            }
            else if (tang == 29)
            {
                MariaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "I thank you as well as count on you. Please help me solve this troublesome conflict!";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Vayne";
                dia.text = "Trust us, because if we can resolve the conflict we can convince the village chief Alasa to hand over Zexel's ice core.";
            }
            else if (tang >= 31)
            {
                CutscenesController.cus77 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        else
        {
            if (tang == 1)
            {
                AsilaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Được rồi! Ta sẽ kể những gì đã xảy ra trước và khi việc hai ngôi làng của bọn ta đóng cửa tiếp xúc với thế giới bên ngoài.";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Asila";
                dia.text = "Khi bố mẹ của chúng ta mất, tức là người cai quản cả hai ngôi làng ở inferno volcano và inferno ice. Ta và em trai Alasa là người cai quản kế tiếp.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Asila";
                dia.text = "Alasa và ta đã từng hòa thuận với nhau, lúc trở thành trưởng làng thì em trai ta và ta đều muốn chia cắt vùng đất ở độc lập chỉ được trao đổi kinh tế với hàng hóa thôi. Các công việc cũng như hàng hóa của hai bên đều được trao đổi hàng ngày. Ở đây bọn ta cung cấp khoáng sản và quặng cho các công cụ sử dụng năng lượng nhiệt. Còn Alasa sẽ cung cấp các sản phẩm lạnh như băng và đồ may mặc.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hợp lý nhỉ! Cả hai ngôi làng đều dùng điểm mạnh và điểm yếu để giúp đỡ nhau nhưng mà tại sao hai người là ở độc lập với nhau.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Asila";
                dia.fontSize = 28;
                dia.text = "Đúng thế! Chúng ta nghĩ rằng khi cả ngôi làng gộp chung lãnh thổ như ba mẹ ta làm trước đó sẽ khó quản lý nên ta nghĩ việc chia ra là tốt nhất. Lúc ấy bọn ta cũng có xuất khẩu các mặt hàng của hai bên cho các ngôi làng khác. Tuy nhiên vì ta lại là người duy nhất quản lý các mặt hàng xuất khẩu vì với bổn phận là anh trai ta không muốn em trai phải làm nhiều việc như ta. Nhưng Alasa lại không đồng ý.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Asila";
                dia.fontSize = 30;
                dia.text = "Tuy nhiên Alasa muốn đổi lại việc cai quản mảnh đất alta inferno tức nằm ở phía tây của cả hai ngôi làng.";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Alta inferno? Tôi chưa từng nghe gì về vùng đất đó.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Asila";
                dia.text = "Tất nhiên mấy người ở ngoài khu vực làng chúng ta không biết là phải. Đó là vùng đất màu mỡ dùng để trồng trọt nông nghiệp và cung cấp lương thực cho hai ngôi làng bọn ta.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Asila";
                dia.text = "Các ngươi biết đấy, tính của em ta có phần độc chiếm nên ta cũng chấp nhận việc cho nó cai quản vùng đất màu mỡ ấy. Cho đến khi, một ngày nọ...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Asila";
                dia.text = "Đã có ai đó phá hủy vùng đất đó khiến cho hoa màu ở vùng đất ấy không còn nữa. Và người duy nhất mà em trai ta nghi ngờ đó là ta. Ta thề với danh dự không phải do ta làm cũng như không ai muốn vậy hết nhưng Alasa không tin ta.";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thế nên ngôi làng hai người đã xảy ra xung đột với nhau.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Asila";
                dia.text = "Việc không có lòng tin của em trai khiến ta rất hối hận về việc phân chia hai làng như hiện giờ. Ước gì em trai ta có thể hiểu và tha thứ cho ta. Vì thế các nguồn hàng hóa xuất khẩu của Alasa cũng ngăn cấm, còn ta để tránh bên ngoài biết về xung đột giữa hai làng nên ta đã cắt đứt liên lạc với bên ngoài để không bị người khác lợi dụng mâu thuẫn của hai làng.";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thì ra là thế. Chuyện này khó mà giải quyết được nếu một bên đã mất lòng tin của nhau.";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Vậy là ông sẽ tiếp tục sống cô lập như thế này mãi mãi sao?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Asila";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia... chuyện này...";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ông cứ nghĩ rằng sẽ không có cách nhưng thực tế ông đang trốn chạy nó đó. Em trai ông chắc hẳn cũng cảm thấy buồn như ông!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Asila";
                dia.text = "Em trai ta cũng cảm giác như ta?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Alia";
                dia.text = "Hãy nghĩ xem nếu vùng đất alta inferno được phục hồi thì mọi chuyện sẽ được giải quyết mà!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Asila";
                dia.text = "Phục hồi lại mảnh đất?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Alia";
                dia.text = "Đúng thế! Vayne đã từng hồi sinh lại vụ lúa cho nông dân ở thị trấn Zexel. Không có gì là không thể.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Asila";
                dia.text = "Chuyện này ta nghĩ rằng Alasa sẽ không tin đâu.";
            }
            else if (tang == 23)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy chúng tôi sẽ giúp ngài trong chuyện này. Chúng tôi sẽ đến đó nói với em trai ông về chuyện phục hồi lại alta inferno.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Asila";
                dia.text = "Cậu... cậu có thể làm được ư?";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia đã từng nói tôi đã cứu được một mảnh đất màu mỡ một lần rồi, tôi chắc là sẽ làm lại lần hai. Alia, cảm ơn cậu đã cho tớ ý tưởng.";
            }
            else if (tang == 26)
            {
                AsilaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ em cũng biết suy nghĩ ghê nhỉ Alia?";
            }
            else if (tang == 27)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có gì đâu! Mà chúng ta phải thuyết phục được trưởng làng Alasa đã.";
            }
            else if (tang == 28)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm!";
            }
            else if (tang == 29)
            {
                MariaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ta cảm ơn cũng như trông cậy vào mấy đứa. Xin hãy giúp ta giải quyết mẫu thuẫn rắc rối này!";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ông hãy tin ở chúng tôi, vì nếu giải quyết được mâu thuẫn chúng tôi có thể thuyết phục trưởng làng Alasa giao cho lõi năng lượng băng của Zexel.";
            }
            else if (tang >= 31)
            {
                CutscenesController.cus77 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
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
        CutscenesController.cus77 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(6, false);
    }
}