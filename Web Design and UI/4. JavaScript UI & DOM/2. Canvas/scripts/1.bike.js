(function(){
	var canvas = document.getElementById("bike");
	var ctx = canvas.getContext("2d");

	ctx.fillStyle = "#90CAD7";
	ctx.strokeStyle = "#22545F";

	//left wheel
	ctx.beginPath();
	ctx.arc(300, 500, 100, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();
	ctx.closePath();

	//bike frame
	ctx.beginPath();
	ctx.moveTo(300, 500);
	ctx.lineTo(450, 350);
	ctx.lineTo(800, 360);
	ctx.lineTo(500, 490);
	ctx.lineTo(300, 500);
	ctx.stroke();
	ctx.closePath();

	//right wheel
	ctx.beginPath();
	ctx.arc(820, 500, 100, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();
	ctx.closePath();

	//front set
	ctx.beginPath();
	ctx.moveTo(820, 500);
	ctx.lineTo(785, 250);
	ctx.lineTo(850, 150);
	ctx.moveTo(785, 250);
	ctx.lineTo(670, 300);
	ctx.stroke();
	ctx.closePath();

	//saddle area
	ctx.beginPath();
	ctx.moveTo(500, 490);
	ctx.lineTo(420, 270);
	ctx.moveTo(370, 270);
	ctx.lineTo(470, 270);
	ctx.stroke();
	ctx.closePath();

	//crank arm and pedal
	ctx.beginPath();
	ctx.arc(500, 490, 30, 0, 2*Math.PI);
	ctx.moveTo(480, 470);
	ctx.lineTo(460, 450);
	ctx.moveTo(520, 510);
	ctx.lineTo(540, 530);
	ctx.stroke();
	ctx.closePath();
}());