using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI inputField;
    public TextMeshProUGUI bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score: " + SceneToScenePersistor.Instance.highScorePlayerName + ": " + SceneToScenePersistor.Instance.highScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void UpdateName()
    {
        SceneToScenePersistor.Instance.playerName = inputField.text;
    }
}
