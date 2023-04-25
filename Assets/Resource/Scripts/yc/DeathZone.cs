using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //当人物角色碰到该区域时则将人物设置到最开始的位置
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //设置角色位置为最开始的位置，这里假设你已经有了一个名为"PlayerStartPoint"的对象来表示角色的开始位置
            other.transform.position = GameObject.Find("PlayerStartPoint").transform.position;
        }
    }
}
