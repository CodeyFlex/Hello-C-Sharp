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
    var submitInput = document.getElementById("submitInput");
    var submitted = submitInput.value;
    var submitOutput = document.getElementById("submitOutput");
    if (choice == "Uppercase") {
        submitOutput.innerHTML = submitted.toUpperCase();
    }
    if (choice == "Lowercase") {
        submitOutput.innerHTML = submitted.toLowerCase();
    }
    if (choice == "Length") {
        submitOutput.innerHTML = submitted.length.toString();
    }
    if (choice == "Anarchy") {
        submitOutput.innerHTML = submitted.toUpperCase() + submitted.toLowerCase() + "afsdfqdasdadsvbejbjhcbnakbdsjkhabsdjkhbk" + submitted + " Hi my name is Jerry!";
    }
}
