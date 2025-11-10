using UnityEngine;
using TMPro;

public class Text: MonoBehaviour
{
    public TextMeshProUGUI instructions;
    public bool finished = false;

    void Start()
    {
        instructions.text = "[R] Restart level, [G] restart Game, [ESC] quit, OBJECTIVE: Connect the shinny block with the white block.";
    }

    void Update()
    {
        // Example: Change text on key press
        if (finished)
        {
            instructions.text = "The end... [R] Restart level, [G] restart Game, [ESC] quit.";
        }

        else
        {
            instructions.text = "[R] Restart level, [G] restart Game, [ESC] quit, OBJECTIVE: Connect the shinny block with the white block.";
        }
    }
}