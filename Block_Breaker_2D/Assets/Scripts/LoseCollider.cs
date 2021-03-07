using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) 
    {
        // int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // int nextSceneIndex = currentSceneIndex +1;
        // if(currentSceneIndex >=2)
        // {

        // }

        SceneManager.LoadScene("Game Over",LoadSceneMode.Single);
    }

}
