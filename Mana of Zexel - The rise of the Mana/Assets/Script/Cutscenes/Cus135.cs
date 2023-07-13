using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus135 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, MariaVAR1, ZexelVAR1;
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
                NameTag.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggg...";
            }
            else if (tang == 2)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is this light... an illusion of Zexel?";
            }
            else if (tang == 3)
            {
                ZexelVAR1.SetActive(true);
                NameTagText.text = "Zexel";
                dia.text = "Welcome, you must have the key to the room of truth to get through here, I hope you all go further to the east of the temple to reach the room of truth.";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Gone... Zexel wants us to go to the room of truth.";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                ZexelVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroommmmm...";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Another earthquake!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks like we don't have much time, let's hurry to the room of truth.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                NameTagText.text = "Alia";
                dia.text = "... (This feeling feels very familiar but what is it?)";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus135 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggg...";
            }
            else if (tang == 2)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Luồng sáng này... là ảo ảnh của Zexel ư?";
            }
            else if (tang == 3)
            {
                ZexelVAR1.SetActive(true);
                NameTagText.text = "Zexel";
                dia.text = "Chào mừng, chắc hẳn để qua được đây các bạn đã có chìa khóa dẫn đến căn phòng sự thật, tôi mong rằng mọi người hãy tiến sâu về phía đông ngôi đền để đến căn phòng sự thật.";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Biến mất rồi... Zexel muốn chúng ta đi đến căn phòng của sự thật ư.";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                ZexelVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroommmmm...";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Lại động đất nữa rồi!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ chúng ta không còn nhiều thời gian đâu, hãy mau đến căn phòng của sự thật xem sao.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                NameTagText.text = "Alia";
                dia.text = "... (Cảm giác này mình cảm thấy rất quen thuộc nhưng rốt cuộc đó là gì?)";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus135 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
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
        CutscenesController.cus135 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel temple");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}