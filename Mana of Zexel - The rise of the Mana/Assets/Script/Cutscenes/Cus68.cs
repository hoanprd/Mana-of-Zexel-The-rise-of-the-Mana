using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus68 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, ShanVAL1, ShanVAR1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Oh my gosh! It's even colder in here! My hand... as if I can't feel it anymore...";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I can feel an abundance of mana here.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Me too... it's cold to admit.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "(Is there a core of energy here?)";
            }
            else if (tang == 5)
            {
                ShanVAL1.SetActive(true);
                MariaVAL1.SetActive(false);
                NameTagText.text = "Shan";
                dia.text = "Be careful, there are a lot of slimes here!";
            }
            else if (tang == 6)
            {
                ShanVAL1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "(Slime so there's a high percentage of mana core is here!)";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What! Slime? Those filthy things too...";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                ShanVAR1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Are you afraid of slimes?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "It's nothing... they just look disgusting.";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "By the way, Shan, usually people in the villages in the two regions of the inferno volcano and inferno ice often interact with each other?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Shan";
                dia.text = "No, it's just me who frequents.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Just you?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Shan";
                dia.text = "I am the servant of both village chiefs, my father is from inferno ice and my mother is from inferno volcano.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Weird...";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Shan";
                dia.text = "You don't need to care about me or about these two villages. Let's focus on finding ice crystals.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus68 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ôi trời! Vào trong này nó càng lạnh hơn nữa! Tay của mình... như không còn cảm giác nữa...";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mình có thể cảm nhận được nguồn mana dồi dào ở đây.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị cũng thế... công nhận lạnh thật.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "(Có lẻ nào lõi năng lượng của ở đây chăng?)";
            }
            else if (tang == 5)
            {
                ShanVAL1.SetActive(true);
                MariaVAL1.SetActive(false);
                NameTagText.text = "Shan";
                dia.text = "Hãy cẩn thận, ở đây có nhiều slime lắm đấy!";
            }
            else if (tang == 6)
            {
                ShanVAL1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "(Slime ư vậy phần trăm cao ở đây có lỗi năng lượng rồi!)";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Cái gì! Slime ư! Mấy thứ nhớt nhát đó nữa ư...";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                ShanVAR1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Bộ cô sợ bọn slime ư?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Không có gì... chẳng qua bọn chúng nhìn tởm kiểu gì thôi.";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "À mà Shan, thường người dân trong làng ở hai vùng inferno volcano và inferno ice thường qua lại với nhau à?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Shan";
                dia.text = "Không, chỉ có tôi là người thường xuyên qua lại thôi.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chỉ có cậu thôi sao?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Shan";
                dia.text = "Tôi là người hầu của cả hai trưởng làng, ba tôi là người thuộc inferno ice còn mẹ tôi ở inferno volcano.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Kỳ lạ thật...";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Shan";
                dia.text = "Mấy người không cần quan tâm về tôi cũng như chuyện của hai ngôi làng này đâu. Hãy tập trung tìm kiếm tinh thể băng đi.";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus68 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideIceCave");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus68 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }
}