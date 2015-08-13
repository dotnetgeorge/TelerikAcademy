(function() {
	'use strict';

	function addEventListener(selector, eventName, listener) {
		document.querySelector(selector).addEventListener(eventName, listener, false);
	}

	var textEl = document.querySelector('#text');

	addEventListener('#text-color', 'change', function(event) {
		textEl.style.color = event.target.value;
	});

	addEventListener('#bg-color', 'change', function(event) {
		textEl.style.backgroundColor = event.target.value;
	});
})();