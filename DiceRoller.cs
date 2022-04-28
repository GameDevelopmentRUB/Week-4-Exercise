using UnityEngine;
using TMPro;

public class DiceRoller : MonoBehaviour
{
    // Don't use the Text Component in UnityEngine.UI, as that's the legacy text
    // Also don't confuse this with 'TextMeshPro', since that is used to render text outside of the Canvas
    [SerializeField] TextMeshProUGUI diceText;
    
    // This needs to be public, otherwise the Button Component won't be able to access the method
    public void RollDice()
    {
        diceText.text = Random.Range(1, 7).ToString();
    }
}
