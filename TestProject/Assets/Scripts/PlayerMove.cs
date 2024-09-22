using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // �ړ����x��ݒ�
    public float speed = 5.0f;

    void Update()
    {
        // ���E�̓��͂��擾 (A�L�[��D�L�[�A�܂��͍����L�[�ƉE���L�[)
        float moveHorizontal = Input.GetAxis("Horizontal");

        // �I�u�W�F�N�g�̈ʒu���X�V
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        // �ʒu��ω�������
        transform.Translate(movement * speed * Time.deltaTime);
    }
}