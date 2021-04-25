using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text text;

    public void TextUpdate(string dialog)
    {
        StopAllCoroutines();
        text.text = dialog;
        StartCoroutine(DisplayText());
    }

    public IEnumerator DisplayText()
    {       
        yield return new WaitForSeconds(8);
        text.text = "";
    }

    public void SceneLoad(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void RestartGame()
    {
        PlayerPrefs.SetInt("step", 0);
        SceneManager.LoadScene("Room");
    }
}
