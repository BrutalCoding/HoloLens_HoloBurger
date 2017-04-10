using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {

	//Regel de levels
    public void LoadLevel(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
