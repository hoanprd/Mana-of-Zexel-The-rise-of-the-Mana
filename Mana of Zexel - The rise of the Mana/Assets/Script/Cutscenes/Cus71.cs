using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus71 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, ShanVAL1, AsilaVAR1;
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
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Everyone please wait outside, I will explain to Asila village chief.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I see, we'll wait.";
            }
            else if (tang == 3)
            {
                ShanVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hey, do you two feel something strange?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Is there anything unusual, Maria?";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... It's normal for me right now. Anyway, the village chief Alasa made it possible for us to get the fire core.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "It doesn't matter, we still don't know why these two lands are closed to other villages and towns.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "... I don't know about that either.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Just like I hope the two village chiefs here don't have any conflict with each other.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "There's good news for everyone, village chief Asila has already agreed to let you get the fire core.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thank you so much Shan!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Shan";
                dia.text = "Nothing! (I have to thank everyone.)";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "I pray that you can obtain the energy core without affecting the village.";
            }
            else if (tang == 14)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We promise we won't trouble this village! And is the village chief really going to give us an energy core like that, after all, it's the treasure of this village.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Asila";
                dia.text = "If this village does not have a fire core, it will be difficult to exploit the mineral resources here, but I want someone to take it away because that energy core is what attracts monsters around the village.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Asila";
                dia.text = "For a long time, Alasa and I have always wanted to live on fertile land and be able to grow and raise livestock like other villages. But fate is as ironic as it is now.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "If so, could you please tell me the location of the fire core.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Asila";
                dia.text = "The fire energy core is deep inside the volcano, just go north to get there. I will go with your group to see the situation.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chief, please trust us.";
            }
            else if (tang >= 20)
            {
                CutscenesController.cus71 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        else
        {
            if (tang == 1)
            {
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Mọi người hãy đợi ở ngoài, tôi sẽ giải thích cho trưởng làng Asila.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tôi hiểu rồi, chúng tớ sẽ đợi.";
            }
            else if (tang == 3)
            {
                ShanVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Này hai người có cảm giác điều gì lạ không?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có gì khác thường ư chị Maria?";
            }
            else if (tang == 6)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Đối với em hiện giờ vẫn bình thường. Dù sao trưởng làng Alasa đã giúp chúng ta có thể lấy được lõi năng lượng lửa.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Đó không phải vấn đề, chúng ta vẫn chưa biết tại sao hai vùng đất này lại đóng cửa với các làng và thị trấn khác.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Chuyện đó thì em cũng không biết nữa.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Cũng như chị mong là hai trưởng làng ở đây không có gì xung đột với nhau.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Có tin tốt cho mọi người đây, trưởng làng Asila đã đồng ý cho mấy người lấy lõi năng lượng lửa rồi đó.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn cậu nhiều Shan!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Shan";
                dia.text = "Không có gì! (Tôi phải cảm ơn mọi người mới đúng.)";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ta cầu mong mấy người có thể lấy được lõi năng lượng mà không ảnh hưởng gì đến ngôi làng.";
            }
            else if (tang == 14)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi hứa sẽ không gây phiền phức cho ngôi làng này đâu! Mà trưởng làng thật sự sẽ trao cho chúng tôi lõi năng lượng như thế luôn ư, dù sao đó cũng là báu vật của ngôi làng này.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Asila";
                dia.text = "Nếu ngôi làng này không còn lõi năng lượng lửa thì sẽ khó khai thác các nguồn khoáng sản ở đây, tuy nhiên ta lại muốn có người lấy nó đi vì lõi năng lượng đó chính là thứ thu hút các quái vật đến xung quanh ngôi làng.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Asila";
                dia.text = "Từ lâu ta và trưởng làng Alasa đã luôn muốn được sống trên mảnh đất màu mỡ và có thể trồng trọt chăn nuôi như bao ngôi làng khác. Nhưng số phận lại trớ trêu như hiện tại.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy thì nhờ ngài chỉ vị trí của lõi năng lượng lửa.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Asila";
                dia.text = "Lõi năng lượng lửa ở sâu bên trong núi lửa, chỉ cần đi về phía bắc là tới nơi. Ta sẽ đi cùng nhóm các người để xem tình hình.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Trưởng làng hãy tin tưởng ở chúng tôi.";
            }
            else if (tang >= 20)
            {
                CutscenesController.cus71 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno volcano");
            }
        }
        
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus71 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}