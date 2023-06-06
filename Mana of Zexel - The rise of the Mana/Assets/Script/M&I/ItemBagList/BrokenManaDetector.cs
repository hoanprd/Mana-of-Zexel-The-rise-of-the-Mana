using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrokenManaDetector : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.BrokenManaDetector;

        if (ContainerController.BrokenManaDetector <= 0)
        {
            Destroy(gameObject);
        }
    }
}
