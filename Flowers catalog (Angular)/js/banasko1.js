var flowerList = new Array();

$(document).ready(function() {
    console.log("in doc ready second");


    rowID = localStorage.getItem("rowID");
    categoryList = JSON.parse(localStorage.getItem("categories"));
    flowerList = JSON.parse(localStorage.getItem("flowerList"));

    categoryName = categoryList[rowID].name;

    $("#category").html(categoryName);

    for (let flower of flowerList) {
        if (flower.category === categoryName) {
            $("#flowers").append(
                `
                <li>${flower.name}
                </li>
                <li>${flower.price}
                </li>
                <li>${flower.instructions}
                </li>
                <li>
                <img src = '../images/${flower.photo}'width="65" height="65"  >
                </li>
                `

            );

        }
    }


    loadHeader();
    loadFooter();

}); //end of document ready

function loadHeader() {
    $("header").html(`         Assignment2 / ${localStorage.getItem("name")}
                                        /${localStorage.getItem("myStudentNumber")}`);
}
//load footer
function loadFooter() {
    $("footer").html(`${localStorage.getItem("myLoginName")}/${localStorage.getItem("myCampus")}`);
}