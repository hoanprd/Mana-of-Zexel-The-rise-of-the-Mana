using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPainMedicine : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.BackPainMedicine;

        if (ContainerController.BackPainMedicine <= 0)
        {
            Destroy(gameObject);
        }
    }
}
