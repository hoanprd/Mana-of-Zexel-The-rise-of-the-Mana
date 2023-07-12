using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus41 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ZexelVAL1;
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
                dia.text = "Here it is! The Zexel Gate? It looks really big, not only that, I can feel something huge behind this gate.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right! A huge source of magic power. But the question is, how can we get through this gate?";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Don't worry, we can climb over it. Take a look here!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Hyaaaaaaa... Come on!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Wait Alia! There's a boundary!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "What! Ahhhhhhhhh...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia! You okay Alia?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm... I'm fine, luckily I haven't put all my strength into it yet.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This barrier isn't easy to break. I've never seen a barrier cover like this continuously.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "So if we break the barrier it will regenerate automatically?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right! Perhaps the gate will give us a way to unlock it.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Let me see.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What are you planning to do Vayne?";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "Dear power of mana, lead the way! Show me the way to go!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "";
                dia.text = "Glowing....";
            }
            else if (tang == 16)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is the gate reacting?";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Does it work! Who is that?";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                ZexelVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "...";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Who are you?";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "This woman...";
            }
            else if (tang == 21)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I can feel a small amount of spiritual energy in her. Is that an illusion?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Zexel";
                dia.text = "Welcome! My name is Zexel, who is sleeping peacefully behind the gate inside the temple.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Zexel";
                dia.text = "Only those who are worthy can pass through this gate.";
            }
            else if (tang == 24)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "How worthy are these people to deserve?";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Zexel";
                dia.text = "To become worthy if and only if one can break the two polar opposites and bring back peace.";
            }
            else if (tang == 26)
            {
                ZexelVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Gone, what does that last sentence mean?";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Vayne";
                dia.text = "Are you kidding me? In the end, we don't know anything.";
            }
            else if (tang == 28)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "(That woman, it feels so familiar in my heart...)";
            }
            else if (tang == 29)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Let's go back to town.";
            }
            else if (tang == 30)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Do you have any ideas?";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Vayne";
                dia.text = "I don't know but there's a way.";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Maria";
                dia.text = "Okay, then we'll go home. Hey Alia, are you all right?";
            }
            else if (tang == 33)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I'm fine! Wait for me!";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Alia";
                dia.text = "(Zexel? Not strange but very familiar?)";
            }
            else if (tang >= 35)
            {
                CutscenesController.cus41 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel gate");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đây là! Cánh cổng Zexel ư? Trông lớn thật, không chỉ thế, mình có thể cảm nhận thứ gì đó rất lớn đằng sau cánh cổng này.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Một nguồn ma lực rất lớn. Nhưng vấn đề là sao chúng ta có thể đi qua cánh cổng này?";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đừng lo, chúng ta có thể trèo qua nó mà. Hãy xem đây!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Hyaaaaaaaaa... Lên nào!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Khoan đã Alia! Có kết giới đấy!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Cái gì! Ahhhhhhhhh...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia! Không sao chứ Alia!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm... Mình không sao, hên là mình vẫn chưa dốc toàn lực lao vào.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Lớp kết giới này không đơn giản để phá đâu. Chị chưa từng thấy lớp kết giới bao phủ liên tục thế này.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tức là chúng ta có phá kết giới nó sẽ tự động tái tạo lại ư?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế! Có lẽ cánh cổng sẽ cho chúng ta cách để mở khóa.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Để mình xem thử.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Cậu tính làm gì thế Vayne?";
            }
            else if (tang == 14)
            {
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "Hỡi sức mạnh của mana, hãy dẫn lối! Cho ta thấy được con đường để đi!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "";
                dia.text = "Glowing....";
            }
            else if (tang == 16)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cánh cổng đang có phản ứng ư?";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Có hiệu quả sao! Đó là?";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                ZexelVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "...";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ai thế?";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Người phụ nữ này...";
            }
            else if (tang == 21)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mình có thể cảm thấy được một nguồn linh lực cũng không lớn lắm đang tồn tại trong cô ta. Đó là ảo ảnh ư?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Zexel";
                dia.text = "Kính chào! Tôi tên là Zexel, người được ngủ yên đằng sau cánh cổng bên trong ngôi đền.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Zexel";
                dia.text = "Chỉ có những người xứng đáng mới được bước quả cánh cổng này.";
            }
            else if (tang == 24)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Những người xứng đáng như thế nào để xứng đáng đây?";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Zexel";
                dia.text = "Để trở nên xứng đáng khi và chỉ khi người đó có thể phá giải hai thái cực đối lập và mang về sự bình yên.";
            }
            else if (tang == 26)
            {
                ZexelVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Biến mất rồi, rốt cuộc câu nói vừa rồi có ý nghĩa gì?";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đùa mình ư? Rốt cuộc chả biết gì hết.";
            }
            else if (tang == 28)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "(Người phụ nữ đó, cảm giác thật thân thuộc trong lòng mình...)";
            }
            else if (tang == 29)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Chúng ta quay về thị trấn thôi.";
            }
            else if (tang == 30)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em có ý tưởng gì chăng?";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em không biết nhưng chắc sẽ có cách.";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Maria";
                dia.text = "Được thôi, nếu vậy thì chúng ta về. Này Alia, vẫn ổn chứ?";
            }
            else if (tang == 33)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vâng! Đợi em với!";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Alia";
                dia.text = "(Zexel ư? Cũng không lạ nhưng lại rất quen thuộc ư?)";
            }
            else if (tang >= 35)
            {
                CutscenesController.cus41 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel gate");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 4)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 8)
        {
            cc.BGMCutscenes(2, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus41 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel gate");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}