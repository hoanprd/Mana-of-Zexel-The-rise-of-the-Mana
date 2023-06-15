using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus0 : MonoBehaviour
{
    public GameObject Dia0;
    public Text[] textM, textBG;

    string[] DiaLogEN = {"A long time ago appeared mysterious beings called Mana\nThey always exist parallel to the human world", "Those creatures have magical powers\nSomething that humans can't touch", "Those are called gods", "Some people say the gods will make our lives better\nBut some think they are dangerous to human life", "History is just a record and no one knows the truth\nNew descendants will write their own stories", "Until..."};
    string[] DiaLogVN = { "Đã từ lâu về trước sự xuất hiện của các sinh vật bí ẩn được gọi là Mana\nChúng luôn tồn tại song song thế giới loài người", "Những sinh vật ấy mang những sức mạnh kỳ diệu\nThứ mà con người không thể chạm tới được", "Đó được gọi là các vị thần", "Một số người bảo các vị thần ấy sẽ giúp cuộc sống chúng ta tốt hơn\nNhưng một số lại cho rằng chúng nguy hiểm tới sự sống con người", "Lịch sử chỉ là sự ghi chép lại và không một ai biết sự thật\nNhững hậu duệ mới sẽ viết nên câu chuyện của riêng họ", "Cho đến khi..." };

    bool ta = true;
    public float ct;
    public float sm;

    // Start is called before the first frame update
    void Start()
    {
        ct = sm;

        if (GameSettingController.GameLangPlot == 0)
        {
            for (int i = 0; i < textM.Length; i++)
            {
                textM[i].text = textBG[i].text = DiaLogEN[i];
            }
        }
        else
        {
            for (int i = 0; i < textM.Length; i++)
            {
                textM[i].text = textBG[i].text = DiaLogVN[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ta == true)
        {
            ct -= Time.deltaTime;
        }
        if (ct < 0)
        {
            ta = false;
            CutscenesController.cus0 = 1;
            SceneManager.LoadScene("Cutscenes");
        }
    }
}
