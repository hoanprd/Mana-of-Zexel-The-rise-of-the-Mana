using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus31 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne! I suddenly remembered someone who is quite important in finding information!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Really? If so, who is that person?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Maria";
                dia.text = "If I remember correctly, this town has a girl who owns a grocery store that sells alchemy ingredients, she knows a lot of things.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "She knows things that the people of the village don't know including the history and locations far from this town.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Is she someone from another village? Maybe she's an archaeologist, so she knows so much.";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Archeology? What's that? And hearing someone who knows almost everything sounds scary, doesn't it? It's like he's not an ordinary person!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "According to what the people in town say, she's like a witch! But that's just a rumour.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Maria never met her?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right! Because of her eccentric nature, everyone gradually shunned her and so did she.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Oddly enough, a wise person is often liked by everyone rather than isolated.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "So you want to try her place, Vayne? Maybe she will know a lot of interesting things.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay then I have to go see her! But what is her name and where is she?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Well her name is Orina, remember that! And the accommodation is also near this pub, actually located on the left hand side of the pub next to the town's cliff.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "In that case, let's go! Can't waste time in vain!";
            }
            else if (tang == 15)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey hey! Wait for me! Why doesn't anyone answer what an archaeologist is!";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus31 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne! Chị chợt nhớ ra một người khá quan trọng trong việc tìm kiếm thông tin rồi!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật vậy ư? Nếu vậy người đó là ai?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Maria";
                dia.text = "Nhớ không lầm thì thị trấn này có một cô gái chủ tiệm tạp hóa có cả bán nguyên liệu của giả kim thuật, cô ấy biết rất nhiều thứ.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Cô ấy biết những thứ mà người dân trong làng chưa từng biết kể cả lịch sử cũng như các địa điểm xa thị trấn này.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chắc cô ấy là một người từ làng khác tới chăng? Có thể cô ấy là một nhà khảo cổ học nên mới biết nhiều đến vậy.";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Khảo cổ học ư? Là gì thế? Mà nghe đến một người biết hầu hết mọi thứ nghe cũng đáng sợ nhỉ? Kiểu như không phải người thường ấy!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Theo những gì người trong thị trấn nói là cô ấy như là phù thủy vậy! Mà đó chỉ là tin đồn thôi.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chị Maria chưa từng gặp cô ta ư?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế! Vì bản chất lập dị của cô ấy nên ai cũng dần xa lánh và cô ta cũng vậy.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Kỳ lạ thật, một người thông thái thường được mọi người yêu mến chứ thay vì cô lập.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Vậy em muốn đến thử chỗ của cô ta chứ Vayne? Có thể cô ta sẽ biết nhiều thứ thú vị.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được nếu vậy em phải đến gặp cô ta! Mà cô ta tên là gì cũng như ở đâu thế?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "À cô ấy tên là Orina, nhớ không lầm là vậy! Còn chỗ ở cũng gần quán rượu này thôi, thực ra là nằm bên tay trái quán rượu sát vách núi thị trấn ấy.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy thì chúng ta đi thôi! Không thể phí thời gian vô bổ được!";
            }
            else if (tang == 15)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này này! Đợi tớ với! Mà sao không ai trả lời nhà khảo cổ học là gì thế!";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus31 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus31 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}