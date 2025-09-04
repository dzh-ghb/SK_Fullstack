function getRandom(maxNum) {
    return Math.round(Math.random() * maxNum);
}
let a1 = getRandom(1_000_000);
let a2 = getRandom(1_000_000);
let a3 = getRandom(1_000_000);

let a4 = getRandom(1_000_000);
let a5 = getRandom(1_000_000);
let a6 = getRandom(1_000_000);

let a7 = getRandom(1_000_000);
let a8 = getRandom(1_000_000);
let a9 = getRandom(1_000_000);

console.log()

function getMax(n1, n2, n3) {
    let max;
    if (n1 > n2 && n1 > n3) {
        max = n1;
    } else if (n2 > n3) {
        max = n2;
    } else {
        max = n3;
    }
    return max;
}

let max1 = getMax(a1, a2, a3);
let max2 = getMax(a4, a5, a6);
let max3 = getMax(a7, a8, a9);
let max = getMax(max1, max2, max3);

console.log("a1: ".concat(a1)
    .concat("\na2: ".concat(a2))
    .concat("\na3: ".concat(a3))
    .concat("\n\na4: ".concat(a4))
    .concat("\na5: ".concat(a5))
    .concat("\na6: ".concat(a6))
    .concat("\n\na7: ".concat(a7))
    .concat("\na8: ".concat(a8))
    .concat("\na9: ".concat(a9))
    .concat("\n\nmax1: ".concat(max1))
    .concat("\nmax2: ".concat(max2))
    .concat("\nmax3: ".concat(max3))
    .concat("\n\nmax: ".concat(max)))

// // max1
// if (a1 > a2 && a1 > a3) {
//     max1 = a1;
// } else {
//     if (a2 > a3) {
//         max1 = a2;
//     } else {
//         max1 = a3;
//     }
// }
// console.log("max1: ".concat(max1));

// // max2
// if (a4 > a5 && a4 > a6) {
//     max2 = a4;
// } else {
//     if (a5 > a6) {
//         max2 = a5;
//     } else {
//         max2 = a6;
//     }
// }
// console.log("max2: ".concat(max2));

// // max3
// if (a7 > a8 && a7 > a9) {
//     max3 = a7;
// } else {
//     if (a8 > a9) {
//         max3 = a8;
//     } else {
//         max3 = a9;
//     }
// }
// console.log("max3: ".concat(max3));

// // max
// if (max1 > max2 && max1 > max3) {
//     max = max1;
// } else {
//     if (max2 > max3) {
//         max = max2;
//     } else {
//         max = max3;
//     }
// }
// console.log("\nmax: ".concat(max));
