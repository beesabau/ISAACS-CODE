using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{

    [SerializeField]
    private string nextSceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("starting");
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("please");
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(nextSceneName);
    }
}
