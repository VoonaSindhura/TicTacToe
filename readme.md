## Tic Tac Toe Game

This is a simple console-based Tic Tac Toe game implemented in C#. 

### Gameplay Instructions

- The game is played on a 3x3 grid.
- Players take turns to place their symbol ('X' or 'O') on an empty cell.
- The first or second player to get three of their symbols in a row (horizontally, vertically, or diagonally) wins the game.
- If all cells are filled and no player has achieved a win, the game ends in a draw.

### Code Structure

- `Program. cs`: The application and contains the main game logic. It organizes the flow of the game, including initializing the game board, managing player turns, receiving user input, updating the board, and checking for a winner.
- `InitializeBoard`: The InitializeBoard method is responsible for setting up the game board at the beginning of each game.
- `PlayGame`: This method manages the game loop, where players take turns placing their symbols on the board until the game is over. 
- `GetCoordinates`: This method is responsible for reading user input to determine the cell where the current player wants to place their symbol. It prompts the user to input row and column numbers separated by a space, validates the input to ensure it corresponds to a valid cell on the board, and returns the coordinates of the selected cell.
- `CheckForWinner`: This method checks if a player has won the game.

Notes
This program is developed using .NET Framework 8.
It is a console application, meaning it operates via command-line input and output.

## Running the Program:

1. Download the TicTacToe ZIP file containing the source code.

2. Extract the contents of the ZIP file to a desired location on your computer.

3. Launch Visual Studio on your Windows PC go to the "File" menu and select "Open" > "Project/Solution...". Navigate to the folder where you extracted the contents of the ZIP file.

4. In the folder, you should see a file with a .sln extension. This is the solution file for your project. Select it and click "Open".

5. Once the solution is loaded, you'll see the files and projects within the solution.

6. Build and Run the Project by selecting "Build" > "Build Solution" from the menu. To run the project, you can press F5 to start debugging.

7. The program will display the initial state of the TicTacToe game, Player 1 represents an "X" and player 2 represents an "O".


Example Output:

~~~~ 
Initial Board
 * * *
 * * *
 * * *

After the game starts it will be like this
Player 1 is 'X' and Player 2 is 'O'

 X O X
 X O O
 O X X
~~~~ 
