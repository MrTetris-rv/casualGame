using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _settingsPanel;
    [SerializeField] private GameObject _namePanel;
    
    public void StartPlay()
    {
        SceneManager.LoadScene(SceneNames.MainSceneName);
        _namePanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        _namePanel.SetActive(true);
        _settingsPanel.SetActive(false);
        _menuPanel.SetActive(true);
    }

    public void OpenSettingsPanel()
    {
        _namePanel.SetActive(false);
        _settingsPanel.SetActive(true);
        _menuPanel.SetActive(false);
    }
}
