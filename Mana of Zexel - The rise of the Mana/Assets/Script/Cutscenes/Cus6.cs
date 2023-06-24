using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus6 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MrLanceVAR1, KlenerVAR1;
    public GameObject NameTag;
    private int tang=0;

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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance I've already made the healing potion.";
            }
            else if (tang == 2)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Amazing, you're faster than I thought.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Why do you want to use the healing potion for?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "These days, goblins regularly wreak havoc on the south side of town. The town guards often fight but the medical supplies are not enough for them, so I take the opportunity to ask for your help.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "It sounds like there are dangerous places around the village, right?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Yes. Those who don't have combat skills are vulnerable to outside monsters, so be careful when you're out of town.";
            }
            else if (tang == 7)
            {
                MrLanceVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Emergency! Sir Lance, the goblins had gathered in a swarm southwest of town. We need urgent help!";
            }
            else if (tang == 8)
            {
                KlenerVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "... It's difficult. We really lack resources.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "So let me. I can handle the goblins.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey let me join you, Vayne!";
            }
            else if (tang == 11)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "I really appreciate you both, thank you and good luck out there.";
            }
            else if (tang == 12)
            {
                MrLanceVAR1.SetActive(true);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Okay let's go Vayne!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hey, don't be like that, Alia! Wait for me!";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus6 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chú Lance, cháu đã làm xong bình hồi phục rồi ạ.";
            }
            else if (tang == 2)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Ngạc nhiên thật, cháu làm nhanh hơn chú tưởng đấy.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mà sao chú lại cần bình hồi phục làm gì thế?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Dạo gần đây tụi yêu tinh thường xuyên phá hoại mùa màn của dân làng. Những vệ sĩ của thị trấn đang trong tình trạng thiếu dược phẩm, nên ta mới nhân cơ hội này nhờ cháu giúp một tay.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ nghe bên ngoài ngôi làng nguy hiểm nhỉ?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Đúng thế. Những ai không có khả năng chiến đấu sẽ vô dụng trước lũ quái vật, nên hãy cẩn thận khi cháu ra khỏi thị trấn.";
            }
            else if (tang == 7)
            {
                MrLanceVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Khẩn cấp! Ngài Lance, tụi yêu tinh đang tụ tập ở phía tây nam ngôi làng. Chúng ta cần hỗ trợ khẩn cấp!";
            }
            else if (tang == 8)
            {
                KlenerVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "... Khó khăn đây. Chúng ta không còn đủ nguồn lực nữa.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy hãy để cháu xử lý bọn yêu tinh.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hãy cho tớ tham gia với nào Vayne!";
            }
            else if (tang == 11)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Ta thật sự cảm kích cho cả hau, cảm ơn và chúc may mắn ngoài đó.";
            }
            else if (tang == 12)
            {
                MrLanceVAR1.SetActive(true);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Được thôi đi nào Vayne!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Khoan đã, đừng có vội vàng như thế Alia! Đợi tớ với!";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus6 = 1;
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
        CutscenesController.cus6 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}
