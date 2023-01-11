using UnityEngine;

namespace yatzu
{
    /// <summary>
    /// 互動系統 : 偵測玩家是否進入並且執行互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        // 3D 物件適用
        //兩個碰撞物件必須其中一個勾選 Is Trigger
        //碰撞開始
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
        }

        //碰撞結束
        private void OnTriggerExit(Collider other)
        {
            
        }

        //持續碰撞
        private void OnTriggerStay(Collider other)
        {
            
        }
    }
}