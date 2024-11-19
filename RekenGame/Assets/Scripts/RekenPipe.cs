using UnityEngine;
using UnityEngine.UI; // Nodig voor Legacy Text-componenten

public class MathProblem : MonoBehaviour
{
    public Text questionText;       // Tekstveld voor de som
    public Text answerTopText;     // Tekstveld voor bovenste antwoord
    public Text answerBottomText;  // Tekstveld voor onderste antwoord

    void Start()
    {
        if (questionText == null || answerTopText == null || answerBottomText == null)
        {
            Debug.LogError("Een of meer Text-componenten zijn niet toegewezen in de Inspector!");
            return; // Stop het script om verdere fouten te voorkomen
        }

        GenerateProblem();
    }

    private void GenerateProblem()
    {
        int num1 = Random.Range(1, 10);
        int num2 = Random.Range(1, 10);

        int correctAnswer = num1 + num2;
        int wrongAnswer = correctAnswer + Random.Range(-3, 4);

        // Zorg dat het foute antwoord niet gelijk is aan het juiste antwoord
        while (wrongAnswer == correctAnswer)
        {
            wrongAnswer = correctAnswer + Random.Range(-3, 4);
        }

        questionText.text = $"{num1} + {num2} = ?";

        // Willekeurig bepalen of het juiste antwoord boven of onder komt
        if (Random.value > 0.5f)
        {
            answerTopText.text = correctAnswer.ToString();
            answerBottomText.text = wrongAnswer.ToString();
            answerTopText.tag = "Correct";
            answerBottomText.tag = "Wrong";
        }
        else
        {
            answerTopText.text = wrongAnswer.ToString();
            answerBottomText.text = correctAnswer.ToString();
            answerTopText.tag = "Wrong";
            answerBottomText.tag = "Correct";
        }
    }
}
