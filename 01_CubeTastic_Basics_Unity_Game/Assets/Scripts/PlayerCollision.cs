using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    public AudioSource crashSound; 

    void OnCollisionEnter (Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "Obstacle")
        {
           movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
            crashSound.PlayOneShot(crashSound.clip);

        }
    }

  
}



//  Debug.Log(collisionInfo.collider.name);
//  Debug.Log("We hit an Obstacle!");