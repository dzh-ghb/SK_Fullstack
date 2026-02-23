const Pagination = ({ currentPage, totalPages, onPageChange }) => {
    const pageNumbers = []; // массив номеров отображаемых страниц
    let startPage, endPage;
    const countPagination = 8; // максимум отображаемых страниц

    // логика вычисления первой и последней отображаемых страниц
    if (totalPages <= countPagination) { // если фактическое количество страниц меньше, чем допустимо отображать
        startPage = 1;
        endPage = totalPages;
    } else {
        if (currentPage <= countPagination - 4) { // выбрана одна из первых 4-х страниц - отображение первых 8-и страниц
            startPage = 1;
            endPage = countPagination;
        } else if (currentPage + 3 >= totalPages) { // выбрана одна из последних 4-х страниц - отображение последних 8-и страниц
            startPage = totalPages - (countPagination - 1);
            endPage = totalPages;
        } else { // остальные случаи (середина) - отображение 9-и страниц (текущая + по 4-е слева и справа)
            startPage = currentPage - (Math.floor(countPagination / 2));
            endPage = currentPage + (Math.floor(countPagination / 2));
        }
    }

    // сохранение перечня отображаемых страниц в массив
    for (let i = startPage; i <= endPage; i++) {
        pageNumbers.push(i);
    }

    return (
        <nav>
            <ul className="pagination">
                {/* кнопка перехода к предыдущей странице - недоступна, если текущая страница первая */}
                <li className={`page-item ${currentPage === 1 ? "disabled" : ""}`}>
                    <button
                        className="page-link"
                        onClick={() => { onPageChange(currentPage - 1); }}
                        disabled={currentPage === 1}>
                        Предыдущая
                    </button>
                </li>

                {/* если текущая страница не первая */}
                {startPage > 1 && (
                    <>
                        {/* отображение кнопки первой страницы */}
                        <li className="page-item">
                            <button
                                className="page-link"
                                onClick={() => { onPageChange(1); }}>
                                1
                            </button>
                        </li>
                        {/* если основное окно страниц начинается с третьей - отображение "..." */}
                        {startPage > 2 &&
                            <li
                                className="page-item disabled">
                                <span className="page-link">...</span>
                            </li>
                        }
                    </>
                )}

                {/* перебор массива страниц и отображение кнопки каждого значения;
                кнопка текущей страницы неактивна, остальные случаи - кнопки перехода на страницу по индексу*/}
                {pageNumbers.map(pageIndex => (
                    <li key={pageIndex}
                        className={`page-item ${currentPage === pageIndex ? "disabled" : ""}`}>
                        {/* onPageChange(pageIndex) в App.js вызывает setCurrentPage и запускает ререндер */}
                        <button
                            className="page-link"
                            onClick={() => { onPageChange(pageIndex); }}>
                            {pageIndex}
                        </button>
                    </li>
                ))}

                {/* если текущая страница не последняя*/}
                {endPage < totalPages && (
                    <>
                        {/* если основное окно страниц заканчивается третьей с конца - отображение "..." */}
                        {endPage < totalPages - 1 &&
                            <li className="page-item disabled">
                                <span className="page-link">...</span>
                            </li>}
                        {/* отображение кнопки последней страницы */}
                        <li className="page-item">
                            <button
                                className="page-link"
                                onClick={() => { onPageChange(totalPages); }}>
                                {totalPages}
                            </button>
                        </li>
                    </>
                )}

                {/* кнопка перехода к следующей странице - недоступна, если текущая страница последняя*/}
                <li className={`page-item ${currentPage === totalPages ? "disabled" : ""}`}>
                    <button
                        className="page-link"
                        onClick={() => { onPageChange(currentPage + 1); }}
                        disabled={currentPage === totalPages}>
                        Следующая
                    </button>
                </li>
            </ul>
        </nav>
    );
}

export default Pagination;