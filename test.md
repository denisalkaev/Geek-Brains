#  Introduction to version control
###  Set the Name and Email for Git
git config --global user.name "<your name>"
  
git config --global user.email "<yourEmail@email.com>"

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