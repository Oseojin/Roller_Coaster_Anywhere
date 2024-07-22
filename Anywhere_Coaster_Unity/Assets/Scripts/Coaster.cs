using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coaster : MonoBehaviour
{
    private Rigidbody rb;
    public float power;
    [SerializeField]
    private bool isRail = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(rb.velocity == Vector3.zero)
        {
            // 정지 이벤트
            DistanceScore.getInstance().checkDistance(gameObject.transform.position);
        }
    }

    private void FixedUpdate()
    {
        if (isRail)
        {
            Vector3 frontVec = gameObject.transform.forward;
            rb.AddForce(frontVec * power, ForceMode.Acceleration);
            Debug.Log(power);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Rail"))
        {
            isRail = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Rail"))
        {
            isRail = false;
        }
    }
}
