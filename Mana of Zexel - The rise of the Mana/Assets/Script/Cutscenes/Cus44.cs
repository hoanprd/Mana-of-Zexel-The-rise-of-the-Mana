using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus44 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MariaVAR1;
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
                dia.text = "This should be enough for Orina's request.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This job is dangerous. I wonder if she really helps us wholeheartedly?";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "She's really evil making us do dangerous things.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Maybe Orina has her own reasons. Which is weird, what kind of grocery store sells poisons like this?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Come to think of it, what is she planning to use this for? She's not an apothecary like anyone else in town buys this.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Very suspicious indeed. Did she know anything about alchemy?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "I don't know but Orina is a real mystery.";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Let's hurry back before more monsters attack us!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "(Usually poison for making potions, if she knows alchemy but isn't an alchemist, that's odd...)";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "(Never mind, this doesn't affect me much)";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus44 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chắc nhiêu đây là đủ số lượng của Orina yêu cầu rồi.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Công việc này nguy hiểm thật. Không biết cô ta có thực sự giúp chúng ta tận tình không nữa?";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ả ta đúng là xấu xa bắt chúng ta làm mấy thứ nguy hiểm.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Chắc là Orina có lý do riêng của cô ấy. Mà kỳ lạ thật, tiệm tạp hóa nào lại đi bán mấy thứ độc dược như này chứ?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nhắc mới để ý, cô ta tính dùng này làm gì thế nhỉ? Cô ta có phải dược sư đâu cũng như đâu ai mua thứ này trong thị trấn.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật sự rất đáng nghi. Liệu rằng cô ta có biết gì về giả kim thuật sao?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Không biết nữa nhưng Orina là một người bí ẩn thật.";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chúng ta mau quay về thôi trước khi có thêm quái vật tấn công chúng ta đấy!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "(Thường thì độc tố để chế tạo thuốc, nếu cô ta biết giả kim thuật mà không phải là nhà giả kim thuật thì chẳng lẻ...)";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "(Mà thôi bỏ đi, chuyện này cũng không ảnh hưởng đến mình là mấy)";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus44 = 1;
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
        CutscenesController.cus44 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}