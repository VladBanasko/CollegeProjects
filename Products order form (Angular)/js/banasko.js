function saveData() {

    localStorage.setItem("name", document.getElementById("name").value);
    localStorage.setItem(`email`, document.getElementById(`email`).value);
    localStorage.setItem(`select`, document.getElementById(`select`).value);
    localStorage.setItem(`amount`, document.getElementById(`amount`).value);
}

function SaveAndRedirect() {
    saveData();
    window.location.href = "pages/page2.html";
}

function display() {
    document.getElementById("outname").value = localStorage.getItem(`name`);
    document.getElementById("outemail").value = localStorage.getItem(`email`);
    document.getElementById("outproduct").value = localStorage.getItem(`select`);
    document.getElementById("outnumber").value = localStorage.getItem(`amount`);
    let amount = parseInt(localStorage.getItem(`amount`));
    let total = amount * 23.99;
    document.getElementById("outtotal").value = (total * 1.13).toFixed(2);
}