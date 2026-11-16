using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneButton : MonoBehaviour
{
    [SerializeField] private Button myButton;
    [SerializeField] private int sceneIndex;

    private void Awake()
    {
        myButton.onClick.AddListener(NextGameScene);
    }

    private void NextGameScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
