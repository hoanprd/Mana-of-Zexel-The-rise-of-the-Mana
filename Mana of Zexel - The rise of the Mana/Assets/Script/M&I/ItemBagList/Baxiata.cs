using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baxiata : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Baxiata;

        if (ContainerController.Baxiata <= 0)
        {
            Destroy(gameObject);
        }
    }
}
