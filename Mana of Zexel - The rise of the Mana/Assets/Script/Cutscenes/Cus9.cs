using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus9 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It worked! My potion has revived the field!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Villager (Man) 1";
                dia.text = "Unbelievable! Is this magic?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man) 2";
                dia.text = "Nope! This is alchemy.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Villager (Wonman)";
                dia.text = "Amazing! Can alchemy do that?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It really worked! Someday I have to try alchemy too!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's easy to say but alchemy is hard to learn, in reality there are very few alchemists in this world.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Really! All this alchemy you taught yourself?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "No, I got alchemy from my mother, she's also a good alchemist.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Oh. Maria is pretty much self-taught alchemy, the whole town except you she's the only alchemist I know.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Really? I also have to see what kind of person she is.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Are you excited! If that's the case, then let's move on to the wishing forest!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay! Let's go!";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus9 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thành công rồi! Thuốc của tớ đã hồi sinh được đồng ruộng!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Villager (Man) 1";
                dia.text = "Không thể tin được! Đây là ma thuật ư?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man) 2";
                dia.text = "Không phải! Đây là giả kim thuật.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Villager (Wonman)";
                dia.text = "Thật ngạc nhiên! Giả kim thuật có thể làm được điều này ư?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Thành công rồi! Một ngày nào đó tớ cũng phải thử giả kim thuật mới được!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nói thì dễ lắm nhưng giả kim thuật rất khó để học được, thực thế chỉ có vài nhà giả kim trên thế giới này thôi.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Vậy ư! Những thứ giả kim này là cậu tự học hết ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không, tớ học từ mẹ tớ đấy, cô ấy cũng là một nhà giả kim tài giỏi.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Ồ, chị Maria cũng tự học giả kim thuật rất nhiều, cả thị trấn tớ biết mỗi chị ấy là nhà giả kim duy nhất đấy.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật ư? Tớ cũng mong được gặp một người như chị đó thật.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Cậu cảm thấy thích thú rồi chứ! Nếu vậy thì hãy tiến tới khu rừng ước nguyện đi!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi! Chúng ta đi thôi!";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus9 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
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
        CutscenesController.cus9 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(0, false);
    }
}
