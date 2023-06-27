using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus116 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
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
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Man)";
                dia.text = "You must be Vayne right? We have been informed by Mr. Asila that we will be helping to restore the damage to the village.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right! I came here to see if anyone needs any help.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Sir Asila has made a policy to start exporting the popular items of the village to the outside. Our family is responsible for transporting goods to the trading point, but the road is quite difficult right now.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Difficult, the passage is no longer usable?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "The inferno beast's attack has missed the safe path. So now the rest of the way, there are so many wild wolves guarding that we can't go there.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "I see, just cleaning up those wild wolves is fine, right?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Yes, bother you, please help me.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's okay, we'll be honor to do that!";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus116 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Man)";
                dia.text = "Cậu chắc hẳn là Vayne đúng không? Chúng tôi đã được ngài Asila báo rằng sẽ được cậu giúp đỡ phục hồi thiệt hại ngôi làng.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Tôi đến đây để xem thử mọi người có cần giúp đỡ gì không?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Ngài Asila đã ra chính sách bắt đầu xuất khẩu các mặt hàng phổ biến của ngôi làng cho bên ngoài. Gia đình chúng tôi chịu trách nhiệm vận chuyển hàng hóa sang điểm buôn thương nhưng đường đi hiện giờ khá khó khăn.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Khó khăn ư, lối đi không còn sử dụng được nữa ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Đợt tấn công của inferno beast đã làm sạt lỡ con đường an toàn. Nên giờ đường đi còn lại thì gặp rất nhiều sói hoang đang canh giữ khiến chúng tôi không thể đi qua đó được.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tôi hiểu rồi, chỉ cần dọn dẹp lũ sói hoang đó là được chứ gì?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Đúng thế, làm phiền cậu hãy giúp tôi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không sao, chúng tôi rất sẵn lòng!";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus116 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus116 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}