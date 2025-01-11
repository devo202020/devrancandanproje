using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using KinematicCharacterController.Examples;

public class MyCharacterController : MonoBehaviour
{

    public TextMeshProUGUI scoretext;
    public GameObject winscreen;
    public AudioSource coinSound;
    public AudioSource winSound;
    public int skor;
    public int toplanmasiGereken;
    public ExampleCharacterController ExampleCharacterController;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            skor = skor+1;
            scoretext.text = "Skor: "+skor.ToString();
            coinSound.Play();
            ExampleCharacterController.MaxStableMoveSpeed = ExampleCharacterController.MaxStableMoveSpeed + 1;

            if (skor >= toplanmasiGereken)
            {
                scoretext.text = "OYUNU KAZANDIN";

                winscreen.SetActive(true);
                winSound.Play();

            }
;
        }
            

    }

    


}
