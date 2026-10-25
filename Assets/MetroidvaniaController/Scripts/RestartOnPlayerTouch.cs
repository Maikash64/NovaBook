
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnPlayerTouch : MonoBehaviour
{
    private void Restart(GameObject other)
    {
        if (!other.CompareTag("Player"))
            return;

        Debug.Log("Player touched! Restarting scene...");
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    private void OnCollisionEnter(Collision collision)
    {
        Restart(collision.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Restart(collision.gameObject);
    }
}
