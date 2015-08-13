// var button = document.getElementById("the-button");

//button.onload = function createDivs() {
window.onload = function createDivs() {
	var mainDiv = document.getElementById("container");
	var countOfDivs = parseInt(prompt("Count of divs:"));

	while (countOfDivs > 0) {
		createRandomDiv();
		countOfDivs--;
	}

	function createRandomDiv() {
		var div = document.createElement("div");

		var randomWidth = Math.floor(Math.random() * (1300 - 700) + 700);
		var randomHeight = Math.floor(Math.random() * (1300 - 700) + 700);

		div.style.width = randomWidth + "px";
		div.style.height = randomHeight + "px";
		div.style.backgroundColor = getRandomColor();
		div.style.color = getRandomColor();

		if (div.style.backgroundColor === div.style.color) {
			div.style.color = getRandomColor();
		}

		div.style.position = getRandomPosition();

		var strong = document.createElement("strong");

		strong.innerHTML = "div";
		div.appendChild(strong);
		div.style.borderRadius = getRandomBorderRadius() + "px";
		div.style.borderColor = getRandomColor();

		if (div.style.backgroundColor === div.style.borderColor || div.style.borderColor === div.style.color) {
			div.style.borderColor = getRandomColor();
		}
		var borderWidth = getRandomBorderWidth + "px " + getRandomBorderWidth() + "px " + getRandomBorderWidth() + "px " + getRandomBorderWidth() + "px";
		div.style.borderWidth = getRandomBorderWidth() + "px";

		mainDiv.appendChild(div);
	}

	function getRandomColor() {
		var letters = '0123456789ABCDEF'.split('');
		var color = '#';
		for (var i = 0; i < 6; i++) {
			color += letters[Math.floor(Math.random() * 16)];
		}
		return color;
	}

	function getRandomPosition() {
		var choice = Math.floor(Math.random() * 6);
		var position = "";

		switch (choice) {
			case 1:
				position = "static";
				break;
			case 2:
				position = "absolute";
				break;
			case 3:
				position = "fixed";
				break;
			case 4:
				position = "relative";
				break;
			case 5:
				position = "initial";
				break;
			case 6:
				position = "inherit";
				break;
		}

		return position;
	}

	function getRandomBorderRadius() {
		return Math.floor(Math.random() * 300);
	}

	function getRandomBorderWidth() {
		return Math.floor(Math.random() * 20);
	}
}