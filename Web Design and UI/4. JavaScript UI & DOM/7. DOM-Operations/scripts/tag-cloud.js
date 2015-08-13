(function () {
  'use strict';

  function addEventListener(selector, eventName, listener) {
    document.querySelector(selector).addEventListener(eventName, listener, false);
  }

  function createTagEl(text) {
    var result = document.createElement('span');

    result.appendChild(document.createTextNode(text));

    result.classList.add('tag');

    return result;
  }

  function TagCloud(el) {
    this.el = el;
    this.setMinFontSize(16);
    this.setMaxFontSize(32);
  }

  TagCloud.prototype.setTags = function (tagText) {
    this.tagToCount = {};

    var tags = tagText.match(/"[^"]+"|[\w-]+/g) || [];

    for (var i = 0, length = tags.length; i < length; i += 1) {
      this.addTag(tags[i].toLowerCase());
    }
  };

  TagCloud.prototype.showTags = function () {
    this.el.innerHTML = '';

    var minCount = this.getMinCount(),
      maxCount = this.getMaxCount(),
      countDiff = maxCount - minCount,
      minFontSize = this.getMinFontSize(),
      maxFontSize = this.getMaxFontSize(),
      fontSizeDiff = maxFontSize - minFontSize,
      tempTagContainer = document.createDocumentFragment();

    for (var tag in this.tagToCount) {
      var tagEl = createTagEl(tag),
        count = this.tagToCount[tag],
        relativeCount = (count - minCount) / countDiff,
        relativeFontSize = minFontSize + relativeCount * fontSizeDiff;

      tagEl.style.fontSize = relativeFontSize + 'px';

      tempTagContainer.appendChild(tagEl);
    }

    this.el.appendChild(tempTagContainer);

    this.highlight();
  };

  TagCloud.prototype.addTag = function (tag) {
    var count = this.tagToCount[tag] || 0;
    count += 1;
    this.tagToCount[tag] = count;
  };

  TagCloud.prototype.getMinCount = function () {
    var result = 0;

    for (var tag in this.tagToCount) {
      var count = this.tagToCount[tag];

      if (count < result || result === 0) {
        result = count;
      }
    }

    return result;
  };

  TagCloud.prototype.getMaxCount = function () {
    var result = 0;

    for (var tag in this.tagToCount) {
      var count = this.tagToCount[tag];

      if (count > result) {
        result = count;
      }
    }

    return result;
  };

  TagCloud.prototype.getMinFontSize = function () {
    return this.minFontSize;
  };

  TagCloud.prototype.setMinFontSize = function (size) {
    this.minFontSize = size || 16;
    return this;
  };

  TagCloud.prototype.getMaxFontSize = function () {
    return this.maxFontSize;
  };

  TagCloud.prototype.setMaxFontSize = function (size) {
    this.maxFontSize = size || 32;
    return this;
  };

  TagCloud.prototype.highlight = function () {
    var style = this.el.style;

    style.webkitTransition = 'none';
    style.transition = 'none';
    style.backgroundColor = 'orange';

    //force application of above style to trigger the transition
    this.el.offsetWidth;

    style.webkitTransition = 'all 1s';
    style.transition = 'all 1s';
    style.backgroundColor = 'white';
  };

  var tagInputEl = document.querySelector('#tag-input'),
    minFontSizeInputEl = document.querySelector('#min-font-size'),
    maxFontSizeInputEl = document.querySelector('#max-font-size'),
    tagCloud = new TagCloud(document.querySelector('output'));

  tagCloud.setTags(tagInputEl.value);

  addEventListener('form', 'submit', function (event) {
    event.preventDefault();
    event.stopPropagation();

    tagCloud.setTags(tagInputEl.value);
    tagCloud.showTags();
  });

  if (minFontSizeInputEl.type === 'range') {
    addEventListener('#min-font-size', 'change', function (event) {
      tagCloud.setMinFontSize(event.target.valueAsNumber);
      tagCloud.showTags();
    });

    tagCloud.setMinFontSize(minFontSizeInputEl.valueAsNumber);

    addEventListener('#max-font-size', 'change', function (event) {
      tagCloud.setMaxFontSize(event.target.valueAsNumber);
      tagCloud.showTags();
    });

    tagCloud.setMaxFontSize(maxFontSizeInputEl.valueAsNumber);

  } else {
    minFontSizeInputEl.style.display = 'none';
    maxFontSizeInputEl.style.display = 'none';
    var rangeUnsupportedMessage = 'Your browser does not support input with type "range"!';
    maxFontSizeInputEl.parentElement.appendChild(document.createTextNode(rangeUnsupportedMessage));

  }

  tagCloud.showTags();
})();