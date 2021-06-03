using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") // Если игрок вызвал тригер сменить уровень на след.
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Загружает следующую сцену.

            // Если номер уровня < количества пройденных.
            if ((SceneManager.GetActiveScene().buildIndex - SceneManager.GetSceneByName("Level 1").buildIndex) >= PlayerPrefs.GetInt("levelComplite"))
                PlayerPrefs.SetInt("levelComplite", PlayerPrefs.GetInt("levelComplite") + 1); // Прибавить к пройденным + 1
        }
    }
}
