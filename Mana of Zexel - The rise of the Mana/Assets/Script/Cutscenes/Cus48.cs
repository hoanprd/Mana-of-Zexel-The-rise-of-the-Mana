using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus48 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAR1, KlenerVAL1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's true! After eating Vayne's porridge, there is nothing better than a refreshing rest!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's great, if you've regained your strength, I'll head south to the inferno desert to find the whereabouts of the mana gods!";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Hey Vayne! Wait for me!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Klener? Is something wrong?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Klener";
                dia.text = "Well, I just heard Mr. Lance recounts that your group just sent me to the inferno desert?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "And I heard there's some kind of poisonous monster there?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right! It is a very large scorpion, if not treated in time, it will be very dangerous to life.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Klener";
                dia.text = "So? If so... mind you helping me collect their venom!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Collecting scorpion poison? Did the villagers get poisoned?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Klener";
                dia.text = "No! We bodyguards plan to expand the range of our guard instead of just guarding the wishing forest. We want to expand into the inferno desert.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "On this occasion, I used to go to the Inferno Desert for the first time to learn about that place as well as build more bases to protect the villagers in this town of Zexel. Since there are monsters like scorpions there, I need their venom as an antidote in case.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "I see, I'm ready to help, okay Alia, Maria?";
            }
            else if (tang == 14)
            {
                KlenerVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "If it's for the safety of the villagers, I'll be happy too.";
            }
            else if (tang == 15)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I'll join too so I don't get bored.";
            }
            else if (tang == 16)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Thank you very much!";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ah Klener! Be prepared to be on high alert because those monsters aren't as easy as the golems.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Klener";
                dia.text = "Don't worry about me, I will definitely fight with all my might!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus48 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.Porridge -= 1;
                MapController.SaveRoomToTavern = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Công nhận đã thật! Sau khi ăn món cháo của Vayne lại nghỉ ngơi sảng khoái đúng là không có gì tuyệt bằng!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vậy thì tốt quá, nếu mọi người đã có lại sức rồi thì ta sẽ tiến tới phía nam sa mạc inferno để tìm nơi ở của các vị thần mana nào!";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Này Vayne! Đợi tớ với!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Klener? Có chuyện gì ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Klener";
                dia.text = "À tớ vừa nghe Mr. Lance kể lại là nhóm cậu vừa tớ sa mạc inferno ư?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "Và tớ nghe là ở đó có một loại quái vật có độc tố ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng vậy! Đó là một bọn bọ cạp rất to, nếu không cứu chữa kịp thời sẽ rất nguy hiểm đến tính mạng.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Klener";
                dia.text = "Vậy ư? Nếu vậy thì... phiền cậu giúp tớ thu thập nọc độc của chúng!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thu thập độc bọ cạp ư? Bộ dân làng có ai dính độc ư?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Klener";
                dia.text = "Không! Vệ sĩ bọn tớ tính mở rộng phạm vi canh gác thay vì chỉ canh gác khu rừng wishing. Bọn tớ muốn mở rộng sang sa mạc inferno.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "Dịp này tớ nhân lần đầu đến sa mạc inferno để tìm hiểu về nơi đó cũng như xây thêm căn cứ để bảo vệ dân làng ở thị trấn Zexel này. Vì ở đó có quái vật như bọ cạp nên tớ cần nọc độc của chúng để làm thuốc giải đề phòng.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ hiểu rồi, tớ sẵn sàng giúp đỡ, được chứ Alia, Maria?";
            }
            else if (tang == 14)
            {
                KlenerVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nếu vì sự an toàn của dân làng thì tớ cũng sẵn lòng.";
            }
            else if (tang == 15)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị cũng sẽ tham gia cho đỡ chán vậy.";
            }
            else if (tang == 16)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Cảm ơn mọi người rất nhiều!";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "À Klener! Hãy chuẩn bị tinh thần cảnh giác cao nhất đi vì lũ quái vật đó không dễ dàng như tụi golems đâu.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Klener";
                dia.text = "Đừng lo cho tớ, tớ nhất định sẽ đánh hết sức!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus48 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.Porridge -= 1;
                MapController.SaveRoomToTavern = true;
                SceneManager.LoadScene("Tavern");
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
        CutscenesController.cus48 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.Porridge -= 1;
        MapController.SaveRoomToTavern = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}