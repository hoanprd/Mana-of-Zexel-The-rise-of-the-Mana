using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus102 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAR1;
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
                dia.text = "...";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Are you still thinking about that Zane?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm... I'm really confused. Even after this, what will you do next?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Surely you never thought your father would be proud of you for anything, right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "What do you mean?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Before my mother passed away, I tried to do everything to make my mother proud so she could rest in peace.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Surely you have to do something to make your father proud, even if he's in heaven, he's happy.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "But that magician Zane, what is he planning to do? Was his goal merely Zexel's mana core stored in the temple?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "I don't know, but if Sicxalon's seal is broken it won't be good.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'm not going to let this go, not just for my father's sake but for Alia and everyone else. I won't let that Zane do evil things.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Did the mana gods say we're heroes? Is it fate or...";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Hey, are you two out there? It's time to eat!";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes, we'll be right in.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus102 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em vẫn còn trầm tư về tên Zane đó ư?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm... Em thật sự rất bối rối. Kể cả sau việc này, em sẽ làm gì tiếp theo.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Chắc hẳn em chưa từng nghĩ cha em sẽ tự hào em vì điều gì đúng không?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ý chị là sao?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Trước khi mẹ chị qua đời, chị đã cố gắng làm mọi thứ để mẹ của chị tự hào để bà ấy có thể yên nghỉ.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Chắc hẳn em cũng phải làm điều gì đó cho cha tự hào kể cả ông ấy đang ở trên thiên đường cũng thấy hạnh phúc.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nhưng mà tên ma pháp sư Zane đó, hắn tính làm chuyện gì thế? Mục tiêu của hắn đơn thuần là lõi năng lượng mana của Zexel được cất giữ trong ngôi đền thôi ư?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị không biết, nhưng nếu như phong ấn của Sicxalon bị phá vỡ chắc hẳn điều đó sẽ không tốt.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em sẽ không để yên chuyện này đâu, không chỉ vì cha em mà còn vì Alia và mọi người. Em sẽ không để tên Zane đó lộng hành những chuyện xấu xa đâu.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Nhắc mới nhớ, các vị thần mana đã nói chúng ta là anh hùng ư? Liệu rằng đó có phải là số phận hay là...";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Này hai đứa đang ở ngoài đó à? Đến giờ ăn rồi đó!";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vâng bọn cháu vô liền.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus102 = 1;
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
        CutscenesController.cus102 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(6, false);
    }
}