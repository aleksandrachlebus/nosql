#!/bin/bash
clear

function help() {
	echo "Aby uruchomiæ skrypt nale¿y podaæ po poleceniu nazwe hosta bazy oraz nazwe pliku"
	echo "Przykladowe uzycie skryptu"
	echo "./import_to_couch.sh http://localhost:5984 waluty waluty.json"          
  exit 1
}

#$1-host
#$2-nazwa_bazy

if [ $# -ne 3 ]; then
help

	else

echo "Deleting the database: " $1"/"$2

	curl -X DELETE  $1"/"$2


echo "Creating new database: "$1"/"$2
	curl -X PUT  $1"/"$2

	while read line 
	do
		curl -d "$line" -X POST -H "Content-Type: application/json" $1"/"$2 
	done < $3;
	echo "Ukoñczono pomyœlnie ! "

fi

exit 0