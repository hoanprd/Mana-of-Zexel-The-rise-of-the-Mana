using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    ThiefTrigger tt;
    //public Transform target2;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("CPosi1") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("CPosi1"));
            PlayerPrefs.SetFloat("x", 5);
            PlayerPrefs.SetFloat("y", 1);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("CPosi1", 0);
        }
        else if (PlayerPrefs.GetInt("BPosi1") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("BPosi1"));
            PlayerPrefs.SetFloat("x", -59);
            PlayerPrefs.SetFloat("y", -14);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("BPosi1", 0);
        }
        else if (PlayerPrefs.GetInt("CPosi2") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("CPosi2"));
            PlayerPrefs.SetFloat("x", -5);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("CPosi2", 0);
        }
        else if (PlayerPrefs.GetInt("BPosi2") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("BPosi2"));
            PlayerPrefs.SetFloat("x", -42);
            PlayerPrefs.SetFloat("y", -2);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("BPosi2", 0);
        }
        else if (PlayerPrefs.GetInt("CPosi3") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("CPosi3"));
            PlayerPrefs.SetFloat("x", 6);
            PlayerPrefs.SetFloat("y", -3);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("CPosi3", 0);
        }
        else if (PlayerPrefs.GetInt("BPosi3") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("BPosi3"));
            PlayerPrefs.SetFloat("x", 4.5f);
            PlayerPrefs.SetFloat("y", 4);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("BPosi3", 0);
        }
        else if (PlayerPrefs.GetInt("CPosi4") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("CPosi4"));
            PlayerPrefs.SetFloat("x", -4);
            PlayerPrefs.SetFloat("y", 14);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("CPosi4", 0);
        }
        else if (PlayerPrefs.GetInt("BPosi4") == 1)
        {
            Debug.Log(PlayerPrefs.GetInt("BPosi4"));
            PlayerPrefs.SetFloat("x", -48);
            PlayerPrefs.SetFloat("y", -40);
            PlayerPrefs.SetFloat("z", 0);
            PlayerPrefs.SetInt("BPosi4", 0);
        }

        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("y", transform.position.y);
        PlayerPrefs.SetFloat("z", transform.position.z);
    }
}
