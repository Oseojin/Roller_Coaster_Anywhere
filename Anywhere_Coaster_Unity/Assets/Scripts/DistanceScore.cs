using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScore : MonoBehaviour
{
    private static DistanceScore instance = null;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float distance = 0f;
    private Vector3 startPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        distance = 0f;
    }

    public void checkDistance(Vector3 coasterVec)
    {
        Vector3 coaster2DVec = new Vector3(coasterVec.x, 0f, coasterVec.z);
        distance = Vector3.Distance(startPos, coaster2DVec);

        Debug.Log(distance);
    }

    public static DistanceScore getInstance()
    {
        return instance;
    }
}
