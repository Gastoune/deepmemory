using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject text;
    public GameManager gameManager;

    public string scene;

    public void OnMouseDown()
    {
        gameManager.SceneLoad(scene);
    }

    public void OnMouseEnter()
    {
        text.SetActive(true);
    }

    public void OnMouseExit()
    {
        text.SetActive(false);
    }
}
