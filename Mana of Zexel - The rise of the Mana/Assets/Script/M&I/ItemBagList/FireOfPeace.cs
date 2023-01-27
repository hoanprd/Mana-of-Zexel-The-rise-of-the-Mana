using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireOfPeace : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.FireOfPeace;

        if (ContainerController.FireOfPeace <= 0)
        {
            Destroy(gameObject);
        }
    }
}
