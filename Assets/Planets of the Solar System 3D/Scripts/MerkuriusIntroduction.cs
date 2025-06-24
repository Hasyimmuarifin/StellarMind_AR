using UnityEngine;
using UnityEngine.UI; // Tambahkan ini untuk menangani tombol UI
public class MerkuriusIntroduction : MonoBehaviour
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
    public Button merkuriusButton;           // Referensi ke tombol "Matahari"
    public Button exitButton;               // Referensi ke tombol keluar di canvas

    void Start()
    {
        // Pastikan UI dimulai dalam keadaan tersembunyi
        merkuriusIntroductionUI.SetActive(false);

        // Tambahkan listener ke tombol
        merkuriusButton.onClick.AddListener(ShowPlanetIntroduction);
        exitButton.onClick.AddListener(HidePlanetIntroduction);
    }

    // Fungsi untuk menampilkan Canvas PlanetIntroduction
    private void ShowPlanetIntroduction()
    {
        merkuriusIntroductionUI.SetActive(true);
        bumiIntroductionUI.SetActive(false);
        matahariIntroductionUI.SetActive(false);
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
        merkuriusIntroductionUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
