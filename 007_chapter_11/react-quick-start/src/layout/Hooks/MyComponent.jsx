// import React, { useState, useEffect } from 'react';

// const MyComponent = (props) => {
//     // №1 (объяснение структуризации массивов) - этап 1 - до структуризации
//     // const arr = [1, 2];
//     // const a = arr[0];
//     // const b = arr[1]; // три строки кода для возможности вывода

//     // №2 - структуризация массива
//     // const [a, b] = [1, 2]; // то же самое, что и выше

//     // №3 - можно работать с функциями
//     // const useMyFunc = () => [1, () => { console.log("++"); }];
//     // const [a, b] = useMyFunc();
//     // console.log(a);
//     // b();

//     // хук управления состоянием конкретного компонента
//     const [count, setCount] = useState(0);

//     // хук управления побочными/фоновыми эффектами после изменения состояний конкретного компонента
//     useEffect(() => { // callback-функция
//         document.title = `Значение ${count}`; // побочное изменение заголовка после нажатия кнопки
//     });

//     return (
//         <div>
//             <h1>{count}</h1>
//             <button onClick={() => setCount(count + 1)}>Tap {count}</button>
//         </div>
//     )
// }

// export default MyComponent;