using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus3 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaDAR1;
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
                AliaDAR1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We have arrived at Zexel town!";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thank you, Alia. Amazingly, this town is so bustling, the children look so happy.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Of course, I really like this town.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "So your hometown is here?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "... Well, it's not.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "So you come for a far place like me too?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Actually, I have amnesia and have been traveling in this town for over a year. I only remember my name.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "... That so sad.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "It's okay, I'm still happy to be here.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "But what did you come here for?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well, I'm here to find my dad. He is an adventurer and came here 1 year ago but he has not returned or sent any reply.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "So you came here to find his whereabouts?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes. Now I don't know where to get this information from.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "I know a good place to look for information. Go to the tavern where adventurers go.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's a good idea, I'll ask you to take me there.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Ok, no problem, the tavern is on the west side of town.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus3 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaDAR1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chúng ta đã đến thị trấn Zexel rồi đấy!";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn nha Alia. Thật thú vị, thị trấn này thật yên bình, trẻ con thì trong rất hạnh phúc.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Tất nhiên rồi, tớ cũng rất thích thị trấn này.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy là quê hương của cậu là ở đây luôn sao?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Chuyện đó thì không phải.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy cậu cũng đến từ một nơi rất xa như mình luôn ư?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Thật ra thì, mình đã bị mất trí nhớ và đã ở thị trấn này hơn một năm rồi. Những gì mà mình nhớ chỉ là tên của mình thôi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Xin lỗi đã nhắc đến nỗi buồn đó.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Không sao đâu, tớ vẫn vui vẻ khi được ở đây mà.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Nhưng mà cậu đến đây vì chuyện gì thế?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ đến đây để tìm cha của tớ. Ông ấy là một nhà phiêu lưu và nghe ông ấy đến đây một năm trước nhưng ông ấy vẫn chưa trở về nhà hay liên lạc gì với gia đình tớ cho đến bây giờ.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Vậy cậu đến đây để tìm kiếm tung tích của ông ấy ư?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế. Giờ tớ chả biết phải tìm kiếm từ đâu hết.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "Tớ biết một nơi tốt để tìm kiếm thông tin đấy. Hãy đến quán rượu nơi mà các nhà phiêu lưu hay đến.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ý hay đó, phiền cậu dẫn tớ đến đó được chứ.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Ok, không vấn đề gì, quán rượu ở phía tây thị trấn ấy.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus3 = 1;
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
        CutscenesController.cus3 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}
