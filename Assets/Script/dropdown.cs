using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public Dropdown characterDropdown;
    public GameObject[] characters;

    void Start()
    {
        characterDropdown.onValueChanged.AddListener(delegate {
            SelectCharacter(characterDropdown.value);
        });
    }

    void SelectCharacter(int index)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(i == index);
        }
    }
}