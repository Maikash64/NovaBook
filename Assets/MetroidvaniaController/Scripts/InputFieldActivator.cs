
using UnityEngine;
using TMPro;

public class InputFieldActivator : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string Answer = "6";

    private void Start()
    {
        inputField.onValueChanged.AddListener(CheckInput);
    }

    private void CheckInput(string value)
    {
        targetObject.SetActive(value == Answer);
    }

    private void OnDestroy()
    {
        if (inputField != null)
            inputField.onValueChanged.RemoveListener(CheckInput);
    }
}
