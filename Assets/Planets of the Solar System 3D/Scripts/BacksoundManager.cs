using UnityEngine;
using UnityEngine.SceneManagement;

public class BacksoundManager : MonoBehaviour
{
    private static BacksoundManager instance;
    private AudioSource audioSource;

    // Daftar nama scene yang diizinkan memiliki backsound
    private string[] quizScenes = { "quiz 1", "quiz 2", "quiz 3", "quiz 4", "quiz 5", "ending" };

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject); // Hapus duplikat jika sudah ada instance sebelumnya
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        bool isQuizScene = false;

        foreach (string quizScene in quizScenes)
        {
            if (scene.name == quizScene)
            {
                isQuizScene = true;
                break;
            }
        }

        if (isQuizScene)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play(); // Mulai main jika belum
            }
            // else: biarkan saja, jangan diapa-apakan
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop(); // Stop jika masuk scene non-quiz
            }
        }
    }


    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
