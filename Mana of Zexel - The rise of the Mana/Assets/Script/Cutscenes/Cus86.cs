using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus86 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, AlasaVAL1, AlasaVAR1;
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
                AlasaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Ah Vayne! You're here, according to what I should do it seems to give you Zexel's ice energy core right?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes sir, so the front energy core is Zexel's ice energy core? I can feel the mana source from it.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alasa";
                dia.text = "Hahaha, that's right, not bad right? You really are a talented alchemist! So I think this energy core belongs to you.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "But if I take it, what will happen to this village?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alasa";
                dia.text = "The glacial climate will simply become colder than usual, which will cause the villagers to move to the inferno volcano or alta inferno to live.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "Sadly, we can't make use of the resources in this land of inferno ice anymore.";
            }
            else if (tang == 7)
            {
                AlasaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You don't have to worry about this, village head Alasa, Vayne can easily clone Zexel's ice energy core like when he saved Asila's village from the volcanic eruption.";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That's right! Vayne is very good at these things!";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Come on guys, I'm not that good, it's all down to luck.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Can you really make a copy of the ice energy core?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "I have to do it to see the results...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alasa";
                dia.text = "I see, I've given you the energy core anyway so make good use of it.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'll do my best.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus86 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
            }
        }
        else
        {
            if (tang == 1)
            {
                AlasaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "À Vayne! Cậu đến rồi, theo những gì ta nên làm có vẻ đưa cho cậu lõi năng lượng băng của Zexel có đúng không?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng vậy thưa trưởng làng, vậy là lõi năng lượng phía trước chính là lõi năng lượng băng của Zexel ư? Tôi có thể cảm nhận được nguồn mana từ nó.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alasa";
                dia.text = "Hahaha, đúng vậy, không tệ nhỉ? Cậu đúng là một nhà giả kim tài ba đấy! Vì thế tôi nghĩ lõi năng lượng này thuộc về cậu.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nhưng mà nếu tôi lấy nó thì sẽ xảy ra chuyện gì với ngôi làng này?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đơn giản khí hậu băng sẽ trở nên lạnh hơn so với bình thường, điều này sẽ khiến người dân trong làng đành phải di chuyển sang inferno volcano hoặc alta inferno để sinh sống.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đáng buồn hơn là bọn ta không thể tận dụng tài nguyên ở vùng đất inferno ice này nữa.";
            }
            else if (tang == 7)
            {
                AlasaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chuyện này ngài không cần lo đâu trưởng làng Alasa, Vayne có thể dễ dàng nhân bản lõi năng lượng băng của Zexel như lúc cậu ấy cứu ngôi làng của Asila trước sự phun trào của núi lửa.";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đúng thế! Vayne rất giỏi trong mấy chuyện này đó nhé!";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thôi nào mấy cậu, tớ không giỏi đến cỡ thế đâu, tất cả cũng nhờ vào may mắn thôi.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Thật là cậu có thể tạo một bản sao của lõi năng lượng băng chứ?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tôi phải làm thì mới biết được kết quả...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alasa";
                dia.text = "Ta hiểu rồi, dù sao ta cũng giao lõi năng lượng cho cậu rồi nên hãy tận dụng nó tốt.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tôi sẽ cố gắng hết sức.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus86 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus86 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }
}