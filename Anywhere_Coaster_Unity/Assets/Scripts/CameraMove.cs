using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 7, gameObject.transform.position.z - 15);
        cam.transform.position = cameraPos;
    }
}
