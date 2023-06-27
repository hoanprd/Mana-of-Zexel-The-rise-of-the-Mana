using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus131 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MrLanceVAR1, KlenerVAR1;
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
                dia.text = "Looks like the monster just now is the last one to deal with.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Why did they attack inside the town so suddenly, they don't dare to go deep into the town these days.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Something provoked them. Surely the earthquake just now had something to do with this.";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria, are you all right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "I'm fine, you are fine dad! Phuhhh...";
            }
            else if (tang == 6)
            {
                MrLanceVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Thank you, Vayne, the people have been safely evacuated.";
            }
            else if (tang == 7)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Will the material monsters come if we're absent? We can't keep this going.";
            }
            else if (tang == 8)
            {
                KlenerVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'll use the barrier to stop them.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "If it's the barrier I used, it won't be strong enough to hold them back.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Don't worry I will upgrade the barrier stronger to protect the town of Zexel and the village in the inferno desert. Make sure to give us enough time to get rid of Zane.";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus131 = 1;
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
                dia.text = "Có vẻ con quái vật vừa rồi là con cuối để giải quyết.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tại sao bọn chúng lại tấn công bên trong thị trấn đột ngột vậy, bọn chúng hồi giờ đâu dám vào sâu trong thị trấn đâu.";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có thứ gì đó đã kích động bọn chúng. Chắc hẳn trận động đất hồi nãy cũng có liên quan đến chuyện này.";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria, con vẫn ổn chứ?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Con không sao, cha không sao là con mừng rồi.";
            }
            else if (tang == 6)
            {
                MrLanceVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Cảm ơn cậu Vayne, người dân đã được di dời an toàn rồi.";
            }
            else if (tang == 7)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tụi quái vật liệu sẽ kéo đến nếu chúng ta vắng mặt chứ? Chúng ta không thể chuyện này cứ tiếp diễn được.";
            }
            else if (tang == 8)
            {
                KlenerVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tớ sẽ sử dụng kết giới để ngăn chặn chúng lại.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nếu là kết giới của chị từng dùng thì sẽ không đủ mạnh để giữ chân bọn chúng đâu.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đừng lo em sẽ nâng cấp kết giới mạnh hơn để bảo vệ thị trấn Zexel và ngôi làng ở inferno desert. Đảm bảo kéo dài đủ thời gian cho chúng ta xử lý được tên Zane.";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus131 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus131 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}