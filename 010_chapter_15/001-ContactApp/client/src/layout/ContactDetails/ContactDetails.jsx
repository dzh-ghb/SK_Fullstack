import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import axios from "axios";

const baseApiUrl = process.env.REACT_APP_API_URL;

const ContactDetails = (props) => {
    const [contact, setContact] = useState({ name: "", phoneNumber: "", email: "" }); // хук хранения данных о контакте
    const { id } = useParams(); // хук получения идентификатора
    const navigate = useNavigate(); // хук для возврата на главную страницу

    // логика получения и обработки данных
    useEffect(() => {
        const url = `${baseApiUrl}/contacts/${id}`;
        // console.log(url);
        axios.get(url).then(
            response => setContact(response.data)
        ).catch( // переброс на главную страницу при ошибке
            () => navigate("/")
        )
    }, [id, navigate]); // второй параметр - обновляемое состояние

    // мой вариант функции удаления
    const handleRemove = () => {
        if (window.confirm("Удалить контакт?")) {
            props.deleteContact(contact.id);
            navigate("/");
        }
    }

    // вариант функции удаления из курса
    // const handleRemove = () => {
    //     const url = `${baseApiUrl}/contacts/${id}`;
    //     if (window.confirm("Удалить контакт?")) {
    //         axios.delete(url).then(
    //             navigate("/")
    //         ).catch(() =>
    //             console.log("Ошибка удаления")
    //         );
    //     }
    // }

    return (
        <div className="container mt-5">
            <h2>Информация о контакте</h2>
            <div className="mb-3">
                <label className="form-label">Имя: </label>
                <input
                    className="form-control"
                    type="text"
                    value={contact.name}
                    onChange={(e) => { }}
                />
            </div>
            <div className="mb-3">
                <label className="form-label">Номер телефона: </label>
                <input
                    className="form-control"
                    type="tel"
                    value={contact.phoneNumber}
                    onChange={(e) => { }}
                />
            </div>
            <div className="mb-3">
                <label className="form-label">E-mail: </label>
                <input
                    className="form-control"
                    type="email"
                    value={contact.email}
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
                onClick={(e) => { handleRemove(); }}>
                Удалить
            </button>
            <button
                className="btn btn-secondary ms-2"
                onClick={(e) => { navigate("/"); }}>
                Назад
            </button>
        </div>);
}

export default ContactDetails;