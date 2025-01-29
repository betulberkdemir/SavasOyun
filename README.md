SavasOyun

SavasOyun is a strategic card game developed using C# and .NET Framework 4.7.2. The game involves players selecting and battling with various war vehicles, each with unique attributes and advantages.

Table of Contents
•	#installation
•	#usage
•	#classes-and-components
•	#game-rules
•	#contributing
•	#license

Installation

  1.	Clone the repository:

 git clone https://github.com/yourusername/SavasOyun.git

2.	Open the solution in Visual Studio 2022.
3.	Restore the NuGet packages.
4.	Build the solution.
5.	Usage
1.	Run the application from Visual Studio.
2.	The main form (Form1) will appear, allowing you to start a new game.
3.	Select your cards and place them in the arena.
4.	Click the "Fight" button to battle against the computer.
5.	The game will display the results and update the scores accordingly.
   
Classes and Components

Main Classes
•	SavasArac: Abstract base class for all war vehicles.
•	HavaArac: Abstract class for air vehicles, inherits from SavasArac.
•	Kullanici: Represents the user player, inherits from Oyuncu.
•	Bilgisayar: Represents the computer player, inherits from Oyuncu.
User Controls
•	KartTutucu: User control for displaying and managing a single card.
•	KartTutucuKucuk: Smaller version of KartTutucu for displaying cards in the player's hand.

Forms
•	Form1: Main form of the application, handles the game logic and user interactions.
Game Rules
1.	Each player starts with a set of cards representing different war vehicles.
2.	Players take turns selecting and placing cards in the arena.
3.	Each card has attributes such as durability, attack power, and class advantages.
4.	The game calculates the damage based on the attributes and class advantages.
5.	The player with the highest score at the end of the game wins.

Contributing
Contributions are welcome! Please follow these steps:
1.	Fork the repository.
2.	Create a new branch (git checkout -b feature-branch).
3.	Make your changes.
4.	Commit your changes (git commit -m 'Add new feature').
5.	Push to the branch (git push origin feature-branch).
6.	Open a pull request.

7.	License
This project is licensed under the MIT License. See the LICENSE file for details.
