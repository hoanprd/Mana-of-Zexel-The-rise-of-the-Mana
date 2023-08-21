using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus137 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, ZaneVAR1;
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
                dia.text = "Zane! We have something to do with you!";
            }
            else if (tang == 2)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Oh, is the little one getting better? I'm surprised.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We will return you both capital and interest for harming innocent people.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahahahaha... it's too late... look at the resurrected Sicxalon.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "What monster is that!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Zane";
                dia.text = "Those two alchemists! You don't know how to use mana, this monster is what shows you the power of mana.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Zane";
                dia.text = "I can use mana to make this monster invade the world hahahaha...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Zane! Why do you want to invade the world like that! You can live a peaceful life with your mother Orina.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Zane";
                dia.text = "So you met my mother, is she still alive? Perhaps she already told you something about me, so I don't need to explain it anymore.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey Zane you think you'll be happy after taking revenge on this world?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahaha... that's right... good question! If you were me from the past then you would understand the pain I went through with this world.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Zane";
                dia.text = "Stupid people and mana too. They have destroyed my way of life, I will take their way back.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Zane";
                dia.text = "I won't let anyone suffer like me. A life hated by the world, I will destroy it!!!";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "If you live only by hatred, you will never understand the meaning of life. If you think I still hold grudges, then you are wrong, I came here to fight for them, not for personal selfishness.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "I don't care how miserable you live, all I know will defeat you, that's all.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Zane";
                dia.text = "Then my world won't contain you guys. Come and I'll give you a lesson for life.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus137 = 1;
                ContainerController.LoadingOpen = true;
                HPMPBarController.EIndex = 26;
                SceneManager.LoadScene("BSZane 1");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Zane! Bọn ta có chuyện cần tính xổ với ngươi đấy!";
            }
            else if (tang == 2)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Ta đang đợi các ngươi đến đấy, để xem nào các ngươi có gì cho ta vui nào.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Bọn ta sẽ trả lại ngươi cả vốn lẫn lãi vì đã hại người vô tội.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahahahaha... đã quá trễ... nhìn xem Sicxalon đã hồi sinh.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Con quái vật gì thế!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Zane";
                dia.text = "Hai đứa giả kim thuật kia! Bọn người không biết thế nào là sử dụng mana đâu, con quái vật này chính là thứ cho các ngươi chiêm ngưỡng sức mạnh mana là như thế nào.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Zane";
                dia.text = "Ta có thể dùng mana để khiển con quái vật này xâm chiếm cả thế giới hahahaha...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Zane! Tại sao ngươi lại muốn xâm chiếm thế giới như thế! Ngươi có thể sống một cuộc sống bình yên với mẹ Orina của ngươi mà.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Zane";
                dia.text = "Vậy là các ngươi đã gặp mẹ ta, bà ta còn sống ư? Có lẽ bà ta đã kể những gì về ta cho các ngươi biết rồi nên ta cũng không cần giải thích nữa.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này Zane ngươi nghĩ là sẽ hạnh phúc sau khi trả thù thế giới này ư?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahaha... đúng là... câu hỏi hay đấy! Nếu ngươi là ta ở quá khứ thì ngươi sẽ hiểu được nỗi đau mà ta đã trải qua với thế giới này.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Zane";
                dia.text = "Lũ người ngu ngốc và cả lũ mana kia nữa. Bọn chúng đã hủy hoại con đường sống của ta thì ta sẽ cướp lại con đường sống của chúng.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Zane";
                dia.text = "Ta sẽ không để ai phải đau khổ như ta. Một cuộc sống bị thế giới ghét bỏ thì ta sẽ hủy diệt nó!!!";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ngươi chỉ sống bằng hận thù thì sẽ không bao giờ hiểu được ý nghĩa của cuộc sống. Nếu như ngươi nghĩ ta vẫn còn hận thù thì sai rồi, ta đến đây để chiến đấu vì họ chứ không phải vì ích kỷ cá nhân.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ta không cần biết ngươi sống đau khổ như thế nào, những gì ta biết là sẽ đánh bại ngươi, chỉ vậy thôi.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Zane";
                dia.text = "Vậy thì thế giới của ta sẽ không tồn tại lũ người các ngươi. Tới đây và ta cho các ngươi một bài học nhớ đời.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus137 = 1;
                ContainerController.LoadingOpen = true;
                HPMPBarController.EIndex = 26;
                SceneManager.LoadScene("BSZane 1");
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
        CutscenesController.cus137 = 1;
        ContainerController.LoadingOpen = true;
        HPMPBarController.EIndex = 26;
        SceneManager.LoadScene("BSZane 1");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}