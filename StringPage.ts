let optionChoice = document.getElementById("optionList") as HTMLSelectElement;
let choice;
updateChoice();
optionChoice.addEventListener("change", updateChoice);

let submitButton: HTMLButtonElement = <HTMLButtonElement>document.getElementById("submitButton");
submitButton.addEventListener("click", stringManipulator);

function updateChoice() {
    choice = optionChoice.options[optionChoice.selectedIndex].value;
}

function stringManipulator(): void {
    if (choice == "Uppercase") {
        let submitInput: HTMLInputElement = <HTMLInputElement>document.getElementById("submitInput");
        let submitted: string = submitInput.value;
        let submitOutput: HTMLDivElement = <HTMLDivElement>document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.toUpperCase();
    }
    if (choice == "Lowercase") {
        let submitInput: HTMLInputElement = <HTMLInputElement>document.getElementById("submitInput");
        let submitted: string = submitInput.value;
        let submitOutput: HTMLDivElement = <HTMLDivElement>document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.toLowerCase();
    }
    if (choice == "Length") {
        let submitInput: HTMLInputElement = <HTMLInputElement>document.getElementById("submitInput");
        let submitted: string = submitInput.value;
        let submitOutput: HTMLDivElement = <HTMLDivElement>document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.length.toString();
    }
    if (choice == "Anarchy") {
        let submitInput: HTMLInputElement = <HTMLInputElement>document.getElementById("submitInput");
        let submitted: string = submitInput.value;
        let submitOutput: HTMLDivElement = <HTMLDivElement>document.getElementById("submitOutput");
        submitOutput.innerHTML = submitted.toUpperCase() + submitted.toLowerCase() + "afsdfqdasdadsvbejbjhcbnakbdsjkhabsdjkhbk" + submitted + " Hi my name is Jerry!";
    }
}