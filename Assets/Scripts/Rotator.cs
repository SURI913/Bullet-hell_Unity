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
        // transform.Rotate(0f, rotationSpeed, 0f); 1�ʿ� 60���� �ƴ϶� �� �����ӿ� 60���� ȸ���Ѵ�.
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);

    }
}
