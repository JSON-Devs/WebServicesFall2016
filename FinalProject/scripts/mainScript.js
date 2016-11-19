//marineCall('40.23445','23.44555');

function convertToLatLong() {
	if(address.value != "") {
		var url = 'https://maps.googleapis.com/maps/api/geocode/json?address=' + address.value + '&key=AIzaSyBEMCtKvrESgW60CeROctXq-jBern2xoI0';
		// Cross platform xmlhttprequest

		// Create xmlhttprequest object
		var xmlhttp = null;
		if (window.XMLHttpRequest) {
			xmlhttp = new XMLHttpRequest();
			//make sure that Browser supports overrideMimeType
			if (typeof xmlhttp.overrideMimeType != 'undefined') {
				xmlhttp.overrideMimeType('text/xml');
			}
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
				var name = myObj.results[0].formatted_address;
				var lat = myObj.results[0].geometry.location.lat;
				var lng = myObj.results[0].geometry.location.lng;
				marineCall(name, lat, lng);
			} else {
				// waiting for the call to complete
			}
		};

		// Make the actual request
		xmlhttp.send(null);
	}
	else {
		console.log("Please enter an address");
	}
}

function marineCall(name, lat, lng) {
	var url = 'http://api.worldweatheronline.com/premium/v1/marine.ashx?key=a09e7b4388894e46bb4173219161811&format=json&tide=yes&q=' + lat + ',' + lng;
	// Cross platform xmlhttprequest

	// Create xmlhttprequest object
	var xmlhttp = null;
	if (window.XMLHttpRequest) {
		xmlhttp = new XMLHttpRequest();
		//make sure that Browser supports overrideMimeType
		if (typeof xmlhttp.overrideMimeType != 'undefined') {
			xmlhttp.overrideMimeType('text/xml');
		}
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
			console.log("Location: " + name);
			for(var i = 0; i < myObj.data.weather.length; i++){
				console.log("Date: " + myObj.data.weather[i].date);
				console.log("Sunrise: " + myObj.data.weather[i].astronomy[0].sunrise);
				console.log("Sunset: " + myObj.data.weather[i].astronomy[0].sunset);
				console.log("Tides");
				for(var j = 0; j < myObj.data.weather[i].tides[0].tide_data.length; j++){
					var highOrLow = "";
					switch (myObj.data.weather[i].tides[0].tide_data[j].tide_type ) {
						case "HIGH":
							highOrLow = "High";
							break;
						case "LOW":
							highOrLow = "Low";
							break;
						default:
							break;
					}
					console.log(highOrLow + " Tide: " + myObj.data.weather[i].tides[0].tide_data[j].tideTime);
					var tideHigghtMeter = myObj.data.weather[i].tides[0].tide_data[j].tideHeight_mt;
					var tideHigghtFeet = (tideHigghtMeter * 3.28) + "";
					console.log("Tide Height: " + tideHigghtFeet.substring(0, 4) + " ft");
				}
				console.log("High: " + myObj.data.weather[i].maxtempF + " F");
				console.log("Low: " + myObj.data.weather[i].mintempF + " F");
				console.log("Hourly Forecast");
				for(var k = 0; k < myObj.data.weather[i].hourly.length; k++){
					//Switch case goes here for time
					switch (myObj.data.weather[i].hourly[k].time) {
						case "0":
							console.log("Time: 12:00 AM");
							break;
						case "300":
							console.log("Time: 3:00 AM");
							break;
						case "600":
							console.log("Time: 6:00 AM");
							break;
						case "900":
							console.log("Time: 9:00 AM");
							break;
						case "1200":
							console.log("Time: 12:00 PM");
							break;
						case "1500":
							console.log("Time: 3:00 PM");
							break;
						case "1800":
							console.log("Time: 6:00 PM");
							break;
						case "2100":
							console.log("Time: 9:00 PM");
							break;
						default:
							break;
					}
					console.log("Weather Description: " + myObj.data.weather[i].hourly[k].weatherDesc[0].value);
					console.log("Cloud Cover: " + myObj.data.weather[i].hourly[k].cloudcover + "%");
					var visKm = myObj.data.weather[i].hourly[k].visibility;
					var visMi = (visKm * 0.621371) + "";
					console.log("Visibility: " + visMi.substring(0,4) + " mi");
					console.log("Icon URL: " + myObj.data.weather[i].hourly[k].weatherIconUrl[0].value);
					console.log("Wind Gust: " + myObj.data.weather[i].hourly[k].WindGustMiles + " mph");
					console.log("Temperature: " + myObj.data.weather[i].hourly[k].tempF + " F");
					console.log("Feels Like Temperature: " + myObj.data.weather[i].hourly[k].FeelsLikeF + " F");
					console.log("Wind Chill: " + myObj.data.weather[i].hourly[k].WindChillF + " F");
					console.log("Humidity: " + myObj.data.weather[i].hourly[k].humidity + "%");
					console.log("Water Temperature: " + myObj.data.weather[i].hourly[k].waterTemp_F + " F");
					console.log("Wind Speed: " + myObj.data.weather[i].hourly[k].windspeedMiles + " mph");
					console.log("Wind Direction: " + myObj.data.weather[i].hourly[k].winddir16Point);
					console.log("Wave Height: " + myObj.data.weather[i].hourly[k].swellHeight_ft + " ft");
					var sigHeightM = myObj.data.weather[i].hourly[k].sigHeight_m;
					var sigHeightFt = (sigHeightM * 3.28) + "";
					console.log("Significant Wave Height: " + sigHeightFt.substring(0,4) + " ft");
					console.log("Wave Direction: " + myObj.data.weather[i].hourly[k].swellDir16Point);
				}
				console.log(" ");
			}
		} else {
			// waiting for the call to complete
		}
	};

	// Make the actual request
	xmlhttp.send(null);
}
