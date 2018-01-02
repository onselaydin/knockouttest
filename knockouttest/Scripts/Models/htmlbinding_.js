var persons = {
   
};

var PersonViewModelH = function () {
    var s= this;
    s.about = ko.observable(persons.about);
};

ko.applyBindings(PersonViewModelH,);