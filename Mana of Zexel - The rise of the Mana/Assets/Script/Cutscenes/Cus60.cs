using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus60 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAL1, ShanVAR1;
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
                dia.text = "We've reached the village! Let's see, where should we find the village chief?";
            }
            else if (tang == 2)
            {
                ShanVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Heh? Are you guys from outside the village?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Oh yes! Yes, we come from far away.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "???";
                dia.text = "Really? Where are you going, what's wrong? Here we do not receive regular guests if there is nothing related to the village, then bother everyone.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Actually, we need to meet the village chief to discuss...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "???";
                dia.text = "Talk about what?";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Please help us, we need to see the village chief and we don't have any bad intentions!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "???";
                dia.text = "... I'm not the village chief to make decisions.";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "In that case, just ask the village chief first, right?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "???";
                dia.text = "That's annoying... well let me tell the village chief if he wants to see you guys. Come to the south-west of this town there's a rather large house waiting for us.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thank you very much! Oh, what's your name?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Shan";
                dia.text = "My name is Shan! It's just Shan.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "...Thank you Shan...";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus60 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta đã đến ngôi làng rồi! Để xem nào chúng ta nên tìm trưởng làng ở đâu nhỉ?";
            }
            else if (tang == 2)
            {
                ShanVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Heh? Mấy cô cậu là người ngoài làng tới à?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "À vâng! Đúng thế chúng tôi từ nơi rất xa đến.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "???";
                dia.text = "Vậy ư? Cô cậu đến đâu có chuyện gì không? Nơi đây chúng tôi không đón tiếp khách thường xuyên nếu không có chuyện gì liên quan đến ngôi làng thì phiền mọi người về.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thực ra thì chúng tôi cần gặp trưởng làng để bàn về chuyện...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "???";
                dia.text = "Bàn về chuyện gì?";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Xin hãy giúp chúng tôi, bọn tôi cần gặp trưởng làng cũng như không có ý định gì xấu đâu!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "???";
                dia.text = "... Ta không phải là trưởng làng để có quyền quyết định đâu.";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy chỉ cần hỏi trưởng làng trước là được đúng không?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "???";
                dia.text = "Thật là phiền phức... được thôi để ta nói với trưởng làng xem ông ta có muốn gặp mấy người không. Hãy tới phía nam tây nam thị trấn này có một ngôi nhà khá lớn để đợi ta.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn nhiều ạ! À mà cậu tên gì thế?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Shan";
                dia.text = "Tên tôi là Shan! Chỉ là Shan thôi.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Cảm ơn Shan...";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus60 = 1;
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
        CutscenesController.cus60 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}