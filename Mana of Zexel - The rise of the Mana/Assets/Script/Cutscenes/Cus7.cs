using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus7 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MrLanceVAR1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mr. Lance, we've taken the goblins down.";
            }
            else if (tang == 2)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "I don't know how to thank you both enough. You two did a great job! I will reward you two with 100 Zen.";
            }
            else if (tang == 3)
            {
                NameTag.SetActive(false);
                dia.text = "Get 100 Zen!";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Anyway, did you find out my father's information Mr. Lance?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "I'm sorry, but I still haven't found the book containing your father's information.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "But I think that book might be at my old house, where my daughter is now.";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "You mean Maria's current residence?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "My old house is deep in the wishing forest. Maria was also there to study alchemy.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What a hardworking person like her.";
            }
            else if (tang == 10)
            {
                MrLanceVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Of course Vayne! She's very good, compared to her, you're just a chicken!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Just kidding, anyway I want to see Maria again, it's been a while since I've seen her.";
            }
            else if (tang == 13)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Be careful you two! That forest is very dangerous!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'll consider your advice, then let's go, Alia!";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ok!";
            }
            else if (tang == 16)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Those two are so passionate, hehe. Good luck both.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus7 = 1;
                Global.Zen += 100;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chú Lance, bọn cháu đã xử lý xong bọn yêu tinh rồi.";
            }
            else if (tang == 2)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Chú không biết phải cảm ơn như thế nào cho đủ. Cả hai đã làm rất tốt! Chú sẽ tưởng cho hai đứa 100 Zen.";
            }
            else if (tang == 3)
            {
                NameTag.SetActive(false);
                dia.text = "Nhận được 100 Zen!";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Dù sao thì chú đã tìm tung tích của cha cháu chưa?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Chú xin lỗi, chú vẫn chưa thấy cuốn sổ nào chứa thông tin về ba cháu.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Nhưng ta nghĩ cuốn sổ đó có thể đang ở nhà cũ của chú, nơi mà con gái chú đang sống.";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ý chú là nơi ở hiện tại của chị Maria ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Nhà cũ của chú ở sâu trong khu rừng ước nguyện. Maria ở đó để học tập kỹ năng giả kim của nó.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nghe như là một người vô cùng chăm chỉ nhỉ.";
            }
            else if (tang == 10)
            {
                MrLanceVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tất nhiên rồi Vayne! Chị ấy rất giỏi đó, so với cô ấy, cậu còn gà lắm!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Chỉ đùa thôi, dù sao thì tớ cũng muốn gặp lại chị Maria, đã một thời gian rồi tớ chưa gặp mặt chị ấy.";
            }
            else if (tang == 13)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Hãy cẩn thận nhé hai đứa! Khu rừng đó rất nguy hiểm đấy!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cháu đã ghi nhớ lời dặn đó, đến lúc đi thôi Alia!";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ok!";
            }
            else if (tang == 16)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Cả hai thật là năng động nhỉ? Chúc may mắn nhé cả hai.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus7 = 1;
                Global.Zen += 100;
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
        CutscenesController.cus7 = 1;
        ContainerController.LoadingOpen = true;
        if (tang >=17)
            SceneManager.LoadScene("Tavern");
        else
        {
            Global.Zen += 100;
            SceneManager.LoadScene("Tavern");
        }
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}
