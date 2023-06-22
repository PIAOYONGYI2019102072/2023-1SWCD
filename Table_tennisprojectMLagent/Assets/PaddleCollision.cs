using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleCollision : MonoBehaviour
{
    // 当球和球拍发生碰撞时调用的方法
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball")) // 检查碰撞对象是否是球
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 重新加载当前场景
        }
    }
}

