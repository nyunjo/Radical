using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class Level1Respawn : MonoBehaviour
{
    // Assign the name of your Level 1 scene in the Inspector
    public string level1SceneName = "Level1"; 

    // Call this method when the player dies
    public void RespawnAtLevel1()
    {
        SceneManager.LoadScene(level1SceneName);
    }

    // Example of how to trigger the respawn (e.g., on collision with a "DeathZone")
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure the colliding object is your player
        {
            RespawnAtLevel1();
        }
    }
}
