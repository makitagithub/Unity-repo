using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 移動速度を設定
    public float speed = 5.0f;

    void Update()
    {
        // 左右の入力を取得 (AキーとDキー、または左矢印キーと右矢印キー)
        float moveHorizontal = Input.GetAxis("Horizontal");

        // オブジェクトの位置を更新
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        // 位置を変化させる
        transform.Translate(movement * speed * Time.deltaTime);
    }
}