using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public Button btnPlay;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Game);
    }

    // Update is called once per frame
    void Game() {
        SceneManager.LoadScene("SampleScene");
    }
}
