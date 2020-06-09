// set the configuration for your app
const config = { databaseURL: "https://sonkkdemos.firebaseio.com/" };
firebase.initializeApp(config);
const dbRef = firebase.database().ref();

/* event-handler methods */
function page_Load() {
  getAll();
}

function lnkID_Click(code) {
  getDetails(code);
}

function btnSearch_Click() {
  var keyword = document.getElementById("txtKeyword").value.trim();
  if (keyword.length > 0)
    search(keyword);
  else
    getAll();
}

function btnAdd_Click() {
  var newBook = {
    Code: document.getElementById("txtCode").value,
    Name: document.getElementById("txtName").value,
    Author: document.getElementById("txtAuthor").value,
    Price: document.getElementById("txtPrice").value
  };
  addNew(newBook);
}

function btnUpdate_Click() {
  var newBook = {
    Code: document.getElementById("txtCode").value,
    Name: document.getElementById("txtName").value,
    Author: document.getElementById("txtAuthor").value,
    Price: document.getElementById("txtPrice").value
  };
  updateBook(newBook);
}

function btnDelete_Click() {
  if (confirm("ARE YOU SURE ?")) {
    var code = document.getElementById("txtCode").value;
    deleteBook(code);
  }
}

/* firebase methods */
function getAll() {
  dbRef.child("books").on("value", (snapshot) => {
    var books = [];
    snapshot.forEach((child) => {
      //alert(child.key);
      var book = child.val();
      books.push(book);
    });
    renderBookList(books);
  });
}

function getDetails(code) {
  dbRef.child("books").once("value", (snapshot) => {
    snapshot.forEach((child) => {
      var book = child.val();
      if (book.Code == code) {
        renderBookDetails(book);
      }
    });
  });
}

function search(keyword) {
  dbRef.child("books").once("value", (snapshot) => {
    var books = [];
    snapshot.forEach((child) => {
      var book = child.val();
      if (book.Name.includes(keyword)) {
        books.push(book);
      }
    });
    renderBookList(books);
  });
}

function addNew(newBook) {
  //dbRef.child("books").push(newBook); // auto-generated key
  dbRef.child("books/B" + newBook.Code).set(newBook); // custom key
}

function updateBook(newBook) {
  dbRef.child("books").once("value", (snapshot) => {
    snapshot.forEach((child) => {
      var book = child.val();
      if (book.Code == newBook.Code) {
        var key = child.key;
        dbRef.child("books").child(key).set(newBook);
      }
    });
  });
}

function deleteBook(code) {
  dbRef.child("books").once("value", (snapshot) => {
    snapshot.forEach((child) => {
      var book = child.val();
      if (book.Code == code) {
        var key = child.key;
        dbRef.child("books").child(key).remove();
      }
    });
  });
}

/* helper methods */
function renderBookList(books) {
  var rows = "";
  for (var book of books) {
    rows += "<tr onclick='lnkID_Click(" + book.Code + ")' style='cursor:pointer'>";
    rows += "<td>" + book.Code + "</td>";
    rows += "<td>" + book.Name + "</td>";
    rows += "<td>" + book.Author + "</td>";
    rows += "<td>" + book.Price + "</td>";
    rows += "</tr>";
  }
  var header = "<tr><th>Code</th><th>Name</th><th>Author</th><th>Price</th></tr>";
  document.getElementById("lstBooks").innerHTML = header + rows;
}

function renderBookDetails(book) {
  document.getElementById("txtCode").value = book.Code;
  document.getElementById("txtName").value = book.Name;
  document.getElementById("txtAuthor").value = book.Author;
  document.getElementById("txtPrice").value = book.Price;
}