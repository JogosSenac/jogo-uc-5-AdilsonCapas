using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Morte : MonoBehaviour
{

    public TMP_Text Moedas;
    public TMP_Text T4x4;
    public TMP_Text T0tal;
    public int total;
    public int Taxa;
    public int moeda;

    // Start is called before the first frame update
    void Start()
    {
        CarregarDados();
        Tax4();
        Total();
        
    }
    void CarregarDados()
    {
        moeda = PlayerPrefs.GetInt("Moeda"); 
        Moedas.text = "Moedas: " + moeda;
        Taxa = moeda * 70/100;
        total = moeda - Taxa;
    }

    void Tax4()
    {
        T4x4.text = "Imposto: " + Taxa;
    }
    
    void Total()
    {
        T0tal.text = "Total: " + total;
    }
    
}
