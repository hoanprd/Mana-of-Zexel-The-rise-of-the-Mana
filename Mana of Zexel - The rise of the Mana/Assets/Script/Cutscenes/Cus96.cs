using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus96 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, MariaVAL1, MeruVAL1, MeruVAR1;
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
                dia.text = "Madam Meru, here she is! Please save her!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "I know, come on... this wound...";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Can you save her?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Meru";
                dia.text = "If I had come later, it would have been late, but now there is still a chance for her to live.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thank goodness, if so, how long will it take to heal, ma'am?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Meru";
                dia.text = "I think it will be a few days! It depends on this little girl Alia's condition as well as the medication.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Meru";
                dia.text = "Another thing is that I need you two to get me the following ingredients to make her potion.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "We're ready for this!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Meru";
                dia.text = "Wait for me, ...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Meru";
                dia.text = "Okay, here's the list of things we need. That seems like a lot, guys, try to collect it as soon as possible.";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "These things we can get quickly.";
            }
            else if (tang == 12)
            {
                MeruVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay! In that case, let's go, Maria. Alia I will definitely help you as much as I can!";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 14)
            {
                MeruVAL1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "This little girl's wound... The person who caused it must be a cruel and inhumane guy... even if the two of them bring back the ingredients, there's still one important thing missing to make the antidote.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus96 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thưa bà Meru, cô ấy đây ạ! Mong bà hãy cứu cô ấy!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Ta biết rồi, nào... vết thương này...";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Bà có thể cứu cô ấy không?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Meru";
                dia.text = "Nếu như ta đến trễ hơn có lẽ đã muộn, còn bây giờ thì vẫn còn cơ hội cho cô ấy sống.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tạ ơn trời, nếu vậy sẽ mất bao lâu để chữa trị vậy thưa bà?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Meru";
                dia.text = "Ta nghĩ sẽ vài ngày đấy! Việc đó tùy thuộc vào thể trạng của cô bé Alia này cũng như là thuốc men.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Meru";
                dia.text = "Một điều nữa đó là ta cần hai người kiếm cho ta một số nguyên liệu sau để làm thuốc cho cô ấy.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng cháu sẵn sàng vì chuyện này ạ!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Meru";
                dia.text = "Đợi ta tý, ...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Meru";
                dia.text = "Được rồi, đây là danh sách những thứ mà ta cần. Có vẻ hơi nhiều đó, các cô cậu hãy cố gắng thu thập càng sớm thì càng tốt.";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Những thứ này chúng ta có thể kiếm nhanh được.";
            }
            else if (tang == 12)
            {
                MeruVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Được! Nếu vậy chúng ta mau đi thôi Maria. Alia tớ nhất định sẽ giúp cậu hết sức có thể!";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 14)
            {
                MeruVAL1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Vết thương của cô bé này... Kẻ gây ra chắc là một tên tàn ác và vô nhân tính rồi... cho dù hai đứa nó có đem nguyên liệu về thì vẫn còn thiếu một thứ quan trọng để chiều chế thuốc giải.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus96 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus96 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}