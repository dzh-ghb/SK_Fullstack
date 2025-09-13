function addInfoBtnClick() {
    tB.value = `Привет, ${tB.value}`;
}
function clearInfoBtnClick() {
    tB.value = ``;
}

const tB = document.getElementById("textBox");
const addInfoBtn = document.getElementById("actionBtn");
const clearInfoBtn = document.getElementById("clearBtn");

addInfoBtn.addEventListener("click", addInfoBtnClick);
clearInfoBtn.addEventListener("click", clearInfoBtnClick);

// function newNameBtnClick() {
//     const tb = document.getElementById("textBox");
//     tb.value = `Привет, ${tb.value}!`;
// }

// const btn = document.getElementById("btnAction");

// btn.addEventListener("click", newNameBtnClick);