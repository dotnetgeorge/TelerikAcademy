(function() {
		var canvas = document.getElementById("canvas-home");
		var ctx = canvas.getContext("2d");


		ctx.beginPath();
		//roof and basic home
		ctx.moveTo(300, 50);
		ctx.lineTo(500, 200);
		ctx.lineTo(100, 200);
		ctx.lineTo(300, 50);

		ctx.fillStyle = "#975B5B";
		ctx.strokeStyle = "black";
		ctx.fill();
		ctx.stroke();
		ctx.closePath();

		//chimney
		ctx.beginPath();
		ctx.moveTo(370, 170);
		ctx.lineTo(370, 70);

		ctx.bezierCurveTo(370, 80, 400, 80, 400, 70);
		ctx.bezierCurveTo(400, 60, 370, 60, 370, 70);

		ctx.moveTo(400, 70);
		ctx.lineTo(400, 170);

		ctx.fill();
		ctx.stroke();
		ctx.closePath();

		ctx.beginPath();

		ctx.rect(100, 200, 400, 300);

		ctx.fill();
		ctx.stroke();
		ctx.closePath();

		//left windows
		ctx.beginPath();

		ctx.rect(120, 220, 70, 50);
		ctx.rect(200, 220, 70, 50);
		ctx.rect(120, 280, 70, 50);
		ctx.rect(200, 280, 70, 50);
		
		ctx.fillStyle = "#000";
		ctx.fill();
		ctx.closePath();

		//right windows
		ctx.beginPath();

		ctx.rect(320, 220, 70, 50);
		ctx.rect(400, 220, 70, 50);
		ctx.rect(320, 280, 70, 50);
		ctx.rect(400, 280, 70, 50);

		//right down windows
		ctx.rect(320, 360, 70, 50);
		ctx.rect(400, 360, 70, 50);
		ctx.rect(320, 420, 70, 50);
		ctx.rect(400, 420, 70, 50);

		ctx.fillStyle = "#000";
		ctx.fill();
		ctx.closePath();

		//doors
		ctx.beginPath();
		ctx.moveTo(130, 500);
		ctx.lineTo(130, 400);

		ctx.moveTo(130, 400);
		ctx.bezierCurveTo(130, 350, 260, 350, 260, 400);

		ctx.lineTo(260, 500);

		ctx.moveTo(195, 500);
		ctx.lineTo(195, 362);

		//handles of doors
		ctx.moveTo(190, 470);
		ctx.arc(180, 470, 10, 0, 2*Math.PI);

		ctx.moveTo(220, 470);
		ctx.arc(210, 470, 10, 0, 2*Math.PI);

		ctx.stroke();
		ctx.closePath();
}());