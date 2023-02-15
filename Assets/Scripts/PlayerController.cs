using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //������ ����
    private Rigidbody playerRigidbody; //�̵��� ��� �� ������ٵ� ������Ʈ
    //�÷��̾� ������ٵ� ������ ���� ������ٵ� Ÿ���� ������Ʈ�� ����Ű�� ��
    public float speed = 8f; //�̵� �ӷ�

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    //���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}

        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    //�Ʒ��� ����Ű �Է��� ������ ��� -z ���� �� �ֱ�
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //}

        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    //������ ����Ű �Է��� ������ ��� x ���� �� �ֱ�
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    //���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}

        //���� ������� ���׷��̵� �� �ڵ�

        // ������� �������� �Է°��� �̵� �ӷ��� ����� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeend = zInput * speed;

        //Vector 3 �ӵ��� (xSpeed, 0 , zSpeed)�� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeend); 
        //�ӵ� ǥ���� Vector3�� ǥ��,
        // ������ AddForce�� �ٸ����� ������ �����̴�.
        // ������ ���ν�Ƽ�� ����� �ӵ��� �������ִ� ���� ���� �ӵ���
        // ����� �� �ӵ��� ����ϴ� ���̴�. ���� ������ �����ϰ� �ӵ��� 
        // ��� ����˴ϴ�. 

        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);

        //���� �����ϴ�  GameManager Ÿ���� ������Ʈ�� ã�ư��� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();
        //������ GameManager ������Ʈ�� EndGame() �޼��� ����
        gameManager.EndGame();
    }
}
