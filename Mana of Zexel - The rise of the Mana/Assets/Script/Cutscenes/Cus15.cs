using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus15 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1;
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
                NameTag.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Graaaaaaaaaaaaaaa...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Impossible! How could such a large monster appear in a forest like this!";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's really big, it looks like a solid giant block.";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It's an iron golemn. Usually iron golems are close to extinction because there is no food source of iron.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "It seems humans are increasingly mining iron making them mad?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "The problem is that we can't defeat iron golems with this much strength!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What is it that we have three people is still not enough?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Iron Golems are usually very difficult to damage them, alchemy's mana attacks are also useless because they are partially resisted by the body, physical damage is also useless.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "In that case, the iron golems will cause the other golems in this forest to enter the town.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Don't worry we'll find another way to fix it.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Do you have a way?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right and we don't have to fight.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Maria is amazing! Is it possible to defeat a monster without fighting?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Are you going to seal it?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Not really, a golemn that big would be difficult to seal even if it was only for a short time.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "I will make something that can restrict this iron golemn's movement to restrain it. Vayne, I ask you to help me pick up some threads around the forest!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "I see, let's go Alia, we have work to do.";
            }
            else if (tang >= 18)
            {
                CutscenesController.cus15 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Graaaaaaaaaaaaaaa...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Không thể nào! Làm sao một con quái vật lớn như thế có thể xuất hiện ở khu rừng như thế này!";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nó to thật đấy, trông nó như một khối khổng lồ vô cùng chắc chắn.";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nó là một con golemn sắt. Thường thì golemn sắt đã gần tuyệt chủng vì không có nguồn thức ăn là sắt.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ con người ngày càng khai thác sắt khiến bọn chúng nổi điên ư?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Vấn đề là chúng ta không thể nào đánh bại golemn sắt với sức mạnh chỉ chừng này!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Gì thế chúng ta có 3 người vẫn không đủ sao?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Golemn sắt thường rất khó gây sát thương lên người chúng, các đòn tấn công dùng mana của giả kim thuật cũng vô dụng vì chúng kháng được một phần nhờ vào cơ thể, sát thương vật lý cũng vô dụng.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Nếu vậy thì golemn sắt sẽ khiến tụi golemn khác ở khu rừng này tiến vào thị trấn mất.";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đừng lo chúng ta sẽ dùng cách khác để khắc phục.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chị có cách gì ư?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế và chúng ta không cần phải đánh nhau.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị Maria đỉnh thế! Có thể đánh bại được một con quái vật mà không cần đánh nhau ư?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không lẽ chị định phong ấn nó ư?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Không hẳn thế, một con golemn to như thế thì rất khó phong ấn cho dù được thì cũng chỉ ngắn hạn.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị sẽ làm ra một thứ có thể hạn chế golemn sắt này di chuyển để kiềm hãm nó lại. Vayne, chị nhờ em nhặt một số sợi tơ xung quanh khu rừng giúp chị!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em hiểu rồi, đi thôi Alia, chúng ta có việc phải làm rồi.";
            }
            else if (tang >= 18)
            {
                CutscenesController.cus15 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus15 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}