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
				$("#addressError").text("");
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
		$("#addressError").text("Error! Please enter an address!");
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
			//Add in if statement to check if formatted_address is undefined
			var str = "<div>";
			str += "<h1>Location: " + name + "</h1>";
			for(var i = 0; i < myObj.data.weather.length; i++){
				str += "<br/><h4>";
				str += "Date: " + myObj.data.weather[i].date;
				str += "</h4><p>";
				str += "Sunrise: " + myObj.data.weather[i].astronomy[0].sunrise;
				str += "&nbsp;&nbsp;&nbsp;&nbsp;";
				str += "Sunset: " + myObj.data.weather[i].astronomy[0].sunset;
				str += "</p>";
				str += "<div>";
				str += "<div>";
				str += "<br/><h4>Tides</h4>";
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
					str += "<p>";
					str += myObj.data.weather[i].date;
					str += "</p><p>";
					str += j + ": " + myObj.data.weather[i].tides[0].tide_data[j].tideTime;
					str += "</p><p>";
					str += highOrLow + " Tide: " + myObj.data.weather[i].tides[0].tide_data[j].tideTime;
					str += "</p><p>";
					var tideHigghtMeter = myObj.data.weather[i].tides[0].tide_data[j].tideHeight_mt;
					var tideHigghtFeet = (tideHigghtMeter * 3.28) + "";
					str += "Tide Height: " + tideHigghtFeet.substring(0, 4) + " ft";
					str += "</p>";
				}
				str+= "</div>";
				str += "<div>";
				str += "<br/><h4>Weather</h4><p>";
				str += "High: " + myObj.data.weather[i].maxtempF + "&deg; F";
				str += "</p><p>";
				str += "Low: " + myObj.data.weather[i].mintempF + "&deg; F";
				str += "</p><p>";
				str += "Hourly Forecast";
				str += "</p><p>";
				for(var k = 0; k < myObj.data.weather[i].hourly.length; k++){
					//Switch case goes here for time
					switch (myObj.data.weather[i].hourly[k].time) {
						case "0":
							str += "Time: 12:00 AM";
							break;
						case "300":
							str += "Time: 3:00 AM";
							break;
						case "600":
							str += "Time: 6:00 AM";
							break;
						case "900":
							str += "Time: 9:00 AM";
							break;
						case "1200":
							str += "Time: 12:00 PM";
							break;
						case "1500":
							str += "Time: 3:00 PM";
							break;
						case "1800":
							str += "Time: 6:00 PM";
							break;
						case "2100":
							str += "Time: 9:00 PM";
							break;
						default:
							break;
					}
					str += "</p><p>";
					str += "Weather Description: " + myObj.data.weather[i].hourly[k].weatherDesc[0].value;
					str += "</p><p>";
					str += "Cloud Cover: " + myObj.data.weather[i].hourly[k].cloudcover + "%";
					str += "</p><p>";					var visKm = myObj.data.weather[i].hourly[k].visibility;
					var visMi = (visKm * 0.621371) + "";
					str += "Visibility: " + visMi.substring(0,4) + " mi";
					str += "</p><p>";
					str += "Wind Gust: " + myObj.data.weather[i].hourly[k].WindGustMiles + " mph";
					str += "</p><p>";
					str += "Temperature: " + myObj.data.weather[i].hourly[k].tempF + "&deg; F";
					str += "</p><p>";
					str += "Feels Like Temperature: " + myObj.data.weather[i].hourly[k].FeelsLikeF + "&deg; F";
					str += "</p><p>";
					str += "Wind Chill: " + myObj.data.weather[i].hourly[k].WindChillF + "&deg; F";
					str += "</p><p>";
					str += "Humidity: " + myObj.data.weather[i].hourly[k].humidity + "%";
					str += "</p><p>";
					str += "Water Temperature: " + myObj.data.weather[i].hourly[k].waterTemp_F + "&deg; F";
					str += "</p><p>";
					str += "Wind Speed: " + myObj.data.weather[i].hourly[k].windspeedMiles + " mph";
					str += "</p><p>";
					str += "Wind Direction: " + myObj.data.weather[i].hourly[k].winddir16Point;
					str += "</p><p>";
					str += "Wave Height: " + myObj.data.weather[i].hourly[k].swellHeight_ft + " ft";
					str += "</p><p>";
					var sigHeightM = myObj.data.weather[i].hourly[k].sigHeight_m;
					var sigHeightFt = (sigHeightM * 3.28) + "";
					str += "Significant Wave Height: " + sigHeightFt.substring(0,4) + " ft";
					str += "</p><p>";
					str += "Wave Direction: " + myObj.data.weather[i].hourly[k].swellDir16Point;
					str += "</p>";
				}
			str+= "</div>";
			}
			$("#infoTables").text("");
			$("#infoTables").append(str);
		} else {
			// waiting for the call to complete
		}
	};

	// Make the actual request
	xmlhttp.send(null);
}
