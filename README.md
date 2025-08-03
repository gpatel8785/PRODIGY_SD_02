# Hi-Lo Game (ASP.NET WebForms)

A simple **Hi-Lo guessing game** built with **C#** and **ASP.NET WebForms**. Players enter their name and try to guess a randomly generated number, receiving feedback after each guess until they find the correct answer.

![ASP.NET](https://img.shields.io/badge/ASP.NET-WebForms-blue)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-purple)
![Bootstrap](https://img.shields.io/badge/Bootstrap-UI-success)

## 🎮 Game Overview

The Hi-Lo game challenges players to guess a secret number within a defined range. After each guess, the game provides feedback indicating whether the guess is too high or too low, helping players narrow down the correct answer. The game features a modern dark theme with responsive design.

## ✨ Features

- **🎯 Simple Guessing Game** - Guess a number within a range with helpful feedback
- **💾 Session-Based State** - Player progress persists between page loads
- **🌙 Dark Theme UI** - Modern, responsive interface built with Bootstrap
- **🔗 Clean URLs** - Friendly routing with bundled JavaScript libraries
- **🔄 Restart Functionality** - Play multiple rounds or exit cleanly
- **📱 Responsive Design** - Works on desktop and mobile devices

## 🏗️ Architecture

The application consists of three main pages:

| Page | Purpose |
|------|---------|
| **Start.aspx** | Entry point where players enter their name |
| **Game.aspx** | Main game interface with guessing logic |
| **PlayAgain.aspx** | Post-game page for restarting or exiting |

### State Management
All game state (player name, secret number, and range limits) is stored in ASP.NET session variables, ensuring persistence across postbacks.

## 🚀 Getting Started

### Prerequisites

- **Visual Studio 2019 or later**
- **.NET Framework 4.8**
- **IIS Express** (included with Visual Studio)
- **Internet connection** (for NuGet package restoration)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/gpatel8785/PRODIGY_SD_02.git
   cd PRODIGY_SD_02
   ```

2. **Open in Visual Studio**
   - Open `HiLoGameASP4.sln` in Visual Studio
   - Allow NuGet package restoration when prompted

3. **Build the project**
   ```
   Build → Build Solution
   ```

4. **Run the application**
   - Press `F5` to start with debugging
   - Navigate to `/Start` in your browser

### How to Play

1. Enter your name on the start page
2. Guess a number within the displayed range
3. Receive feedback (too high/too low) after each guess
4. Continue until you find the correct number
5. Choose to play again or exit

## 📁 Project Structure

```
HiLoGameASP4/
├── Start.aspx              # Name entry page
├── Game.aspx               # Main game interface
├── PlayAgain.aspx          # Post-game options
├── App_Start/
│   ├── RouteConfig.cs      # URL routing configuration
│   └── BundleConfig.cs     # Script bundling setup
├── Content/
│   ├── bootstrap.css       # Bootstrap framework
│   └── style.css           # Custom dark theme styles
├── Scripts/                # JavaScript libraries
├── Global.asax             # Application startup configuration
└── *.cs files              # Code-behind files
```

## 🎨 Customization

### Change Number Range
Modify the constants in `Game.aspx.cs`:
```csharp
private const int MIN_NUMBER = 1;
private const int MAX_NUMBER = 100;
```

### Customize Theme
Edit `Content/style.css` to change:
- Color scheme (currently dark blue/coral)
- Typography (currently uses Poppins font)
- Layout and spacing

### Add Features
Extend the game by adding:
- Attempt counters
- High-score tracking
- Multiple difficulty levels
- Timer functionality

## 🛠️ Technologies Used

- **Backend**: C#, ASP.NET WebForms 4.8
- **Frontend**: HTML5, CSS3, Bootstrap
- **JavaScript**: jQuery, Modernizr
- **State Management**: ASP.NET Session State
- **Build Tools**: Visual Studio, NuGet

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

Please ensure your code follows the existing style and includes appropriate documentation.

## 👨‍💻 Authors

- **Gaurav Patel** - Primary Developer


## 📧 Contact

For questions, suggestions, or licensing inquiries, please open an issue in this repository.

## 🙏 Acknowledgments

- Bootstrap team for the responsive framework
- jQuery team for JavaScript utilities
- Microsoft for ASP.NET WebForms platform

---

**Happy Gaming! 🎮**
