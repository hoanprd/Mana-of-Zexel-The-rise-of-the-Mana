using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus62 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, HeeriumVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hey Heerium! We brought some presents for this uncle!";
            }
            else if (tang == 2)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Oh yeah? Then thank you very much!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Heerium";
                dia.text = "Wow! This is the ore in the land of the inferno volcano! You guys are already there!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right! We haven't been able to get through inferno ice yet because we haven't gotten the energy core to open the Zexel portal yet at the inferno volcano.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Heerium";
                dia.text = "Why can't you get that?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Because the village chief there said if you take the energy core there, the land will be engulfed in flames.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Heerium";
                dia.text = "Hum... So that core of energy sustains the village.";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I'm afraid it will be the same in inferno ice, because the energy cores keep the people alive there.";
            }
            else if (tang == 9)
            {
                HeeriumVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That means we'll never be able to open the Zexel Gate.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's a headache, we're still stuck anyway!";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "It's hard to admit, no one wants to take away someone else's source of life.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Heerium";
                dia.text = "But I think you guys should go to inferno ice and see if things are different.";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "But we can't get the core there...";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Heerium";
                dia.text = "It's not! I mean in that land it's the opposite of the inferno volcano. Surely there is a way to fix this. Come and try it and you'll see.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay then we'll go to inferno ice.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Heerium";
                dia.text = "I will expect good news from you.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus62 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("WeaponStore");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Này chú Heerium! Bọn cháu có mang một ít quà về cho chú này!";
            }
            else if (tang == 2)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Ồ vậy ư? Vậy thì cảm ơn các cháu nhiều!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Heerium";
                dia.text = "Chà! Đây là quặng ở vùng đất inferno volcano đây mà! Các cháu đã đến đó rồi à!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Bọn cháu vẫn chưa thể qua inferno ice được do ở inferno volcano bọn cháu chưa lấy được lõi năng lượng để mở cánh cổng Zexel.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Heerium";
                dia.text = "Tại sao lại không lấy được thế?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vì trưởng làng ở đó bảo nếu cháu lấy lõi năng lượng nơi đấy thì vùng đất ấy sẽ chìm trong biển lửa.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Heerium";
                dia.text = "Hum... Vậy là lõi năng lượng đó duy trì sự tồn tại cho ngôi làng ư.";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cháu e rằng ở inferno ice cũng sẽ tương tự, vì các lõi năng lượng duy trì sự sống cho người dân ở đó.";
            }
            else if (tang == 9)
            {
                HeeriumVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tức là bọn cháu sẽ không bao giờ mở cánh cổng Zexel được.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đau đầu thật dù sao bọn cháu đến nước này còn bị kẹt lại nữa!";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Công nhận khó thiệt, không ai lại muốn lấy đi nguồn sống của người khác.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Heerium";
                dia.text = "Nhưng mà chú nghĩ các cháu nên đến inferno ice xem thử đi biết đâu mọi chuyện lại khác.";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nhưng mà chúng ta không lấy được lõi năng lượng ở đó...";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Heerium";
                dia.text = "Không phải thế! Ý chú là ở vùng đất đó là nơi tương khắc với inferno volcano. Chắc hẳn sẽ có cách để khắc phục chuyện này. Các cháu hãy đến thử đi rồi mới biết được.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi nếu vậy thì chúng cháu sẽ tiến đến inferno ice.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Heerium";
                dia.text = "Ta sẽ trông chờ tin tốt từ các cháu.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus62 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("WeaponStore");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus62 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("WeaponStore");
    }
}