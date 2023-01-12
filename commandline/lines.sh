cat lakes.txt | sort > sorted-lakes.txt 

sort deserts.txt | uniq 
#above arranges alphabetically and removes adjacent duplicates
#uniq deserts.txt
#would just identify adjacent line duplicates
sort deserts.txt | uniq > uniq-deserts.txt

grep Mount mountains.txt
grep -i Mount mountains.txt

#-i insensitive (case)
grep -R Arctic /home/ccuser/workspace/geography
#-recursive show text matches and file
grep -Rl Arctic /home/ccuser/workspace/geography
#l option just file path
sed 's/snow/rain/'g forests.txt
#find replace g = global
sed 's/snow/rain/' forests.txt
#first word occurence on line.
cat lacrosse.txt | wc
# 1      27     159
# line  word   charachters
grep -R player .
# grep player . doesn't work
sed 's/loss/win/' games.txt
wc -l <plants.txt
#stdin to program
wc -l plants.txt
#as argument
ls -l | head > list1.txt
#lists default head long format
ls -la | head >> list1.txt | wc 
#adds total words to file
sort flowers.txt | uniq > uniq-flowers.txt
grep -Rl tree .
sed 's/Dirt/Soils/g' soils.txt
sed 's/Dirt/Soils/'g soils.txt
cat the.txt | sort
