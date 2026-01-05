using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Slider loadingSlider;
    [SerializeField] private TextMeshProUGUI progress;

    void Awake()
    {
        loadingSlider = GetComponent<Slider>();
        loadingSlider.value = 0;
    }

    void Update()
    {
        while (ButtonScript.startLoading == true && loadingSlider.value < 1)
        {
            StartCoroutine("LoadingSlider");
        }

        progress.text = loadingSlider.value.ToString("0%");
    }




    public IEnumerator LoadingSlider()
    {
        yield return new WaitForSecondsRealtime(1f);
        loadingSlider.value += 0.1f;
    }

}
