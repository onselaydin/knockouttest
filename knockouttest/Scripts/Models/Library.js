var libraryViewModel = function () {
    var self = this;
    self.Name = ko.observable();
    self.Books = ko.observableArray();
    // Initial data
    $.ajax({
        url: '/Library/GetName',
        cache: false,
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        data: {},
        success: function (data) {
            self.Name(data);
        }
    });
    $.ajax({
        url: '/Library/GetBooks',
        cache: false,
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        data: {},
        success: function (data) {
            self.Books(data);
        }
    });
    // Remove
    self.remove = function (book) {
        var id = book.Id;
        $.ajax({
            url: '/Library/Remove', //'@Url.Action("Library","Remove")',
            cache: false,
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify({ id: id }),
            dataType: "json",
            success: function (data) {
                self.Books(data);
            }
        });
    }
    // Add
    self.add = function () {
        $.ajax({
            url: '/Library/Add', //'@Url.Action("Add")',
            cache: false,
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            data: {},
            success: function (data) {
                self.Books(data);
            }
        });
    }
    // Edit
    self.edit = function (book) {
        var id = book.Id;
        location.href = 'Library/Edit/' + id;
    }
}
// Applying bindings
ko.applyBindings(new libraryViewModel());