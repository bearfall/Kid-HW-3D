using UnityEngine;
using System.Collections;

namespace bearfall
{
    /// <summary>
    /// 學習協同程序，簡稱協程
    /// 目的:讓程式停留達到等待的效果
    /// </summary>

    public class LearnCoroutine : MonoBehaviour
    {
        //使用協同程序的三個條件
        //1.引用命名空間 System.Collections
        //2.定義一個傳回 IEnumerator 的方法
        //3.方法內必須使用 yield return(等待)
        //4.使用StartCoroutine 啟動

        private string testDialogue = "這裡好可怕 我想快點回家...";

        private void Awake()
        {
            StartCoroutine(Test());
            StartCoroutine(ShowDialogueUseFor());
        }
        private IEnumerator Test()
        {
            print("1");
            yield return new WaitForSeconds(2);
            print("2");
        }

        private IEnumerator ShowDialogueUseFor()
        {
            for (int i = 0; i < testDialogue.Length; i++)
            {
                print(testDialogue[i]);
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}