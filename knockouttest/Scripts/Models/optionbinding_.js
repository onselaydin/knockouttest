var person = {
    children: ["Jonnie", "Jane", "Richard", "Mary"],
    selectedChildren: ["Jonnie", "Mary"]
};

var PersonViewModel = function () {
    var self = this;
    self.children = person.children;
    self.selectedChildren = person.selectedChildren;
};

ko.applyBindings(PersonViewModel);