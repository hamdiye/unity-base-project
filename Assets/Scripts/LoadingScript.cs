using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class LoadingScript : MonoBehaviour
{
    public UnityEngine.UI.Image LoadImage;
    public TextMeshProUGUI loadingText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneAsync("MenuScene"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return new WaitForSeconds(0.3f); // Kısa gecikme (opsiyonel)
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            // Filled Image'i doldur
            LoadImage.fillAmount = progress;

            if (loadingText != null)
                loadingText.text = $"{progress * 100:F0}%";

            // Yükleme tamamlandı
            if (operation.progress >= 0.9f)
            {
                LoadImage.fillAmount = 1f;

                yield return new WaitForSeconds(0.3f); // Tam dolduğunu göster

                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
