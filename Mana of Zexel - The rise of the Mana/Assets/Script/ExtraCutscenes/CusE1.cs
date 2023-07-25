using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CusE1 : MonoBehaviour
{
    ExtraCutscenesController ecc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        ecc = FindObjectOfType<ExtraCutscenesController>();
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
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey Vayne, what are you thinking about so much?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "No big deal... Just the view from this hill is majestic.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Hmm, that's all?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "I come here every day and see Zexel town from above.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Haha, ...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "What's so funny?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "I just see the two of us with different backgrounds, I live in the suburbs near the capital of the land of Zorth.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Is there a much better view there than here?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Beauty is also beautiful but beauty there and here are completely different.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Different? Specifically how?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "In the very bustling capital, many people come and go from many different lands to trade goods, so everyone is busy.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Busy until dusk, when the bustle disappears and everything starts to light up at night for people in the capital to walk around.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "Really? Are you busy every day and go out for a walk in the capital every night?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "I only go to the capital for the weekend, basically my life is quite similar to the people in Zexel town.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "And yet I'm already homesick!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alia";
                dia.text = "I really want to visit where Vayne lives.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "You can come with me after this is over. But I said before that it will be very far, don't get discouraged in the middle of the way!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Alia";
                dia.text = "If you think like that, it's no different from treating me like a child.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Huh? Not really!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Alia";
                dia.text = "Well, I'll go back to town first.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Wait for me!";
            }
            else if (tang >= 23)
            {
                ExtraCutscenesController.cuse1 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing hill");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này Vayne có chuyện gì suy ngẫm nhiều thế?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không có gì lớn cả... Chỉ là góc nhìn từ ngọn đồi này thật hùng vĩ.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Hửm, chỉ vậy thôi ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Tớ thì ngày nào cũng đến đây và ngắm thị trấn Zexel từ trên cao.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Haha, ...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Có gì đáng cười sao?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ chỉ thấy hai ta khác nhau về hoàn cảnh thôi, tớ thì sống ở vùng ngoại ô gần thủ đô vùng đất Zorth.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Ở đó có khung cảnh đẹp hơn đây nhiều lắm ư?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đẹp thì cũng có đẹp nhưng vẻ đẹp ở đó và ở đây hoàn toàn khác nhau.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Khác nhau ư? Cụ thể như thế nào chứ?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ở thủ đô rất nhộn nhịp, người đông qua lại từ nhiều vùng đất khác nhau để buôn thương hàng hóa nên ai cũng bận rộn.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bận rộn cho đến hoàng hôn, cũng là lúc sự nhộn nhịp biến mất và mọi thứ bắt đầu sáng đèn ban đêm để mọi người trong thủ đô đi dạo xung quanh.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "Thật vậy ư? Ngày nào cậu cũng bận rộn và đi chơi dạo thủ đô mỗi tối hả?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ chỉ vào thủ đô cuối tuần thôi, cơ bản cuộc sống của tớ khá giống với người dân ở thị trấn Zexel.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mà chưa gì hết tớ đã nhớ nhà rồi!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alia";
                dia.text = "Tớ thật sự muốn ghé thăm nơi của Vayne sinh sống xem sao.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cậu có thể đi cùng tớ sau khi mọi chuyện kết thúc. Nhưng tớ nói trước là sẽ rất xa đấy, đừng có mà chán nản giữa đường đi nha!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Alia";
                dia.text = "Cậu cứ nghĩ vậy thì không khác gì xem tớ như con nít.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hể? Không hẳn vậy đâu!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Alia";
                dia.text = "Thôi tớ về thị trấn trước đây.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đợi tớ với!";
            }
            else if (tang >= 23)
            {
                ExtraCutscenesController.cuse1 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing hill");
            }
        }
    }

    public void Pressnext()
    {
        ecc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        ecc.FXCutscenes(1);
        ExtraCutscenesController.cuse1 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing hill");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        ecc.BGMCutscenes(2, false);
    }
}
