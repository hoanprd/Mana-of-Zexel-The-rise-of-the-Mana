using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CusE3 : MonoBehaviour
{
    ExtraCutscenesController ecc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        ecc = FindObjectOfType<ExtraCutscenesController>();
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
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Looks like the land is green again, but there's still no sign of life coming back, right?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "If this land is both the life of the two villages of Inferno volcano and Inferno ice, then life will probably return here in the near future.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, this area might be similar to the Wishing forest.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "You mean there will be many materials for alchemy?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Sure, but maybe I won't wait that long.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'm sure my mother will be pleased if you bring back a lot of new ingredients that she hasn't seen.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "You said you learned alchemy from your mother, right? She must be very famous in the country where you live, right?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "My mother isn't that famous, just an ordinary alchemist on the outskirts of the capital.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "The outskirts of the capital? It's not bad, there would be more customers to visit the alchemy shop, right?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, my mother also opened a store there and there were a lot of customers. That means I have to help her a lot.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "But now she'll be very busy without you by her side.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "One day I will open my own alchemy shop too. It would be nice if her mother saw that she would have such a stable life.";
            }
            else if (tang >= 13)
            {
                ExtraCutscenesController.cuse3 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ mảnh đất đã xanh tươi trở lại nhưng vẫn chưa có giấu hiệu sự sống nào quay lại hết nhỉ?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nếu như mảnh đất này là cả sự sống của hai ngôi làng Inferno volcano và Inferno ice thì chắc sự sống sẽ quay lại đây trong tương lai sớm thôi.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, khu vực này có thể sẽ giống với Wishing forest.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Ý em là sẽ có nhiều nguyên liệu cho giả kim thuật ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chắc chắn là vậy rồi nhưng có lẻ em sẽ không đợi lâu được như thế.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chắc hẳn mẹ em sẽ hài lòng nếu em đem nhiều thứ nguyên liệu mới về mà bà ấy chưa từng thấy.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Em từng nói là em học giả kim thuật từ mẹ em đúng không? Chắc hẳn bà ấy cũng rất nổi tiếng ở quê em sống nhỉ?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mẹ em không có nổi tiếng như thế đâu, chỉ là một nhà giả kim bình thường ở ngoại ô thủ đô.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Ngoại ô thủ đô ư? Cũng không tệ, chắc hẳn ở đó sẽ có khách hàng ghé thăm cửa hàng giả kim hơn chứ nhỉ?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, mẹ em cũng mở cửa hàng ở đó và khách ghé cũng khá nhiều. Đồng nghĩa em phải phụ giúp bà ấy khá nhiều.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nhưng giờ bà ấy sẽ rất bận rộn nếu không có em cạnh bên.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Một ngày nào đó chị cũng sẽ mở một cửa tiệm giả kim thuật riêng cho mình mới được. Sẽ thật tốt nếu mẹ chị thấy chị sẽ có một cuộc sống ổn định như vậy.";
            }
            else if (tang >= 13)
            {
                ExtraCutscenesController.cuse3 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
            }
        }
    }

    public void Pressnext()
    {
        ecc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        ecc.FXCutscenes(1);
        ExtraCutscenesController.cuse3 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Alta inferno");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        ecc.BGMCutscenes(2, false);
    }
}
