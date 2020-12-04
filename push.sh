read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Add : Ability to sort the entries in the address book by City, State, or Zip"
git push origin $a
git checkout master
git merge $a
git push origin master --force
