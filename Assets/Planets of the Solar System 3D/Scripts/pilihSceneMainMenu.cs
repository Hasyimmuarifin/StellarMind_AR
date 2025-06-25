using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PindahScene : MonoBehaviour
{
    public AudioSource benarSound;

    [Header("Nama atau Index Scene Tujuan")]
    public string sceneName; // isi di Inspector, misalnya "Level2"
    public int sceneIndex = -1; // opsional: isi kalau pakai index, -1 artinya tidak digunakan

    public void OnButtonClick()
    {
        if (benarSound != null)
            benarSound.Play();

        StartCoroutine(PindahSetelahDelay(0.5f));
    }

    IEnumerator PindahSetelahDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else if (sceneIndex >= 0)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogWarning("Scene name atau index belum diatur!");
        }
    }
}