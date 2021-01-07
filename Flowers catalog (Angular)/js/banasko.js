var categoryArray = new Array();
var flowerArray = new Array();

class Category {
    constructor(name, pic) {
        this.name = name;
        this.pic = pic;
    }
}

class Flower {
    constructor(category, price, instructions, photo, name, productId) {
        this.category = category;
        this.price = price;
        this.instructions = instructions;
        this.photo = photo;
        this.name = name;
        this.productId = productId;
    }
}


$(document).ready(function() {
    console.log("in doc ready");
    $.ajax({

        type: "GET",
        dataType: "json",
        url: "data/A2-Flowers.json",

        success: loadJSON,
        error: function(e) { alert(`${e.status} - ${e.statusTEst}`); }
    }); //end of ajax


}); //end of doc ready

// loadJSON function
function loadJSON(data) {
    console.log(data);

    localStorage.setItem("name", data.personal.myFullName);
    localStorage.setItem("myStudentNumber", data.personal.myStudentNumber);
    localStorage.setItem("myLoginName", data.personal.myLoginName);
    localStorage.setItem("myCampus", data.personal.myCampus);

    //creation of array with categories
    for (let x = 0; x < data.categories.length; x++) {
        category = new Category(data.categories[x].category, data.categories[x].pic)
        categoryArray.push(category);
    } // end of loop
    localStorage.setItem("CategoryArray", JSON.stringify(categoryArray));


    start = data.flowerlist;
    for (let x = 0; x < start.length; x++) {
        flower = new Flower(start[x].category, start[x].price, start[x].instructions, start[x].photo, start[x].name, start[x].productId);
        flowerArray.push(flower);
    } // end of loop

    // set array of flowers ot local storage
    localStorage.setItem("flowerArray", JSON.stringify(flowerArray));

    loadHeader();
    loadFooter();
    loadMain();
} // end of loadJSON

//load main
function loadMain() {


    $("#categoryList").html("");
    $("#categoryListPic").html("");


    //set list of categories
    for (x = 0; x < categoryArray.length; x++) {
        $("#categoryList").append(
            `
	<li id='${x}' >
            <a href="pages/second.html">${categoryArray[x].name}</a>
	 </li>
	`
        );
    }
    // set pictures for categories
    for (x = 0; x < categoryArray.length; x++) {
        $("#categoryListPic").append(
            `
            <li>
            <img src = 'images/${categoryArray[x].pic}'width="65" height="65"  >
            </li>
            `

        );

    }
}


//load header
function loadHeader() {
    $("header").html(`
                Assignment2 / ${localStorage.getItem("name")}
                /${localStorage.getItem("myStudentNumber")}`);
}
//load footer
function loadFooter() {
    $("footer").html(`${localStorage.getItem("myLoginName")}/${localStorage.getItem("myCampus")}`);
}

// Save data to local storage
$(document).on("click", "#categoryList >li", function() {
    localStorage.setItem("rowID", $(this).closest("li").attr("id"));
    localStorage.setItem("flowerList", JSON.stringify(flowerArray));
    localStorage.setItem("categories", JSON.stringify(categoryArray));

});