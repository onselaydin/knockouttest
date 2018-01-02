function LibraryViewModel() {
    this.book1 = { title: 'Oliver Twist', author: 'Charles Dickens', year: 1837 };
this.book2 = { title: 'Winnie-the-Pooh', author: 'A. A. Milne', year: 1926 };
    this.book3 = { title: 'The Hobbit', author: 'J. R. R.  Tolkien', year: 1937 };
}
ko.applyBindings(new LibraryViewModel());