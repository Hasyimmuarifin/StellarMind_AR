using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneAkhir : MonoBehaviour
{
    public Image hasilGambar;
    public Sprite bagusSprite;
    public Sprite cukupSprite;
    public Sprite gagalSprite;

    public AudioSource klikSound; // <-- Tambahkan ini

    void Start()
    {
        int skor = ScoreManager.Instance.score;

        if (skor == 5)
        {
            hasilGambar.sprite = bagusSprite;
        }
        else if (skor >= 3)
        {
            hasilGambar.sprite = cukupSprite;
        }
        else
        {
            hasilGambar.sprite = gagalSprite;
        }
    }

    public void UlangiQuiz()
    {
        if (klikSound != null)
            klikSound.Play();

        // Pakai Coroutine agar suara sempat diputar dulu sebelum pindah scene
        StartCoroutine(LoadSceneAfterSound());
    }

    private System.Collections.IEnumerator LoadSceneAfterSound()
    {
        // Tunggu selama durasi suara
        yield return new WaitForSeconds(klikSound.clip.length);

        ScoreManager.Instance.ResetSkor();
        SceneManager.LoadScene("quiz 1"); // Ganti sesuai nama scene awal kamu
    }
}
