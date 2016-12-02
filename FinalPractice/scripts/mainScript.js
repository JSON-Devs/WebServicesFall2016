function myLoad() {
	var url = 'http://54.84.69.209/jsonfootballservice/footballteams/getfootballteam';
	// Cross platform xmlhttprequest

	// Create xmlhttprequest object
	var xmlhttp = null;
	if (window.XMLHttpRequest) {
		xmlhttp = new XMLHttpRequest();
		//make sure that Browser supports overrideMimeType
		if (typeof xmlhttp.overrideMimeType != 'undefined') { xmlhttp.overrideMimeType('text/xml'); }
	} else if (window.ActiveXObject) {
		xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
	} else {
		alert('Perhaps your browser does not support xmlhttprequests?');
	}

	// Create an HTTP GET request
	xmlhttp.open('GET', url, true);

	// Set the callback function
	xmlhttp.onreadystatechange = function () {
		if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
			var myObj = JSON.parse(xmlhttp.responseText);
			console.log(myObj);

		} else {
			// waiting for the call to complete
		}
	};

	// Make the actual request
	xmlhttp.send(null);
}