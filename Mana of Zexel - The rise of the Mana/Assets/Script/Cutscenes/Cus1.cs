using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus1 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject va2;
    public GameObject va3;
    public GameObject va4;
    public GameObject VayneVAL1, GinVAR1;
    public GameObject NameTag;
    public AudioSource FunBGM, LessSeriousBGM, NormalBGM, SeriousBGM, TutorialBGM2;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
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
                NameTagText.text = "Dante";
                dia.text = "Look Zane! This must be it, Mana of Zexel.";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Zane";
                dia.text = "You right. I can feel a huge amount of mana in that thing.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Dante";
                dia.text = "With this we can help people everywhere with the fuel problem.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Dante";
                dia.text = "Right Zane?";
            }
            else if (tang == 5)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "Dante";
                dia.text = "Uh... What the?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Zane";
                dia.text = "That's pathetic, Dante.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Dante";
                dia.text = "...Uh... But why? Why you do this.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Zane";
                dia.text = "You should know that with this power, I can do anything. Even dominating this world.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Dante";
                dia.text = "...Unbelievably, I was miserably betrayed. Anyway, your selfishness and ambition will destroy you.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahaha. So that was your last words Dante?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Zane";
                dia.text = "It's sad that you didn't get to see the world kneeling down on me. Once I revieve Malagam, I will become the strongest.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Zane";
                dia.text = "Good night Dante. Hahahahahahaha...";
            }
            else if (tang == 13)
            {
                va2.SetActive(false);
                va3.SetActive(true);
                NameTag.SetActive(false);
                dia.text = "1 year later";
            }
            else if (tang == 14)
            {
                LessSeriousBGM.Stop();
                NormalBGM.Play();
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'm going mom! Wish you stay healthy.";
            }
            else if (tang == 15)
            {
                GinVAR1.SetActive(true);
                NameTagText.text = "Gin";
                dia.text = "Well, it's been over a year and your father still hasn't returned. I hope you find your father again.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "I will!";
            }
            else if (tang == 17)
            {
                va3.SetActive(false);
                va4.SetActive(true);
                VayneVAL1.SetActive(false);
                GinVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Phuff... Am I nearing to Zexel town yet?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Thief";
                dia.text = "Stop there kid! Give me all your jewelry and valuables things.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Are you kidding me? A thief in middel of the day? I think I have to teach this bandit a lesson!";
            }
            else if (tang >= 21)
            {
                CutscenesController.cus1 = 1;
                SceneManager.LoadScene("BSThief");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Dante";
                dia.text = "Nhìn kìa Zane, Kia chắc hẳn là mana của Zexel.";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Zane";
                dia.text = "Cậu nói đúng đấy, tôi có thể cảm nhận được một nguồn năng lượng lớn từ thứ đó.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Dante";
                dia.text = "Với thứ này chúng ta có thể giúp mọi người ở bất kỳ nơi nào về vấn đề nhiên liệu.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Dante";
                dia.text = "Phải không Zane?";
            }
            else if (tang == 5)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "Dante";
                dia.text = "Uh... Không thể nào.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Zane";
                dia.text = "Thảm hại quá đấy Dante.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Dante";
                dia.text = "... Uh... Nhưng tại sao? Tại sao cậu lại phản bội tôi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Zane";
                dia.text = "Ngươi nên biết là với sức mạnh này, ta có thể làm được mọi thứ. Kể cả thống trị cả thế giới.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Dante";
                dia.text = "... Thật không thể tin nổi, mình đã bị phản bội một cách thê thảm như này. Dù sao thì sự ích kỷ và ác độc đó sẽ hủy diệt bản thân ngươi.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahaha. Vậy đó là những lời cuối cùng của ngươi sao Dante?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Zane";
                dia.text = "Thật buồn khi ngươi không được chứng kiến cả thế giới quỳ gối trước ta. Một khi Sicxalon được hồi sinh, ta sẽ là kẻ mạnh nhất.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Zane";
                dia.text = "Ngủ ngon nhé Dante. Hahahahahahaha...";
            }
            else if (tang == 13)
            {
                va2.SetActive(false);
                va3.SetActive(true);
                NameTag.SetActive(false);
                dia.text = "1 năm sau";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Con đi đây nha mẹ! Hãy ở nhà mạnh khỏe.";
            }
            else if (tang == 15)
            {
                GinVAR1.SetActive(true);
                NameTagText.text = "Gin";
                dia.text = "Có vẻ đã hơn 1 năm rồi cha con chưa trở về nhà. Cầu mong con có thể gặp lại ông ấy.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chắc chắn con sẽ gặp được";
            }
            else if (tang == 17)
            {
                va3.SetActive(false);
                va4.SetActive(true);
                VayneVAL1.SetActive(false);
                GinVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Phù... Mình đã đến gần thị trấn Zexel chưa thế?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Thief";
                dia.text = "Dừng lại đi nhóc con! Đưa ta toàn bộ đồ trang sức và vật phẩm giá trị đây.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đùa mình à? Một tên cướp giữa ban ngày ư? Có vẻ mình phải cho tên cướp này một bài học!";
            }
            else if (tang >= 21)
            {
                CutscenesController.cus1 = 1;
                SceneManager.LoadScene("BSThief");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }

    public void Pressskip()
    {
        CutscenesController.cus1 = 1;
        SceneManager.LoadScene("BSThief");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        LessSeriousBGM.Play();
    }
}
