using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus112 : MonoBehaviour
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
                dia.text = "You must be Vayne right? We have been informed by Sir Alasa that we will be assisted by you to restore the damage to the village.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right, hopefully we can be of some help!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "I heard you guys are from Zexel town right?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Actually that's my current residence, do you have any request from the outside?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "You see my house was broken by the inferno beast, the materials here are quite few for building such as wood.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "That's why I need you to help me get some wood, okay?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Wood? This is simple, but it will take some time to transport from the forest near Zexel town.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Then thank you, please spare your time.";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus112 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Man)";
                dia.text = "Cậu chắc hẳn là Vayne đúng không? Chúng tôi đã được ngài Alasa báo rằng sẽ được cậu giúp đỡ phục hồi thiệt hại ngôi làng.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, mong rằng chúng tôi có thể giúp được gì đó!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Tôi nghe rằng các cậu là người đến từ Zexel town đúng chứ?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật ra chỗ ở hiện tại của tôi là thế, ông có yêu cầu gì từ bên ngoài ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Cậu thấy đấy ngôi nhà của tôi đã bị phá vỡ bởi con quái vật inferno beast, nguyên vật liệu ở đây khá ít cho việc xây nhà ví dụ như là gỗ.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Chính vì thế tôi cần cậu kiếm giúp tôi một số lượng gỗ được chứ?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Gỗ ư? Chuyện này đơn giản thôi nhưng sẽ khá mất thời gian để vận chuyển từ khu rừng gần thị trấn Zexel town.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Vậy thì cảm ơn cậu, hãy thông thả thời gian của cậu.";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus112 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus112 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}