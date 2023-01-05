using UnityEngine;
namespace bearfall
{


    public class GhostTrigger : MonoBehaviour
    {

        [SerializeField, Header("鬼魂編號")]
        private GameObject ghost;
        [SerializeField, Header("動畫")]
        private Animator Animator;
        [SerializeField, Header("追人鬼魂")]
        private GameObject badGhost;
        [SerializeField, Header("追人鬼魂生成點")]
        private Transform spawnBadGhost;



        private void Start()
        {
            Animator = ghost.GetComponent<Animator>();
        }
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
            GoGhostGo();
            Instantiate(badGhost, spawnBadGhost.position, spawnBadGhost.rotation);
          
            transform.GetComponent<Collider>().enabled = false;
        }
        void GoGhostGo()
        {


            

                Animator.enabled = true;
             
            


        }

    }
}