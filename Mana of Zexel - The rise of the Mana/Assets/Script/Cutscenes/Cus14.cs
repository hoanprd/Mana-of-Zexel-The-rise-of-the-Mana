using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus14 : MonoBehaviour
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Finally at peace, what's wrong with the golems, usually we only get attacked when we invade their territory.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Could it be that their territory is this whole forest?";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Normally the golemns would disperse in the deep corners of the forest, not in the middle of the forest like this, unless?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Did you think of something else?";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Are they looking for another territory?";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "That's right and not just that! Their old territory is having problems as if it was taken by someone.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Who usually goes to take over golemn territory?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "There must be something terrible in the eastern part of this forest, only strong beings dare to touch the golems.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay if we're going to try it.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "You don't care about your father's information, Vayne?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "We still have time, so let's try to see what the forest still contains..";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Okay, if you two agree to follow, let's head to the east of the forest.";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus14 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cuối cùng cũng được yên, tụi Golemn bị sao thế nhỉ thường chúng ta chỉ bị tấn công khi xâm phạm lãnh thổ chúng thôi";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chẳng lẻ lãnh thổ chúng là cả khu rừng này ư?";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thường thì Golemn sẽ phân tán ở góc sâu của khu rừng chứ không có ở giữa rừng như thế này đâu, trừ khi?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chị nghĩ ra gì đó khác ư?";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chẳng lẻ chúng đi tìm lãnh thổ khác ư?";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đúng thế và không chỉ đơn thuần như vậy đâu! Lãnh thổ cũ của bọn chúng đang gặp vấn đề như bị ai đó chiếm mất.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thường ai lại đi chiếm lãnh thổ golem thế?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Chắc chắn có thứ gì đó rất khủng khiếp ở phía đông khu rừng này, chỉ có sinh vật mạnh mẽ mới dám động đến tụi golemn.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi nếu như chúng ta sẽ đến đó thử.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Cậu không quan tâm thông tin của cha cậu ư Vayne?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta vẫn còn thời gian nên hãy tranh thủ xem thử khu rừng còn ẩn chứa những điều gì.";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Được thôi nếu hai đứa đã đồng ý đi theo thì tiến về phía đông khu rừng thôi.";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus14 = 1;
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
        CutscenesController.cus14 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}