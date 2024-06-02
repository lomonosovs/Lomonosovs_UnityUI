using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public TMP_InputField nameField;
    public TMP_InputField ageField;
    public TMP_Text displayText;
    void Start()
    {
        ageField.onValueChanged.AddListener(OnAgeInput);
    }
    public void UpdateDisplayText()
    {
        displayText.text = "Supervaronis " + nameField.text + " ir  " + ageField.text + " gadus vecs";
    }
    private void OnAgeInput(string input)
    {
        string newText = string.Empty;
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                newText += c;
            }
        }
        ageField.text = newText;
    }

}