using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public RawImage scrim;

    public void Start()
    {
        Color fixedColor = scrim.color;
        fixedColor.a = 1;
        scrim.color = fixedColor;
        scrim.CrossFadeAlpha(0f, 0f, true);
    }

    public void StartTheGame()
    {
        scrim.CrossFadeAlpha(.7f, 1, false);
        StartCoroutine(LoadNextLevel());
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level01");
    }
}
