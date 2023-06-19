using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothSpeed = 10f;

    public bool SonaGeldikmi;

    public GameObject GidecegiYer;
    // Start is called before the first frame update
    private void Update()
    {
        
        
    }
    private void LateUpdate()
    {
        if (!SonaGeldikmi)

            if (target != null)
            {
                Vector3 desiredPosition = target.position + offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = smoothedPosition;
            }

            else
            transform.position = Vector3.Lerp(transform.position, GidecegiYer.transform.position + offset, 0.015f);
    }
}

