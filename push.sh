read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add : Ability to sort the entries in the address book alphabetically by Person’s name"
git push origin $a
git checkout master
git merge $a
git push origin master --force
