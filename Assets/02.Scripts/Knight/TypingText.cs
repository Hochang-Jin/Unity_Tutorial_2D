using System.Collections;
using TMPro;
using UnityEngine;

public class TypingText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUI;
    private string currentText;
    [SerializeField] private float typingSpeed = 0.1f;

    private void Awake()
    {
        currentText = textUI.text;
    }

    private void OnEnable()
    {
        textUI.text = string.Empty;

        StartCoroutine(TypingRoutine());
    }

    IEnumerator TypingRoutine()
    {
        int textLength = currentText.Length;
        for (int i = 0; i < textLength; i++)
        {
            textUI.text += currentText[i];
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
