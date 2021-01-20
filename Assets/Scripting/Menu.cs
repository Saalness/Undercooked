using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Main_menu;
    public GameObject Food_selection;
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
    
    public void Btn_Foodselect_menu_clicked()
    {
        Food_selection.SetActive(true);
        Main_menu.SetActive(false);
    }

    public void Btn_quit_clicked()
    {
        Application.Quit();
    }
}
