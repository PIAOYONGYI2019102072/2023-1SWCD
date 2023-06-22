using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball1"))
        {
            // 获取球的刚体组件
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            // 获取球的Z轴方向速度
            float ballZVelocity = ballRigidbody.velocity.z;

            // 计算球拍受到的力
            float paddleForce = ballRigidbody.mass * Mathf.Abs(ballZVelocity);

            Debug.Log("Ball Z Velocity: " + ballZVelocity);
            Debug.Log("Paddle Force: " + paddleForce);
        }
    }
}

