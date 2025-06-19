using UnityEngine;
using UnityEngine.SceneManagement;

public class JawabanBenar : MonoBehaviour
{
    public AudioSource benarSound;         // Drag audio "benar" ke sini
    public float delayBeforeNextScene = 2f; // Delay (detik) sebelum pindah scene

    public void OnButtonClick()
    {
        if (benarSound != null)
            benarSound.Play();

        ScoreManager.Instance.TambahSkor(); // Tambah skor

        Invoke("PindahScene", delayBeforeNextScene);
    }


    void PindahScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
