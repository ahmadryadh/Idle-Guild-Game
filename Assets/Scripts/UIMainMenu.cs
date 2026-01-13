using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button ButtonPlay;
    [SerializeField] private Button ButtonSettings;
    [SerializeField] private Button ButtonExit;

    private void Init()
    {
        ButtonExit.onClick.AddListener(ExitGame);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
