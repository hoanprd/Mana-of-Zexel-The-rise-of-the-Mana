using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus75 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Very similar... very similar to Zexel's fire core.";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "So Vayne succeeded?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "If you want to know success or not, you have to try to know. I think it might work because I successfully extracted and split Zexel's and mine's fire energy cores in two.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "I can feel the abundant mana energy in both of those fire energy cores.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "The question is, can the fire elemental mana you generate maintain the stability of the volcano?";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "In that case, let's go to the inferno volcano and replace Vayne's fire core! We don't have much time, right?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right! Anyway, I've put all my heart into this clone energy core. Definitely success!";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus75 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Save room");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Rất giống... rất giống lõi năng lượng lửa của Zexel.";
            }
            else if (tang == 4)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vậy là Vayne đã thành công ư?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Muốn biết thành công hay không thì phải thử mới biết được. Tớ nghĩ có thể thành công rồi vì tớ đã thành công chiết xuất và tách lõi năng lượng lửa của Zexel và của tớ ra làm hai.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị có thể cảm nhận được nguồn năng lượng mana dồi dào ở cả hai lõi năng lượng lửa ấy.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vấn đề là mana nguyên tố lửa của em tạo ra có thể duy trì sự ổn định của núi lửa không?";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nếu vậy chúng ta mau đến inferno volcano thay lõi năng lượng lửa của Vayne vào đi! Thời gian chúng ta không còn nhiều nữa đúng không?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Dù sao tớ đã dùng hết tâm huyết cho lõi năng lượng bản sao này. Nhất định phải thành công!";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus75 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Save room");
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
        CutscenesController.cus75 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Save room");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}