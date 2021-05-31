using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{
    public void loadLevel(int idLevel){
        SceneManager.LoadScene(idLevel);
    }
}
