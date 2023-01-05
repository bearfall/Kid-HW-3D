using UnityEngine;
namespace bearfall
{


    public class GhostTrigger : MonoBehaviour
    {

        [SerializeField, Header("����s��")]
        private GameObject ghost;
        [SerializeField, Header("�ʵe")]
        private Animator Animator;
        [SerializeField, Header("�l�H����")]
        private GameObject badGhost;
        [SerializeField, Header("�l�H����ͦ��I")]
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