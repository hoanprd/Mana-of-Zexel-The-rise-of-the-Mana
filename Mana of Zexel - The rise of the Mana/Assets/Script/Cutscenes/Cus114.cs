using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus114 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
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
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Woman)";
                dia.text = "You must be Vayne right? We have been informed by Sir Alasa that we will be assisted by you to restore the damage to the village.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right, we're here to see what we can do for you!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Have you heard the new policy of Mr. Asila and Alasa for the two villages?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "You mean both villages started to open their borders to the outside right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Yes, my family mainly deals in minerals.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "However, our mineral resources have been eaten by the inferno beast so we urgently need the lost minerals to trade on schedule but the monsters outside the village are quite aggressive. This makes it impossible for us to dig minerals.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "I see, as long as we can supply the lost minerals, can't we?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Really this will bother you.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Don't worry the monsters here won't give us a hard time. I will provide you with timely supplies.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus114 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Woman)";
                dia.text = "Cậu chắc hẳn là Vayne đúng không? Chúng tôi đã được ngài Alasa báo rằng sẽ được cậu giúp đỡ phục hồi thiệt hại ngôi làng.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, chúng tôi đến đây mong có thể gì cho cô!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Cậu đã nghe chính sách mới của ngài Asila và Alasa ban ra cho hai ngôi làng rồi chứ?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ý cô là cả hai ngôi làng bắt đầu mở cửa khẩu với bên ngoài đúng không?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Đúng thế, gia đình tôi chủ yếu buôn bán các loại khoáng sản.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Tuy nhiên nguồn khoáng sản của chúng tôi đã bị con quái vật inferno beast ăn sạch nên chúng tôi đang cần gấp lượng khoáng sản đã mất để buôn thương đúng tiến độ nhưng lũ quái vật bên ngoài ngôi làng khá là hung hăn khiến chúng tôi không thể đào khoáng sản được.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tôi hiểu rồi, chỉ cần chúng tôi có thể cung cấp lượng khoáng sản đã mất là được chứ gì?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Thật sự điều này sẽ làm phiền cô cậu đấy.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đừng lo đám quái vật ở đây sẽ không làm khó chúng tôi đâu. Tôi sẽ cung cấp nguồn hàng kịp lúc cho cô.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus114 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
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
        CutscenesController.cus114 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}