using UnityEngine;

public class ShowItems : MonoBehaviour
{
    public GameObject nakidka;
    public GameObject ruki;
    public GameObject pojas;
    public GameObject golova;
    public GameObject wuzi;
    public GameObject nogi;


    public void Nakidka()
    {
        nakidka.SetActive(!nakidka.activeSelf);
    }
    public void Ruki()
    {
        ruki.SetActive(!ruki.activeSelf);
    }
    public void Pojas()
    {
        pojas.SetActive(!pojas.activeSelf);
    }
    public void Golova()
    {
        golova.SetActive(!golova.activeSelf);
    }
    public void Wuzi()
    {
        wuzi.SetActive(!wuzi.activeSelf);
    }
    public void Nogi()
    {
        nogi.SetActive(!nogi.activeSelf);
    }
}
