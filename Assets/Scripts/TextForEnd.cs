using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextForEnd : MonoBehaviour
{
    public TextMeshProUGUI instructions;

    public void ChangeSceneByIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    void Start()
    {
        instructions.text = "Press G to restart or ESC to quit.";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeSceneByIndex(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}