using UnityEngine;
using UnityEngine.UI; // Tambahkan ini untuk menangani tombol UI
public class BumiIntroduction : MonoBehaviour
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
    public Button bumiButton;           // Referensi ke tombol "Matahari"
    public Button exitButton;               // Referensi ke tombol keluar di canvas

    void Start()
    {
        // Pastikan UI dimulai dalam keadaan tersembunyi
        bumiIntroductionUI.SetActive(false);

        // Tambahkan listener ke tombol
        bumiButton.onClick.AddListener(ShowPlanetIntroduction);
        exitButton.onClick.AddListener(HidePlanetIntroduction);
    }

    // Fungsi untuk menampilkan Canvas PlanetIntroduction
    private void ShowPlanetIntroduction()
    {
        bumiIntroductionUI.SetActive(true);
        matahariIntroductionUI.SetActive(false);
        merkuriusIntroductionUI.SetActive(false);
        venusIntroductionUI.SetActive(false);
        marsIntroductionUI.SetActive(false);
        jupiterIntroductionUI.SetActive(false);
        saturnusIntroductionUI.SetActive(false);
        uranusIntroductionUI.SetActive(false);
        neptunusIntroductionUI.SetActive(false);
    }

    // Fungsi untuk menyembunyikan Canvas PlanetIntroduction
    private void HidePlanetIntroduction()
    {
        bumiIntroductionUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
