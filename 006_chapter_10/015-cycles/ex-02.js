let str = "hello world!";

// >h<
// >e<
// ...

// for (let index = 0; index < str.length; index++) {
//     const element = str[index];
//     console.log(`>${element}<`);
// }

// перебор значений?
for (let e of str) { //через let НЕ РЕКОМЕНДУЕТСЯ
    e = "abc";
    console.log(`>${e}<`);
}

// перебор индексов/позиций?
console.log("\n");
for (let e in str) { //через let НЕ РЕКОМЕНДУЕТСЯ
    e = 0;
    console.log(`<${str[e]}>`);
}