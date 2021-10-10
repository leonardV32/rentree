using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject loadingScreenPrefab;
    public void LoadSceneAsync()
    {
        StartCoroutine(LoadingScreenCoroutine());
    }

    private IEnumerator LoadingScreenCoroutine()
    {
        var prefab = Instantiate(loadingScreenPrefab);
        DontDestroyOnLoad(prefab);
        var sceneLoading = SceneManager.LoadSceneAsync("2D_top-down"); // permet de charger la sc�ne en d�caler
        sceneLoading.allowSceneActivation = false; // bloque l'affichage de la sc�ne suivante.
        while (sceneLoading.isDone == false)
        {
            if (sceneLoading.progress >= 0.9f) //chargement dans unity est � 90% le rest c'est l'affichage sur le screen
            {
                sceneLoading.allowSceneActivation = true; //r�autorise l'affichage de la sc�ne game.
                prefab.SetActive(false);
            }
            yield return new WaitForSeconds(1);
        }
        //yield return new WaitForSeconds(2);
        //SceneManager.LoadScene("Game");
        //yield return null;
    }

    /*public void ToMenu()
    {
        SceneManager.LoadScene("Menu"); // pour les boutons back
    }

    public void ToOptions()
    {
        SceneManager.LoadScene("Options");
    }*/

    public void ToQuit()
    {
        Application.Quit();
    }

}
