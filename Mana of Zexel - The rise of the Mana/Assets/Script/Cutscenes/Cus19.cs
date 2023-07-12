using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus19 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, KlenerVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay Klener! I brought the items you requested!";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Thank you, you're really fast. I will definitely repay this favor.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's okay, I don't mind about gratitude, as long as it helps people.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "You're really kind, since coming to town you've helped a lot of people.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well, I said as long as everyone's happy it's fine.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "Okay then I don't want to bother you anymore.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Wait Klener! Are you planning to use these items to fight?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Klener";
                dia.text = "That's right!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Do you have an urgent mission? Needing a mana barrier, are you planning to fight golems?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Klener";
                dia.text = "Actually, I want to push the golems near the town and it's not a quest but I decide for myself.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "You should have said this sooner! Let me join you!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "But what about your investigation?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "I told you, as long as I help others I'm happy enough, my father must be proud of me for that too.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Klener";
                dia.text = "You're really nice! Thank you so much Vayne!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Shall we start at the wishing forest first?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "Okay! The two of us will protect the people of this town!";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus19 = 1;
                ContainerController.HealPotion -= 1;
                ContainerController.ManaCloth -= 1;
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
                dia.text = "Được rồi Klener! Tớ đã mang những vật phẩm cậu yêu cầu đây!";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Cảm ơn cậu, công nhận cậu làm nhanh thật. Tớ nhất định sẽ trả công ơn này.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không sao đâu, tớ không để bụng chuyện ơn nghĩa đâu, miễn sao giúp ích cho mọi người là được.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Công nhận cậu hiền thật, kể từ lúc đến thị trấn cậu đã giúp rất nhiều người.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thì tớ đã nói là miễn mọi người vui là được.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "Được rồi vậy tớ không muốn làm phiền cậu nữa.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mà khoan Klener! Cậu tính dùng những vật phẩm này để chiến đấu à?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Klener";
                dia.text = "Đúng thế!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cậu gặp phải nhiệm vụ gấp lắm ư? Cần cả màn chắn mana chẳng lẻ cậu định đánh nhau với golemn ư?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Klener";
                dia.text = "Thực ra thì tớ muốn đẩy lụi tụi golemn gần thị trấn và đây không phải là nhiệm vụ gì cả mà là tớ tự quyết định.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cậu nên nói điều này sớm hơn chứ! Để tớ gia nhập với cậu nào!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "Nhưng mà việc điều tra thông tin của cậu thì sao?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ bảo rồi, miễn là giúp đỡ người khác là mình đủ vui rồi, chắc hẳn cha tớ cũng tự hào tớ vì điều đó.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Klener";
                dia.text = "Cậu thật sự rất tốt! Cảm ơn cậu nhiều Vayne!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta sẽ bắt đầu ở khu rừng wishing trước được chứ?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "Được! Hai ta sẽ bảo vệ nhưng dân ở thị trấn này nào!";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus19 = 1;
                ContainerController.HealPotion -= 1;
                ContainerController.ManaCloth -= 1;
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
        CutscenesController.cus19 = 1;
        ContainerController.HealPotion -= 1;
        ContainerController.ManaCloth -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}