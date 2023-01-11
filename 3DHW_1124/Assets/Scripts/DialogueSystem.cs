﻿using UnityEngine;
using TMPro;
using System.Collections;


namespace yatzu
{
    /// <summary>
    /// 對話系統
    /// </summary>

    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField, Header("對話間隔"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField, Header("開頭對話")]
        private DialogueData dialogueOpening;
        [SerializeField, Header("對話按鍵")]
        private KeyCode dialogueKey = KeyCode.Space;


        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);

        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;

        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話者內容").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("對話完成圖示");
            goTriangle.SetActive(false);

            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect());
        }
        

        ///<summary>
        ///淡入淡出群組物件
        ///</summary>
        private IEnumerator FadeGroup()
        {
            for (int i = 0; i < 10; i++)
            {
                groupDialogue.alpha += 0.1f;
                yield return new WaitForSeconds(0.04f);
            }
        }

        private IEnumerator TypeEffect()
        {
            textName.text = dialogueOpening.dialogueName;
            textContent.text = "";

            string dialogue = dialogueOpening.dialogueContents[1];
            for (int i= 0;i < dialogue.Length; i++)
            {
                textContent.text += dialogue[i];
                yield return dialogueInterval;
            }

            goTriangle.SetActive(true);
            //如果 玩家 還沒按下 指定按鍵 就等待
            while (!Input.GetKeyDown(dialogueKey)) 
            {
                yield return null;
            }
            print("<color=#993300>玩家按下按鍵!</color>");
        }
    }
}