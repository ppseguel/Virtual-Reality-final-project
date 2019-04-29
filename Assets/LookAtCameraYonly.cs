using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCameraYonly : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cameraToLookAt;
    
    void Update() 
    {
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(cameraToLookAt.transform.position - v); 
    }

}
