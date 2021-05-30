using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour
{
    public int level;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Nextlvl")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("levelComplite", PlayerPrefs.GetInt("levelComplite") + 1);
            Debug.Log(PlayerPrefs.GetInt("levelComplite"));
        }
    }
}
