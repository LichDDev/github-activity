# 🚀 GitHub User Activity CLI

A command-line tool built with **C# and .NET** to fetch and display recent activity of a GitHub user using the GitHub API.

This project is part of the  [roadmap.sh Backend Projects](https://roadmap.sh/projects/github-user-activity).


## ✨ Features

- 📊 Fetch recent activity for any GitHub user  
- 🎯 Supports multiple event types (push, issues, pull requests, etc.)  
- 💻 Simple and clean CLI interface  
- ⚡ Fast and lightweight implementation in .NET  


## 🧱 Prerequisites

Before running the project, make sure you have:

- .NET SDK installed (recommended: .NET 8 or higher)  
- Internet connection (to consume the GitHub API)  


## 📦 Installation

Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/github-activity.git
cd github-activity
```

## ⚡ Usage
Run the application by passing a GitHub username:
```bash
dotnet run -- github-activity <username>
```
Example:
```bash
dotnet run -- github-activity gaearon
```
## 📊 Example Output
```bash
- Pushed 3 commits to facebook/react
- Opened an issue in microsoft/vscode
- Starred vercel/next.js
```
## 🛠️ Technologies Used
Language: C#
Framework: .NET
API: GitHub REST API
