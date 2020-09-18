using UnityEngine;
using UnityEngine.UI;

public class BotRandomChoice : MonoBehaviour
{
    [SerializeField] private Image myEmote;
    private int randomChoice;
    private GameManager gm;

    void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        // Select a Random Emote from the available choises
        randomChoice = Random.Range(0, 3);
    }

    // Reveal and return bot's choice
    public int Choice()
    {
        myEmote.sprite = gm.handEmotes[randomChoice];

        return randomChoice;
    }
}
