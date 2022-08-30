using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HV3 : MonoBehaviour
{
    public Text show1;
    public GameObject show2;
    private bool pick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pick && Input.GetKeyDown(KeyCode.Space) && PlayerPrefs.GetInt("cus8") == 1 && PlayerPrefs.GetInt("SEP") > 0 && PlayerPrefs.GetInt("SHVStop3") == 0)
        {
            PlayerPrefs.SetInt("SHVStop3", 1);
            show2.SetActive(true);
            show1.text = "Help +1";
            PlayerPrefs.SetInt("SEP", PlayerPrefs.GetInt("SEP") - 1);
            PlayerPrefs.SetInt("SHV", PlayerPrefs.GetInt("SHV") + 1);
            Invoke("delay1", 1f);
        }
        if (PlayerPrefs.GetInt("SHV") == 3 && PlayerPrefs.GetInt("SHVStop1") == 1 && PlayerPrefs.GetInt("SHVStop2") == 1 && PlayerPrefs.GetInt("SHVStop3") == 1)
        {
            PlayerPrefs.SetInt("SHVStop1", 2);
            PlayerPrefs.SetInt("SHVStop2", 2);
            PlayerPrefs.SetInt("SHVStop3", 2);
            SceneManager.LoadScene(15);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            pick = true;
        }
    }
    void delay1()
    {
        show2.SetActive(false);
        //Destroy(gameObject);
    }
}
