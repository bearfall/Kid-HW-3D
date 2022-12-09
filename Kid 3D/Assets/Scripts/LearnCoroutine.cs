using UnityEngine;
using System.Collections;

namespace bearfall
{
    /// <summary>
    /// �ǲߨ�P�{�ǡA²�٨�{
    /// �ت�:���{�����d�F�쵥�ݪ��ĪG
    /// </summary>

    public class LearnCoroutine : MonoBehaviour
    {
        //�ϥΨ�P�{�Ǫ��T�ӱ���
        //1.�ޥΩR�W�Ŷ� System.Collections
        //2.�w�q�@�ӶǦ^ IEnumerator ����k
        //3.��k�������ϥ� yield return(����)
        //4.�ϥ�StartCoroutine �Ұ�

        private string testDialogue = "�o�̦n�i�� �ڷQ���I�^�a...";

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