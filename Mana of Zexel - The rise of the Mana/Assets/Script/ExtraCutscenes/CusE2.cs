using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CusE2 : MonoBehaviour
{
    ExtraCutscenesController ecc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, KlenerVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        ecc = FindObjectOfType<ExtraCutscenesController>();
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
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That Klener? Do you like to come out here often?";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Well, this is my favorite place to sightsee.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "If you look closely, this area crosses a large river, doesn't it?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "I heard my grandfather say that this river runs along the Wishing forest and leads to the fairy forest.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Really? Sounds like fun to go to that forest, doesn't it?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "I'm like you, but that forest is far away from this area, it takes a long time to go through by boat.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "The difficulty is that the forest is very dangerous because it used to be a base for magicians to reside.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Magician? Are there really magicians there?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Klener";
                dia.text = "I don't think it's any more but the forest is still full of dangerous things anyway and it's best if they're still around this area it'll be fine.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Sounds mystical.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Klener";
                dia.text = "Anyway, if I have a chance to stop by there, I want to go to that forest like my grandfather.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Was your grandfather already in that forest?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Klener";
                dia.text = "That's right! But he decided to come to the town of Zexel.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "He wants to have a good life with the villagers here?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Klener";
                dia.text = "If I remember correctly, there was a certain girl who helped him realize a lot of things that he missed in life.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "And my grandfather chose the town of Zexel to find the missing things.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's hard for the ancients to understand, isn't it?";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Klener";
                dia.text = "I'm also satisfied to live in peace like this.";
            }
            else if (tang >= 19)
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Klener đó ư? Cậu thích ra đây thường xuyên nhỉ?";
            }
            else if (tang == 2)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "À thì đây là nơi mà tớ thích ngắm cảnh nhất.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Để ý kỹ thì khu vực này có thông qua một con sông lớn nhỉ?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Trước đây tớ nghe ông tớ nói con sông này chạy dọc Wishing forest và dẫn đến khu rừng cổ tích.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật vậy ư? Nghe có vẻ thích thú nếu đến khu rừng đó nhỉ?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Klener";
                dia.text = "Tớ cũng như cậu nhưng mà khu rừng đó ở xa khu vực này lắm, muốn qua được thì phải đi thuyền mất rất nhiều thời gian.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "Điều khó khăn là khu rừng ấy rất nguy hiểm vì đó từng là căn cứ của các ma pháp sư trú ngụ.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ma pháp sư? Thật sự có ma pháp sư ở đó chứ?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Klener";
                dia.text = "Tớ nghĩ không còn nữa đâu nhưng dù gì khu rừng đó vẫn còn nhiều thứ nguy hiểm tốt nhất là chúng vẫn ở quanh khu vực này thì sẽ ổn.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nghe thần bí thật.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Klener";
                dia.text = "Nói sao thì nói nếu có dịp ghé qua đó thì tớ cũng muốn tới khu rừng đó thử như ông của tớ.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ông của cậu đã ở khu rừng đó rồi sao?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Klener";
                dia.text = "Đúng thế! Nhưng ông ấy quyết định đến với thị trấn Zexel.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ông ấy muốn có cuộc sống vui vẻ cùng dân làng ở đây ư?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Klener";
                dia.text = "Nếu nhớ không lầm là có một cô gái nào đó đã giúp ông ấy ngộ ra rất nhiều điều mà ông ấy bỏ lỡ trong cuộc sống.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Klener";
                dia.text = "Và ông của tớ chọn thị trấn Zexel để tìm kiếm những thứ còn thiếu đấy.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Người xưa khó hiểu thật nhỉ?";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Klener";
                dia.text = "Tớ cũng thấy hài lòng khi được sống sự yên bình như này là được.";
            }
            else if (tang >= 19)
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
    }

    public void Pressnext()
    {
        ecc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        ecc.FXCutscenes(1);
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        ecc.BGMCutscenes(2, false);
    }
}
