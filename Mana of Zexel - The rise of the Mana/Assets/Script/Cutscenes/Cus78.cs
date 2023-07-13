using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus78 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, ShanVAL1, AlasaVAL1, AlasaVAR1;
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
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Oh it your guys again! Is everything okay in the inferno volcano village?";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey Shan! Do you know what happened after we used your respected village chief Alasa's ice crystals?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Shan";
                dia.text = "I don't know anything, what I do is follow orders.";
            }
            else if (tang == 4)
            {
                ShanVAL1.SetActive(false);
                AlasaVAL1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "What's so noisy? It your guys again?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alasa village chief, you took advantage of me to want to destroy your brother's village!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "Looks like that village is gone?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "That village is back to normal, thanks to us!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alasa";
                dia.text = "So you came here to avenge my brother?";
            }
            else if (tang == 9)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "No, we're here to settle those two conflicts!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alasa";
                dia.text = "Hum... So he told you everything? But I told him I wouldn't trust him anymore!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alasa";
                dia.text = "If you think that I don't have faith, you're wrong! It was he who arranged the border management to silence us from outside help.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "No, he did it so he wouldn't be taken advantage of by the bad guys outside the village!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alasa";
                dia.text = "So what about the land of alta inferno? How can we trust him?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "You two are brothers, the one who has no faith is you, Alasa. If I could revive alta inferno's crops, wouldn't that solve your conflict?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alasa";
                dia.text = "This is our personal matter, no need to interfere.";
            }
            else if (tang == 16)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Your brother is very sad about you, Asila entrusted us to prove him wrong by asking Vayne to revive the land of alta inferno for you Alasa!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alasa";
                dia.text = "... What does he think... why would he want to revive that land?";
            }
            else if (tang == 18)
            {
                AlasaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "... (We seem to be better than I thought. If so...)";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Shan";
                dia.text = "Chief, what they say makes sense, as well as this is an opportunity to resolve the conflict that has been difficult for both sides for many years.";
            }
            else if (tang == 20)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "... But how are you planning to revive that land when it's a dead land.";
            }
            else if (tang == 21)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "You can trust us on this, we will handle the revival of the land ourselves.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Alasa";
                dia.text = "Okay, I will wait for good news from you.";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus78 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        else
        {
            if (tang == 1)
            {
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Ồ là mấy người sao? Mọi chuyện ở ngôi làng inferno volcano vẫn ổn chứ?";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này Shan! Cậu có biết chuyện gì đã xảy ra sau khi chúng tôi dùng tinh thể băng của trưởng làng Alasa đáng kính của cậu chứ?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Shan";
                dia.text = "Tôi không biết gì cả, những gì tôi làm là theo mệnh lệnh mà thôi.";
            }
            else if (tang == 4)
            {
                ShanVAL1.SetActive(false);
                AlasaVAL1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Có gì mà ồn ào thế? Ồ lại là mấy người à?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Trưởng làng Alasa, ông đã lợi dụng bon tôi muốn phá hủy ngôi làng của anh trai của ông!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "Có vẻ ngôi làng đó đã tiêu tùng rồi nhỉ?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ngôi làng ấy đã bình thường trở lại, nhờ vào chúng tôi đấy!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alasa";
                dia.text = "Vậy ư? Thế là các người đến đây là để trả thù cho anh trai ta đấy ư?";
            }
            else if (tang == 9)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Không chúng tôi đến đây để giải quyết mâu thuẫn của hai người đó!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alasa";
                dia.text = "Hum... Vậy là hắn ta đã kể mọi chuyện cho các ngươi nghe rồi sao? Nhưng ta đã bảo là sẽ không tin lời hắn nữa đâu!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alasa";
                dia.text = "Các ngươi nghĩ rằng ta không có lòng tin thì sai lầm rồi! Chính hắn là người sắp đặt chuyện quản lý cửa khẩu để bịt miệng ta không có được sự trợ giúp bên ngoài.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không phải, ông ấy làm vậy để không bị kẻ xấu ở ngoài làng lợi dụng mâu thuẫn của hai người đó!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alasa";
                dia.text = "Vậy chuyện vùng đất alta inferno thì sao? Làm sao ta có thể tin hắn?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hai người là anh em, người không có lòng tin chính là ông đấy Alasa. Nếu như tôi có thể hồi sinh lại hoa màu cho alta inferno thì coi như đã giải quyết mâu thuẫn của hai người chứ?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đây là chuyện cá nhân của bọn ta, không cần người xen vô.";
            }
            else if (tang == 16)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Anh trai của ông rất buồn về ông đó, Asila đã giao cho chúng tôi việc chứng minh ông ấy bị oan qua việc nhờ Vayne hồi sinh lại vùng đất alta inferno cho ông đó Alasa!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alasa";
                dia.text = "... Hắn ta nghĩ sao... sao lại muốn hồi sinh lại vùng đất đó?";
            }
            else if (tang == 18)
            {
                AlasaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "... (Bọn này có vẻ tốt hơn những gì mình nghĩ. Nếu vậy thì...)";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Shan";
                dia.text = "Thưa trưởng làng, họ nói cũng có lý đấy, cũng như đây là cơ hội để giải quyết mâu thuẫn là khó khăn của hai bên suốt mấy năm nay.";
            }
            else if (tang == 20)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "... Nhưng bọn ngươi tính hồi sinh vùng đất ấy kiểu gì khi đó đang là một vùng đất chết.";
            }
            else if (tang == 21)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Việc này ông cứ tin ở chúng tôi, chính chúng tôi sẽ giải quyết việc hồi sinh mảnh đất.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Alasa";
                dia.text = "Được thôi, ta sẽ chờ tin tốt từ các ngươi.";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus78 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
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
        CutscenesController.cus78 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}