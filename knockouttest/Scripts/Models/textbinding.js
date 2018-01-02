// Model
var person = {
    firstName: "Önsel",
    age: "42",
    about: "onsel's favorite site is <a href='http://www.onsel.net'>onselnet</a>.",
    favoricolor: "red",
    favoriurl: "http://www.onsel.net",
    favorisite: "Bla Bla",
    isMarried: true,
    wife: "blablawife"
};
// ViewModel
var PersonViewModel = function () {
    var self = this;
    self.firstName = ko.observable(person.firstName);
    self.age = ko.observable(person.age);
    self.about = ko.observable(person.about);
    self.favoricolor = ko.observable(person.favoricolor);
    self.favoriurl = ko.observable(person.favoriurl);
    self.favorisite = ko.observable(person.favorisite);
    self.isMarried = ko.observable(person.isMarried);
    self.wife = ko.observable(person.wife);
};
// Apply
ko.applyBindings(PersonViewModel);