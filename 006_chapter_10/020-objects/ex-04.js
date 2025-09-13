let arr = [];

for (let i = 0; i < 5; i++) {
    arr[i] = Math.round(Math.random() * 1000);
    console.log(arr[i]);

}

const getMax = (arr) => {
    let max = arr[0];
    for (let i = 0; i < arr.length; i++) {
        max = arr[i] > max ? arr[i] : max;
    }
    return max;
}

const getMin = (arr) => {
    let min = arr[0];
    for (let i = 0; i < arr.length; i++) {
        min = arr[i] < min ? arr[i] : min;
    }
    return min;
}

console.log("\n" + `max - ${getMax(arr)}`);
console.log(`min - ${getMin(arr)}` + "\n");

const obj = {
    name: "Ben",
    age: 34,
    bruh: function () {
        console.log(`bruuuh #1 - ${this.name}`);

    }
}
obj.bruh();
obj.name = "Zavoz";

obj.bruh = () => {
    console.log(`brubrubruuuh #2 - ${obj.name}`);
};
obj.bruh();

obj.newBruh = () => console.log("new new new Bruuh " + obj.name);
obj.newBruh();

console.log("\n");

for (const key in obj) {
    // console.log(key);
    // console.log(obj[key]);
    let item = obj[key];
    if (typeof item === "function") {
        let func = item.bind(obj);
        func();
    } else {
        console.log(item);
    }
    console.log("\n");
}
