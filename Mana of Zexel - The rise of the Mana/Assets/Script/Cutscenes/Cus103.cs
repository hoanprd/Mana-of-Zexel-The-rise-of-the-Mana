using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus103 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, MariaVAR1, MrLanceVAL1, MeruVAR1;
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
                dia.text = "Vayne! Look at me, healthy like nothing ever happened hihi.";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Alia";
                dia.text = "Alia! Are you awake! It's lucky... I'm so worried.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I'm worried too, are you sure you're okay?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Of course...";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Of course it's not completely fine. Don't get too cocky little girl, you may be in good shape but it still takes time to fully recover.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Hehe...";
            }
            else if (tang == 7)
            {
                MeruVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia I'm sorry for everything...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "It's okay I get it... if that's the case with me, I'll act like you.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "I promise I won't make the same mistake again.";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "It's been a long wait, hasn't it? The food has arrived.";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Invite everyone to a meal.";
            }
            else if (tang == 12)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "All";
                dia.text = "Have a good meal everyone.";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus103 = 1;
                ContainerController.LoadingOpen = true;
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
                dia.text = "Vayne! Xem tớ này, khỏe mạnh như chưa từng có chuyện gì xảy ra đây hihi.";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Alia";
                dia.text = "Alia! Cậu đã tỉnh rồi à! Thật là may là... tớ rất lo lắng đấy.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị cũng rất lo đấy, em có chắc là đã khỏe rồi chứ?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Tất nhiên là...";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Tất nhiên là chưa khỏe hẳn rồi. Đừng có mà tự cao quá cô bé, có thể con có một thể trạng cơ thể tốt nhưng vẫn cần thời gian để phục hồi hoàn toàn.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Hehe...";
            }
            else if (tang == 7)
            {
                MeruVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia tớ xin lỗi vì tớ mà...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Không sao tớ hiểu mà... nếu trường hợp đó là tớ thì tớ cũng hành động như cậu.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ hứa sẽ không tái phạm sai lầm lần nào nữa đâu.";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Mọi người đã chờ đợi lâu rồi nhỉ? Món ăn đã tới.";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mời mọi người dùng bữa.";
            }
            else if (tang == 12)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "All";
                dia.text = "Chúc tất cả ngon miệng.";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus103 = 1;
                ContainerController.LoadingOpen = true;
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
        CutscenesController.cus103 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(0, false);
    }
}