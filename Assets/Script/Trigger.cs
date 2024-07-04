using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject[] Marks; // array untung nampung mark
    public GameObject Sparks; // buat game objek partikel api
    // public GameObject WinUI; // buat game objek win ui
    private int markIndex = 0; // buat ngitung mark
    private void OnTriggerEnter(Collider other) // kalau ke trigger
    {
        if (markIndex >= Marks.Length) // di cek dlu apakah marknya masih ada
        {
            Debug.LogWarning("No more marks available to use."); // buat tanda kalau marknya habis
            return; // kalau habis bakal return
        }

        Debug.Log("Triggered!"); // buat tanda kalau ke trigger
        Marks[markIndex].SetActive(true); // setiap ke trigger marknya bakal hidup
        Marks[markIndex].transform.position = other.transform.position; // buat nyesuain posisi
        Sparks.SetActive(true); // tiap kena partikel api nyala
        Sparks.transform.position = other.transform.position; // buat nyesuain posisi si partikel
        GameManager.instance.scoreGlobal += 1; // stiap ke trigger scroe nambah satu
        markIndex++; // buat nentuin mark mana lagi yang akan active
    }

    private void OnTriggerExit(Collider other){ // kalau trigger sudah selesai
        other.gameObject.SetActive(false); // game object bakal mati supaya tidak terjadi kesalahn
        Sparks.SetActive(false); // supaya partikel apinya juga ikut mati
    }
    
    // void Update() // ketika score udh mencapai parameternya WinUI nya muncul
    // {
    //     if (GameManager.instance.scoreGlobal == 32)
    //     {
    //         WinUI.SetActive(true);
    //         GameManager.instance.scoreGlobal = 0;
    //     }
    // }
}
