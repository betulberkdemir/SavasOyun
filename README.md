# 🎮🔥 Battle Game 🚀⚔️

Savaş Oyun is a strategy card game developed using **C# and .NET Framework 4.7.2.** Players fight their opponents by choosing different combat vehicles. Each vehicle has its own unique features and advantages.


## 📌 Contents
- [Usage](#usage)
- [Classes and Components](#classes-and-components)
- [Game Rules](#game-rules)
- [Contributing](#contributing)
- [License](#license)

## 🎮 Usage

Oyunu başlattıktan sonra:
1. Başlangıç ekranından "Yeni Oyun" seçeneğini tıklayın.
2. Kartlarınızı seçin ve rakibinizle mücadeleye başlayın.
3. Her turun sonunda stratejinizi belirleyerek savaşın kazananı olun!

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
-	**Form1.cs**: Main form of the application, handles the game logic and user interactions.

---

## 📜 Game Rules

- **Each player starts with a set of cards representing different war vehicles.**
- **Players take turns selecting and placing cards in the arena.**
- **Each card has attributes such as durability, attack power, and class advantages.**
-**The game calculates the damage based on the attributes and class advantages.**
-**The player with the highest score at the end of the game wins.**

---

![Image Alt](https://github.com/betulberkdemir/SavasOyun/blob/master/image.png))
