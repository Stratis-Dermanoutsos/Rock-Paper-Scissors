using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite[] handEmotes;

    [SerializeField] private Text scoresText;

    [SerializeField] private BotRandomChoice bot;

    private int playerScore;

    private int botScore;

    void Start()
    {
        // Reset the scores
        playerScore = 0;
        botScore = 0;

        // Reset the <scoresText>
        scoresText.text = "0  -  0";
    }

    public void SetScore(int playerChoice)
    {
        int botChoice = bot.Choice(); // Reveal the bot's choice and get the result

        // Compare
        if (botChoice == playerChoice + 1 || (playerChoice == 2 && botChoice == 0)) // bot wins
            botScore++;
        else if (playerChoice == botChoice + 1 || (botChoice == 2 && playerChoice == 0)) // player wins
            playerScore++;
        else
            return;

        // Set the <scoresText>
        scoresText.text = string.Format("{0}  -  {1}", playerScore, botScore);
    }
}
