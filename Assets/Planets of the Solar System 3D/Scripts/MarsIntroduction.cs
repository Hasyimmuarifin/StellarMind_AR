using UnityEngine;
using UnityEngine.UI; // Tambahkan ini untuk menangani tombol UI
public class MarsIntroduction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created    
    public GameObject matahariIntroductionUI; // Referensi ke Canvas/Panel
    public GameObject merkuriusIntroductionUI; 
    public GameObject venusIntroductionUI;
    public GameObject bumiIntroductionUI;
    public GameObject marsIntroductionUI;
    public GameObject jupiterIntroductionUI;
    public GameObject saturnusIntroductionUI;
    public GameObject uranusIntroductionUI;
    public GameObject neptunusIntroductionUI;
    public Button marsButton;           // Referensi ke tombol "Matahari"
    public Button exitButton;               // Referensi ke tombol keluar di canvas

    void Start()
    {
        // Pastikan UI dimulai dalam keadaan tersembunyi
        marsIntroductionUI.SetActive(false);

        // Tambahkan listener ke tombol
        marsButton.onClick.AddListener(ShowPlanetIntroduction);
        exitButton.onClick.AddListener(HidePlanetIntroduction);
    }

    // Fungsi untuk menampilkan Canvas PlanetIntroduction
    private void ShowPlanetIntroduction()
    {
        marsIntroductionUI.SetActive(true);
        bumiIntroductionUI.SetActive(false);
        matahariIntroductionUI.SetActive(false);
        merkuriusIntroductionUI.SetActive(false);
        venusIntroductionUI.SetActive(false);
        jupiterIntroductionUI.SetActive(false);
        saturnusIntroductionUI.SetActive(false);
        uranusIntroductionUI.SetActive(false);
        neptunusIntroductionUI.SetActive(false);
    }

    // Fungsi untuk menyembunyikan Canvas PlanetIntroduction
    private void HidePlanetIntroduction()
    {
        marsIntroductionUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
