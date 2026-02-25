import React, { useState } from "react";
import { useNavigate } from "react-router-dom";

const FormContact = (props) => {
    const [contactName, setContactName] = useState("");
    const [contactPhoneNumber, setContactPhoneNumber] = useState("");
    const [contactEmail, setContactEmail] = useState("");

    const navigate = useNavigate();

    const submit = () => {
        if (contactName.trim() === "" || contactPhoneNumber.trim() === "" || contactEmail.trim() === "") return;
        props.addContact(contactName, contactPhoneNumber, contactEmail);
        setContactName("");
        setContactPhoneNumber("");
        setContactEmail("");
    }

    return (
        <div>
            <div className="mb-3">
                <form>
                    <div className="mb-3">
                        <label className="form-label">Введите имя:</label>
                        <input className="form-control" type="text"
                            value={contactName}
                            onChange={e => setContactName(e.target.value)} />
                    </div>
                    <div className="mb-3">
                        <label className="form-label">Введите номер телефона:</label>
                        <input className="form-control" type="text"
                            value={contactPhoneNumber}
                            onChange={e => setContactPhoneNumber(e.target.value)} />
                    </div>
                    <div className="mb-3">
                        <label className="form-label">Введите адрес электронной почты:</label>
                        <textarea className="form-control" rows={1}
                            value={contactEmail}
                            onChange={e => setContactEmail(e.target.value)} />
                    </div>
                </form>
            </div>

            <div>
                <button className="btn btn-primary"
                    onClick={() => { submit() }}>
                    Добавить контакт
                </button>
                <button
                    className="btn btn-secondary ms-2"
                    onClick={() => { navigate("/"); }}>
                    Назад
                </button>
            </div>
        </div >
    );
}

export default FormContact;