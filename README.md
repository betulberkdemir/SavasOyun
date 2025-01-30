# 🎮🔥 Battle Game 🚀⚔️

Savaş Oyun is a strategy card game developed using **C# and .NET Framework 4.7.2.** Players fight their opponents by choosing different combat vehicles. Each vehicle has its own unique features and advantages.
--

## 📌 Contents
- [Usage](#usage)
- [Classes and Components](#classes-and-components)
- [Game Rules](#game-rules)
- [Contributing](#contributing)
- [License](#license)



## 🎮 Usage

After the game starts
1.	Run the application from Visual Studio.
2.	The main form will appear, allowing you to start a new game.
3.	Select your cards and place them in the arena.
4.	Click the "Fight" button to battle against the computer.
5.	The game will display the results and update the scores accordingly.

---

## 🛠 Classes and Components

Main Classes
- **SavasArac.cs** → Abstract base class for all war vehicles.
- **HavaArac** → Abstract class for air vehicles, inherits from SavasArac.
- **Kullanici.cs** → Represents the user player, inherits from Oyuncu.
- **Bilgisayar.cs** → Represents the computer player, inherits from Oyuncu.


User Controls
- **KartTutucu.cs** → User control for displaying and managing a single card.
- **KartTutucuKucuk.cs** → Smaller version of KartTutucu for displaying cards in the player's hand.

Forms
-	**MainForm.cs**: Main form of the application, handles the game logic and user interactions.

---

## 📜 Game Rules 🚀


### ✅ Objective

The objective of SavasOyun is to defeat your opponent by strategically selecting and placing war vehicle cards in the arena. The player with the highest score at the end of the game wins.

### ✅ Game Setup

***1.	Players:*** The game is played between a user (Kullanici) and the computer (Bilgisayar).

***2.	Cards:*** Each player starts with a set of war vehicle cards. These cards represent different types of vehicles such as air, land, and sea vehicles.

***3.	Attributes:*** Each card has the following attributes:

### ✅ Gameplay

***1.	Starting the Game:***

  •	The game begins with the user and computer each having a set of cards.

  •	The user can select and place cards in the arena by clicking on the "Arena" button.

***2.	Placing Cards:***

  •	The user selects a card from their hand and places it in one of the available slots in the arena.

  •	The computer also selects and places its cards in the arena.

***3.	Battle Phase:***

  •	Once all cards are placed in the arena, the user clicks the "Fight" button to start the battle.

  •	Each card in the arena will battle against the corresponding card of the opponent.

  •	The damage is calculated based on the attributes and class advantages of the cards.

***4.	Damage Calculation:***

  •	The base damage is determined by the Vurus attribute of the card.

  •	Additional damage or reduction is applied based on the class advantages:

  •	Hava (Air) vs. Kara (Land): Air vehicles have an advantage over land vehicles.

  •	Kara (Land) vs. Deniz (Sea): Land vehicles have an advantage over sea vehicles.

  •	Deniz (Sea) vs. Hava (Air): Sea vehicles have an advantage over air vehicles.

***5.	Updating Scores:***

  •	The result of each battle is determined, and the scores are updated accordingly.

  •	The player with the higher score after each battle round is declared the winner of that round.
  
***6.	End of Game:***

  •	The game continues for a set number of rounds or until one player runs out of cards.

  •	The player with the highest total score at the end of the game is declared the winner.

### ✅ Special Rules

1.	Card Durability:

  •	Each card's durability decreases as it takes damage.

  •	If a card's durability reaches zero, it is removed from the game.

2.	Card Levels:

  •	Higher-level cards have better attributes and can inflict more damage.

3.	Special Cards:
  
   •	Certain cards have special abilities or advantages that can turn the tide of the battle.

### ✅ Winning the Game

  •	The game ends when the maximum number of rounds is reached, or one player runs out of cards.
  
  •	The player with the highest score at the end of the game is declared the winner.
  
  •	In case of a tie, the game is declared a draw.

---

![Image Alt](https://github.com/betulberkdemir/SavasOyun/blob/master/image.png)
