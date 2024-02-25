## Tic Tac Toe Game

This is a simple console-based Tic Tac Toe game implemented in C# using .NetFramework 8. 

### Gameplay Instructions

- The game is played on a 3x3 grid.
- Players take turns to place their symbol ('X' or 'O') on an empty cell.
- The first or second player to get three of their symbols in a row (horizontally, vertically, or diagonally) wins the game.
- If all cells are filled and no player has achieved a win, the game ends in a draw.

### Code Structure

- `Program.cs`: The application contains the main game logic. It organizes the flow of the game, including initializing the game board, managing player turns, receiving user input, updating the board, and checking for a winner.
- `InitializeBoard`: The InitializeBoard method is responsible for setting up the game board at the beginning of each game.
- `PlayGame`: This method manages the game loop, where players take turns placing their symbols on the board until the game is over. 
- `GetCoordinates`: This method is responsible for reading user input to determine the cell where the current player wants to place their symbol. It prompts the user to input row and column numbers separated by a space, validates the input to ensure it corresponds to a valid cell on the board, and returns the coordinates of the selected cell.
- `CheckForWinner`: This method checks if a player has won the game.

###Test Cases:
I have covered various scenarios, including winning conditions, draw conditions, player turns, user input handling, and error handling to ensure the correctness and robustness of the Tic Tac Toe game implementation. Here's a summary of the scenarios covered:

1. `Winning Scenarios:` 

- Test_RowWin: Tests if a player wins by filling an entire row with their symbols ('X').
- Test_ColumnWin: Tests if a player wins by filling an entire column with their symbols ('O').
- Test_DiagonalWin_Player1: Tests if player 1 wins by filling one of the diagonals with their symbols ('X').
- Test_DiagonalWin_Player2: Tests if player 2 wins by filling one of the diagonals with their symbols ('O').

2. `Draw Condition:` Tests if the game correctly identifies a draw when all cells are filled and no player has won.

3. `Test_AlternatePlayers:` Tests that the game does not identify a winner when the game board is empty, ensuring both players have equal opportunities to make moves.

4. `User Input Handling:`

- Test_GetCoordinates_ValidInput: Tests if the program correctly parses and returns valid user input coordinates.
- Test_GetCoordinates_InValidInput: Tests if the program handles invalid user input by providing an appropriate error message.

5. `Test_OccupiedCell:` Tests if the program correctly handles attempts to place a symbol in an already occupied cell, providing an error message to the user.


## Running the Program:

1. Download the TicTacToe ZIP file containing the source code.

2. Extract the contents of the ZIP file to a desired location on your computer.

3. Launch Visual Studio on your Windows PC go to the "File" menu and select "Open" > "Project/Solution...". Navigate to the folder where you extracted the contents of the ZIP file.

4. In the folder, you should see a file with a .sln extension. This is the solution file for your project. Select it and click "Open".

5. Once the solution is loaded, you'll see the files and projects within the solution.

6. Build and Run the Project by selecting "Build" > "Build Solution" from the menu. To run the project, you can press F5 to start debugging.

7. The program will display the initial state of the TicTacToe game.

8. When the console board appears, please enter the row number followed by the column number, separated by a space. For example, to place your symbol in the top-right corner, enter '0 2'.

9. Player 1 represents an "X" and player 2 represents an "O".

10. 

Example Output:

~~~~ 
Initial Board

     col0 col1 col2
row0:  *    *    *
row1:  *    *    *
row2:  *    *    *

After the game starts it will be like this

 X O X
 X O O
 O X X
~~~~ 


