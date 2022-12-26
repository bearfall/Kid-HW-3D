using UnityEngine;
namespace bearfall
{
    /// <summary>
    /// 互動系統:偵測玩家是否進入並且執行互動行為
    /// </summary>

    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
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