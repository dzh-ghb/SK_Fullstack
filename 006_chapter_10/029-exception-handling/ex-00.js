const obj = {
    foo: "foo value",
    bar: "bar value"
}

try { // отлов ошибок
    console.log(obj.foo()); // попытка обращения к свойству как к методу
    // console.log(obj.foo);
    // } catch {
} catch (error) { // отлов ошибок | можно не указывать (error), если не нужна инфа об ошибке
    console.log("что-то пошло не так | " + error + "\n");
    // console.log(error); // может использоваться для логирования ошибок
}
finally { // блок выполняется независимо от наличия/отсутствия ошибки
    console.log("finally");
}