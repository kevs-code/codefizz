#! /bin/bash
echo "Hello User, I'm Tron! Building ..."
firstline=$(head -n 1 source/changelog.md)

read -a splitfirstline <<< $firstline
version=${splitfirstline[1]}
echo $version
echo "Version OK? 1=Yes 0=No"
read versioncontinue
if [ $versioncontinue -eq 1 ]
then
  echo "OK"
for filename in source/*
do
  echo $filename
  if [ "$filename" == "source/secretinfo.md" ]
  then
  echo "File is not being copied." $filename
  else
  echo "File is being copied." $filename
  cp $filename build # build/.
  fi
done
else
  echo "Please come back when you are ready"
fi
cd build/
echo "Build version $version contains:"
ls
cd ..
