using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    public float speed = 2f; // �ړ����x

    void Update()
    {
        // x���W�����X�ɑ���������
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}