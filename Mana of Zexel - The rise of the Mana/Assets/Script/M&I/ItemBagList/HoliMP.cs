using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoliMP : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.HoliMP;

        if (ContainerController.HoliMP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
