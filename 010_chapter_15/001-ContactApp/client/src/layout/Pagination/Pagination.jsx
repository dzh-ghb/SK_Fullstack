const Pagination = ({ currentPage, totalPages, onPageChange }) => {
    const pageNumber = [];
    let startPage, endPage;
    const countPagination = 8;

    if (totalPages <= countPagination) { // если фактическое количество страниц меньше, чем хотим отображать
        startPage = 1;
        endPage = totalPages;
    } else {
        if (currentPage <= countPagination - 4) { // выбрана 1-я страница и отображаются страницы после нее
            startPage = 1;
            endPage = countPagination;
        } else if (currentPage + 4 >= totalPages) { // выбрана последняя страница
            startPage = totalPages - (countPagination - 1);
            endPage = totalPages;
        } else { // остальные случаи
            startPage = currentPage - (Math.floor(countPagination / 2));
            endPage = currentPage + (Math.floor(countPagination / 2));
        }
    }

    // сохранение перечня страниц в массив в случае, если startPage != 1 и endPage != last_page
    for (let i = startPage; i <= endPage; i++) {
        pageNumber.push(i);
    }

    return (
        <nav>
            <ul className="pagination">
                {/* кнопка перехода к предыдущей странице - недоступна, если текущая страница "1" */}
                <li className={`page-item ${currentPage === 1 ? "disabled" : ""}`}>
                    <button
                        className="page-link"
                        onClick={() => { onPageChange(currentPage - 1); }}
                        disabled={currentPage === 1}>
                        Предыдущая
                    </button>
                </li>

                {/* если текущая страница первая - отображение кнопки "1"*/}
                {startPage > 1 && (
                    <>
                        <li className="page-item">
                            <button
                                className="page-link"
                                onClick={() => { onPageChange(1); }}
                            >
                                1
                            </button>
                        </li>
                        {/* если текущая страница 3 и далее - отображение "..."*/}
                        {startPage > 2 &&
                            <li
                                className="page-item disabled">
                                <span className="page-link">...</span>
                            </li>
                        }
                    </>
                )}

                {/* если текущая страница ~ в середине;
                перебор массива страниц и выставление кнопки каждому значению,
                кнопка текущей страница неактивна, остальные случаи - добавление кнопок перехода на страницу по индексу*/}
                {pageNumber.map(pageIndex => (
                    <li key={pageIndex}
                        className={`page-item ${currentPage === pageIndex ? "disabled" : ""}`}>
                        <button
                            className="page-link"
                            onClick={() => { onPageChange(pageIndex); }}>
                            {pageIndex}
                        </button>
                    </li>
                ))}

                {/* если текущая страница последняя - отображение кнопки с номером последней страницы*/}
                {endPage < totalPages && (
                    <>
                        {/* если текущая страница 3 и далее с конца - отображение "..."*/}
                        {endPage < totalPages - 1 &&
                            <li className="page-item disabled">
                                <span className="page-link">...</span>
                            </li>}
                        <li className="page-item">
                            {/* показ кнопки последней страницы */}
                            <button
                                className="page-link"
                                onClick={() => { onPageChange(totalPages); }}>
                                {totalPages}
                            </button>
                        </li>
                    </>
                )
                }

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