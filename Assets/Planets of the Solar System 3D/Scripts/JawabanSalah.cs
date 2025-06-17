using UnityEngine;

public class JawabanSalah : MonoBehaviour
{
    public AudioSource salahSound;

    public void OnButtonClick()
    {
        Debug.Log("Jawaban salah!");
        if (salahSound != null)
            salahSound.Play();
    }
}
