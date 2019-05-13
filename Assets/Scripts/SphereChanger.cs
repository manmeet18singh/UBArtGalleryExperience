using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereChanger : MonoBehaviour {

    public void ChangeSphere(Transform nextSphere)
    {
        Camera.main.transform.parent.position = nextSphere.position;
    }
}
