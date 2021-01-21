using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Undercooked.UI
{
public class Menu : MonoBehaviour
{
    public GameObject Main_menu;
    public GameObject Tutorial;
    public GameObject Settings;
    public GameObject Controls;
    public GameObject Game_end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Btn_play_clicked()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("The play button was clicked");
    }
    
    public void Btn_tutorial_clicked()
    {
        Tutorial.SetActive(true);
        Main_menu.SetActive(false);
    }

    public void Btn_back_to_menu()
    {
        Tutorial.SetActive(false);
        Settings.SetActive(false);
        Controls.SetActive(false);
        Main_menu.SetActive(true);
    }

    public void Btn_quit_clicked()
    {
        Application.Quit();
    }

    public void Btn_settings_clicked()
    {
        Tutorial.SetActive(false);
        Settings.SetActive(true);
        Controls.SetActive(false);
        Main_menu.SetActive(false);
    }

    public void Btn_controls_clicked()
    {
        
        Settings.SetActive(false);
        Controls.SetActive(true);
        Main_menu.SetActive(false);
    }
    public void Back_to_menu_scene()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Show_game_end()
    {
        Game_end.SetActive(true);
    }

}

}
