using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float minAngle = 0f; // Y 轴最小角度
    public float maxAngle = 90f; // Y 轴最大角度
    public float minXAngle = 0f; // X 轴最小角度
    public float maxXAngle = 90f; // X 轴最大角度

    private void Start()
    {
        // 生成随机的 Y 轴角度
        float randomYAngle = Random.Range(minAngle, maxAngle);

        // 生成随机的 X 轴角度
        float randomXAngle = Random.Range(minXAngle, maxXAngle);

        // 将球拍绕 Y 轴和 X 轴旋转到随机角度
        transform.rotation = Quaternion.Euler(randomXAngle, randomYAngle, 0f);
    }

    // 其他球拍控制逻辑...
}


