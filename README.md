# Tic-Tac-Toe Reinforcement Learning Agent

This project implements a simple reinforcement learning agent to play the game of Tic-Tac-Toe. The agent learns to play the game by playing against itself and updating its strategy based on the outcomes of the games.

## Features

- **Tic-Tac-Toe Game Logic**: A complete implementation of the classic Tic-Tac-Toe game.
- **Reinforcement Learning Agent**: An agent that learns to play Tic-Tac-Toe through repeated gameplay.
- **Save and Load Learning**: Functionality to save and load the learned policies, enabling persistent learning.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software:

- [.NET SDK](https://dotnet.microsoft.com/download)

### Installing

A step-by-step series of examples that tell you how to get a development environment running.

1. Clone the repository
   ```sh
   git clone https://github.com/pavadik/tictactoe-reinforcement-learning.git

2. Navigate to the project directory
	cd tictactoe-reinforcement-learning

### Usage

Run the program to start training the agent. The agent will play a specified number of games against itself and learn over time.

	TrainingHelper.TrainAgent(1000); // Train the agent with 1000 games

### Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

1. Fork the Project
2. Create your Feature Branch (git checkout -b feature/AmazingFeature)
3. Commit your Changes (git commit -m 'Add some AmazingFeature')
4. Push to the Branch (git push origin feature/AmazingFeature)
5. Open a Pull Request

### License

This project is licensed under the MIT License - see the LICENSE.md file for details.
