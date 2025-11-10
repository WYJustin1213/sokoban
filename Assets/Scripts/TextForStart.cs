using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextForStart : MonoBehaviour
{
    public TextMeshProUGUI instructions;

    public void ChangeSceneByIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    void Start()
    {
        instructions.text = "Press SPACE to start.";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeSceneByIndex(1);
        }
    }
}