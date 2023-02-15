using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0f, rotationSpeed, 0f); 1초에 60도가 아니라 한 프레임에 60도로 회전한다.
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);

    }
}
