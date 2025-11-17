using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour {
    public GameObject malePrefab;
    public GameObject femalePrefab;
    public Dropdown hairDropdown;
    public Dropdown shirtDropdown;
    public Text status;
    private GameObject current;

    public void SelectGender(string g){
        if(current) Destroy(current);
        if(g=="male") current = Instantiate(malePrefab);
        else current = Instantiate(femalePrefab);
        if(status) status.text = g + " selected";
    }

    public void ApplyCustomization(int hairIndex, int shirtIndex){
        if(status) status.text = $"Hair:{hairIndex} Shirt:{shirtIndex}";
        // placeholder: set materials/colors
    }
}
