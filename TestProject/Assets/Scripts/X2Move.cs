using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveX : MonoBehaviour
{
    public float speed = 2f; // ˆÚ“®‘¬“x

    void Update()
    {
        // xÀ•W‚ğ™X‚É‘‰Á‚³‚¹‚é
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}