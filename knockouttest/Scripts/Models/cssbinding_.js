var person = {
    favoriteColor: "red"
};

var PersonViewModel = function () {
    var self = this;
    self.favoriteColor = ko.observable(person.favoriteColor);
};
ko.applyBindings(PersonViewModel);