using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackScreen : MonoBehaviour
{

    public GameObject pantalla;

    public void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            pantalla.SetActive(true);
            StartCoroutine(changeScene());
        }
    }   

    IEnumerator changeScene(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    } 

}
