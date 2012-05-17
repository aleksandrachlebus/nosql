m = function() {
		if(this.przelicznik == "1")
			emit("Jedynka",1);

		else
			emit("Dwojka",1);
};



r = function(key, values) {
	var result = 0;
	values.forEach(function(count) {
		result += count;
	});
	return result;
};	 

res = db.waluty.mapReduce(m, r, {out: "wynik"}); 
printjson(res);