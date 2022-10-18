#  Introduction to version control
###  Set the Name and Email for Git
git config --global user.name "your name"

git config --global user.email "yourEmail@email.com"

### Remember to Save file before adding the commit
   press "CMD+S"

### Add the file for future commit
git add <fileName>

### Add the new commit with your comment
git commit -m "Add the file for future commit"

### Check you added correctly your name and email
git config --list --global

### Look through the history of commits
git log

### Look through the history of commits in brief
git log --oneline  

### Switch to commit
git checkout "the first letters of commit"

# Branches
### Create the the branch
git branch "branch name"

### Look through the all branches
git branch

### Switch to branch
git checkout "branch name"

### Merge branch
git merge "daughter branch"

### Delete the branch
git branch -d "branch name"

### Show the chart of commits and branches
git log --graph
# Pull request
### Copy the repository
git clone "link from GitHub"

### Allocate your data on your GitHub repository
git push

### Take the data from your GitHub repository
git pull

### Do the branch of head repository (press "Fork" on GitHub). Then Clone forked repository, do some changes in new branch. Then commit changes, push it to forked repository and press "Pull request" with comments. Ann wait for the answer from repository's owner (approve or reject)
