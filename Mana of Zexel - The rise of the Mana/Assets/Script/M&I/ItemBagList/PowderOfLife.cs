using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowderOfLife : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.PowderOfLife;

        if (ContainerController.PowderOfLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}
