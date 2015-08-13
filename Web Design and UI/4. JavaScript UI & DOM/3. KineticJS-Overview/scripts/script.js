	

    (function () {
        'use strict';
        /*jslint browser: true */
        /*jslint node: true */
        /*jslint plusplus: true */
        /*jslint vars: true */
        /*global Kinetic*/
        var i,
            l,
            childIndex,
            indexOfMotherInChildren,
            indexOfFatherInChildren,
            familyMembers,
            startXCoord,
            startYCoord,
            parentName,
            index;
     
        familyMembers = [
            {
                mother: 'Maria Petrova',
                father: 'Georgi Petrov',
                children: ['Teodora Petrova', 'Peter Petrov']
            },
            {
                mother: 'Petra Stamatova',
                father: 'Todor Stamatov',
                children: ['Teodor Stamatov', 'Boris Opanov', 'Maria Petrova']
            },
            {
                mother: 'Boriana Stamatova',
                father: 'Teodor Stamatov',
                children: ['Martin Stamatov', 'Albena Dimitrova']
            },
            {
                mother: 'Albena Dimitrova',
                father: 'Ivan Dimitrov',
                children: ['Doncho Dimitrov', 'Ivaylo Dimitrov']
            },
            {
                mother: 'Donika Dimitrova',
                father: 'Doncho Dimitrov',
                children: ['Vladimir Dimitrov', 'Iliana Dobreva']
            },
            {
                mother: 'Juliana Petrova',
                father: 'Peter Petrov',
                children: ['Dimitar Petrov', 'Galina Opanova']
            },
            {
                mother: 'Iliana Dobreva',
                father: 'Delian Dobrev',
                children: ['Dimitar Dobrev', 'Galina Pundiova']
            },
            {
                mother: 'Galina Pundiova',
                father: 'Martin Pundiov',
                children: ['Dimitar Pundiov', 'Todor Pundiov']
            },
            {
                mother: 'Maria Pundiova',
                father: 'Dimitar Pundiov',
                children: ['Georgi Pundiov', 'Stoian Pundiov']
            },
            {
                mother: 'Dobrinka Pundiova',
                father: 'Georgi Pundiov',
                children: ['Pavel Pundiov', 'Marian Pundiov']
            },
            {
                mother: 'Elena Pundiova',
                father: 'Marian Pundiov',
                children: ['Kamen Pundiov', 'Hristina Ivancheva']
            },
            {
                mother: 'Hristina Ivancheva',
                father: 'Martin Ivanchev',
                children: ['Kamen Ivanchev', 'Evgeny Ivanchev']
            },
            {
                mother: 'Maria Ivancheva',
                father: 'Kamen Ivanchev',
                children: ['Ivo Ivanchev', 'Delian Ivanchev']
            },
            {
                mother: 'Nadejda Ivancheva',
                father: 'Ivo Ivanchev',
                children: ['Petio Ivanchev', 'Marin Ivanchev']
            },
            {
                mother: 'Natalia Ivancheva',
                father: 'Delian Ivanchev',
                children: ['Galina Hristova']
            },
            {
                mother: 'Galina Opanova',
                father: 'Boian Opanov',
                children: ['Maria Opanova', 'Patar Opanov']
            },
            {
                mother: 'Galina Hristova',
                father: 'Marin Hristov',
                children: ['Petar Hristov', 'Kamen Hristov', 'Ivan Hristov']
            },
            {
                mother: 'Simona Hristova',
                father: 'Kamen Hristov',
                children: ['Elena Hristova', 'Valeria Hristova']
            }
        ];
     
        for (i = 0; i < familyMembers.length; i++) {
            familyMembers[i].level = 0;
            familyMembers[i].indexWithChildren = [];
        }
     
        function increaseLevels(family) {
            var child;
            family.level++;
            if (family.indexWithChildren.length === 0) {
                return;
            }
     
            for (child in family.indexWithChildren) {
                if (family.indexWithChildren.hasOwnProperty(child)) {
                    increaseLevels(family[family.indexWithChildrens[child]]);
                }
            }
        }
     
        var familyTree = [];
        var stage = new Kinetic.Stage({
            container: 'container',
            width: 2000,
            height: 2000,
        });
     
        var layer = new Kinetic.Layer();
     
        function drawArrow(fromx, fromy, tox, toy) {
            var headlen = 15;
            var angle = Math.atan2(toy - fromy, tox - fromx);
            var line = new Kinetic.Line({
                points: [fromx, fromy, tox, toy, tox - headlen * Math.cos(angle - Math.PI / 10), toy - headlen * Math.sin(angle - Math.PI / 10), tox, toy, tox - headlen * Math.cos(angle + Math.PI / 10), toy - headlen * Math.sin(angle + Math.PI / 10)],
                stroke: "purple"
            });
     
            return line;
        }
     
        function addLines(indexOfFamily) {
            var c,
                el,
                nameOfChild,
                endXCoord,
                endYCoord;
            for (c = 0; c < familyMembers[indexOfFamily].children.length; c++) {
                nameOfChild = familyMembers[indexOfFamily].children[c];
                for (el = 0; el < familyTree.length; el++) {
                    if (familyTree[el].textArr) {
                        if (familyTree[el].textArr[0].text === nameOfChild) {
                            endXCoord = familyTree[el].getX() + 70;
                            endYCoord = familyTree[el].getY() - 5;
                            layer.add(drawArrow(startXCoord, startYCoord, endXCoord, endYCoord));
                        }
                    }
                }
            }
        }
     
        for (i = 0; i < familyMembers.length; i++) {
            for (l = 0; l < familyMembers.length; l++) {
                indexOfMotherInChildren = familyMembers[l].children.indexOf(familyMembers[i].mother);
                indexOfFatherInChildren = familyMembers[l].children.indexOf(familyMembers[i].father);
                if (indexOfMotherInChildren !== -1 || indexOfFatherInChildren !== -1) {
                    familyMembers[l].indexWithChildren.push(i);
                    familyMembers[i].level = familyMembers[l].level + 1;
                    if (familyMembers[i].indexWithChildren.length !== 0) {
                        for (childIndex in familyMembers[i].indexWithChildren) {
                            if (familyMembers[i].indexWithChildren.hasOwnProperty(childIndex)) {
                                increaseLevels(familyMembers[familyMembers[i].indexWithChildren[childIndex]]);
                            }
                        }
                    }
                }
            }
        }
     
        var text;
     
        var countEqualLevels = [];
        var prop;
        var child;
        for (i = 0; i < familyMembers.length; i++) {
            if (countEqualLevels[familyMembers[i].level] === undefined) {
                countEqualLevels[familyMembers[i].level] = 0;
            }
     
            for (prop in familyMembers[i]) {
                if (familyMembers[i].hasOwnProperty(prop)) {
                    if (prop === "mother" || prop === "father") {
                        familyTree.push(new Kinetic.Rect({
                            x: countEqualLevels[familyMembers[i].level] * 160,
                            y: familyMembers[i].level * 120,
                            width: 150,
                            height: 40,
                            fill: 'yellow',
                            stroke: 'green'
                        }));
                        text = familyMembers[i][prop];
                        familyTree.push(new Kinetic.Text({
                            x: countEqualLevels[familyMembers[i].level] * 160 + 5,
                            y: familyMembers[i].level * 120 + 5,
                            text: text,
                            fill: 'black',
                        }));
                        countEqualLevels[familyMembers[i].level]++;
                    }
                    if ((prop === "children") && (familyMembers[i].indexWithChildren.length === 0)) {
                        if (!countEqualLevels[familyMembers[i].level + 1]) {
                            countEqualLevels[familyMembers[i].level + 1] = 0;
                        }
     
                        for (child in familyMembers[i].children) {
                            if (familyMembers[i].children.hasOwnProperty(child)) {
                                familyTree.push(new Kinetic.Rect({
                                    x: countEqualLevels[familyMembers[i].level + 1] * 160,
                                    y: (familyMembers[i].level + 1) * 120,
                                    width: 150,
                                    height: 40,
                                    fill: 'yellow',
                                    stroke: 'green'
                                }));
                                text = familyMembers[i].children[child];
                                familyTree.push(new Kinetic.Text({
                                    x: countEqualLevels[familyMembers[i].level + 1] * 160 + 5,
                                    y: (familyMembers[i].level + 1) * 120 + 5,
                                    text: text,
                                    fill: 'black',
                                    fontFamily: 'Consolas'
                                }));
                                countEqualLevels[familyMembers[i].level + 1]++;
                            }
                        }
                        addLines(i);
                    }
                }
            }
        }
     
        function findElement(name) {
            var m;
            for (m = 0; m < familyMembers.length; m++) {
                if (familyMembers[m].mother === name || familyMembers[m].father === name) {
                    return m;
                }
            }
        }
     
        for (i = 0; i < familyTree.length; i++) {
            if (familyTree[i].textArr) {
                startXCoord = familyTree[i].getX() + 10;
                startYCoord = familyTree[i].getY() + 10;
                parentName = familyTree[i].textArr[0].text;
                index = findElement(parentName);
                if (index) {
                    addLines(index);
                }
            }
            layer.add(familyTree[i]);
        }
     
        stage.add(layer);
    }());

