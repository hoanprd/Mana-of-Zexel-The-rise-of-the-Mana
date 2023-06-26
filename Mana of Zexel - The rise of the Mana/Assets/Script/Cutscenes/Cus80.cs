using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus80 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1;
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
                dia.text = "Oh, you guys come back here to rest? Be comfortable!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Dad, we have something to ask this time!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Well, okay. Is there something difficult that you need us for?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "It's about the purifying water legend that I heard from a young age.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Purifying water? Is it just a word of mouth?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "It was you who told me about it!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance, can you retell that legend? May be useful for us!";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Okay, in that case we'll start.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "A long time ago when mana gods still existed and co-existed with humans.";
            }
            else if (tang == 10)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(So the mana god is telling the truth that humans used to live with mana?)";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "At that time magicians were considered a threat to mana, the war of magicians broke out, causing villages and people to be affected by dark magic.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "To avoid this loss, there was a mana who tried to find an antidote to humans because they were innocent in the war.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "That mana god has found a source of water that can produce purifying water, water that can remove dark magic. Thanks to that, the lands and innocent people are peaceful again.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "According to the story, the source of water was found in the Wishing forest.";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Unbelievable, were magicians so cruel at that time?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "That's what I heard from previous generations, but I don't know the truth. And no one cares about that legend anymore because there are no magicians anymore.";
            }
            else if (tang == 17)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We encountered a kind of dark magic ravaging a land of inferno volcano and inferno ice.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Have we been there already?";
            }
            else if (tang == 19)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes, but there is a cold war there, the best way to resolve the conflict between the two sides is to remove the dark magic in that land and revive that land.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "So that's it, didn't expect dark magic to still exist.";
            }
            else if (tang == 21)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "At least we'll have a quest for purifying water in the Wishing forest!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Good luck guys.";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus80 = 1;
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
                dia.text = "Ồ mấy đứa quay về đây nghỉ ngơi à? Hãy thoải mái nhé!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cha à, lần này tụi con có chuyện cần hỏi đấy!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "À, được thôi. Có chuyện gì khó khăn mà tụi con cần ta à?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Đó là về truyền thuyết nước thanh tẩy mà con nghe từ nhỏ.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Nước thanh tẩy ư? Chẳng lẽ đó chỉ là tin đồn qua miệng thôi ư?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Chính cha là người kể cho con nghe đó!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance, ông có thể kể lại truyền thuyết đó không ạ? Biết đâu có ích cho bọn cháu!";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Được thôi, nếu vậy thì ta sẽ bắt đầu.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Từ rất lâu về trước khi mà các vị thần mana vẫn còn tồn tại và sống chung với con người.";
            }
            else if (tang == 10)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(Vậy là mana god đang nói sự thật là con người từng sống chung với mana ư?)";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Khi ấy các ma pháp sư được xem là một mối nguy hại cho các mana, cuộc chiến của các ma pháp sư nổ ra khiến cho các làng mạc và con người bị dính phải các ma thuật hắc ám.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Để tránh sự tổn thất này, đã có một vị mana ra sức truy tìm thuốc giải cho con người vì họ là những người vô tội trong cuộc chiến.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Vị thần mana đó đã tìm ra một nguồn nước có thể tạo ra nước thanh tẩy, thứ nước có thể loại bỏ ma thuật hắc ám. Cũng nhờ thế mà những mảnh đất và người vô tội mới yên lành trở lại.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Theo như lời kể thì nguồn nước ấy được tìm thấy ở Wishing forest.";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Không thể tin được, ma pháp sư họ rất độc ác vào thời điểm đó sao?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Đó những gì mà ta nghe thế hệ trước kể lại thôi còn sự thật thế nào ta cũng không biết. Và cũng không ai quan tâm đến truyền thuyết đó nữa vì giờ đâu còn ma pháp sư nào nữa.";
            }
            else if (tang == 17)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Tụi con đã gặp phải một loại ma thuật hắc ám đang tàn phá một mảnh đất của inferno volcano và inferno ice.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Tụi con đã đến nơi đó rồi à?";
            }
            else if (tang == 19)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes, but there is a cold war there, the best way to resolve the conflict between the two sides is to remove the dark magic in that land and revive that land.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Ra là thế, không ngờ bây giờ vẫn còn ma thuật hắc ám tồn tại đấy.";
            }
            else if (tang == 21)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ít ra bọn cháu sẽ có một cuộc dò tìm nước thanh tẩy ở Wishing forest xem sao!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Chúc mấy đứa may mắn.";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus80 = 1;
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
        CutscenesController.cus80 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}