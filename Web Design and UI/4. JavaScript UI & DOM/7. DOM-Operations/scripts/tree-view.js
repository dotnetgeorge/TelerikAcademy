(function () {
  'use strict';

  //classical inheritance
  var extend = (function () {
    function Proxy() {}

    return function (Child, Parent, childPrototypeProps) {
      Proxy.prototype = Parent.prototype;
      Child.prototype = new Proxy();
      Child.prototype.constructor = Child;

      childPrototypeProps = childPrototypeProps || {};

      for (var prop in childPrototypeProps) {
        if (childPrototypeProps.hasOwnProperty(prop)) {
          Child.prototype[prop] = childPrototypeProps[prop];
        }
      }
    };
  })();

  function toArray(list) {
    return Array.prototype.slice.call(list || []);
  }

  function BaseComponent() {
  }

  BaseComponent.prototype = {
    constructor: BaseComponent,
    getElement: function () {
      return this.el;
    },
    setElement: function (el) {
      this.el = el;
      return this;
    }
  };

  function TreeView() {
    this.setElement(document.createElement('ul'));

    this.getElement().addEventListener('click', function (event) {
      if (event.target.classList.contains('has-children')) {
        new TreeItem().setElement(event.target).toggleCollapsed();
      }
    }, false);
  }

  extend(TreeView, BaseComponent, {
    render: function () {
      document.body.appendChild(this.getElement());
    },
    getChildren: function () {
      return toArray(this.getElement().children);
    },
    setChildren: function (children) {
      children.forEach(function (child) {
        this.getElement().appendChild(child.getElement());
      }, this);

      return this;
    }
  });

  function TreeItem(name) {
    this.setElement(document.createElement('li'));
    this.setName(name);
    this.toggleCollapsed();
  }

  extend(TreeItem, BaseComponent, {
    setName: function (name) {
      this.getElement().textContent = name || '';
      return this;
    },
    setChildren: function (children) {
      var childrenContainer = document.createElement('ul');

      children.forEach(function (child) {
        this.appendChild(child.getElement());
      }, childrenContainer);

      this.getElement().appendChild(childrenContainer);

      this.getElement().classList.add('has-children');

      return this;
    },
    toggleCollapsed: function () {
      var isCollapsed = this.getElement().classList.toggle('collapsed');

      if (isCollapsed) {
        var collapsibleItems = toArray(this.getElement().querySelectorAll('.has-children'));

        collapsibleItems.forEach(function (item) {
          item.classList.add('collapsed');
        });
      }
    }
  });

  new TreeView().setChildren([
    new TreeItem('HTML'),
    new TreeItem('CSS'),
    new TreeItem('JS').setChildren([
      new TreeItem('JS1'),
      new TreeItem('JS2'),
      new TreeItem('JS Libraries').setChildren([
        new TreeItem('jQuery'),
        new TreeItem('Underscore')
      ]),
      new TreeItem('JS Frameworks'),
      new TreeItem('Win8 JS')
    ])
  ]).render();
})();