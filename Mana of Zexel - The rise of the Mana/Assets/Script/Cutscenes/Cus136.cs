using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus136 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1, ZexelVAR1;
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
                NameTagText.text = "";
                dia.text = "Glowinggggggg...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Another Zexel illusion. After all, she wants to show us something.";
            }
            else if (tang == 3)
            {
                ZexelVAR1.SetActive(true);
                NameTagText.text = "Zexel";
                dia.text = "Dear everyone, it seems fate has arranged according to what I predicted.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Zexel";
                dia.text = "Long ago after the battle between me and Sicxalon ended, I had a peaceful life.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Zexel";
                dia.text = "But I know well that the peace will crumble someday like now. That's why I hope future generations don't make the same mistake I did.";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Zexel's mistake?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Zexel";
                dia.text = "I have a family, my beloved daughter Alia. I was not able to fulfill the role of a mother completely.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Zexel";
                dia.text = "In order to prolong the seal of Sicxalon, I must sacrifice my life in this temple. Since I didn't want her to live a lonely life, I gave her the option of hibernation for her.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Zexel";
                dia.text = "I want it to have a new life once it wakes up. A life where she doesn't need me. I'm sorry Alia!";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "This... I... have started to remember! Memories of my mother are flooding back...";
            }
            else if (tang == 11)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What? Is Alia really Zexel's daughter?";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "If so, that would clear up a lot of questions.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Zexel";
                dia.text = "I implore the chosen ones to save this world, defeat Sicxalon completely and don't make your future suffer like me.";
            }
            else if (tang == 14)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... So that's the whole truth...";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                ZexelVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That day, I woke up and fought with the temple intruders Vayne and Zane's father.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "That's when I lost the battle and lost my memory. And Maria saved me.";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... You don't have to worry about that anymore Alia. I've got you and new friends, I've created a new life for myself and have no regrets about the past.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Alia";
                dia.text = "That's right... I still have everyone around.";
            }
            else if (tang == 19)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Surely if your mother saw you now, she would be happy too.";
            }
            else if (tang == 20)
            {
                AliaVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrrrrrroommmmmmm...";
            }
            else if (tang == 21)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Let's go guys, I can feel Zane's dark energy at the temple's main gate!";
            }
            else if (tang >= 22)
            {
                CutscenesController.cus136 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggggg...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Lại một ảo ảnh của Zexel nữa. Rốt cuộc cô ấy muốn cho chúng ta thấy điều gì.";
            }
            else if (tang == 3)
            {
                ZexelVAR1.SetActive(true);
                NameTagText.text = "Zexel";
                dia.text = "Kính chào, có vẻ định mệnh đã sắp đặt theo những gì tôi đã dự đoán.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Zexel";
                dia.text = "Đã rất lâu về trước sau khi trận chiến giữa tôi và Sicxalon đã kết thúc, tôi đã có một cuộc sống bình yên.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Zexel";
                dia.text = "Nhưng tôi biết rõ là sự bình yên sẽ sụp đổ vào ngày nào đó như bây giờ. Chính vì thế tôi mong rằng những thế hệ sau đừng mắc phải sai lầm của tôi.";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Sai lầm của Zexel?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Zexel";
                dia.text = "Tôi đã có một gia đình, người con gái yêu quý Alia của tôi. Tôi đã không thể đáp ứng vai trò một người mẹ hoàn toàn.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Zexel";
                dia.text = "Để kéo dài phong ấn Sicxalon, tôi phải hy sinh mạng sống của mình ở ngôi đền này. Vì tôi không muốn con bé sống một sống cô đơn nên tôi đã cho con bé lựa chọn phương án ngủ đông cho con bé.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Zexel";
                dia.text = "Tôi muốn nó một khi thức dậy sẽ có một cuộc sống mới. Một cuộc sống mà con bé không cần tôi. Mẹ xin lỗi Alia!";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chuyện này... mình... đã bắt đầu nhớ ra rồi! Những ký ức về mẹ của mình đang ùa về...";
            }
            else if (tang == 11)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cái gì? Alia là con gái của Zexel thật ư?";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nếu vậy thì điều đó sẽ lý giải khá nhiều thắc mắc.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Zexel";
                dia.text = "Tôi cầu xin những người được chọn hãy cứu thế giới này, hãy đánh bại Sicxalon hoàn toàn và đừng khiến cho tương lai của bản thân đau khổ như tôi.";
            }
            else if (tang == 14)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Vậy đó là toàn bộ sự thật ư...";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                ZexelVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ngày đó, mình đã tỉnh dậy và đã từng giao chiến với những kẻ xâm nhập ngôi đền là cha của Vayne và Zane.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Cũng chính lúc đó mình đã bại trận và mất đi trí nhớ. Và chị Maria đã cứu mình.";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Em không cần phải bận tâm chuyện đó nữa đâu Alia. Em đã có anh và những người bạn mới, em đã tự tạo dựng cuộc sống mới rồi không có gì phải nuối tiếc về quá khứ.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Alia";
                dia.text = "Đúng thế... em vẫn còn mọi người ở bên.";
            }
            else if (tang == 19)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chắc hẳn nếu mẹ em thấy em được bây giờ cũng sẽ hạnh phúc thôi.";
            }
            else if (tang == 20)
            {
                AliaVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrrrrrroommmmmmm...";
            }
            else if (tang == 21)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đi thôi mọi người, tớ có thể cảm nhận năng lượng hắc ám của Zane ở cổng chính ngôi đền!";
            }
            else if (tang >= 22)
            {
                CutscenesController.cus136 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 1)
        {
            cc.FXCutscenes(3);
        }
        else if (tang == 2)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 20)
        {
            cc.FXCutscenes(2);
        }
        else if (tang == 21)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 14)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 15)
        {
            cc.BGMCutscenes(6, false);
        }
        if (tang == 20)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus136 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel temple");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}