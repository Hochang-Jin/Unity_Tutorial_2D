using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;
        
        public void OnStartEvent()
        {
            if (inputField.text == "")
                nameTextUI.text = "나비"; // Default
            else
                nameTextUI.text = inputField.text;
        }
    }
    
}

