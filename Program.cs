
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

string player1 = typeName(1);
string player2 = typeName(2);
int player1Points = 0;
int player2Points = 0;

Console.WriteLine ("Welcome to the quiz game! Ask a question which can be answered by 'yes' or a 'no' or a number");


Console.WriteLine("How many points to declare a victor.");


bool parsingResult = int.TryParse(Console.ReadLine(), out int PointsToWin);
if (!parsingResult)
{
	PointsToWin = 3;
}

Console.WriteLine(PointsToWin);

while (player1Points < PointsToWin && player2Points < PointsToWin)



{
Console.WriteLine($"What is the question, {player1}");
	 string question = Console.ReadLine()?.ToLower().Trim() ?? string.Empty; 

    
    Console.WriteLine($"What is the correct answer, {player1}");
	  string correctAnswer = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;
      Console.Clear();
      Console.WriteLine (question);

	if (correctAnswer.ToLower() == "yes" || correctAnswer.ToLower() == "no")
    
        Console.WriteLine("valid answer, proceed");
    
    else
    
        if (int.TryParse(correctAnswer, out int number))
        {
            Console.WriteLine("valid answer, proceed");
        }
        else
        {
            Console.WriteLine("invalid answer, start the game again.");
            break;
        }
        Console.WriteLine($" {player2}, What is {player1}'s answer ?");
        string answer = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;

        if (answer == correctAnswer)
        {
            Console.WriteLine($"Correct, {player2} gets a point!");
            player2Points++;
            
        }
        else
        {
            Console.WriteLine("incorrect, better luck next time");
        }

        



           

Console.WriteLine($"What is the question, {player2}");
	 string question2 = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;
    
    Console.WriteLine($"What is the correct answer, {player2}");
	  string correctAnswer2 = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;
      Console.Clear();
      Console.WriteLine (question2);

	if (correctAnswer2.ToLower() == "yes" || correctAnswer2.ToLower() == "no")
    
        Console.WriteLine("valid answer, proceed");
    
    else
    
        if (int.TryParse(correctAnswer2, out int number))
        {
            Console.WriteLine("valid answer, proceed");
        }
        else
        {
            Console.WriteLine("invalid answer, start the game again.");
            break;
        }
        Console.WriteLine($" {player1}, What is {player2}'s answer ?");
        string answer2 = Console.ReadLine()?.ToLower().Trim() ?? string.Empty;

        if (answer2 == correctAnswer2)
        {
            Console.WriteLine($"Correct, {player1} gets a point!");
            player1Points++;
            
        }
        else
        {
            Console.WriteLine("incorrect, better luck next time");
        }


        
       Console.WriteLine($"[{player1}] {player1Points} : {player2Points} [{player2}]");

        if (player1Points == player2Points && player1Points >= PointsToWin )
       {
        Console.WriteLine("its a draw");
        break;
    
       }
       else
       {
        if (player1Points >= PointsToWin)
        {
            Console.WriteLine($"{player1} wins!");
            break;
        }
        else
        {
            if (player2Points >= PointsToWin)
            {
                Console.WriteLine($"{player2} wins!");
                break;
            }
        }
        
        
        
        
       }



       
    
       
}
   
	string typeName(int playerNumber)
{
	Console.WriteLine($"Type your name, player {playerNumber}");
	string? input = Console.ReadLine();
	return string.IsNullOrWhiteSpace(input) ? $"Player {playerNumber}" : input;
}