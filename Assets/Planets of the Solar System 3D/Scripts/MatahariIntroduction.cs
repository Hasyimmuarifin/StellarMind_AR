using UnityEngine;
using UnityEngine.UI; // Tambahkan ini untuk menangani tombol UI
public class MatahariIntroduction : MonoBehaviour
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
    public Button matahariButton;           // Referensi ke tombol "Matahari"
    public Button exitButton;               // Referensi ke tombol keluar di canvas

    void Start()
    {
        // Pastikan UI dimulai dalam keadaan tersembunyi
        matahariIntroductionUI.SetActive(false);

        // Tambahkan listener ke tombol
        matahariButton.onClick.AddListener(ShowPlanetIntroduction);
        exitButton.onClick.AddListener(HidePlanetIntroduction);
    }

    // Fungsi untuk menampilkan Canvas PlanetIntroduction
    private void ShowPlanetIntroduction()
    {
        matahariIntroductionUI.SetActive(true);
        marsIntroductionUI.SetActive(false);
        bumiIntroductionUI.SetActive(false);
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
        matahariIntroductionUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
