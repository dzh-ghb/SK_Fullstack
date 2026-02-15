const ContactDetails = () => {
    return (
        <div className="container mt-5">
            <h2>Информация о контакте</h2>
            <div className="mb-3">
                <label className="form-label">Имя: </label>
                <input
                    className="form-control"
                    type="text"
                    // value = {}
                    onChange={(e) => { }}
                />
            </div>
            <div className="mb-3">
                <label className="form-label">Номер телефона: </label>
                <input
                    className="form-control"
                    type="tel"
                    // value = {}
                    onChange={(e) => { }}
                />
            </div>
            <div className="mb-3">
                <label className="form-label">E-mail: </label>
                <input
                    className="form-control"
                    type="email"
                    // value = {}
                    onChange={(e) => { }}
                />
            </div>
            <button
                className="btn btn-primary me-2"
                onClick={(e) => { }}>
                Обновить
            </button>
            <button
                className="btn btn-danger"
                onClick={(e) => { }}>
                Удалить
            </button>
            <button
                className="btn btn-secondary ms-2"
                onClick={(e) => { }}>
                Назад
            </button>
        </div>);
}

export default ContactDetails;