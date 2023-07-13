using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus115 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
    public GameObject NameTag;
    private int tang, stop1, stop2;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        stop1 = 0;
        stop2 = 0;
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
                dia.text = "Ma'am, is this mineral enough?";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Thank you... thank you very much, this will help us a lot.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "No problem, glad to have helped.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "I ask you to accept this little bit of sincerity from me.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "";
                dia.text = "Photonria +1";
                if (stop1 == 0)
                {
                    stop1 = 1;
                    ContainerController.PhotonriaPick = 1;
                }
            }
            else if (tang == 6)
            {
                NameTagText.text = "";
                dia.text = "Baxiata +1";
                if (stop2 == 0)
                {
                    stop2 = 1;
                    ContainerController.BaxiataPick = 1;
                }
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Does your family specialize in producing these gems?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Yes, these mineral resources will be finely processed to obtain, but the precious gem is not only full of energy but also collectible, so its export value will be high.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "So that's it! Really great.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus115 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thưa cô, số lượng khoáng sản này đủ rồi chứ?";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Cảm ơn... cảm ơn rất nhiều, nhiêu đây sẽ giúp chúng tôi rất nhiều.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không có gì, rất vui vì đã được giúp đỡ.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Tôi mong cậu hãy nhận chút thành ý này của tôi.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "";
                dia.text = "Photonria +1";
                if (stop1 == 0)
                {
                    stop1 = 1;
                    ContainerController.PhotonriaPick = 1;
                }
            }
            else if (tang == 6)
            {
                NameTagText.text = "";
                dia.text = "Baxiata +1";
                if (stop2 == 0)
                {
                    stop2 = 1;
                    ContainerController.BaxiataPick = 1;
                }
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Gia đình cô chuyên sản xuất các viên ngọc này ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Villager (Woman)";
                dia.text = "Đúng thế, các nguồn khoáng sản này sẽ được chế biến mịn để thu được nhưng viên ngọc quý giá không chỉ mang đầy năng lượng mà còn mang tính sưu tầm nên mang giá trị xuất khẩu bên ngoài sẽ cao.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "Ra là thế! Tuyệt vời thật.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus115 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
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
        CutscenesController.cus115 = 1;
        ContainerController.LoadingOpen = true;
        if (tang < 5)
        {
            ContainerController.PhotonriaPick = 1;
            ContainerController.BaxiataPick = 1;
        }
        else if (tang == 5)
        {
            ContainerController.BaxiataPick = 1;
        }
        SceneManager.LoadScene("Inferno volcano");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}