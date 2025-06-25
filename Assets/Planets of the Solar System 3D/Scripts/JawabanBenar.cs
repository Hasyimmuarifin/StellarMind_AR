using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class JawabanBenar : MonoBehaviour
{
    public AudioSource benarSound;

    public void OnButtonClick()
    {
        if (benarSound != null)
            benarSound.Play();

        ScoreManager.Instance.TambahSkor();

        StartCoroutine(LoadSceneWithoutBlack(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadSceneWithoutBlack(int sceneIndex)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneIndex);
        asyncLoad.allowSceneActivation = false;

        // Tunggu sampai scene selesai dimuat di background
        while (asyncLoad.progress < 0.9f)
        {
            yield return null;
        }

        // Langsung aktifkan tanpa delay/hitam
        asyncLoad.allowSceneActivation = true;
    }
}
