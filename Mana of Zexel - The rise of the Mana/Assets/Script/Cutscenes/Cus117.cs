using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus117 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
    public GameObject NameTag;
    private int tang, stop;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        stop = 0;
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
                NameTagText.text = "Villager (Man)";
                dia.text = "Is that Vayne? Is there something you wonder about?";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I just wanted to report that the monsters have been defeated by me, now you can move around freely.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Really? Unbelievable, your group is really strong.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "As long as we can help people, I'll be happy.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "I don't know what to say, but you guys have helped us a lot. Please accept my kindness.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "";
                dia.text = "Zen +200";
                if (stop == 0)
                {
                    stop = 1;
                    Global.Zen += 200;
                }
            }
            else if (tang == 7)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Looks like I have to start going out to do some business, see you next time!";
            }
            else if (tang >= 8)
            {
                CutscenesController.cus117 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Villager (Man)";
                dia.text = "Là Vayne đó sao? Có chuyện gì mà cậu thắc mắc ư?";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tôi chỉ muốn báo là lũ quái vật đã bị tôi tiêu diệt rồi, giờ mọi người có thể thoải mái đi lại.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Thật vậy ư? Thật không thể tin nổi, nhóm các cậu thật sự rất mạnh.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Miễn là chúng tôi có thể giúp mọi người là tôi sẽ sẵn lòng.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Tôi không biết phải nói sao chứ các cậu đã giúp buôn thương chúng tôi rất nhiều đó. Xin cậu hãy nhận lòng tốt của tôi.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "";
                dia.text = "Zen +200";
                if (stop == 0)
                {
                    stop = 1;
                    Global.Zen += 200;
                }
            }
            else if (tang == 7)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Có vẻ tôi phải bắt đầu lên đường để buôn bán đây, hẹn gặp lại vào dịp khác!";
            }
            else if (tang >= 8)
            {
                CutscenesController.cus117 = 1;
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
        CutscenesController.cus117 = 1;
        ContainerController.LoadingOpen = true;
        if (tang < 6)
        {
            Global.Zen += 200;
        }
        SceneManager.LoadScene("Inferno ice");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}