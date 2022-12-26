using UnityEngine;
using UnityEngine.Events;
namespace bearfall
{
    /// <summary>
    /// ���ʨt��:�������a�O�_�i�J�åB���椬�ʦ欰
    /// </summary>

    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("�Ĥ@�q��ܸ��")]
        private DialogueData dataDialogue;
        [SerializeField, Header("��ܵ����᪺�ƥ�")]
        private UnityEvent onDialogueFinish;
        [SerializeField, Header("�ҰʹD��")]
        private GameObject propActive;
        [SerializeField, Header("�Ұʫ᪺��ܸ��")]
        private DialogueData dataDialogueActive;
        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("�e����ܨt��").GetComponent<DialogueSystem>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                print(other.name);

                //�p�G ���ݭn�ҰʹD�� �Ϊ� �ҰʹD��O��ܪ� �N���� �Ĥ@�q���
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive);
                }
            }
        }

        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    }
}