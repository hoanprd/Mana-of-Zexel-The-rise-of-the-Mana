using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus17 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1, MrLanceVAR1, KlenerVAL1, KlenerVAR1;
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
                MrLanceVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Is everyone back? What's going on, why are you in such a hurry?";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Sir! Vayne's party had just stopped the iron golemn from entering the wishing forest.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "What? An iron golemn!";
            }
            else if (tang == 4)
            {
                KlenerVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You don't have to worry, we're almost done with it.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Oh, it's Maria, I miss you so much, you don't visit town very often these days, don't you?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "I've only been away from you for a month.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Come on, a month is long enough, what do you guys want to eat so that Mr. Lance here treats you to a hearty meal.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance, if you don't mind can you help me read the information you wrote about my father?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Oh, so you found that notebook? Alright let's take a look.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'm counting on you.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "By the way, Maria! Can't you read?";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Father! Don't ask like that in front of everyone...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "How come I'm old, my eyes are much worse than before!";
            }
            else if (tang == 14)
            {
                MrLanceVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                KlenerVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 17)
            {
                AliaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "It's okay, it's okay, I can still read it like that! Haha.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "(My God, it seems Mr. Lance knows that people can't read his handwriting)";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Oh I remember, it's Dante Dias, an adventurer who used to do many quests of this tavern to earn some money and get information to the temple of Zexel.";
            }
            else if (tang == 20)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Temple of Zexel?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Vayne";
                dia.text = "Where is that place?";
            }
            else if (tang == 22)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Looks like you're new so you haven't heard of Zexel's origins.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Zexel? What is that?";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Zexel is the name of an alchemist who lived in this town a hundred years ago. She is a very great person for stopping a monster that wants to destroy everything.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "That's why everyone built a temple and renamed this town Zexel.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Is that so! A powerful alchemist a hundred years ago.";
            }
            else if (tang == 27)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "That sounds surprising, right Vayne? I wish I could meet her too!";
            }
            else if (tang == 28)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Looks like I haven't been to that place yet.";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Alia";
                dia.text = "If Vayne wanted to go there, there would be a lot of interesting things, right?";
            }
            else if (tang == 31)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance do you have any information about that temple?";
            }
            else if (tang == 32)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "What we do know is that the temple is far from town and north of the inferno desert.";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Vayne";
                dia.text = "So it's hard to get there?";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Not only is the road dangerous, but there are a lot of monsters there. That's why people in the town don't go to that temple now, so they don't know anything about the temple.";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's strange why people at that time built their thrones in such a dangerous place?";
            }
            else if (tang == 36)
            {
                MrLanceVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I heard about that desert land that was once inhabited by a tribe, for some reason that tribe lost its habitat and suffered a sandstorm that buried the entire civilization in it. sand.";
            }
            else if (tang == 37)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay anyway I didn't come here empty-handed, I'll definitely cross the desert and head to the Zexel temple.";
            }
            else if (tang == 38)
            {
                MariaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "If that's the case, you need to be mentally prepared. You can ask the merchants around town to get more information.";
            }
            else if (tang == 39)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thanks Mr. Lance! Alright everyone, let's spread out and gather information!";
            }
            else if (tang >= 40)
            {
                CutscenesController.cus17 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                MrLanceVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Mọi người về rồi ư? Nãy có chuyện gì sao mọi người gấp gáp thế?";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Thưa ngài! Cả nhóm Vayne vừa ngăn chặn con golemn sắt tiến sâu vào wishing forest.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Gì cơ? Một con golemn sắt ư!";
            }
            else if (tang == 4)
            {
                KlenerVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cha không cần lo nữa đâu tụi con giải quyết gần xong rồi.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Ồ là Maria đó ư, cha nhớ con quá, dạo này con ít ghé thị trấn quá nhỉ?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Con chỉ mới xa cha một tháng thôi mà.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Thôi nào, một tháng là đủ lâu rồi, mọi người muốn ăn gì nào để Mr. Lance đây đãi một bữa thịnh soạn.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance, nếu không phiền chú có thể giúp cháu đọc nhưng thông tin mà chú đã viết về cha cháu chứ?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "À, thì ra cháu đã tìm ra cuốn sổ đó rồi ư? Được rồi để ta xem thử.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Trông cậy vào chú vậy.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Mà Maria à! Con không đọc được sao?";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Cha à! Đừng có hỏi như thế trước mặt mọi người chứ...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Sao thế cha đã già rồi, mắt cha đã kém hơn trước nhiều rồi!";
            }
            else if (tang == 14)
            {
                MrLanceVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 16)
            {
                KlenerVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 17)
            {
                AliaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Không sao, không sao, nhìn vậy chứ ta vẫn đọc được thôi! Haha.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "(Trời đất, có vẻ Mr. Lance biết là mọi người không thể đọc được chữ của chú ấy viết)";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "À ta nhớ rồi, là Dante Dias, một nhà thám hiểm từng làm nhiều nhiệm vụ của quán rượu này để kiếm chút tiền và thông tin đến ngôi đền thờ Zexel.";
            }
            else if (tang == 20)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đền thờ Zexel ư?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đó là nơi nào vậy?";
            }
            else if (tang == 22)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Có vẻ cháu là người mới nên chưa nghe về nguồn gốc của Zexel.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Zexel ư? Đó là gì thế?";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Zexel là tên của một nhà giả kim cách đây một trăm năm trước sinh sống tại thị trấn này. Cô ấy là một người rất vĩ đại vì đã ngăn chặn được một con quái vật muốn phá hủy mọi thứ.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Vậy nên mọi người đã đặt đền thờ cũng như đổi tên thị trấn này thành Zexel.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy ư! Một nhà giả kim mạnh mẽ một trăm năm trước à.";
            }
            else if (tang == 27)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nghe ngạc nhiên lắm đúng không Vayne? Mình ước gì cũng được gặp bà ấy!";
            }
            else if (tang == 28)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hình như em vẫn chưa qua chỗ ấy lần nào cả.";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Alia";
                dia.text = "Nếu Vayne muốn đến chỗ đó chắc sẽ có nhiều thứ thú vị lắm nhỉ?";
            }
            else if (tang == 31)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance ngài có thông tin gì về ngôi đền đó không?";
            }
            else if (tang == 32)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Những gì ta biết là ngôi đền ấy cách rất xa thị trấn và ở phía bắc của inferno desert.";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy là rất khó để đến đó ư?";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Không chỉ đường đi hiểm trở mà còn có rất nhiều quái vật ở đó. Chính vì thế hiện giờ người dân trong thị trấn không ai đến ngôi đền đó cả nên không biết thông tin gì về ngôi đền.";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Vayne";
                dia.text = "Kỳ lạ thật tại sao người dân thời đó lại xây ngôi đến tại nơi nguy hiểm như thế?";
            }
            else if (tang == 36)
            {
                MrLanceVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị từng nghe về vùng đất sa mạc ấy từng là nơi của một bộ tộc sinh sống, vì một lý do nào đó bộ tộc ấy đã mất nơi sinh sống và chịu phải trận bão cát khiến cả nền văn minh ấy chôn vùi trong cát.";
            }
            else if (tang == 37)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi dù sao mình đã đến đây không phải để quay về tay trắng, tôi nhất định sẽ băng qua sa mạc và tiến đến ngôi đền Zexel.";
            }
            else if (tang == 38)
            {
                MariaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Nếu vậy cháu cần phải chuẩn bị tinh thần thật tốt. Cháu có thể hỏi thăm những người dân buôn bán xung quanh thị trấn để lấy thêm thông tin vậy.";
            }
            else if (tang == 39)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cháu cảm ơn Mr. Lance! Được rồi mọi người hãy tản ra và thu thâp tin tức nào!";
            }
            else if (tang >= 40)
            {
                CutscenesController.cus17 = 1;
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
        CutscenesController.cus17 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}