using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus83 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1, MrLanceVAR1;
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
                dia.text = "Success! Success! This is the magic purification potion!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That's amazing Vayne! Let's solve the remaining problem!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Not bad...";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Ah... yah... My back!";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Huh, Mr. Lance? What's wrong with your back?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "I don't know why I've been having back pain lately. Probably due to old age!";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "This... we have a solution for you because I know the recipe for back pain very well!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Really?";
            }
            else if (tang == 9)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne, You are tired of making a lot of things just now, let me take care of this!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, I'll take a break then.";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Okay, Dad, you can put this on your back!";
            }
            else if (tang == 13)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria! You know my back hurts so I can't...";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "You mean ask me to put some medicine on your back, don't you?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Hehe... that's right!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "No! There's no way I would do that in front of these two.";
            }
            else if (tang == 17)
            {
                MrLanceVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "If you don't mind we can go out...";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Are you faking it...";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Not really! Yah... it hurts...";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Maria";
                dia.text = "You two go out, my father just wants to lose face in front of you!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Hey... wait, I feel like my back pain is gone!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "Are you planning to run away? Let me show you what the filial piety of your daughter is.";
            }
            else if (tang == 23)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Yahhhhhhhhhh...";
            }
            else if (tang == 24)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "This is the first time I've seen such a scary Maria!";
            }
            else if (tang == 25)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Maybe we shouldn't touch her like that. Really scary!";
            }
            else if (tang >= 26)
            {
                CutscenesController.cus83 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Save room");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thành công! Thành công rồi! Đây chính là thuốc thanh tẩy ma thuật!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Thật tuyệt vời đó Vayne! Chúng ta mau giải quyết vấn đề còn lại nào!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Không tệ nhỉ...";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Ah... yah... Lưng của ta!";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hể, Mr Lance? Có vấn đề gì về lưng của ngài ư?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Không biết sao dạo này ta lại hay đau lưng. Chắc cỏ vẻ do tuổi già rồi!";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chuyện này... tụi cháu có giải pháp cho chú đấy vì cháu đã biết công thức thuốc trị đau lưng rất tốt!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Thật vậy ư?";
            }
            else if (tang == 9)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne, em đã mệt vì đã chế tạo nhiều thứ vừa rồi, hãy để chị giải quyết vấn đề này!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vâng, vậy thì em sẽ nghỉ ngơi một lát vậy.";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Được rồi, cha hãy bôi thứ này lên lưng là được!";
            }
            else if (tang == 13)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria à! Con biết ta đang đau lưng nên không thể...";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Ý cha là kêu con bôi thuốc lên lưng giúp cha chứ gì?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Hehe... đúng thế đấy!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Không! Không đời nào con lại làm thế trước mặt hai đứa này.";
            }
            else if (tang == 17)
            {
                MrLanceVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nếu không phiền tụi em có thể ra ngoài...";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Cha đang giả bộ đúng không...";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Đâu hẳn thế! Yah... đau thật...";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Maria";
                dia.text = "Hai đứa ra ngoài đi, cha chị chỉ muốn cho mất mặt trước hai đứa thôi!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Này... khoan đã, ta cảm giác như đã hết đau lưng rồi!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "Cha tính chuồn đấy à? Để con cho cha thấy thế nào là báo hiếu của con gái bố.";
            }
            else if (tang == 23)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAR1.SetActive(false);
                NameTagText.text = "Mr. Lance";
                dia.text = "Yahhhhhhhhhh...";
            }
            else if (tang == 24)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đây là lần đầu tiên mình lại thấy chị Maria đáng sợ như vậy!";
            }
            else if (tang == 25)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có lẽ chúng ta không nên động chạm chị ấy như thế. Đáng sợ thật!";
            }
            else if (tang >= 26)
            {
                CutscenesController.cus83 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Save room");
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
        CutscenesController.cus83 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Save room");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(0, false);
    }
}