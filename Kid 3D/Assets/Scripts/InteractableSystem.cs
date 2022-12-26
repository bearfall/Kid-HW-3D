using UnityEngine;
namespace bearfall
{
    /// <summary>
    /// ���ʨt��:�������a�O�_�i�J�åB���椬�ʦ欰
    /// </summary>

    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܸ��")]
        private DialogueData dataDialogue;

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
                dialogueSystem.StartDialogue(dataDialogue);
            }
        }
    }
}