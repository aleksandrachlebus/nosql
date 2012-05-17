#!/bin/bash
clear

function help() {
	echo "Aby uruchomi� skrypt nale�y poda� po poleceniu nazwe bazy oraz nazwe kolekcji" 
	echo "Przykladowe uzycie skryptu"
	echo "./import_to_mongo.sh mojabaza waluty"
  exit 1
}
#$1-nazwa_bazy
#$2-nazwa_kolekcji

if [ "$#" -ne 2 ]
	then
		help
	elif [ ! -f  waluty.json ] 
	then
		echo "B��d.Nie wykrywam pliku waluty.json. Sprawd� czy znajdujesz si� w odpowiednim katalogu !"
	else
		echo "Importowanie danych do bazy $1 i kolekcji $2"
		mongoimport --file  waluty.json --db $1 --collection $2
		echo "Uko�czono pomy�lnie ! "
fi