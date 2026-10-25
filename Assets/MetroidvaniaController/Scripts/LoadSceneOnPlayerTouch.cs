
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnPlayerTouch : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private void LoadDestination(GameObject other)
    {
        if (!other.CompareTag("Player"))
            return;

        Debug.Log("Player entered trigger. Loading: " + sceneName);

        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError(
                "Scene not found in Build Profiles scene list: "
                + sceneName
            );
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        LoadDestination(other.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        LoadDestination(other.gameObject);
    }
}
