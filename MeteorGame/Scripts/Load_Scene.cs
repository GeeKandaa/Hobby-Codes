using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Scene : MonoBehaviour {
    
    public int id;
    public bool Load = false;

    public GameObject loadingImage;
    void Update() { 
        if (Load == true){

        loadingImage.SetActive(true);
        SceneManager.LoadScene(id);
        }
    }
}
