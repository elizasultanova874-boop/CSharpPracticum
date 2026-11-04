# Git notes

## Task 15 — Basic git
### Commands
git checkout -b feature/git-basics
git add README.md
git commit -m "docs: update readme in feature branch"
git checkout master
git add README.md
git commit -m "docs: update readme in master branch"
git merge feature/git-basics
git add README.md
git commit -m "fix: resolve merge conflict in README"

### Output (git log --graph --oneline --all)
* 2f88a8b (HEAD -> master) fix: resolve merge conflict in README
*   a331854 (feature/git-basics) docs: update readme in feature branch
|\  
| * 56c0ca7 docs: update readme in master
|/  
* fb12b7d feat: tasks 1-5
* 183c7a feat: task 02 - primitives

### What I learned
Я научилась создавать ветки, переключаться между ними, делать коммиты в разных ветках и вызывать конфликт слиянием. Самое главное — я поняла, как вручную разрешать конфликты и сохранять результат.