(function(){
	var canvas = document.getElementById("face-with-hat");
	var ctx = canvas.getContext("2d");

	ctx.fillStyle = "#90CAD7";
	ctx.strokeStyle = "#22545F";

	//basic head
	ctx.beginPath();
	ctx.arc(300, 300, 100, 0, 2*Math.PI);
	ctx.fill();
	ctx.stroke();
	ctx.closePath();

	//hat
	
	ctx.save();
	ctx.beginPath();
	ctx.scale(1, 1/2);
	ctx.acr(270, 270, 20, 0, 2*Math.PI);
	ctx.restore();
	ctx.stroke();
	ctx.closePath();
}());