using UnityEngine;

public class VictoryPoint : MonoBehaviour
{
    //当人物角色进入该区域时则表示获得胜利
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //在控制台打印胜利信息
            Debug.Log("You Win!");

            //在这里可以添加获胜时的额外操作，例如弹出胜利菜单等等
        }
    }
}
