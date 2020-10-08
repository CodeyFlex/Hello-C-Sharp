var optionChoice = document.getElementById("optionList");
var choice;
updateChoice();
optionChoice.addEventListener("change", updateChoice);
var submitButton = document.getElementById("submitButton");
submitButton.addEventListener("click", stringManipulator);
function updateChoice() {
    choice = optionChoice.options[optionChoice.selectedIndex].value;
}
function stringManipulator() {
    if (choice == "Uppercase") {
        var submitInput = document.getElementById("submitInput");
        var submitted = submitInput.value;
        var submitOutput = document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.toUpperCase();
    }
    if (choice == "Lowercase") {
        var submitInput = document.getElementById("submitInput");
        var submitted = submitInput.value;
        var submitOutput = document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.toLowerCase();
    }
    if (choice == "Length") {
        var submitInput = document.getElementById("submitInput");
        var submitted = submitInput.value;
        var submitOutput = document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.length.toString();
    }
    if (choice == "Anarchy") {
        var submitInput = document.getElementById("submitInput");
        var submitted = submitInput.value;
        var submitOutput = document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.toUpperCase() + submitted.toLowerCase() + "afsdfqdasdadsvbejbjhcbnakbdsjkhabsdjkhbk" + submitted + " Hi my name is Jerry!";
    }
}
