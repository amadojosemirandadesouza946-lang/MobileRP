using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {
    public Text healthText;
    public Text moneyText;
    public Image wantedStars;

    public void SetHealth(int hp){ if(healthText) healthText.text = "HP: " + hp; }
    public void SetMoney(int money){ if(moneyText) moneyText.text = "$" + money; }
    public void SetWanted(int level){ if(wantedStars) wantedStars.fillAmount = Mathf.Clamp01(level / 5f); }
}
