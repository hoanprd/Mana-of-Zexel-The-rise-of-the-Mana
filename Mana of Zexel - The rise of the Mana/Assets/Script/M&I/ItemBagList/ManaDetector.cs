using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaDetector : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaDetector;

        if (ContainerController.ManaDetector <= 0)
        {
            Destroy(gameObject);
        }
    }
}
