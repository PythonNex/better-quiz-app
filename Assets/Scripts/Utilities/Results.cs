﻿using System.Collections.Generic;

/**
 * Utility Class to hold the results from a single question
 */

[System.Serializable]
public class Results {

	/**
	 * The question that was asked.
	 * It also contains the correct answer to the question
	 */
	public Card originalQuestion;

	/**
	 * An array of every player who answered the question.
	 * The index is equal to the player's ID
	 */
	public List<Player> players=new List<Player>();

	/**
	 * An array of every player's answer to the question.
	 * The index is equal to the player's ID
	 */
	public List<Answer> playerAnswers=new List<Answer>();

	/**
	 * True if the player's answer is correct.
	 * The index is equal to the player's number
	 */
	public List<bool> isCorrect=new List<bool>();

}
