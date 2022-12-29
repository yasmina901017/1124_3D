using UnityEngine;

namespace yatzu
{
    /// <summary>
    /// ��ܸ��
    /// </summary>
    [CreateAssetMenu(menuName = "yatzu/Dialogue Data", fileName = "New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("��ܪ̦W��")]
        public string dialogue;
        [Header("��ܪ̤��e"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}