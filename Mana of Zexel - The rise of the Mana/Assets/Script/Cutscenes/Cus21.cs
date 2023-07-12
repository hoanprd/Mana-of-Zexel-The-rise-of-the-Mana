using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus21 : MonoBehaviour
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
                dia.text = "We're back at the pub! Are you all right, Klener?";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Uhm! I'm fine!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Is that true?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Really! It's ridiculous for a bodyguard to be seriously injured by a punch.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, I'm just a little nervous.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "It's okay, but I admit you're strong. Are all alchemists that strong?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Not really. Usually alchemists were only equipped with basic combat knowledge and used tools to fight.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Klener";
                dia.text = "That's it. I can see not only using the tool but you have a strange power emanating from the staff.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well that's called mana, usually alchemists must possess a hidden power called mana.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mana is not available to everyone, but it is extremely difficult to develop through practice, it is not only used in crafting but also in combat as a source of strength.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Klener";
                dia.text = "... I don't quite understand it either, but can mana be used as fighting power? Interesting!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Have you heard of mana before?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Klener";
                dia.text = "Yes, but actually, I just heard it from my grandfather.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Klener";
                dia.text = "My grandfather has seen things called mana but the people in town don't care.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "It seems this town used to have many alchemists, right?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "I don't know either... A lot of people say Zexel was the only one a hundred years ago is the time my grandfather was still alive.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Klener";
                dia.text = "But my grandfather passed it on to my father and me that there are still other alchemists.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "An unnamed alchemist? Why is that?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Klener";
                dia.text = "Anyway, that's just the story being told, what matters is the present.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right! By the way, if you don't mind I want to make you a new shield, okay?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Klener";
                dia.text = "No need! I owe you a lot too!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "No debt at all! I just wanted to make a special gift. After all, a bodyguard who doesn't have a shield to protect himself, how can he protect others?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Klener";
                dia.text = "To make a shield, it takes materials and effort, whether it's good or not is the problem.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "If I use alchemy everything will be quick! My cane is also made from alchemy easily so a shield would be easy.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Klener";
                dia.text = "If so, thanks a lot Vayne!";
            }
            else if (tang >= 26)
            {
                CutscenesController.cus21 = 1;
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
                dia.text = "Chúng ta đã quay về quán rượu rồi! Cậu vẫn ổn chứ Klener?";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Uhm! Tớ vẫn ổn!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có thật vậy không?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Thật mà! Một vệ sĩ mà bị trọng thương bởi một cú đấm thì thật nực cười.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi tớ chỉ hơi lo lắng tý thôi.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "Không sao đâu, mà công nhận cậu mạnh thật. Nhà giả kim nào cũng mạnh vậy ư?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cũng không hẳn thế. Thường nhà giả kim chỉ được trang bị những kiến thức chiến đấu cơ bản và sử dụng công cụ để chiến đấu.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Klener";
                dia.text = "Vậy ư. Tớ có thể thấy không chỉ dùng dụng cụ mà cậu có thứ sức mạnh rất lạ phóng ra từ cây trượng.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "À đó gọi là mana đó, thường các nhà giả kim đều phải sở hữu sức mạnh tiềm ẩn gọi là mana.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mana không phải ai cũng có sẵn mà phải qua luyện tập vô cùng khó để có thể phát huy được, nó không chỉ dùng trong việc chế tạo mà còn dùng trong chiến đấu như một nguồn sức mạnh.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Klener";
                dia.text = "... Tớ cũng không hiểu rõ lắm nhưng mana có thể dùng như sức mạnh để chiến đấu? Thật thú vị!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cậu từng nghe qua về mana rồi ư?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Klener";
                dia.text = "Đúng thế nhưng thật ra là tớ chỉ nghe ông tớ kể lại thôi.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ông tớ từng chứng kiến những thứ gọi là mana nhưng mọi người trong thị trấn lại không quan tâm.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Klener";
                dia.text = "Có vẻ thị trấn này ngày xưa có nhiều nhà giả kim nhỉ?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "Tớ cũng không biết nữa... Nhiều người nói Zexel là người duy nhất cách đây trăm năm trước tức là thời ông của tớ còn sống.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Klener";
                dia.text = "Nhưng ông của tớ từng truyền lại cho bố tớ và tớ là vẫn còn nhà giả kim khác.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Một nhà giả kim giấu tên ư? Tại sao lại thế nhỉ?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Klener";
                dia.text = "Dù sao thì đó chỉ là câu chuyện được kể lại thôi, quan trọng là hiện tại.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! À mà nếu không phiền tớ muốn làm cho cậu một chiếc khiên mới được chứ?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Klener";
                dia.text = "Thôi không cần đâu! Tớ nợ cậu cũng nhiều mà!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không nợ nần gì hết! Tớ chỉ muốn làm một món quà đặc biệt thôi. Dù sao một vệ sĩ không có tấm khiên bảo vệ chính mình thì sao bảo vệ người khác được chứ?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Klener";
                dia.text = "Để làm một tấm khiên thì tốn nguyên liệu và công sức chưa kể là tốt hay không là cả vấn đề.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu tớ dùng giả kim thuật mọi chuyện sẽ nhanh thôi! Cây gậy của tớ cũng làm từ giả kim thuật một cách dễ dàng thì một tấm khiên sẽ dễ thôi.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Klener";
                dia.text = "Nếu vậy thì cảm ơn cậu trước Vayne!";
            }
            else if (tang >= 26)
            {
                CutscenesController.cus21 = 1;
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
        CutscenesController.cus21 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}