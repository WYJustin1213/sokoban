using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    [SerializeField] private GameObject targetBlock;
    [SerializeField] private Vector3 targetLoc = new Vector3();

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RestartGame(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private void Update()
    {
        targetLoc = targetBlock.transform.position;
        float distance = Vector3.Distance(targetLoc, transform.position);

        Debug.Log("targetBlock = " + targetBlock.transform.position);
        Debug.Log("targetLoc = " + targetLoc);
        Debug.Log(distance);
        Debug.Log(transform.position);

        if (distance <= 1)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            RestartGame(0);
        }
    }
}

