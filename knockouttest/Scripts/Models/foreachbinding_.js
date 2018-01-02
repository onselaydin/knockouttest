var person = {
    children: [
    { firstName: "Jonnie", age: 3 },
    { firstName: "Jane", age: 5 },
    { firstName: "Richard", age: 7 },
    { firstName: "Mary", age: 9 }
    ],
    wife: {
        firstName: "Jessica",
        lastName: "Doe"
    },
    kids: ["Jonnie", "Jane", "Richard", "Mary"]
};

var PersonViewModel = function () {
    var self = this;
    self.children = person.children;
    self.wife = ko.observable(person.wife);
    self.kids = ko.observableArray(person.kids);
};

ko.applyBindings(PersonViewModel);

