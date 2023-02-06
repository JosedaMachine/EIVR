using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private UIManager uiManager;

    private void Awake(){
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        uiManager = GetComponent<UIManager>();
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    public void UpdateScore(int newScore)
    {
        uiManager.UpdateScore(newScore);
    }

    public void LoadNextScene()
    {
        // Carga la siguiente escena aquí
    }
}
