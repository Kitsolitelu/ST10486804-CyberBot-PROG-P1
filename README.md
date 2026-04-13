# ST10486804-CyberBot-PROG-P1

Cybersecurity Awareness Bot for part 1 
This is a C# console application designed to help users understand the basics of online safety through an interactive, AI chatbot themed experience.


The Cybersecurity Awareness Bot serves as an educational tool to simplify complex security topics. It guides you through a personalized session where you can explore various "cyber-threat" modules to better protect your digital life.

Key Modules:
Password Safety: Learn how to build "unbreakable" passwords using symbols and variety while avoiding personal data.

Phishing Defense: Discover how to spot deceptive messages and suspicious links from scammers.

Safe Browsing: Master the signs of a secure connection (HTTPS) and how to block malicious ads.

Code Structure:
Program.cs: The entry point that initializes the bot session.

ChatBot.cs: The main engine that handles navigation and educational content.

UI.cs: Manages the "Typewriter" effect and the ASCII terminal art for a retro-tech feel.

Voice.cs: Provides an audio greeting using local system audio files.

GetUserInput.cs: Ensures the bot knows who it is talking to through validated input.

ShowMenuHelpers.cs: Provides a clean, color-coded menu interface.

 How to Run Locally
Prerequisites
.NET SDK: Ensure you have .NET 6.0 or higher installed.

OS: Windows is required for the audio playback feature (SoundPlayer).

Setup
Clone this repo:

Bash
git clone https://github.com/YourUsername/YourRepoName.git
Navigate to the project folder:

Bash
cd "CyberBot PROG Prac1"
Run the app:

Bash
dotnet run
Usage
When you launch the app:

user input : Enter your name so the bot can personalize the experience.

Choose a Topic: Type the number (1-4) or a keyword like "phishing" or "safe" to jump straight to a lesson.

Exit Safely: Use the "exit" command or option 4 when you are finished to receive a final security reminder.

 CI/CD Integration
This project is configured with a GitHub Actions CI workflow. On every push or pull request, the system automatically:

Sets up the .NET environment.

Restores dependencies.

Builds the project to ensure no compilation errors exist.
