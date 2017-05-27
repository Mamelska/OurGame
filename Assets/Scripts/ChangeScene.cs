using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    //Ładowanie wybranej sceny
    public void ChangeSceneTo(int ChangeScene)
    {

        SceneManager.LoadScene(ChangeScene);

    }




}
