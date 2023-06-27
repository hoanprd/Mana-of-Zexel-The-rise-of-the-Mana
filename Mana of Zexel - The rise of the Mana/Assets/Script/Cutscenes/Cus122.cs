using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus122 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, JescaVAL1;
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
                dia.text = "It's exciting, we'll definitely win against Zane.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I told you not to be so subjective. Even if we're strong, that doesn't mean Zane will lose to us. Magicians have many dangerous tricks.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Okay, I won't let my guard down.";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrrrrrrrrrroooommmmmmmmmmmmmmmmm....";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "!!! The ground is shaking...";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What's going on!";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Earthquake?";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrrrrrrrrrrroommmmmmmmmmm...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It stop.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is it really an ordinary earthquake or is something going on?";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                JescaVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "It's dangerous, I have to collect it quickly and then return.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Huh? Is that Vayne's group? Do you guys have any business to come over here?";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Jesca? We just stopped by here for a little business. Why are you out here alone?";
            }
            else if (tang == 14)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Don't tell me you're taking the risk of picking medicine again?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Jesca";
                dia.text = "No, that's not it, I'm just collecting cacti.";
            }
            else if (tang == 16)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Collecting cactus? To do what?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Jesca";
                dia.text = "It's also complicated, my village is running out of water right now. So everyone uses every source of water they can find like a cactus.";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Did your village all have a source of water these days?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Jesca";
                dia.text = "Yes, my villagers use water from a river to create a large lake but the recent shoreline has made it salty through groundwater.";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Has this just happened or is it cyclical?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Jesca";
                dia.text = "My grandma said this is the first time this has happened to me so it's really hard to deal with.";
            }
            else if (tang == 22)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Well, if that's the case, why don't we drop by to have a look.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Jesca";
                dia.text = "Yes, please come over to my place.";
            }
            else if (tang >= 24)
            {
                CutscenesController.cus122 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Thật là phấn khởi, nhất định chúng ta sẽ chiến thắng trước tên Zane.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị đã nói đừng có chủ quan đó nha. Cho dù chúng ta mạnh nhưng không nghĩa tên Zane sẽ thua chúng ta đâu. Ma pháp sư có rất nhiều chiêu trò nguy hiểm.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Được rồi, em sẽ không mất cảnh giác đâu.";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrrrrrrrrrroooommmmmmmmmmmmmmmmm....";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "!!! Mặt đất đang rung chuyển...";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chuyện gì đang xảy ra thế!";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Động đất ư?";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrrrrrrrrrrroommmmmmmmmmm...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Dừng lại rồi.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thực sự là động đất thông thường hay là có chuyện gì đó đang xảy ra?";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                JescaVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Nguy hiểm thật, mình phải thu thập thật nhanh rồi còn về thôi.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Hể? Là nhóm anh Vayne đó ư? Mọi người có công chuyện gì cần ghé qua đây ư?";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Jesca ư? Bọn a chỉ ghé qua đây với một chút công chuyện thôi. Tại sao em lại ở ngoài này một mình?";
            }
            else if (tang == 14)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đừng nói là em lại mạo hiểm đi hái thuốc đó?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Jesca";
                dia.text = "Không, không phải thế đâu, em đang thu thập xương rồng thôi.";
            }
            else if (tang == 16)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thu thập xương rồng ư? Để làm gì thế?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Jesca";
                dia.text = "Mọi chuyện cũng khá phức tạp, ngôi làng của em hiện đang cạn kiệt nguồn nước. Nên mọi người đều sử dụng mọi nguồn nước có thể tìm được như cây xương rồng chẳng hạn.";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chẳng lẽ hồi giờ làng em đều phải một nguồn nước nào đó sao?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Jesca";
                dia.text = "Đúng thế, dân làng em sử dụng nguồn nước từ một con sông để tạo nên một con hồ lớn nhưng bờ biển gần đây khiến nó nó đã bị nhiễm mặn thông qua mạch nước ngầm.";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chuyện này chỉ mới xảy ra thôi hay là thường xuyên theo chu kỳ?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Jesca";
                dia.text = "Bà của em nói đây là lần đầu tiên gặp phải trường hợp này nên thật sự khó mà giải quyết được.";
            }
            else if (tang == 22)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vậy ư, nếu vậy để bọn anh ghé qua xem sao.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Jesca";
                dia.text = "Vâng ạ, mời anh chị qua chỗ em.";
            }
            else if (tang >= 24)
            {
                CutscenesController.cus122 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus122 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}