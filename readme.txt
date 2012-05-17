Operowa³am na danych o kursach walut , znajduj¹ siê one w pliku waluty.json

1. Import z pliku JSON do mongo:
Skrypt:			import_to_mongo.sh
U¿ycie:			./import_to_mongo.sh mojabaza waluty
Sprawdzenie:	db.waluty.find()


2.Import z pliku JSON do couch:
Skrypt:			import_to_couch.sh
U¿ycie:			/import_to_couch.sh http://localhost:5984 waluty waluty.json
Sprawdzenie: 	http://localhost:5984/_utils/database.html?waluty
	

3.Map Reduce dla Mongo:
Map Reduce zlicza ile w bazie walut o przelicznikach 1 , a ile o przelicznikach 2.
Plik: 			mapreduce_mongo.js
U¿ycie:			mongo mapreduce_mongo.js --shell
				db.przelicznik.find()












repozytorium zawiera dodatkowo projekt w microsoft visual c#, który dodaje dane do mongodb:

uruchomienie mongodb:
tworzymy na dysku c katalog data,a w nim podkatalog db
w konsoli, z miejsca w którym mamy zainstalowane mongodb wpisujemy mongod -- c:\\data\db

projekt uruchamiamy w microsoft visual c# (wystarczy wcisnaæ F5)

