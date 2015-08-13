(function () {
  'use strict';

  function createDiv() {
    var result = document.createElement('div'),
      style = result.style;

    style.width = '50px';
    style.height = '50px';

    style.backgroundColor = getRandomColor();

    style.color = getRandomColor();
    style.textAlign = 'center';

    style.position = 'absolute';
    style.top = getRandomInt(0, 75) + '%';
    style.left = getRandomInt(0, 75) + '%';

    style.borderRadius = '50%';
    style.borderColor = getRandomColor();
    style.borderWidth = '2px';
    style.borderStyle = ['solid', 'dashed', 'dotted'][getRandomInt(0, 2)];

    result.appendChild(createStrong('div'));

    return result;
  }

  function createStrong(text) {
    var result = document.createElement('strong');

    result.appendChild(document.createTextNode(text));

    return result;
  }

  function getRandomColor() {
    return 'rgba(' + [
        getRandomInt(0, 255),
        getRandomInt(0, 255),
        getRandomInt(0, 255),
        getRandomInt(0, 255)
      ].join(', ') + ')';
  }

  function Circle(x, y, r) {
    this.x = x;
    this.y = y;
    this.radius = r;

    this.el = document.createElement('div');
    var style = this.el.style;

    style.width = r * 2 + 'px';
    style.height = r * 2 + 'px';

    style.position = 'absolute';
    style.top = x - r + 'px';
    style.left = y - r + 'px';

    style.borderRadius = '50%';
    style.borderColor = 'black';
    style.borderWidth = '1px';
    style.borderStyle = 'solid';
  }

  Circle.prototype.drawAtDegrees = function (el, degrees) {
    var x = this.x + this.radius * Math.cos(degrees * Math.PI / 180),
      y = this.y + this.radius * Math.sin(degrees * Math.PI / 180);

    el.style.left = x - parseInt(el.style.width, 10) / 2 + 'px';
    el.style.top = y - parseInt(el.style.height, 10) / 2 + 'px';
  };

  var listTempContainer = document.createDocumentFragment(),
    divList = [],
    divCount = 5,
    circle = new Circle(200, 200, 100);

  listTempContainer.appendChild(circle.el);

  for (var i = 0; i < divCount; i += 1) {
    var div = createDiv();
    listTempContainer.appendChild(div);
    divList.push(div);
    var degrees = i * 360 / divCount;
    div.setAttribute('data-degrees', degrees);
    circle.drawAtDegrees(div, degrees);
  }

  document.body.appendChild(listTempContainer);

  setInterval(function () {
    for (var i = 0; i < divCount; i += 1) {
      div = divList[i];
      degrees = (parseFloat(div.getAttribute('data-degrees')) + 1) % 360;
      div.setAttribute('data-degrees', degrees);
      circle.drawAtDegrees(div, degrees);
    }
  }, 100);

  //https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/Math/random
  function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }
})();