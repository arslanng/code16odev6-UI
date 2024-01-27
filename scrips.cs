using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class odev6Scripts : MonoBehaviour
{
    string firstname;
    string gender;
    string school;
    bool onay;
    public GameObject Panel;
    public Text SonucMetni;
    public Image GryffindorLogo;
    public Image SlytherinLogo;
    public Image RavenclawLogo;
    public Image HufflepuffLogo;


    public void IsOkFunc(bool durum) // toogle için
    {
        onay = durum;
        print("onay: " + onay);
    }
    public void NameFunc(string name) // InputField için
    {
        firstname = name;
        print("name: " + firstname);
    }
    public void GenderFunc (float slider) // Slider için
    {
        if(slider == 0)
        {
            gender = "Kadın";
        } else if(slider == 1)
        {
            gender = "Erkek";
        }
        print("gender :" + gender);
    }
    public void SchoolFunc(int index) // Dropdown için
    {
        switch (index)
        {
            case 0:
                school = "";
                GryffindorLogo.gameObject.SetActive(false);
                SlytherinLogo.gameObject.SetActive(false);
                RavenclawLogo.gameObject.SetActive(false);
                HufflepuffLogo.gameObject.SetActive(false);
                break;
            case 1:
                school = "Gryffindor";
                GryffindorLogo.gameObject.SetActive(true);
                SlytherinLogo.gameObject.SetActive(false);
                RavenclawLogo.gameObject.SetActive(false);
                HufflepuffLogo.gameObject.SetActive(false);
                break;
            case 2:
                school = "Slytherin";
                GryffindorLogo.gameObject.SetActive(false);
                SlytherinLogo.gameObject.SetActive(true);
                RavenclawLogo.gameObject.SetActive(false);
                HufflepuffLogo.gameObject.SetActive(false);
                break;
            case 3:
                school = "Ravenclaw";
                GryffindorLogo.gameObject.SetActive(false);
                SlytherinLogo.gameObject.SetActive(false);
                RavenclawLogo.gameObject.SetActive(true);
                HufflepuffLogo.gameObject.SetActive(false);
                break;
            case 4:
                school = "Hufflepuff";
                GryffindorLogo.gameObject.SetActive(false);
                SlytherinLogo.gameObject.SetActive(false);
                RavenclawLogo.gameObject.SetActive(false);
                HufflepuffLogo.gameObject.SetActive(true);
                break;
        }
        print("school: " + school);
    }

    //Sayfa kontrolleri
    public void Cikis() // çıkış
    {
        Application.Quit();
    }
    public void Anket() // anket sayfası
    {
        SceneManager.LoadScene("odev6-2");
    }
    public void Anasayfa() // ana sayfa
    {
        SceneManager.LoadScene("odev6-1");
    }
    public void OpenPanel() // sonuç panelini aç
    {
        Panel.SetActive(true);
    }
    public void ClosePanel() // sonuç panelini kapat
    {
        Panel.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        gender = "Kadın";
        school = "Gryffindor";
        onay = false;
        firstname = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (onay && firstname != "" && school != "") // alınan verilerin işlenmesi
        {
            SonucMetni.text = "Merhaba " + firstname + " Cinsiyetinizi " + gender + " okul binası tercihinizi " + school + " olarak belirttiniz ve verilerinizin işlenmesini onayladınız. Seçmen şapkanın sizin tercihinize uyma veya sizi okula kabul etme zorunluluğu yoktur. Onaylıyor musunuz?";
        } else
        {
            SonucMetni.text = "Lütfen verileri eksiksiz doldurunuz.";
        }
    }
}
