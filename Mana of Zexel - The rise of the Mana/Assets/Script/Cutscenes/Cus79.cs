using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus79 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This land! I can feel a huge amount of mana!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right, I also feel a tremendous amount of energy here... but...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What's wrong, Vayne?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's just that we don't see any life here, the trees, the animals, all without what we see as a dead land.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Okay Vayne! Use the potion you used to revive the farmers' rice fields in Zexel town, I believe you can do it.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Interesting isn't it? I never thought using alchemy to reform the land.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "This... I'm not sure if it's possible because basically land that is damaged by physical factors can be restored easily but this land we still don't understand the cause. Why is this land dead?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "But it's also worth trying the elixir potion to revive the land. Alright let's try!";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Uhmmmm... Why do I feel like it hasn't changed at all?";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's not as easy as I thought it would be.";
            }
            else if (tang == 12)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "The land is still dry and the color of the earth is still crimson. The problem was why this land had so many mana sources but no life at all. It's absurd.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Somehow this land is dead but still retains a huge amount of mana energy.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "... I don't think so... Look down at the ground at your feet and release some mana there Vayne!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Is this really necessary? I see...";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Just do it, and you'll understand what I mean!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, ...";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 19)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "No way, is there something on this earth resonating with your mana?";
            }
            else if (tang == 20)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "That's what I mean, something is covering this land and absorbing our mana. Although it is not large, the mana we can feel is the mana being absorbed from this land.";
            }
            else if (tang == 21)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mana in this land is being absorbed but we don't feel anything.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "That's when we don't use mana.";
            }
            else if (tang == 23)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Then we'll find a way to get rid of what's haunting the ground. But what's the problem with that? I still don't understand.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "I'm not so sure about this, something that can absorb mana is definitely not trivial.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Vayne";
                dia.text = "I mean a form of mana energy greater than us.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Maria";
                dia.text = "Yes, this mana might belong to magicians.";
            }
            else if (tang == 27)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "A magician again? After all, what is a magician?";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's not good, I don't know anything about dark magic.";
            }
            else if (tang == 29)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Me too but if we can purify the dark magic then maybe we can revive the land.";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Vayne";
                dia.text = "An item that can purify magic?";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Maria";
                dia.text = "I've only heard some people in Zexel town talk about the legend of the cleansing water for quite some time, but I don't know if it's true?";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Vayne";
                dia.text = "If so, try visiting Mr. Is Lance sure he knows?";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Maria";
                dia.text = "I pray that my father doesn't get mad and gossip about this matter.";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Vayne";
                dia.text = "At least we have a clue! Let's go, let's go back to Zexel town.";
            }
            else if (tang == 35)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey, are you guys really ignoring me?";
            }
            else if (tang >= 36)
            {
                CutscenesController.cus79 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mảnh đất này! Chị có thể cảm nhận một nguồn mana rất lớn!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, em cũng cảm nhận được nguồn năng lượng vô cùng lớn ở đây... nhưng...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có chuyện gì sao Vayne?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chỉ là chúng ta không hề thấy sự sống nào tồn tại ở đây, cây cối, động vật, tất cả đều không có những gì chúng ta thấy là một mảnh đất chết.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Được rồi Vayne! Hãy dùng thứ thuốc cậu dùng để hồi sinh ruộng lúa của nông dân ở Zexel town đi, tớ tin là cậu có thể làm được.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thú vị nhỉ? Chị chưa từng nghĩ sử dụng giả kim thuật để cải cách ruộng đất lại đấy.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chuyện này... mình không chắc là có thể làm được không vì cơ bản việc đất đai bị hư hỏng do các yếu tố vật lý thì có thể phục hồi dễ dàng nhưng mảnh đất này thì chúng ta vẫn không hiểu nguyên nhân tại sao vùng đất này lại chết.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nhưng mà cũng đáng thể thử dùng elixir potion để hồi sinh mảnh đất. Được rồi hãy thử nào!";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Uhmmmm... Sao mình thấy nó như chưa thay đổi gì hết thế?";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ không dễ như mình nghĩ rồi.";
            }
            else if (tang == 12)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mảnh đất vẫn còn khô cằn và màu đất vẫn còn đỏ thẩm. Vấn đề là tại sao mảnh đất này lại có nhiều nguồn mana nhưng không hề có sự sống nào cả. Thật vô lý.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bằng cách nào đó mảnh đất này đã chết nhưng vẫn còn giữ được nguồn năng lượng mana cực lớn.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "... Chị không nghĩ thế... Nhìn xuống mặt đất dưới chân và thả lỏng một lượng mana xuống đó đi Vayne!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chuyện này thật sự cần thiết chứ? Em thấy...";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Cứ làm đi, rồi em sẽ hiểu ý chị!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi, ...";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 19)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không thể nào, mặt đất này có thứ gì đó đang cộng hưởng mana của em?";
            }
            else if (tang == 20)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đó là điều chị muốn nói, có thứ gì đó đang bao phủ khắp mảnh đất này và hấp thụ mana của chúng ta. Mặc dù không lớn tuy nhiên thứ mana chúng ta cảm nhận được chính là nguồn mana đang bị hấp thụ từ vùng đất này.";
            }
            else if (tang == 21)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mana ở vùng đất này đang bị hấp thụ nhưng chúng ta không có cảm giác gì hết.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "Đó là khi chúng ta không sử dụng mana thôi.";
            }
            else if (tang == 23)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vậy thì chúng ta tìm cách loại bỏ thứ đang ám vào mặt đất là được. Nhưng vấn đề thứ đó là gì? Em vẫn không hiểu được.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị không chắc về điều này lắm, thứ gì đó có thể hấp thụ mana thì chắc chắn không hề tầm thường.";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ý chị là một dạng năng lượng mana lớn hơn chúng ta.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế, mana này có thể thuộc về các ma pháp sư.";
            }
            else if (tang == 27)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Lại là ma pháp sư sao? Rốt cuộc ma pháp sư là gì thế?";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy thì không hay rồi, em không biết gì về các ma thuật hắc ám.";
            }
            else if (tang == 29)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị cũng thế nhưng nếu chúng ta có thể thanh tẩy ma thuật hắc ám đi thì may ra ta có thể hồi sinh được mảnh đất.";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Vayne";
                dia.text = "Một món đồ có thể thanh tẩy ma thuật ư?";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị chỉ nghe một số người ở thị Zexel nói về truyền thuyết nước thanh tẩy cũng khá lâu nhưng chị không biết có thật không?";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy hãy thử ghé thăm Mr. Lance chắc là ông ấy biết?";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị cầu mong là cha chị không bị đảng trí và nói nhảm về vấn đề này.";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ít ra chúng ta có manh mối là được! Đi thôi, hãy quay về thị trấn Zexel nào.";
            }
            else if (tang == 35)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này hai người tính lơ tôi thật đấy à?";
            }
            else if (tang >= 36)
            {
                CutscenesController.cus79 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
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
        CutscenesController.cus79 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Alta inferno");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}