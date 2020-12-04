read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add : Ability to get number of contact persons i.e. count by City or State"
git push origin $a
git checkout master
git merge $a
git push origin master --force
