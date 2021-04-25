using UnityEngine;

public class Object : MonoBehaviour
{
    public GameManager gameManager;

    public int stepRequired;
    
    [TextArea] public string firstDialog;
    [TextArea] public string secondDialog;
    [TextArea] public string thirdDialog;
    
    [HideInInspector] public string textToDisplay;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnMouseDown()
    {
        int step = PlayerPrefs.GetInt("step");

        if (stepRequired > step)
        {
            textToDisplay = firstDialog;
        }
        else if (stepRequired == step)
        {
            textToDisplay = secondDialog;
            PlayerPrefs.SetInt("step", step + 1);
        }
        else
        {
            textToDisplay = thirdDialog;
        }

        gameManager.TextUpdate(textToDisplay);
    }

    public void OnMouseExit()
    {
        Debug.Log(name);
    }
}
